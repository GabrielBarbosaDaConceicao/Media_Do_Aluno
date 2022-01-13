using System;
using System.Globalization;
using System.Text;

namespace mediaDoAluno
{
    public class Aluno
    {
        public string nomeAluno { get; set; }
        public double nota1 { get; set; }
        public double nota2 { get; set; }
        public  double total { get; set; }
        public double media { get; set; }

        public string NomeAluno
        {
            get { return nomeAluno; }
            set { nomeAluno = Console.ReadLine(); }
        }

        public void SomarNotas()
        {
            total = nota1 + nota2;
            Console.WriteLine($"\nO soma das notas do aluno {nomeAluno}, é [{total.ToString("F2", CultureInfo.InvariantCulture)}].");
        }

        public void Media()
        {
            media = (nota1 + nota2) / 2.0;
            Console.WriteLine($"\nA média das notas do aluno {nomeAluno}, foi [{media.ToString("F2", CultureInfo.InvariantCulture)}].");
        }

        public void PassouDeAno()
        {
            if (media >= 8.0 && media <= 10.0)
            {
                Console.WriteLine($"\nParabéns! O aluno {nomeAluno} passou de ano diréto. ");
            }
            else if (media >= 6.0 && media < 8.0)
            {
                Console.WriteLine($"\nO aluno {nomeAluno} ficou de recuperação. ");
            }
            else
            {
                Console.WriteLine($"\nO aluno {nomeAluno} reprovou.");
            }
        }
    }
}
