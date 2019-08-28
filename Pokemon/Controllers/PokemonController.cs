using Microsoft.AspNetCore.Mvc;
using Pokemon.Models.Repository.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private MocksPokemonRepository _mockspokemonRepository;

        public PokemonController(MocksPokemonRepository mockspokemonRepository)
        {
            _mockspokemonRepository = mockspokemonRepository;

        }
        

    }
}
