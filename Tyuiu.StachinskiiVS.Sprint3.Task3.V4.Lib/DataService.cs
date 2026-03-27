using tyuiu.cources.programming.interfaces.Sprint3;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.StachinskiiVS.Sprint3.Task3.V4.Lib
{
    public class DataService : ISprint3Task3V4
    {
        public string DeleteCharInString(string value, char item)
        {
            string result = "";
            foreach (char letter in value)
            {
                if (letter != 'j')
                {
                    result += letter;
                }
            }

            return result;
        }
    }
}