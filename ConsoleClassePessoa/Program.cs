using System;

namespace ConsoleClassePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            
            Console.WriteLine("Digite o nome: ");
            pessoa.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade: ");
            pessoa.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o RG: ");
            pessoa.rg = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            pessoa.cpf = Console.ReadLine();

            Console.WriteLine("Nome: {0}", pessoa.nome);
            Console.WriteLine("Idade: {0}", pessoa.idade);
            Console.WriteLine("RG: {0}", pessoa.rg);
            Console.WriteLine("CPF: {0}", pessoa.cpf);


            Pessoa pessoaSilvia = new Pessoa();

            pessoaSilvia.nome = "Silvia";
            pessoaSilvia.idade = 22;
            pessoaSilvia.rg = "88.888.888-8";
            pessoaSilvia.cpf = "888.888.8888-8";

            Console.WriteLine("Nome: {0}", pessoaSilvia.nome);
            Console.WriteLine("Idade: {0}", pessoaSilvia.idade);
            Console.WriteLine("RG: {0}", pessoaSilvia.rg);
            Console.WriteLine("CPF: {0}", pessoaSilvia.cpf);

            pessoa.Acenar(pessoaSilvia);
            pessoa.PerguntaIdade(pessoaSilvia);

        }
    }
}
