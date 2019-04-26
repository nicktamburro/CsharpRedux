//default Parameters in C# are "by value" 
//not "by reference"
//that means when we pass a var to a function, we're sending a copy of it,
//rather than a reference to it

//also you can change it inside the function, without changing the original

//THIS WON'T WORK:
static void Main(string[] args)
{
    int number = 20;
    AddFive(number);
    Console.WriteLine(number);
    Console.ReadKey();
}
//because the number is never carried out of this function, 
//it returns void, remember

static void AddFive(int number)
{
    number = number + 5;
}

//SO INSTEAD DO THIS:
static void Main(string[] args)
{
    int number = 20;
    AddFive(ref number);
    Console.WriteLine(number);
    Console.ReadKey();
    //what is ReadKey?
}

static void AddFive(ref int number)
{
    number = number + 5;
}
//so it wasn't because of void, it was that we needed to add ref

//okay read more about ref