Console.Write("vedite vashe imea: ");
string usernume = Console.ReadLine();

if(usernume.ToLower() == "Kristina")//aici este o gresala,dar nustiu unde.
{
    Console.WriteLine("moia jena samaia lucishaia");
}
else
{
    Console.Write("privet, ");
    Console.WriteLine(usernume);
}
