using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
   public static  class Condition
    {

        public static object  LoopCondition(string word, Delegate OnNumber, Delegate OnWord, Delegate OnJunk)
        {
            bool countNumber = false;
            bool countWord = false;
            bool countJunk = false;

            foreach (var i in word)
            {
                if (Char.IsNumber(i))
                {
                    countNumber = true;

                }
                else if (Char.IsLetter(i))
                {
                    countWord = true;

                }
                else
                {
                    countJunk = true;
                }

            }
            string check = checkcondition(countJunk, countNumber, countWord);
           var value= check == "JUNK" ? OnJunk : check == "WORD" ? OnWord : OnNumber;
          
            return value.DynamicInvoke();;

        }
        public static string checkcondition(bool countJunk, bool countNumber, bool countWord)
        {
            if (countJunk)
            {
                return "JUNK";
            }
            else if (countWord || countNumber)
            {

               var value= countNumber&&countWord? "WORD" : countWord ?  "WORD" :  "NUMBER";
                return value;
               
            }
            else
            {
                return "JUNK";
            }

        }
    }
}
