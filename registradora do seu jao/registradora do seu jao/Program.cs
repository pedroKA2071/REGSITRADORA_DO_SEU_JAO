using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registradora_do_seu_jao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu, loop, menuloop;
            menuloop = 1;
            loop = 1;
            string Cadastro, infotipo, infopreco, infopeso;

            Console.ForegroundColor = ConsoleColor.Magenta;


            while (menuloop == 1) 
            {
            
                Console.WriteLine("Menu: ");
                Console.WriteLine("1- Cadastrar Novos Produtos");
                Console.WriteLine("2- Realizar Venda de Produtos");
                Console.WriteLine("3- Gerar relatorio ");
                Console.Write("Escolha a Opção: ");
            

                menu = int.Parse(Console.ReadLine());

                if (menu == 1)
                {
                while (loop == 1)
                { 
                    Console.Write('\n');
                    Console.WriteLine("Qual produto vamos cadastrar?");
                    Cadastro = (Console.ReadLine());
                    
                    Console.Write('\n');
                    Console.WriteLine("O produto a ser cadastrado é " + Cadastro);
                
                    Console.Write('\n');
                    Console.WriteLine("Atualize as informaçoes pedidas");
                
                    Console.Write('\n');
                    Console.Write("TIPO:");
                    infotipo = (Console.ReadLine());
                
                    Console.Write("PREÇO:");
                    infopreco = (Console.ReadLine());
                
                    Console.Write("PESO:");
                    infopeso = (Console.ReadLine());

                    Console.Write('\n');
                    Console.WriteLine("O produto cadastrado é " + Cadastro);
                        
                    Console.Write('\n');
                    Console.WriteLine("As informações estão corretas!");

                    Console.Write('\n');
                    Console.WriteLine("TIPO:" + infotipo);
                        
                    Console.Write('\n');
                    Console.WriteLine("PREÇO:" + infopreco);

                    Console.Write('\n');
                    Console.WriteLine("PESO:" + infopeso);

                    Console.Write('\n');
                
                    Console.WriteLine("temos mais produtos para cadastro?");
                    Console.Write('\n');

                    Console.WriteLine("1 = Sim / 2 = NÃO ");
                    loop = int.Parse(Console.ReadLine());



                }


                }
                else if (menu == 2)
                {

                }
                else if (menu == 3)
                {

                }
                else
                {
                Console.WriteLine("Selecione uma opção valida");
                }


                Console.WriteLine("Gostaria de voltar para o menu?");
                Console.Write('\n');

                Console.WriteLine("1 = Sim / 2 = NÃO ");
                menuloop  = int.Parse(Console.ReadLine());



            }




            Console.Write("PRESS ENTER TO FINISH");
        Console.ReadKey();
        
        }
    }
}
