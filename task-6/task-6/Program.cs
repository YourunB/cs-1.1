int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
string[] words = { "aPPLE", "ORangE", "cHeRry" };

var numQuery =
    from num in numbers
    where (num % 2) == 0
    select num;

var varWords =
    from word in words
    select new { Upper = word.ToUpper(), Lower = word.ToLower() };