namespace Vjezba06.Services
{
    public interface IPokemonService
    {
        public Pokemon GetPokemon(int id);
        public List<Pokemon> GetPokemons();
    }

    public class PokemonService : IPokemonService
    {
        private static readonly List<Pokemon> pokemons = new List<Pokemon>(
            new Pokemon[] {

            new Pokemon
            {
                Id = 1,
                Name = "Snorlax",
                Type = "Belancuga",
                Level = 200
            },

            new Pokemon
            {
                Id = 2,
                Name = "Maro Jeguljica",
                Type = "OG",
                Level = 15
            },

             new Pokemon
            {
                Id = 3,
                Name = "Zava Skockalone",
                Type = "Roblox",
                Level = 2
            }

            });



        public Pokemon GetPokemon(int id)
        {
            return pokemons[id];
        }

        public List<Pokemon> GetPokemons()
        {
            return pokemons;
        }
    }
}
