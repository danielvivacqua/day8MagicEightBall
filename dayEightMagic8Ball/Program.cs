using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayEightMagic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            string playAgain = "N";
            string[] responses = { "Honestly, it doesn't look good.", "You know what? Let's hope so!", "Eek, try again!",
                                    "I think you should be optimistic.", "What? I don't even get what you're asking!", "Sure, why not?" };
            var max = responses.Length;
            Random random = new Random(); //instantiating a random object

            do
            {
                Console.WriteLine("Ask me a question");
                Console.ReadLine();
                var selectedNum = random.Next(max);
                Console.WriteLine(responses[selectedNum]);
                Console.WriteLine("Do you want to play again: Y or N?");
                playAgain = Console.ReadLine();
                
            } while (playAgain == "Y");
         }

            
        }
    }
