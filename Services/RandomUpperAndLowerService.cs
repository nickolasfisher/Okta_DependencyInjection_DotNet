using System;
using System.Collections.Generic;

namespace OktaDependencyInjection.Services
{
    public class RandomUpperAndLowerService : Interfaces.IRandomUpperAndLowerService
    {
        public string RandomizeString(string input)
        {
            List<char> chars = new();
            var rand = new Random();

            foreach (var c in input.ToCharArray())
            {
                var next = rand.Next(0, 2);
                chars.Add(next == 0 ? char.ToUpper(c) : char.ToLower(c));
            }

            return new string(chars.ToArray());
        }
    }
}