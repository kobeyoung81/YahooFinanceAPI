/* 
 * Yahoo Finance Term Search API
 *
 * This is the API from yahoo finance to search for symbols.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: kobeyoung81@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = YahooFinance.SearchTerm.Client.SwaggerDateConverter;

namespace YahooFinance.SearchTerm.Model
{
    /// <summary>
    /// QuoteResponseContent
    /// </summary>
    [DataContract]
        public partial class QuoteResponseContent :  IEquatable<QuoteResponseContent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteResponseContent" /> class.
        /// </summary>
        /// <param name="quoteResponse">quoteResponse.</param>
        /// <param name="error">error.</param>
        public QuoteResponseContent(QuoteResponseContentQuoteResponse quoteResponse = default(QuoteResponseContentQuoteResponse), string error = default(string))
        {
            this.QuoteResponse = quoteResponse;
            this.Error = error;
        }
        
        /// <summary>
        /// Gets or Sets QuoteResponse
        /// </summary>
        [DataMember(Name="quoteResponse", EmitDefaultValue=false)]
        public QuoteResponseContentQuoteResponse QuoteResponse { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuoteResponseContent {\n");
            sb.Append("  QuoteResponse: ").Append(QuoteResponse).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as QuoteResponseContent);
        }

        /// <summary>
        /// Returns true if QuoteResponseContent instances are equal
        /// </summary>
        /// <param name="input">Instance of QuoteResponseContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteResponseContent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuoteResponse == input.QuoteResponse ||
                    (this.QuoteResponse != null &&
                    this.QuoteResponse.Equals(input.QuoteResponse))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                int hashCode = 41;
                if (this.QuoteResponse != null)
                    hashCode = hashCode * 59 + this.QuoteResponse.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }
    }
}
