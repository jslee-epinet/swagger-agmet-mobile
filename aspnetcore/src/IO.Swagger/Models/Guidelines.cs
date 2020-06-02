/*
 * agmet_mobile_version_update 
 *
 * version update
 *
 * OpenAPI spec version: 1.0.0-oas3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 작목별로 대응지침을 알려준다. 만약 재해가 발생하지 않았다면 해당 대응지침은 나오지 않는다. ex) freeze(동해)가 0일 경우 freeze에 해당하는 대응지침은 안나옴
    /// </summary>
    [DataContract]
    public partial class Guidelines : IEquatable<Guidelines>
    { 
        /// <summary>
        /// 재해 발생 날짜
        /// </summary>
        /// <value>재해 발생 날짜</value>
        [DataMember(Name="date")]
        public string Date { get; set; }

        /// <summary>
        /// 해당 농가 작목
        /// </summary>
        /// <value>해당 농가 작목</value>
        [DataMember(Name="plant")]
        public Object Plant { get; set; }

        /// <summary>
        /// 해당되는 대응지침
        /// </summary>
        /// <value>해당되는 대응지침</value>
        [DataMember(Name="content")]
        public List<DisasterGuidelines> Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Guidelines {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Plant: ").Append(Plant).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Guidelines)obj);
        }

        /// <summary>
        /// Returns true if Guidelines instances are equal
        /// </summary>
        /// <param name="other">Instance of Guidelines to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Guidelines other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    Plant == other.Plant ||
                    Plant != null &&
                    Plant.Equals(other.Plant)
                ) && 
                (
                    Content == other.Content ||
                    Content != null &&
                    Content.SequenceEqual(other.Content)
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
                // Suitable nullity checks etc, of course :)
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (Plant != null)
                    hashCode = hashCode * 59 + Plant.GetHashCode();
                    if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Guidelines left, Guidelines right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Guidelines left, Guidelines right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}