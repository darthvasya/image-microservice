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
                        IImageRepository userRepository)
        {
            this._unitOfWork = unitOfWork;
            this._imageRepository = userRepository;
        }

        public Image GetImage(string id)
        {
            Image imageObj = _imageRepository.GetById(id);

            if (imageObj == null)
                return null;
            return imageObj;
        }

        public IEnumerable<Image> GetAll()
        {
            IEnumerable<Image> list = _imageRepository.GetAll();

            return list;
        }
    }
}
