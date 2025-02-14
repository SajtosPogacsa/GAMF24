//using System.Linq;

const string DIR = "H:\\gamf";
//List<int> osztok = new List<int>();
//int num = 1310438493;
//int goodNums = 0;
//for (int i = 1; i < Math.Sqrt(num); i++)
//{
//    if (num % i == 0)
//    {
//        osztok.Add(i);
//    }
//}

//using (StreamReader stream = new StreamReader($"{DIR}\\szamok.txt"))
//{
//    while(!stream.EndOfStream)
//    {
//        long line = long.Parse(stream.ReadLine());
//        Console.WriteLine(line);
//        int counter = 0;
//        for (long i = 1; i <= Math.Sqrt(line); i++)
//        {
//            if (line % i == 0)
//            {
//                if(osztok.ToHashSet().Contains((int)i))

//                if (osztok.Contains((int)i))
//                {
//                    counter++;
//                }
//            }

//            if (counter > 1)
//            {
//                break;
//            }
//        }
//        if(counter == 1)
//        {
//            goodNums++;
//        }
//        counter = 0;
//        Console.WriteLine(goodNums);
//    }

//}

//Console.WriteLine(goodNums);

//2. feladat

string szam = "2354211341";
char[] chars = szam.ToCharArray();
Array.Sort(chars);
int annagrams = 0;
List<string> voltmar = new List<string>();
using (StreamReader sr = new($"{DIR}\\szamok.txt"))
{
    while(!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        if (voltmar.ToHashSet<string>().Contains(line))
        {
            continue;
        }
        voltmar.Add(line);
        char[] charsLine = line.ToCharArray();
        Array.Sort(charsLine);
        if (chars.SequenceEqual(charsLine))
        {
            Console.WriteLine(line);
            annagrams++;
        }
    }
}
Console.WriteLine(annagrams - 1);