using System.Text.RegularExpressions;
using Utils;
var lines = await FileProvider.ReadAllLines(default(CancellationToken));
int i = 0;
var piles = new List<char>[]{
    new(),
    new(),
    new(),
    new(),
    new(),
    new(),
    new(),
    new(),
    new(),
};

while(lines[i][1] != '1'){
    var line = lines[i];
    for(int j = 0; j < 9; j++){
        int p = j*4+1;
        if(line[p] != ' '){
            piles[j].Add(line[p]);
        }
    }
    i++;
}

var pileSave = (List<char>[]) piles.Clone();
const string regexstr = "[0-9]{1,}";
var regex = new Regex(regexstr);
i++;
i++;
var isave = i;
for(;i < lines.Length; i++){
    var line = lines[i];
    var matches = regex.Matches(line);
    int nbPiece = int.Parse(matches[0].Value);
    int from = int.Parse(matches[1].Value)-1;
    int to = int.Parse(matches[2].Value)-1;
    for (int k = 0; k < nbPiece; k++)
    {
        if (piles[from].Count > 0)
        {
            piles[to].Insert(0, piles[from].First());
            piles[from].RemoveAt(0);
        }
    }
}

for (int k = 0; k < 9; k++)
{
    Console.Write(piles[k].First());
}
Console.WriteLine();

piles = new List<char>[]{
    new(),
    new(),
    new(),
    new(),
    new(),
    new(),
    new(),
    new(),
    new(),
};
i = 0;
while(lines[i][1] != '1'){
    var line = lines[i];
    for(int j = 0; j < 9; j++){
        int p = j*4+1;
        if(line[p] != ' '){
            piles[j].Add(line[p]);
        }
    }
    i++;
}
i++;
i++;

for(;i < lines.Length; i++){
    var line = lines[i];
    var matches = regex.Matches(line);
    int nbPiece = int.Parse(matches[0].Value);
    int from = int.Parse(matches[1].Value)-1;
    int to = int.Parse(matches[2].Value)-1;
    
    piles[to].InsertRange(0, piles[from].Take(nbPiece));
    if(piles[from].Count > 0 && piles[from].Count > nbPiece)
        piles[from].RemoveRange(0, nbPiece);
    else
    {
        piles[from].RemoveAll(x => true);
    }
}

for (int k = 0; k < 9; k++)
{
    Console.Write(piles[k].First());
}