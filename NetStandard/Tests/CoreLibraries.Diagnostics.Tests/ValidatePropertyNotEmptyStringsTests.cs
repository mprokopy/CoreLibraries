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
    /// Tests of method <see cref="Validate.NotEmpty(string, string, string)"/>.
    /// </summary>
    [Localizable(false)]
    [TestClass]
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumented", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumentedOptional", Justification = "Tests")]
    [SuppressMessage("ReSharper", "UncatchableException", Justification = "Tests")]
    public sealed class ValidatePropertyNotEmptyStringsTests
    {
        private const string NotNullNotEmptyNotWhiteSpaceString = "Test";
        private const string WhiteSpaceString = "    ";

        /// <summary>
        /// Success test of method <see cref="Validate.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        public void NotEmptySuccessTest()
        {
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, null, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, null, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, null, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, null, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, string.Empty, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, string.Empty, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, string.Empty, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, string.Empty, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNullPropNameIsNullTest() => Validate.NotEmpty(null, null, null);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNullPropNameIsEmptyTest() => Validate.NotEmpty(null, null, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNullPropNameIsWhiteSpaceTest() => Validate.NotEmpty(null, null, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNullPropNameIsNotNullTest() => Validate.NotEmpty(null, null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsEmptyPropNameIsNullTest() => Validate.NotEmpty(null, string.Empty, null);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsEmptyPropNameIsEmptyTest() => Validate.NotEmpty(null, string.Empty, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsEmptyPropNameIsWhiteSpaceTest() => Validate.NotEmpty(null, string.Empty, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsEmptyPropNameIsNotNullTest() => Validate.NotEmpty(null, string.Empty, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsWhiteSpacePropNameIsNullTest() => Validate.NotEmpty(null, WhiteSpaceString, null);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsWhiteSpacePropNameIsEmptyTest() => Validate.NotEmpty(null, WhiteSpaceString, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsWhiteSpacePropNameIsWhiteSpaceTest() => Validate.NotEmpty(null, WhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsWhiteSpacePropNameIsNotNullTest() => Validate.NotEmpty(null, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNotNullPropNameIsNullTest() => Validate.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, null);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNotNullPropNameIsEmptyTest() => Validate.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNotNullPropNameIsWhiteSpaceTest() => Validate.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNotNullPropNameIsNotNullTest() => Validate.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNullPropNameIsNullTest() => Validate.NotEmpty(string.Empty, null, null);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNullPropNameIsEmptyTest() => Validate.NotEmpty(string.Empty, null, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNullPropNameIsWhiteSpaceTest() => Validate.NotEmpty(string.Empty, null, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNullPropNameIsNotNullTest() => Validate.NotEmpty(string.Empty, null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsEmptyPropNameIsNullTest() => Validate.NotEmpty(string.Empty, string.Empty, null);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsEmptyPropNameIsEmptyTest() => Validate.NotEmpty(string.Empty, string.Empty, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsEmptyPropNameIsWhiteSpaceTest() => Validate.NotEmpty(string.Empty, string.Empty, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsEmptyPropNameIsNotNullTest() => Validate.NotEmpty(string.Empty, string.Empty, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsWhiteSpacePropNameIsNullTest() => Validate.NotEmpty(string.Empty, WhiteSpaceString, null);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsWhiteSpacePropNameIsEmptyTest() => Validate.NotEmpty(string.Empty, WhiteSpaceString, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsWhiteSpacePropNameIsWhiteSpaceTest() => Validate.NotEmpty(string.Empty, WhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsWhiteSpacePropNameIsNotNullTest() => Validate.NotEmpty(string.Empty, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNotNullPropNameIsNullTest() => Validate.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString, null);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNotNullPropNameIsEmptyTest() => Validate.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNotNullPropNameIsWhiteSpaceTest() => Validate.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNotNullPropNameIsNotNullTest() => Validate.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNullPropNameIsNullTest() => Validate.NotEmpty(WhiteSpaceString, null, null);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNullPropNameIsEmptyTest() => Validate.NotEmpty(WhiteSpaceString, null, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNullPropNameIsWhiteSpaceTest() => Validate.NotEmpty(WhiteSpaceString, null, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNullPropNameIsNotNullTest() => Validate.NotEmpty(WhiteSpaceString, null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsEmptyPropNameIsNullTest() => Validate.NotEmpty(WhiteSpaceString, string.Empty, null);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsEmptyPropNameIsEmptyTest() => Validate.NotEmpty(WhiteSpaceString, string.Empty, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsEmptyPropNameIsWhiteSpaceTest() => Validate.NotEmpty(WhiteSpaceString, string.Empty, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsEmptyPropNameIsNotNullTest() => Validate.NotEmpty(WhiteSpaceString, string.Empty, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsWhiteSpacePropNameIsNullTest() => Validate.NotEmpty(WhiteSpaceString, WhiteSpaceString, null);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsWhiteSpacePropNameIsEmptyTest() => Validate.NotEmpty(WhiteSpaceString, WhiteSpaceString, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsWhiteSpacePropNameIsWhiteSpaceTest() => Validate.NotEmpty(WhiteSpaceString, WhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsWhiteSpacePropNameIsNotNullTest() => Validate.NotEmpty(WhiteSpaceString, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNotNullPropNameIsNullTest() => Validate.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, null);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNotNullPropNameIsEmptyTest() => Validate.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNotNullPropNameIsWhiteSpaceTest() => Validate.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNotNullPropNameIsNotNullTest() => Validate.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueNullParameterNameNullPropNameIsNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(null, null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: objectName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueNullParameterNameNullPropNameIsNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(null, null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: objectName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameIsEmptyPropNameIsNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(null, string.Empty, null);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'objectName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameIsEmptyPropNameIsNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(null, string.Empty, null);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'objectName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameIsWhiteSpacePropNameIsNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(null, WhiteSpaceString, null);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'objectName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameIsWhiteSpacePropNameIsNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(null, WhiteSpaceString, null);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'objectName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueNullParameterNameNotNullPropNameIsNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: propertyName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueNullParameterNameNotNullPropNameIsNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: propertyName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameNotNullPropNameIsEmptyExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'propertyName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameNotNullPropNameIsEmptyExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'propertyName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameNotNullSpacePropNameIsWhiteSpaceExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'propertyName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameNotNullPropNameIsWhiteSpaceExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'propertyName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyValueNullParameterNameNotNullPropNameNotNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Ошибка состояния приложения. Значение строкового свойства '{NotNullNotEmptyNotWhiteSpaceString}' объекта '{NotNullNotEmptyNotWhiteSpaceString}' не может быть неопределенным.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyValueNullParameterNameNotNullPropNameNotNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Application state error. The string property '{NotNullNotEmptyNotWhiteSpaceString}' of the '{NotNullNotEmptyNotWhiteSpaceString}' cannot be null.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyValueEmptyParameterNameNotNullPropNameNotNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Ошибка состояния приложения. Значение строкового свойства '{NotNullNotEmptyNotWhiteSpaceString}' объекта '{NotNullNotEmptyNotWhiteSpaceString}' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyValueEmptyParameterNameNotNullPropNameNotNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Application state error. The string property '{NotNullNotEmptyNotWhiteSpaceString}' of the '{NotNullNotEmptyNotWhiteSpaceString}' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyValueWhiteSpaceParameterNameNotNullPropNameNotNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Ошибка состояния приложения. Значение строкового свойства '{NotNullNotEmptyNotWhiteSpaceString}' объекта '{NotNullNotEmptyNotWhiteSpaceString}' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotEmpty(string, string, string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotEmptyValueWhiteSpaceParameterNameNotNullPropNameNotNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Application state error. The string property '{NotNullNotEmptyNotWhiteSpaceString}' of the '{NotNullNotEmptyNotWhiteSpaceString}' cannot be empty.", e.Message);
                throw;
            }
        }
    }
}
