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
    using System.Threading.Tasks;
    using TalesApp.Domain;

    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        private readonly IMapper _mapper;

        public CharacterController(ICharacterService service, IMapper mapper)
        {
            _characterService = service;
            _mapper = mapper;
        }

        [HttpGet("{characterId}")]
        [ProducesResponseType(typeof(IEnumerable<StorySetNumberModel>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CharacterModel>> GetCharacter(Guid characterId)
        {
            var character = await _characterService.FindAsync(characterId);

            if (character == null) return NotFound();

            return Ok(_mapper.Map<Character, CharacterModel>(character));
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutCharactersRange([FromBody] List<UpdateCharacterModel> charactersModels)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

            var characters =
                _mapper.Map<List<UpdateCharacterModel>, List<Character>>(charactersModels);
            var result = await _characterService.UpdateRangeAsync(characters);

            if (!result.Success) return BadRequest(result.Message);

            return Ok(_mapper.Map<IEnumerable<Character>, IEnumerable<CharacterModel>>(result.DbObject));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<LineNumberModel>> PostCharactersRange([FromBody] List<SaveCharacterModel> Model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

            var characters = _mapper.Map<List<SaveCharacterModel>, List<Character>>(Model);

            var result = await _characterService.SaveRangeAsync(characters);

            if (!result.Success) return BadRequest();

            return Ok(_mapper.Map<IEnumerable<Character>,
                IEnumerable<CharacterModel>>(result.DbObject));
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CharacterModel>> DeleteRange([FromBody] List<Guid> charactersIds)
        {
            List<Character> characters = new List<Character>();

            foreach (var characterId in charactersIds)
            {
                characters.Add(_characterService.FindAsync(characterId).Result);
            }

            var result = await _characterService.DeleteAsync(characters);

            if (!result.Success) return NotFound();

            return Ok(_mapper.Map<IEnumerable<Character>, IEnumerable<CharacterModel>>(result.DbObject));
        }
    }
}
