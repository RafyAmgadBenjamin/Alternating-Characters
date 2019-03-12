using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternating_Characters
{
    class Program
    {
        static int alternatingCharacters(string s)
        {
            int deletion = 0;
            for (int i = 0; i < s.Length-1; i++)
            {

                if(s[i]=='A'&& s[i+1] == 'A')
                {
                    deletion++;
                }
                else if (s[i] == 'B' && s[i + 1] == 'B')
                {
                    deletion++;
                }

            }
            return deletion;

        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = alternatingCharacters(s);

                Console.WriteLine(result);
            }

            //textWriter.Flush();
           // textWriter.Close();
        }
    }
}

