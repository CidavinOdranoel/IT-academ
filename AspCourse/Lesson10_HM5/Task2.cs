using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_HM5
{
    internal class Task2<T>
    {
        //  Создайте пользовательский список.
        // Реализуйте добавление в список нового объекта так,
        // чтобы после добавления список сортировался по одному из свойств вашего класса.

        // Заполните список начальными данными.
        // Добавьте в ваш список новый элемент.

        // После каждого изменения списка выводите его на экран.

        public T[] Items { get; set; }
        public string Comment { get; set; }

        public Task2(int number, string text, string comment = "No comment") 
        {

        }
    }
}
