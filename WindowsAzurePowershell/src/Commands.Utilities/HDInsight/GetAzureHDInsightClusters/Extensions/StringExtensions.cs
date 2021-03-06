﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------
namespace Microsoft.WindowsAzure.Management.HDInsight.Cmdlet.GetAzureHDInsightClusters.Extensions
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Text;

    /// <summary>
    ///     Provides useful extension methods for strings.
    /// </summary>
    internal static class StringExtensions
    {
        /// <summary>
        ///     Uri Encodes the value of a string.
        /// </summary>
        /// <param name="inputValue">
        ///     The string to encode.
        /// </param>
        /// <returns>
        ///     A Uri encoded string.
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings",
            Justification = "This method does not return a Uri but a string that is encoded properly for Uris [tgs]")]
        public static string EscapeDataString([ValidatedNotNull] this string inputValue)
        {
            if (inputValue.IsNullOrEmpty())
            {
                return string.Empty;
            }

            return Uri.EscapeDataString(inputValue);
        }

        /// <summary>
        ///     Determines if a string is not null or empty.
        /// </summary>
        /// <param name="value">
        ///     The string to check.
        /// </param>
        /// <returns>
        ///     True if the string is something other than null or string.Empty otherwise false.
        /// </returns>
        public static bool IsNotNullOrEmpty([ValidatedNotNull] this string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///     Determines if a string is null or empty.
        /// </summary>
        /// <param name="value">
        ///     The string to check.
        /// </param>
        /// <returns>
        ///     True if the string is null or string.Empty otherwise false.
        /// </returns>
        public static bool IsNullOrEmpty([ValidatedNotNull] this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///     Returns a stream containing the UTF8 encoded content of a string.
        /// </summary>
        /// <param name="value">
        ///     The string to convert.
        /// </param>
        /// <returns>
        ///     A UTF8 Stream with the contents of the string present.
        /// </returns>
        public static Stream ToUtf8Stream(this string value)
        {
            var result = Help.SafeCreate<MemoryStream>();
            using (var temp = new MemoryStream())
            {
                var writer = new StreamWriter(temp, Encoding.UTF8);
                writer.Write(value);
                writer.Flush();
                temp.Flush();
                temp.Position = 0;
                temp.CopyTo(result);
            }
            result.Position = 0;
            return result;
        }
    }
}
