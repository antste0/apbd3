namespace cwiczenia3;

public class ContainerShip(double maxCargoWeight, int maxContainers, double maxSpeed)
{
    public List<Container> Containers { get; set; } = new List<Container>();
    public double MaxSpeed { get; set; } = maxSpeed;
    public int MaxContainers { get; set; } = maxContainers;
    public double MaxCargoWeight { get; set; } = maxCargoWeight;
    private double CargoWeight { get; set; }

    public void TransferCargo(Container container, ContainerShip ship)
    {
        if (ship.Containers.Count >= MaxContainers)
        {
            Console.WriteLine("Not enough space on deck");
            return;
        }
        ship.Containers.Add(container);
        Containers.Remove(container);
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count >= MaxContainers && CargoWeight < MaxCargoWeight)
        {
            Containers.Add(container);
            CargoWeight += container.ContainerWeight / 1000;
        } else
        {
            Console.WriteLine("Exceeded maximum number of containers");
        }
    }

    public void GetContainerInfo(Container container)
    {
        Console.WriteLine(container);
    }

    public void GetShipInfo()
    {
        Console.WriteLine(this);
        for (int i = 0; i < Containers.Count; i++)
        {
            Console.WriteLine(Containers[i]);
        }
    }

    public override string ToString()
    {
        return "Max speed: " + MaxSpeed + ", max containers: " + MaxContainers + ", containers: " + Containers.Count;
    }
}