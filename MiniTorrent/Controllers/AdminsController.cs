using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MiniTorrent.Models;

namespace MiniTorrent.Controllers
{
    public class AdminsController : ApiController
    {
        private MiniTorrentContext db = new MiniTorrentContext();

        // GET: api/Admins
        public IQueryable<User> GetUsers()
        {
            return db.Users;
        }

        // GET: api/Admins/5
        [ResponseType(typeof(User))]
        public IHttpActionResult GetUser(int id)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        // PUT: api/Admins/5
        [ResponseType(typeof(void))]
        public IHttpActionResult RegisterUser(int id, User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.Id)
            {
                return BadRequest();
            }

            db.Entry(user).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Admins
        [ResponseType(typeof(User))]
        public IHttpActionResult PostUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Users.Add(user);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = user.Id }, user);
        }

        // DELETE: api/Admins/5
        [ResponseType(typeof(User))]
        public IHttpActionResult DeleteUser(int id)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            db.Users.Remove(user);
            db.SaveChanges();

            return Ok(user);
        }
        public IHttpActionResult ShowAllFiles()
        {
            var Files = db.Users.ToList().SelectMany(i => i.lstFiles).ToList();

            return Ok(Files);

            //for (int i=0;i<db.Users.Count();i++)
            //{
                
            //    for (int j = 0; i < db.Users.ElementAt(i).lstFiles.Count(); j++)
            //    {
            //        files.Add(db.Users.ElementAt(i).lstFiles.ElementAt(j));
            //    }


            //}

            //return Ok(files);
        }
        public IHttpActionResult ShowAllActiveUsers()
        {
            List<User> users = new List<User>();
            for (int i = 0; i < db.Users.Count(); i++)
            {
                if (db.Users.ElementAt(i).active==true)
                {
                    users.Add(db.Users.ElementAt(i));
                }

            }

            return Ok(users);
        }
        public IHttpActionResult disableUser(int id)
        {
            db.Users.ElementAt(id).active = false;
            return Ok();
        }
        public IHttpActionResult enableUser(int id)
        {
            db.Users.ElementAt(id).active = true;
            return Ok();
        }
        public IHttpActionResult UpdateUserName(int id,string username)
        {
            db.Users.ElementAt(id).username = username;
            return Ok();
        }
        public IHttpActionResult UpdatePassword(int id, string password)
        {
            db.Users.ElementAt(id).password = password;
            return Ok();
        }
        public IHttpActionResult UpdateStatus(int id, Boolean status)
        {
            db.Users.ElementAt(id).active = status;
            return Ok();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserExists(int id)
        {
            return db.Users.Count(e => e.Id == id) > 0;
        }
    }
}