using ImageMicro.Model;
using System.Collections.Generic;

namespace ImageMicro.Service.Contracts
{
    public interface IImageService
    {
        Image GetImage(int id);
        IEnumerable<Image> GetAll();
    }
}
