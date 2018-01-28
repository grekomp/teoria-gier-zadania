using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaGier
{
    class Program
    {
        static void Main(string[] args)
        {

            string game = "Haba baba";

            Evaluator6 evaluator6 = new Evaluator6();
            Console.WriteLine(evaluator6.RemoveNthUp(game, 4));

            Console.ReadLine();
        }
    }
}
