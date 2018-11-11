using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Init(object sender, EventArgs e)
    {
        


    }
    protected void Page_Load(object sender, EventArgs e)
    {
        RequiredFieldValidator _re = new RequiredFieldValidator();
        _re.ID = "test";
         _re.ControlToValidate = txtRoll.ID;
        //_re.EnableClientScript = true;
        _re.ErrorMessage = "This is not...";
        form1.Controls.Add(_re);
      
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       
         StudentInfo _objStudentInfo = new StudentInfo(Int32.Parse( txtRoll.Text) ,txtUserName.Text);
        Session["objStudentInfo"] = _objStudentInfo;
        ResetField();
    }
    protected void btnRestore_Click(object sender, EventArgs e)
    {
        StudentInfo _objStudentInfo = (StudentInfo) Session["objStudentInfo"];
        txtRoll.Text = _objStudentInfo.Roll.ToString();
        txtUserName.Text = _objStudentInfo.Name;
        
    }
    public void ResetField()
    {
        txtRoll.Text = "";
        txtUserName.Text = "";
    }
}
