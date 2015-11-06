using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateRole : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadDropDown();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!Roles.RoleExists(TextBox1.Text))
        {
            Roles.CreateRole(TextBox1.Text);
            Label1.Text = "Role has been created";
        }
        else
        {
            Label1.Text = "Role already Exist";
        }
        loadDropDown();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string username = DropDownList1.SelectedItem.ToString();
        string rolename = DropDownList2.SelectedItem.ToString();

        if (!Roles.IsUserInRole(username, rolename))
        {
            Roles.AddUserToRole(username, rolename);
            Label1.Text = "User Added in Role";
        }
        else
        {
            Label1.Text = "User already Exist  in this Role";
        }

    }

    void loadDropDown()
    {
        DropDownList1.Items.Clear();
        DropDownList2.Items.Clear();
         MembershipUserCollection CurrentUser= Membership.GetAllUsers();
     foreach (MembershipUser mu in CurrentUser)
     {
         DropDownList1.Items.Add(mu.UserName);
     }


     string[] currentRoles= Roles.GetAllRoles();
     foreach (string role in currentRoles)
     {
         DropDownList2.Items.Add(role);
     }
    

    }
}