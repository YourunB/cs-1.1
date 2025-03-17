static void InArray<T>(T[] i) // так будет работать любой массив
{
    Console.WriteLine(i.Length);
}

var а = new[] { 1, 10, 100, 1000 };
var c = new[] { "string1", null, "string2" };

InArray(а);
InArray(c);