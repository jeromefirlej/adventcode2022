using System.Text.RegularExpressions;
using Utils;
var line = await FileProvider.ReadText(default(CancellationToken));
var skip = 0;
var index = 0;
while (true)
{
    var buffer = line.Skip(skip).Take(4).ToArray();
    if (buffer.Distinct().Count() == 4)
    {
        index = 4+skip;
        break;
    }
    skip++;
}

Console.WriteLine(index);

while (true)
{
    var buffer = line.Skip(skip).Take(14).ToArray();
    if (buffer.Distinct().Count() == 14)
    {
        index = 14+skip;
        break;
    }
    skip++;
}

Console.WriteLine(index);