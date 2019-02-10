using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniTorrent.Models
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        //public string IP { get; set; }
        //public int port { get; set; }
        //public string PublicPath { get; set; }
        //public string DownloadPath { get; set; }
        //public string Status { get; set; }
        public List<MyFile> lstFiles { get; set; }

    }
}