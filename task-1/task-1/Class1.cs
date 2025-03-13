using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------------------- 1. Создание одномерного массива.
namespace task_1
{
    class AClass1
    {
        public int[] iArray; //объявлен массив чисел
        public string[] strArray; //обяъявлен массив строк

        public AClass1() //конструктор
        {
            iArray = new int[10];
            strArray = new string[5];
        }
    }
}
