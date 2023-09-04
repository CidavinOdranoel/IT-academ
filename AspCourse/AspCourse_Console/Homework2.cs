using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspCourse_Console
{
    
    
    internal class Homework2
    {
        /*
         * 1. Реверс строки
         * 2. Повторяющаяся строка
         * 3. Самое большое и самое маленькое число в строке
         * 4. Определить изограмму
         * 5. Увеличивающиеся повторения в строке
         * 
         */

        #region Task1
        /// <summary>
        /// Возвращает строку в обратном порядке
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseString(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result += str[str.Length-i-1];
            }
            return result;
        }
        #endregion

        #region Task2
        /// <summary>
        /// Повторяет строку n раз. Пустая строка при n=0
        /// </summary>
        /// <param name="n">Количество повторений</param>
        /// <param name="s">Строка для повторения</param>
        /// <returns></returns>
        public static string RepeatString(int n, string s) 
        {
            string reslut = "";
            for(int i = 0; i < n; i++)
            {
                reslut += s;
            }
            return reslut;
        }
        #endregion

        #region Task3

        /// <summary>
        /// Возвращает максимальное и минимальное значение int из строки
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetHighestAndLowestInt (string str)
        {
            string result = "";
            int[] splitedStr = str.Split(' ').Select(int.Parse).ToArray();
            result = splitedStr.Max().ToString() + " " + splitedStr.Min().ToString();            
            return result;
        }
        #endregion

        #region Task4
        /// <summary>
        /// Определяет является ли строка изограммой (нет повторяющихся символов)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsIsogram(string str)
        {
            HashSet<char> charSet = str.ToCharArray().ToHashSet();
            if (str.Length == charSet.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Task5
        /// <summary>
        /// Повторение символов
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RepeatSymbols(string str)
        {
            string result = "";
            char[] strChars = str.ToCharArray();
            int repeatCounter = 1; //сколько раз повторить символ

            for (int i = 0; i < str.Length; i++)
            {
                result += strChars[i].ToString().ToUpper();//Первый символ с верхним регистром

                for (int j = 1; j < repeatCounter; j++)
                {
                    result += strChars[i].ToString().ToLower();
                }
                result += "-";
                repeatCounter++;
            }
            result = result.TrimEnd('-');
            return result;
        }

        #endregion
    }
}
