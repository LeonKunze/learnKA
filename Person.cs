namespace learnka{

	class Person{
		private string nachname;
		private string vorname;

		public Person(){}

		public Person(string nn, string vn){
			this.nachname = nn;
			this.vorname = vn;
		}

		public string getNachname(){
			return this.nachname;
		}

		public string getVorname(){
			return this.vorname;
		}

	}
}
