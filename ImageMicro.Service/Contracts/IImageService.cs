using ImageMicro.Model;
using System.Collections.Generic;

namespace ImageMicro.Service.Contracts
{
    public interface IImageService
    {
        Image GetImage(string id);
        IEnumerable<Image> GetAll();
    }
}
