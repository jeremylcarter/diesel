﻿using System;
using System.Linq;
using Diesel;
using Diesel.Parsing;
using Diesel.Parsing.CSharp;
using NUnit.Framework;
using Sprache;

namespace Test.Diesel.Parsing
{
    [TestFixture]
    public class GrammarTest
    {

        [Test]
        public void Keyword_ValidName_ShouldParse()
        {
            var actual = Grammar.Keyword().Parse(":foo");
            Assert.That(actual.Name, Is.EqualTo("foo"));
        }

        [Test]
        public void Keyword_SpecificNameOverloadSameName_ShouldParse()
        {
            var actual = Grammar.Keyword("foo").Parse(":foo");
            Assert.That(actual.Name, Is.EqualTo("foo"));
        }

        [Test]
        public void Keyword_SpecificNameOverloadOtherKeyword_ShouldNotParse()
        {
            var actual = Grammar.Keyword("foo").TryParse(":bar");
            Assert.That(actual.WasSuccessful, Is.False);
        }


        [Test]
        public void ValueTypeDeclaration_JustNameNoType_ShouldParseName()
        {
            var actual = Grammar.ValueTypeDeclaration.Parse("(defvaluetype EmployeeNumber)");
            Assert.That(actual.Name, Is.EqualTo("EmployeeNumber"));
        }

        [Test]
        public void ValueTypeDeclaration_JustNameNoType_ShouldNotSetPropertyName()
        {
            var actual = Grammar.ValueTypeDeclaration.Parse("(defvaluetype EmployeeNumber)");
            Assert.That(actual.Properties.Single().Name, Is.Null);
        }

        [Test]
        public void ValueTypeDeclaration_JustNameNoType_ShouldSetNoPropertyType()
        {
            var actual = Grammar.ValueTypeDeclaration.Parse("(defvaluetype EmployeeNumber)");
            var actualProperty = actual.Properties.Single();
            Assert.That(actualProperty.Type, Is.Null);
        }

        [Test]
        public void ValueTypeDeclaration_NameAndExplicitType_ShouldSetType()
        {
            var actual = Grammar.ValueTypeDeclaration.Parse("(defvaluetype GradePointAverage decimal)");
            var actualProperty = actual.Properties.Single();
            Assert.That(actualProperty.Type, Is.EqualTo(AstSimpleType<Decimal>()));
        }

        [Test]
        public void ValueTypeDeclaration_NameAndExplicitNullableType_ShouldSetType()
        {
            var actual = Grammar.ValueTypeDeclaration.Parse("(defvaluetype Optional int?)");
            var actualProperty = actual.Properties.Single();
            Assert.That(actualProperty.Type, Is.EqualTo(AstNullableOf<int>()));
        }

        private NullableType AstNullableOf<T>()
        {
            return new NullableType(new SimpleType(typeof(T)));
        }

        private static SimpleType AstSimpleType<T>()
        {
            return new SimpleType(typeof(T));
        }


        private static ArrayType AstArrayOfSimpleType<T>()
        {
            return new ArrayType(new SimpleType(typeof (T)), 
                new RankSpecifiers(new[] {new RankSpecifier(1)}));
        }

        private static ArrayType AstArrayOfString()
        {
            return new ArrayType(new StringReferenceType(), 
                new RankSpecifiers(new[] { new RankSpecifier(1) }));
        }

        private static TypeNameTypeNode AstGuidType()
        {
            return new TypeNameTypeNode(new TypeName(typeof(Guid).Name));
        }

        private static StringReferenceType AstStringType()
        {
            return new StringReferenceType();
        }

        [Test]
        public void ValueTypeDeclaration_NameAndExplicitSystemValueType_ShouldSetType()
        {
            var actual = Grammar.ValueTypeDeclaration.Parse("(defvaluetype AggregateRootId Guid)");
            var actualProperty = actual.Properties.Single();
            Assert.That(actualProperty.Type, Is.EqualTo(AstGuidType()));
        }

        [Test]
        public void ValueTypeDeclaration_NameAndExplicitType_ShouldNotSetPropertyName()
        {
            var actual = Grammar.ValueTypeDeclaration.Parse("(defvaluetype GradePointAverage Decimal)");
            var actualProperty = actual.Properties.Single();
            Assert.That(actualProperty.Name, Is.Null);
        }

        [Test]
        public void ValueTypeDeclaration_ComplexWithSingleProperty_ShouldSetNameAndType()
        {
            var actual = Grammar.ValueTypeDeclaration.Parse("(defvaluetype BookSize (int Pages))");
            var actualProperty = actual.Properties.Single();
            Assert.That(actualProperty.Name, Is.EqualTo("Pages"));
            Assert.That(actualProperty.Type, Is.EqualTo(AstSimpleType<int>()));
        }

        [Test]
        public void ValueTypeDeclaration_ComplexWithMultipleProperties_ShouldSetNamesAndTypes()
        {
            var actual = Grammar.ValueTypeDeclaration.Parse("(defvaluetype BookSize (int Pages, int Chapters))");
            var actualProperties = actual.Properties.ToList();
            Assert.That(actualProperties[0].Name, Is.EqualTo("Pages"));
            Assert.That(actualProperties[0].Type, Is.EqualTo(AstSimpleType<int>()));
            Assert.That(actualProperties[1].Name, Is.EqualTo("Chapters"));
            Assert.That(actualProperties[1].Type, Is.EqualTo(AstSimpleType<int>()));
        }

        [Test]
        public void ValueTypeDeclaration_ComplexWithNullableProperty_ShouldSetTypes()
        {
            var actual = Grammar.ValueTypeDeclaration.Parse("(defvaluetype BookSize (int Pages, int? Chapters))");
            var actualProperties = actual.Properties.ToList();
            Assert.That(actualProperties[1].Type, Is.EqualTo(AstNullableOf<int>()));
        }

        [Test]
        public void Namespace_SinglePartName_ShouldParse()
        {
            var actual = Grammar.Namespace.Parse("(namespace Administration)");
            Assert.That(actual.Name.Name, Is.EqualTo("Administration"));
        }

        [Test]
        public void Namespace_MultiPartName_ShouldParse()
        {
            var actual = Grammar.Namespace.Parse("(namespace Administration.Client)");
            Assert.That(actual.Name.Name, Is.EqualTo("Administration.Client"));
        }

        [Test]
        public void Namespace_NoDeclarations_ShouldHaveEmptyList()
        {
            var actual = Grammar.Namespace.Parse("(namespace Administration)");
            Assert.That(actual.Declarations, Is.Not.Null);
            Assert.That(actual.Declarations, Is.Empty);
        }

        [Test]
        public void Namespace_WithSingleDeclaration_ShouldParseDeclaration()
        {
            var actual = Grammar.Namespace.Parse("(namespace Administration.Client" +
                                                 "  (defvaluetype ClientId))");
            Assert.That(actual.Name.Name, Is.EqualTo("Administration.Client"));
            var singleDeclaration = actual.Declarations.Single();
            Assert.That(singleDeclaration.Name, Is.EqualTo("ClientId"));
            Assert.That(singleDeclaration, Is.TypeOf<ValueTypeDeclaration>());
        }

        [Test]
        public void Namespace_WithMultipleDeclarations_ShouldParseDeclarations()
        {
            var actual = Grammar.Namespace.Parse("(namespace Administration.Client" +
                                                 "  (defvaluetype ClientId)" +
                                                 "  (defvaluetype UserId)" +
                                                 ")");

            
            var clientIdDeclaration = actual.Declarations.SingleOrDefault(x => x.Name == "ClientId");
            var userIdDeclaration = actual.Declarations.SingleOrDefault(x => x.Name == "UserId");
            Assert.That(clientIdDeclaration, Is.Not.Null);
            Assert.That(userIdDeclaration, Is.Not.Null);
        }

        [Test]
        public void Namespace_DeclarationsOfMultipleTypes_ShouldParseDeclarations()
        {
            var actual = Grammar.Namespace.Parse("(namespace Administration.Client" +
                                                 "  (defvaluetype ClientId)" +
                                                 "  (defcommand ImportEmployee (int EmployeeNumber, string FirstName, string LastName))" +
                                                 "  (defdomainevent EmployeeImported (Guid Id, int EmployeeNumber, string FirstName, string LastName))" +
                                                 ")");
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual.Declarations.Single(x => x.Name == "ClientId"), Is.Not.Null);
            Assert.That(actual.Declarations.Single(x => x.Name == "ImportEmployee"), Is.Not.Null);
        }


        [Test]
        public void CommandDeclaration_ValidDeclaration_ShouldParseName()
        {
            var actual = Grammar.CommandDeclaration.Parse("(defcommand ImportEmployee)");
            Assert.That(actual.Name, Is.EqualTo("ImportEmployee"));
        }

        [Test]
        public void CommandDeclaration_ValidDeclarationNoProperties_ShouldHaveNoProperties()
        {
            var actual = Grammar.CommandDeclaration.Parse("(defcommand ImportEmployee)");
            Assert.That(actual.Properties, Is.Empty);
        }


        [Test]
        public void PropertyDeclaration_SingleProperty_ShouldSetNameAndType()
        {
            var actual = Grammar.PropertyDeclaration.Parse("int EmployeeNumber");
            Assert.That(actual.Name, Is.EqualTo("EmployeeNumber"));
            Assert.That(actual.Type, Is.EqualTo(new SimpleType(typeof(int))));
        }

        [Test]
        public void PropertyDeclaration_NullableType_ShouldSetType()
        {
            var actual = Grammar.PropertyDeclaration.Parse("int? Optional");
            Assert.That(actual.Type, Is.EqualTo(AstNullableOf<int>()));
        }

        [Test]
        public void PropertyDeclaration_ArrayTypeOfValueType_ShouldSetType()
        {
            var actual = Grammar.PropertyDeclaration.Parse("int[] Roles");
            Assert.That(actual.Type, Is.EqualTo(AstArrayOfSimpleType<int>()));
        }

        [Test]
        public void PropertyDeclaration_ArrayTypeOfValueType2D_ShouldSetType()
        {
            var actual = Grammar.PropertyDeclaration.Parse("int[,] Map");
            Assert.That(actual.Type, Is.EqualTo(new ArrayType(new SimpleType(typeof(int)),
                new RankSpecifiers(new[]{new RankSpecifier(2)}))));
        }

        [Test]
        public void PropertyDeclaration_ArrayTypeOfReferenceType_ShouldSetType()
        {
            var actual = Grammar.PropertyDeclaration.Parse("string[] Names");
            Assert.That(actual.Type, Is.EqualTo(AstArrayOfString()));
        }

        [Test]
        public void PropertyDeclaration_ArrayTypeOfNamedType_ShouldSetType()
        {
            var actual = Grammar.PropertyDeclaration.Parse("MyDomain.Name[] Names");
            Assert.That(actual.Type, Is.InstanceOf(typeof (ArrayType)));
            var actualType = ((ArrayType) actual.Type).Type;
            Assert.That(actualType, Is.EqualTo(new TypeNameTypeNode(new TypeName("MyDomain.Name"))));
        }

        [Test]
        public void PropertyDeclaration_UnqualifiedSystemTypeDateTime_ShouldSetType()
        {
            var actual = Grammar.PropertyDeclaration.Parse("DateTime OccurredOn");
            Assert.That(actual.Type, Is.EqualTo(new TypeNameTypeNode(new TypeName("DateTime"))));
        }

        [Test]
        public void PropertyDeclaration_UnqualifiedSystemTypeGuid_ShouldSetType()
        {
            var actual = Grammar.PropertyDeclaration.Parse("Guid CommandId");
            Assert.That(actual.Type, Is.EqualTo(new TypeNameTypeNode(new TypeName("Guid"))));
        }




        [Test]
        public void CommandDeclaration_SingleProperty_ShouldParseProperty()
        {
            var actual = Grammar.CommandDeclaration.Parse("(defcommand ImportEmployee (int EmployeeNumber))");
            Assert.That(actual.Properties, Is.Not.Null);
            var property = actual.Properties.Single();
            Assert.That(property.Name, Is.EqualTo("EmployeeNumber"));
            Assert.That(property.Type, Is.EqualTo(AstSimpleType<int>()));
        }


        [Test]
        public void CommandDeclaration_MultipleProperties_ShouldParseProperties()
        {
            var actual = Grammar.CommandDeclaration.Parse("(defcommand ImportEmployee (int EmployeeNumber, string FirstName, string LastName))");
            var properties = actual.Properties.ToList();
            AssertPropertyEquals(properties[0], "EmployeeNumber", AstSimpleType<int>());
            AssertPropertyEquals(properties[1], "FirstName", AstStringType());
            AssertPropertyEquals(properties[2], "LastName", AstStringType());
        }

        [Test]
        public void CommandDeclaration_PropertyWithArrayType_ShouldParseProperties()
        {
            var actual = Grammar.CommandDeclaration.Parse("(defcommand ImportEmployeeRoles (int EmployeeNumber, int[] RoleIds))");
            var properties = actual.Properties.ToList();
            AssertPropertyEquals(properties[0], "EmployeeNumber", AstSimpleType<int>());
            AssertPropertyEquals(properties[1], "RoleIds", AstArrayOfSimpleType<int>());
        }


        private void AssertPropertyEquals(PropertyDeclaration actual, string expectedName, TypeNode expectedType)
        {
            Assert.That(actual.Name, Is.EqualTo(expectedName));
            Assert.That(actual.Type, Is.EqualTo(expectedType));
        }

        [Test]
        public void ApplicationServiceDeclaration_NoCommands_ShouldNotParse()
        {
            var result = Grammar.ApplicationServiceDeclaration.TryParse("(defapplicationservice ImportService)");
            Assert.That(result.WasSuccessful, Is.False);
        }

        [Test]
        public void ApplicationServiceDeclaration_SingleCommand_ShouldParseName()
        {
            var actual = Grammar.ApplicationServiceDeclaration.Parse("(defapplicationservice ImportService" +
                                                                     "  (defcommand ImportEmployee (int EmployeeNumber, string Name)))");
            Assert.That(actual.Name, Is.EqualTo("ImportService"));
        }


        [Test]
        public void ApplicationServiceDeclaration_MultipleCommands_ShouldParseCommands()
        {
            var actual = Grammar.ApplicationServiceDeclaration.Parse("(defapplicationservice ImportService" +
                                                                     "  (defcommand ImportEmployee (int EmployeeNumber, string Name))" +
                                                                     "  (defcommand ImportClient (int ClientNumber, string Name))" +
                                                                     ")");
            var commands = actual.Commands.ToList();
            Assert.That(commands.Count, Is.EqualTo(2));
            Assert.That(commands[0].Name, Is.EqualTo("ImportEmployee"));
            Assert.That(commands[1].Name, Is.EqualTo("ImportClient"));
        }

        [Test]
        public void DomainEventDeclaration_MultipleProperties_ShouldParseProperties()
        {
            var actual = Grammar.DomainEventDeclaration.Parse("(defdomainevent EmployeeImported (Guid Id, int EmployeeNumber, string FirstName, string LastName))");
            var properties = actual.Properties.ToList();
            AssertPropertyEquals(properties[0], "Id", AstGuidType());
            AssertPropertyEquals(properties[1], "EmployeeNumber", AstSimpleType<int>());
            AssertPropertyEquals(properties[2], "FirstName", AstStringType());
            AssertPropertyEquals(properties[3], "LastName", AstStringType());
        }


        [Test]
        public void TypeDeclaration_ValueTypeDeclaration_ShouldBeAccepted()
        {
            var actual = Grammar.TypeDeclaration.TryParse("(defvaluetype EmployeeNumber)");
            Assert.True(actual.WasSuccessful);
        }

        [Test]
        public void TypeDeclaration_CommandDeclaration_ShouldBeAccepted()
        {
            var actual = Grammar.TypeDeclaration.TryParse("(defcommand ImportEmployee (int EmployeeNumber, String Name))");
            Assert.True(actual.WasSuccessful);
        }

        [Test]
        public void TypeDeclaration_DomainEventDeclaration_ShouldBeAccepted()
        {
            var actual = Grammar.TypeDeclaration.TryParse("(defdomainevent EmployeeImported (Guid Id, int EmployeeNumber, String Name))");
            Assert.True(actual.WasSuccessful);
        }

        [Test]
        public void ConventionDeclarations_Valid_ShouldParse()
        {
            var actual = Grammar.ConventionsDeclaration.Parse(
                    "(defconventions :domainevents {:inherit [SomeNamespace.IDomainEvent]})");
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual.DomainEventConventions, Is.Not.Null);
            Assert.That(actual.DomainEventConventions, Is.Not.Null);
        }


        [Test]
        public void AbstractSyntaxTree_MultipleNamespaces_ShouldParseNamespaces()
        {
            var actual =
                Grammar.AbstractSyntaxTree.Parse(
                    "(namespace Foo (defvaluetype FooId)) " +
                    "(namespace Bar (defcommand Say (string message)))");
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual.Namespaces.Count(), Is.EqualTo(2));
        }

        [Test]
        public void AbstractSyntaxTree_WithConventions_ShouldParseConventions()
        {
            var actual =
                Grammar.AbstractSyntaxTree.Parse(
                    "(defconventions :domainevents {:inherit [SomeName.IDomainEvent]})" +
                    "(namespace Bar (defcommand Say (string message)))");
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual.Conventions, Is.Not.Null);
            Assert.That(actual.Namespaces.Count(), Is.EqualTo(1));
        }

        
        [Test]
        public void Everything_ValidAstFollowedByInvalidSource_ShouldNotParse()
        {
            var actual = Grammar.Everything.TryParse("(namespace Foo (defvaluetype FooId)) )");
            Assert.False(actual.WasSuccessful);
        }


        [Test]
        public void Everything_ValidAst_ShouldParse()
        {
            var actual = Grammar.Everything.TryParse("(namespace Foo (defvaluetype FooId))");
            Assert.True(actual.WasSuccessful);
        }

    }
}