using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numreverse
{
    public class NumReversing
    {
     
        public int Reverseint(string input = null)
        {
            /*
             * 
             * Given an integer, return an integer that is reverse ordering the numbers 
                // 500 = 5 
                // -56 = -65 
                // -90 = -9 
                // 91  = 19 
             * 
             */
            String finalNum = "";
            String num;
            if (input != null)
            {
                 num = input;
            }
            else
            {
                 num = Console.ReadLine();
            }
          
            if (num != null)
            {
                char[] numArray = num.ToCharArray();
                //Console.WriteLine(numArray);
                var numArrayReversed = numArray.Reverse();

                foreach (var oneNum in numArrayReversed)
                {

                    finalNum += oneNum.ToString();

                }
                Console.WriteLine(int.Parse(finalNum));



            }
            return int.Parse(finalNum);



        }
    }
}


