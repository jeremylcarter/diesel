﻿using System;
using System.Linq;
using Diesel;
using Diesel.Parsing;
using Diesel.Parsing.CSharp;
using Diesel.Transformations;
using NUnit.Framework;

namespace Test.Diesel.Transformations
{
    [TestFixture]
    public class ApplyDefaultsTest
    {
        [Test]
        public void ApplyDefaults_ValueTypeDeclarationWithNullType_ShouldSetTypeToInt32()
        {
            var valueTypeDeclaration = new ValueTypeDeclaration("EmployeeNumber",
                                                                new[] {new PropertyDeclaration(null, null)});
            var actualDeclaration =
                (ValueTypeDeclaration) ApplyDefaultsOnSingleDeclarationNamespace(valueTypeDeclaration);
            Assert.That(actualDeclaration.Name, Is.EqualTo(valueTypeDeclaration.Name));
            Assert.That(actualDeclaration.Properties.Single().Type, Is.EqualTo(new SimpleType(typeof (Int32))));
        }

        [Test]
        public void ApplyDefaults_ValueTypeDeclarationWithNullPropertyName_ShouldSetPropertyName()
        {
            var valueTypeDeclaration = new ValueTypeDeclaration("EmployeeNumber",
                                                                new[] { new PropertyDeclaration(null, null) });
            var actualDeclaration =
                (ValueTypeDeclaration)ApplyDefaultsOnSingleDeclarationNamespace(valueTypeDeclaration);
            Assert.That(actualDeclaration.Properties.Single().Name, Is.EqualTo("Value"));
        }

        [Test]
        public void ApplyDefaults_ValueTypeDeclarationWithType_ShouldNotModifyNameOrType()
        {
            var valueTypeDeclaration = new ValueTypeDeclaration("Name",
                                                                new[] {new PropertyDeclaration("FullName", new StringReferenceType())});
            var actualDeclaration =
                (ValueTypeDeclaration) ApplyDefaultsOnSingleDeclarationNamespace(valueTypeDeclaration);
            var actualProperty = actualDeclaration.Properties.Single();
            Assert.That(actualProperty.Name, Is.EqualTo("FullName"));
            Assert.That(actualProperty.Type, Is.EqualTo(new StringReferenceType()));
        }

        private static ITypeDeclaration ApplyDefaultsOnSingleDeclarationNamespace(TypeDeclaration valueTypeDeclaration)
        {
            var input = new AbstractSyntaxTree(null,
                new[]
                    {
                        new Namespace(new NamespaceName("Test"),
                                      new[] {valueTypeDeclaration})
                    });
            var actual = ModelTransformations.Transform(input);
            var actualDeclaration = (ValueTypeDeclaration) actual.AbstractSyntaxTree.Namespaces.Single().Declarations.Single();
            return actualDeclaration;
        }
    }
}