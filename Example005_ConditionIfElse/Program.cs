Console.Write("Enter User Name: ");
string username = Console.ReadLine();

if(username.ToLower() == "oleg")
{
    Console.WriteLine("Yep, this is Oleg");
}
else
{
   Console.Write("Hello, ");
   Console.Write(username);
}