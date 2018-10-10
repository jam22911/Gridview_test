using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Repositories;

namespace Web
{
    public partial class Listdb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindData();
            }
        }

        void bindData()
        {
            Repository movieRepo = new Repository();
            gvdb.DataSource = movieRepo.getList();
            gvdb.DataBind();
        }
    }
}