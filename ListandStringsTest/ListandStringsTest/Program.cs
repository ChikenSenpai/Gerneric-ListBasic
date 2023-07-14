
string itemInput;

List<string> shopList = new List<string>();

Console.WriteLine("Enter x to cancel");
do
{
    itemInput = Console.ReadLine().ToLower();
    if(itemInput == "x")
    {

    }
    else
    {
        //capitalizes the first letter of a string (Substring adds the rest of the string to the capital letter)
        itemInput = char.ToUpper(itemInput[0]) + itemInput.Substring(1); 
        Console.WriteLine($"{itemInput} was added to List");
        shopList.Add(itemInput);
    }  

}while (itemInput != "x");


foreach(var item in shopList) 
{ 
    Console.WriteLine(item);
}

