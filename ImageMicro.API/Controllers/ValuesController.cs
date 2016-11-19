using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using ImageMicro.Service.Contracts;
using ImageMicro.Model;

namespace ImageMicro.API.Controllers
{
    public class ValuesController : ApiController
    {
        private IImageService _imageService;
        public ValuesController(IImageService image)
        {
            _imageService = image;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }



        // GET api/values/5
        public string Get(int id)
        {
            Image img = _imageService.GetImage(id.ToString());
            if (img != null)
                return "value: " + img.name + " date: " + img.date_download;
            return "error: message";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
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
