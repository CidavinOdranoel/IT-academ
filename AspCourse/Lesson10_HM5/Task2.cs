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




        // Массив автоматически сортирует данные.
        // Имеется возможность отключить автосортировку
        // Так же можно оставить комментарий к массиву

        private bool _autoSort;
        private List<T> _items;
        public List<T> Items 
        {
            get { return this._items; }
            set 
            { 
                this._items = value;
                if (_autoSort) _items.Sort();
            } 
        }
        public string Comment { get; set; }

        public Task2(T[] items, string comment = "No comment", bool autoSort = true) 
        {
            _autoSort = autoSort;
            _items = new List<T>();
            foreach (var e in items)
            {
                Items.Add(e);
            }
            Comment = comment;
            if (_autoSort) _items.Sort();
        }
        public Task2(T item, string comment = "No comment", bool autoSort = true)
        {
            _autoSort = autoSort;          
            _items = new List<T>();
            Items.Add(item);            
            Comment = comment;
        }
        /// <summary>
        /// Autosort
        /// </summary>
        /// <param name="auto"></param>
        public void AutoSort(bool auto) { _autoSort = auto; }
        /// <summary>
        /// Auttosort switch
        /// </summary>
        public void AutoSort() { _autoSort = !_autoSort; }

        public void Add(T item)
        {
            Items.Add(item);
        }

        /// <summary>
        /// [item1,item2,item3... - comment]
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendJoin(',',Items);            
            sb.Append(" - ");
            sb.Append(Comment);
            return sb.ToString();
        }
    }
}
