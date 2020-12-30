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
    /// Tests of methods <see cref="Check.NotNull{T}(T,string)"/> and <see cref="Check.NotNull{T}(T?,string)"/>.
    /// </summary>
    [Localizable(false)]
    [TestClass]
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumented", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumentedOptional", Justification = "Tests")]
    [SuppressMessage("ReSharper", "NotResolvedInText", Justification = "Tests")]
    [SuppressMessage("ReSharper", "UncatchableException", Justification = "Tests")]
    public sealed class CheckNotNullTests
    {
        private const string NotNullNotEmptyNotWhiteSpaceString = "Test";
        private const string WhiteSpaceString = "    ";

        /// <summary>
        /// Success test of method <see cref="Check.NotNull{T}(T,string)"/>.
        /// </summary>
        [TestMethod]
        public void NotNullReferenceTypeSuccessTest()
        {
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, null));
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, string.Empty));
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, WhiteSpaceString));
            Assert.AreEqual(string.Empty, Check.NotNull(string.Empty, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Check.NotNull(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));

            var testObject = new object();
            Assert.AreSame(testObject, Check.NotNull(testObject, null));
            Assert.AreSame(testObject, Check.NotNull(testObject, string.Empty));
            Assert.AreSame(testObject, Check.NotNull(testObject, WhiteSpaceString));
            Assert.AreSame(testObject, Check.NotNull(testObject, nameof(testObject)));
        }

        /// <summary>
        /// Success test of method <see cref="Check.NotNull{T}(T?,string)"/>.
        /// </summary>
        [TestMethod]
        public void NotNullNullableValueTypeSuccessTest()
        {
            Assert.AreEqual(0, Check.NotNull((int?)0, null));
            Assert.AreEqual(0, Check.NotNull((int?)0, string.Empty));
            Assert.AreEqual(0, Check.NotNull((int?)0, WhiteSpaceString));
            Assert.AreEqual(0, Check.NotNull((int?)0, NotNullNotEmptyNotWhiteSpaceString));

            (string StringTupleItem, int IntTupleItem)? testTuple = (NotNullNotEmptyNotWhiteSpaceString, 1);
            Assert.AreEqual(testTuple, Check.NotNull(testTuple, null));
            Assert.AreEqual(testTuple, Check.NotNull(testTuple, string.Empty));
            Assert.AreEqual(testTuple, Check.NotNull(testTuple, WhiteSpaceString));
            Assert.AreEqual(testTuple, Check.NotNull(testTuple, nameof(testTuple)));
        }

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullReferenceTypeThrowsWhenStringArgIsNullArgNameIsNullTest() => Check.NotNull<string>(null, null);

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullNullableValueTypeThrowsWhenStringArgIsNullArgNameIsNullTest() => Check.NotNull((int?)null, null);

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullReferenceTypeThrowsWhenStringArgIsNullArgNameIsNotNullTest() => Check.NotNull<string>(null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullNullableValueTypeThrowsWhenStringArgIsNullArgNameIsNotNullTest() => Check.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullReferenceTypeThrowsWhenStringArgIsNullArgNameEmptyTest() => Check.NotNull<string>(null, string.Empty);

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullNullableValueTypeThrowsWhenStringArgIsNullArgNameEmptyTest() => Check.NotNull((int?)null, string.Empty);

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullReferenceTypeThrowsWhenStringArgIsNullArgNameWhiteSpaceTest() => Check.NotNull<string>(null, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullNullableValueTypeThrowsWhenStringArgIsNullArgNameWhiteSpaceTest() => Check.NotNull((int?)null, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullReferenceTypeParameterNameIsNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotNull((string)null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: argumentName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullReferenceTypeParameterNameIsNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotNull((string)null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: argumentName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullNullableValueTypeParameterNameIsNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotNull((int?)null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: argumentName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullNullableValueTypeParameterNameIsNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotNull((int?)null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: argumentName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullReferenceTypeParameterNameHasValueExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotNull((string)null, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: {NotNullNotEmptyNotWhiteSpaceString}", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullReferenceTypeParameterNameHasValueExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotNull((string)null, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: {NotNullNotEmptyNotWhiteSpaceString}", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullNullableValueTypeParameterNameHasValueExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: {NotNullNotEmptyNotWhiteSpaceString}", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullNullableValueTypeParameterNameHasValueExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: {NotNullNotEmptyNotWhiteSpaceString}", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullReferenceTypeParameterNameEmptyExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotNull((object)null, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(Resources.ArgumentIsEmpty("argumentName"), e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullReferenceTypeParameterNameEmptyExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotNull((object)null, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(Resources.ArgumentIsEmpty("argumentName"), e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullNullableValueTypeParameterNameEmptyExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Check.NotNull((int?)null, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(Resources.ArgumentIsEmpty("argumentName"), e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Check.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullNullableValueTypeParameterNameEmptyExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Check.NotNull((int?)null, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(Resources.ArgumentIsEmpty("argumentName"), e.Message);
                throw;
            }
        }
    }
}
