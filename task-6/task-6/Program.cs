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