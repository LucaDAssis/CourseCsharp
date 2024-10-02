using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class ContaBancaria
    {
        public BigInteger Numero { get; private set; }
        public String Titular { get; set; }
        public Double Saldo { get; private set; }

        public ContaBancaria(BigInteger numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public ContaBancaria(BigInteger numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Dados da Conta: "
                + "Titular: "
                + Titular
                + " Saldo: $"
                + Saldo;
        }

    }
}
