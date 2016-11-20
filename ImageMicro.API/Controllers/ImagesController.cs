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
    public class ImagesController : ApiController
    {
        private IImageService _imageService;
        public ImagesController(IImageService image)
        {
            _imageService = image;
        }

        // GET api/<controller>
        public IEnumerable<Image> Get()
        {
            return _imageService.GetAll();
        }

        // GET api/<controller>/5
        public Image Get(int id)
        {
            Image image = _imageService.GetImage(id);

            if (image == null)
                return null;
            return image;
        }

        // POST api/<controller>

        //accept: application/json
        //content-type: application/json
        public Empty Post([FromBody]Empty value)
        {
            return value;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}