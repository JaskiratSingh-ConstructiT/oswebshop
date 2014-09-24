using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using OswebshopAPI.Models;


namespace OswebshopAPI.Controllers
{
    public class ProductsController : ApiController
    {
        IList<ProductModel> list = new List<ProductModel>();
        // GET api/values
        //ProductModel product = new ProductModel();
        ClsMethods Methods = new ClsMethods();
        public IEnumerable<ProductModel> Get()
        {
            return list;
        }

        // GET api/values/5
        public List<ProductModel.Item> Get(string keyword)
        {
            return Methods.Getsearchlistingsbykeyword(keyword);
            
            //return list;
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            throw new HttpResponseException(HttpStatusCode.MethodNotAllowed);
            

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}