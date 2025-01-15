namespace learnka
{
	class Textnachricht : Nachricht
	{
		private string nachricht;

		public Textnachricht():base()
		{
		}

		public Textnachricht(string nachricht, Person absender): base(absender)
		{
			this.nachricht = nachricht;
		}

		public override string getNachricht()
		{
			return this.nachricht;
		}


	}
}
