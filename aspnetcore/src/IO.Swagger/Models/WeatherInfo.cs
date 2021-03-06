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
    /// 열흘 동안 기상 자료
    /// </summary>
    [DataContract]
    public partial class WeatherInfo : IEquatable<WeatherInfo>
    { 
        /// <summary>
        /// yyyy-MM-dd
        /// </summary>
        /// <value>yyyy-MM-dd</value>
        [DataMember(Name="date")]
        public string Date { get; set; }

        /// <summary>
        /// 최고기온
        /// </summary>
        /// <value>최고기온</value>
        [DataMember(Name="tmax")]
        public string Tmax { get; set; }

        /// <summary>
        /// 최저기온
        /// </summary>
        /// <value>최저기온</value>
        [DataMember(Name="tmin")]
        public string Tmin { get; set; }

        /// <summary>
        /// 강수량
        /// </summary>
        /// <value>강수량</value>
        [DataMember(Name="rainfall")]
        public string Rainfall { get; set; }

        /// <summary>
        /// 평균 풍속
        /// </summary>
        /// <value>평균 풍속</value>
        [DataMember(Name="wmean")]
        public string Wmean { get; set; }

        /// <summary>
        /// 최고 풍속
        /// </summary>
        /// <value>최고 풍속</value>
        [DataMember(Name="wmax")]
        public string Wmax { get; set; }

        /// <summary>
        /// 일사량
        /// </summary>
        /// <value>일사량</value>
        [DataMember(Name="insolation")]
        public string Insolation { get; set; }

        /// <summary>
        /// 일조
        /// </summary>
        /// <value>일조</value>
        [DataMember(Name="sunshine")]
        public string Sunshine { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeatherInfo {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Tmax: ").Append(Tmax).Append("\n");
            sb.Append("  Tmin: ").Append(Tmin).Append("\n");
            sb.Append("  Rainfall: ").Append(Rainfall).Append("\n");
            sb.Append("  Wmean: ").Append(Wmean).Append("\n");
            sb.Append("  Wmax: ").Append(Wmax).Append("\n");
            sb.Append("  Insolation: ").Append(Insolation).Append("\n");
            sb.Append("  Sunshine: ").Append(Sunshine).Append("\n");
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
            return obj.GetType() == GetType() && Equals((WeatherInfo)obj);
        }

        /// <summary>
        /// Returns true if WeatherInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of WeatherInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeatherInfo other)
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
                    Tmax == other.Tmax ||
                    Tmax != null &&
                    Tmax.Equals(other.Tmax)
                ) && 
                (
                    Tmin == other.Tmin ||
                    Tmin != null &&
                    Tmin.Equals(other.Tmin)
                ) && 
                (
                    Rainfall == other.Rainfall ||
                    Rainfall != null &&
                    Rainfall.Equals(other.Rainfall)
                ) && 
                (
                    Wmean == other.Wmean ||
                    Wmean != null &&
                    Wmean.Equals(other.Wmean)
                ) && 
                (
                    Wmax == other.Wmax ||
                    Wmax != null &&
                    Wmax.Equals(other.Wmax)
                ) && 
                (
                    Insolation == other.Insolation ||
                    Insolation != null &&
                    Insolation.Equals(other.Insolation)
                ) && 
                (
                    Sunshine == other.Sunshine ||
                    Sunshine != null &&
                    Sunshine.Equals(other.Sunshine)
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
                    if (Tmax != null)
                    hashCode = hashCode * 59 + Tmax.GetHashCode();
                    if (Tmin != null)
                    hashCode = hashCode * 59 + Tmin.GetHashCode();
                    if (Rainfall != null)
                    hashCode = hashCode * 59 + Rainfall.GetHashCode();
                    if (Wmean != null)
                    hashCode = hashCode * 59 + Wmean.GetHashCode();
                    if (Wmax != null)
                    hashCode = hashCode * 59 + Wmax.GetHashCode();
                    if (Insolation != null)
                    hashCode = hashCode * 59 + Insolation.GetHashCode();
                    if (Sunshine != null)
                    hashCode = hashCode * 59 + Sunshine.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(WeatherInfo left, WeatherInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(WeatherInfo left, WeatherInfo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
