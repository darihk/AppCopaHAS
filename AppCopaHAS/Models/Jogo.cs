using System;
using System.Collections.Generic;
using System.Text;

namespace AppCopaHAS.Models
{
    //Classe Jogo
    public class Jogo
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int EstadioId { get; set; }
    }
}
