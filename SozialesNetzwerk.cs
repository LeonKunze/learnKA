namespace learnka
{
	class SozialesNetzwerk
	{
		private List<Person> mitgliederliste = new List<Person>();
		private List<Nachricht> nachrichtenliste = new List<Nachricht>();

		public void hinzufuegenMitglied(Person person)
		{
			mitgliederliste.Add(person);
		}

		public void hinzufuegenNachricht(Nachricht nachricht)
		{
			nachrichtenliste.Add(nachricht);
		}

		public string getAllNachrichten()
		{
			string output = "";
			foreach (var nachricht in nachrichtenliste)
			{
				output += nachricht.getNachricht() + "\n";
			}
			return output;
		}
	}
}
