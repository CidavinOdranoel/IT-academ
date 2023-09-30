using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_HM4
{
    internal class Task3
    {
        /*
         Вы разрабатываете систему обновления программы, и вам нужно сравнивать версии программы, 
         представленные в виде строк. Версии записываются в формате X.Y.Z, где X, Y и Z — целые числа.

         Ваша задача написать функцию, которая будет принимать две строки с версиями и возвращать:
         1, если первая версия новее второй.
         -1, если вторая версия новее первой.
         0, если версии идентичны.   

            Требования:
         Учитывайте, что число в каждом из сегментов может быть любым целым числом (например, 1.10.1 старше, чем 1.9.9).
         Игнорируйте ведущие нули (т.е. 1.01.1 и 1.1.1 считаются идентичными).
         Не используйте внешние библиотеки.
        */

        public int CompareVersions(string v1, string v2)
        {
            List<int> v1IntNums = VersionToIntList(v1);
            List<int> v2IntNums = VersionToIntList(v2);

            for (int i = 0; i < 3; i++)
            {
                if (v1IntNums[i] > v2IntNums[i])
                {
                    return 1;
                }
                if (v1IntNums[i] < v2IntNums[i])
                {
                    return -1;
                }
            }
            return 0;
        }

        private List<int> VersionToIntList (string v)
        {           
            List<string> v1StringNums = v.Split('.').ToList();
            List<int> result = new List<int>(3);
            foreach (var e in v1StringNums)
            {
                result.Add(Convert.ToInt32(e));
            }
            return result;
        }
    }
}
