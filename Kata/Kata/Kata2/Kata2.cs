using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kata.Kata2
{
    internal class Kata2
    {
        public static int DeadAnts(string str)
        {
            if (str == null)
            {
                return 0;
            }

            int Head = 0;
            int Body = 0;
            int Tail = 0;

            var saveTheAnts = Regex.Split(str, "ant");
            foreach (var body in saveTheAnts)
            {
                for (int i = 0; i < body.Length; i++)
                {
                    if (body[i] == 'a')
                    {
                        Head++;
                    }
                    else if (body[i] == 'n')
                    {
                        Body++;
                    }
                    else if (body[i] == 't')
                    {
                        Tail++;
                    }
                }
            }

            return Math.Max(Head, Math.Max(Body, Tail));

        }
    }
}
