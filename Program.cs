using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            float[] notas1 = new float[10];
            float[] notas2 = new float[10];
            float[] notas3 = new float[10];
            float[] notas4 = new float[10];
            float[] geral = new float[10];
            int ContadorAprovados = 0;
            int ContadorReprovados = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o nome do {i+1}º aluno");
                nomes[i] = Console.ReadLine();
                Console.WriteLine($"Digite a 1º nota");
                notas1[i] = float.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a 2º nota");
                notas2[i] = float.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a 3º nota");
                notas3[i] = float.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a 4º nota");
                notas4[i] = float.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("--------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Aluno: {nomes[i]}");
                float Media = CalculoMedia(notas1[i], notas2[i], notas3[i], notas4[i]);
                geral[i] = Media;
                Console.WriteLine($"A média do aluno é {Media}");
                if(Media>=7){
                    Console.WriteLine("Aluno Aprovado");
                    ContadorAprovados = ContadorAprovados + 1;
                }else{
                    Console.WriteLine("Aluno Reprovado");
                    ContadorReprovados = ContadorReprovados + 1;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------------");
                Console.ForegroundColor = ConsoleColor.Green;
            } 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"A quantidade de Alunos Aprovados é {ContadorAprovados}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A quantidade de Alunos Reprovados é {ContadorReprovados}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            float exibirGeral = MediaGeral(geral[0], geral[1], geral[2], geral[3], geral[4], geral[5], geral[6], geral[7], geral[8], geral[9]);
            Console.WriteLine($"A Média Geral dos 10 alunos é {exibirGeral}");
            Console.ResetColor();
        }
          static float CalculoMedia(float a, float b, float c, float d)
            {
                float CalculoMedia = (a+b+c+d)/4;
                return CalculoMedia;
            }

            static float MediaGeral(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j)
            {
                float MediaGeral = (a+b+c+d+e+f+g+h+i+j)/10;
                return MediaGeral;
            }
      
    }
}
