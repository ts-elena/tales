namespace TalesAPI.Controllers
{
    using AutoMapper;
    using Extentions;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Models.PostModels;
    using Services.ServiceInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Domain;
    using Models.PutModels;

    [Route("api/[controller]")]
    [ApiController]
    public class StorySetController : ControllerBase
    {
        private readonly IStorySetService _storySetService;
        private readonly IMapper _mapper;

        public StorySetController(IStorySetService storySetService, IMapper mapper)
        {
            _storySetService = storySetService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<StorySetModel>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IEnumerable<StorySetModel>> GetStorySets()
        {
            var storySets = await _storySetService.ListAsync();
            var storySetDto = _mapper
                .Map<IEnumerable<StorySet>, IEnumerable<StorySetModel>>(storySets);
            return storySetDto;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(StorySetModel), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<StorySetModel>> GetStorySet(Guid id)
        {
            var storySet = await _storySetService.FindAsync(id);
            var storySetDto = _mapper.Map<StorySet, StorySetModel>(storySet);
            if (storySet == null) return NotFound();
            return storySetDto;
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutStorySet([FromBody] UpdateStorySetModel Model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var storySet = _mapper.Map<UpdateStorySetModel, StorySet>(Model);
            var result = await _storySetService.UpdateAsync(storySet);

            if (!result.Success) return BadRequest();

            var storySetModel = _mapper.Map<StorySet, StorySetModel>(result.DbObject);

            return Ok(storySetModel);
        }

        [HttpPost]
        [ProducesResponseType(typeof(StorySetModel), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<StorySetModel>> PostStorySet([FromBody] SaveStorySetModel saveStorySetModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var storySet = _mapper.Map<SaveStorySetModel, StorySet>(saveStorySetModel);
            var result = await _storySetService.SaveAsync(storySet);

            if (!result.Success) return BadRequest();

            var storySetModel = _mapper.Map<StorySet, StorySetModel>(result.DbObject);
            return Ok(storySetModel);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteStorySet(Guid id)
        {
            var result = await _storySetService.DeleteAsync(id);
            if (result == null) return NotFound();

            if (!result.Success)
                return BadRequest(result.Message);

            var storySetModel = _mapper.Map<StorySet, StorySetModel>(result.DbObject);
            return Ok(storySetModel);
        }
    }
}
