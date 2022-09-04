// https://twitter.com/okyrylchuk/status/1552351944269828099

class MyType { }

class GenericAttribute<T> : Attribute
    where T: MyType 
{
    private T _type;
}

[Generic<MyType>]
class MyClass { }
