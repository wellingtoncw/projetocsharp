﻿using System;

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
                        decimal notaTotal = 0;
                        var numeroAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome)) //para que seja calculado apenas os alunos inseridos no Array
                            {
                                notaTotal = notaTotal + alunos[i].Nota; // soma a nota em cada indice do Array
                                numeroAlunos++; // incrementa o numero de alunos
                            }
                        }

                        var mediaGeral = notaTotal / numeroAlunos;
                        Conceito conceitoGeral;

                        if (mediaGeral <= 2)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if (mediaGeral <= 4)
                        {
                            conceitoGeral = Conceito.D;
                        }
                        else if (mediaGeral <= 6)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        else if (mediaGeral <= 8)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"A média geral da turma é de: {mediaGeral} e o conceito é: {conceitoGeral}");
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
