using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Prime.Services
{
    public class PrimeService
    {

        public bool IsNumber(string input)
        {
            Regex rx = new Regex("^[0-9-]");
            MatchCollection matches = rx.Matches(input);

            if (matches.Count > 0)
            {
                return true;
            }

            return false;
        }

        public bool IsLetter(string input)
        {
            Regex rx = new Regex("^[a-zA-Z ]+$");
            MatchCollection matches = rx.Matches(input);

            if(matches.Count > 0)
            {
                return true;
            }

            return false;
        }

        public bool ValidSsn(string input)
        {
            if (input == null)
                return false;

            if (input.Length != 11)
                return false;

            if (!IsNumber(input))
                return false;

            if (input[3] != '-' || input[6] != '-')
                return false;

            return true;
        }

    }
}