using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Models.Repository
{
    public interface IPokemonRepository
    {
        List<Pokemon> GetAllPokemons();
        Pokemon GetPokemonById(int pokemonId);
    }
}
