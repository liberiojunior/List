using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposAbstratosDeDados
{
    class TestaLista
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int c;
            string nu;
            int num = 0;

            Console.Write("Selecione uma opção: \n1) Inserir\n2) Pesquisar\n3) Imprimir Lista\n4) Excluir\n5) Sair\n");



            c = int.Parse(Console.ReadLine());
  
            while (c != 5)
            {
                switch (c)
                {
                    case 1:
                        Console.WriteLine("Digite um número: ");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite um nome: ");
                        nu = Console.ReadLine();
                        if (l.pesquisar(num) != null)
                        {
                            Console.Clear();
                            Console.WriteLine("Erro, número já inserido!");
                        }
                        else
                        {
                            Console.Clear();
                            l.inserir(new NoLista(num,nu));
                            Console.WriteLine("Número e Nome inserido com sucesso!!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite o número para ser pesquisado: ");
                        num = int.Parse(Console.ReadLine());
                        l.pesquisar(num);
                        if (l.pesquisar(num) != null)
                        {
                            NoLista temp = l.pesquisar(num);
                            Console.Clear();
                            Console.WriteLine("Número existente, usuário: " + temp.nome);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Número não inserido: ");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        l.imprimir();
                        break;
                    case 4:
                        Console.WriteLine("Digite um número para excluir: ");
                        num = int.Parse(Console.ReadLine());
                        if (l.pesquisar(num) != null)
                        {
                            Console.Clear();
                            l.remover(num);
                            Console.WriteLine("Usuário removido com sucesso!!");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Usuário não cadastrado: ");
                        }
                        break;
                }
                Console.WriteLine("");
                Console.Write("Selecione uma opção: \n1) Inserir\n2) Pesquisar\n3) Imprimir Lista\n4) Excluir\n5) Sair\n");
                c = int.Parse(Console.ReadLine());

            }



            /*while (c != -1)
            {
                l.inserir(new NoLista(c));
                Console.Write("Digite outro nº (-1 para sair): ");
                c = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite um nº a ser pesquisado: ");
            c = int.Parse(Console.ReadLine());

            NoLista n = l.pesquisar(c);
            if (n == null)
                Console.WriteLine("Valor não encontrado!");
            else
                Console.WriteLine("Achou: " + n.chave);

            l.imprimir();*/
            Console.WriteLine("Obrigado, volta sempre!!");
            Console.ReadKey();
        }
    }
}
