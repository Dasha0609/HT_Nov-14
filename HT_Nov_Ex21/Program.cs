// See https://aka.ms/new-console-template for more information


int aX = ReadInt("Pls enter polar x for A: ");
int aY = ReadInt("Pls enter polar y for A: ");
int aZ = ReadInt("Pls enter polar z for A: ");
int bX = ReadInt("Pls enter polar x for B: ");
int bY = ReadInt("Pls enter polar y for B: ");
int bZ = ReadInt("Pls enter polar z for B: ");

int sqrSideX = (aX - bX) * (aX - bX);
int sqrSideY = (aY - bY) * (aY - bY);
int sqrSideZ = (aZ - bZ) * (aZ - bZ);
double distance = Math.Sqrt(sqrSideX + sqrSideY + sqrSideZ);
Console.WriteLine(distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
