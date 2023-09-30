using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_HM4
{
    internal class Task2
    {
        // Используйте StringBuilder для соединения корневых слов.
        // Генерируйте имя, состоящее из 3-х корневых слов.
        // Корневые слова не должны повторяться в одном имени.

        List<string> partsOfDefaultName = new List<string>(6) 
        {
            "Ast", "Lor", "Bel", "Tor", "Zel", "Mer"
        };

        public string GetRandomName()
        {
            Random rdm = new Random();
            StringBuilder sb = new StringBuilder();
            HashSet<string> keys = new HashSet<string>();

            while (keys.Count != 3)
            {
                keys.Add(partsOfDefaultName[rdm.Next(0, 6)]);
            }

            foreach (var item in keys)
            {
                sb.Append(item);
            }
            return sb.ToString();
        }
        
    }
}
