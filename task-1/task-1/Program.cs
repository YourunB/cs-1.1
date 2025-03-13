//----------------------------------------------------------- 1. Создание одномерного массива.
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

class Program
{
    static void Main()
    {
        AClass1 a1 = new AClass1(); //создать объект типа AClass1
        a1.iArray[0] = 100;
        Console.WriteLine(a1.iArray[0]);
    }
}