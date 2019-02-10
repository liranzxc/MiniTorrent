using MiniTorrent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniTorrent.DatabaseStub
{
    public class Stub
    {
        public User[] users;

        public Stub()
        {
            init();
        }

        private void init()
        {
            users = new User[]
            {
            new User { username = "liranzxc", password = "liran123", lstFiles = { new MyFile {name="file1",size=34 }} },
             new User { username = "avivzxc", password = "liran123", lstFiles = { new MyFile {name="file2",size=32 }} },
              new User { username = "sapirzxc", password = "liran123", lstFiles = { new MyFile {name="file3",size=33 }, new MyFile { name = "file1", size = 34 } } }
              };

        }

        public List<User> getAllUser()
        {
            return this.users.ToList();
        }
    }
}