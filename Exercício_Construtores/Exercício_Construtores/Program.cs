using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Construtores
{
    internal class Program
    {  //lucas gabriel 03/02/23
        static void Main(string[] args)
        {
            double saldo1 = 0, saldo2,saldo3, total1, total2;
            Console.Write("Entre o número da conta: ");
            int numero_conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta:  ");
            string titular_conta = Console.ReadLine();

            Console.Write("Haverá deposito inicial (S/N): ");
            string deposito = Console.ReadLine();
            if(deposito == "S")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                saldo1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

            }
            else
            {
               
            }
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine("Conta " + numero_conta + ", Titular: " + titular_conta + " Saldo: $" + saldo1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.Write("Entre um valor de depósito: ");
            saldo2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            total1 = saldo1 + saldo2;
            Console.WriteLine();

            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine("Conta " + numero_conta + ", Titular: " + titular_conta + " Saldo: $" + total1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            saldo3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            total2 = total1 - saldo3;
            Console.WriteLine();

            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine("Conta " + numero_conta + ", Titular: " + titular_conta + " Saldo: $" + total2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.ReadKey();
        }

    }
}
