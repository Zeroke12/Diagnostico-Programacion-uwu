using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicioDeProgramacion
{
    class Program
    {
        public static int Repeticion(string arg, string sb)
        {
            int s = 0;
            int b = 0;

            string[] palabras = arg.Split(' ');

            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[s] == sb)
                {
                    b++;
                    s++;
                    Console.WriteLine(b);
                    s = 0;
                }
                Console.ReadLine();
            }
            return b;
        }
        public static bool Palindromo(string arg)
        {
            bool valor = true;
            int p = 0;
            char[] caracter = new char[arg.Length];
            foreach (char c in arg)
            {
                caracter[p] = c;
                p++;
            }
            foreach (char c in arg)
            {
                p--;
                if (c == caracter[p])
                {
                    valor = true;
                }
                else
                {
                    valor = false;
                    return valor;
                }

            }
            return valor;
        }

        static void Main(string[] arg)
        {
            bool op = true;
            string seleccion = "";
            string palindromo = "";
            while (op == true)
            {
                Console.WriteLine("1. Palindromo \n");
                Console.WriteLine("2. Repeticion \n");
                Console.WriteLine("3. Salir \n");
                seleccion = Console.ReadLine();

                switch (seleccion)
                {
                    case ("1"):
                        Console.Clear();
                        Console.WriteLine("Digite la palabra a comparar en el campo siguiente ");
                        palindromo = Console.ReadLine();
                        bool texto = Palindromo(palindromo);
                        if (texto == true)
                        {
                            Console.WriteLine("La palabra es palindromo ");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("La palabra no es palindromo ");
                            Console.ReadLine();
                        }
                        break;

                        case ("2"):
                        Console.Clear();
                        int repeticion = 0;
                        string texto1 = "";
                        string texto2 = "";
                        Console.WriteLine(" Escriba una frase ");
                        texto1 = Console.ReadLine();
                        Console.WriteLine("Escriba la palabra que quiere saber si se repitio ");
                        texto2 = Console.ReadLine();
                        repeticion = Repeticion(texto1, texto2);
                        Console.WriteLine("La palabra se repitio " + repeticion + " veces ");
                        Console.ReadLine();

                        break;

                        case ("3"):
                        op = false;
                        break;
                        break;
                }
                    
            }
        }

        
    }
}

