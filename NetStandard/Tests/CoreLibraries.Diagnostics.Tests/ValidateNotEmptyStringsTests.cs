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
    /// Tests of method <see cref="Validate.NotEmpty(string, string)"/>.
    /// </summary>
    [Localizable(false)]
    [TestClass]
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumented", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumentedOptional", Justification = "Tests")]
    [SuppressMessage("ReSharper", "UncatchableException", Justification = "Tests")]
    public sealed class ValidateNotEmptyStringsTests
    {
        private const string NotNullNotEmptyNotWhiteSpaceString = "Test";
        private const string WhiteSpaceString = "    ";

        /// <summary>
        /// Success test of method <see cref="Validate.NotEmpty(string, string)"/>.
        /// </summary>
        [TestMethod]
        public void NotEmptySuccessTest()
        {
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNullTest() => Validate.NotEmpty(null, null);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsEmptyTest() => Validate.NotEmpty(null, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsWhiteSpaceTest() => Validate.NotEmpty(null, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNotEmptyTest() => Validate.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenEmptyAndArgNameIsNullTest() => Validate.NotEmpty(string.Empty, null);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenEmptyAndArgNameIsEmptyTest() => Validate.NotEmpty(string.Empty, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenEmptyAndArgNameIsWhiteSpaceTest() => Validate.NotEmpty(string.Empty, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyThrowsWhenEmptyAndArgNameIsNotEmptyTest() => Validate.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNullTest() => Validate.NotEmpty(WhiteSpaceString, null);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsEmptyTest() => Validate.NotEmpty(WhiteSpaceString, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsWhiteSpaceTest() => Validate.NotEmpty(WhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNotEmptyTest() => Validate.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueNullParameterNameNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: objectName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueNullParameterNameNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: objectName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueEmptyParameterNameNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(string.Empty, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: objectName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueEmptyParameterNameNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(string.Empty, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: objectName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueWhiteSpaceParameterNameNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(WhiteSpaceString, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: objectName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueWhiteSpaceParameterNameNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(WhiteSpaceString, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: objectName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameEmptyExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(null, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'objectName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameEmptyExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(null, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'objectName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueEmptyParameterNameEmptyExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(string.Empty, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'objectName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueEmptyParameterNameEmptyExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(string.Empty, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'objectName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueWhiteSpaceParameterNameEmptyExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(WhiteSpaceString, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'objectName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueWhiteSpaceParameterNameEmptyExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(WhiteSpaceString, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'objectName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameWhiteSpaceExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(null, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'objectName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameWhiteSpaceExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(null, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'objectName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueEmptyParameterNameWhiteSpaceExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(string.Empty, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'objectName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueEmptyParameterNameWhiteSpaceExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(string.Empty, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'objectName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueWhiteSpaceParameterNameWhiteSpaceExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(WhiteSpaceString, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'objectName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueWhiteSpaceParameterNameWhiteSpaceExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(WhiteSpaceString, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'objectName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyValueNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Ошибка состояния приложения. Строка '{NotNullNotEmptyNotWhiteSpaceString}' не может быть неопределенной.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyValueNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Application state error. The string '{NotNullNotEmptyNotWhiteSpaceString}' cannot be null.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyValueEmptyExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Ошибка состояния приложения. Строка '{NotNullNotEmptyNotWhiteSpaceString}' не может быть пустой.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyValueEmptyExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Application state error. The string '{NotNullNotEmptyNotWhiteSpaceString}' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyValueWhiteSpaceExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Ошибка состояния приложения. Строка '{NotNullNotEmptyNotWhiteSpaceString}' не может быть пустой.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyValueWhiteSpaceExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Application state error. The string '{NotNullNotEmptyNotWhiteSpaceString}' cannot be empty.", e.Message);
                throw;
            }
        }
    }
}
