using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable para iterar y  el numero que quieremes multiplicar
            //int i = 0, num;

            //Console.WriteLine("INtroduce el numero");
            //num = Convert.ToInt32(Console.ReadLine());

            //while(i < 11)
            //{
            //    Console.WriteLine(num + "x" + i + "=" + (num*i));
            //    // to add value every time iterating the loop
            //    i++;
            //}

            //to type humbers from 0 to 100. We set up i = 0 before as a beginning of the loop

            //while ( i < 101)
            //{
            //    Console.WriteLine("Your numbers is " + i);
            //    i++;
            //}

            // DO WHILE loop (to decrease numbers, for ex) 

            //do
            //{
            //    Console.WriteLine(i);
            //    //We can add more conditions
            //    //Console.WriteLine(i);
            //    i++;
            //}
            //while (i < 101);

            // until negative number
            //int i = 10;

            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //} while (-2 < i);

            // Count back till one negative number

            //while (-2 < i)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            // until negative number with WHILE LOOP
            //int i = 0;

            //do
            //{
            //    Console.WriteLine("Write a number");
            //    i = Convert.ToInt32(Console.ReadLine());
            //} while (i > 0);

            // the same with WHILE

            //
            //int num = 1;

            //while (num > 0 )
            //{
            //    Console.WriteLine("Write a number");
            //    num = Convert.ToInt32(Console.ReadLine());               
            //}
            //// To let the user know that the program stops run cause the number is negative
            //Console.WriteLine("The number is negative");

            // For loop

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // pedir 4 numeros y escribir la sume total con For bucle
            //int num, suma = 0;

            //// u < 4 cause we start to count from 0
            //for (int u = 0; u < 4; u++ )
            //{
            //    Console.WriteLine("Introduce el numero");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    suma = suma + num;
            //}

            //Console.WriteLine("Total: " + suma);

            //Escribe un programa que muestre en pantalla los números del 10 al 20 (incluidos los dos) con una línea vacía entre ellos.

            //for(int x= 10; x < 21; x++)
            //{
            //    // to add a line in between Environment.NewLine or /n

            //    Console.WriteLine(x + Environment.NewLine);
            //}

            ////Escribe un programa que muestre en pantalla los números del 20 al 10 (incluidos los dos) con una línea vacía entre ellos.

            //for (int y = 20; y > 9 ; y--)
            //{
            //    // to add a line in between Environment.NewLine or /n

            //    Console.WriteLine(y + Environment.NewLine);
            //}

            //Escribe un programa que pida 10 valores. Al final mostrar la media de esos valores.
            //int num, average = 0, suma = 0;

            //for (int v = 0; v < 9; v++)
            //{
            //    Console.WriteLine("Introduce el numero");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    suma = suma + num;
            //    average = suma / (suma / num);
            //}

            //Console.WriteLine("The average of your 10 numbers is : " + average);

            // Escribe un programa que pida valores hasta que el usuario introduzca un 0. 
            //Si introduce un valor negativo, mostrar un mensaje diciendo que se ignoran los valores negativos. 
            // Mostrar la suma de los valores introducidos. 


           /* int number, sum = 0;


            do
            {
                Console.WriteLine("Type a number");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 0)
                {
                    Console.WriteLine("You typed zero");
                }
                else if (number > 0)
                {
                    sum = sum + number;
                    Console.WriteLine("The sum of the numbers is " + sum);
                }
                else
                {
                    Console.WriteLine("The program ignores negative numbers.");
                }
            } while (number != 0) ;

            Console.WriteLine("The sum is " + sum); */

            //Escribe un programa que muestre todos los valores pares o impares
            //entre 1 y 100 dependiendo de si el usuario introduce P o I . Si introduce otra cosa, 
            //decir que ese valor no es correcto y pedirle otra vez.

            //string answer = "";

            //Console.WriteLine("Type P o I: ");
            //answer = Console.ReadLine();

            //if (answer!= "P" && answer != "I")
            //{
            //    Console.WriteLine("The value is incorrect. Please, type P o I:");
            //}
            //else if (answer == "P")
            //{
            //    for (int i = 2; i < 100; i = i+2 )
            //    {
            //        Console.WriteLine(i);
            //    }
                    
            //}
            //else
            //{
            //    for (int y = 1; y < 100; y = y + 2)
            //    {
            //        Console.WriteLine(y);
            //    }
            //}

            //// Escribe un programa que pregunte al usuario su edad. Mostrar en pantalla “Feliz cumpleaños” repetido tantas veces como años tenga.

            //int edad;

            //Console.WriteLine("How old are you? Type a number.");
            //edad = Convert.ToInt32(Console.ReadLine());

            //for (int e=1; e <= edad; e++)
            //{
            //    Console.WriteLine("Feliz cumpleaños!");
            //}



            // Pedir al usuario un número. Mostrar en pantalla 
            //         *
            //         **
            //         ***
            //     Con tantas líneas como el número que ha introducido


            //int numero;

            //Console.WriteLine("Type a number:");
            //numero = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= numero; i++)
            //{
            //    for (int j = 1; j <= i+1; j ++)
            //    {
            //        // to be able to place the asterics on one line -> Console.Write();
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("\n");
            //}

            //Escribe un programa que muestre los números de 1 a 12 en una columna. 
            //En la columna de al lado de los números impares mostrar el cuadrado de ese valor y en la de los pares mostrar el cubo.

            for(int k = 1; k <= 12; k++)
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine("\t" + k + " en el cubo  es " + Math.Pow(k, 3) + "\t");
                }
                else
                {
                    Console.Write("\t" + k + " en el cuadrado  es " + Math.Pow(k, 2));
                }
                

            }
            



            Console.ReadLine();
        }
    }
}
