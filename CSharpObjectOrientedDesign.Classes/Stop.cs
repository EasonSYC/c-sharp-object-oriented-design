namespace CSharpObjectOrientedDesign.Classes;

public class Stop
{
	public Station Station { get; private set; }
	public bool Passing { get; private set; }
	public TimeOnly? ArrivalTime { get; private set; }
	public TimeOnly? DepartureTime { get; private set; }

	public Stop(Station station, bool passing, TimeOnly arrivalTime, TimeOnly departureTime)
	{
		Station = station;
		Passing = passing;
		ArrivalTime = arrivalTime;
		DepartureTime = departureTime;
	}
}

