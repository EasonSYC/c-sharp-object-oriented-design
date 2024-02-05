namespace CSharpObjectOrientedDesign.Classes
{
	internal class TfLDriver : Driver
	{
		internal enum TfLType
		{
			Overground,
			Underground,
			Tram,
			DLR,
			ElizabethLine
		}

		internal TfLType Type { get; private set; }

		internal TfLDriver(string name, string id, string type) : base(name, id)
		{
			if (Enum.TryParse(type, out TfLType convertedType)){
				Type = convertedType;
			}
			else
			{
				throw new ArgumentException($"Type of driver invalid: {type}");
			}
		}
	}
}

