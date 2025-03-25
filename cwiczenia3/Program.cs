namespace cwiczenia3;

public class Program
{
    public static void Main(string[] args)
    {
        ContainerShip ship = new ContainerShip(10, 30, 50);
        ship.Containers.Add(new GasContainer(20, 30, 30));
        ship.GetShipInfo();
    }
}