public interface FileIO
{
    string ReadAllText(string path);
    Unit WriteAllText(string path, string text);
}