using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.EcommLibrary.Model.Checkout
{
    /// <summary>
    /// Configuration
    /// </summary>
    [DataContract]
    public partial class Configuration : IEquatable<Configuration>, IValidatableObject
    {
        /// <summary>
        /// Determines whether the cardholder name should be provided or not.  Permitted values: * NONE * OPTIONAL * REQUIRED
        /// </summary>
        /// <value>Determines whether the cardholder name should be provided or not.  Permitted values: * NONE * OPTIONAL * REQUIRED</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CardHolderNameEnum
        {
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")] NONE = 1,

            /// <summary>
            /// Enum OPTIONAL for value: OPTIONAL
            /// </summary>
            [EnumMember(Value = "OPTIONAL")] OPTIONAL = 2,

            /// <summary>
            /// Enum REQUIRED for value: REQUIRED
            /// </summary>
            [EnumMember(Value = "REQUIRED")] REQUIRED = 3
        }

        /// <summary>
        /// Determines whether the cardholder name should be provided or not.  Permitted values: * NONE * OPTIONAL * REQUIRED
        /// </summary>
        /// <value>Determines whether the cardholder name should be provided or not.  Permitted values: * NONE * OPTIONAL * REQUIRED</value>
        [DataMember(Name = "cardHolderName", EmitDefaultValue = false)]
        public CardHolderNameEnum? CardHolderName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class.
        /// </summary>
        /// <param name="Avs">Describes the configuration for AVS ([Address Verification System](https://en.wikipedia.org/wiki/Address_Verification_System))..</param>
        /// <param name="CardHolderName">Determines whether the cardholder name should be provided or not.  Permitted values: * NONE * OPTIONAL * REQUIRED.</param>
        /// <param name="Installments">Describes the configuration for [installment payments](https://docs.adyen.com/developers/payment-methods/installment-payments)..</param>
        /// <param name="ShopperInput">Determines how to display the details fields..</param>
        public Configuration(Avs Avs = default(Avs), CardHolderNameEnum? CardHolderName = default(CardHolderNameEnum?),
            Installments Installments = default(Installments), ShopperInput ShopperInput = default(ShopperInput))
        {
            this.Avs = Avs;
            this.CardHolderName = CardHolderName;
            this.Installments = Installments;
            this.ShopperInput = ShopperInput;
        }

        /// <summary>
        /// Describes the configuration for AVS ([Address Verification System](https://en.wikipedia.org/wiki/Address_Verification_System)).
        /// </summary>
        /// <value>Describes the configuration for AVS ([Address Verification System](https://en.wikipedia.org/wiki/Address_Verification_System)).</value>
        [DataMember(Name = "avs", EmitDefaultValue = false)]
        public Avs Avs { get; set; }


        /// <summary>
        /// Describes the configuration for [installment payments](https://docs.adyen.com/developers/payment-methods/installment-payments).
        /// </summary>
        /// <value>Describes the configuration for [installment payments](https://docs.adyen.com/developers/payment-methods/installment-payments).</value>
        [DataMember(Name = "installments", EmitDefaultValue = false)]
        public Installments Installments { get; set; }

        /// <summary>
        /// Determines how to display the details fields.
        /// </summary>
        /// <value>Determines how to display the details fields.</value>
        [DataMember(Name = "shopperInput", EmitDefaultValue = false)]
        public ShopperInput ShopperInput { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Configuration {\n");
            sb.Append("  Avs: ").Append(Avs).Append("\n");
            sb.Append("  CardHolderName: ").Append(CardHolderName).Append("\n");
            sb.Append("  Installments: ").Append(Installments).Append("\n");
            sb.Append("  ShopperInput: ").Append(ShopperInput).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as Configuration);
        }

        /// <summary>
        /// Returns true if Configuration instances are equal
        /// </summary>
        /// <param name="input">Instance of Configuration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Configuration input)
        {
            if (input == null)
                return false;

            return
                (
                    Avs == input.Avs ||
                    Avs != null &&
                    Avs.Equals(input.Avs)
                ) &&
                (
                    CardHolderName == input.CardHolderName ||
                    CardHolderName != null &&
                    CardHolderName.Equals(input.CardHolderName)
                ) &&
                (
                    Installments == input.Installments ||
                    Installments != null &&
                    Installments.Equals(input.Installments)
                ) &&
                (
                    ShopperInput == input.ShopperInput ||
                    ShopperInput != null &&
                    ShopperInput.Equals(input.ShopperInput)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Avs != null)
                    hashCode = hashCode * 59 + Avs.GetHashCode();
                if (CardHolderName != null)
                    hashCode = hashCode * 59 + CardHolderName.GetHashCode();
                if (Installments != null)
                    hashCode = hashCode * 59 + Installments.GetHashCode();
                if (ShopperInput != null)
                    hashCode = hashCode * 59 + ShopperInput.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}