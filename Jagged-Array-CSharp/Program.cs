// Jagged Array

string[][] jaggedArray = new string[5][]
{
    new string[] {"BBA","BA","BSC"},
    new string[] {"MSC","MBA"},
    new string[] {"SSC"},
    new string[] {"HSC"},
    new string[] {"CSE","MCSE"}
    
};

Console.WriteLine(jaggedArray[0][0]);
Console.WriteLine(jaggedArray[0][1]);
Console.WriteLine(jaggedArray[0][2]);

Console.WriteLine(jaggedArray[1][0]);
Console.WriteLine(jaggedArray[1][1]);

Console.WriteLine(jaggedArray[2][0]);

Console.WriteLine(jaggedArray[3][0]);

Console.WriteLine(jaggedArray[4][0]); 
Console.WriteLine(jaggedArray[4][1]);


