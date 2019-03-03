using System;
using System.Web;
using System.Web.UI;

namespace DomaciUASPNet
{

    public partial class Default : System.Web.UI.Page
    {
        public void button1Clicked(object sender, EventArgs args)
        {
			// Generate rows and cells.           
            int numrows = 3;
            int numcells = 2;
            for (int j = 0; j < numrows; j++)
            {
                TableRow r = new TableRow();
                for (int i = 0; i < numcells; i++)
                {
                    TableCell c = new TableCell();
                    c.Controls.Add(new LiteralControl("row "
                        + j.ToString() + ", cell " + i.ToString()));
                    r.Cells.Add(c);
                }
                Table1.Rows.Add(r);
            }
		}
    }
}
