using System;
using System.Collections.Generic;

namespace My_Project
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.Title = "Endless Journey";

            Console.WindowWidth = 100;
            Console.WindowHeight = 40;
            

            Console.WriteLine("Bem vindo a Endless Journey. Um jogo de interpretação, imaginação e escolhas.");
            Console.WriteLine("Qual o seu nome?\n");

            string userName = Console.ReadLine();
            
            Console.WriteLine(userName + ", Seu objetivo será desvendar os mistérios do local onde se encontra e encontrar uma forma de fugir.\n");
            Console.WriteLine("Pressione qualquer tecla para continuar.\n");

            Console.ReadLine();

            Console.WriteLine("\nSeus sentidos aos poucos retornam. Você sente seu corpo pesado e o chão frio sob suas costas.");
            Console.WriteLine("Ar húmido preenche seus pulmões e sua visão turva delinei um cômodo completamente escuro.\n");
            Console.WriteLine("O que você faz?\n");

            
            List<string> opçoes = new List<string>();

            opçoes.Add("Se examinar.");
            opçoes.Add("Olhar em volta.");
            opçoes.Add("Chamar por ajuda.\n");

            for (int i = 0; i < opçoes.Count; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + "." + opçoes[i]);
            }



            if (Console.ReadKey().KeyChar == '1')
            {
                Console.WriteLine("Você encontra um isqueiro.");
                opçoes.RemoveAt(0);
                
                for (int i = 0; i < opçoes.Count; i++)
                {
                    int rank = i + 1;
                    Console.WriteLine(rank + "." + opçoes[i]);
                }
            }


            Console.ReadKey();
            
        }
    }
}
