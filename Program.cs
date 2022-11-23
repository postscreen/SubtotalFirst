// Prepare supported variables
int i = 0;
List<string> incomingBuffer =  new List<string>();

// Ethernal loop for collect incoming strings 
while(true){

    // Message for each session and save data from session also
    Console.Clear();
    Console.WriteLine($"Pleace, insert {i} array item: ");
    var nextString = Console.ReadLine();

    // Check that new string isn't null
    if(nextString != null)
        incomingBuffer.Add(nextString);

    // User can stop or continuous
    Console.Clear();
    Console.WriteLine($"ESC to exit, ANYKEY to continuous ... ");
    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
        break;

    // Counter for easily understanding session' number
    i++;

}

// Clear all previous interface info
Console.Clear();

// Prepare array, clear old data
string[] arrayOfData = incomingBuffer.ToArray();
incomingBuffer.Clear();

// Show items that like to task' conditions
Console.WriteLine($"We are have element that length is <= 3: ");
for(i = 0; i < arrayOfData.Length; i++)
    if(arrayOfData[i].Length <= 3)
        Console.WriteLine(arrayOfData[i]);