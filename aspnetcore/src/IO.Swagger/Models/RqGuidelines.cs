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
    /// 대응지침을 요청하기 위한 본문
    /// </summary>
    [DataContract]
    public partial class RqGuidelines : IEquatable<RqGuidelines>
    { 
        /// <summary>
        /// 농가 id
        /// </summary>
        /// <value>농가 id</value>
        [DataMember(Name="farmId")]
        public int? FarmId { get; set; }

        /// <summary>
        /// 해당 농가 작목
        /// </summary>
        /// <value>해당 농가 작목</value>
        [DataMember(Name="plant")]
        public string Plant { get; set; }

        /// <summary>
        /// 재해가 발생한 날자
        /// </summary>
        /// <value>재해가 발생한 날자</value>
        [DataMember(Name="date")]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets Disaster
        /// </summary>
        [DataMember(Name="disaster")]
        public Object Disaster { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RqGuidelines {\n");
            sb.Append("  FarmId: ").Append(FarmId).Append("\n");
            sb.Append("  Plant: ").Append(Plant).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Disaster: ").Append(Disaster).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RqGuidelines)obj);
        }

        /// <summary>
        /// Returns true if RqGuidelines instances are equal
        /// </summary>
        /// <param name="other">Instance of RqGuidelines to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RqGuidelines other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FarmId == other.FarmId ||
                    FarmId != null &&
                    FarmId.Equals(other.FarmId)
                ) && 
                (
                    Plant == other.Plant ||
                    Plant != null &&
                    Plant.Equals(other.Plant)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.Equals(other.Date)
                ) && 
                (
                    Disaster == other.Disaster ||
                    Disaster != null &&
                    Disaster.Equals(other.Disaster)
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
                    if (FarmId != null)
                    hashCode = hashCode * 59 + FarmId.GetHashCode();
                    if (Plant != null)
                    hashCode = hashCode * 59 + Plant.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (Disaster != null)
                    hashCode = hashCode * 59 + Disaster.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RqGuidelines left, RqGuidelines right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RqGuidelines left, RqGuidelines right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
