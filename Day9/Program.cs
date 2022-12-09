using System.Xml.XPath;
using Utils;
using Day9;

var lines = await FileProvider.ReadAllLines(default);

var head = new List<Coord> { new (0,0) };
var tail1 = new List<Coord> { new (0,0) };
var tail2 = new List<Coord> { new (0,0) };
var tail3 = new List<Coord> { new (0,0) };
var tail4 = new List<Coord> { new (0,0) };
var tail5 = new List<Coord> { new (0,0) };
var tail6 = new List<Coord> { new (0,0) };
var tail7 = new List<Coord> { new (0,0) };
var tail8 = new List<Coord> { new (0,0) };
var tail9 = new List<Coord> { new (0,0) };

void MoveR(Coord headp, Coord tailp, List<Coord> tail, Coord newHeadP)
{
    if(tailp.X != headp.X){
        if(headp.X != newHeadP.X && headp.Y != newHeadP.Y){
            tail.Insert(0,headp);
            return;
        }
        if(tailp.Y < headp.Y){
            tail.Insert(0,new (headp.X, tailp.Y+1));
        }
    }else{
        if(tailp.Y < headp.Y){
            tail.Insert(0,new (tailp.X, tailp.Y+1));
        }
    }
}

void MoveL(Coord headp, Coord tailp, List<Coord> tail, Coord newHeadP)
{
    if(tailp.X != headp.X){
        if(headp.X != newHeadP.X && headp.Y != newHeadP.Y){
            tail.Insert(0,headp);
            return;
        }
        if(tailp.Y > headp.Y){
            tail.Insert(0,new (headp.X, tailp.Y-1));
        }
    }else{
        if(tailp.Y > headp.Y){
            tail.Insert(0,new (tailp.X, tailp.Y-1));
        }
    }
}

void MoveU(Coord headp, Coord tailp, List<Coord> tail, Coord newHeadP)
{
    if(tailp.Y != headp.Y){
        if(headp.X != newHeadP.X && headp.Y != newHeadP.Y){
            tail.Insert(0,headp);
            return;
        }
        if(tailp.X < headp.X){
            tail.Insert(0,new (tailp.X+1, headp.Y));
        }
    }else{
        if(tailp.X < headp.X){
            tail.Insert(0,new (tailp.X+1, tailp.Y));
        }
    }
}

void MoveD(Coord headp, Coord tailp, List<Coord> tail, Coord newHeadP)
{
    if(tailp.Y != headp.Y){
        if(headp.X != newHeadP.X && headp.Y != newHeadP.Y){
            tail.Insert(0,headp);
            return;
        }
        if(tailp.X > headp.X){
            tail.Insert(0,new (tailp.X-1, headp.Y));
        }
    }else{
        if(tailp.X > headp.X){
            tail.Insert(0,new (tailp.X-1, tailp.Y));
        }
    }
}

foreach(var line in lines){
    var turn = line.Split(" ");
    var moves = int.Parse(turn[1]);
    
        
    switch(turn[0]){
        case "R":
            for(int i =0; i < moves; i++)
            {
                var headp = head.First();
                var tail1p = tail1.First();
                var tail2p = tail2.First();
                var tail3p = tail3.First();
                var tail4p = tail4.First();
                var tail5p = tail5.First();
                var tail6p = tail6.First();
                var tail7p = tail7.First();
                var tail8p = tail8.First();
                var tail9p = tail9.First();
                
                head.Insert(0,new (headp.X, headp.Y+1));
                MoveR(headp, tail1p, tail1,head.First());
                MoveR(tail1p, tail2p, tail2,tail1.First());
                MoveR(tail2p, tail3p, tail3,tail2.First());
                MoveR(tail3p, tail4p, tail4,tail3.First());
                MoveR(tail4p, tail5p, tail5,tail4.First());
                MoveR(tail5p, tail6p, tail6,tail5.First());
                MoveR(tail6p, tail7p, tail7,tail6.First());
                MoveR(tail7p, tail8p, tail8,tail7.First());
                MoveR(tail8p, tail9p, tail9,tail8.First());
            }
            break;
        case "L":
            for(int i =0; i < moves; i++)
            {
                var headp = head.First();
                var tail1p = tail1.First();
                var tail2p = tail2.First();
                var tail3p = tail3.First();
                var tail4p = tail4.First();
                var tail5p = tail5.First();
                var tail6p = tail6.First();
                var tail7p = tail7.First();
                var tail8p = tail8.First();
                var tail9p = tail9.First();
                
                head.Insert(0,new (headp.X, headp.Y-1));
                MoveL(headp, tail1p, tail1,head.First());
                MoveL(tail1p, tail2p, tail2,tail1.First());
                MoveL(tail2p, tail3p, tail3,tail2.First());
                MoveL(tail3p, tail4p, tail4,tail3.First());
                MoveL(tail4p, tail5p, tail5,tail4.First());
                MoveL(tail5p, tail6p, tail6,tail5.First());
                MoveL(tail6p, tail7p, tail7,tail6.First());
                MoveL(tail7p, tail8p, tail8,tail7.First());
                MoveL(tail8p, tail9p, tail9,tail8.First());
            }
            break;
        case "U":
            for(int i =0; i < moves; i++)
            {
                var headp = head.First();
                var tail1p = tail1.First();
                var tail2p = tail2.First();
                var tail3p = tail3.First();
                var tail4p = tail4.First();
                var tail5p = tail5.First();
                var tail6p = tail6.First();
                var tail7p = tail7.First();
                var tail8p = tail8.First();
                var tail9p = tail9.First();
                
                head.Insert(0,new (headp.X+1, headp.Y));
                MoveU(headp, tail1p, tail1,head.First());
                MoveU(tail1p, tail2p, tail2,tail1.First());
                MoveU(tail2p, tail3p, tail3,tail2.First());
                MoveU(tail3p, tail4p, tail4,tail3.First());
                MoveU(tail4p, tail5p, tail5,tail4.First());
                MoveU(tail5p, tail6p, tail6,tail5.First());
                MoveU(tail6p, tail7p, tail7,tail6.First());
                MoveU(tail7p, tail8p, tail8,tail7.First());
                MoveU(tail8p, tail9p, tail9,tail8.First());
            }
            break;
        case "D":
            for(int i =0; i < moves; i++)
            {
                var headp = head.First();
                var tail1p = tail1.First();
                var tail2p = tail2.First();
                var tail3p = tail3.First();
                var tail4p = tail4.First();
                var tail5p = tail5.First();
                var tail6p = tail6.First();
                var tail7p = tail7.First();
                var tail8p = tail8.First();
                var tail9p = tail9.First();
                
                head.Insert(0,new (headp.X-1, headp.Y));
                MoveD(headp, tail1p, tail1,head.First());
                MoveD(tail1p, tail2p, tail2,tail1.First());
                MoveD(tail2p, tail3p, tail3,tail2.First());
                MoveD(tail3p, tail4p, tail4,tail3.First());
                MoveD(tail4p, tail5p, tail5,tail4.First());
                MoveD(tail5p, tail6p, tail6,tail5.First());
                MoveD(tail6p, tail7p, tail7,tail6.First());
                MoveD(tail7p, tail8p, tail8,tail7.First());
                MoveD(tail8p, tail9p, tail9,tail8.First());
            }
            break;
    }
}

Console.WriteLine(tail9.Distinct().Count());