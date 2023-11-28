namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads the path to a file and subtracts the file name and its extension

            // може да се реши и по този начин - с методите Get
            // string filePath = Console.ReadLine();
            // Console.WriteLine($"File name: {Path.GetFileNameWithoutExtension(filePath)}");
            //  Console.WriteLine($"File extension: {Path.GetExtension(filePath).Replace(".","")}"); 
            // заменя точката с празен стринг
            string text = Console.ReadLine();
            int templateIndex = text.LastIndexOf('\\');// търсим последния индекс "\" но трябва да изпишем \\
            int extensionIndex = text.LastIndexOf('.');

            int lenght = extensionIndex - templateIndex;
            string tempate = text.Substring(templateIndex + 1, lenght-1);
            string extension = text.Substring(extensionIndex + 1);


            Console.WriteLine($"File name: {tempate}");
            Console.WriteLine($"File extension: {extension}");
            
        }
    }
}
