using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationDictionary
{
    class Program
    {
        static void Permutation(int[] dictionary, int[] places, int position = 0)
        {
            if(places.Length == position)
            {
                //Print permutation
                for (int i = 0; i < places.Length; i++)
                    Console.Write(places[i]);
                Console.WriteLine();
                return;
            }
            
            //insert from dictionary
            for(int i = 0; i < dictionary.Length; i++)
            {
                places[position] = dictionary[i];
                Permutation(dictionary, places, position + 1);
            }
        }

        static void Main(string[] args)
        {
            int[] dic = new int[] { 1, 2, 3};
            Permutation(dic, new int[3]);
        }
    }
}
