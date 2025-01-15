namespace learnka{
	
	abstract class Nachricht {

		private int likes;
		private Person absender;
		
		public Nachricht(){

		}
		public Nachricht(Person absender){
			this.absender = absender;
		}

		public void hinzufuegenLike(){
			this.likes++;
		}

		public abstract string getNachricht();
	}
}
