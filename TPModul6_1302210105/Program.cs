// See https://aka.ms/new-console-template for more information
using TPModul6_1302210105;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design by Contract - Onesiforus Rade Putra");
        video.IncreasePlayCount(9);
        video.PrintVideoDetails();
    }
}