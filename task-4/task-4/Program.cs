static void InArray<T>(T[] i) // так будет работать любой массив
{
    foreach (var item in i)
    {
        if (item != null)
        {
            Console.WriteLine(item);
        }
    }
}

var а = new[] { 1, 10, 100, 1000 };
var c = new[] { "string1", null, "string2" };

InArray(а);
InArray(c);