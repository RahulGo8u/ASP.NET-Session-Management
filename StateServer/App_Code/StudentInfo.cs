using System;
using System.Data;
using System.Configuration;
using System.Web;

using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for StudentInfo
/// </summary>

[Serializable]
public class StudentInfo
{
    //Default Constructor
    public StudentInfo()
    {
       
    }
    /// <summary>
	/// Create object of student Class
	/// </summary>
	/// <param name="intRoll">Int RollNumber</param>
	/// <param name="strName">String Name</param>
    public StudentInfo(int intRoll, string strName)
	{
        this.Roll = intRoll;
        this.Name = strName;
	}

    private int intRoll;
    private string strName;
    public int Roll
    {
        get
        {
            return intRoll;
        }
        set
        {
            intRoll = value;
        }
    }

    public string Name
    {
        get
        {
            return strName;
        }
        set
        {
            strName = value;
        }
    }
}
