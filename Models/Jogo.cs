using System.Collections.Generic;

namespace corujasdev.megasena.web.Models
{
    public class Jogo
    {
        public Jogo()
        {
            Numero = new List<int>();
        }
        
        public List<int> Numero { get; set; }
    }
}