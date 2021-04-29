// Copyright (c) Michael Prokopyev. All rights reserved.

namespace CoreLibraries.Diagnostics
{
    #region usings section

    using JetBrains.Annotations;
    using Properties;
    using System;
    using System.Diagnostics;

    #endregion usings section

    /// <summary>
    /// <para xml:lang="en">Checking the method's arguments.</para>
    /// <para xml:lang="ru">Проверка аргументов метода.</para>
    /// </summary>
    [PublicAPI]
    [DebuggerStepThrough]
    public static class Check
    {
        /// <summary>
        /// <para xml:lang="en">
        /// Checks if the reference type argument is not <see langword="null"/>.
        /// if argument is <see langword="null"/>, an <see cref="ArgumentNullException"/> exception is thrown.
        /// </para>
        /// <para xml:lang="ru">
        /// Проверка аргумента ссылочного типа на его неравенство <see langword="null"/>.
        /// Если аргумент <see langword="null"/>, возникает исключение <see cref="ArgumentNullException"/>.
        /// </para>
        /// </summary>
        /// <typeparam name="T">
        /// <para xml:lang="en">Argument type.</para>
        /// <para xml:lang="ru">Тип аргумента.</para>
        /// </typeparam>
        /// <param name="argumentValue">
        /// <para xml:lang="en">The argument to check.</para>
        /// <para xml:lang="ru">Аргумент подлежащий проверке.</para>
        /// </param>
        /// <param name="argumentName">
        /// <para xml:lang="en">Argument name.</para>
        /// <para xml:lang="ru">Имя аргумента.</para>
        /// </param>
        /// <returns>
        /// <para xml:lang="en">Argument value.</para>
        /// <para xml:lang="ru">Значение аргумента.</para>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="argumentValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="argumentValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="argumentValue"/> <see langword="null"/> и <paramref name="argumentName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="argumentValue"/> <see langword="null"/> и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// </para>
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <para xml:lang="en">Thrown when <paramref name="argumentValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is empty, or consists only of white-space characters.</para>
        /// <para xml:lang="ru">Возникает когда <paramref name="argumentValue"/> <see langword="null"/> и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей.</para>
        /// </exception>
        [NotNull]
        [ContractAnnotation("argumentValue:null => halt")]
        public static T NotNull<T>([NoEnumeration] T argumentValue, [InvokerParameterName][NotNull] string argumentName)
            where T : class
        {
            if (!(argumentValue is null))
            {
                return argumentValue;
            }

            NotEmpty(argumentName, nameof(argumentName));
            throw new ArgumentNullException(argumentName);
        }

        /// <summary>
        /// <para xml:lang="en">
        /// Checks if the nullable value type argument is not <see langword="null"/>.
        /// if argument is <see langword="null"/>, an <see cref="ArgumentNullException"/> exception is thrown.
        /// </para>
        /// <para xml:lang="ru">
        /// Проверка аргумента типа значения, которому можно присвоить значение <see langword="null"/> на его неравенство <see langword="null"/>.
        /// Если аргумент <see langword="null"/>, возникает исключение <see cref="ArgumentNullException"/>.
        /// </para>
        /// </summary>
        /// <typeparam name="T">
        /// <para xml:lang="en">Argument type.</para>
        /// <para xml:lang="ru">Тип аргумента.</para>
        /// </typeparam>
        /// <param name="argumentValue">
        /// <para xml:lang="en">The argument to check.</para>
        /// <para xml:lang="ru">Аргумент подлежащий проверке.</para>
        /// </param>
        /// <param name="argumentName">
        /// <para xml:lang="en">Argument name.</para>
        /// <para xml:lang="ru">Имя аргумента.</para>
        /// </param>
        /// <returns>
        /// <para xml:lang="en">Argument value.</para>
        /// <para xml:lang="ru">Значение аргумента.</para>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="argumentValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="argumentValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="argumentValue"/> <see langword="null"/> и <paramref name="argumentName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="argumentValue"/> <see langword="null"/> и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// </para>
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <para xml:lang="en">Thrown when <paramref name="argumentValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is empty, or consists only of white-space characters.</para>
        /// <para xml:lang="ru">Возникает когда <paramref name="argumentValue"/> <see langword="null"/> и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей.</para>
        /// </exception>
        [NotNull]
        [ContractAnnotation("argumentValue:null => halt")]
        public static T? NotNull<T>(T? argumentValue, [InvokerParameterName][NotNull] string argumentName)
            where T : struct
        {
            if (!(argumentValue is null))
            {
                return argumentValue;
            }

            NotEmpty(argumentName, nameof(argumentName));
            throw new ArgumentNullException(argumentName);
        }

        /// <summary>
        /// <para xml:lang="en">
        /// Checks if the reference type argument property value is not <see langword="null"/>.
        /// if argument property value is <see langword="null"/>, an <see cref="ArgumentException"/> exception is thrown.
        /// </para>
        /// <para xml:lang="ru">
        /// Проверка значения свойства аргумента ссылочного типа на его неравенство <see langword="null"/>.
        /// Если значение свойства аргумента <see langword="null"/>, возникает исключение <see cref="ArgumentException"/>.
        /// </para>
        /// </summary>
        /// <typeparam name="T">
        /// <para xml:lang="en">Argument property type.</para>
        /// <para xml:lang="ru">Тип свойства аргумента.</para>
        /// </typeparam>
        /// <param name="argumentPropertyValue">
        /// <para xml:lang="en">The argument property value to check for not <see langword="null"/>.</para>
        /// <para xml:lang="ru">Значение свойства аргумента подлежащего проверке на неравенство <see langword="null"/>.</para>
        /// </param>
        /// <param name="argumentName">
        /// <para xml:lang="en">Argument name.</para>
        /// <para xml:lang="ru">Имя аргумента.</para>
        /// </param>
        /// <param name="argumentPropertyName">
        /// <para xml:lang="en">Argument property name.</para>
        /// <para xml:lang="ru">Имя свойства аргумента.</para>
        /// </param>
        /// <returns>
        /// <para xml:lang="en">Argument property value.</para>
        /// <para xml:lang="ru">Значение свойства аргумента.</para>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="argumentPropertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is <see langword="null"/> and <paramref name="argumentPropertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is <see langword="null"/> and <paramref name="argumentPropertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is <see langword="null"/> and <paramref name="argumentPropertyName"/> is empty, or consists only of white-space characters.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> <see langword="null"/> и <paramref name="argumentPropertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> <see langword="null"/> и <paramref name="argumentPropertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> <see langword="null"/> и <paramref name="argumentPropertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// </para>
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="argumentPropertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="argumentPropertyName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is empty, or consists only of white-space characters and <paramref name="argumentPropertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is empty, or consists only of white-space characters and <paramref name="argumentPropertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is empty, or consists only of white-space characters and <paramref name="argumentPropertyName"/> is empty, or consists only of white-space characters.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// </para>
        /// </exception>
        [NotNull]
        [ContractAnnotation("argumentPropertyValue:null => halt")]
        public static T NotNull<T>([NoEnumeration] T argumentPropertyValue, [InvokerParameterName][NotNull] string argumentName, [NotNull] string argumentPropertyName)
            where T : class
        {
            if (!(argumentPropertyValue is null))
            {
                return argumentPropertyValue;
            }

            NotEmpty(argumentName, nameof(argumentName));
            NotEmpty(argumentPropertyName, nameof(argumentPropertyName));

            throw new ArgumentException(Resources.ArgumentPropertyNull(argumentPropertyName, argumentName));
        }

        /// <summary>
        /// <para xml:lang="en">
        /// Checks if the nullable value type argument property value is not <see langword="null"/>.
        /// if argument property value is <see langword="null"/>, an <see cref="ArgumentException"/> exception is thrown.
        /// </para>
        /// <para xml:lang="ru">
        /// Проверка свойства аргумента типа значения, которому можно присвоить значение <see langword="null"/> на неравенство <see langword="null"/>.
        /// Если значение свойства аргумента <see langword="null"/>, возникает исключение <see cref="ArgumentException"/>.
        /// </para>
        /// </summary>
        /// <typeparam name="T">
        /// <para xml:lang="en">Argument property type.</para>
        /// <para xml:lang="ru">Тип свойства аргумента.</para>
        /// </typeparam>
        /// <param name="argumentPropertyValue">
        /// <para xml:lang="en">The argument property value to check for not <see langword="null"/>.</para>
        /// <para xml:lang="ru">Значение свойства аргумента подлежащего проверке на неравенство <see langword="null"/>.</para>
        /// </param>
        /// <param name="argumentName">
        /// <para xml:lang="en">Argument name.</para>
        /// <para xml:lang="ru">Имя аргумента.</para>
        /// </param>
        /// <param name="argumentPropertyName">
        /// <para xml:lang="en">Argument property name.</para>
        /// <para xml:lang="ru">Имя свойства аргумента.</para>
        /// </param>
        /// <returns>
        /// <para xml:lang="en">Argument property value.</para>
        /// <para xml:lang="ru">Значение свойства аргумента.</para>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="argumentPropertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is <see langword="null"/> and <paramref name="argumentPropertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is <see langword="null"/> and <paramref name="argumentPropertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is <see langword="null"/> and <paramref name="argumentPropertyName"/> is empty, or consists only of white-space characters.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> <see langword="null"/> и <paramref name="argumentPropertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> <see langword="null"/> и <paramref name="argumentPropertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> <see langword="null"/> и <paramref name="argumentPropertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// </para>
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="argumentPropertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="argumentPropertyName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is empty, or consists only of white-space characters and <paramref name="argumentPropertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is empty, or consists only of white-space characters and <paramref name="argumentPropertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is empty, or consists only of white-space characters and <paramref name="argumentPropertyName"/> is empty, or consists only of white-space characters.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// </para>
        /// </exception>
        [NotNull]
        [ContractAnnotation("argumentPropertyValue:null => halt")]
        public static T? NotNull<T>(T? argumentPropertyValue, [InvokerParameterName][NotNull] string argumentName, [NotNull] string argumentPropertyName)
            where T : struct
        {
            if (!(argumentPropertyValue is null))
            {
                return argumentPropertyValue;
            }

            NotEmpty(argumentName, nameof(argumentName));
            NotEmpty(argumentPropertyName, nameof(argumentPropertyName));

            throw new ArgumentException(Resources.ArgumentPropertyNull(argumentPropertyName, argumentName));
        }

        /// <summary>
        /// <para xml:lang="en">
        /// Checks if <see langword="string"/> argument is not <see langword="null"/>, not empty and not consists only of white-space characters.
        /// if argument is <see langword="null"/>, an <see cref="ArgumentNullException"/> exception is thrown.
        /// if argument is empty or consists only of white-space characters, an <see cref="ArgumentException"/> exception is thrown.
        /// </para>
        /// <para xml:lang="ru">
        /// Проверка <see langword="string"/> аргумента на неравенство <see langword="null"/>, на невозможность являться пустой строкой и на невозможность являться строкой, состоящей только из символов-разделителей.
        /// Если аргумент <see langword="null"/>, возникает исключение <see cref="ArgumentNullException"/>.
        /// Если аргумент пустая строка или строка, состоящая только из символов-разделителей, возникает исключение <see cref="ArgumentException"/>.
        /// </para>
        /// </summary>
        /// <param name="argumentValue">
        /// <para xml:lang="en">The argument to check.</para>
        /// <para xml:lang="ru">Аргумент подлежащий проверке.</para>
        /// </param>
        /// <param name="argumentName">
        /// <para xml:lang="en">Argument name.</para>
        /// <para xml:lang="ru">Имя аргумента.</para>
        /// </param>
        /// <returns>
        /// <para xml:lang="en">Argument value.</para>
        /// <para xml:lang="ru">Значение аргумента.</para>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="argumentValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="argumentValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="argumentValue"/> is empty, or consists only of white-space characters and <paramref name="argumentName"/> is <see langword="null"/>.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="argumentValue"/> <see langword="null"/> и <paramref name="argumentName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="argumentValue"/> <see langword="null"/> и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и строка, не состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentValue"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentName"/> <see langword="null"/>.
        /// </para>
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="argumentValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="argumentValue"/> is empty or consists only of white-space characters and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="argumentValue"/> is empty or consists only of white-space characters and <paramref name="argumentName"/> is empty, or consists only of white-space characters.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="argumentValue"/> <see langword="null"/> и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentValue"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentValue"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// </para>
        /// </exception>
        [NotNull]
        [ContractAnnotation("argumentValue:null => halt")]
        public static string NotEmpty(string argumentValue, [InvokerParameterName][NotNull] string argumentName)
        {
            if (argumentValue is null)
            {
                NotEmpty(argumentName, nameof(argumentName));
                throw new ArgumentNullException(argumentName);
            }

            if (argumentValue.Trim().Length != 0)
            {
                return argumentValue;
            }

            NotEmpty(argumentName, nameof(argumentName));
            throw new ArgumentException(Resources.ArgumentIsEmpty(argumentName));
        }

        /// <summary>
        /// <para xml:lang="en">
        /// Checks if argument <see langword="string"/> property is not <see langword="null"/>, not empty and not consists only of white-space characters.
        /// if argument property is <see langword="null"/>, an <see cref="ArgumentNullException"/> exception is thrown.
        /// if argument property is empty or consists only of white-space characters, an <see cref="ArgumentException"/> exception is thrown.
        /// </para>
        /// <para xml:lang="ru">
        /// Проверка <see langword="string"/> свойства аргумента на неравенство <see langword="null"/>, на невозможность являться пустой строкой и на невозможность являться строкой, состоящей только из символов-разделителей.
        /// Если свойство аргумента <see langword="null"/>, возникает исключение <see cref="ArgumentNullException"/>.
        /// Если свойство аргумента пустая строка или строка, состоящая только из символов-разделителей, возникает исключение <see cref="ArgumentException"/>.
        /// </para>
        /// </summary>
        /// <param name="argumentPropertyValue">
        /// <para xml:lang="en">The argument property to check.</para>
        /// <para xml:lang="ru">Значение свойства аргумента подлежащего проверке.</para>
        /// </param>
        /// <param name="argumentName">
        /// <para xml:lang="en">Argument name.</para>
        /// <para xml:lang="ru">Имя аргумента.</para>
        /// </param>
        /// <param name="argumentPropertyName">
        /// <para xml:lang="en">Argument property name.</para>
        /// <para xml:lang="ru">Имя свойства аргумента.</para>
        /// </param>
        /// <returns>
        /// <para xml:lang="en">Argument property value.</para>
        /// <para xml:lang="ru">Значение свойства аргумента.</para>
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is <see langword="null"/> and <paramref name="argumentPropertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is <see langword="null"/> and <paramref name="argumentPropertyName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is <see langword="null"/> and <paramref name="argumentPropertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="argumentPropertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="argumentPropertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is empty, or consists only of white-space characters and <paramref name="argumentName"/> is <see langword="null"/> and <paramref name="argumentPropertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="argumentPropertyValue"/> is empty, or consists only of white-space characters and <paramref name="argumentName"/> is <see langword="null"/> and <paramref name="argumentPropertyName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is empty, or consists only of white-space characters and <paramref name="argumentName"/> is <see langword="null"/> and <paramref name="argumentPropertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is empty, or consists only of white-space characters and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="argumentPropertyName"/> is <see langword="null"/>.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> <see langword="null"/> и <paramref name="argumentPropertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> <see langword="null"/> и <paramref name="argumentPropertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> <see langword="null"/> и <paramref name="argumentPropertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentName"/> is <see langword="null"/> и <paramref name="argumentPropertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="argumentPropertyValue"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentName"/> is <see langword="null"/> и <paramref name="argumentPropertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentName"/> is <see langword="null"/> и <paramref name="argumentPropertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> <see langword="null"/>.
        /// </para>
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is empty, or consists only of white-space characters and <paramref name="argumentPropertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is empty, or consists only of white-space characters and <paramref name="argumentPropertyName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is empty, or consists only of white-space characters and <paramref name="argumentPropertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is <see langword="null"/> and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="argumentPropertyName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is empty, or consists only of white-space characters and <paramref name="argumentName"/> is empty, or consists only of white-space characters and <paramref name="argumentPropertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="argumentPropertyValue"/> is empty, or consists only of white-space characters and <paramref name="argumentName"/> is empty, or consists only of white-space characters and <paramref name="argumentPropertyName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is empty, or consists only of white-space characters and <paramref name="argumentName"/> is empty, or consists only of white-space characters and <paramref name="argumentPropertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is empty, or consists only of white-space characters and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="argumentPropertyName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="argumentPropertyValue"/> is empty, or consists only of white-space characters and <paramref name="argumentName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="argumentPropertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> <see langword="null"/> и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="argumentPropertyValue"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="argumentPropertyValue"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="argumentName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="argumentPropertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// </para>
        /// </exception>
        [NotNull]
        [ContractAnnotation("argumentPropertyValue:null => halt")]
        public static string NotEmpty(string argumentPropertyValue, [InvokerParameterName][NotNull] string argumentName, [NotNull] string argumentPropertyName)
        {
            if (argumentPropertyValue is null)
            {
                NotEmpty(argumentName, nameof(argumentName));
                NotEmpty(argumentPropertyName, nameof(argumentPropertyName));
                throw new ArgumentException(Resources.ArgumentPropertyNull(argumentPropertyName, argumentName));
            }

            if (argumentPropertyValue.Trim().Length != 0)
            {
                return argumentPropertyValue;
            }

            NotEmpty(argumentName, nameof(argumentName));
            NotEmpty(argumentPropertyName, nameof(argumentPropertyName));
            throw new ArgumentException(Resources.ArgumentPropertyIsEmpty(argumentPropertyName, argumentName));
        }
    }
}
