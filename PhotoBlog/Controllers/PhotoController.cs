using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PhotoBlog.Services;
using PhotoBlog.Models;

namespace PhotoBlog.Controllers
{
    public class PhotoController : ApiController
    {
        IPhotoEntryService _photoService;

        public PhotoController()
        {
            _photoService = new PhotoEntryService();
        }

        public IEnumerable<PhotoEntry> Get()
        {
            return _photoService.GetAllPhotoEntries();
        }

        // GET api/photo/5
        //public PhotoEntry Get(int id)
        //{
        //    return "value";
        //}

        
    }
}
