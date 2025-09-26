public class Product
{
    private string _name;
    private int _productId;
    private decimal _pricePerUnity;
    private int _quantity;

    public Product(string name, int productId, decimal pricePerUnity, int quantity)
    {
        _name = name;
        _pricePerUnity = pricePerUnity;
        _productId = productId;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }
    public int GetProdcutId()
    {
        return _productId;
    }
    public decimal GetPricePerUnity()
    {
        return _pricePerUnity;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = _pricePerUnity * _quantity;
        return totalCost;
    }
}