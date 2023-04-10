string rootPath = @"D:\Books";

string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
foreach (string dir in dirs)
{
    Console.WriteLine(dir);
}

string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
foreach (string file in files)
{
    Console.WriteLine(file);
    Console.WriteLine(Path.GetFileName(file));
    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
    var info = new FileInfo(file);
    Console.WriteLine(  $"{Path.GetFileName(file)}: {info.Length} bytes");
}

bool directoryExist = Directory.Exists(rootPath);
if (directoryExist)
{
    Console.WriteLine("The directory exist");
}
else
{
    Console.WriteLine("The directory does not exist");
}


string newRootPath = @"D:\from C\tf";
//Directory.CreateDirectory(newRootPath);
//Console.WriteLine("The directory created");

foreach (var file in files)
{
    //File.Copy(file, $"{newRootPath}\\{Path.GetFileName(file)}");
    //File.Move(file, $"{newRootPath}\\{Path.GetFileName(file)}");
}
