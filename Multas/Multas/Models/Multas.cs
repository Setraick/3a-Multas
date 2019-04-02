using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multas.Models
{
    public class Multas {

        public int Id { get; set; }

        public DateTime DataMulta { get; set; }

        public decimal ValorMulta { get; set; }

        public String Descricao { get; set; }


    }
}