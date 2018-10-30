using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Net;
using System.IO;

namespace MakeReport
{
    public partial class frm_update : Form
    {
        public frm_update()
        {
            InitializeComponent();
        }

        private void bt_load_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel.Workbook WB = new Microsoft.Office.Interop.Excel.Workbook();
            //Microsoft.Office.Interop.Excel.Worksheet WS = new Microsoft.Office.Interop.Excel.Worksheet();

            //WB = App.Workbooks.Open(txt_link.Text);

            WebClient client = new WebClient();
            client.UseDefaultCredentials = true;
            Stream stream = client.OpenRead(txt_link.Text);


        }
    }
}
