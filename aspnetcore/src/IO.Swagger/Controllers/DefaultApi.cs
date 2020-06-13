/*
 * Lines Collection
 *
 * Endpoints for updating Lines of Tales App
 *
 * OpenAPI spec version: 0.1
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
    public class DefaultApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Delete all lines of a story</remarks>
        /// <param name="body"></param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Access Denied</response>
        /// <response code="404">The resource is not found</response>
        [HttpDelete]
        [Route("/api/Line")]
        [ValidateModelState]
        [SwaggerOperation("ApiLineDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(ArrayOfLines), description: "OK")]
        public virtual IActionResult ApiLineDelete([FromBody]List<string> body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ArrayOfLines));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\n  \"CharacterId\" : \"f89da017-05bb-48b0-c02f-08d80a57a67b\",\n  \"LineId\" : \"e520e6df-4ac0-49c8-7dcd-08d80a569eba\",\n  \"LineContent\" : \"You can't live your life for other people. You've got to do what's right for you, even if it hurts some people you love.\"\n}, {\n  \"CharacterId\" : \"a58da017-05bb-48b0-c02f-08d80a57s458\",\n  \"LineId\" : \"d589e6df-4ac0-49c8-7dcd-08d80a548lfg\",\n  \"LineContent\" : \"I'll be back!\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ArrayOfLines>(exampleJson)
                        : default(ArrayOfLines);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Delete all lines of a story</remarks>
        /// <param name="id">An ID to look up one or more values</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Access Denied</response>
        /// <response code="404">The resource is not found</response>
        [HttpDelete]
        [Route("/api/Line/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ApiLineIdDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(ArrayOfLines), description: "OK")]
        public virtual IActionResult ApiLineIdDelete([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ArrayOfLines));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\n  \"CharacterId\" : \"f89da017-05bb-48b0-c02f-08d80a57a67b\",\n  \"LineId\" : \"e520e6df-4ac0-49c8-7dcd-08d80a569eba\",\n  \"LineContent\" : \"You can't live your life for other people. You've got to do what's right for you, even if it hurts some people you love.\"\n}, {\n  \"CharacterId\" : \"a58da017-05bb-48b0-c02f-08d80a57s458\",\n  \"LineId\" : \"d589e6df-4ac0-49c8-7dcd-08d80a548lfg\",\n  \"LineContent\" : \"I'll be back!\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ArrayOfLines>(exampleJson)
                        : default(ArrayOfLines);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Returns Line by Line ID</remarks>
        /// <param name="id">An ID to look up one or more values</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Access Denied</response>
        /// <response code="404">The resource is not found</response>
        [HttpGet]
        [Route("/api/Line/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ApiLineIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Line), description: "OK")]
        public virtual IActionResult ApiLineIdGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Line));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"LineId\" : \"LineId\",\n  \"LineContent\" : \"LineContent\",\n  \"CharacterId\" : \"CharacterId\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Line>(exampleJson)
                        : default(Line);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Delete Line Numbers</remarks>
        /// <param name="body">Provide an array of Line Numbers IDs to delete</param>
        /// <response code="200">The Line Numbers were successfully deleted</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Access Denied</response>
        /// <response code="404">The resource is not found</response>
        [HttpDelete]
        [Route("/api/LineNumber")]
        [ValidateModelState]
        [SwaggerOperation("ApiLineNumberDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(ArrayOfLineNumbers), description: "The Line Numbers were successfully deleted")]
        public virtual IActionResult ApiLineNumberDelete([FromBody]List<string> body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ArrayOfLineNumbers));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\n  \"StoryId\" : \"f89da017-05bb-48b0-c02f-08d80a57a67b\",\n  \"LineId\" : \"e520e6df-4ac0-49c8-7dcd-08d80a569eba\",\n  \"Number\" : 1\n}, {\n  \"StoryId\" : \"a58da017-05bb-48b0-c02f-08d80a57s458\",\n  \"LineId\" : \"d589e6df-4ac0-49c8-7dcd-08d80a548lfg\",\n  \"Number\" : 2\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ArrayOfLineNumbers>(exampleJson)
                        : default(ArrayOfLineNumbers);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Delete all Line Numbers of a Story</remarks>
        /// <param name="id">An ID to look up one or more values</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Access Denied</response>
        /// <response code="404">The resource is not found</response>
        [HttpDelete]
        [Route("/api/LineNumber/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ApiLineNumberIdDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(ArrayOfLineNumbers), description: "OK")]
        public virtual IActionResult ApiLineNumberIdDelete([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ArrayOfLineNumbers));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\n  \"StoryId\" : \"f89da017-05bb-48b0-c02f-08d80a57a67b\",\n  \"LineId\" : \"e520e6df-4ac0-49c8-7dcd-08d80a569eba\",\n  \"Number\" : 1\n}, {\n  \"StoryId\" : \"a58da017-05bb-48b0-c02f-08d80a57s458\",\n  \"LineId\" : \"d589e6df-4ac0-49c8-7dcd-08d80a548lfg\",\n  \"Number\" : 2\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ArrayOfLineNumbers>(exampleJson)
                        : default(ArrayOfLineNumbers);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get Line by its Id</remarks>
        /// <param name="id">An ID to look up one or more values</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Access Denied</response>
        /// <response code="404">The resource is not found</response>
        [HttpGet]
        [Route("/api/LineNumber/{id}")]
        [ValidateModelState]
        [SwaggerOperation("ApiLineNumberIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(LineNumber), description: "OK")]
        public virtual IActionResult ApiLineNumberIdGet([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(LineNumber));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"LineId\" : \"LineId\",\n  \"Number\" : 0.8008281904610115,\n  \"StoryId\" : \"StoryId\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<LineNumber>(exampleJson)
                        : default(LineNumber);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Add new Line Numbers</remarks>
        /// <param name="body">Provide an array of Line Numbers to create</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Access Denied</response>
        /// <response code="404">The resource is not found</response>
        [HttpPost]
        [Route("/api/LineNumber")]
        [ValidateModelState]
        [SwaggerOperation("ApiLineNumberPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ArrayOfLineNumbers), description: "OK")]
        public virtual IActionResult ApiLineNumberPost([FromBody]List<ArrayOfLineNumbersInner> body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ArrayOfLineNumbers));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\n  \"StoryId\" : \"f89da017-05bb-48b0-c02f-08d80a57a67b\",\n  \"LineId\" : \"e520e6df-4ac0-49c8-7dcd-08d80a569eba\",\n  \"Number\" : 1\n}, {\n  \"StoryId\" : \"a58da017-05bb-48b0-c02f-08d80a57s458\",\n  \"LineId\" : \"d589e6df-4ac0-49c8-7dcd-08d80a548lfg\",\n  \"Number\" : 2\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ArrayOfLineNumbers>(exampleJson)
                        : default(ArrayOfLineNumbers);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Update Line Numbers of a Line to describe in what sequence they need to be in the story</remarks>
        /// <param name="body"></param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Access Denied</response>
        /// <response code="404">The resource is not found</response>
        [HttpPut]
        [Route("/api/LineNumber")]
        [ValidateModelState]
        [SwaggerOperation("ApiLineNumberPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(ArrayOfLineNumbers), description: "OK")]
        public virtual IActionResult ApiLineNumberPut([FromBody]List<ArrayOfLineNumbersInner> body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ArrayOfLineNumbers));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\n  \"StoryId\" : \"f89da017-05bb-48b0-c02f-08d80a57a67b\",\n  \"LineId\" : \"e520e6df-4ac0-49c8-7dcd-08d80a569eba\",\n  \"Number\" : 1\n}, {\n  \"StoryId\" : \"a58da017-05bb-48b0-c02f-08d80a57s458\",\n  \"LineId\" : \"d589e6df-4ac0-49c8-7dcd-08d80a548lfg\",\n  \"Number\" : 2\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ArrayOfLineNumbers>(exampleJson)
                        : default(ArrayOfLineNumbers);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Add new Lines</remarks>
        /// <param name="body"></param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Access Denied</response>
        /// <response code="404">The resource is not found</response>
        [HttpPost]
        [Route("/api/Line")]
        [ValidateModelState]
        [SwaggerOperation("ApiLinePost")]
        [SwaggerResponse(statusCode: 200, type: typeof(ArrayOfLines), description: "OK")]
        public virtual IActionResult ApiLinePost([FromBody]List<ArrayOfLinesInner> body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ArrayOfLines));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\n  \"CharacterId\" : \"f89da017-05bb-48b0-c02f-08d80a57a67b\",\n  \"LineId\" : \"e520e6df-4ac0-49c8-7dcd-08d80a569eba\",\n  \"LineContent\" : \"You can't live your life for other people. You've got to do what's right for you, even if it hurts some people you love.\"\n}, {\n  \"CharacterId\" : \"a58da017-05bb-48b0-c02f-08d80a57s458\",\n  \"LineId\" : \"d589e6df-4ac0-49c8-7dcd-08d80a548lfg\",\n  \"LineContent\" : \"I'll be back!\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ArrayOfLines>(exampleJson)
                        : default(ArrayOfLines);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Edit Existing Lines</remarks>
        /// <param name="body"></param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Access Denied</response>
        /// <response code="404">The resource is not found</response>
        [HttpPut]
        [Route("/api/Line")]
        [ValidateModelState]
        [SwaggerOperation("ApiLinePut")]
        [SwaggerResponse(statusCode: 200, type: typeof(ArrayOfLines), description: "OK")]
        public virtual IActionResult ApiLinePut([FromBody]List<ArrayOfLinesInner> body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ArrayOfLines));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "[ {\n  \"CharacterId\" : \"f89da017-05bb-48b0-c02f-08d80a57a67b\",\n  \"LineId\" : \"e520e6df-4ac0-49c8-7dcd-08d80a569eba\",\n  \"LineContent\" : \"You can't live your life for other people. You've got to do what's right for you, even if it hurts some people you love.\"\n}, {\n  \"CharacterId\" : \"a58da017-05bb-48b0-c02f-08d80a57s458\",\n  \"LineId\" : \"d589e6df-4ac0-49c8-7dcd-08d80a548lfg\",\n  \"LineContent\" : \"I'll be back!\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ArrayOfLines>(exampleJson)
                        : default(ArrayOfLines);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
