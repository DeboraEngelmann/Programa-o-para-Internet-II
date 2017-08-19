using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa1Cadastro.Entidade
{
    class Pessoa
    {
        public Pessoa()
        {
            Id = Guid.NewGuid();
        }
        //Principal
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }

        //Secundários
        public DateTime DataCadastro { get; set; }
        public DateTime DataModificacao { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
    }
}
