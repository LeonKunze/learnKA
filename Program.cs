using learnka;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Das ist ein Soziales Netz: ");

SozialesNetzwerk soziales = new SozialesNetzwerk();
Person personL = new Person("Kunze", "Leon");
Person personN = new Person("Lengfeld", "Nico");
Textnachricht textnachricht1 = new Textnachricht("Hey wie geht es euch", personL);

soziales.hinzufuegenMitglied(new Person());
soziales.hinzufuegenNachricht(textnachricht1);
textnachricht1.hinzufuegenLike();
soziales.hinzufuegenNachricht(new Textnachricht("Mir geht es gut und dir ?", personN));

System.Console.WriteLine(soziales.getAllNachrichten());
