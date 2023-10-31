using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lesson13
{
    internal class Plane
    {
        const int maxSpeed = 100;
        const int maxHeight = 100;
        int _height;
        int _speed;

        private void SpeedUp(int acceleration)
        {
            if (acceleration < 0) throw new NotImplementedException();
            int speedToAdd = acceleration;
            while (speedToAdd > 0)
            {
                if (_speed >= maxSpeed) break;
                speedToAdd--;
                _speed++;
            }
            Console.WriteLine($"Скорость увеличина на {acceleration-speedToAdd}");
            if (_speed == maxSpeed) Console.WriteLine("Максимальная скорость достигнута");
        }

        private void SlowDown(int acceleration)
        {
            if (acceleration < 0) throw new NotImplementedException();
            int speedToRemove = acceleration;
            while (speedToRemove > 0)
            {
                if (_speed <= 0) break;
                speedToRemove--;
                _speed--;
            }
            Console.WriteLine($"Скорость уменьшена на {acceleration-speedToRemove}");
            if (_speed == 0) Console.WriteLine("Самолёт остановлен");

        }

        public void GetUp(int height)
        {
            if (_speed <= 10)
            {
                Console.WriteLine("Не хватает скорости для наборар высоты");
                return;
            }
            int heightToAdd = height;
            while (heightToAdd > 0)
            {
                if (_height >= maxHeight) break;                
                heightToAdd--;
                _height++;
            }            
        }
    }
}
