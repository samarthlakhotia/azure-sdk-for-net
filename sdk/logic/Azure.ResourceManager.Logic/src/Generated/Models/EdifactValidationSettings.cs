// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The Edifact agreement validation settings. </summary>
    public partial class EdifactValidationSettings
    {
        /// <summary> Initializes a new instance of EdifactValidationSettings. </summary>
        /// <param name="validateCharacterSet"> The value indicating whether to validate character set in the message. </param>
        /// <param name="checkDuplicateInterchangeControlNumber"> The value indicating whether to check for duplicate interchange control number. </param>
        /// <param name="interchangeControlNumberValidityDays"> The validity period of interchange control number. </param>
        /// <param name="checkDuplicateGroupControlNumber"> The value indicating whether to check for duplicate group control number. </param>
        /// <param name="checkDuplicateTransactionSetControlNumber"> The value indicating whether to check for duplicate transaction set control number. </param>
        /// <param name="validateEdiTypes"> The value indicating whether to Whether to validate EDI types. </param>
        /// <param name="validateXsdTypes"> The value indicating whether to Whether to validate XSD types. </param>
        /// <param name="allowLeadingAndTrailingSpacesAndZeroes"> The value indicating whether to allow leading and trailing spaces and zeroes. </param>
        /// <param name="trimLeadingAndTrailingSpacesAndZeroes"> The value indicating whether to trim leading and trailing spaces and zeroes. </param>
        /// <param name="trailingSeparatorPolicy"> The trailing separator policy. </param>
        public EdifactValidationSettings(bool validateCharacterSet, bool checkDuplicateInterchangeControlNumber, int interchangeControlNumberValidityDays, bool checkDuplicateGroupControlNumber, bool checkDuplicateTransactionSetControlNumber, bool validateEdiTypes, bool validateXsdTypes, bool allowLeadingAndTrailingSpacesAndZeroes, bool trimLeadingAndTrailingSpacesAndZeroes, TrailingSeparatorPolicy trailingSeparatorPolicy)
        {
            ValidateCharacterSet = validateCharacterSet;
            CheckDuplicateInterchangeControlNumber = checkDuplicateInterchangeControlNumber;
            InterchangeControlNumberValidityDays = interchangeControlNumberValidityDays;
            CheckDuplicateGroupControlNumber = checkDuplicateGroupControlNumber;
            CheckDuplicateTransactionSetControlNumber = checkDuplicateTransactionSetControlNumber;
            ValidateEdiTypes = validateEdiTypes;
            ValidateXsdTypes = validateXsdTypes;
            AllowLeadingAndTrailingSpacesAndZeroes = allowLeadingAndTrailingSpacesAndZeroes;
            TrimLeadingAndTrailingSpacesAndZeroes = trimLeadingAndTrailingSpacesAndZeroes;
            TrailingSeparatorPolicy = trailingSeparatorPolicy;
        }

        /// <summary> The value indicating whether to validate character set in the message. </summary>
        public bool ValidateCharacterSet { get; set; }
        /// <summary> The value indicating whether to check for duplicate interchange control number. </summary>
        public bool CheckDuplicateInterchangeControlNumber { get; set; }
        /// <summary> The validity period of interchange control number. </summary>
        public int InterchangeControlNumberValidityDays { get; set; }
        /// <summary> The value indicating whether to check for duplicate group control number. </summary>
        public bool CheckDuplicateGroupControlNumber { get; set; }
        /// <summary> The value indicating whether to check for duplicate transaction set control number. </summary>
        public bool CheckDuplicateTransactionSetControlNumber { get; set; }
        /// <summary> The value indicating whether to Whether to validate EDI types. </summary>
        public bool ValidateEdiTypes { get; set; }
        /// <summary> The value indicating whether to Whether to validate XSD types. </summary>
        public bool ValidateXsdTypes { get; set; }
        /// <summary> The value indicating whether to allow leading and trailing spaces and zeroes. </summary>
        public bool AllowLeadingAndTrailingSpacesAndZeroes { get; set; }
        /// <summary> The value indicating whether to trim leading and trailing spaces and zeroes. </summary>
        public bool TrimLeadingAndTrailingSpacesAndZeroes { get; set; }
        /// <summary> The trailing separator policy. </summary>
        public TrailingSeparatorPolicy TrailingSeparatorPolicy { get; set; }
    }
}
