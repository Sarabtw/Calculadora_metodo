using Calculadora;
using Layout;
class Program
{
     static void Main()
    {
        while (true)
        {

            Console.Clear();
            Formatacao.Cor("Com qual operação deseja trabalhar?\n", ConsoleColor.Green);
            Formatacao.Cor("1 - Adição\n", ConsoleColor.Cyan);
            Formatacao.Cor("2 - Subtração\n", ConsoleColor.Cyan);
            Formatacao.Cor("3 - Divisão\n", ConsoleColor.Cyan);
            Formatacao.Cor("4 - Multiplicação\n", ConsoleColor.Cyan);
            Formatacao.Cor("5 - Sair\n", ConsoleColor.Red);
            Formatacao.Cor("Digite a opção aqui: \n", ConsoleColor.Cyan);
            string opcao = Console.ReadLine();

           if(opcao == "5")
           {
             Formatacao.Cor("Saindo...\n", ConsoleColor.Red);
             break;
           }

           decimal valor1 = Operacoes.ObterValores();
           decimal valor2 = Operacoes.ObterValores();

            switch (opcao)
            {
            case "1":
            Operacoes.RealizarAdicao(valor1, valor2);
            
            break;
            case "2":
            Operacoes.RealizarSubtracao(valor1, valor2);
           
            break;
            case "3":
            Operacoes.RealizarDivisao(valor1, valor2);
             
            break;
            case "4":
            Operacoes.RealizarMultiplicacao(valor1, valor2);
            
            break;
            default:
            Formatacao.Cor("Opção inválida! Tente novamente.\n", ConsoleColor.Red);
             break;

            }
            Console.ReadKey();
       }
    }
}
