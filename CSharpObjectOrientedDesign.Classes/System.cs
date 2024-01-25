namespace CSharpObjectOrientedDesign.Classes;

public class System
{
    private HashSet<Driver> _drivers;
    private HashSet<Line> _lines;
    private HashSet<Train> _trains;
    private HashSet<Timetable> _timetables;

    public System()
    {
        _drivers = new();
        _lines = new();
        _trains = new();
        _timetables = new();
    }

    private void PrintTimetable(Timetable timetable)
    {
        throw new NotImplementedException();
    }

    private HashSet<Timetable> QueryDriver(Driver driver)
    {
        if (!_drivers.Contains(driver))
        {
            throw new ArgumentException($"Driver does not exist: {driver}.");
        }

        HashSet<Timetable> retTimetable = new();

        foreach (var item in _timetables)
        {
            if (item.Driver == driver)
            {
                retTimetable.Add(item);
            }
        }

        return retTimetable;
    }

    private HashSet<Timetable> QueryLine(Line line)
    {
        if (!_lines.Contains(line))
        {
            throw new ArgumentException($"Line does not exist: {line}.");
        }

        HashSet<Timetable> retTimetable = new();

        foreach (var item in _timetables)
        {
            if (item.Line == line)
            {
                retTimetable.Add(item);
            }
        }

        return retTimetable;
    }

    private HashSet<Timetable> QueryTrain(Train train)
    {
        if (!_trains.Contains(train))
        {
            throw new ArgumentException($"Train does not exist: {train}.");
        }

        HashSet<Timetable> retTimetable = new();

        foreach (var item in _timetables)
        {
            if (item.Train == train)
            {
                retTimetable.Add(item);
            }
        }

        return retTimetable;
    }

    private void AddDriver(Driver driver)
    {
        try
        {
            _drivers.Add(driver);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}.");
        }
    }

    private void DelDriver(Driver driver)
    {
        if (QueryDriver(driver) == new HashSet<Timetable>())
        {
            _drivers.Remove(driver);
        }
        else
        {
            throw new ArgumentException($"Driver has timetables: {driver}.");
        }
    }

    private void AddLine(Line line)
    {
        throw new NotImplementedException();
    }

    private void DelLine(Line line)
    {
        throw new NotImplementedException();
    }

    private void AddTrain(Train train)
    {
        throw new NotImplementedException();
    }

    private void DelTrain(Train train)
    {
        throw new NotImplementedException();
    }

    private void AddTimetable(Timetable timetable)
    {
        throw new NotImplementedException();
    }

    private void DelTimetable(Timetable timetable)
    {
        throw new NotImplementedException();
    }

    public void Query()
    {
        throw new NotImplementedException();
    }

    public void Add()
    {
        throw new NotImplementedException();
    }

    public void Del()
    {
        throw new NotImplementedException();
    }
    
}

