using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

internal class Program

{
    private static readonly object jogo_de_TLP;

    private static void Main(string[] args)
    {
	//Menu de Apresentação
        Console.WriteLine("         SEJA BEM-VINDO AO INSTITUTO POLITÉCNICO INDUSTRIAL DO KILAMBA KIAXI Nº 8056 ”NOVA VIDA");
        
	Thread.Sleep(3000);
        
	//Barra de carregamento (Loading)
	int a = 1;
        while (a <= 10)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("■■■■");
            Console.Write("■■■■");
            Console.Write("■■■■");

            Thread.Sleep(100);

            a++;
        }
        Console.Clear();
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.White; //mudar a cor do texto para branco
        Console.WriteLine("================/=================/==============/==================================/============================================");
        Console.WriteLine("===============/ Turma: INF11AT  /     Sala: 4  /    Curso: Técnico De Informática / Programador: Alberto Lucas António ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

        Thread.Sleep(5000);

        Console.Clear();

	//Menu Inicial
        
	int op = 1;
        while (op!=0) 
        {
            Console.WriteLine("_______________________________________________________________________________________________________________________");
            Console.WriteLine("bem-vindo, escolha uma das seguintes opções                                 /                           ");
            Console.WriteLine("1 jogo de TLP                                                              /                                 ");
            Console.WriteLine("2 tabela de verdade                                                       /                                  "); 
            Console.WriteLine("3 Opção     C                                                            /                                         ");
            Console.WriteLine("4 calculadora                                                           /                                               ");
            Console.WriteLine("0 SAIR                                                                 /                                                ");

            Console.ForegroundColor = ConsoleColor.Red;
                    
            Console.WriteLine("======================================================================================================================");
            Console.WriteLine("");
            op = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.ReadKey();
        	
	//Avaliando a opção escolhida pelo usuário    
	if(op ==0)
            {
                break;
            }
            else if(op == 1)
            {
                jogoDeTLP(); //chamar a função que executa jogos

            }
            else if(op == 2)
            {

                Tabela_de_verdade(); //chamar a função que executa as tabelas de verdade

            }
            else if (op == 3)
            {
                Console.Clear();           

                Console.WriteLine("você escolheu a opção C");
                Console.WriteLine("sem informação no momento para está opção");

                Console.ReadKey();
            }
            else if(op == 4)
            {
                calculadora(); //chamar a função que executa a calculadora científica
            }

            else
            {
                Console.Clear();

                Console.WriteLine("você escolheu opção invalida");
                Console.ReadKey();

            }
        }

    }

    //=========================================================================
    //IMPLEMENTAÇÃO DA TABELA DE VERDADE
    //=========================================================================
    private static void Tabela_de_verdade()
    {
        int op = 1;
        while (op != 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Escolha uma das operações Lógias no MEMU");
            Console.WriteLine("1 porta lógica END      ");
            Console.WriteLine("2 inversor (NOT)        ");
            Console.WriteLine("3 porta lógica OR       ");
            Console.WriteLine("0 voltar ao menu anterior     ");
           
            op = Convert.ToInt32(Console.ReadLine());
            
	    Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadLine();
            
	    if(op==0)
            {
                break;
            }
            
            else if(op==1)
            {
                Console.Clear();
                Console.WriteLine("1 porta lógica END      ");
                Console.WriteLine(" ");
                Console.WriteLine("");
                Console.WriteLine("|==============|");
                Console.WriteLine("| INPUT|OUTPUT |");
                Console.WriteLine("|¨¨|¨¨¨|¨¨¨¨¨¨¨|");
                Console.WriteLine("|A | B |  X    |");
                Console.WriteLine("|¨¨|¨¨¨|¨¨¨¨¨¨¨|");
                Console.WriteLine("| 0|  0|   0   |");
                Console.WriteLine("| 0|  1|   0   |");
                Console.WriteLine("| 1|  0|   0   |");
                Console.WriteLine("| 1|  1|   1   |");
                Console.WriteLine("|==============|");
                Console.WriteLine("");
                Console.WriteLine("");

                Console.ReadLine();
            }
            else if (op == 2)
            {
                Console.Clear();
                Console.WriteLine("2 inversor (NOT)        ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("|==============|");
                Console.WriteLine("| INPUT|OUTPUT |");
                Console.WriteLine("|¨¨|¨¨¨|¨¨¨¨¨¨¨|");
                Console.WriteLine("| A|   |  X    |");
                Console.WriteLine("|¨¨|¨¨¨|¨¨¨¨¨¨¨|");
                Console.WriteLine("| 0|   |  1    |");
                Console.WriteLine("| 1|   |  0    |");
                Console.WriteLine("|==============|");

                Console.ReadLine();
            }

            else if (op == 3)
            {
                Console.Clear();
                Console.WriteLine("3 porta lógica OR       ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("|==============|");
                Console.WriteLine("| INPUT|OUTPUT |");
                Console.WriteLine("|¨¨|¨¨¨|¨¨¨¨¨¨¨|");
                Console.WriteLine("|A | B |  X    |");
                Console.WriteLine("|¨¨|¨¨¨|¨¨¨¨¨¨¨|");
                Console.WriteLine("| 0|  0|   0   |");
                Console.WriteLine("| 0|  1|   1   |");
                Console.WriteLine("| 1|  0|   1   |");
                Console.WriteLine("| 1|  1|   1   |");
                Console.WriteLine("|==============|");
                Console.ReadLine();
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("meu amigo, a opção que não tem no menu não meti weeeee!");
                Console.ReadLine();
            }

        }
    }

    //=========================================================================
    //IMPLEMENTAÇÃO DO JOGO DE QUIZ
    //=========================================================================
    private static void jogoDeTLP()
    {
        int op = 1;
        while (op != 0)
        {
            Console.Clear();
            Console.WriteLine("         DIGITE A OPÇÃO 1 DO MENU PARA ENTRAR NO JOGO                ");
            Console.WriteLine("1                             ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("0 voltar ao menu anterior     ");

            op = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.ReadLine();

            if (op == 0)
            {
                break;
            }

            else if (op == 1)
            {
                Console.WriteLine("                                TESTE O SEU CONHECIMENTO EM PROGRAMAÇÃO                                  ");
        	Console.WriteLine("========================================================================================================================");

        	Console.BackgroundColor = ConsoleColor.Black;

                string[] perguntas = {                 
            		" O Que é delbuger ?",
            		" O Que é uma variável ?",
            		" O Array é acessado a partir de um ?",
            		" Qual é a função do GETTIPE ?",
            		" Adicionar um valor fixo a uma variável significa adicionar um valor constante ?",
            		" Um dos passos da  sintaxe do if funciona da seguinte forma :",
           		" Qual das opções existe na sintaxe do switch case:",
             		" Em c# usa-se o Console.ReadLine para:",
        	};
        	
		Console.WriteLine("========================================================================================================================");
                Console.WriteLine(" PARABENS,VOCÊ GANHOU  100 pontos");

                int a = 0;
                while (a <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("");
                    Console.Write("");
                    Console.Write("■■");
                    Console.Write("■■■■");
                    Console.WriteLine("");

                    Thread.Sleep(100);
                    a++;
                }
                
		Console.ForegroundColor = ConsoleColor.Blue;
        	
		string[][] opções = {
            		new string[] { "a)serve para limpar  ",  "b) Debulger é o processo de identificar, isolar e corrigir erros ou bugs em um programa.",  "c) isso não existe" },
            		new string[] { "a) Uma variável é um espaço de armazenamento nomeado que pode conter um valor ou informações modificáveis durante a execução de um programa.",   "b)Uma variável é um espaço de armazenamento da CPU ",   "c) Uma variável é uma letra" },
            		new string[] { "a) Um loop", "b) índice", "c) um for" },
            		new string[] { "a) Identificar o loop ", "b)  Para dar espaço", "c) Identificar o tipo de dado de uma variável " },
            		new string[] { "a) Falso ",    "b)  verdade ", "c) em programação isso não existe " },
            		new string[] { "a) Primeiro testa-se o bloco else ",    "b) não existe uma condição ", "c) A condição é avaliada " },
            		new string[] { "a) Primeiro testa-se o bloco else ",    "b) A variável( que representa uma expressão avaliada ) ", "c) A condição é avaliada " },
            		new string[] { "a)  Saída de dados", "b) índice", "c) Leitura de dados" },
        	};

                string[] respostasCorretas = { "b", "a", "b", "c", "b", "c", "b", "c" };
       
        	int pontuação = 0;
                
		while (true)
        	{
            		for (int i = 0; i < perguntas.Length; i++)
            		{
                		Console.WriteLine(perguntas[i]);
                		foreach (string opcao in opções[i])
                		{
                    			Console.WriteLine(opcao);
               			}

                		Console.Write("Escolha a opção correta (a, b ou c): ");                     

                		Console.WriteLine("====");

                		string respostaUsuario = Console.ReadLine().ToLower();

                        	Console.Clear();
                        	Console.ForegroundColor = ConsoleColor.Yellow;
                        	
				if (respostaUsuario == respostasCorretas[i])
                        	{
                    			Console.WriteLine("Resposta correta!\n");
                            		pontuação += 100;
                            		Console.WriteLine($"{pontuação} pontos");
                        	}
                        	else
                          	{
                         		Console.WriteLine($"Resposta incorreta. A resposta correta é:  {respostasCorretas[i]}\n");
                            		pontuação -= 50;
                            		Console.WriteLine($" - {pontuação}  da pontuação");
                        	}
           		 }		
            
                         Console.Write("Deseja jogar novamente? (s/n): ");
                         string jogarNovamente = Console.ReadLine().ToLower();
                         
			 if (jogarNovamente != "s")
                         {
                               break;
                         }
        	}

        	Console.WriteLine($"Sua pontuação final é: {pontuação}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("meu amigo, a opção que não tem no menu não meti ueeeee");
                Console.ReadLine();

            }
    	} 
      }

	//=========================================================================
    	//IMPLEMENTAÇÃO DO JOGO DE QUIZ
    	//=========================================================================
   
    	private static void calculadora()
    	{
        	int op = 1;
        	while (op!=0)
        	{
            		Console.ForegroundColor = ConsoleColor.Yellow;
            		Console.Clear();
            		Console.WriteLine(" calculador cientifica");
            		Console.WriteLine("");
            		Console.WriteLine("");
            		Console.WriteLine(" escolha uma das opções da calculadora");
            		Console.WriteLine("1     adição          ");
            		Console.WriteLine("2      subtração      ");
            		Console.WriteLine("3      multiplicação  ");
            		Console.WriteLine("4      divisão        ");
            		Console.WriteLine("5      Potenciação    ");
            		Console.WriteLine("6     percentagem     ");
            		Console.WriteLine("7     Raiz quadrada");
            		Console.WriteLine("");
            		Console.WriteLine("");
            		Console.WriteLine("");
            		Console.WriteLine("");
            		Console.WriteLine("");
            		Console.WriteLine("0 voltar ao menu anterior");
            		
			op = Convert.ToInt32(Console.ReadLine());
            		
			Console.Clear();
            		Console.ReadKey();
                	
			double resultado = 0;

            		if (op==0)
            		{
                		break;       
            		}
            		
			else if (op == 1)
            		{
                		Console.Clear();
                		Console.WriteLine(" Digite o seu nome para usar a calculadora");
                		string nome = Console.ReadLine();
                		
				Console.WriteLine(" Digite a sua idade "+nome);
                		int idade = int.Parse(Console.ReadLine());

                		Console.WriteLine(" Obrigado por seguir as instruções senhor "+nome);
                		Console.WriteLine("_______________________________________________");
                		Console.WriteLine(" A opção selecionada é a adição ");
                		Console.Write("");
                		Console.Write("");
                		Console.Write(" digite o primeiro valor");
                
				int n1 = Convert.ToInt32(Console.ReadLine());
                
				Console.Write(" digite o segundo valor");
                		int n2 = Convert.ToInt32(Console.ReadLine());

                		Console.WriteLine(" a soma de "+n1+"+"+n2+"="+(n1+n2));
		
                		StreamWriter escritor = new StreamWriter("nomes.txt");
		                
				escritor.WriteLine(nome);
                		escritor.WriteLine(idade);
                		escritor.WriteLine(n1+n2);

                		escritor.Close();

                		Console.ReadKey();
            		}
            		
			else if (op == 2)
            		{
               	 		Console.Clear();

                		Console.WriteLine(" Digite o seu nome para usar a calculadora");
                		string nome = Console.ReadLine();
                
				Console.WriteLine(" Digite a sua idade " + nome);
                		int idade = int.Parse(Console.ReadLine());

                		Console.WriteLine(" Obrigado por seguir as instruções senhor " + nome);
                		Console.WriteLine("_______________________________________________");

                		Console.WriteLine("A opção selecionada é a subtração ");
                		Console.Write("");
                		Console.Write("");
                		
				Console.Write(" digite o primeiro valor");
                		int n1 = Convert.ToInt32(Console.ReadLine());
                
				Console.Write(" digite o segundo valor");
                		int n2 = Convert.ToInt32(Console.ReadLine());
                		
				Console.WriteLine(" a sutração de " + n1 + "-" + n2 + "=" + (n1 - n2));

                		StreamWriter escritor = new StreamWriter("nomes.txt");

                		escritor.WriteLine(nome);
                		escritor.WriteLine(idade);
                		escritor.WriteLine(n1 - n2);
               	 		escritor.Close();

                		Console.ReadKey();
            		}
            		
			else if (op == 3)
            		{
                		Console.Clear();

                		Console.WriteLine(" Digite o seu nome para usar a calculadora");
                		string nome = Console.ReadLine();
                		
				Console.WriteLine(" Digite a sua idade " + nome);
                		int idade = int.Parse(Console.ReadLine());

                		Console.WriteLine(" Obrigado por seguir as instruções senhor " + nome);
                		Console.WriteLine("_______________________________________________");
                		Console.WriteLine(" A opção selecionada é a multiplicação ");
                		Console.Write("");
                		Console.Write("");
                		
				Console.Write(" digite o primeiro valor");
                		int n1 = Convert.ToInt32(Console.ReadLine());
                
				Console.Write(" digite o segundo valor");
                		int n2 = Convert.ToInt32(Console.ReadLine());
                		
				Console.WriteLine(" a multiplicação de " + n1 + "*" + n2 + "=" + (n1 * n2));

                		StreamWriter escritor = new StreamWriter("nomes.txt");

                		escritor.WriteLine(nome);
                		Console.WriteLine(idade);
                		escritor.WriteLine(n1 * n2);
                		escritor.Close();

                		Console.ReadKey();	
           	 	}
            		
			else if (op == 4)
            		{
                		Console.Clear();

	                	Console.WriteLine(" Digite o seu nome para usar a calculadora");
                		string nome = Console.ReadLine();
                
				Console.WriteLine(" Digite a sua idade " + nome);
                		int idade = int.Parse(Console.ReadLine());

                		Console.WriteLine(" Obrigado por seguir as instruções senhor " + nome);
                		Console.WriteLine("_______________________________________________");

                		Console.WriteLine(" opção a selecionada é a divisão ");
                		Console.Write("");
                		Console.Write("");
                		
				Console.Write(" digite o primeiro valor");
                		double n1 = Convert.ToDouble(Console.ReadLine());
                
				Console.Write(" digite o segundo valor");
                		double n2 = Convert.ToDouble(Console.ReadLine());
                
				Console.WriteLine(" a divisão de " + n1 + "/" + n2 + "=" + (n1 / n2));

                		StreamWriter escritor = new StreamWriter("nomes.txt");

                		escritor.WriteLine(nome);
                		escritor.WriteLine(idade);
                		escritor.WriteLine(n1 / n2);
                		escritor.Close();
                		Console.ReadKey();
            		}
            		
			else if(op==5)
            		{

                		Console.WriteLine(" Digite o seu nome para usar a calculadora");
                		string nome = Console.ReadLine();
                		
				Console.WriteLine(" Digite a sua idade " + nome);
                		int idade = int.Parse(Console.ReadLine());

               	 		Console.WriteLine(" Obrigado por seguir as instruções senhor " + nome);
                		Console.WriteLine("_______________________________________________");

                		Console.Write(" Digite a base");
                		int num1 = Convert.ToInt32 (Console.ReadLine());
                
				Console.Write(" Digite o expoente");
                		int num2 = Convert.ToInt32(Console.ReadLine());
                		resultado = Math.Pow(num1,num2);
                		
				Console.Write(" o resultado de "+num1+" elevado a "+num2+"  é    "+resultado);

		                StreamWriter escritor = new StreamWriter("nomes.txt");

                		escritor.WriteLine(nome);
                		escritor.WriteLine(idade);
                		escritor.WriteLine( resultado);
                		escritor.Close();
                		Console.ReadKey();
            		}
            		
			else if (op == 6)
            		{
                		Console.Clear();

                		Console.WriteLine(" Digite o seu nome para usar a calculadora");
                		string nome = Console.ReadLine();
                		Console.WriteLine(" Digite a sua idade " + nome);
                		int idade = int.Parse(Console.ReadLine());

                		Console.WriteLine(" Obrigado por seguir as instruções senhor " + nome);
                		Console.WriteLine("_______________________________________________");

                		Console.Write(" leia o valor da percentagem");
                		double percentagem = Convert.ToDouble(Console.ReadLine());
                		Console.Write(" Digite o número da percentagem a saber");
                		double número_de_percentagem = Convert.ToDouble(Console.ReadLine());
                		resultado = número_de_percentagem * percentagem / 100;
                		Console.Write(" o valor da persentagem é de  " +resultado) ;

                		StreamWriter escritor = new StreamWriter("nomes.txt");

                		escritor.WriteLine(nome);
                		escritor.WriteLine(idade);
                		escritor.WriteLine(resultado);
                		escritor.Close();

                		Console.ReadKey();
            		}
            		
			else if (op == 7)
                	{
                		Console.Clear();

                		Console.ReadKey();
            		}
        	}
    	}
}