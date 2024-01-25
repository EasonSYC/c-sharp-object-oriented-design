namespace CSharpObjectOrientedDesign.Classes;

public class Timetable
{
	public Line Line { get; private set; }
	public Train Train { get; private set; }
	public Driver Driver { get; private set; }
	public List<Stop> Stops { get; private set; }

	public Timetable(Line line, Train train, Driver driver, List<Stop> stops)
	{
		Line = line;
		Train = train;
		Driver = driver;
		Stops = stops;
	}
}

