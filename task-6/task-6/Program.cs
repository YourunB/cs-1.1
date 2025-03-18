/*
using System.Linq; // использование стандартных операторов запросов, но в данной версии C# она не требуется

//------------------------------------------------------LINQ-запрос-----------------------------------------------------------

int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
string[] words = { "aPPLE", "ORangE", "cHeRry" };

var numQuery =
    from num in numbers
    where (num % 2) == 0
    select num;

foreach (int num in numQuery) { Console.Write("{0,1} ", num); } // вывод четных чисел

var varWords =
    from word in words
    select new { Upper = word.ToUpper(), Lower = word.ToLower() };

foreach (var ul in varWords) { Console.WriteLine("Заглавные буква: {0}, Строчные буквы: {1}", ul.Upper, ul.Lower); }  // вывод слов в верхнем и нижнем регистре

//---------------------------------------------------Лямбда-выражения---------------------------------------------------------

Func<int, int> square = x => x * x; // объявление лямбда-выражения
Console.WriteLine(square(2));

//--------------------------------------------------Методы расширения---------------------------------------------------------

int[] arrints = { 11, 75, 15, 33, 20, 26 };
var nums = arrints.OrderBy(x => x); // сортировка по возростанию, метод OrderBy

foreach (var i in nums) { System.Console.Write(i + " "); }
*/

long?[] longs = { null, 20006L, 50L, 255433101075L };
double? average = longs.Average(); // рвссчитать среднее значение в массиве, метод Average
Console.WriteLine("The average is {0}", average);

string[] strs = { "apple", "mango", "orange", "grape" };
var query = strs.Select((s, index) => new { index, str = s.Substring(0, index) }); // Substring - функция преобразования

foreach (var obj in query)
{
    Console.WriteLine($"{obj}");
}

/*
IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x + x); // метод Range создает набор значений от 1 до 10
// Метод Select последовательно получает каждое значение из созданного набора и выполняет для него операцию x+x
foreach (int num in squares) { Console.WriteLine(num); }
*/