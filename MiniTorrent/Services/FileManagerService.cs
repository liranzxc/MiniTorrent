using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiniTorrent.Models;

namespace MiniTorrent.Services
{
    public class FileManagerService
    {
        internal bool Valid(string username, string password)
        {
            //throw new NotImplementedException();
            return true;
        }

        internal void UpdateListFiles(string username, string password, List<MyFile> lstFiles)
        {
            //throw new NotImplementedException();
        }

        internal FileFinderObject FindFile(MyFile file)
        {
           // throw new NotImplementedException();

            return  new FileFinderObject { size = 45, ManyUser = 34 };
        }
    }
}