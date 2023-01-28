using PerformanceInEnumerableSample;
var people = GetPeople().ToList();

var count=people.Count();
Console.WriteLine($"People data count: {count}");

foreach (var item in people)
{
    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Age: {item.Age}");
}


IEnumerable<Person> GetPeople()
{
    var lines = File.ReadAllLines("./Person.csv");
    foreach (var item in lines)
    {
        var data = item.Split(',');
        yield return new Person(int.Parse(data[0]), data[1], int.Parse(data[2]));
    }
}
