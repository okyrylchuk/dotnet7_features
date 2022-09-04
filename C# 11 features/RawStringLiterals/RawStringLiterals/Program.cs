// https://twitter.com/okyrylchuk/status/1527003752187707395

string name = "Oleg", surname = "Kyrylchuk";

string jsonString = 
    $$"""
    {
        "Name": {{name}},
        "Surname": {{surname}}
    }
    """;

Console.WriteLine(jsonString);
