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
            string produto1 = "Salgado de Calabresa"; 
            int quantidade1 = 20 , valor1 = 5 ;
            
            string produto2 = "Salgado de Frango";
            int quantidade2 = 20, valor2 = 5 ;
            
            string produto3 = "Salgado de Carne";
            int quantidade3 = 20, valor3 = 5 ;
            
            string produto4 = "Salgado de Queijo";
            int quantidade4 = 20, valor4 = 5 ;

            string produto5 = "Coca-Cola";
            int quantidade5 = 20, valor5 = 4;

            string produto6 = "Fanta Uva";
            int quantidade6 = 20, valor6 = 4;

            string produto7 = "Pepsi";
            int quantidade7 = 20, valor7 = 4;

            string produto8 = "Dolly";
            int quantidade8 = 20, valor8 = 4;

            string produto9 = "Torta de Limão";
            int quantidade9 = 20, valor9 = 7;

            string produto10 = "Torta Holandesa";
            int quantidade10 = 20, valor10 = 8;

            string produto11 = "Chocolate Garoto";
            int quantidade11 = 20, valor11 = 6;

            string produto12 = "Pão de Mel";
            int quantidade12 = 20, valor12 = 3;

           

            while (menuloop == 1) 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\r\n   _____   _         _                                        _                _____                           _    /\\/|         \r\n  / ____| (_)       | |                                      | |              / ____|                         | |  |/\\/          \r\n | (___    _   ___  | |_    ___   _ __ ___     __ _        __| |   ___       | (___     ___   _   _           | |   __ _    ___  \r\n  \\___ \\  | | / __| | __|  / _ \\ | '_ ` _ \\   / _` |      / _` |  / _ \\       \\___ \\   / _ \\ | | | |      _   | |  / _` |  / _ \\ \r\n  ____) | | | \\__ \\ | |_  |  __/ | | | | | | | (_| |     | (_| | | (_) |      ____) | |  __/ | |_| |     | |__| | | (_| | | (_) |\r\n |_____/  |_| |___/  \\__|  \\___| |_| |_| |_|  \\__,_|      \\__,_|  \\___/      |_____/   \\___|  \\__,_|      \\____/   \\__,_|  \\___/ \r\n                                                                                                                                 \r\n                                                                                                                                 \r\n");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Menu: ");
                Console.WriteLine("\n");
                Console.WriteLine("1- Cadastrar Novos Produtos");
                Console.WriteLine("\n");
                Console.WriteLine("2- Realizar Venda de Produtos");
                Console.WriteLine("\n");
                Console.WriteLine("3- Gerar relatorio ");
                Console.WriteLine("\n");
                Console.WriteLine("4- Vendas ");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Escolha a Opção: ");
            

                menu = int.Parse(Console.ReadLine());

                Console.Clear();    

                if (menu == 1)
                {
                while (loop == 1)
                { 

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\r\n   _____            _              _                         _            _____                  _         _              \r\n  / ____|          | |            | |                       | |          |  __ \\                | |       | |             \r\n | |      __ _   __| |  __ _  ___ | |_  _ __  ___         __| |  ___     | |__) |_ __  ___    __| | _   _ | |_  ___   ___ \r\n | |     / _` | / _` | / _` |/ __|| __|| '__|/ _ \\       / _` | / _ \\    |  ___/| '__|/ _ \\  / _` || | | || __|/ _ \\ / __|\r\n | |____| (_| || (_| || (_| |\\__ \\| |_ | |  | (_) |     | (_| ||  __/    | |    | |  | (_) || (_| || |_| || |_| (_) |\\__ \\\r\n  \\_____|\\__,_| \\__,_| \\__,_||___/ \\__||_|   \\___/       \\__,_| \\___|    |_|    |_|   \\___/  \\__,_| \\__,_| \\__|\\___/ |___/\r\n                                                                                                                          \r\n                                                                                                                          \r\n");
                    
                    Console.Write('\n');
                    Console.ForegroundColor= ConsoleColor.Cyan; 

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
                        Console.Clear();



                    }


                }
                else if (menu == 2)
                {
                    int menu2;
                    int loop2 = 1;

                    Console.WriteLine("\n");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\r\n   _____                      _                   _         \r\n  / ____|                    | |                 (_)        \r\n | |        __ _   _ __    __| |   __ _   _ __    _    ___  \r\n | |       / _` | | '__|  / _` |  / _` | | '_ \\  | |  / _ \\ \r\n | |____  | (_| | | |    | (_| | | (_| | | |_) | | | | (_) |\r\n  \\_____|  \\__,_| |_|     \\__,_|  \\__,_| | .__/  |_|  \\___/ \r\n                                         | |                \r\n                                         |_|                \r\n");
                    Console.WriteLine("\n");
                    Console.ForegroundColor= ConsoleColor.Cyan;
                    Console.WriteLine("Menu de vendas");
                    Console.WriteLine("1- Cardapio");
                    Console.Write("Escolha a Opção: ");
                    
                    menu2 = int.Parse(Console.ReadLine());
                    Console.Clear();


                    if (menu2 == 1) 
                    {
                        while (loop2 == 1)
                        {

                            int menu3;
                            
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\r\n  __  __                              _                                   _             \r\n |  \\/  |                            | |                                 | |            \r\n | \\  / |  ___  _ __   _   _       __| |  ___     __   __ ___  _ __    __| |  __ _  ___ \r\n | |\\/| | / _ \\| '_ \\ | | | |     / _` | / _ \\    \\ \\ / // _ \\| '_ \\  / _` | / _` |/ __|\r\n | |  | ||  __/| | | || |_| |    | (_| ||  __/     \\ V /|  __/| | | || (_| || (_| |\\__ \\\r\n |_|  |_| \\___||_| |_| \\__,_|     \\__,_| \\___|      \\_/  \\___||_| |_| \\__,_| \\__,_||___/\r\n                                                                                        \r\n                                                                                        \r\n");
                            Console.WriteLine("\n");

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("SALGADOS");
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("1-Salgado de Calabresa");
                            Console.WriteLine("2-Salgado de Frango");
                            Console.WriteLine("3-Salgado de Carne");
                            Console.WriteLine("4-Salgado de Queijo");
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("REFRIGERANTES");
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("5-Coca-Cola");
                            Console.WriteLine("6-Fanta Uva");
                            Console.WriteLine("7-Spite");
                            Console.WriteLine("8-Dolly");
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("DOCES");
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("9-Torta de Limão ");
                            Console.WriteLine("10-Torta Holandesa");
                            Console.WriteLine("11-Chocolate Garoto");
                            Console.WriteLine("12-Pão de mel");
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Escolha a Opção: ");

                            menu3 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if (menu3 == 1)
                            {
                                
                                Console.WriteLine(produto1);
                                Console.WriteLine(" valor " + valor1 + "$");

                            }
                            if (menu3 == 2)
                            {
                                
                                Console.WriteLine(produto2);
                                Console.WriteLine(" valor " + valor2 + "$");
                            }
                            if (menu3 == 3)
                            {
                                
                                Console.WriteLine(produto3);
                                Console.WriteLine(" valor " + valor3 + "$");
                            }
                            if (menu3 == 4)
                            {
                               
                                Console.WriteLine(produto4);
                                Console.WriteLine(" valor " + valor4 + "$");

                            }
                            if (menu3 == 5)
                            {
                                
                                Console.WriteLine(produto5);
                                Console.WriteLine(" valor " + valor5 + "$");

                            }
                            if (menu3 == 6)
                            {
                               
                                Console.WriteLine(produto6);
                                Console.WriteLine(" valor " + valor6 + "$");

                            }
                            if (menu3 == 7)
                            {
                                
                                Console.WriteLine(produto7);
                                Console.WriteLine(" valor " + valor7 + "$");

                            }
                            if (menu3 == 8)
                            {
                                
                                Console.WriteLine(produto8);
                                Console.WriteLine(" valor " + valor8 + "$");

                            }
                            if (menu3 == 9)
                            {
                                
                                Console.WriteLine(produto9);
                                Console.WriteLine(" valor " + valor9 + "$");

                            }
                            if (menu3 == 10)
                            {
                                
                                Console.WriteLine(produto10);
                                Console.WriteLine(" valor " + valor10 + "$");

                            }
                            if (menu3 == 11)
                            {
                                
                                Console.WriteLine(produto11);
                                Console.WriteLine(" valor " + valor11 + "$");

                            }
                            if (menu3 == 12)
                            {
                                
                                Console.WriteLine(produto12);
                                Console.WriteLine(" valor " + valor12 + "$");

                            }
                            Console.WriteLine("temos mais produtos para comprar?");
                            Console.Write('\n');

                            Console.WriteLine("1 = Sim / 2 = NÃO ");
                            loop2 = int.Parse(Console.ReadLine());
                            Console.Clear();


                        }
                    }
                    else 
                    { 
                    }



                }
                else if (menu == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\r\n  _____        _         _     __         _        \r\n |  __ \\      | |       | |   /_/        (_)       \r\n | |__) | ___ | |  __ _ | |_  ___   _ __  _   ___  \r\n |  _  / / _ \\| | / _` || __|/ _ \\ | '__|| | / _ \\ \r\n | | \\ \\|  __/| || (_| || |_| (_) || |   | || (_) |\r\n |_|  \\_\\\\___||_| \\__,_| \\__|\\___/ |_|   |_| \\___/ \r\n                                                   \r\n                                                   \r\n");
                    Console.ForegroundColor= ConsoleColor.Cyan;
                    Console.Write('\n');
                    Console.WriteLine("\n");
                    Console.WriteLine(produto1 + " - estoque: " + quantidade1 + " - valor " + valor1 + "$" );
                    Console.Write('\n');
                    Console.WriteLine(produto2 + " - estoque: " + quantidade2 + " - valor " + valor2 + "$" );
                    Console.Write('\n');
                    Console.WriteLine(produto3 + " - estoque: " + quantidade3 + " - valor " + valor3 + "$");
                    Console.Write('\n');
                    Console.WriteLine(produto4 + " - estoque: " + quantidade4 + " - valor " + valor4 + "$");
                    Console.Write('\n');
                    Console.WriteLine(produto5 + " - estoque: " + quantidade5 + " - valor " + valor5 + "$");
                    Console.Write('\n');
                    Console.WriteLine(produto6 + " - estoque: " + quantidade6 + " - valor " + valor6 + "$");
                    Console.Write('\n');
                    Console.WriteLine(produto7 + " - estoque: " + quantidade7 + " - valor " + valor7 + "$");
                    Console.Write('\n');
                    Console.WriteLine(produto8 + " - estoque: " + quantidade8 + " - valor " + valor8 + "$");
                    Console.Write('\n');
                    Console.WriteLine(produto9 + " - estoque: " + quantidade9 + " - valor " + valor9 + "$");
                    Console.Write('\n');
                    Console.WriteLine(produto10 + " - estoque: " + quantidade10 + " - valor " + valor10 + "$");
                    Console.Write('\n');
                    Console.WriteLine(produto11 + " - estoque: " + quantidade11 + " - valor " + valor11 + "$");
                    Console.Write('\n');
                    Console.WriteLine(produto12 + " - estoque: " + quantidade12 + " - valor " + valor12 + "$");
                    
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                }
                else if (menu == 4)
                {

                    int menu5;


                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\r\n  __  __                              _                                   _             \r\n |  \\/  |                            | |                                 | |            \r\n | \\  / |  ___  _ __   _   _       __| |  ___     __   __ ___  _ __    __| |  __ _  ___ \r\n | |\\/| | / _ \\| '_ \\ | | | |     / _` | / _ \\    \\ \\ / // _ \\| '_ \\  / _` | / _` |/ __|\r\n | |  | ||  __/| | | || |_| |    | (_| ||  __/     \\ V /|  __/| | | || (_| || (_| |\\__ \\\r\n |_|  |_| \\___||_| |_| \\__,_|     \\__,_| \\___|      \\_/  \\___||_| |_| \\__,_| \\__,_||___/\r\n                                                                                        \r\n                                                                                        \r\n");
                    Console.WriteLine("\n");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("SALGADOS");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("1-Salgado de Calabresa");
                    Console.WriteLine("2-Salgado de Frango");
                    Console.WriteLine("3-Salgado de Carne");
                    Console.WriteLine("4-Salgado de Queijo");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("REFRIGERANTES");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("5-Coca-Cola");
                    Console.WriteLine("6-Fanta Uva");
                    Console.WriteLine("7-Spite");
                    Console.WriteLine("8-Dolly");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("DOCES");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("9-Torta de Limão ");
                    Console.WriteLine("10-Torta Holandesa");
                    Console.WriteLine("11-Chocolate Garoto");
                    Console.WriteLine("12-Pão de mel");
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Escolha a Opção: ");

                    menu5 = int.Parse(Console.ReadLine());

                    if (produto1 == 1) 
                    { 
                        
                    }
                    



                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Selecione uma opção valida");
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Gostaria de voltar para o menu?");
                Console.Write('\n');

                Console.WriteLine("1 = Sim / 2 = NÃO ");
                menuloop  = int.Parse(Console.ReadLine());
                Console.Clear();



            }



            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("PRESS ENTER TO FINISH");
        Console.ReadKey();
        
        }
    }
}
