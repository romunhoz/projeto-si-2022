using ProjetoBanco.Classes;
using System;
using System.Collections.Generic;

namespace ProjetoBanco
{
    class Program
    {
        static void Main()
        {            
            try
            {
                var roger = Cliente.CreateCliente("Roger", "Rua dos Garimpeiros N° 5", 16-999222999, "999.888.777-66", new DateTime(2002, 04, 11));
                var sueli = Cliente.CreateCliente("Sueli", "Rua dos Libaneses N° 28", 16-988287788,"111.333.222-44", new DateTime(1985, 03, 20));

               
                                
                Conta contaPoupanca = new Poupanca(roger, 445852, 2000);
                Conta contaCorrente = new ContaCorrente(sueli, 85774, 0);

                Console.WriteLine(roger.ToString());
                Console.WriteLine("Saldo {0}",contaPoupanca.Saldo);

                Console.WriteLine(sueli.ToString());
                Console.WriteLine("Saldo {0}", contaCorrente.Saldo);

                contaPoupanca.Transferir(500, contaCorrente);

                List<Conta> contas = new List<Conta>() { contaPoupanca, contaCorrente };

                Console.WriteLine(contaPoupanca.Saldo);
                contaPoupanca.Depositar(1000);
                Console.WriteLine(contaPoupanca.Saldo);
                contaPoupanca.Sacar(200);
                Console.WriteLine(contaPoupanca.Saldo);
                
               
                Console.WriteLine(contaCorrente.Saldo);
                contaCorrente.Depositar(1000);
                Console.WriteLine(contaCorrente.Saldo);
                contaCorrente.Sacar(500);
                Console.WriteLine(contaCorrente.Saldo);

                Console.WriteLine(roger.ToString());
                Console.WriteLine("Saldo {0}", contaPoupanca.Saldo);

                Console.WriteLine(sueli.ToString());
                Console.WriteLine("Saldo {0}", contaCorrente.Saldo);

            }            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }
    }
}