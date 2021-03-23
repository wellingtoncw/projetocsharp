using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1- Inserir novo aluno;");
            Console.WriteLine("2- Listar alunos;");
            Console.WriteLine("3- Calcular média geral;");
            Console.WriteLine("X- Sair.");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            // ToUpper transforma minúsculo em maiúsculo
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: Adicionar aluno
                        break;
                    case "2":
                        //TODO: Listar aluno
                        break;
                    case "3":
                        //TODO: Calcular média geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Escolha a opção 1, 2 ou 3.");
                }

                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1- Inserir novo aluno;");
                Console.WriteLine("2- Listar alunos;");
                Console.WriteLine("3- Calcular média geral;");
                Console.WriteLine("X- Sair.");
                Console.WriteLine();
                opcaoUsuario = Console.ReadLine();
            }
        }
    }
}
