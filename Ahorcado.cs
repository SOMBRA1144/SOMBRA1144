using System;

namespace Aorcado
{
    class Program
    {
        static void Main(string[] args)
        {

       int intentos = 0, Ganar = 0;

       
            string palabra = eligepalabra();
            char[] palabraChar = palabra.ToCharArray();
            char[] longitud = GenerarEspacios(palabra);
            //Variable donde se guardara lo que el susuario escriba 
            string ingresaletra = string.Empty;
            //variable char donde guardaremos la letra que teclea el usuario en string
            char ingresaletrachar = ' ';
           //Por si gana 
            bool gano = false;




//Bucle para repetir el ingreso de palabras hasta que ganemos o perdamos
            while (gano == false)
            {
                int letra = 0, contador = 0, repite = 0;
//Bucle para comparar si la letra que se ingresa es solo una no se sale de el hasta que se ingrese una letra
                while (letra == 0)
                {
                    //Mostrar el aorcado
                    muestraaorcado(intentos);
                    //Mostrar la palabra que debe ir en los guiones
                    ImprimirEspacios(longitud);

                    Console.WriteLine("\nHas Fallado: {0}", intentos);
                    Console.Write("\nIntroduce una letra: ");
                    ingresaletra = Console.ReadLine();
                    //Comprobar los caracteres del teclado
                    if (CompruebaUna(ingresaletra))
                    {
                        //Comparar la letra
                        ingresaletrachar = Convert.ToChar(ingresaletra);
                        letra++;
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("Ingresa solo una letra!.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }


                //Bucle para encontrar la letra y sustituir la letra
                for (int k = 0; k < longitud.Length; k++)
                {
                    //Condicional para saber si la letra que ingresa ya habia sido encontrada
                    if (longitud[k] == ingresaletrachar)
                    {
                        if (repite == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Esta letra ya ha sido encontrada, intenta con otra.");
                            Console.ReadKey();
                            repite++;
                        }
                        contador++;
                    }
                    else
                    {
                 //Condicional para comparar la letra con toda palabra y asi cambiarla en la impresion de guiones
                        if (ingresaletrachar == palabraChar[k])
                        {
                            longitud[k] = ingresaletrachar;
                            //Para no generar un intento fallido
                            contador++;
                            //Para contar las letras que encuentra 
                            Ganar++;
                        }
                    }
                }



                if (contador == 0)
                {
                    intentos++;
                }
                //Salida por si se acaban los intentos
                if (intentos == 5)
                {
                    Console.Clear();
                    muestraaorcado(intentos);
                    Console.WriteLine("\nSe terminaron tus intentos\nYa lo mataste!");
                    Console.ReadKey();
                    break;
                }
                //Terminar pos si se encontro toda la palabra
                if (Ganar == palabraChar.Length)
                {
                    gano = true;
                }
                Console.Clear();








                
            }
            ImprimirFinJuego(palabra, intentos, gano);
        }
        static string eligepalabra()
        {
            Random rdn = new Random();
            int n = rdn.Next(0,4);

            //palabras a encontrar
            string[] palabras = { "hospital", "carro", "frutas","escuela","pandemia","edad","familia","apruebeme"};
            string encontrada;

            encontrada = palabras[n];
            return encontrada;
        }










        static char[] GenerarEspacios(string palabra)
        {
            char[] longitud = palabra.ToCharArray();

            //Se colocan los guiones bajos donde ira la palabra
            for (int a = 0; a < palabra.Length; a++)
                longitud[a] = '_';

            return longitud;
        }
        static void ImprimirEspacios(char[] longitud)
        {
            Console.WriteLine();

            for (int i = 0; i < longitud.Length; i++)
                Console.Write(longitud[i] + " ");

            Console.WriteLine();
        }
        static bool CompruebaUna(string letra)
        {
            //Se comprueba si solo se ingreso una palabra 
            bool UnaLetra = false;

            if (letra.Length == 1)
                UnaLetra = true;

            return UnaLetra;
        }













        static void ImprimirFinJuego(string palabra, int intentos, bool gano)
        {
            //Imprimir fin del juego
            if (gano == true)
            {
                muestraaorcado(intentos);
                Console.WriteLine();
                Console.WriteLine("Felicitaciones has ganado!");
                Console.WriteLine();
                Console.WriteLine("La palabra era: {0}", palabra.ToUpper());
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("La palabra era: {0}", palabra.ToUpper());
                Console.ReadKey();
            }
        }









        
        static void muestraaorcado(int intentos)
        {
            //Diseño del ahorcado
            Console.WriteLine("_ _ _");
            if (intentos >= 1)
            {
                Console.SetCursorPosition(0, 0);
                
                Console.WriteLine("_____");
                
            }
            if (intentos >= 2)
            {
                Console.SetCursorPosition(3, 1);
                Console.WriteLine("|");
            }
            if (intentos >= 2)
            {
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("O");
            }
            if (intentos >= 3)
            {
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("/");
            }
            if (intentos >= 3)
            {
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("/T");
            }
            if (intentos >= 4)
            {
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("/T\\");
            }
            if (intentos >= 4)
            {
                Console.SetCursorPosition(2, 4);
                Console.WriteLine("/");
            }
            if (intentos >= 5)
            {
                Console.SetCursorPosition(2, 4);
                Console.WriteLine("/ \\");
            }
            for (int i = 1; i < 6; i++)
            {
               

        }
    }
    }
}




            
        