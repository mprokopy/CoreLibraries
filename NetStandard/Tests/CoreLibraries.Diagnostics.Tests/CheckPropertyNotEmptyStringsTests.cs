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
    /// Tests of method <see cref="Check.NotEmpty(string, string, string)"/>.
    /// </summary>
    [Localizable(false)]
    [TestClass]
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumented", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumentedOptional", Justification = "Tests")]
    [SuppressMessage("ReSharper", "UncatchableException", Justification = "Tests")]
    public sealed class CheckPropertyNotEmptyStringsTests
    {
        private const string NotNullNotEmptyNotWhiteSpaceString = "Test";
        private const string WhiteSpaceString = "    ";

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        public void NotEmptySuccessTest()
        {
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, null, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, null, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, null, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, null, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, string.Empty, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, string.Empty, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, string.Empty, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, string.Empty, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotEmpty(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNullPropNameIsNullTest() => Check.NotEmpty(null, null, null);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNullPropNameIsEmptyTest() => Check.NotEmpty(null, null, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNullPropNameIsWhiteSpaceTest() => Check.NotEmpty(null, null, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNullPropNameIsNotNullTest() => Check.NotEmpty(null, null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsEmptyPropNameIsNullTest() => Check.NotEmpty(null, string.Empty, null);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsEmptyPropNameIsEmptyTest() => Check.NotEmpty(null, string.Empty, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsEmptyPropNameIsWhiteSpaceTest() => Check.NotEmpty(null, string.Empty, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsEmptyPropNameIsNotNullTest() => Check.NotEmpty(null, string.Empty, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsWhiteSpacePropNameIsNullTest() => Check.NotEmpty(null, WhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsWhiteSpacePropNameIsEmptyTest() => Check.NotEmpty(null, WhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsWhiteSpacePropNameIsWhiteSpaceTest() => Check.NotEmpty(null, WhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsWhiteSpacePropNameIsNotNullTest() => Check.NotEmpty(null, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNotNullPropNameIsNullTest() => Check.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNotNullPropNameIsEmptyTest() => Check.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNotNullPropNameIsWhiteSpaceTest() => Check.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenNullAndArgNameIsNotNullPropNameIsNotNullTest() => Check.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNullPropNameIsNullTest() => Check.NotEmpty(string.Empty, null, null);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNullPropNameIsEmptyTest() => Check.NotEmpty(string.Empty, null, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNullPropNameIsWhiteSpaceTest() => Check.NotEmpty(string.Empty, null, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNullPropNameIsNotNullTest() => Check.NotEmpty(string.Empty, null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsEmptyPropNameIsNullTest() => Check.NotEmpty(string.Empty, string.Empty, null);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsEmptyPropNameIsEmptyTest() => Check.NotEmpty(string.Empty, string.Empty, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsEmptyPropNameIsWhiteSpaceTest() => Check.NotEmpty(string.Empty, string.Empty, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsEmptyPropNameIsNotNullTest() => Check.NotEmpty(string.Empty, string.Empty, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsWhiteSpacePropNameIsNullTest() => Check.NotEmpty(string.Empty, WhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsWhiteSpacePropNameIsEmptyTest() => Check.NotEmpty(string.Empty, WhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsWhiteSpacePropNameIsWhiteSpaceTest() => Check.NotEmpty(string.Empty, WhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsWhiteSpacePropNameIsNotNullTest() => Check.NotEmpty(string.Empty, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNotNullPropNameIsNullTest() => Check.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNotNullPropNameIsEmptyTest() => Check.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNotNullPropNameIsWhiteSpaceTest() => Check.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenIsEmptyAndArgNameIsNotNullPropNameIsNotNullTest() => Check.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNullPropNameIsNullTest() => Check.NotEmpty(WhiteSpaceString, null, null);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNullPropNameIsEmptyTest() => Check.NotEmpty(WhiteSpaceString, null, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNullPropNameIsWhiteSpaceTest() => Check.NotEmpty(WhiteSpaceString, null, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNullPropNameIsNotNullTest() => Check.NotEmpty(WhiteSpaceString, null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsEmptyPropNameIsNullTest() => Check.NotEmpty(WhiteSpaceString, string.Empty, null);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsEmptyPropNameIsEmptyTest() => Check.NotEmpty(WhiteSpaceString, string.Empty, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsEmptyPropNameIsWhiteSpaceTest() => Check.NotEmpty(WhiteSpaceString, string.Empty, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsEmptyPropNameIsNotNullTest() => Check.NotEmpty(WhiteSpaceString, string.Empty, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsWhiteSpacePropNameIsNullTest() => Check.NotEmpty(WhiteSpaceString, WhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsWhiteSpacePropNameIsEmptyTest() => Check.NotEmpty(WhiteSpaceString, WhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsWhiteSpacePropNameIsWhiteSpaceTest() => Check.NotEmpty(WhiteSpaceString, WhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsWhiteSpacePropNameIsNotNullTest() => Check.NotEmpty(WhiteSpaceString, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNotNullPropNameIsNullTest() => Check.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNotNullPropNameIsEmptyTest() => Check.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNotNullPropNameIsWhiteSpaceTest() => Check.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyThrowsWhenWhiteSpaceAndArgNameIsNotNullPropNameIsNotNullTest() => Check.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueNullParameterNameNullPropNameIsNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(null, null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: argumentName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueNullParameterNameNullPropNameIsNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(null, null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: argumentName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameIsEmptyPropNameIsNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(null, string.Empty, null);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'argumentName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameIsEmptyPropNameIsNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(null, string.Empty, null);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'argumentName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameIsWhiteSpacePropNameIsNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(null, WhiteSpaceString, null);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'argumentName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameIsWhiteSpacePropNameIsNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(null, WhiteSpaceString, null);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'argumentName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueNullParameterNameNotNullPropNameIsNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: argumentPropertyName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotEmptyValueNullParameterNameNotNullPropNameIsNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: argumentPropertyName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameNotNullPropNameIsEmptyExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'argumentPropertyName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameNotNullPropNameIsEmptyExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'argumentPropertyName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameNotNullSpacePropNameIsWhiteSpaceExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'argumentPropertyName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameNotNullPropNameIsWhiteSpaceExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'argumentPropertyName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameNotNullPropNameNotNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual($"Значение свойства '{NotNullNotEmptyNotWhiteSpaceString}' аргумента '{NotNullNotEmptyNotWhiteSpaceString}' не может быть неопределенным.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueNullParameterNameNotNullPropNameNotNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(null, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual($"The property '{NotNullNotEmptyNotWhiteSpaceString}' of the argument '{NotNullNotEmptyNotWhiteSpaceString}' cannot be null.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueEmptyParameterNameNotNullPropNameNotNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual($"Значение строкового свойства '{NotNullNotEmptyNotWhiteSpaceString}' аргумента '{NotNullNotEmptyNotWhiteSpaceString}' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueEmptyParameterNameNotNullPropNameNotNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(string.Empty, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual($"The string property '{NotNullNotEmptyNotWhiteSpaceString}' of the argument '{NotNullNotEmptyNotWhiteSpaceString}' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueWhiteSpaceParameterNameNotNullPropNameNotNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual($"Значение строкового свойства '{NotNullNotEmptyNotWhiteSpaceString}' аргумента '{NotNullNotEmptyNotWhiteSpaceString}' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotEmpty(string, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotEmptyValueWhiteSpaceParameterNameNotNullPropNameNotNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotEmpty(WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual($"The string property '{NotNullNotEmptyNotWhiteSpaceString}' of the argument '{NotNullNotEmptyNotWhiteSpaceString}' cannot be empty.", e.Message);
                throw;
            }
        }
    }
}
