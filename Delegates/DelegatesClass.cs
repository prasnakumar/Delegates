using System;


namespace Delegates
{
    public delegate string InputDelegate();

   public  class DelegatesClass
    {
       
        public  string OnNumber()
        {
          return "OnNumber";
           
        }
        public  string OnWord()
        {
           return "OnWord";
        }
        public  string OnJunk()
        {
            return "OnJunk";
        }

    }
}
