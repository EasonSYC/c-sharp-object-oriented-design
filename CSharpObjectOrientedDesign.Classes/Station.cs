namespace CSharpObjectOrientedDesign.Classes;

internal class Station
{
    internal string Name { get; private set; }

    internal Station(string name)
    {
        Name = name;
    }
}