namespace cwiczenia3;

public class GasContainer(int height, int weight, int containerDepth)
    : Container('G', height, weight, containerDepth), IHazardNotifier
{
    protected override void UnloadCargo(int cargoWeight)
    {
        base.UnloadCargo(cargoWeight);
        if (LoadedWeight < ContainerDepth * 0.05)
        {
            Notify();
        }
    }

    public void Notify()
    {
        Console.WriteLine($"Dangerous situation, serial number: {SerialNumber}");
    }
}