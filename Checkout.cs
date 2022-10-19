using static CheckoutKata.ItemModel;

namespace CheckoutKata;

public class Checkout
{
    public List<ItemModel> ItemList = new List<ItemModel>();

    public decimal Total()
    {
        decimal? total = 0m;
        decimal? remainder = 0m;
        decimal? dividePrice = 0m;
        foreach (ItemModel item in ItemList)
        {
            if (item.Qty == 1)
            {
                total += item.Price;
            }
            else if (item.OfferCondition == null)
            {
                total += (item.Price * item.Qty);
            }
            else if (item.Qty % item.OfferCondition == 0 )
            {
                dividePrice = item.Qty / item.OfferCondition;
                total += item.OfferPrice * dividePrice;
            }
            else if (item.Qty % item.OfferCondition != 0)
            {
                remainder = item.Qty % item.OfferCondition;
                dividePrice = (item.Qty - remainder) / item.OfferCondition;
                total += (item.OfferPrice * dividePrice) + (item.Price * remainder);
            }
        }
        //add all items prices if  offerprice  is always null add all
        //if offer price is not null, add all prices and offer prices
        return total;
    }
    
        public void Scan(ItemModel item)
        {
            if (ItemList?.Count > 0 && ItemList.Any(i => i.Sku == item.Sku))
            {
                int existingItemIndex = ItemList.FindIndex(i => i.Sku == item.Sku);
                 ItemList[existingItemIndex].Qty += item.Qty;
            }
            else
            {
                ItemModel newItem = new ItemModel
                {
                    Sku = item.Sku, Price = item.Price, Qty = item.Qty, OfferCondition = item.OfferCondition,
                    OfferPrice = item.OfferPrice
                };
                ItemList.Add(newItem);
            }
            //1st item add to list and +1 to qty
            //if item is already in list, +1 to qty
           
        
        }
    
 

//if qty is is divisible by offer price and has matching SKU use offer price * remainder unless 0 
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


