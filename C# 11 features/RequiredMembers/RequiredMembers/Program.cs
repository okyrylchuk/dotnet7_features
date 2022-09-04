// https://twitter.com/okyrylchuk/status/1553435991100334080

using System.Diagnostics.CodeAnalysis;

// Initializations with required properties
var person1 = new Person { Name = "Oleg", Surname = "Kyrylchuk" };
Person person2 = new("Oleg", "Kyrylchuk");

// Initializations with missing required properties
var person3 = new Person { Name = "Oleg" };
Person person4 = new();

public class Person
{
    public Person() { }

    [SetsRequiredMembers]
    public Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public required string Surname { get; set; }
}

