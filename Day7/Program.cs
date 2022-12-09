using Day7;
using Utils;

var baseNode = new Noeud("/");
Noeud currentrep = baseNode;

void cmd(string line)
{
    var cmds = line.Split(" ");
    if (cmds[1] == "cd")
    {
        if (cmds[2] == "/")
        {
            currentrep = baseNode;
        }
        else
        {
            currentrep = cmds[2] == ".." ? currentrep.Parent ?? baseNode: currentrep.Childs.Find(n => n.Id == cmds[2])!;
        }
        
    }
}

var lines = await FileProvider.ReadAllLines(default(CancellationToken));
foreach(var line in lines){
    if(line.StartsWith("$"))
    {
        cmd(line);
    }
    else
    {
        var cmds = line.Split(" ");
        if (cmds[0] == "dir")
        {
            if (!currentrep.Childs.Any(c => c.Id == cmds[1]))
            {
                currentrep.Childs.Add(new Noeud(cmds[1])
                {
                    Parent = currentrep
                });
            }
            
        }
        else
        {
            currentrep.Length += int.Parse(cmds[0]);
        }
    }
}

int total = 0;
List<int> buffer = new List<int>();

if (baseNode.GetLength() <= 100000)
{
    total = baseNode.GetLength();
}
else
{
    total += GetTotalChilds(baseNode.Childs);

    int GetTotalChilds(List<Noeud> baseNodeChilds)
    {
        var total = 0;
        foreach (var child in baseNodeChilds)
        {
            if (child.GetLength() <= 100000)
            {
                total += child.GetLength();
            }
            var b = GetTotalChilds(child.Childs);
            buffer.Add(child.GetLength());
            total += b;
        }

        return total;
    }
}
Console.WriteLine(total);

int smaller = baseNode.GetLength();
int b = 30000000 - (70000000 - smaller);
//GetSmallerChild(baseNode.Childs, 30000000 - (70000000 - smaller));

/*void GetSmallerChild(List<Noeud> baseNodeChilds, int needSpace)
{
    foreach (var child in baseNodeChilds.Where(x => x.GetLength() > needSpace))
    {
        buffer.Add(child.GetLength());
        GetSmallerChild(baseNodeChilds, needSpace);
    }
}*/
Console.WriteLine(buffer.Where(x => x >= b).MinBy(x => x));