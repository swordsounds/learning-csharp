// Sample for the Environment.GetFolderPath method
using System;

class Sample
{
    public static void Main()
    {
        string OfflineMap1;
        string directoryFolder = Directory.GetCurrentDirectory();
        string fullPath = Path.Combine(directoryFolder, nameof(OfflineMap1));
        System.IO.DirectoryInfo di = new DirectoryInfo(fullPath);
        Console.WriteLine();
        Console.WriteLine("GetFolderPath: {0}",
                     Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        Console.WriteLine(Directory.GetCurrentDirectory());
        Console.WriteLine(Path.Combine(Directory.GetCurrentDirectory(), "OfflineMap/p13/mobile_map.mmap"));
        Console.WriteLine(di);
    }
}
/*
This example produces the following results:

GetFolderPath: C:\WINNT\System32
*/