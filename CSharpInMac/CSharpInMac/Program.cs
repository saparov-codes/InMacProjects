namespace CSharpInMac;

class Program
{
    static void Main(string[] args)
    {
        var filePath = "../../../example.json";
        if(File.Exists(filePath) is false)
        {
            File.WriteAllText(filePath, "[]");
        }

    }
}

