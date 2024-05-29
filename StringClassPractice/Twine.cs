//This was a helpful exercise, but ultimately a misfire. I was trying to do two things at a time. On the one hand,
//I was trying to reinvent string by using a char[] CharArray.
//On the other hand, I was trying to create all the methods to do things to said CharArray, but also create methods that have parameters and return values.
//I think the two are mutually exclusive?
//So I'm going to create a new class, Cord, that does all the things to a STRING instead of char[] CharArray.
//But as I think about it, I feel like the string class has its cake and eats it too, so I'll have to figure that out sometime.

//Another note, I think this solves my re-entrant issue.
//Another note, will this be a static class? Which means it doesn't need to be instantiated. I'm just calling methods from it.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringClassPractice
{
    public class Twine
    {


        public Twine(char[] twine)
        {
            this.CharArray = twine;
        }

        public char[] CharArray { get; private set; }

        public int Length() => CharArray.Length;

        public void Print() {
            foreach (var character in CharArray) { Console.Write(character); }
            Console.WriteLine("\n");
        }

        public char[] Reverse()
        {
            char[] originalOrder = this.CharArray;

            Console.WriteLine($"originalOrder length is {originalOrder.Length}");

            char[] reverseOrder = new char[originalOrder.Length];
            int index = 0;
            foreach (var i in originalOrder)
            {

                int reverseIndex = originalOrder.Length - index;

                reverseOrder[reverseIndex - 1] = originalOrder[index];
                index++;
            }
            CharArray = reverseOrder;
            return reverseOrder;
        }

        public bool IsPalindrome()
        {
            //char[] lowercased = ToLowerCaseInternal(CharArray);
            //char[] reversed = Reverse(lowercased);


            //return reversed.SequenceEqual(lowercased);
            return true;
        }

        

        internal void Trim(int trimFront, int trimRear)
        {

            Console.WriteLine("Trim not built yet.");
        }

        public void ToLowerCase()
        {
            for (int i = 0; i < CharArray.Length; i++)
            {
                CharArray[i] = char.ToLower(CharArray[i]);
            }            
        }

        internal char[] ToLowerCaseInternal(char[] characters)
        {
            for (int i = 0; i < CharArray.Length; i++)
            {
                characters[i] = char.ToLower(characters[i]);
            }

            return characters;
        }

        public void ToUpperCase()
        {
            for (int i = 0; i < CharArray.Length; i++)
            {
                CharArray[i] = char.ToUpper(CharArray[i]);
            }
        }


    }
}
