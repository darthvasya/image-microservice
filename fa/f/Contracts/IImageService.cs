using ImageMicro.Model;

namespace ImageMicro.Service.Contracts
{
    public interface IImageService
    {
        Image GetImage(string id);
    }
}
