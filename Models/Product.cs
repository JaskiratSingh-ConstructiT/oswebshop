using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace OswebshopAPI.Models
{
    public class ProductModel
    {
            public class PrimaryCategory
    {
        [JsonProperty("categoryId")]
        public string categoryId { get; set; }
        [JsonProperty("categoryName")]
        public string categoryName { get; set; }
    }

    public class ShippingServiceCost
    {
        [JsonProperty("@currencyId")]
        public string @currencyId { get; set; }
        [JsonProperty("#text")]
        public string text { get; set; }
    }

    public class ShippingInfo
    {
        [JsonProperty("shippingServiceCost")]
        public ShippingServiceCost shippingServiceCost { get; set; }
        [JsonProperty("shippingType")]
        public string shippingType { get; set; }
        [JsonProperty("shipToLocations")]
        public object shipToLocations { get; set; }
        [JsonProperty("expeditedShipping")]
        public string expeditedShipping { get; set; }
        [JsonProperty("oneDayShippingAvailable")]
        public string oneDayShippingAvailable { get; set; }
        [JsonProperty("handlingTime")]
        public string handlingTime { get; set; }
    }

    public class CurrentPrice
    {
        [JsonProperty("@currencyId")]
        public string @currencyId { get; set; }
        [JsonProperty("#text")]
        public string text { get; set; }
    }

    public class ConvertedCurrentPrice
    {
        [JsonProperty("@currencyId")]
        public string @currencyId { get; set; }
        [JsonProperty("#text")]
        public string text { get; set; }
    }

    public class SellingStatus
    {
        [JsonProperty("currentPrice")]
        public CurrentPrice currentPrice { get; set; }
        [JsonProperty("convertedCurrentPrice")]
        public ConvertedCurrentPrice convertedCurrentPrice { get; set; }
        [JsonProperty("sellingState")]
        public string sellingState { get; set; }
        [JsonProperty("timeLeft")]
        public string timeLeft { get; set; }
    }

    public class ListingInfo
    {
        [JsonProperty("bestOfferEnabled")]
        public string bestOfferEnabled { get; set; }
        [JsonProperty("buyItNowAvailable")]
        public string buyItNowAvailable { get; set; }
        [JsonProperty("startTime")]
        public DateTime startTime { get; set; }
        [JsonProperty("endTime")]
        public DateTime endTime { get; set; }
        [JsonProperty("listingType")]
        public string listingType { get; set; }
        [JsonProperty("gift")]
        public string gift { get; set; }
    }

    public class Condition
    {
        [JsonProperty("conditionId")]
        public string conditionId { get; set; }
        [JsonProperty("conditionDisplayName")]
        public string conditionDisplayName { get; set; }
    }

    public class OriginalRetailPrice
    {
        [JsonProperty("@currencyId")]
        public string @currencyId { get; set; }
        [JsonProperty("#text")]
        public string text { get; set; }
    }

    public class DiscountPriceInfo
    {
        [JsonProperty("originalRetailPrice")]
        public OriginalRetailPrice originalRetailPrice { get;  set; }
        [JsonProperty("pricingTreatment")]
        public string pricingTreatment { get; set; }
        [JsonProperty("soldOnEbay")]
        public string soldOnEbay { get; set; }
        [JsonProperty("soldOffEbay")]
        public string soldOffEbay { get; set; }
    }

    public class Item
    {
        [JsonProperty("itemId")]
        public string itemId { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("globalId")]
        public string globalId { get; set; }
        //[JsonProperty("subtitle")]
        //public string subtitle { get; set; }
        //[JsonProperty("primaryCategory")]
        //public PrimaryCategory primaryCategory { get; set; }
        [JsonProperty("galleryURL")]
        public string galleryURL { get; set; }
        //[JsonProperty("viewItemURL")]
        //public string viewItemURL { get; set; }
        [JsonProperty("productId")]
        public string productId { get; set; }
        //[JsonProperty("paymentMethod")]
        //public string paymentMethod { get; set; }
        //[JsonProperty("autoPay")]
        //public string autoPay { get; set; }
        //[JsonProperty("postalCode")]
        //public string postalCode { get; set; }
        //[JsonProperty("location")]
        //public string location { get; set; }
        //[JsonProperty("country")]
        //public string country { get; set; }
        //[JsonProperty("shippingInfo")]
        //public ShippingInfo shippingInfo { get; set; }
        //[JsonProperty("sellingStatus")]
        //public SellingStatus sellingStatus { get; set; }
        //[JsonProperty("listingInfo")]
        //public ListingInfo listingInfo { get; set; }
        //[JsonProperty("returnsAccepted")]
        //public string returnsAccepted { get; set; }
        [JsonProperty("condition")]
        public Condition condition { get; set; }
        //[JsonProperty("isMultiVariationListing")]
        //public string isMultiVariationListing { get; set; }
        //[JsonProperty("topRatedListing")]
        //public string topRatedListing { get; set; }
        //[JsonProperty("discountPriceInfo")]
        //public DiscountPriceInfo discountPriceInfo { get; set; }
    }

    public class SearchResult
    {
        [JsonProperty("@count")]
        public string @count { get; set; }
        [JsonProperty("item")]
        public IList<Item> item { get; set; }
    }

    public class PaginationOutput
    {
        [JsonProperty("pageNumber")]
        public string pageNumber { get; set; }
        [JsonProperty("entriesPerPage")]
        public string entriesPerPage { get; set; }
        [JsonProperty("totalPages")]
        public string totalPages { get; set; }
        [JsonProperty("totalEntries")]
        public string totalEntries { get; set; }
    }

    public class Example
    {
        [JsonProperty("@xmlns")]
        public string @xmlns { get; set; }
        [JsonProperty("ack")]
        public string ack { get; set; }
        [JsonProperty("version")]
        public string version { get; set; }
        [JsonProperty("timestamp")]
        public DateTime timestamp { get; set; }
        [JsonProperty("searchResult")]
        public SearchResult searchResult { get; set; }
        [JsonProperty("paginationOutput")]
        public PaginationOutput paginationOutput { get; set; }
        [JsonProperty("itemSearchURL")]
        public string itemSearchURL { get; set; }
    }
        //public string ScoreIfNoMatch { get; set; }
    }
}