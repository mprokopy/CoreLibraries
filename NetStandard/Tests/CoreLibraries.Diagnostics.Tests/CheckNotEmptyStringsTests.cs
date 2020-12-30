// Copyright (c) Michael Prokopyev. All rights reserved.

namespace CoreLibraries.Diagnostics.Tests
{
    #region usings section

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;

    #endregion usings section

    /// <summary>
    /// Tests of method <see cref="Check.NotEmpty(string, string)"/>.
    /// </summary>
    [Localizable(false)]
    [TestClass]
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumented", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumentedOptional", Justification = "Tests")]
    [SuppressMessage("ReSharper", "UncatchableException", Justification = "Tests")]
    public sealed class CheckNotEmptyStringsTests
    {
        private const string NotNullNotEmptyNotWhiteSpaceString = "Test";
        private const string WhiteSpaceString = "    ";

        /// <summary>
        /// Success test of method <see cref="Check.NotEmpty(string, string)"/>.
        /// </summary>
        [TestMethod]
        public void NotEmptySuccessTest()
        {
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNullTest() => Check.NotEmpty(null, null);

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsEmptyTest() => Check.NotEmpty(null, string.Empty);

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsWhiteSpaceTest() => Check.NotEmpty(null, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNotEmptyTest() => Check.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenEmptyAndArgNameIsNullTest() => Check.NotEmpty(string.Empty, null);

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenEmptyAndArgNameIsEmptyTest() => Check.NotEmpty(string.Empty, string.Empty);

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenEmptyAndArgNameIsWhiteSpaceTest() => Check.NotEmpty(string.Empty, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenEmptyAndArgNameIsNotEmptyTest() => Check.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNullTest() => Check.NotEmpty(WhiteSpaceString, null);

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsEmptyTest() => Check.NotEmpty(WhiteSpaceString, string.Empty);

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsWhiteSpaceTest() => Check.NotEmpty(WhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNotEmptyTest() => Check.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueNullParameterNameNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: argumentName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueNullParameterNameNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: argumentName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueEmptyParameterNameNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(string.Empty, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: argumentName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueEmptyParameterNameNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(string.Empty, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: argumentName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueWhiteSpaceParameterNameNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(WhiteSpaceString, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: argumentName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueWhiteSpaceParameterNameNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(WhiteSpaceString, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: argumentName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameEmptyExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(null, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'argumentName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameEmptyExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(null, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'argumentName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueEmptyParameterNameEmptyExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(string.Empty, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'argumentName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueEmptyParameterNameEmptyExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(string.Empty, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'argumentName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueWhiteSpaceParameterNameEmptyExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(WhiteSpaceString, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'argumentName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueWhiteSpaceParameterNameEmptyExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(WhiteSpaceString, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'argumentName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameWhiteSpaceExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(null, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'argumentName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameWhiteSpaceExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(null, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'argumentName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueEmptyParameterNameWhiteSpaceExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(string.Empty, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'argumentName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueEmptyParameterNameWhiteSpaceExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(string.Empty, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'argumentName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueWhiteSpaceParameterNameWhiteSpaceExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(WhiteSpaceString, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'argumentName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueWhiteSpaceParameterNameWhiteSpaceExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(WhiteSpaceString, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'argumentName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: {NotNullNotEmptyNotWhiteSpaceString}", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: {NotNullNotEmptyNotWhiteSpaceString}", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueEmptyExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual($"Строковый аргумент '{NotNullNotEmptyNotWhiteSpaceString}' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueEmptyExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual($"The string argument '{NotNullNotEmptyNotWhiteSpaceString}' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueWhiteSpaceExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual($"Строковый аргумент '{NotNullNotEmptyNotWhiteSpaceString}' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueWhiteSpaceExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual($"The string argument '{NotNullNotEmptyNotWhiteSpaceString}' cannot be empty.", e.Message);
                throw;
            }
        }
    }
}
