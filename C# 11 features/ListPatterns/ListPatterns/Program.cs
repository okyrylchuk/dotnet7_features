// https://twitter.com/okyrylchuk/status/1527738927838371846

var numbers = new[] { 1, 2, 3, 4 };

// List and constant patterns
Console.WriteLine(numbers is [1, 2, 3, 4]); // True
Console.WriteLine(numbers is [1, 2, 4]);    // False

// List and discard patterns
Console.WriteLine(numbers is [_, 2, _, 4]); // True
Console.WriteLine(numbers is [.., 3, _]);   // True

// List and logical patterns
Console.WriteLine(numbers is [_, >= 2, _, _]); // True

var persons = new Person[]
{
        new Person("John", "Smith", 30),
        new Person("Oleg", "Kyrylchuk", 29),
};

var isSecondPersonMe = (Person[] p) => p switch
{
    [_, { Surname: "Kyrylchuk" } and { Age: < 30 }] => true,
    _ => false
};

Console.WriteLine(isSecondPersonMe(persons)); // True

record class Person(string Name, string Surname, int Age);

