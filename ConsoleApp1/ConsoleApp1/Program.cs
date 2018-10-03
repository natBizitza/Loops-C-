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


            int number, sum = 0, i=0;


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

            Console.WriteLine("The sum is " + sum);

                Console.ReadLine();
        }
    }
}
