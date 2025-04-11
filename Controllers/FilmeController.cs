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
        private static int id = 0;

        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
            Console.WriteLine(filme.Duracao);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperaFilmes()
        {
            return filmes;
        }

        [HttpGet("{id}")]
        public Filme RecuperaFilmePorId(int id)
        {
            return filmes.FirstOrDefault(filme => filme.Id == id);
        }
    }
}