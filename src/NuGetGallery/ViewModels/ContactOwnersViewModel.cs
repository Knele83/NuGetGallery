﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace NuGetGallery
{
    [Bind(Include = "Message")]
    public class ContactOwnersViewModel
    {
        public string PackageId { get; set; }

        public IEnumerable<User> Owners { get; set; }

        [AllowHtml]
        [Required(ErrorMessage = "Please enter a message.")]
        [StringLength(4000)]
        public string Message { get; set; }
    }
}