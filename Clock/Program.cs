// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.CursorVisible = false;
do
{
    DateTime currentTime = DateTime.Now;
    Console.SetCursorPosition(1, 1);
    Console.Write("Time:"+currentTime.ToLongTimeString());
    Thread.Sleep(1000);
}while (!Console.KeyAvailable);
