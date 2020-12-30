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
    /// <para xml:lang="en">Validation the objects.</para>
    /// <para xml:lang="ru">Проверка объектов.</para>
    /// </summary>
    [PublicAPI]
    [DebuggerStepThrough]
    public static class Validate
    {
        /// <summary>
        /// <para xml:lang="en">
        /// Validates if the reference type object is not <see langword="null"/>.
        /// if object is <see langword="null"/>, an <see cref="ApplicationStateException"/> exception is thrown.
        /// </para>
        /// <para xml:lang="ru">
        /// Проверка объекта ссылочного типа на его неравенство <see langword="null"/>.
        /// Если объект <see langword="null"/>, возникает исключение <see cref="ApplicationStateException"/>.
        /// </para>
        /// </summary>
        /// <typeparam name="T">
        /// <para xml:lang="en">Object type.</para>
        /// <para xml:lang="ru">Тип объекта.</para>
        /// </typeparam>
        /// <param name="value">
        /// <para xml:lang="en">The object value to check.</para>
        /// <para xml:lang="ru">Значение объекта подлежащего проверке.</para>
        /// </param>
        /// <param name="objectName">
        /// <para xml:lang="en">Object name.</para>
        /// <para xml:lang="ru">Имя объекта.</para>
        /// </param>
        /// <returns>
        /// <para xml:lang="en">Object value.</para>
        /// <para xml:lang="ru">Значение объекта.</para>
        /// </returns>
        /// <exception cref="ApplicationStateException">
        /// <para xml:lang="en">Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.</para>
        /// <para xml:lang="ru">Возникает когда <paramref name="value"/> и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.</para>
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <para xml:lang="en">Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is <see langword="null"/>.</para>
        /// <para xml:lang="ru">Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> <see langword="null"/>.</para>
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <para xml:lang="en">Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is empty, or consists only of white-space characters.</para>
        /// <para xml:lang="ru">Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей.</para>
        /// </exception>
        [NotNull]
        [ContractAnnotation("value:null => halt", true)]
        public static T NotNull<T>([NoEnumeration] T value, [NotNull] string objectName)
            where T : class
        {
            if (!(value is null))
            {
                return value;
            }

            Check.NotEmpty(objectName, nameof(objectName));
            throw new ApplicationStateException(Resources.ObjectNull(objectName));
        }

        /// <summary>
        /// <para xml:lang="en">
        /// Validates if the nullable value type object is not <see langword="null"/>.
        /// if object is <see langword="null"/>, an <see cref="ApplicationStateException"/> exception is thrown.
        /// </para>
        /// <para xml:lang="ru">
        /// Проверка объекта типа значения на его неравенство <see langword="null"/>.
        /// Если объект <see langword="null"/>, возникает исключение <see cref="ApplicationStateException"/>.
        /// </para>
        /// </summary>
        /// <typeparam name="T">
        /// <para xml:lang="en">Object type.</para>
        /// <para xml:lang="ru">Тип объекта.</para>
        /// </typeparam>
        /// <param name="value">
        /// <para xml:lang="en">The object value to check.</para>
        /// <para xml:lang="ru">Значение объекта подлежащего проверке.</para>
        /// </param>
        /// <param name="objectName">
        /// <para xml:lang="en">Object name.</para>
        /// <para xml:lang="ru">Имя объекта.</para>
        /// </param>
        /// <returns>
        /// <para xml:lang="en">Object value.</para>
        /// <para xml:lang="ru">Значение объекта.</para>
        /// </returns>
        /// <exception cref="ApplicationStateException">
        /// <para xml:lang="en">Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.</para>
        /// <para xml:lang="ru">Возникает когда <paramref name="value"/> и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.</para>
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <para xml:lang="en">Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is <see langword="null"/>.</para>
        /// <para xml:lang="ru">Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> <see langword="null"/>.</para>
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <para xml:lang="en">Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is empty, or consists only of white-space characters.</para>
        /// <para xml:lang="ru">Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей.</para>
        /// </exception>
        [NotNull]
        [ContractAnnotation("value:null => halt", true)]
        public static T? NotNull<T>(T? value, [NotNull] string objectName)
            where T : struct
        {
            if (!(value is null))
            {
                return value;
            }

            Check.NotEmpty(objectName, nameof(objectName));
            throw new ApplicationStateException(Resources.ObjectNull(objectName));
        }

        /// <summary>
        /// <para xml:lang="en">
        /// Validates if the reference type object property value is not <see langword="null"/>.
        /// if object property value is <see langword="null"/>, an <see cref="ApplicationStateException"/> exception is thrown.
        /// </para>
        /// <para xml:lang="ru">
        /// Проверка значения свойства объекта ссылочного типа на его неравенство <see langword="null"/>.
        /// Если значение свойства объекта <see langword="null"/>, возникает исключение <see cref="ApplicationStateException"/>.
        /// </para>
        /// </summary>
        /// <typeparam name="T">
        /// <para xml:lang="en">Object property type.</para>
        /// <para xml:lang="ru">Тип свойства объекта.</para>
        /// </typeparam>
        /// <param name="value">
        /// <para xml:lang="en">The object property value to check for not <see langword="null"/>.</para>
        /// <para xml:lang="ru">Значение свойства объекта подлежащего проверке на неравенство <see langword="null"/>.</para>
        /// </param>
        /// <param name="objectName">
        /// <para xml:lang="en">Object name.</para>
        /// <para xml:lang="ru">Имя объекта.</para>
        /// </param>
        /// <param name="propertyName">
        /// <para xml:lang="en">Object property name.</para>
        /// <para xml:lang="ru">Имя свойства объекта.</para>
        /// </param>
        /// <returns>
        /// <para xml:lang="en">Object property value.</para>
        /// <para xml:lang="ru">Значение свойства объекта.</para>
        /// </returns>
        /// <exception cref="ApplicationStateException">
        /// <para xml:lang="en">Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="propertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.</para>
        /// <para xml:lang="ru">Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.</para>
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="propertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is <see langword="null"/> and <paramref name="propertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is <see langword="null"/> and <paramref name="propertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is <see langword="null"/> and <paramref name="propertyName"/> is empty, or consists only of white-space characters.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> <see langword="null"/> и <paramref name="propertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> <see langword="null"/> и <paramref name="propertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> <see langword="null"/> и <paramref name="propertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// </para>
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="propertyName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is empty, or consists only of white-space characters and <paramref name="propertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is empty, or consists only of white-space characters and <paramref name="propertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is empty, or consists only of white-space characters and <paramref name="propertyName"/> is empty, or consists only of white-space characters.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// </para>
        /// </exception>
        [NotNull]
        [ContractAnnotation("value:null => halt", true)]
        public static T NotNull<T>([NoEnumeration] T value, [NotNull] string objectName, [NotNull] string propertyName)
            where T : class
        {
            if (!(value is null))
            {
                return value;
            }

            Check.NotEmpty(objectName, nameof(objectName));
            Check.NotEmpty(propertyName, nameof(propertyName));

            throw new ApplicationStateException(Resources.ObjectPropertyNull(propertyName, objectName));
        }

        /// <summary>
        /// <para xml:lang="en">
        /// Validates if the nullable value type object property value is not <see langword="null"/>.
        /// if object property value is <see langword="null"/>, an <see cref="ApplicationStateException"/> exception is thrown.
        /// </para>
        /// <para xml:lang="ru">
        /// Проверка свойства объекта типа значения, которому можно присвоить значение <see langword="null"/> на неравенство <see langword="null"/>.
        /// Если значение свойства объекта <see langword="null"/>, возникает исключение <see cref="ApplicationStateException"/>.
        /// </para>
        /// </summary>
        /// <typeparam name="T">
        /// <para xml:lang="en">Object property type.</para>
        /// <para xml:lang="ru">Тип свойства объекта.</para>
        /// </typeparam>
        /// <param name="value">
        /// <para xml:lang="en">The object property value to check for not <see langword="null"/>.</para>
        /// <para xml:lang="ru">Значение свойства объекта подлежащего проверке на неравенство <see langword="null"/>.</para>
        /// </param>
        /// <param name="objectName">
        /// <para xml:lang="en">Object name.</para>
        /// <para xml:lang="ru">Имя объекта.</para>
        /// </param>
        /// <param name="propertyName">
        /// <para xml:lang="en">Object property name.</para>
        /// <para xml:lang="ru">Имя свойства объекта.</para>
        /// </param>
        /// <returns>
        /// <para xml:lang="en">Object property value.</para>
        /// <para xml:lang="ru">Значение свойства объекта.</para>
        /// </returns>
        /// <exception cref="ApplicationStateException">
        /// <para xml:lang="en">Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="propertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.</para>
        /// <para xml:lang="ru">Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.</para>
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="propertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is <see langword="null"/> and <paramref name="propertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is <see langword="null"/> and <paramref name="propertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is <see langword="null"/> and <paramref name="propertyName"/> is empty, or consists only of white-space characters.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> <see langword="null"/> и <paramref name="propertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> <see langword="null"/> и <paramref name="propertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> <see langword="null"/> и <paramref name="propertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// </para>
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="propertyName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is empty, or consists only of white-space characters and <paramref name="propertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is empty, or consists only of white-space characters and <paramref name="propertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is empty, or consists only of white-space characters and <paramref name="propertyName"/> is empty, or consists only of white-space characters.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// </para>
        /// </exception>
        [NotNull]
        [ContractAnnotation("value:null => halt", true)]
        public static T? NotNull<T>(T? value, [NotNull] string objectName, [NotNull] string propertyName)
            where T : struct
        {
            if (!(value is null))
            {
                return value;
            }

            Check.NotEmpty(objectName, nameof(objectName));
            Check.NotEmpty(propertyName, nameof(propertyName));

            throw new ApplicationStateException(Resources.ObjectPropertyNull(propertyName, objectName));
        }

        /// <summary>
        /// <para xml:lang="en">
        /// Validates if <paramref name="value"/> is not <see langword="null"/>, not empty and not consists only of white-space characters.
        /// if <paramref name="value"/> is <see langword="null"/>, empty or consists only of white-space characters, an <see cref="ApplicationStateException"/> exception is thrown.
        /// </para>
        /// <para xml:lang="ru">
        /// Проверка <paramref name="value"/> на неравенство <see langword="null"/>, на невозможность являться пустой строкой и на невозможность являться строкой, состоящей только из символов-разделителей.
        /// Если <paramref name="value"/> <see langword="null"/>, пустая строка или строка, состоящая только из символов-разделителей, возникает исключение <see cref="ApplicationStateException"/>.
        /// </para>
        /// </summary>
        /// <param name="value">
        /// <para xml:lang="en">The string value to check.</para>
        /// <para xml:lang="ru">Строка подлежащая проверке.</para>
        /// </param>
        /// <param name="objectName">
        /// <para xml:lang="en">Object name.</para>
        /// <para xml:lang="ru">Имя объекта.</para>
        /// </param>
        /// <returns>
        /// <para xml:lang="en">Object value.</para>
        /// <para xml:lang="ru">Значение объекта.</para>
        /// </returns>
        /// <exception cref="ApplicationStateException">
        /// <para xml:lang="en">Thrown when <paramref name="value"/> is <see langword="null"/> or is empty, or consists only of white-space characters and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.</para>
        /// <para xml:lang="ru">Возникает когда <paramref name="value"/> <see langword="null"/> или пустая строка или строка, состоящая только из символов-разделителей и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.</para>
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is empty, or consists only of white-space characters and <paramref name="objectName"/> is <see langword="null"/>.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и строка, не состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="objectName"/> <see langword="null"/>.
        /// </para>
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is empty or consists only of white-space characters and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is empty or consists only of white-space characters and <paramref name="objectName"/> is empty, or consists only of white-space characters.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// </para>
        /// </exception>
        [NotNull]
        [ContractAnnotation("value:null => halt", true)]
        public static string NotEmpty(string value, [NotNull] string objectName)
        {
            if (value is null)
            {
                Check.NotEmpty(objectName, nameof(objectName));
                throw new ApplicationStateException(Resources.StringIsNull(objectName));
            }

            if (value.Trim().Length != 0)
            {
                return value;
            }

            Check.NotEmpty(objectName, nameof(objectName));
            throw new ApplicationStateException(Resources.StringIsEmpty(objectName));
        }

        /// <summary>
        /// <para xml:lang="en">
        /// Checks if object <see langword="string"/> property is not <see langword="null"/>, not empty and not consists only of white-space characters.
        /// if object property is <see langword="null"/>, empty or consists only of white-space characters an <see cref="ApplicationStateException"/> exception is thrown.
        /// </para>
        /// <para xml:lang="ru">
        /// Проверка <see langword="string"/> свойства Объекта на неравенство <see langword="null"/>, на невозможность являться пустой строкой и на невозможность являться строкой, состоящей только из символов-разделителей.
        /// Если свойство объекта <see langword="null"/>, пустая строка или строка, состоящая только из символов-разделителей возникает исключение <see cref="ApplicationStateException"/>.
        /// </para>
        /// </summary>
        /// <param name="value">
        /// <para xml:lang="en">The object property to check.</para>
        /// <para xml:lang="ru">Значение свойства объекта подлежащего проверке.</para>
        /// </param>
        /// <param name="objectName">
        /// <para xml:lang="en">Object name.</para>
        /// <para xml:lang="ru">Имя объекта.</para>
        /// </param>
        /// <param name="propertyName">
        /// <para xml:lang="en">Object property name.</para>
        /// <para xml:lang="ru">Имя свойства объекта.</para>
        /// </param>
        /// <returns>
        /// <para xml:lang="en">Object property value.</para>
        /// <para xml:lang="ru">Значение свойства объекта.</para>
        /// </returns>
        /// <exception cref="ApplicationStateException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="propertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is empty, or consists only of white-space characters and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="propertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// </para>
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is <see langword="null"/> and <paramref name="propertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is <see langword="null"/> and <paramref name="propertyName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is <see langword="null"/> and <paramref name="propertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="propertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="value"/> is empty, or consists only of white-space characters and <paramref name="objectName"/> is <see langword="null"/> and <paramref name="propertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="value"/> is empty, or consists only of white-space characters and <paramref name="objectName"/> and is <see langword="null"/> <paramref name="propertyName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is empty, or consists only of white-space characters and <paramref name="objectName"/> and is <see langword="null"/> <paramref name="propertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is empty, or consists only of white-space characters and <paramref name="objectName"/> is empty, or consists only of white-space characters and <paramref name="propertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="value"/> is empty, or consists only of white-space characters and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="propertyName"/> is <see langword="null"/>.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> <see langword="null"/> и <paramref name="propertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> <see langword="null"/> и <paramref name="propertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> <see langword="null"/> и <paramref name="propertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="value"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="objectName"/> <see langword="null"/> и <paramref name="propertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="value"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="objectName"/> <see langword="null"/> и <paramref name="propertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="objectName"/> <see langword="null"/> и <paramref name="propertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="value"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> <see langword="null"/>.
        /// </para>
        /// </exception>
        /// <exception cref="ArgumentException">
        /// <para xml:lang="en">
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is empty, or consists only of white-space characters and <paramref name="propertyName"/> is <see langword="null"/>.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is empty, or consists only of white-space characters and <paramref name="propertyName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is empty, or consists only of white-space characters and <paramref name="propertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is <see langword="null"/> and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="propertyName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is empty, or consists only of white-space characters and <paramref name="objectName"/> is empty, or consists only of white-space characters and <paramref name="propertyName"/> is empty, or consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is empty, or consists only of white-space characters and <paramref name="objectName"/> is empty, or consists only of white-space characters and <paramref name="propertyName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters.
        /// Thrown when <paramref name="value"/> is empty, or consists only of white-space characters and <paramref name="objectName"/> is not <see langword="null"/> and not empty and not consists only of white-space characters and <paramref name="propertyName"/> is empty, or consists only of white-space characters.
        /// </para>
        /// <para xml:lang="ru">
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> <see langword="null"/>.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> <see langword="null"/> и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="objectName"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей.
        /// Возникает когда <paramref name="value"/> пустая строка или строка, состоящая только из символов-разделителей и <paramref name="objectName"/> не <see langword="null"/>, не пустая строка и не строка, состоящая только из символов-разделителей и <paramref name="propertyName"/> пустая строка или строка, состоящая только из символов-разделителей.
        /// </para>
        /// </exception>
        [NotNull]
        [ContractAnnotation("value:null => halt", true)]
        public static string NotEmpty(string value, [NotNull] string objectName, [NotNull] string propertyName)
        {
            if (value is null)
            {
                Check.NotEmpty(objectName, nameof(objectName));
                Check.NotEmpty(propertyName, nameof(propertyName));
                throw new ApplicationStateException(Resources.StringPropertyIsNull(objectName, propertyName));
            }

            if (value.Trim().Length != 0)
            {
                return value;
            }

            Check.NotEmpty(objectName, nameof(objectName));
            Check.NotEmpty(propertyName, nameof(propertyName));
            throw new ApplicationStateException(Resources.StringPropertyIsEmpty(propertyName, objectName));
        }
    }
}
