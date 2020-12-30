// Copyright (c) Michael Prokopyev. All rights reserved.

namespace CoreLibraries.Diagnostics.Tests
{
    #region usings section

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Properties;
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;

    #endregion usings section

    /// <summary>
    /// Tests of methods <see cref="Check.NotNull{T}(T, string, string)"/> and <see cref="Check.NotNull{T}(T?, string, string)"/>.
    /// </summary>
    [Localizable(false)]
    [TestClass]
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumented", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumentedOptional", Justification = "Tests")]
    [SuppressMessage("ReSharper", "UncatchableException", Justification = "Tests")]
    public sealed class CheckPropertyNotNullTests
    {
        private const string NotNullNotEmptyNotWhiteSpaceString = "Test";
        private const string WhiteSpaceString = "    ";

        /// <summary>
        /// Success test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        public void NotNullReferenceTypeSuccessTest()
        {
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, null, null));
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, null, string.Empty));
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, null, WhiteSpaceString));
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, null, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, string.Empty, null));
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, string.Empty, string.Empty));
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, string.Empty, WhiteSpaceString));
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, string.Empty, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, WhiteSpaceString, null));
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, WhiteSpaceString, string.Empty));
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, WhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, NotNullNotEmptyNotWhiteSpaceString, null));
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, NotNullNotEmptyNotWhiteSpaceString, string.Empty));
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, null, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, null, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, null, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, null, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, string.Empty, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, string.Empty, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, string.Empty, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, string.Empty, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));
        }

        /// <summary>
        /// Success test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        public void NotNullValueTypeSuccessTest()
        {
            Assert.AreEqual(0, Check.NotNull((int?)0, null, null));
            Assert.AreEqual(0, Check.NotNull((int?)0, null, string.Empty));
            Assert.AreEqual(0, Check.NotNull((int?)0, null, WhiteSpaceString));
            Assert.AreEqual(0, Check.NotNull((int?)0, null, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(0, Check.NotNull((int?)0, string.Empty, null));
            Assert.AreEqual(0, Check.NotNull((int?)0, string.Empty, string.Empty));
            Assert.AreEqual(0, Check.NotNull((int?)0, string.Empty, WhiteSpaceString));
            Assert.AreEqual(0, Check.NotNull((int?)0, string.Empty, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(0, Check.NotNull((int?)0, WhiteSpaceString, null));
            Assert.AreEqual(0, Check.NotNull((int?)0, WhiteSpaceString, string.Empty));
            Assert.AreEqual(0, Check.NotNull((int?)0, WhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(0, Check.NotNull((int?)0, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(0, Check.NotNull((int?)0, NotNullNotEmptyNotWhiteSpaceString, null));
            Assert.AreEqual(0, Check.NotNull((int?)0, NotNullNotEmptyNotWhiteSpaceString, string.Empty));
            Assert.AreEqual(0, Check.NotNull((int?)0, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(0, Check.NotNull((int?)0, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));
        }

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNullPropNameIsNullTest() => Check.NotNull<string>(null, null, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNullPropNameIsNotNullTest() => Check.NotNull<string>(null, null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNullPropNameEmptyTest() => Check.NotNull<string>(null, null, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNullPropNameWhiteSpaceTest() => Check.NotNull<string>(null, null, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNotNullPropNameIsNullTest() => Check.NotNull<string>(null, NotNullNotEmptyNotWhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNotNullPropNameIsNotNullTest() => Check.NotNull<string>(null, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNotNullPropNameEmptyTest() => Check.NotNull<string>(null, NotNullNotEmptyNotWhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNotNullPropNameWhiteSpaceTest() => Check.NotNull<string>(null, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsEmptyPropNameIsNullTest() => Check.NotNull<string>(null, string.Empty, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsEmptyPropNameIsNotNullTest() => Check.NotNull<string>(null, string.Empty, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsEmptyPropNameEmptyTest() => Check.NotNull<string>(null, string.Empty, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsEmptyPropNameWhiteSpaceTest() => Check.NotNull<string>(null, string.Empty, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsWhiteSpacePropNameIsNullTest() => Check.NotNull<string>(null, WhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsWhiteSpacePropNameIsNotNullTest() => Check.NotNull<string>(null, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsWhiteSpacePropNameEmptyTest() => Check.NotNull<string>(null, WhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsWhiteSpacePropNameWhiteSpaceTest() => Check.NotNull<string>(null, WhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNullPropNameIsNullTest() => Check.NotNull(null as object, null, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNullPropNameIsNotNullTest() => Check.NotNull(null as object, null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNullPropNameEmptyTest() => Check.NotNull(null as object, null, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNullPropNameWhiteSpaceTest() => Check.NotNull(null as object, null, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNotNullPropNameIsNullTest() => Check.NotNull(null as object, NotNullNotEmptyNotWhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNotNullPropNameIsNotNullTest() => Check.NotNull(null as object, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNotNullPropNameEmptyTest() => Check.NotNull(null as object, NotNullNotEmptyNotWhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNotNullPropNameWhiteSpaceTest() => Check.NotNull(null as object, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsEmptyPropNameIsNullTest() => Check.NotNull(null as object, string.Empty, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsEmptyPropNameIsNotNullTest() => Check.NotNull(null as object, string.Empty, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsEmptyPropNameEmptyTest() => Check.NotNull(null as object, string.Empty, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsEmptyPropNameWhiteSpaceTest() => Check.NotNull(null as object, string.Empty, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsWhiteSpacePropNameIsNullTest() => Check.NotNull(null as object, WhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsWhiteSpacePropNameIsNotNullTest() => Check.NotNull(null as object, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsWhiteSpacePropNameEmptyTest() => Check.NotNull(null as object, WhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsWhiteSpacePropNameWhiteSpaceTest() => Check.NotNull(null as object, WhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNullPropNameIsNullTest() => Check.NotNull((int?)null, null, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNullPropNameIsNotNullTest() => Check.NotNull((int?)null, null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNullPropNameEmptyTest() => Check.NotNull((int?)null, null, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNullPropNameWhiteSpaceTest() => Check.NotNull((int?)null, null, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNotNullPropNameIsNullTest() => Check.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNotNullPropNameIsNotNullTest() => Check.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNotNullPropNameEmptyTest() => Check.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNotNullPropNameWhiteSpaceTest() => Check.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsEmptyPropNameIsNullTest() => Check.NotNull((int?)null, string.Empty, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsEmptyPropNameIsNotNullTest() => Check.NotNull((int?)null, string.Empty, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsEmptyPropNameEmptyTest() => Check.NotNull((int?)null, string.Empty, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsEmptyPropNameWhiteSpaceTest() => Check.NotNull((int?)null, string.Empty, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsWhiteSpacePropNameIsNullTest() => Check.NotNull((int?)null, WhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsWhiteSpacePropNameIsNotNullTest() => Check.NotNull((int?)null, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsWhiteSpacePropNameEmptyTest() => Check.NotNull((int?)null, WhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsWhiteSpacePropNameWhiteSpaceTest() => Check.NotNull((int?)null, WhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullParameterNameIsNullPropNameIsNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotNull((int?)null, null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: argumentName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullParameterNameIsNullPropNameIsNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotNull((int?)null, null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: argumentName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullParameterNameEmptyPropNameIsNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotNull((int?)null, string.Empty, null);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(Resources.ArgumentIsEmpty("argumentName"), e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullParameterNameEmptyPropNameIsNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotNull((int?)null, string.Empty, null);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(Resources.ArgumentIsEmpty("argumentName"), e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullParameterNameIsNotNullPropNameIsNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: argumentPropertyName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullParameterNameIsNotNullPropNameIsNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: argumentPropertyName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullParameterNameIsNotNullPropNameIsEmptyExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(Resources.ArgumentIsEmpty("argumentPropertyName"), e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullParameterNameIsNotNullPropNameIsEmptyExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(Resources.ArgumentIsEmpty("argumentPropertyName"), e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullParameterNameHasValuePropNameHasValueExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, "Test");
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual($"Значение свойства '{NotNullNotEmptyNotWhiteSpaceString}' аргумента '{NotNullNotEmptyNotWhiteSpaceString}' не может быть неопределенным.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullParameterNameHasValuePropNameHasValueExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual($"The property '{NotNullNotEmptyNotWhiteSpaceString}' of the argument '{NotNullNotEmptyNotWhiteSpaceString}' cannot be null.", e.Message);
                throw;
            }
        }
    }
}
