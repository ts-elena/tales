namespace TalesAPI.Controllers
{
    using AutoMapper;
    using Extentions;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Models.PostModels;
    using Models.PutModels;
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

        [HttpGet("{storyId}/{lineNumber}")]
        [ProducesResponseType(typeof(LineNumber), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<LineNumber>> GetLineNumberOfStory(Guid storyId, int lineNumber)
        {
            var lineSequence = await _lineNumberService.LineNumbersOfStory(storyId, lineNumber);

            if (lineSequence == null) return NotFound();

            return Ok(_mapper.Map<LineNumber, LineNumberModel>(lineSequence));
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PutLineNumbers([FromBody] List<UpdateLineNumberModel> lineNumbersModels)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var lineNumbers =
                _mapper.Map<List<UpdateLineNumberModel>, List<LineNumber>>(lineNumbersModels);
            var result = await _lineNumberService.UpdateRangeAsync(lineNumbers);

            if (!result.Success) return NotFound("Could not find the lines to update. Check the provided IDs");

            return Ok(_mapper.Map<IEnumerable<LineNumber>,
                IEnumerable<LineNumberModel>>(result.DbObject));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<LineNumberModel>> PostLineNumbers([FromBody] IEnumerable<SaveLineNumberModel> Model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

            var lineNumbers = _mapper.Map<IEnumerable<SaveLineNumberModel>, IEnumerable<LineNumber>>(Model);
            var result = await _lineNumberService.AddRangeAsync(lineNumbers.ToList());

            if (!result.Success) return BadRequest();

            return Ok(_mapper.Map<IEnumerable<LineNumber>, IEnumerable<LineNumberModel>>(result.DbObject));
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<LineNumberModel>> DeleteLineNumbersByIds([FromBody] IEnumerable<Guid> lineNumbersIds)
        {
            var result = await _lineNumberService.DeleteRangeByLineId(lineNumbersIds);
            if (!result.Success) return NotFound();

            return Ok(_mapper.Map<IEnumerable<LineNumber>,
                IEnumerable<LineNumberModel>>(result.DbObject));
        }
    }
}
