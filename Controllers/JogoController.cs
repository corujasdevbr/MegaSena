using System;
using System.Collections.Generic;
using corujasdev.megasena.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace corujasdev.megasena.web.Controllers
{
    [Route("api/[controller]")]
    public class JogoController : Controller
    {
        [HttpGet]
        public IActionResult GetAction(){

            int quantJogos = 2, quantNumeros = 7;
            Random random = new Random();

            List<Jogo> jogos = new List<Jogo>();

            for (int i = 0; i < quantJogos; i++)
            {
                Jogo jogo = new Jogo();

                for (int c = 0; c < quantNumeros; c++)
                {
                    int numero = random.Next(1,60);

                    jogo.Numero.Add(numero);

                }

                jogos.Add(jogo);
            }

            return Ok(Json(jogos));
        }
    }
}