// https://twitter.com/okyrylchuk/status/1528818918403493889

// switch expression in string interpolation
int month = 5;
string season = $"The season is {month switch
{
    1 or 2 or 12 => "winter",
    > 2 and < 6 => "spring",
    > 5 and < 9 => "summer",
    > 8 and < 12 => "autumn",
    _ => "unknown. Wrong month number",
}}.";

Console.WriteLine(season);
// The season is spring.

// LINQ query in string interpolation
int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
string message = $"The reversed even values of {nameof(numbers)} are {string.Join(", ", numbers.Where(n => n % 2 == 0)
                             .Reverse())}.";

Console.WriteLine(message);
// The reversed even values of numbers are 6, 4, 2.

