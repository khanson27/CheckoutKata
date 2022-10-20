// See https://aka.ms/new-console-template for more information

using CheckoutKata;

Checkout checkout = new Checkout();
ItemModel item = new ItemModel { Sku = "A99", Price = 0.5m, Qty = 1, OfferCondition = 3, OfferPrice = 1.3m };
ItemModel item2 = new ItemModel { Sku = "B15", Price = 0.3m, Qty = 1, OfferCondition = 2, OfferPrice = 0.45m };
ItemModel item3 = new ItemModel { Sku = "C40", Price = 0.6m, Qty = 1, OfferCondition = null, OfferPrice = null };
checkout.Scan(item3);
checkout.Scan(item3);
checkout.Scan(item3);
checkout.Scan(item3);
checkout.Scan(item3);

Console.WriteLine(checkout.Total());


