using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double saldo = 9000;
        int opcao = 1;

        var consultarSaldo = () =>
        {
            Console.WriteLine("Você possui um saldo de " + saldo);
        };

        var depositar = () =>
        {
            Console.WriteLine("Digite o valor para depositar");

            string valorDigitado = Console.ReadLine();
            var valor = double.Parse(valorDigitado);

            if (valor <= 0)
            {
                Console.WriteLine("Operação cancelada o valor digitado é menor ou igual a zero!");
            }
            else
            {
                saldo = valor + saldo;
            }
        };

        var sacar = () =>
        {
            Console.WriteLine("Digite o valor para sacar");

            string valorDigitado = Console.ReadLine();
            var valor = double.Parse(valorDigitado);

            if (valor <= 0)
            {
                Console.WriteLine("Operação cancelada o valor digitado é menor ou igual a zero!");
            }
            else if (valor > saldo)
            {
                Console.WriteLine("Operação cancelada não há saldo suficiente para o saque!");
            }
            else
            {
                saldo = saldo - valor;
            }
        };

        while (opcao != 0)
        {
            Console.WriteLine("Bem vindo ao programa");
            Console.WriteLine("Digite 1 para consultar o saldo");
            Console.WriteLine("Digite 2 para depositar");
            Console.WriteLine("Digite 3 para sacar");
            Console.WriteLine("Digite 0 para sair");

            string valorDigitado = Console.ReadLine();
            opcao = int.Parse(valorDigitado);

            switch (opcao)
            {
                case 1:
                    consultarSaldo();
                    break;
                case 2:
                    depositar();
                    break;
                case 3:
                    sacar();
                    break;
                case 0:
                    Console.WriteLine("Obrigado por usar o sistema");
                    break;
                default:
                    Console.WriteLine("Opão inválida!");
                    break;
            }
        }

    }
}