using ImageMicro.Model;
using ImageMicro.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
        public IEnumerable<Image> Get()
        {   
            return _imageService.GetAll();
        }

        // GET api/values/5
        public string Get(int id)
        {
            Image imageObj = _imageService.GetImage(id.ToString());

            if (imageObj == null)
                return "errormessage";
            return imageObj.name;

            return "value";
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
