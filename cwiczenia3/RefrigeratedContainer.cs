namespace cwiczenia3;

public class RefrigeratedContainer(string productType, float temperature, int height, int weight, int containerDepth)
    : Container('C', height, weight, containerDepth)
{
    public string ProductType {get; set;} = productType;
    public float Temperature {get; set;} = temperature;

    public Dictionary<string, double> MinProductTemperature = new()
    {
        {"Bananas", 13.3}, {"Chocolate", 18}, {"Fish", 2}, {"Meat", -15}, {"Ice cream", 18}, {"Frozen pizza", -30},
        {"Cheese", 7.2}, {"Sausages", 5}, {"Butter", 20.5}, {"Eggs", 19}
    };
    
    public void LoadCargo(int cargoWeight, string productType)
    {
        base.LoadCargo(cargoWeight);
        if (productType != ProductType)
        {
            throw new ApplicationException("Invalid product");
        }
        
        if (Temperature < MinProductTemperature[productType])
        {
            throw new ApplicationException("Temperature too low for the product.");
        }

    }
    
    public override string ToString()
    {
        string toReturn = base.ToString() + ", product type: " + ProductType + ", temperature: " + Temperature;
        return toReturn;
    }
}