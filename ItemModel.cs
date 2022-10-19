namespace CheckoutKata;

public class ItemModel
{
		public string Sku {get;set;}
        public decimal Price{get; set;}
        public int Qty { get; set; }
        public decimal? OfferPrice { get; set; }
        public decimal? OfferCondition { get; set; }
        
}
//model for Items scanned