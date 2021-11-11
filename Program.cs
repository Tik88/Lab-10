using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Corner corner = new Corner();
            Console.WriteLine("Введите число от 0 до 360 градусов");
            corner.Gradus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число от 0 до 60 минут");
            corner.Min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число от 0 до 3600 секунд");
            corner.Sec = Convert.ToInt32(Console.ReadLine());
            corner.ToRadian();
            Console.ReadKey();
        }
    }
    public class Corner
    {
        int gradus;
        int min;
        int sec;

        public void ToRadian()
        {
            double Rad = (gradus * (Math.PI / 180)) + (min * ((Math.PI) / (180 * 60))) + (sec * ((Math.PI) / (180 * 60 * 60)));
            Console.WriteLine("Угол {0} градусов {1} минут {2} секунд = {3} радиан", gradus, min, sec, Rad);
        }

        public int Gradus
        {
            set
            {
                if (value >= 0 && value <= 360)
                    gradus = value;
                else
                    Console.WriteLine("Ошибка диапазона в градусах!");
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value <= 60)
                    min = value;
                else
                    Console.WriteLine("Ошибка диапазона в минутах!");
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value <= 3600)
                    sec = value;
                else
                    Console.WriteLine("Ошибка диапазона в секундах!");
            }
            get
            {
                return sec;
            }
        }

    }
}
