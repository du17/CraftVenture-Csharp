using System;
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

            if(nome.Length != 0)
            {
                this.nome = nome;
            }
            else { throw new ArgumentException("O nome não pode ser nulo"); }

            if(senha.Length >= 8)
            {
                this.senha = senha;

            }
            else { throw new ArgumentException("A senha deve ter pelo menos 8 caracteres"); }
            if(validaEmail(email) == true)
            {
                this.email = email;
            }
            else { throw new ArgumentException("O email não é válido, cheque e tente novamente");  }

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

        public bool validaEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
