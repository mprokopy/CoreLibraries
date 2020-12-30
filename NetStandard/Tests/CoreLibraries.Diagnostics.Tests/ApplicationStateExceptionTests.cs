// Copyright (c) Michael Prokopyev. All rights reserved.

namespace CoreLibraries.Diagnostics.Tests
{
    #region usings section

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Soap;

    #endregion usings section

    /// <summary>
    /// Tests of <see cref="ApplicationStateException" />.
    /// </summary>
    [TestClass]
    [Localizable(false)]
    [SuppressMessage("Maintainability", "RCS1140:Add exception to documentation comment.", Justification = "Tests")]
    [SuppressMessage("ReSharper", "ExceptionNotDocumentedOptional", Justification = "Tests")]
    [SuppressMessage("ReSharper", "PossibleNullReferenceException", Justification = "Tests")]
    public sealed class ApplicationStateExceptionTests
    {
        /// <summary>
        /// Test of constructor.
        /// </summary>
        [TestMethod]
        [Localizable(false)]
        public void ConstructorTest()
        {
            var exception = new ApplicationStateException();
            Assert.IsNotNull(exception);

            var exceptionWithMessage = new ApplicationStateException("TestMessage");
            Assert.IsNotNull(exceptionWithMessage);
        }

        /// <summary>
        /// Test of constructor.
        /// </summary>
        [TestMethod]
        public void ConstructorInnerExceptionTest()
        {
            var exception = new ApplicationStateException(string.Empty, new Exception());
            Assert.IsNotNull(exception);
            Assert.IsNotNull(exception.InnerException);
        }

        /// <summary>
        /// Test the exception serialization.
        /// </summary>
        [TestMethod]
        public void ShouldSerializeException()
        {
            var ex = new ApplicationStateException("Test");
            var stream = new MemoryStream();
            try
            {
                var formatter = new SoapFormatter(null, new StreamingContext(StreamingContextStates.File));
                formatter.Serialize(stream, ex);
                stream.Position = 0L;
                var deserializedException = (ApplicationStateException)formatter.Deserialize(stream);
                throw deserializedException;
            }
            catch (SerializationException)
            {
                Assert.Fail("Unable to serialize/deserialize the exception");
            }
            catch (ApplicationStateException e)
            {
                Assert.IsNotNull(e);
            }
            finally
            {
                stream.Close();
            }
        }
    }
}
