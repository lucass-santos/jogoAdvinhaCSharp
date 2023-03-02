// See https://aka.ms/new-console-template for more information

namespace Advinha
{
    class Advinha
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("--------------------------Programa Advinhe o nº--------------------------");
            System.Console.WriteLine("Digite um número entre 1 e 20 e veja se você acerta qual foi o escolhido:");
            System.Console.WriteLine("Você terá 3 chances para acertar o número. Vamos lá?");
            
            int chances = 3;
            List<int> tentativas = new List<int>();
            Random geradorDeNumeros = new Random();
            int numeroGerado = geradorDeNumeros.Next(1, 21);

            while(chances > 0){
                int palpite = 0;
                System.Console.Write("Digite o número: ");
                bool retorno = false;
                while(retorno == false){
                    
                    retorno = int.TryParse(Console.ReadLine(), out palpite);

                    if(retorno == false){
                        System.Console.WriteLine("O valor digitado não é um nº.");
                        System.Console.WriteLine("Por favor digite apenas números entre 1 à 20:");
                    }
                    else if(palpite > 20 || palpite < 1){
                        retorno = false;
                        System.Console.WriteLine("O valor digitado está fora dos números do jogo.");
                        System.Console.WriteLine("Por favor digite apenas números entre 1 à 20:");
                    }
                    
                }

                if(palpite != numeroGerado){
                    System.Console.WriteLine("Você errou...");

                    System.Console.WriteLine($"Ainda tem {chances -=1} chances");
                    tentativas.Add(palpite);
                    System.Console.Write("Seus palpites: ");
                    foreach(int numeros in tentativas){
                        System.Console.Write(numeros + " ");
                    }
                    System.Console.WriteLine("\n");
                    if(palpite < numeroGerado){
                        System.Console.WriteLine("O número que procura é maior que o digitado...");
                    }else{
                        System.Console.WriteLine("O número que procura é menor que o digitado...");
                    }
                    if(chances == 0){
                        System.Console.WriteLine("Você perdeu...");
                    }
                }else if(palpite == numeroGerado){
                    chances = 0;
                    System.Console.WriteLine("Você acertou!!!");
                    break;
                }

                
            }
            System.Console.WriteLine("Fim do jogo.");
        }
    }
}