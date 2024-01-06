/* Author: MEZONE */

/// <summary>
/// 
/// </summary>
static int Fibonachi(int N)
{
    if (N == 1)
        return (1);
    if (N == 2)
        return (1);
    return (Fibonachi(N - 2) + Fibonachi(N - 1));
}

/*string Q;*/
int Count = 1, X, i;

Console.Write("\nEnter Number:");
X = int.Parse(Console.ReadLine());
Console.Write("Result is:\n");
for (i = 1; i <= X; i++)
    Console.Write("Fibonachi({01}): {00} \n",Fibonachi(i), Count++);
Console.WriteLine("------------\nReceved ({0}) Fibonachi Number Complated.", X);

/* HELLO FROM ER-A-SE, THIS PROGRAM CREATED BY ALI DAREHSHORI, FOR ALL PEOPLE IN THE WORLD, NO EXEPTION */
Console.ReadKey();


// Q = Console.ReadLine();
// Console.Write("\nYou Want to Contniuo? "); // Y/N
// if (Q == true)
// {

// }




/// <summary>
/// 
/// </summary>