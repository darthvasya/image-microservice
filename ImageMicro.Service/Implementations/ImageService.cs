using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ImageMicro.Model;
using ImageMicro.Repository;
using ImageMicro.DAL.Contracts;
using ImageMicro.Service.Contracts;

namespace ImageMicro.Service.Implementations
{
    public class ImageService : IImageService
    {
        IUnitOfWork _unitOfWork;
        IImageRepository _imageRepository;

        public ImageService(
                        IUnitOfWork unitOfWork,
                        IImageRepository imageRepository)
        {
            this._unitOfWork = unitOfWork;
            this._imageRepository = imageRepository;
        }

        public Image GetImage(int id)
        {
            try
            {
                Image imageObj = _imageRepository.GetById(id);

                if (imageObj == null)
                    return null;
                return imageObj;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public IEnumerable<Image> GetAll()
        {
            try
            {
                IEnumerable<Image> list = _imageRepository.GetAll();

                return list;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public Image AddImage(Image image)
        {
            if (image == null)
                return null;
            _imageRepository.Add(image);
            return image;
        }
    }
}
