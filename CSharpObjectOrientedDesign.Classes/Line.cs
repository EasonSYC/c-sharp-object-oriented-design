namespace CSharpObjectOrientedDesign.Classes;

internal class Line
{
    internal string Name { get; private set; }

    private List<Station> _stations;

    internal List<Station> Stations
    {
        get
        {
            return _stations;
        }
        private set
        {
            if (value.Count == value.Distinct().Count())
            {
                _stations = value;
            }
            else
            {
                throw new FormatException("Format of stations incorrect, contains duplicates.");
            }
        }
    }

    internal Line(string name, List<Station> stations)
    {
        _stations = new();
        Name = name;
        Stations = stations;
    }
}