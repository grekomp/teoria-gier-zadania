using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaGier
{
    class Evaluator6
    {
        public float Evaluate(string game)
        {


            return 0;
        }

        public List<string> GetOptions(string game, char player)
        {
            List<string> options = new List<string>();

            for (int i = 0; i < game.Length; i++)
            {
                if (game.ElementAt(i) == player)
                {
                    options.Add(RemoveNthUp(game, i));
                }
            }

            return options;
        }

        public string RemoveNthUp(string game, int n)
        {
            StringBuilder newGameBuilder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                newGameBuilder.Append("" + game.ElementAt(i));
            }

            return newGameBuilder.ToString();
        }
    }
}
