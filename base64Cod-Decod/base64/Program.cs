using System;
using System.IO;

namespace Base64EncoderDecoder
{
    class Program
    {
        //Criando o processo de codificação
        static void EncodeFile(string inputPath, string outputPath)
        {
            byte[] data = File.ReadAllBytes(inputPath);
            string base64String = Convert.ToBase64String(data);
            File.WriteAllText(outputPath, base64String);
        }
        
        //Criando o processo de decodificação
        static void DecodeFile(string inputPath, string outputPath)
        {
            string base64String = File.ReadAllText(inputPath);
            byte[] data = Convert.FromBase64String(base64String);
            File.WriteAllBytes(outputPath, data);
        }

        //Criando oque vai aparecer para quem utilizar o software
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Codificar arquivo para Base64");
            Console.WriteLine("2 - Decodificar arquivo de Base64");
            Console.Write("Escolha uma opção (1/2): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Digite o caminho do arquivo de entrada: ");
                string inputPath = Console.ReadLine();
                Console.Write("Digite o caminho do arquivo de saída codificado: ");
                string outputPath = Console.ReadLine();
                EncodeFile(inputPath, outputPath);
                Console.WriteLine("Arquivo codificado com sucesso!");
            }
            else if (choice == "2")
            {
                Console.Write("Digite o caminho do arquivo de entrada codificado: ");
                string inputPath = Console.ReadLine();
                Console.Write("Digite o caminho do arquivo de saída decodificado: ");
                string outputPath = Console.ReadLine();
                DecodeFile(inputPath, outputPath);
                Console.WriteLine("Arquivo decodificado com sucesso!");
            }
            else
            {
                Console.WriteLine("Opção inválida. Escolha 1 ou 2.");
            }
        }
    }
}