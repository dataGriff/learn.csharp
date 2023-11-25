// Random random = new Random();
// int coinFlip = random.Next(0,2);
// string coinSide = coinFlip == 1 ? "Heads" : "Tails";
// Console.WriteLine(coinSide);

string permission = "jim";
int level = 56;
string message = "You do not have sufficient privileges.";

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        message = "Welcome, Super Admin user.";
    }
    else
    {
        message = "Welcome, Admin user.";
    }
}
if (permission.Contains("Manager"))
{
    if (level > 20)
    {
        message = "Welcome, Super Manager user.";
    }

}

Console.WriteLine(message);

