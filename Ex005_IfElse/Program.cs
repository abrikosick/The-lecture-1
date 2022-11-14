Console.Write("Enter username: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hooray, it's MASHA!");

}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}