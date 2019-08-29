using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ListaAutos
    {
        private List<Auto> autos;

        public ListaAutos()
        {
        }

        public List<Auto> Autos { get => autos; set => autos = value; }
    }


}
