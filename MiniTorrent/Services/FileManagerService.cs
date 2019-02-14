﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MiniTorrent.Models;

namespace MiniTorrent.Services
{
    public class FileManagerService
    {

        private MiniTorrentContext db = new MiniTorrentContext();

        internal bool Valid(string username, string password)
        {
            //throw new NotImplementedException();

            List<User> users = db.Users.ToList();

            return (users
                .Where(user => user.username.Equals(username) && user.password.Equals(password))
                .Count() > 0);      
            
        }


        internal bool UpdateStatus(string username,string password, Boolean active)
        {

           User user = GetUser(username, password);
           user.active = active;
           db.Entry(user).State = EntityState.Modified;
           db.SaveChanges();

            return true;
          

        }

        internal bool SignIn(string username, string password)
        {

            UpdateStatus(username, password, true);
            //throw new NotImplementedException();

            // Change Status userStatus
            return true;
        }

        internal bool SignOut(string username, string password)
        {
            //throw new NotImplementedException();

            UpdateStatus(username, password, false);

            // Change Status userStatus
            return true;
        }

        internal void UpdateListFiles(string username, string password, List<MyFile> lstFiles_new)
        {
            User user = GetUser(username, password);

            List<MyFile> files = db.Files.Where(file => file.IdUser == user.Id).ToList();

            // delete all user files
            files.ForEach(f => db.Files.Remove(f));

            // add new files

            lstFiles_new.ForEach(f =>
            {
                f.IdUser = user.Id;

                db.Files.Add(f);


            });


            db.SaveChanges();





            //throw new NotImplementedException();
        }

        private User GetUser(string username , string password)
        {
            return db.Users.ToList().Single(user => user.username == username && user.password == password);
        }

        // return how many file owers and size 
        internal FileFinderObject FindFile(MyFile file)
        {
            List<MyFile> files = db.Files.ToList();

            int many = files.Where(f => f.name.Equals(file.name) && f.size == file.size).Count();
           
            return  new FileFinderObject { size = file.size, ManyUser = many };
        }
    }
}