namespace CSharpObjectOrientedDesign.Classes;

internal class Stop
{
    internal Station Station { get; private set; }
    internal bool Passing { get; private set; }
    internal TimeOnly? ArrivalTime { get; private set; }
    internal TimeOnly? DepartureTime { get; private set; }

    internal Stop(Station station, bool passing, TimeOnly arrivalTime, TimeOnly departureTime)
    {
        Station = station;
        Passing = passing;
        ArrivalTime = arrivalTime;
        DepartureTime = departureTime;
    }
}