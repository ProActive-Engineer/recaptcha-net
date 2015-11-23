﻿/* ============================================================================================================================
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
 * LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE.
 * =========================================================================================================================== */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recaptcha.Web
{
    /// <summary>
    /// Represents the JSON result for reCAPTCHA v2.
    /// </summary>
    public class Recaptcha2VerificationResult
    {
        #region Properties

        /// <summary>
        /// Determines if the reCAPTCHA verification was successful.
        /// </summary>
        [JsonProperty("success")]
        public bool Success
        {
            get;
            set;
        }

        /// <summary>
        /// Represents an array of errors if reCAPTCHA verification was not successful.
        /// </summary>
        [JsonProperty("error-codes")]
        public string[] ErrorCodes
        {
            get;
            set;
        }

        #endregion Properties
    }
}
