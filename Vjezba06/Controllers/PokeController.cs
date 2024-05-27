using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vjezba06.Services;

namespace Vjezba06.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokeController : ControllerBase
    {
        private readonly IPokemonService pokeService;
        public PokeController(IPokemonService pokeService)
        {

            this.pokeService = pokeService;
        }

        [HttpGet("[action]")]
        public IActionResult GetPokemons() 
        {
            return Ok(pokeService.GetPokemons());
        }

        [HttpGet("[action]")]
        public IActionResult GetPokemon(int id)
        {
            return Ok(pokeService.GetPokemon(id));
        }
    }
}
