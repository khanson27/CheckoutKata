using static CheckoutKata.ItemModel;

namespace CheckoutKata;

public class Checkout
{
    private List<ItemModel> ItemList;

    public decimal Total()
    {
        //add all items prices if  offerprice  is always null add all
        //if offer price is not null, add all prices and offer prices
        return 0m;
    }
 
    public void Scan(ItemModel items)
    {
        //1st item add to list and +1 to qty
        //if item is already in list, +1 to qty
        //if qty reaches offer level, add offer price, set price to null/0
        
    }
}
 

//if qty is is divisible by offer price and has matching SKU use offer price * remainder unless 0 
/*public class SpecialOffer
{
    public int Qty { get; set; }
    public decimal OfferPrice { get; set; }
}*/


