using ImageMicro.Model;
using System.Collections.Generic;

namespace ImageMicro.Service.Contracts
{
    public interface IImageService
    {
        Image GetImage(int id);
        Image AddImage(Image image);
        IEnumerable<Image> GetAll();
        
    }
}
