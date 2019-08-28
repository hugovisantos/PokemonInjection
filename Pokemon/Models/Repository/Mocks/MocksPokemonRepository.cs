using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Models.Repository.Mocks
{
    public class MocksPokemonRepository : IPokemonRepository
    {
        public List<Pokemon> GetAllPokemons()
        {
            throw new NotImplementedException();
        }

        public Pokemon GetPokemonById(int pokemonId)
        {
            throw new NotImplementedException();
        }
    }
}
