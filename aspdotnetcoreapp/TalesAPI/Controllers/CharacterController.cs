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
        [ProducesResponseType(typeof(IEnumerable<StorySetNumberResource>), 200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CharacterResource>> GetCharacter(Guid characterId)
        {
            var character = await _characterService.FindAsync(characterId);

            if (character == null) return NotFound();

            return Ok(_mapper.Map<Character, CharacterResource>(character));
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutCharactersRange([FromBody] List<UpdateCharacterResource> charactersResources)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

            var characters =
                _mapper.Map<List<UpdateCharacterResource>, List<Character>>(charactersResources);
            var result = await _characterService.UpdateRangeAsync(characters);

            if (!result.Success) return BadRequest(result.Message);

            return Ok(_mapper.Map<IEnumerable<Character>, IEnumerable<CharacterResource>>(result.DbObject));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<LineNumberResource>> PostCharactersRange([FromBody] List<SaveCharacterResource> resource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

            var characters = _mapper.Map<List<SaveCharacterResource>, List<Character>>(resource);

            var result = await _characterService.SaveRangeAsync(characters);

            if (!result.Success) return BadRequest();

            return Ok(_mapper.Map<IEnumerable<Character>,
                IEnumerable<CharacterResource>>(result.DbObject));
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CharacterResource>> DeleteRange([FromBody] List<Guid> charactersIds)
        {
            List<Character> characters = new List<Character>();

            foreach (var characterId in charactersIds)
            {
                characters.Add(_characterService.FindAsync(characterId).Result);
            }

            var result = await _characterService.DeleteAsync(characters);

            if (!result.Success) return NotFound();

            return Ok(_mapper.Map<IEnumerable<Character>, IEnumerable<CharacterResource>>(result.DbObject));
        }
    }
}
