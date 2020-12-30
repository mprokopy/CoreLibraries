// Copyright (c) Michael Prokopyev. All rights reserved.

namespace CoreLibraries.Diagnostics.Properties
{
    #region usings section

    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    #endregion usings section

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager = new ResourceManager("CoreLibraries.Diagnostics.Properties.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The string argument '{argumentName}' cannot be empty.
        /// </summary>
        public static string ArgumentIsEmpty(object argumentName) => string.Format(CultureInfo.CurrentCulture, GetString("ArgumentIsEmpty", nameof(argumentName)), argumentName);

        /// <summary>
        /// The string property '{property}' of the argument '{argument}' cannot be empty.
        /// </summary>
        public static string ArgumentPropertyIsEmpty(object property, object argument) => string.Format(CultureInfo.CurrentCulture, GetString("ArgumentPropertyIsEmpty", nameof(property), nameof(argument)), property, argument);

        /// <summary>
        /// The property '{property}' of the argument '{argument}' cannot be null.
        /// </summary>
        public static string ArgumentPropertyNull(object property, object argument) => string.Format(CultureInfo.CurrentCulture, GetString("ArgumentPropertyNull", nameof(property), nameof(argument)), property, argument);

        /// <summary>
        /// Application state error. '{elementName}' cannot be null.
        /// </summary>
        public static string ObjectNull(object elementName) => string.Format(CultureInfo.CurrentCulture, GetString("ObjectNull", nameof(elementName)), elementName);

        /// <summary>
        /// Application state error. The property '{property}' of the object '{elementName}' cannot be null.
        /// </summary>
        public static string ObjectPropertyNull(object property, object elementName) => string.Format(CultureInfo.CurrentCulture, GetString("ObjectPropertyNull", nameof(property), nameof(elementName)), property, elementName);

        /// <summary>
        /// Application state error. The string '{elementName}' cannot be empty.
        /// </summary>
        public static string StringIsEmpty(object elementName) => string.Format(CultureInfo.CurrentCulture, GetString("StringIsEmpty", nameof(elementName)), elementName);

        /// <summary>
        /// Application state error. The string '{elementName}' cannot be null.
        /// </summary>
        public static string StringIsNull(object elementName) => string.Format(CultureInfo.CurrentCulture, GetString("StringIsNull", nameof(elementName)), elementName);

        /// <summary>
        /// Application state error. The string property '{property}' of the '{elementName}' cannot be empty.
        /// </summary>
        public static string StringPropertyIsEmpty(object property, object elementName) => string.Format(CultureInfo.CurrentCulture, GetString("StringPropertyIsEmpty", nameof(property), nameof(elementName)), property, elementName);

        /// <summary>
        /// Application state error. The string property '{property}' of the '{elementName}' cannot be null.
        /// </summary>
        public static string StringPropertyIsNull(object property, object elementName) => string.Format(CultureInfo.CurrentCulture, GetString("StringPropertyIsNull", nameof(property), nameof(elementName)), property, elementName);

        internal static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace($"{{{formatterNames[i]}}}", $"{{{i}}}");
            }

            return value;
        }
    }
}

