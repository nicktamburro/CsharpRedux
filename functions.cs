//basic function structure:
<visibility> <return type> <name>(<parameters>)
{
    <function code>
}

//call a function just like JS
RockIt();

//it LOOKS like they like to have the curly braces start on the next line
public void RockIt()
{
    Console.WriteLine("Rock and roll all night and party every day.");
}
//visibility (public, here) is optional... default is private
//defined as void, because it has no return

//here's one that takes parameters
public int AddNumbers(int number1, int number2)
{
    int result = number1 + number2;
    return resule;
}
//remember the function is defined as int, becuause it returns an int