namespace Utils;
public class FileProvider{
    public static Task<string[]> ReadAllLines(CancellationToken cancellationToken){
       return File.ReadAllLinesAsync("./input.txt", cancellationToken);
    }
}