using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_1_Satya
{
    class Amount
    {
        int amount = 1000;
        float interest = 0.05F;
        int total;
        int yeartotal;
        public int Total() 
        {
           return total = Convert.ToInt32(amount * interest);
        }
        public int EndOfYears()
        {
            return yeartotal = Convert.ToInt32(total * interest);
             Console.Write(yeartotal);
        }
    }

    internal class Program3
    {
        static void Main()
        {
            try
            {
                Amount amount = new Amount();
                amount.Total();
                Console.WriteLine("Your end of year ammount is:");
                amount.EndOfYears();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
