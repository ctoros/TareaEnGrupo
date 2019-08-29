using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ListaClientes
    {
        private List<Cliente> clientes;

        public ListaClientes()
        {
        }

        public List<Cliente> Clientes { get => clientes; set => clientes = value; }

    }
}
