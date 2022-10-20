using CheckoutKata;

namespace Tests;

public class TestData
{
    public ItemModel item1QtyOne = new ItemModel
        { Sku = "A99", Price = 0.5m, Qty = 1, OfferCondition = 3, OfferPrice = 1.3m };

    public ItemModel item2QtyOne = new ItemModel
        { Sku = "B15", Price = 0.3m, Qty = 1, OfferCondition = 2, OfferPrice = 0.45m };

    public ItemModel item3QtyOne = new ItemModel
        { Sku = "C40", Price = 0.6m, Qty = 1, OfferCondition = null, OfferPrice = null };
    
    public ItemModel item1QtyTwo = new ItemModel
        { Sku = "A99", Price = 0.5m, Qty = 2, OfferCondition = 3, OfferPrice = 1.3m };

    public ItemModel item2QtyThree = new ItemModel
        { Sku = "B15", Price = 0.3m, Qty = 3, OfferCondition = 2, OfferPrice = 0.45m };

    public ItemModel item3QtyFour = new ItemModel
        { Sku = "C40", Price = 0.6m, Qty = 4, OfferCondition = null, OfferPrice = null };
}