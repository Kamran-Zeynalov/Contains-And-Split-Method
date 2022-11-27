using System.Collections;
using System.Globalization;
using System.Linq;

namespace Extension_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Contains method.
            //Console.WriteLine("Bir cumle daxil edin:");
            //string sentence = Console.ReadLine();
            //Console.WriteLine("Neticesi:");
            //string search = Console.ReadLine();

            //Console.WriteLine(sentence.customContains(search));
            #endregion


            string sentence = "Kamran codede oxuyur";

            foreach (var item in sentence.CustomSplit(';'))
            {
                Console.WriteLine(item);
            }
        }
    }
}
