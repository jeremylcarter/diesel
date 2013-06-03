﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diesel;
using NUnit.Framework;

namespace Test.Diesel
{
    [TestFixture]
    public class DieselCompilerIntegrationTest
    {
        [Test]
        public void Compile_ValidModelSource_ShouldGenerateSourceCode()
        {
            var modelSource = CodeExamples.DieselCompilerIntegrationTestCase;
            var sourceCode = DieselCompiler.Compile(modelSource);

            Assert.That(sourceCode, Is.Not.Empty);
            Assert.That(sourceCode, Is.StringContaining("namespace Employees"));
            Assert.That(sourceCode, Is.StringContaining("struct EmployeeNumber"));
            Assert.That(sourceCode, Is.StringContaining("class ChangeTelephoneNumber"));
            Assert.That(sourceCode, Is.StringContaining("namespace Clients"));
            Assert.That(sourceCode, Is.StringContaining("interface IImportService"));
            Assert.That(sourceCode, Is.StringContaining("class ImportClient"));

            AssertIncludesDefvaluetypeExamples(sourceCode);
            AssertIncludesDefcommandExamples(sourceCode);
        }

        private static void AssertIncludesDefvaluetypeExamples(string sourceCode)
        {
            Assert.That(sourceCode, Is.StringContaining("namespace TestCases.Defvaluetype"));
            Assert.That(sourceCode, Is.StringContaining("struct InvoiceNumber"));
            Assert.That(sourceCode, Is.StringContaining("struct Amount"));
            Assert.That(sourceCode, Is.StringContaining("struct LineItemNumber"));
            Assert.That(sourceCode, Is.StringContaining("struct Name"));
            Assert.That(sourceCode, Is.StringContaining("struct SourceMetadata"));
        }

        private static void AssertIncludesDefcommandExamples(string sourceCode)
        {
            Assert.That(sourceCode, Is.StringContaining("namespace TestCases.Defcommand"));
            Assert.That(sourceCode, Is.StringContaining("class PrintString"));
            Assert.That(sourceCode, Is.StringContaining("class PrintNullable"));
            Assert.That(sourceCode, Is.StringContaining("class PrintMultiple"));
            Assert.That(sourceCode, Is.StringContaining("class PrintDateTime"));
            Assert.That(sourceCode, Is.StringContaining("class PrintGuid"));
        }

    }
}
