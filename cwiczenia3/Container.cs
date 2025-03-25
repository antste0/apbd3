namespace cwiczenia3;

public abstract class Container
{
    private static int _idNum;

    protected Container(char containerType, int height, int weight, int containerDepth)
    {
        ContainerType = containerType;
        Height = height;
        ContainerDepth = containerDepth;
        ContainerWeight = weight;
        _idNum++;
        SerialNumber = "KON-" + ContainerType + "-" + _idNum; // Ustawienie numeru seryjnego
    }

    protected int LoadedWeight { get; set; }
    public int Height { get; set; }
    public int ContainerWeight { get; set; }
    public int ContainerDepth { get; set; }
    private char ContainerType { get; set; }

    public string SerialNumber { get; }

    protected int MaxCargoWeight { get; init; }

    protected virtual void UnloadCargo(int cargoWeight)
    {
        LoadedWeight -= cargoWeight;
    }

    public virtual void LoadCargo(int cargoWeight)
    {
        LoadedWeight += cargoWeight;
        if (LoadedWeight > MaxCargoWeight)
        {
            throw new OverfillException("Cargo weight too large.");
        }
    }

    public override string ToString()
    {
        return "Serial number: " + SerialNumber + ", height: " + Height + ", container weight: " + ContainerWeight;
    }
}
