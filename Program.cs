using System;
using System.Globalization;
namespace mediaDoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            TextInfo text = CultureInfo.CurrentCulture.TextInfo;

            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno.nomeAluno = Console.ReadLine();
            aluno.nomeAluno = text.ToTitleCase(aluno.nomeAluno);

            Console.WriteLine("Digite a primeira nota: ");
            aluno.nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a segunda nota: ");
            aluno.nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.SomarNotas();

            aluno.Media();

            aluno.PassouDeAno(); 
        }
    }
}
