using MiniTorrent.Controllers;
using MiniTorrent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiniTorrent
{
    public partial class AdminView : System.Web.UI.Page
    {
        AdminsController adminController;
        protected void Page_Load(object sender, EventArgs e)
        {
            adminController = new AdminsController();
            List<MyFile> files = adminController.ShowAllFiles();
            lblAllFiles.Text = files.Count().ToString();
            List<User> users = adminController.ShowAllActiveUsers();
            lblActiveUsers.Text = users.Count().ToString();
        }

       
    }
}