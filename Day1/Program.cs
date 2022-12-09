// See https://aka.ms/new-console-template for more information
int buf = 0;
int max = 0;

foreach(var e in Input.input.Split(Environment.NewLine)){
       if(string.IsNullOrEmpty(e)){
        max = Math.Max(max, buf);
        buf = 0;
    }
    else{
        buf += int.Parse(e);
    }
}
Console.WriteLine(max);
List<int> l = new List<int>();
buf = 0;
foreach(var e in Input.input.Split(Environment.NewLine)){
    if(string.IsNullOrEmpty(e)){
       l.Add(buf);
        buf = 0;
    }
    else{
        buf += int.Parse(e);
    }
}
Console.WriteLine(l.OrderByDescending(x => x).Take(3).Sum());