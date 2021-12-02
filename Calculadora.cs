using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
string resp = ""; 
do
  {
} while (resp == "s" || resp == "s");

int valor1 = 0; 
int valor2 = 0; 
int R = 0;




Console.WriteLine("Que operacion desea realizar:");
Console.WriteLine("+ para sumar");
Console.WriteLine("- para restar");
Console.WriteLine("* para multiplicar");
Console.WriteLine("/ para dividir");
Console.Write(" Eliga Una Opcion: "); 
resp = Console.ReadLine();

string eleccion = Convert.ToString(resp);



Console.WriteLine("Ingrese sus variables");
Console.Write("Valor1: ");
valor1 = int.Parse(Console.ReadLine());
Console.Write("Valor2: ");
valor2 = int.Parse(Console.ReadLine());
Console.WriteLine();




switch (eleccion)
          {

case "+":
Console.WriteLine("El resultado de la suma es:");
R = valor1 + valor2;
Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);
break;
case "-":
Console.WriteLine("El resultado de la resta es:");
R = valor1 - valor2;
Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);
break;
case "*": 
Console.WriteLine("El resultado de la multiplicacion es:");
R = valor1 * valor2;
Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);
break;
case "/": 
Console.WriteLine("El resultado de la division es:");
R = valor1 / valor2;
Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);
break;
       }


Console.Write("n¿Desea Continuar? s/n: "); 
resp = Console.ReadLine();



        }
    }
}
