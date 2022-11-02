using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaInzynierka.Zapisywanie
{
    internal class Component
    {
        private static int userCode;
        private static Dictionary<string, char> userResults;
        public int UserCode
        {
            get => userCode;
            set => userCode = value >= 0 && value <= 100
                ? value
                : throw new ArgumentOutOfRangeException("Podano niewłaściwy kod użytkownika. Kod powinien być z przedziału 1 - 100.");
        }

        public Dictionary<string, char> UserResults
        {
            get => userResults;
            set => userResults = value;
        }

        public Component(int _userCode)
        {
            UserCode = _userCode;
            UserResults = new Dictionary<string, char>();
            UserResults.Clear();
        }

        public void StoreResults(string question, char answer)
        {
            if(UserResults.ContainsKey(question))
            {
                UserResults[question] = answer;
            }
            else
            {
                UserResults.Add(question, answer);
            }
        }
    }
}
