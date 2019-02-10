﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniTorrent.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }


        public string username { get; set; }
        public string password { get; set; }
        public string IP { get; set; }
        public string port { get; set; }
        public string PublicPath { get; set; }
        public string DownloadPath { get; set; }
        public Boolean active { get; set; }
        public List<MyFile> lstFiles { get; set; }

    }
}