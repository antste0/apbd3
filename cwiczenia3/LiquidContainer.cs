namespace cwiczenia3;

public class LiquidContainer : Container, IHazardNotifier
{
    private IHazardNotifier _hazardNotifierImplementation;
    private bool _dangerousCargo;

    public LiquidContainer(int maxCargoWeight, bool dangerousCargo) : base('L')
    {
        _dangerousCargo = dangerousCargo;
        MaxCargoWeight = maxCargoWeight;
    }
    
    public override void LoadCargo(int cargoWeight)
    {
    }

    public void Notify()
    {
        Console.WriteLine($"Niebezpieczna sytuacja, Serial number: {SerialNumber}");
        throw new NotImplementedException();
    }
}