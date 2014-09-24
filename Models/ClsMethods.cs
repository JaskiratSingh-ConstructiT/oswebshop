using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Temboo.Library.eBay;
using Temboo.Library.eBay.Finding;
using Temboo.Library.eBay.Shopping;
using Temboo.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace OswebshopAPI.Models
{
    public class ClsMethods
    {


        //Code to Get Products from Ebay, Amazon and others to be inserted here//


        public string AppID = "DATechno-e2df-4ebd-8552-2768732e80bf";
        public string DevID = "c27b41ea-00c5-4d64-8ef5-b22e2cf36cf5";
        public string CertID = "e406e6ed-5404-45bd-9e37-c6f3500b7413";
        public string AuthToken = "AgAAAA**AQAAAA**aAAAAA**ygj+Uw**nY+sHZ2PrBmdj6wVnY+sEZ2PrA2dj6wFk4GhDJaFowydj6x9nY+seQ**AwQDAA**AAMAAA**V4mopSFzo9Y9j2UCTSfi8dwBPZS0IU1H+TbEkhmmgK1VaHNBnuJCaEZTmkXBXA48yV3bzUdnFdd9POqzTeQ1PAjsFx/LZIV6X/+eVYOeNqmhTKf2/ANUOiHcHqPrPc+TDU+gG8wzDzMSpLNRgD6E6HMqdQEtLN0AAac5X5ecSaCuoLKAn4e2Ooont/9fjTOJc3+4pyas7I1WWgSTWbI4dk+7XmwZyhKy3jsyns/2VVRb9GttBtnB5e4hKxk5Q7IHF9uLd5kcDZqRDIQVF5Rp25z0/wsJbRUB5NbuGQTDIvfdtKHqocMkytL4n2PHqokA9FnPKBmoepUFmvUm5R6fS6RCbypDvg4xKlVNFfZ5F7jw3yfW05cPh9dXpf1YOMy6eyIIM+xfIj+MTUDTMw7PA7GWkGRQs9nmN3rtKF9VResw86W55sdo7bqnGzlq2z5NKfp4ME3Tu95sssh/PT4Pd4KmBHMmqX1Fl99Pw+xhHWnSK+BA55nufT3kc/kudewdnNclR3hJrUFvGZTnyuafPTaNpecpX2XmyWg90M5nuEbai2u6FX7SswlF4ZiHwn5eiPQm9fKDq5gzUp+6oHk2j6/0dDQLHHWZ1R+bXNaZC7I+bdq7+pEzBTVbn3TfgaG2uqxDrXjpnXUizQG+xOGLnROszgaR9UejtEhSYuChf3nBgAdTPsrAL1G0NFouu2Ju8AVAYtxMKKvUOEvk4a++XK2GpeBsPjqR+vdZykU2zaz4pB2XcttuFxw482vWMT01";
        public string ProductionAppID = "DATechno-cbe9-4261-8f80-49bf0dd2b803";

        public List<ProductModel.Item> Getsearchlistingsbykeyword(string keyword)
        {
            // Instantiate the Choreo, using a previously instantiated TembooSession object, eg:
            TembooSession session = new TembooSession("jaskirat", "myFirstApp", "d205eddb11ec4969a30911d32a9b9eff");
            FindItemsAdvanced findItemsAdvancedChoreo = new FindItemsAdvanced(session);

            // Set inputs
            findItemsAdvancedChoreo.setEntriesPerPage("10");
            findItemsAdvancedChoreo.setAppID(ProductionAppID);
            findItemsAdvancedChoreo.setSandboxMode("0");
            findItemsAdvancedChoreo.setKeywords(keyword);
            findItemsAdvancedChoreo.setItemFilters("{\"ListingType\":\"FixedPrice\"}");

            // Execute Choreo
            FindItemsAdvancedResultSet findItemsAdvancedResults = findItemsAdvancedChoreo.execute();

            var Model = JsonConvert.DeserializeObject<ProductModel.Example>(findItemsAdvancedResults.Response);
            var lst = new List<ProductModel.Item>();
            if (Model.searchResult.count != null)
            {
                foreach (var item in Model.searchResult.item)
                {
                    lst.Add(new ProductModel.Item { title = item.title,productId=item.productId,itemId=item.itemId,condition=item.condition,galleryURL=item.galleryURL,globalId=item.globalId});
                }
            }
            //string response = JsonConvert.SerializeObject(lst);

            return lst;
        }

    }
}