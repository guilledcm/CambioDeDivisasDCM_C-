using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDivisasGuillermoDeCarlos
{
    public class Moneda
    {
        public string nombre { get; set; }
        public double valor { get; set; }
        public Moneda(string nombre,double valor) { 
            this.nombre = nombre;
            this.valor = valor;
        }

        public override string? ToString()
        {
            return nombre.ToString();
        }
    }
}
