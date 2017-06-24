namespace ContactList.Enums
{
	public enum BsonType
	{

		Double = 0x01,
		String = 0x02,
		Document = 0x03,
		Array = 0x04,
		Binary = 0x05,
		Undefined = 0x06,
		ObjectId = 0x07,
		Boolean = 0x08,
		DateTime = 0x09,
		Null = 0x0a,
		RegularExpresion = 0x0b,
		Javascript = 0x0d,
		Symbol = 0x0e,
		JavascriptWithScope = 0x0f,
		Int32 = 0x10,
		TimeStamp = 0x11,
		Int64 = 0x12,
		MinKey = 0xff,
		MaxKey = 0x7f

	}
}
