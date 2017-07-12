using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using ValenciaSustainability.Models;

namespace ValenciaSustainability.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Ryan
                // Create a table in your database called user.
                //    It should have columns for username, password, firstname, lastname etc...
                //    This is where you will hold the users of your web application.
                // Create a method here to go to the database 
                //   and select the record from your user table which matches the username and password the user typed in
                //   for example:   select * from user where username = blah and password = blah
                //   as you can see below, if the user is null, show invalid password as below
                //   otherwise sign in and redirect as below
                //   you will also need to modify the page Register.aspx to give your users a place to create an account
                //   but do this part first.
                //   add accounts to your database and test that it works.
                
                var manager = new UserManager();
                var user = GetUserFromDatabase(UserName.Text, Password.Text);

                if (user != null)
                {
                    IdentityHelper.SignIn(manager, user, RememberMe.Checked);
                    IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                }
                else
                {
                    FailureText.Text = "Invalid username or password.";
                    ErrorMessage.Visible = true;
                }
            }
        }

        private ApplicationUser GetUserFromDatabase(string userNameText, string passwordText)
        {
            var user = new ApplicationUser();

            user.UserName = userNameText;

            // now go to the database and get a user
            // assign it to user if it's there

            return user;
        }
    }
}