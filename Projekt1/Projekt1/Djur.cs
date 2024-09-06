/* Skapa en basklass Djur med en virtuell metod Ljud. Skapa sedan två subklasser Hund 
 och Katt som ärver från Djur och som implementerar metoden Ljud på olika sätt. 
Skriv ett program som visar polymorfism genom att anropa metoden Ljud på objekt av olika typer.*/
class Djur //Basklass
{
    public virtual void Ljud()
    { 
        Console.WriteLine("Djur gör ett ljud.");
    }
}
class Hund : Djur
{
    public override void Ljud()  
    {
        Console.WriteLine("Hunden säger: Voff Voff!");
        }
}
class Katt : Djur
{
    public override void Ljud()                                                                   
    {
        Console.WriteLine("Katten säger: Mjau Mjau!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Hund hund = new Hund();
        Katt katt = new Katt();

        Djur[] djurs = { hund, katt };

        foreach (Djur djur in djurs)
        {
            djur.Ljud();
        }
        Console.ReadKey();
    }
  
}