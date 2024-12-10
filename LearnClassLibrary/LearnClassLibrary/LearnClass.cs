using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassLibrary
{
    public class LearnClass
    {
        public int TimeInSeconds(int a, int b)
        {
            return a * 3600 + b * 60;
        }

        public (int hours, int minutes) SecToTime(int totalSec) // Перевод из секунд в минуты, первый два параметра - строго возвращаемые переменные (часы и минуты)
        {
            int hours = totalSec / 3600;
            int minutes = (totalSec % 3600) / 60;
            return (hours, minutes);
        }
    }
}
