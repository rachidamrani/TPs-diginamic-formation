// See https://aka.ms/new-console-template for more information

// That does not work !! there is a bug !

DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\Formation Diginamic\TPs-diginamic-formation");

listFolderFiles(directoryInfo, 1);

void listFolderFiles(DirectoryInfo directoryInfo, int level)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{new string('.', level)}{directoryInfo.Name}");

    listFiles(directoryInfo, level);

    foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
    {
        listFiles(directory, level);
        listFolderFiles(directory, ++level);
    }
}


void listFiles(DirectoryInfo directoryInfo, int level)
{
    level++;

    Console.ForegroundColor = ConsoleColor.Blue;

    FileInfo[]? subFiles = directoryInfo.GetFiles();

    foreach (var file in subFiles)
    {
        Console.WriteLine($"{new string('.', level)}{file.Name}");
    }
}





