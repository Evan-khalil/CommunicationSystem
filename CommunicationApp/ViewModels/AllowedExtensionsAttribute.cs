using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace CommunicationApp.ViewModels
{
    public class AllowedExtensionsAttribute : ValidationAttribute
    {
        private readonly string[] _extensions;
        public AllowedExtensionsAttribute(string[] extensions)
        {
            _extensions = extensions;
        }

        protected override ValidationResult IsValid(
            object value, ValidationContext validationContext)
        {
            long size = 0;
            if (value != null)
            {
                foreach (var file in (List<IFormFile>) value)
                {
                    if (file != null)
                    {
                        size += file.Length;
                        var extension = Path.GetExtension(file.FileName);
                        if (!_extensions.Contains(extension.ToLower()))
                        {
                            return new ValidationResult(GetErrorMessage());
                        }
                    }
                }

                if (size > 20971520)
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }
            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            return $"Endast dessa filer är tillåtna: .jpg, .png, .jpeg, .gif, .pdf, .doc, .docx, .ppt, .xlsx, .zip, .rar. Maxstorlek 20MB.";
        }
    }
}