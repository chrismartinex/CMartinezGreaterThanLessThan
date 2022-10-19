// //Chris Martinez 
//  10/18/22
// Greater Than or Less Than, #4 Mini Challenge REVAMPT
// The new edition to this program consist of the IF Statements to Compare different numbers, from the user input. The program will check and validate whether or not the numbers compared are equal, less than, or greater than. All while at same time, allow the user to exit the program or re play as he or she wishes to!


bool looper = true;
string repeat = "";

while (looper == true)
{
Console.Clear();
Console.WriteLine("Please enter a <><><><><><><>FIRST NUMBER!<><><><><><><>");
string number1 = Console.ReadLine();
Console.WriteLine("Now please enter a <><><><>SECOND NUMBER<><><><><><>");
string number2 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);
int num2 = Convert.ToInt32(number2);
Console.WriteLine("");

//FIRST NUMBER against SECOND NUMBER check
if (num1 > num2){
Console.WriteLine(num1 + "<>><<> is greater than <>><<> "+ num2);
}
if (num1 < num2){
    Console.WriteLine(num1 + "<>><<> is lesser than <>><<> " + num2);
}
if (num1 == num2){
    Console.WriteLine(num1 + " <>><<> is equal to <>><<> " + num2);
}

//SECOND NUMBER against FIRST NUMBER check
if (num2 < num1){
Console.WriteLine(num2 + " is lesser than "+ num1);
}
if (num2 > num1){
    Console.WriteLine(num2 + " is greater than " + num1);
}
Console.WriteLine();
while (looper == true)
{
Console.WriteLine("Wanna TRY again? \"yes\" or \"no\"?");
repeat = Console.ReadLine();
repeat = repeat.ToLower();
if (repeat == "yes")
{
looper = false;
}
if (repeat == "no")
{
looper = false;
}
Console.WriteLine("<><><><><><><><>THE END!<><><><><><><><>");
}
if (repeat == "yes")
{
looper = true;
}
}