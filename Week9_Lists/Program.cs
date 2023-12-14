


string folderPath = @"C:\Users\\Dell\source\repos\DATA_WEEK_8";
string fileName = "christmasList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myChristmasList = new List<string>();

if (File.Exists(filePath))
{
    myChristmasList = GetItemsFromUser();
    File.WriteAllLines(filePath, myChristmasList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created.");
    myChristmasList = GetItemsFromUser();
    File.WriteAllLines(filePath, myChristmasList);
}

static List<string> GetItemsFromUser()
{
    List<string> userList = new List<string>();
    while (true)
    {
        Console.WriteLine("Add an item (add)/ Exit (exit)");
        string userChoise = Console.ReadLine();
        
        if (userChoise == "add")
        {
            Console.WriteLine("Enter an item:");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }
    }
    return userList;
}

static void ShowItemsFromList (List<string> someList)
{
    Console.Clear();

    int listLenght = someList.Count;
    Console.WriteLine($"You have added {listLenght} items to your ChristmasList list.");

    int i = 1;
    foreach (string item in someList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}
