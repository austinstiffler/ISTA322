
namespace Indexers
{
	struct PhoneNumber
	{
        private string number;

		public PhoneNumber(string text)
		{
			number = text;
		}

		public string Text
		{
			get { return number; }
		}

		public override int GetHashCode() => number.GetHashCode();

		public override bool Equals(object other) => (other is PhoneNumber) && Equals((PhoneNumber)other);
		
		public bool Equals(PhoneNumber other) => number == other.number;
	}
}
