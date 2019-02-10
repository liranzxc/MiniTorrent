using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiniTorrent.Models;
using MiniTorrent.DatabaseStub;

namespace MiniTorrent.Services
{
    public class FileManagerService
    {

        private Stub stub = new Stub();


        internal bool Valid(string username, string password)
        {
            //throw new NotImplementedException();
            List<User> lst = stub.getAllUser();
            
            return true;
        }
        internal bool ChangeStatus(string username, string password , String status)
        {
            //throw new NotImplementedException();

            // Change Status userStatus
            return true;
        }

        internal bool SignIn(string username, string password)
        {

            ChangeStatus(username, password, "ON");
            //throw new NotImplementedException();

            // Change Status userStatus
            return true;
        }

        internal bool SignOut(string username, string password)
        {
            //throw new NotImplementedException();

            ChangeStatus(username, password, "OFF");

            // Change Status userStatus
            return true;
        }

        internal void UpdateListFiles(string username, string password, List<MyFile> lstFiles)
        {
            //throw new NotImplementedException();
        }

        // return how many file owers and size 
        internal FileFinderObject FindFile(MyFile file)
        {
           // throw new NotImplementedException();

            return  new FileFinderObject { size = 45, ManyUser = 34 };
        }
    }
}