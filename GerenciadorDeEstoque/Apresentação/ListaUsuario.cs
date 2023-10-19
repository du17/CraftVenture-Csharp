using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.Apresentação
{
    public class ListaUsuario
    {
        private List<CadastroUsuario> listaUsuario = new List<CadastroUsuario> ();

        public ListaUsuario(CadastroUsuario cadastro) { 
            
            listaUsuario.Add (cadastro);

        }
    }
}
