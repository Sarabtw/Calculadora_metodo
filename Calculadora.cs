//using System.Runtime.InteropServices;
 using Layout;

namespace Calculadora
{

   class Operacoes
   {
      
      public static decimal ObterValores()
      {
      repetir:
          Formatacao.Cor("Informe o valor: ", ConsoleColor.Cyan);
          if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
          {
            Console.WriteLine("Valor inválido! \n");
            goto repetir;
          }
          else
          {
            return valor;
          }
      }
       public static void RealizarAdicao(decimal valor1, decimal valor2)
      {
        MostrarResultado("soma", valor1, valor2, valor1 + valor2);
      }
      public static void RealizarSubtracao(decimal valor1, decimal valor2)
      {
        MostrarResultado("subtração", valor1, valor2, valor1 - valor2);
      }
      public static void RealizarMultiplicacao(decimal valor1, decimal valor2)
      {
        MostrarResultado("multiplicação", valor1, valor2, valor1 * valor2);
      }
      public static void RealizarDivisao(decimal valor1, decimal valor2)
      {
        if (valor2 == 0)
        {
          Formatacao.Cor("Erro: Divisão por zero!/n", ConsoleColor.Red);
          return;
        }
          MostrarResultado("divisão", valor1, valor2, valor1 / valor2);
      }
       private static void MostrarResultado(string operacao, decimal valor1, decimal valor2, decimal resultado)
      {
        Formatacao.Cor($"O resultado da {operacao} ", ConsoleColor.Green);
        Formatacao.Cor($"de ", ConsoleColor.Green);
        Formatacao.Cor($"{valor1} ", ConsoleColor.Green);
        Formatacao.Cor($"e ", ConsoleColor.Cyan);
        Formatacao.Cor($"{valor2} ", ConsoleColor.Green);
        Formatacao.Cor($"é: ", ConsoleColor.Green);
        Formatacao.Cor($"{resultado}\n", ConsoleColor.Green);
      }
   }

}
