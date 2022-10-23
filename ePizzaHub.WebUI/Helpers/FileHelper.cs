using ePizzaHub.WebUI.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ePizzaHub.WebUI.Helpers
{
    public class FileHelper : IFileHelper
    {
        IWebHostEnvironment _env;

        public FileHelper(IWebHostEnvironment env)
        {
            _env = env;
        }

        private string GenerateFileName(string fileName)
        {
            string[] strName = fileName.Split(".");
            string strFileName = DateTime.Now.ToUniversalTime().ToString("yyyyMMdd\\THHmmssfff") + "." + strName[strName.Length - 1]; 
            return strFileName;
        }
        public void DeleteFile(string ImageUrl)
        {
            if(File.Exists(_env.WebRootPath + ImageUrl))
            {
                File.Delete(_env.WebRootPath + ImageUrl);
            }
          
        }

        public string UploadFile(IFormFile file)
        {
            var uploads = Path.Combine(_env.WebRootPath, "images");
            bool exists = Directory.Exists(uploads);
            if (!exists)
                Directory.CreateDirectory(uploads);

            var fileName = GenerateFileName(file.FileName);
            var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create);
            file.CopyToAsync(fileStream);
            return "/images/" + fileName;

        }
 
    }
}
