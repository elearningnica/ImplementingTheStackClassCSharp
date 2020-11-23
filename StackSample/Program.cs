using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //The program will tell the store user what is the cellphone brand order to be placed in the showroom considering the last arrived to the store as the most advanced phone,
            //therefore, the most likely to be sold

            Stack<string> cellPhone = new Stack<string>();

            //adding values to the stack

            cellPhone.Push("Samsung");
            cellPhone.Push("iPhone");
            cellPhone.Push("Motorola");
            cellPhone.Push("Nokia");
            cellPhone.Push("Sony");

            int cellPhonesToBePlaced = cellPhone.Count;

            for(int i = 0; i<cellPhonesToBePlaced; i++)
            {
                Console.WriteLine("Number of cellphones yet to be placed in the showroom: {0}", cellPhone.Count);
                Console.WriteLine("Next cellphone to be placed in the showroom {0}", cellPhone.Peek());
                cellPhone.Pop(); //removing a item from the stack
                Console.ReadLine();
            }

        }
    }
}
