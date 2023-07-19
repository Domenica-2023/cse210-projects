public class order
{
    public gettotalPrice(shippingCost)
    {
        newPrice + shippingCost;
    }

    public MakeShippingLabel(string customerName, string address)
    {
        return $"{_customerName} : {_address}"
    }

    public MakePackingLabel(string productName, string productID)
    {
        return $"{_productName} : {_productID}"
    }
}