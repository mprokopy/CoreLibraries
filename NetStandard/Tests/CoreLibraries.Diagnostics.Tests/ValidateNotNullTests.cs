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
    /// Tests of methods <see cref="Validate.NotNull{T}(T,string)"/> and <see cref="Validate.NotNull{T}(T?,string)"/>.
    /// </summary>
    [Localizable(false)]
    [TestClass]
    [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumented", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumentedOptional", Justification = "Tests")]
    [SuppressMessage("ReSharper", "UncatchableException", Justification = "Tests")]
    public sealed class ValidateNotNullTests
    {
        private const string NotNullNotEmptyNotWhiteSpaceString = "Test";
        private const string WhiteSpaceString = "    ";

        /// <summary>
        /// Success test of method <see cref="Validate.NotNull{T}(T,string)"/>.
        /// </summary>
        [TestMethod]
        public void NotNullReferenceTypeSuccessTest()
        {
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, null));
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, string.Empty));
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, WhiteSpaceString));
            Assert.AreEqual(string.Empty, Validate.NotNull(string.Empty, NotNullNotEmptyNotWhiteSpaceString));

            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, null));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, string.Empty));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, WhiteSpaceString));
            Assert.AreEqual(NotNullNotEmptyNotWhiteSpaceString, Validate.NotNull(NotNullNotEmptyNotWhiteSpaceString, NotNullNotEmptyNotWhiteSpaceString));

            var testObject = new object();
            Assert.AreSame(testObject, Validate.NotNull(testObject, null));
            Assert.AreSame(testObject, Validate.NotNull(testObject, string.Empty));
            Assert.AreSame(testObject, Validate.NotNull(testObject, WhiteSpaceString));
            Assert.AreSame(testObject, Validate.NotNull(testObject, nameof(testObject)));
        }

        /// <summary>
        /// Success test of method <see cref="Validate.NotNull{T}(T?,string)"/>.
        /// </summary>
        [TestMethod]
        public void NotNullNullableValueTypeSuccessTest()
        {
            Assert.AreEqual(0, Validate.NotNull((int?)0, null));
            Assert.AreEqual(0, Validate.NotNull((int?)0, string.Empty));
            Assert.AreEqual(0, Validate.NotNull((int?)0, WhiteSpaceString));
            Assert.AreEqual(0, Validate.NotNull((int?)0, NotNullNotEmptyNotWhiteSpaceString));

            (string StringTupleItem, int IntTupleItem)? testTuple = (NotNullNotEmptyNotWhiteSpaceString, 1);
            Assert.AreEqual(testTuple, Validate.NotNull(testTuple, null));
            Assert.AreEqual(testTuple, Validate.NotNull(testTuple, string.Empty));
            Assert.AreEqual(testTuple, Validate.NotNull(testTuple, WhiteSpaceString));
            Assert.AreEqual(testTuple, Validate.NotNull(testTuple, nameof(testTuple)));
        }

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullReferenceTypeThrowsWhenStringArgIsNullArgNameIsNullTest() => Validate.NotNull<string>(null, null);

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullNullableValueTypeThrowsWhenStringArgIsNullArgNameIsNullTest() => Validate.NotNull((int?)null, null);

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotNullReferenceTypeThrowsWhenStringArgIsNullArgNameIsNotNullTest() => Validate.NotNull<string>(null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotNullNullableValueTypeThrowsWhenStringArgIsNullArgNameIsNotNullTest() => Validate.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullReferenceTypeThrowsWhenStringArgIsNullArgNameEmptyTest() => Validate.NotNull<string>(null, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullNullableValueTypeThrowsWhenStringArgIsNullArgNameEmptyTest() => Validate.NotNull((int?)null, string.Empty);

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullReferenceTypeThrowsWhenStringArgIsNullArgNameWhiteSpaceTest() => Validate.NotNull<string>(null, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullNullableValueTypeThrowsWhenStringArgIsNullArgNameWhiteSpaceTest() => Validate.NotNull((int?)null, WhiteSpaceString);

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullReferenceTypeParameterNameIsNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotNull((string)null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: objectName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullReferenceTypeParameterNameIsNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotNull((string)null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: objectName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullNullableValueTypeParameterNameIsNullExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotNull((int?)null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Значение не может быть неопределенным.{Environment.NewLine}Имя параметра: objectName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNullNullableValueTypeParameterNameIsNullExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotNull((int?)null, null);
            }
            catch (ArgumentNullException e)
            {
                Assert.AreEqual($"Value cannot be null.{Environment.NewLine}Parameter name: objectName", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotNullReferenceTypeParameterNameHasValueExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotNull((string)null, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Ошибка состояния приложения. '{NotNullNotEmptyNotWhiteSpaceString}' не может быть неопределенным.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotNullReferenceTypeParameterNameHasValueExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotNull((string)null, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Application state error. '{NotNullNotEmptyNotWhiteSpaceString}' cannot be null.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotNullNullableValueTypeParameterNameHasValueExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Ошибка состояния приложения. '{NotNullNotEmptyNotWhiteSpaceString}' не может быть неопределенным.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationStateException))]
        public void NotNullNullableValueTypeParameterNameHasValueExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotNull((int?)null, NotNullNotEmptyNotWhiteSpaceString);
            }
            catch (ApplicationStateException e)
            {
                Assert.AreEqual($"Application state error. '{NotNullNotEmptyNotWhiteSpaceString}' cannot be null.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullReferenceTypeParameterNameEmptyExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotNull((object)null, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'objectName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullReferenceTypeParameterNameEmptyExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotNull((object)null, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'objectName' cannot be empty.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullNullableValueTypeParameterNameEmptyExceptionMessageRuTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("ru");
                Validate.NotNull((int?)null, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("Строковый аргумент 'objectName' не может быть пустым.", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Method <see cref="Validate.NotNull{T}(T?,string)"/> test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullNullableValueTypeParameterNameEmptyExceptionMessageEnTest()
        {
            try
            {
                CultureInfo.CurrentUICulture = new CultureInfo("en");
                Validate.NotNull((int?)null, string.Empty);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The string argument 'objectName' cannot be empty.", e.Message);
                throw;
            }
        }
    }
}
