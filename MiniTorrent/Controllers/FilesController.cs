using MiniTorrent.Models;
using MiniTorrent.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace MiniTorrent.Controllers
{
    
    public class FilesController : ApiController
    {
        private FileManagerService fileservice = new FileManagerService();

        [ActionName("SignIn")]
        [HttpPost]
        public IHttpActionResult SignIn([FromBody] User user)
        {
            if(fileservice.Valid(user.username, user.password))
            {
                fileservice.UpdateListFiles(user.username, user.password, user.lstFiles);
                fileservice.SignIn(user.username, user.password);
                // add user to database ! admin service 
                    return Ok(user.username + " Log in ");
            }
            else
            {
                return BadRequest("unvalid username");

            }
        }

        [ActionName("FindFile")]
        [HttpPost]
        public IHttpActionResult FindFile([FromBody] FileFinderObject args)
        {
           
            if (fileservice.Valid(args.user.username, args.user.password))
            {

                FileFinderObject Data = fileservice.FindFile(args.file); // Data : { size : ?? , How many users : ??}

                if(Data.ManyUser > 0 )
                {
                    return Ok(Data);
                }
                else
                {
                    return BadRequest("File not found");
                }
             
            }
            else
            {
                return BadRequest("unvalid username");

            }
        }


        [ActionName("SignOut")]
        [HttpPost]
        public IHttpActionResult SignOut([FromBody] User user)
        {
            fileservice.SignOut(user.username, user.password);
            return Ok(user.username + "Log Out");
        }


    }
}
