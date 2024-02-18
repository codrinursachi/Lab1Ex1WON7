partial class Program
{
    static (uint, uint, uint) ReadSides()
    {
        (uint latime, uint lungime, uint adancime) paralelipiped = new();
        Console.WriteLine($"Introduceti " +
            $"{nameof(paralelipiped.latime)}, " +
            $"{nameof(paralelipiped.lungime)}, " +
            $"{nameof(paralelipiped.adancime)} " +
            $"ale paralelipiedului separate de un spatiu");
        var laturi = Console.ReadLine()?.Split(" ");
        if (laturi?.Length==3&&
            uint.TryParse(laturi?[0], out paralelipiped.latime)&&
            uint.TryParse(laturi?[1], out paralelipiped.lungime)&&
            uint.TryParse(laturi?[2], out paralelipiped.adancime))
            return paralelipiped;
        else
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
            return ReadSides();
        }
    }
    static uint ComputeVolume((uint,uint,uint) paralelipiped)
    {
        return paralelipiped.Item1 * paralelipiped.Item2 * paralelipiped.Item3;
    }
    static void ShowVolume(uint volum)
    {
        Console.WriteLine(volum);
    }
}
