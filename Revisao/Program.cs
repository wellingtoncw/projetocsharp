using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno[] alunos = new Aluno[5]; // cria array de alunos com tamanho 5
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            // ToUpper transforma minúsculo em maiúsculo
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Informe a nota do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota)) // tenta converter a string do ReadLine em decimal
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser um número decimal!");
                        }
                        Console.WriteLine();

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;

                    case "2":
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome)) //para que seja mostrada apenas os alunos cadastrados no Array
                            {
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                            }
                        }
                        break;

                    case "3":
                        //TODO: Calcular média geral
                        break;

                    default:
                        throw new ArgumentOutOfRangeException("Escolha entre as opções 1, 2 ou 3.");
                }


                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1- Inserir novo aluno;");
            Console.WriteLine("2- Listar alunos;");
            Console.WriteLine("3- Calcular média geral;");
            Console.WriteLine("X- Sair.");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
