/*using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GerenciadorDeEstoque.Apresentação
{
    public class CadastroUsuario
    {

        /*string conexaoCU = "sever = localhost; user id = root; password = root; database = Estoque";
        var conexao = new MySqlConnection(conexaoCU);
        conexao.Open();
        

        private string nome;
        private string email;
        private string senha;

        public CadastroUsuario()
        {
            this.nome = "";
            this.email = ""; 
            this.senha = ""; 
        }

        public string getNome() { return nome; }
        public string getEmail() { return email; }
        public string getSenha() {  return senha; }

        public void criarCadastro(string nome, string email, string senha)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
        }

        public bool checaSenha(string senha)
        {
            if(senha == this.senha)
            {
                return true;
            }
            else { return false; }
        }

        public bool checaUsuario(string nome)
        {
            if(nome == this.nome) { 
                return true; 
            }
            else { return false; }
        }

        
    }
}*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorDeEstoque.Apresentação
{
    class UsuarioVO
    {
        private Int32 _itemid;
        private String _itemcodigo, _itemdescricao;
        private Double _itempreco;
        private DAO.DAO dao;

        public UsuarioVO()
        {

        }

        public Int32 itemid
        {
            get { return _itemid; }
            set { _itemid = value; }
        }
        public String itemcodigo
        {
            get { return _itemcodigo; }
            set { _itemcodigo = value; }
        }
        public String itemdescricao
        {
            get { return _itemdescricao; }
            set { _itemdescricao = value; }
        }
        public Double itempreco
        {
            get { return _itempreco; }
            set { _itempreco = value; }
        }

        public void Inserir()
        {
            dao = new DAO.DAO();
            dao.InserirDados(itemcodigo, itemdescricao, itempreco);
        }
        public void Atualizar()
        {
            dao = new DAO.DAO();
            dao.AtualizarDados(itemcodigo, itemdescricao, itempreco, itemid);
        }
        public void Remover()
        {
            dao = new DAO.DAO();
            dao.RemoverDados(itemcodigo, itemid);
        }
    }
}
