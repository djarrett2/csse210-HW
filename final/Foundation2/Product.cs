public class Product
{
    private string _productName;
    private string _productId;
    private float _price;
    private int _quantity;

    public Product(string name, string id, float price, int quantity)
    {
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName()
        {
            return _productName;
        }

        public string GetProductId()
        {
            return _productId;
        }
}