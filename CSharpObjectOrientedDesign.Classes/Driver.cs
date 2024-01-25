namespace CSharpObjectOrientedDesign.Classes;

public class Driver
{
    private string _firstName;
    private string _lastName;

    public string Name
    {
        get
        {
            return _firstName + " " + _lastName;
        }
        private set
        {
            List<string> strList = new(value.Split(' '));
            if(strList.Count == 2 && strList[0].All(char.IsLetter) && strList[1].All(char.IsLetter))
            {
                _firstName = strList[0];
                _lastName = strList[1];
            }
            else
            {
                throw new FormatException($"Format of name incorrect: {value}.");
            }
        }
    }

    private const int _idLength = 6;
    private string _id;

    public string ID
    {
        get
        {
            return _id;
        }
        private set
        {
            if(value.All(char.IsDigit) && value.Length == _idLength)
            {
                _id = value;
            }
            else
            {
                throw new FormatException($"Format of ID incorrect: {value}.");
            }
        }
    }

    public Driver(string name, string id)
    {
        _firstName = "";
        _lastName = "";
        _id = "";
        Name = name;
        ID = id;
    }
}

