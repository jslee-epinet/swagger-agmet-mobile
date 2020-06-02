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
    /// 설문조사를 완료한 데이터
    /// </summary>
    [DataContract]
    public partial class SendSurveyData : IEquatable<SendSurveyData>
    { 
        /// <summary>
        /// 농가 id
        /// </summary>
        /// <value>농가 id</value>
        [DataMember(Name="farmId")]
        public int? FarmId { get; set; }

        /// <summary>
        /// 재해가 발생한 날짜
        /// </summary>
        /// <value>재해가 발생한 날짜</value>
        [DataMember(Name="date")]
        public string Date { get; set; }

        /// <summary>
        /// 작목
        /// </summary>
        /// <value>작목</value>
        [DataMember(Name="plant")]
        public string Plant { get; set; }

        /// <summary>
        /// 생육단계
        /// </summary>
        /// <value>생육단계</value>
        [DataMember(Name="growthStage")]
        public string GrowthStage { get; set; }

        /// <summary>
        /// 재해 종류에 따른 답변 | 답변 0은 설문 미완료 1은 모름 2은 발생 3는 발생없음
        /// </summary>
        /// <value>재해 종류에 따른 답변 | 답변 0은 설문 미완료 1은 모름 2은 발생 3는 발생없음</value>
        [DataMember(Name="answer")]
        public List<SurveyContent> Answer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendSurveyData {\n");
            sb.Append("  FarmId: ").Append(FarmId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Plant: ").Append(Plant).Append("\n");
            sb.Append("  GrowthStage: ").Append(GrowthStage).Append("\n");
            sb.Append("  Answer: ").Append(Answer).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SendSurveyData)obj);
        }

        /// <summary>
        /// Returns true if SendSurveyData instances are equal
        /// </summary>
        /// <param name="other">Instance of SendSurveyData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendSurveyData other)
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
                    GrowthStage == other.GrowthStage ||
                    GrowthStage != null &&
                    GrowthStage.Equals(other.GrowthStage)
                ) && 
                (
                    Answer == other.Answer ||
                    Answer != null &&
                    Answer.SequenceEqual(other.Answer)
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
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (Plant != null)
                    hashCode = hashCode * 59 + Plant.GetHashCode();
                    if (GrowthStage != null)
                    hashCode = hashCode * 59 + GrowthStage.GetHashCode();
                    if (Answer != null)
                    hashCode = hashCode * 59 + Answer.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SendSurveyData left, SendSurveyData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SendSurveyData left, SendSurveyData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
