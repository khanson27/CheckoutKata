using System.Collections.Generic;
using CheckoutKata;
using FluentAssertions;


namespace Tests;

public class CheckoutKataTests
{
    #region TestData
    public Checkout Checkout = new Checkout();
    public static ItemModel Item1So = new ItemModel
        { Sku = "A99", Price = 0.5m, Qty = 3, OfferCondition = 3, OfferPrice = 1.3m };

    public static ItemModel Item2So = new ItemModel
        { Sku = "B15", Price = 0.3m, Qty = 4, OfferCondition = 2, OfferPrice = 0.45m };
    
    public static ItemModel Item1QtyOne = new ItemModel
        { Sku = "A99", Price = 0.5m, Qty = 1, OfferCondition = 3, OfferPrice = 1.3m };

    public static ItemModel Item2QtyOne = new ItemModel
        { Sku = "B15", Price = 0.3m, Qty = 1, OfferCondition = 2, OfferPrice = 0.45m };

    public static ItemModel Item3QtyOne = new ItemModel
        { Sku = "C40", Price = 0.6m, Qty = 1, OfferCondition = null, OfferPrice = null };
    public static IEnumerable<object[]> TestItems1 =>

        new List<object[]>
        {  
              new object[]
              {
               new ItemModel { Sku = "A99", Price = 0.5m, Qty = 1, OfferCondition = 3, OfferPrice = 1.3m }
               },
              new object[]
              {
                  new ItemModel { Sku = "B15", Price = 0.3m, Qty = 1, OfferCondition = 2, OfferPrice = 0.45m } 
              }, 
              new object[]
              {
                  new ItemModel { Sku = "C40", Price = 0.6m, Qty = 1, OfferCondition = null, OfferPrice = null }
              }
        };
 
    public static IEnumerable<object[]> TestItemListTotal =>

        new List<object[]>
        {  
            new object[]
                {new List<ItemModel>{ Item1QtyOne, Item2QtyOne, Item3QtyOne}, 1.4m }
        };
    public static IEnumerable<object[]> TestItemListSpecialOffer =>

        new List<object[]>
        {  
            new object[]
                {new List<ItemModel>{ Item1So, Item2So}, 2.2m }
        };
    public static IEnumerable<object[]> TestItemListAllPrices=>

        new List<object[]>
        {  
            new object[]
                {new List<ItemModel>{ Item1So, Item2So, Item1QtyOne, Item2QtyOne, Item3QtyOne}, 3.6m }
        };
    public static IEnumerable<object[]> TestItemListForScan =>

        new List<object[]>
        {  
            new object[]
                {new List<ItemModel>{ Item1QtyOne, Item2QtyOne, Item3QtyOne,  Item1QtyOne, Item2QtyOne, Item3QtyOne}}
        };
    
    #endregion

    #region Scan
    [Theory]
    [MemberData(nameof(TestItems1))]
    public void Scan_WithItemNotInList_AddsItemAndQtyToList (ItemModel item)
    {
        Checkout.Scan(item);
        Checkout.ItemList.Should().NotBeEmpty();
        Checkout.ItemList[0].Should().BeOfType<ItemModel>();
        Checkout.ItemList[0].Qty.Should().Be(1);
        
    }

    [Theory]
    [MemberData(nameof(TestItemListForScan))]
    public void Scan_ItemExistsInList_AddsOneToQty(List<ItemModel> items)
    {
        foreach (var item in items)
        {
            Checkout.Scan(item);
        }
        Checkout.ItemList.Should().NotBeEmpty();
        Checkout.ItemList.Should().HaveCount(3);
        foreach (var listedItem in Checkout.ItemList)
        {
            listedItem.Should().BeOfType<ItemModel>();
            listedItem.Qty.Should().Be(2);
        }

    }
    #endregion
    

    #region Total
    [Theory]
    [MemberData(nameof(TestItemListTotal))]
    public void Total_WithNoSpecialOffer_AddsAllPrices(List<ItemModel> itemList, decimal expectedTotal)
    {
        foreach (var item in itemList)
        {
            Checkout.Scan(item);
        }

        Checkout.Total().Should().Be(expectedTotal);
    }
    
    [Theory]
    [MemberData(nameof(TestItemListSpecialOffer))]
    public void Total_WithSpecialOffer_AddsSpecialOffers(List<ItemModel> itemList, decimal expectedTotal)
    {
        foreach (var item in itemList)
        {
            Checkout.Scan(item);
        }

        Checkout.Total().Should().Be(expectedTotal);
    }

    [Theory]
    [MemberData(nameof(TestItemListAllPrices))]
    public void Total_WithSpecialOfferAndNormalPrice_AddsAllPrices(List<ItemModel> itemList, decimal expectedTotal)
    {
        foreach (var item in itemList)
        {
            Checkout.Scan(item);
        }

        Checkout.Total().Should().Be(expectedTotal);
    }
    #endregion
}