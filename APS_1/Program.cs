using System;

namespace Aps1
{
    class Program
    {
        //Método Principal 
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um tamanho para o vetor");
            int tamanhoVetor = int.Parse(Console.ReadLine());
            int[] vetor = new int[tamanhoVetor];


            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.WriteLine("Digite um número:");
                int numero = int.Parse(Console.ReadLine());
                vetor[i] = numero;
            }

            int contador = 0;
            Console.WriteLine("==========================================");
            while (contador < vetor.Length)
            {
                Console.WriteLine(vetor[contador]);
                contador++;
            }
            Console.WriteLine("==========================================");

            Console.WriteLine("Digite o número que você quer achar");
            int chave = int.Parse(Console.ReadLine());
            int min = 0;
            int max = vetor.Length - 1;

            string resultado = pesquisaBinaria(vetor, chave, min, max);


            DesenharArray(vetor);
            Console.WriteLine($"O índice com o valor é : {resultado}");
            Console.ReadKey();
        }

        //Método que faz a pesquisa Binária
        static string pesquisaBinaria(int[] vetor, int chave, int min, int max)
        {
            //Ordena o vetor.
            Array.Sort(vetor);
            int meio = (min + max) / 2;

            while (max >= min)
            {

                if (chave == vetor[meio])
                {
                    return meio.ToString();
                }

                else if (chave > vetor[meio])
                {
                    min = meio + 1;

                    if (chave == vetor[min])
                    {
                        return min.ToString();
                    }
                    else
                    {
                        return pesquisaBinaria(vetor, chave, meio + 1, max);
                    }
                }

                else if (chave < vetor[meio])
                {
                    max = meio - 1;

                    if (chave == vetor[max])
                    {
                        return max.ToString();
                    }
                    else
                    {
                        return pesquisaBinaria(vetor, chave, min, meio - 1);
                    }
                }
            }

            return "Não existe";
        }

        //Método para Desenhar o Array no final
        public static void DesenharArray(int[] vetor)
        {
            Array.Sort(vetor);
            Console.WriteLine("Vetor Ordenado");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Chave  -  Valor");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($" {i}    -     {vetor[i]}");
            }
            Console.WriteLine("-------------------------------");
        }
    }
}
