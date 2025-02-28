using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5_Tinhgiaithuaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tinh_Click(object sender, EventArgs e)
        {
           
            int so = Convert.ToInt32(txtSo.Text);
            int giaithua = 1;

            for (int i = 1; i <= so; i++)
            {
                giaithua = giaithua * i;
            }    
            txtKq.Text = giaithua.ToString();   
            
        }

        private void trbSo_Scroll(object sender, EventArgs e)
        {
            txtSo.Text = trbSo.Value.ToString();
            int so = Convert.ToInt32(txtSo.Text);
            int giaithua = 1;

            for (int i = 1; i <= so; i++)
            {
                giaithua = giaithua * i;
            }
            txtKq.Text = giaithua.ToString();

        }
    }
}
