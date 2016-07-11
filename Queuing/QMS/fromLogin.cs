using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QMS
{
    public partial class fromLogin : Form
    {
        public fromLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.Gray,
                                                                       Color.Green,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
        private void fromLogin_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text=="admin" && txtPassword.Text =="admin")
            {
                Dashboard DA = new Dashboard();
                DA.Show();
            }
        }
    }
}
