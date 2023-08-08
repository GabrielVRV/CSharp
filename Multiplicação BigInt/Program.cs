using System;
using System.Numerics;

namespace  BigIntMultiplica
{
    class Program{
        static void Main(string[] args){

            bool repeatAux = true;

            //Criando uma estrutura de repetição para caso seja necessário realizar mais de uma operação
            while (repeatAux){    
                Console.WriteLine("Digite o primeiro número:");
                string inputNum1 = Console.ReadLine();

                Console.WriteLine("Digite o segundo número:");
                string inputNum2 = Console.ReadLine();

                //Realizando a conversão de String para BigInteger e ao mesmo tempo verifica se é um número
                if (BigInteger.TryParse(inputNum1, out BigInteger num1) &&
                    BigInteger.TryParse(inputNum2, out BigInteger num2))
                {
                    //Caso tenha conseguido realizar a conversão, realiza a multiplicação e exibe o resultado
                    BigInteger result = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação é:");
                    Console.WriteLine(result);

                    //Verifica se é necessário realizar uma nova operação
                    Console.WriteLine("Você deseja realizar uma nova operação? Digite S para sim e N para não");
                    string aux = Console.ReadLine();

                    /*Caso a resposta seja sim ele mantem a variavel repeatAux como verdadeira fazendo
                      com que repita todo o processo*/
                    if(aux == "s" || aux == "S"){
                        repeatAux = true;
                    }

                    /*Caso a resposta seja diferente de sim ele altera a variavel para false fazendo com
                      que saia do loop e assim encerre o programa */
                    else{
                        repeatAux = false;
                    }
                    
                }
                else
                {
                    /*Caso seja verificado que não possível converter para BigInt significa que não é um número
                    então solicita que seja inserido um número válido*/
                    Console.WriteLine("Entrada inválida! Certifique-se de digitar números válidos.");
                    repeatAux = true;
                }
            }       
        }
    }
    
}