using System;
using System.Collections.Generic;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> pilha = new Stack<char>();

            bool isBemFormada = true;

            Console.WriteLine("Digite a sequencia de parenteses e colchetes: ");
            string sequencia = Console.ReadLine();

            for(int i=0;i< sequencia.Length;i++) {
                if (sequencia[i] == '[' || sequencia[i] == '(')
                {
                    pilha.Push(sequencia[i]);

                }else if (sequencia[i] == ']')
                {
                    char desempilha = pilha.Peek();
                    if(desempilha == '[')
                    {
                        pilha.Pop();
                    }
                    else
                    {
                        isBemFormada = false;
                    }
                }else if (sequencia[i] == ')')
                {
                    char desempilha = pilha.Peek();
                    if(desempilha == '(')
                    {
                        pilha.Pop();
                    }
                    else
                    {
                        isBemFormada = false;
                    }
                }
            }

            if (isBemFormada)
            {
                Console.WriteLine("A sequencia é bem-formada");
            }
            else
            {
                Console.WriteLine("A sequencia é malformada");
            }

            Console.ReadLine();
        }
    }
}
