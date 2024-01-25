namespace CSharpObjectOrientedDesign.Classes;

public class Train
{
	private const int _numberLength = 5;
	private string _number;

	public string Number
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

	public string Model
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


	public Train(string number, string model)
	{
		_number = "";
		_model = "";
		Number = number;
		Model = model;
	}
}

