// https://twitter.com/okyrylchuk/status/1553081565613367298

public class MyAttr : Attribute
{
    private readonly string _paramName;
    public MyAttr(string paramName)
    {
        _paramName = paramName;
    }
}


public class MyClass
{
    [MyAttr(nameof(param))]
    public void Method(int param, [MyAttr(nameof(param))] int anotherParam)
    { }
}

