using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa1Cadastro.Entidade;

namespace Tarefa1Cadastro
{
    class Program
    {
        public static List<Pessoa> _listPessoas = new List<Pessoa>();
        static void Main(string[] args)
        {
            int opcao;
            var scape = "";
            do
            {
                Console.WriteLine("Bem vindo ao sistema de cadastro de pessoa!");
                Console.WriteLine("Opções:");
                Console.WriteLine("1 - Adicionar.");
                Console.WriteLine("2 - Alterar.");
                Console.WriteLine("3 - Excluir.");
                Console.WriteLine("4 - Listar.");
                Console.WriteLine("5 - Sair.");
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite uma opção: ");
                scape = Console.ReadLine();
                if (!scape.Equals("") && scape.All(char.IsDigit))
                {
                    opcao = Int32.Parse(scape);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção Inválida!");
                    opcao = 10;
                }

                switch (opcao)
                {
                    case 1:
                        cadastrar();
                        break;
                    case 2:
                        editar();
                        break;
                    case 3:
                        excluir();
                        break;
                    case 4:
                        listar();
                        break;
                    case 5:
                        saiPrograma();
                        opcao = 0;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (opcao != 0);
        }
        private static void saiPrograma()
        {
            Console.WriteLine();
            Console.WriteLine("Você saiu do Programa. Pressione qualquer tecla para sair...");
        }
        private static void cadastrar()
        {
            Console.Clear();
            Pessoa p1 = new Pessoa();
            p1.DataCadastro = DateTime.Now;
            Console.WriteLine("*****************************| Cadastro de Pessoas |********************************");
            Console.WriteLine("");
            Console.WriteLine("Digite o nome da pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF da pessoa: ");
            p1.Cpf = Console.ReadLine();
            Console.WriteLine("Digite o RG da pessoa: ");
            p1.Rg = Console.ReadLine();
            Console.WriteLine("Digite o email da pessoa: ");
            p1.Email = Console.ReadLine();
            Console.WriteLine("Digite o endereço da pessoa: ");
            p1.Endereco = Console.ReadLine();
            Console.WriteLine("Digite o numero do endereço da pessoa: ");
            p1.Numero = Console.ReadLine();
            Console.WriteLine("Digite o bairro do endereço da pessoa: ");
            p1.Bairro = Console.ReadLine();
            Console.WriteLine("Digite a cidade da pessoa: ");
            p1.Cidade = Console.ReadLine();

            _listPessoas.Add(p1);
            Console.WriteLine("Pessoa Cadastrada om Sucesso!");

        }
        private static void listar()
        {
            Console.Clear();
            int i = 0;
            Console.WriteLine("*****************************| Pessoas Cadastradas |********************************");
            foreach (Pessoa item in _listPessoas)
            {
                i++;
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("Pessoa "+ i);
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("ID: "+ item.Id);
                Console.WriteLine("Nome: " + item.Nome);
                Console.WriteLine("CPF: " + item.Cpf);
                Console.WriteLine("RG: " + item.Rg);
                Console.WriteLine("Email: " + item.Email);
                Console.WriteLine("Data de Cadastro: " + item.DataCadastro);
                Console.WriteLine("Data de Modificação: " + item.DataModificacao);
                Console.WriteLine("Endereço: " + item.Endereco);
                Console.WriteLine("Numero: " + item.Numero);
                Console.WriteLine("Bairro: " + item.Bairro);
                Console.WriteLine("Cidade: " + item.Cidade);
            }
        }
        private static void editar()
        {
            Console.Clear();
            string nome;
            string resp;
            Pessoa p1 = null;
            Console.WriteLine("*****************************| Editar Cadastro |********************************");
            Console.WriteLine("Informe o nome da pessoa que deseja editar ");
            nome = Console.ReadLine();
            foreach (Pessoa item in _listPessoas)
            {
                if (item.Nome.Equals(nome))
                {
                    p1 = item;
                }
            }
            if (p1!=null)
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("ID: " + p1.Id);
                Console.WriteLine("Nome: " + p1.Nome);
                Console.WriteLine("CPF: " + p1.Cpf);
                Console.WriteLine("RG: " + p1.Rg);
                Console.WriteLine("Email: " + p1.Email);
                Console.WriteLine("Data de Cadastro: " + p1.DataCadastro);
                Console.WriteLine("Data de Modificação: " + p1.DataModificacao);
                Console.WriteLine("Endereço: " + p1.Endereco);
                Console.WriteLine("Numero: " + p1.Numero);
                Console.WriteLine("Bairro: " + p1.Bairro);
                Console.WriteLine("Cidade: " + p1.Cidade);
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("Deseja editar esse cadastro? sim ou nao");
                resp = Console.ReadLine();
                if (!resp.Equals("sim"))
                {
                    Console.WriteLine("Alteração Cancelada!");
                }
                else
                {
                    p1.DataModificacao = DateTime.Now;
                    Console.WriteLine("--------------------| Novos Dados |----------------------");
                    Console.WriteLine("");
                    Console.WriteLine("Digite o nome da pessoa: ");
                    p1.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o CPF da pessoa: ");
                    p1.Cpf = Console.ReadLine();
                    Console.WriteLine("Digite o RG da pessoa: ");
                    p1.Rg = Console.ReadLine();
                    Console.WriteLine("Digite o email da pessoa: ");
                    p1.Email = Console.ReadLine();
                    Console.WriteLine("Digite o endereço da pessoa: ");
                    p1.Endereco = Console.ReadLine();
                    Console.WriteLine("Digite o numero do endereço da pessoa: ");
                    p1.Numero = Console.ReadLine();
                    Console.WriteLine("Digite o bairro do endereço da pessoa: ");
                    p1.Bairro = Console.ReadLine();
                    Console.WriteLine("Digite a cidade da pessoa: ");
                    p1.Cidade = Console.ReadLine();
                    
                    Console.WriteLine("Pessoa Alterada com Sucesso!");
                }
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada!");
            }                        
                
        }
        private static void excluir()
        {
            Console.Clear();
            Console.WriteLine("*****************************| Excluir Cadastro |********************************");
            Console.WriteLine("");
            Pessoa p1 = null;
            string nome;
            string resp;
            Console.WriteLine("Informe o nome do cliente que deseja excluir!");
            nome = Console.ReadLine();
            foreach (Pessoa item in _listPessoas)
            {
                if (item.Nome.Equals(nome))
                {
                    p1 = item;
                }
            }
            if (p1 != null)
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("ID: " + p1.Id);
                Console.WriteLine("Nome: " + p1.Nome);
                Console.WriteLine("CPF: " + p1.Cpf);
                Console.WriteLine("RG: " + p1.Rg);
                Console.WriteLine("Email: " + p1.Email);
                Console.WriteLine("Data de Cadastro: " + p1.DataCadastro);
                Console.WriteLine("Data de Modificação: " + p1.DataModificacao);
                Console.WriteLine("Endereço: " + p1.Endereco);
                Console.WriteLine("Numero: " + p1.Numero);
                Console.WriteLine("Bairro: " + p1.Bairro);
                Console.WriteLine("Cidade: " + p1.Cidade);
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("Realmente deseja excluir esse cadastro? sim ou nao");
                resp = Console.ReadLine();
                if (!resp.Equals("sim"))
                {
                    Console.WriteLine("Exclusão Cancelada!");
                }
                else
                {
                    _listPessoas.Remove(p1);
                    Console.WriteLine("Cadastro excluido com sucesso!");
                }                
            }
            else
            {
                Console.WriteLine("Cadastro não encontrado!");
            }
        }

    }
}

