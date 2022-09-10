using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowStore
{
    public class Validator
    {
        public static bool isValidLength(string str, int min, int max)
        {
            if (str.Length < min || str.Length > max)
            {
                return false;
            }
            return true;
        }
        public static bool isValidPassword(string password)
        {
            bool result = true;
            for (int i = 0; i < password.Length; i++)
            {
                if (!(Char.IsDigit(password[i]) || password[i] >= 'a' && password[i] <= 'z' 
                    || password[i] >= 'A' && password[i] <= 'Z' || password[i] == '_'))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public static bool isValidLogin(string login)
        {
            bool result = true;

            for (int i = 0; i < login.Length; i++)
            {
                if (!(login[i] >= 'a' && login[i] <= 'z' || login[i] >= 'A' && login[i] <= 'Z'))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public static bool isEmpty(string str)
        {
            return str.Length == 0;
        }

        public static bool isSamePasswords(string password, string repeatPassword)
        {
            bool result = true;
            if(password != repeatPassword)
                result = false;
               
            return result;
        }

        public static bool isValidLoginAndPassword(string login, string password)
        {
            return isValidLogin(login) & isValidPassword(password);
        }
        
        public static bool isRussianSymbolsString(string testString)
        {

            if (isEmpty(testString))
                return false;
            else
            {
                for (int i = 0; i < testString.Length; i++)
                {
                    if (!(testString[i] >= 'а' && testString[i] <= 'я' || testString[i] >= 'А' && testString[i] <= 'Я'
                        || testString[i] == ' '))
                        return false;
                }
            }

            return true;
        }

        public static bool checkForDigits(string str)
        {
            for (int i = 0; i < str.Length; i++)
             {
                 if (str == "" || !Char.IsDigit(str[i]))
                     return true;
             }

             return false;
           
        }
        public static bool checkForNumber(string str)
        {
            string[] numbers = str.Split(',');
            foreach (string number in numbers)
            {
                if (checkForDigits(number))
                {
                    return false;
                }
            }
            return true;

        }

    }
}
