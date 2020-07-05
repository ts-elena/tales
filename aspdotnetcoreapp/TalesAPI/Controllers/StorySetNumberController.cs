namespace TalesAPI.Controllers
{
    using AutoMapper;
    using Extentions;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Models.PostModels;
    using Services;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Domain;
    using Models.PutModels;

    [Route("api/[controller]")]
    [ApiController]
    public class StorySetNumberController : ControllerBase
    {
        private readonly IStorySetNumberService _storySetsNumberService;
        private readonly IMapper _mapper;

        public StorySetNumberController(IStorySetNumberService storySetsNumberService, IMapper mapper)
        {
            _storySetsNumberService = storySetsNumberService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<StorySetNumberModel>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IEnumerable<StorySetNumberModel>> GetStorySetNumbers()
        {
            var storySetNumber = await _storySetsNumberService.ListAsync();
            IEnumerable<StorySetNumberModel> storySetNumberDto = _mapper
                .Map<IEnumerable<StorySetNumber>, IEnumerable<StorySetNumberModel>>(storySetNumber);
            return storySetNumberDto;
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostStorySetNumber([FromBody] SaveStorySetNumberModel saveStorySetNumber)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }

            var storySetSequence = _mapper.Map<SaveStorySetNumberModel, StorySetNumber>(saveStorySetNumber);
            var result = await _storySetsNumberService.SaveAsync(storySetSequence);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            var storySetsModel = _mapper.Map<StorySetNumber, StorySetNumberModel>(result.DbObject);
            return Ok(storySetsModel);
        }

        /// <summary>
        /// Updates an existing story sets sequence according to an identifier.
        /// </summary>
        /// <param name="Model">Updated sequence data.</param>
        /// <returns>Response for the request.</returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutAsync([FromBody] UpdateStorySetNumberModel Model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var storySetNumber = _mapper.Map<UpdateStorySetNumberModel, StorySetNumber>(Model);
            var result = await _storySetsNumberService.UpdateAsync(storySetNumber);

            if (!result.Success)
            {
                return BadRequest();
            }

            return Ok(_mapper.Map<StorySetNumber, StorySetNumberModel>(result.DbObject));
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var result = await _storySetsNumberService.DeleteAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var storySetNumberModel = _mapper.Map<StorySetNumber, StorySetNumberModel>(result.DbObject);
            return Ok(storySetNumberModel);
        }
    }
}
