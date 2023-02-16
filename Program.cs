using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> IPs = new List<string> { };

            string input = Console.ReadLine();
            int result = 0;

            while (input != "")
            {
                IPs.Add(input);
                input = Console.ReadLine();
            }

            int[] values = new int[IPs.Count];

            for(int i = 0; i < IPs.Count; i++)
            {
                values[i] = Convert.ToInt32(IPs[i].Substring(IPs[i].IndexOf('/') + 1));
            }

            foreach(int value in values)
            {                
                result = result + Convert.ToInt32(Math.Pow(2, 32 - value));
            }

            Console.WriteLine("Ответ : " + result);

            Console.ReadLine();                       
        }
    }
}
