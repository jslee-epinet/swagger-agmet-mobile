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
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class SurveyApiController : ControllerBase
    { 
        /// <summary>
        /// 설문조사 페이지
        /// </summary>
        /// <remarks>예측 시스템이 얼마나 맞았는지 설문지를 가져온다. </remarks>
        /// <param name="farmId">해당 농가 id</param>
        /// <param name="plant">해당 농가가 키우고 있는 작물. 기본값은 우선순위를 정해서 가져온다.</param>
        /// <param name="date">재해가 발생한 날짜</param>
        /// <response code="200">작성 성공</response>
        [HttpGet]
        [Route("/mobile/survey")]
        [ValidateModelState]
        [SwaggerOperation("MobileSurveyGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<SurveyInfo>), description: "작성 성공")]
        public virtual IActionResult MobileSurveyGet([FromQuery][Required()]int? farmId, [FromQuery][Required()]string plant, [FromQuery]string date)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<SurveyInfo>));
            string exampleJson = null;
            exampleJson = "[ {\n  \"farmInfo\" : [ {\n    \"regionId\" : 111,\n    \"plant\" : [ {\n      \"ko\" : \"사과\",\n      \"growthStage\" : [ \"과실비대초기\", \"과육단계\" ],\n      \"id\" : \"apple\"\n    }, {\n      \"ko\" : \"사과\",\n      \"growthStage\" : [ \"과실비대초기\", \"과육단계\" ],\n      \"id\" : \"apple\"\n    } ],\n    \"regionNm\" : \"고창면 고창리 123-234\",\n    \"farmId\" : 253\n  }, {\n    \"regionId\" : 111,\n    \"plant\" : [ {\n      \"ko\" : \"사과\",\n      \"growthStage\" : [ \"과실비대초기\", \"과육단계\" ],\n      \"id\" : \"apple\"\n    }, {\n      \"ko\" : \"사과\",\n      \"growthStage\" : [ \"과실비대초기\", \"과육단계\" ],\n      \"id\" : \"apple\"\n    } ],\n    \"regionNm\" : \"고창면 고창리 123-234\",\n    \"farmId\" : 253\n  } ],\n  \"content\" : [ {\n    \"burn\" : 0,\n    \"freeze\" : 0,\n    \"lt\" : 1,\n    \"ht\" : 0,\n    \"water\" : 3,\n    \"wind\" : 2\n  }, {\n    \"burn\" : 0,\n    \"freeze\" : 0,\n    \"lt\" : 1,\n    \"ht\" : 0,\n    \"water\" : 3,\n    \"wind\" : 2\n  } ]\n}, {\n  \"farmInfo\" : [ {\n    \"regionId\" : 111,\n    \"plant\" : [ {\n      \"ko\" : \"사과\",\n      \"growthStage\" : [ \"과실비대초기\", \"과육단계\" ],\n      \"id\" : \"apple\"\n    }, {\n      \"ko\" : \"사과\",\n      \"growthStage\" : [ \"과실비대초기\", \"과육단계\" ],\n      \"id\" : \"apple\"\n    } ],\n    \"regionNm\" : \"고창면 고창리 123-234\",\n    \"farmId\" : 253\n  }, {\n    \"regionId\" : 111,\n    \"plant\" : [ {\n      \"ko\" : \"사과\",\n      \"growthStage\" : [ \"과실비대초기\", \"과육단계\" ],\n      \"id\" : \"apple\"\n    }, {\n      \"ko\" : \"사과\",\n      \"growthStage\" : [ \"과실비대초기\", \"과육단계\" ],\n      \"id\" : \"apple\"\n    } ],\n    \"regionNm\" : \"고창면 고창리 123-234\",\n    \"farmId\" : 253\n  } ],\n  \"content\" : [ {\n    \"burn\" : 0,\n    \"freeze\" : 0,\n    \"lt\" : 1,\n    \"ht\" : 0,\n    \"water\" : 3,\n    \"wind\" : 2\n  }, {\n    \"burn\" : 0,\n    \"freeze\" : 0,\n    \"lt\" : 1,\n    \"ht\" : 0,\n    \"water\" : 3,\n    \"wind\" : 2\n  } ]\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<SurveyInfo>>(exampleJson)
                        : default(List<SurveyInfo>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 설문조사 작성
        /// </summary>
        /// <remarks>예측 시스템이 얼마나 맞았는지 사용자가 설문을 작성한다. </remarks>
        /// <param name="body">설문 작성 내용이 담겨있는 요청 본문</param>
        /// <response code="201">작성 성공</response>
        [HttpPost]
        [Route("/mobile/survey/submit")]
        [ValidateModelState]
        [SwaggerOperation("MobileSurveySubmitPost")]
        public virtual IActionResult MobileSurveySubmitPost([FromBody]SendSurveyData body)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201);

            throw new NotImplementedException();
        }
    }
}