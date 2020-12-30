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
    /// Tests of methods <see cref="Validate.NotNull{T}(T, string, string)"/> and <see cref="Validate.NotNull{T}(T?, string, string)"/>.
    /// </summary>
    [Localizable(false)]
    [TestClass]
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumented", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumentedOptional", Justification = "Tests")]
    [SuppressMessage("ReSharper", "UncatchableException", Justification = "Tests")]
    public sealed class ValidatePropertyNotNullTests
    {
        private const string NotNullNotEmptyNotWhiteSpaceString = "Test";
        private const string WhiteSpaceString = "    ";

        /// <summary>
        /// Success test of method <see cref="Validate.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        public void NotNullReferenceTypeSuccessTest()
        {
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, null, null));
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, null, string.Empty));
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, null, WhiteSpaceString));
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, null, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, string.Empty, null));
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, string.Empty, string.Empty));
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, string.Empty, WhiteSpaceString));
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, string.Empty, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, WhiteSpaceString, null));
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, WhiteSpaceString, string.Empty));
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, WhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, NotNullNotEmptyNotWhiteSpaceString, null));
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, NotNullNotEmptyNotWhiteSpaceString, string.Empty));
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, null, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, null, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, null, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, null, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, string.Empty, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, string.Empty, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, string.Empty, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, string.Empty, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));
        }

        /// <summary>
        /// Success test of method <see cref="Validate.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        public void NotNullValueTypeSuccessTest()
        {
            Assert.AreEqual(0, Validate.NotNull((int?)0, null, null));
            Assert.AreEqual(0, Validate.NotNull((int?)0, null, string.Empty));
            Assert.AreEqual(0, Validate.NotNull((int?)0, null, WhiteSpaceString));
            Assert.AreEqual(0, Validate.NotNull((int?)0, null, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(0, Validate.NotNull((int?)0, string.Empty, null));
            Assert.AreEqual(0, Validate.NotNull((int?)0, string.Empty, string.Empty));
            Assert.AreEqual(0, Validate.NotNull((int?)0, string.Empty, WhiteSpaceString));
            Assert.AreEqual(0, Validate.NotNull((int?)0, string.Empty, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(0, Validate.NotNull((int?)0, WhiteSpaceString, null));
            Assert.AreEqual(0, Validate.NotNull((int?)0, WhiteSpaceString, string.Empty));
            Assert.AreEqual(0, Validate.NotNull((int?)0, WhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(0, Validate.NotNull((int?)0, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(0, Validate.NotNull((int?)0, NotNullNotEmptyNotWhiteSpaceString, null));
            Assert.AreEqual(0, Validate.NotNull((int?)0, NotNullNotEmptyNotWhiteSpaceString, string.Empty));
            Assert.AreEqual(0, Validate.NotNull((int?)0, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(0, Validate.NotNull((int?)0, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));
        }

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNullPropNameIsNullTest() => Validate.NotNull<string>(null, null, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNullPropNameIsNotNullTest() => Validate.NotNull<string>(null, null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNullPropNameEmptyTest() => Validate.NotNull<string>(null, null, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNullPropNameWhiteSpaceTest() => Validate.NotNull<string>(null, null, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNotNullPropNameIsNullTest() => Validate.NotNull<string>(null, NotNullNotEmptyNotWhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNotNullPropNameIsNotNullTest() => Validate.NotNull<string>(null, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNotNullPropNameEmptyTest() => Validate.NotNull<string>(null, NotNullNotEmptyNotWhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsNotNullPropNameWhiteSpaceTest() => Validate.NotNull<string>(null, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsEmptyPropNameIsNullTest() => Validate.NotNull<string>(null, string.Empty, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsEmptyPropNameIsNotNullTest() => Validate.NotNull<string>(null, string.Empty, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsEmptyPropNameEmptyTest() => Validate.NotNull<string>(null, string.Empty, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsEmptyPropNameWhiteSpaceTest() => Validate.NotNull<string>(null, string.Empty, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsWhiteSpacePropNameIsNullTest() => Validate.NotNull<string>(null, WhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsWhiteSpacePropNameIsNotNullTest() => Validate.NotNull<string>(null, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsWhiteSpacePropNameEmptyTest() => Validate.NotNull<string>(null, WhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenStringArgIsNullArgNameIsWhiteSpacePropNameWhiteSpaceTest() => Validate.NotNull<string>(null, WhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNullPropNameIsNullTest() => Validate.NotNull(null as object, null, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNullPropNameIsNotNullTest() => Validate.NotNull(null as object, null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNullPropNameEmptyTest() => Validate.NotNull(null as object, null, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNullPropNameWhiteSpaceTest() => Validate.NotNull(null as object, null, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNotNullPropNameIsNullTest() => Validate.NotNull(null as object, NotNullNotEmptyNotWhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNotNullPropNameIsNotNullTest() => Validate.NotNull(null as object, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNotNullPropNameEmptyTest() => Validate.NotNull(null as object, NotNullNotEmptyNotWhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsNotNullPropNameWhiteSpaceTest() => Validate.NotNull(null as object, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsEmptyPropNameIsNullTest() => Validate.NotNull(null as object, string.Empty, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsEmptyPropNameIsNotNullTest() => Validate.NotNull(null as object, string.Empty, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsEmptyPropNameEmptyTest() => Validate.NotNull(null as object, string.Empty, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsEmptyPropNameWhiteSpaceTest() => Validate.NotNull(null as object, string.Empty, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsWhiteSpacePropNameIsNullTest() => Validate.NotNull(null as object, WhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsWhiteSpacePropNameIsNotNullTest() => Validate.NotNull(null as object, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsWhiteSpacePropNameEmptyTest() => Validate.NotNull(null as object, WhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenObjectArgIsNullArgNameIsWhiteSpacePropNameWhiteSpaceTest() => Validate.NotNull(null as object, WhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNullPropNameIsNullTest() => Validate.NotNull((int?)null, null, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNullPropNameIsNotNullTest() => Validate.NotNull((int?)null, null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNullPropNameEmptyTest() => Validate.NotNull((int?)null, null, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNullPropNameWhiteSpaceTest() => Validate.NotNull((int?)null, null, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNotNullPropNameIsNullTest() => Validate.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNotNullPropNameIsNotNullTest() => Validate.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNotNullPropNameEmptyTest() => Validate.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsNotNullPropNameWhiteSpaceTest() => Validate.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsEmptyPropNameIsNullTest() => Validate.NotNull((int?)null, string.Empty, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsEmptyPropNameIsNotNullTest() => Validate.NotNull((int?)null, string.Empty, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsEmptyPropNameEmptyTest() => Validate.NotNull((int?)null, string.Empty, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsEmptyPropNameWhiteSpaceTest() => Validate.NotNull((int?)null, string.Empty, WhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsWhiteSpacePropNameIsNullTest() => Validate.NotNull((int?)null, WhiteSpaceString, null);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsWhiteSpacePropNameIsNotNullTest() => Validate.NotNull((int?)null, WhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsWhiteSpacePropNameEmptyTest() => Validate.NotNull((int?)null, WhiteSpaceString, string.Empty);

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullThrowsWhenIntArgIsNullArgNameIsWhiteSpacePropNameWhiteSpaceTest() => Validate.NotNull((int?)null, WhiteSpaceString, WhiteSpaceString);

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
                Validate.NotNull((int?)null, null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: objectName", e.Message);
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
                Validate.NotNull((int?)null, null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: objectName", e.Message);
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
                Validate.NotNull((int?)null, string.Empty, null);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(Resources.ArgumentIsEmpty("objectName"), e.Message);
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
                Validate.NotNull((int?)null, string.Empty, null);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(Resources.ArgumentIsEmpty("objectName"), e.Message);
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
                Validate.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: propertyName", e.Message);
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
                Validate.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: propertyName", e.Message);
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
                Validate.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(Resources.ArgumentIsEmpty("propertyName"), e.Message);
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
                Validate.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(Resources.ArgumentIsEmpty("propertyName"), e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotNullParameterNameHasValuePropNameHasValueExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual("Ошибка состояния приложения. Значение свойства 'Test' объекта 'Test' не может быть неопределенным.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Test of method <see cref="Check.NotNull{T}(T?, string, string)"/>.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotNullParameterNameHasValuePropNameHasValueExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual("Application state error. The property 'Test' of the object 'Test' cannot be null.", e.Message);
                throw;
            }
        }
    }
}
