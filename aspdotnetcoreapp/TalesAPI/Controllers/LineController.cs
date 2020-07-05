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
    using TalesApp.Domain.Services.Communication;
    using Models.PutModels;

    [Route("api/[controller]")]
    [ApiController]
    public class LineController : ControllerBase
    {
        private readonly ILineService _lineService;
        private readonly IMapper _mapper;

        public LineController(ILineService service, IMapper mapper)
        {
            _lineService = service;
            _mapper = mapper;
        }


        [HttpGet("{lineId:Guid}", Name = "GetLineById")]
        [ProducesResponseType(typeof(LineModel), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<LineModel>> GetLineById(Guid lineId)
        {
            Line line = await _lineService.LineByIdOrDefault(lineId);

            if (line == null)
                return NotFound();

            return _mapper.Map<Line, LineModel>(line);
        }


        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutLinesRange([FromBody] IEnumerable<UpdateLineModel> Model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            IEnumerable<Line> lines = _mapper.Map<IEnumerable<UpdateLineModel>, IEnumerable<Line>>(Model);
            Response<IEnumerable<Line>> result = await _lineService.UpdateRangeAsync(lines);
            if (!result.Success)
                return BadRequest();

            return Ok(_mapper.Map<IEnumerable<Line>, IEnumerable<LineModel>>(result.DbObject));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Line>> PostLinesRange([FromBody] List<SaveLineModel> Model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            IEnumerable<Line> lines = _mapper.Map<List<SaveLineModel>, List<Line>>(Model);

            Response<IEnumerable<Line>> result = await _lineService.SaveRangeAsync(lines);

            if (!result.Success)
                return BadRequest();

            return Ok(_mapper.Map<IEnumerable<Line>, IEnumerable<LineModel>>(result.DbObject));
        }


        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<LineModel>> DeleteLinesRange([FromBody] IEnumerable<Guid> lineIds)
        {
            Response<IEnumerable<Line>> result = await _lineService.DeleteRangeAsync(lineIds);

            if (!result.Success)
                return NotFound();

            return Ok(_mapper.Map<IEnumerable<Line>, IEnumerable<LineModel>>(result.DbObject));
        }
    }
}
