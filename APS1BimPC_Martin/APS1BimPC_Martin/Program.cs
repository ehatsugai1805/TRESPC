/* NOME: ÉRIKA CRISTINE HATSUGAI ---------- RA 2019101301 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APS1BimPC_Martin
{
    class Program
    {
        public static void Main(string[] args)
        {
            Boolean continuar = true;
            List<Cadastro> listaCadastro = new List<Cadastro>();

            do
            {
                /* MENU com as opções: incluir, alterar, excluir, listar, pesquisar e sair */ 
                Console.WriteLine("Seja bem-vindo ao Menu de Cadastro!");
                Console.WriteLine("01 - Incluir");
                Console.WriteLine("02 - Alterar");
                Console.WriteLine("03 - Excluir");
                Console.WriteLine("04 - Listar");
                Console.WriteLine("05 - Pesquisar");
                Console.WriteLine("10 - Sair");
                Console.WriteLine("Por gentileza, informa a opção desejada: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
             
                    case "01":
                        listaCadastro.Add(incluirCadastro());
                        break;

                    case "02": 
                        foreach (Cadastro cadastro in listaCadastro)
                        {
                            Console.WriteLine(cadastro);
                        }
                        Console.WriteLine("Digite o ID do cadastro que deseja alterar: ");

                        int alterar = int.Parse(Console.ReadLine());

                        Cadastro buscaAlterar = listaCadastro.Find(x => x.Id == alterar);

                        if (buscaAlterar != null)
                        {
                            listaCadastro.Remove(buscaAlterar);
                            listaCadastro.Add(incluirCadastro());

                            foreach (Cadastro cadastro in listaCadastro)
                            {
                                Console.WriteLine("Cadastro atualizado com sucesso!");
                                Console.WriteLine(cadastro);
                            }
                        }
                        else
                        {
                           Console.WriteLine("Ahhh, infelizmente o ID não  foi localizado. Tente novamente!");
                        }
                        break;

                    
                    case "03":
                        foreach (Cadastro cadastro in listaCadastro)
                        {
                            Console.WriteLine(cadastro);
                        }
                        Console.Write("Digite o ID do cadastro que deseja excluir: ");
                        int excluir = int.Parse(Console.ReadLine());

                        Cadastro buscaExcluir = listaCadastro.Find(x => x.Id == excluir);

                        if (buscaExcluir != null)
                        {
                            listaCadastro.Remove(buscaExcluir);
                            Console.WriteLine("Cadastro removido com sucesso! Lista atualizada: ");


                            foreach (Cadastro cadastro in listaCadastro)
                            {
                                Console.WriteLine(cadastro);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ahhh, infelizmente o ID não  foi localizado. Tente novamente!");
                        }
                        break;

                    case "04":
                        Console.WriteLine("Lista de cadastrados: ");
                        foreach (Cadastro cadastro in listaCadastro)
                        {
                            Console.WriteLine(cadastro);
                        }
                        break;

                    case "05":
                        Console.WriteLine("Digite o ID que deseja pesquisar: ");
                        int pesquisaId = int.Parse(Console.ReadLine());

                        Cadastro pesquisar = listaCadastro.Find(pesq => pesq.Id == pesquisaId);
                        if (pesquisar != null)
                        {
                            Console.WriteLine("Cadastro localizado: " + pesquisar);
                        }
                        else
                        {
                            Console.WriteLine("ATENÇÃO: o ID pesquisado não foi encontrado!");
                        }


                        break;

                    case "10":
                        /* SAIR */
                        Console.WriteLine("Você está de saída? Então até logo, criatura! :D");
                        continuar = false;
                        break;


                        default:
                        Console.WriteLine("Opção inválida, tente novamente!");
                        break;
                }
            }

            while (continuar);

            Console.ReadKey();
        }



        private static Cadastro incluirCadastro()
        {
            Cadastro cadastro = new Cadastro();

            Console.WriteLine("Cadastro de usuário");
            Console.Write("ID: ");
            cadastro.Id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            cadastro.Nome = Console.ReadLine();
            Console.Write("Cidade: ");
            cadastro.Cidade = Console.ReadLine();

            return cadastro;
        }
    }
}
