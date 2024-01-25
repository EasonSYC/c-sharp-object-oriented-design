namespace CSharpObjectOrientedDesign.Classes;

public class Line
{
	public string Name { get; private set; }

	private List<Station> _stations;

	public List<Station> Stations {
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

	public Line(string name, List<Station> stations)
	{
		_stations = new();
		Name = name;
		Stations = stations;
	}
}

