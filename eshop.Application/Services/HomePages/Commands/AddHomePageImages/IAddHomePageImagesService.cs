﻿using eshop.Common.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using eshop.Domain.Entities.HomePages;
using eshop.Application.Interfaces.Contexts;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace eshop.Application.Services.HomePages.Commands.AddHomePageImages
{
    public interface IAddHomePageImagesService
    {
        ResultDto Execute(RequestAddHomePageImagesDto requestAdd);
    }

    public class AddHomePageImagesService : IAddHomePageImagesService
    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;
        public AddHomePageImagesService(IDataBaseContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public ResultDto Execute(RequestAddHomePageImagesDto requestAdd)
        {
            if(requestAdd.file==null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "ابتدا تصویر را انتخاب کنید",
                };
            }
            var ResultUpload = UploadFile(requestAdd.file);

            HomePageImages HomePageImages1 = new HomePageImages()
            {
                Src = ResultUpload.FileNameAddress,
                Link = requestAdd.Link,
                ImageLocation = requestAdd.ImageLocation,
            };

            _context.HomePageImages.Add(HomePageImages1);
            _context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message="!",
            };



        }
        public UploadDto UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string Folder = $@"images\HomePages\adplacement\";
                var UploadRootFolder = Path.Combine(_environment.WebRootPath, Folder);
                if (!Directory.Exists(UploadRootFolder))
                {
                    Directory.CreateDirectory(UploadRootFolder);
                }

                if (file == null || file.Length == 0)
                {
                    return new UploadDto()
                    {
                        Status = false,
                        FileNameAddress = ""
                    };
                }
                string fileName = DateTime.Now.Ticks.ToString() + file.FileName;
                var filePath = Path.Combine(UploadRootFolder, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                return new UploadDto()
                {
                    FileNameAddress = Folder + fileName,
                    Status = true,
                };
            }
            return null;
        }

        public class UploadDto
        {
            public long Id { get; set; }
            public bool Status { get; set; }
            public string FileNameAddress { get; set; }

        }
    }

    public class RequestAddHomePageImagesDto
    {
        public IFormFile file { get; set; }
        public string Link { get; set; }
        public ImageLocation ImageLocation { get; set; }
    }
}
