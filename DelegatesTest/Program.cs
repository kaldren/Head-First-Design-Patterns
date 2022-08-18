Action<string> test = (name) => { Console.WriteLine(name); };

SomeFunction(test);



void SomeFunction(Action<string> act)
{
    var res = act;
    res("blah");
}