
// Author: PHNO - Tecnólogo | Pós-Graduado
// Data Release: 17/09/2023
// Versão Código: 2.0.1v
// Replit: @PHNO, @PHREPLIT
// E-mail: phreplit@gmail.com

// Algorithm: Basic Calculator in C Sharp, with 4 basic functions, with menu and console compilation.

// Algoritmo: Calculadora Basica em C Sharp, com 4 funcoes basicas, com menu e compilacao em console.

using System; // importa lib

class Calculadora { // classe
  
 public static void Main (string[] args) {

   while (true) {
    // classe, metodo, string
     Console.WriteLine ("\n"); 
     Console.WriteLine (" :::::::::::::::::::::::::::::::::::::::::::::::::::::::");
     Console.WriteLine (" :: Calculadora Basica em C Sharp - 4 Funcoes Basicas ::");
     Console.WriteLine (" :::::::::::::::::::::::::::::::::::::::::::::::::::::::");
     Console.WriteLine ("");
     Console.WriteLine ("  Menu \n");
     
     Console.WriteLine (" 1 - Somar"); // sum
     Console.WriteLine (" 2 - Subtrair"); // subtract
     Console.WriteLine (" 3 - Multiplicar"); // multiply
     Console.WriteLine (" 4 - Dividir"); // divide - divisao simples
     Console.WriteLine (" 5 - Sair"); // exit

     Console.WriteLine ("\n [9] Sobre "); // about

     Console.WriteLine ("\n Digite sua escolha 1 a 5: "); // choice
     
      try {
      int escolha = Convert.ToInt32 (Console.ReadLine ());
      Console.WriteLine("\n");
        
      switch (escolha) {
	case 1:
            Console.WriteLine (" Digite um numero: ");
	    int a = Convert.ToInt32 (Console.ReadLine ());
	    Console.WriteLine (" Digite outro numero: ");
	    int b = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine();
            Console.WriteLine (" O resultado da soma: " + (a + b));
            Console.WriteLine();
            Console.WriteLine(" Teclar enter para retornar ao menu...");
            Console.ReadKey();
            Clear(); // chama metodo
	    break;
	  case 2:
            Console.WriteLine (" Digite um numero: ");
	    int c = Convert.ToInt32 (Console.ReadLine ());
	    Console.WriteLine (" Digite outro numero: ");
	    int d = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine();
	    Console.WriteLine (" O resultado da subtracao: " + (c - d));
            Console.WriteLine();
            Console.WriteLine(" Teclar enter para retornar ao menu...");
            Console.ReadKey();
            Clear(); // chama metodo
	    break;
	  case 3:
            Console.WriteLine (" Digite um numero: ");
	    int e = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine (" Digite outro numero: ");
	    int f = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine();
	    Console.WriteLine (" O resultado da multiplicacao: " + (e * f));
            Console.WriteLine();
            Console.WriteLine(" Teclar enter para retornar ao menu...");
            Console.ReadKey();
            Clear(); // chama metodo
	    break;
	  case 4:
            Console.WriteLine (" Digite um numero: ");
	    int g = Convert.ToInt32 (Console.ReadLine ());
	    Console.WriteLine (" Digite outro numero: ");
	    int h = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine();
	    Console.WriteLine (" O resultado da divisao simples: " + (g / h));
            Console.WriteLine();
            Console.WriteLine(" Teclar enter para retornar ao menu...");
            Console.ReadKey();
            Clear(); // chama metodo
	    break;
	  case 5:
            Exit(); // chama metodo
	    break;
	  case 9:
	    Clear();
            Console.WriteLine();
            Console.WriteLine(" Algoritmo: Calculadora Básica em C Sharp");
            Console.WriteLine("\n Author: PHNO");
            Console.WriteLine(" Data Release: 17/09/2023");
            Console.WriteLine(" Versao Codigo: 2.0.1v");
            Console.WriteLine(" Replit: @PHNO, @PHREPLIT");
            Console.WriteLine(" E-mail: phreplit@gmail.com");
            Console.WriteLine();
            Console.WriteLine(" Teclar enter para retornar ao menu...");
            Console.ReadKey();
            Clear(); // chama metodo
	    break;
	  default:
            Console.WriteLine (" Erro, escolha novamente! ");
            Console.WriteLine();
            Console.WriteLine(" Teclar enter para retornar ao menu...");
            Console.ReadKey();
            Clear(); // chama metodo
	  break;
     }
     } catch (Exception e) {
            Console.WriteLine(" Erro no sistema.");
            Console.WriteLine();
            Console.WriteLine(" Teclar enter para retornar ao menu...");
            Console.ReadKey();
            Clear(); // chama metodo
     }  
    }
   }
	
   public static void Exit() { // metodo sair
           Console.WriteLine();
           Console.WriteLine (" Algoritmo Finalizado! ");
           Console.WriteLine();
           System.Environment.Exit(-1);
           return;
     }
	
   public static void Clear() { // metodo limpar
     Console.Clear();
     return;
    }
  }
  
