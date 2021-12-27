using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleCase;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var set = new HashSet<string>();
            
            foreach (var arg in args)
            {
                set.Add(arg);
            }
            
            
            if (set.Count != args.Length)
            {
                "Duplicated name's.".Log();
                return;
            }

            
            if (args.Length < 3)
            {
                "Need more args.".Log();
                return;
            }

            
            if (args.Length % 2 == 0)
            {
                "The number of arguments must be odd.".Log();
                return;
            }

        
            var random = new Random();
            var CompChoice = random.Next(args.Length);
            var CompChoiceString = args[CompChoice];

            var key = KeyGenerator.GenerateKey();
            var hmacValue = HmacExtensions.GenerateHmac(CompChoiceString, key);
            $"HMAC: {hmacValue}".Log();
            "What is ur choice?".Log();

            for (var index = 0; index < args.Length; index++)
            {
                var variant = args[index];
                $"{index + 1} - {variant}".Log();
            }
            
            "0 - exit".Log();
            Console.Write("Enter your move: ");
            var userChoice = int.Parse(Console.ReadLine()) - 1;

            if(userChoice+1==0){return;}

            $"Your move: {args[userChoice]}".Log();

          

            var halfLenght = (args.Length - 1) / 2;
            
            if (CompChoice == userChoice)
            {
                "Draw!".Log();
                key.Log();
                return;
            }

            for (var i = userChoice + 1; i < userChoice + halfLenght; i++)
            {
                var winVariant = i;
                if (winVariant > args.Length)
                {
                    winVariant = -args.Length;
                }

                if (CompChoice == winVariant)
                {
                    "U lose :(".Log();
                    key.Log();
                    return;
                }
            }
            
            "You win!!!".Log();
            key.Log();
        }
    }
}