//Samuel Laguna
//10-19-22
//We are to recreated mini challenge 1. We need to get the same output
//but using a diffrent method.
//Peer reivew: 

Console.Clear();
bool TryAgain = true;
bool end = false;

while(TryAgain){
Console.WriteLine("Hello What is your name?");

string myNAme = "";
bool mn = false;

while(!mn){
    myNAme = Console.ReadLine();
Console.WriteLine("My name is " + myNAme);
bool checkmn = myNAme.All(Char.IsLetter);
if(checkmn == false)
{
    Console.WriteLine("This is not a word");
    mn = false;
}else
{
    mn = true;
}

}
Console.WriteLine("Would you like to try again [TryAgain to restart] [end to end]");
   string ending = Console.ReadLine();
     if(ending == "end")
    {
        TryAgain = false;
        end = true;
    }
}