namespace CSharpObjectOrientedDesign.Classes;

internal class Timetable
{
	internal Line Line { get; private set; }
	internal Train Train { get; private set; }
	internal Driver Driver { get; private set; }
	internal List<Stop> Stops { get; private set; }

	internal Timetable(Line line, Train train, Driver driver, List<Stop> stops)
	{
		Line = line;
		Train = train;
		Driver = driver;
		Stops = stops;
	}
}