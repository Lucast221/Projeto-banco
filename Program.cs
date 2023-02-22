using System;

namespace Banco
{
    class Program
    {
        //Definição dos dados 
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(personName: "Lucas");
            bankAccount.Deposit(amount: 100);
            bankAccount.Withdrawn(amount: 150);
            bankAccount.ShowDetails();
        }
    }
    // Definição de variáveis
    public class BankAccount
    {
        private string personName;
        private decimal balance;

        public decimal Balance => balance;

        //Criação de um construtor para dar entrada no 'personName', visto que ele é privado
        public BankAccount(string personName)
        {
            this.personName = personName;
        }
        //Definição de métodos ou funções(ações que serão realizadas)
        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        //Impedindo a retirada de um valor maior que o caixa
        public void Withdrawn(decimal amount)
        {if (amount > balance)
            {
                Console.WriteLine(value: "Valor informado é maior que o saldo");
                return;
            }
        balance -= amount; 
        }
        public void ShowDetails() 
        {
            Console.WriteLine(value: $"{personName} possui saldo de {balance:C2}");
        }
    }
}
