namespace cwiczenia3;

public class LiquidContainer : Container, IHazardNotifier
{
    public IHazardNotifier HazardNotifier { get; }
    private bool DangerousCargo {get; set;}

    public LiquidContainer(
        int maxCargoWeight, bool dangerousCargo, IHazardNotifier hazardNotifier,
        int height, int weight, int containerDepth)
        : base('L', height, weight, containerDepth
    ) {
        DangerousCargo = dangerousCargo;
        HazardNotifier = hazardNotifier;
        MaxCargoWeight = maxCargoWeight;
    }
    
    public override void LoadCargo(int cargoWeight)
    {
        if (
            (! DangerousCargo && cargoWeight > MaxCargoWeight * 0.9) ||
            (DangerousCargo && cargoWeight > MaxCargoWeight * 0.5))
        {
            Notify();
        }
        base.LoadCargo(cargoWeight);
    }

    public void Notify()
    {
        Console.WriteLine($"Dangerous situation, serial number: {SerialNumber}");
    }

    public override string ToString()
    {
        string toReturn = base.ToString() + ", dangerous cargo: " + DangerousCargo;
        return toReturn;
    }
}