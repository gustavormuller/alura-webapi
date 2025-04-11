using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using alura_webapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace alura_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController
    {
        private static List<Filme> filmes = [];

        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme)
        {
            if (!string.IsNullOrEmpty(filme.Titulo) &&
                !string.IsNullOrEmpty(filme.Genero) &&
                filme.Duracao >= 70)
            {
                filmes.Add(filme);
                Console.WriteLine(filme.Titulo);
                Console.WriteLine(filme.Duracao);
            }
        }
    }
}