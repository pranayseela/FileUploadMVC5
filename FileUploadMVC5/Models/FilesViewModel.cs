
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FileUploadMVC5.Helpers;
namespace FileUploadMVC5.Models
{
    public class FilesViewModel
    {
        public ViewDataUploadFilesResult[] Files { get; set; }
    }
}