using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        List<string> lijst = new List<string>();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            

            lijst.Add(tbList.Text);

            string s = String.Join(",", lijst);

            MessageBox.Show(s.ToString());
        }
    }
}
