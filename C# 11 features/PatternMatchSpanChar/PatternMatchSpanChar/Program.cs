// https://twitter.com/okyrylchuk/status/1552017075727630342

ReadOnlySpan<char> str = "Oleg".AsSpan();

if (str is "Oleg")
{
    Console.WriteLine("Hey, Oleg");
}
