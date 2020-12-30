// Copyright (c) Michael Prokopyev. All rights reserved.

namespace CoreLibraries.Diagnostics
{
    #region usings section

    using JetBrains.Annotations;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;

    #endregion usings section

    /// <inheritdoc />
    /// <summary>
    /// <para xml:lang="en">The exception that is thrown for errors of application state.</para>
    /// <para xml:lang="ru">Исключение, которое возникает при ошибочном состоянии приложения.</para>
    /// </summary>
    [Serializable]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1642:Constructor summary documentation should begin with standard text", Justification = "https://github.com/DotNetAnalyzers/StyleCopAnalyzers/issues/2640")]
    public sealed class ApplicationStateException : Exception
    {
        /// <inheritdoc cref="Exception" />
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ApplicationStateException"/> class.</para>
        /// <para xml:lang="ru">Инициализирует новый экземпляр класса <see cref="ApplicationStateException"/>.</para>
        /// </summary>
        public ApplicationStateException()
        {
        }

        /// <inheritdoc cref="Exception" />
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ApplicationStateException"/> class with a specified error message.</para>
        /// <para xml:lang="ru">Инициализирует новый экземпляр класса <see cref="ApplicationStateException"/> с указанным сообщением об ошибке.</para>
        /// </summary>
        /// <param name="message">
        /// <para xml:lang="en">The message that describes the error.</para>
        /// <para xml:lang="ru">Сообщение, описывающее ошибку.</para>
        /// </param>
        public ApplicationStateException(string message)
            : base(message)
        {
        }

        /// <inheritdoc cref="Exception" />
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ApplicationStateException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.</para>
        /// <para xml:lang="ru">Инициализирует новый экземпляр класса <see cref="ApplicationStateException"/> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</para>
        /// </summary>
        /// <param name="message">
        /// <para xml:lang="en">The error message that explains the reason for the exception.</para>
        /// <para xml:lang="ru">Сообщение об ошибке, указывающее причину создания исключения.</para>
        /// </param>
        /// <param name="innerException">
        /// <para xml:lang="en">The exception that is the cause of the current exception. If the innerException parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception.</para>
        /// <para xml:lang="ru">Исключение, которое является причиной текущего исключения. Если параметр innerException не является указателем null, то текущее исключение создается в блоке catch, обрабатывающем внутреннее исключение.</para>
        /// </param>
        public ApplicationStateException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <inheritdoc cref="Exception" />
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ApplicationStateException"/> class with serialized data.</para>
        /// <para xml:lang="ru">Инициализирует новый экземпляр класса <see cref="ApplicationStateException"/> с сериализованными данными.</para>
        /// </summary>
        /// <param name="info">
        /// <para xml:lang="en">The object that holds the serialized object data.</para>
        /// <para xml:lang="ru">Объект, содержащий сериализованные данные объекта.</para>
        /// </param>
        /// <param name="context">
        /// <para xml:lang="en">The contextual information about the source or destination.</para>
        /// <para xml:lang="ru">Контекстные сведения об источнике или назначении.</para>
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// <para xml:lang="en">The <paramref name="info">info</paramref> parameter is <see langword="null"/>.</para>
        /// <para xml:lang="ru">Параметр <paramref name="info">info</paramref> содержит <see langword="null"/>.</para>
        /// </exception>
        /// <exception cref="SerializationException">
        /// <para xml:lang="en">The class name is null or <see cref="Exception.HResult"></see> is zero (0).</para>
        /// <para xml:lang="ru">Наименование класса null или <see cref="Exception.HResult"></see> содержит нулевое (0) значение.</para>
        /// </exception>
        private ApplicationStateException([NotNull] SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
