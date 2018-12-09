using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntitySelfreferencingDF
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeDBContext db = new EmployeeDBContext();
            GridView1.DataSource = db.Employees5.Select(emp => new { EmployeeName = emp.EmployeeName, MamagerName = emp.Manager.EmployeeName == null ? "Super Boss" :emp.Manager.EmployeeName }).ToList();
            GridView1.DataBind();
        }
    }
}