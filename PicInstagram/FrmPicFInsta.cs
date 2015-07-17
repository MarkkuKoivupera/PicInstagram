using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using HttpReq;

namespace PicInstagram
{
    public partial class Frm_PicsInst : Form
    {
        public Frm_PicsInst()
        {
            InitializeComponent();
        }

        private void TSBtn_open_Click(object sender, EventArgs e)
        {
            HttpReq LueHttp = new HttpReq();
            String EkaSivu= LueHttp.read_Address(TSText_Address.Text);
        }
    }
}
