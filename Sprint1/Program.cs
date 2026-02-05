using System;

namespace SistemaBancario
{

    abstract class ContaBancaria
    {
        protected int numero;
        protected string titular;
        protected double saldo;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public ContaBancaria(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

    }

    class ContaCorrente : ContaBancaria
    {
        
        public ContaCorrente(int numero, string titular, double saldo) : base(numero, titular, saldo)
        {

        }


    }

    class ContaPoupanca : ContaBancaria
    {

        public ContaPoupanca(int numero, string titular, double saldo) : base(numero, titular, saldo)
        {

        }
    }

    class ContaEmpresarial : ContaBancaria
    {

        public ContaEmpresarial(int numero, string titular, double saldo) : base(numero, titular, saldo)
        {

        }

    }



    class Program
    {

        static void Main()
        {
        
        }
    }
}
