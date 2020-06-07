namespace TalesAPI.Controllers
{
    using AutoMapper;
    using Extentions;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Resources;
    using Resources.PostResources;
    using Resources.PutResources;
    using Services.ServiceInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TalesApp.Domain;

    [Route("api/[controller]")]
    [ApiController]
    public class LineNumberController : ControllerBase
    {
        private readonly ILineNumberService _lineNumberService;
        private readonly IMapper _mapper;

        public LineNumberController(ILineNumberService service, IMapper mapper)
        {
            _lineNumberService = service;
            _mapper = mapper;
        }

        [HttpGet("{storyId}")]
        [ProducesResponseType(typeof(IEnumerable<LineNumber>), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<LineNumber>>> GetLineNumbersOfStory(Guid storyId)
        {
            var lineSequence = await _lineNumberService.LineNumbersOfStory(storyId);

            if (lineSequence == null) return NotFound();

            return Ok(_mapper.Map<IEnumerable<LineNumber>, IEnumerable<LineNumberResource>>(lineSequence));
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PutLineNumbers(List<UpdateLineNumberResource> lineNumbersResources)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var lineNumbers =
                _mapper.Map<List<UpdateLineNumberResource>, List<LineNumber>>(lineNumbersResources);
            var result = await _lineNumberService.UpdateRangeAsync(lineNumbers);

            if (!result.Success) return NotFound("Could not find the lines to update. Check the provided IDs");

            return Ok(_mapper.Map<IEnumerable<LineNumber>,
                IEnumerable<LineNumberResource>>(result.DbObject));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<LineNumberResource>> PostLineNumbers([FromBody] IEnumerable<SaveLineNumberResource> resource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

            var lineNumbers = _mapper.Map<IEnumerable<SaveLineNumberResource>, IEnumerable<LineNumber>>(resource);
            var result = await _lineNumberService.AddRangeAsync(lineNumbers.ToList());

            if (!result.Success) return BadRequest();

            return Ok(_mapper.Map<IEnumerable<LineNumber>, IEnumerable<LineNumberResource>>(result.DbObject));
        }

        [HttpDelete("{storyId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<LineNumberResource>> DeleteAllStoryLineNumbers(Guid storyId)
        {
            var result = await _lineNumberService.DeleteRangeByStoryId(storyId);
            if (!result.Success) return NotFound();

            return Ok(_mapper.Map<IEnumerable<LineNumber>,
                IEnumerable<LineNumberResource>>(result.DbObject));
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<LineNumberResource>> DeleteLineNumbersByIds([FromBody] IEnumerable<Guid> lineNumbersIds)
        {
            var result = await _lineNumberService.DeleteRangeByLineId(lineNumbersIds);
            if (!result.Success) return NotFound();

            return Ok(_mapper.Map<IEnumerable<LineNumber>,
                IEnumerable<LineNumberResource>>(result.DbObject));
        }
    }
}
