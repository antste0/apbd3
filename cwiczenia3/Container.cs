namespace cwiczenia3;

public abstract class Container
{
    protected Container(char type)
    {
        _type = type;
        _identifier = _idNum;
        _idNum++;
    }

    private int LoadedWeight { get; set; }
    private int Height { get; set; }
    private int ContainerWeight { get; set; }
    private int Depth { get; set; }
    private char _type;
    private int _identifier;
    private static int _idNum = 0;

    public string SerialNumber
    {
        get { throw new NotImplementedException(); }
        set => SerialNumber = "KON-" + _type + "-" + _identifier;
    }

    public int MaxCargoWeight { get; set; }

    public void UnloadCargo(int cargoWeight)
    {
        LoadedWeight -= cargoWeight;
    }

    public virtual void LoadCargo(int cargoWeight)
    {
        LoadedWeight += cargoWeight;
        if (LoadedWeight > MaxCargoWeight)
        {
            throw new OverfillException("Cargo weight is too large.");
        }
    }
}