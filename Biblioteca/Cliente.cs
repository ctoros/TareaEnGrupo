using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private int rut;
        private char dv;
        private string nombre;
        private string apellido;

        public Cliente()
        {
        }

        public int Rut { get => rut; set => rut = value; }
        public char Dv { get => dv; set => dv = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
