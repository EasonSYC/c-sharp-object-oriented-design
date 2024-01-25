namespace CSharpObjectOrientedDesign.Classes;

internal class Train
{
    private const int _numberLength = 5;
    private string _number;

    internal string Number
    {
        get
        {
            return _number;
        }
        private set
        {
            if (value.Length == _numberLength && value.All(char.IsDigit))
            {
                _number = Number;
            }
            else
            {
                throw new FormatException($"Format of number incorrect: {value}.");
            }
        }
    }

    private const int _modelLength = 3;
    private string _model;

    internal string Model
    {
        get
        {
            return _model;
        }
        private set
        {
            if (value.Length == _modelLength && value.All(char.IsDigit))
            {
                _model = Model;
            }
            else
            {
                throw new FormatException($"Format of model incorrect: {value}.");
            }
        }
    }


    internal Train(string number, string model)
    {
        _number = "";
        _model = "";
        Number = number;
        Model = model;
    }
}