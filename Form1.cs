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
            Stappel<int> lijstint = new Stappel<int>();
            Stappel<string> lijstString = new Stappel<string>();
            Stappel<Persoon> lijstPersoon = new Stappel<Persoon>();
            

        
        public Form1()
        {
            InitializeComponent();
        }

        private void btAddInt_Click(object sender, EventArgs e)
        {
            int cijfer = int.Parse(tbInt.Text);

            lijstint.addLijst(cijfer); 
           
        }

        private void btRemoveInt_Click(object sender, EventArgs e)
        {
            lijstint.RemoveLijst();
        }

        private void btDeleteInt_Click(object sender, EventArgs e)
        {
            lijstint.Delete(int.Parse(tbInt.Text));
        }

        private void btToStringInt_Click(object sender, EventArgs e)
        {
            lijstint.ToString();

            tbAnswer.Text = tbInt.ToString();
        }

        private void btIsAanwezigInt_Click(object sender, EventArgs e)
        {
            if(lijstint.isAanwezig(int.Parse(tbInt.Text)) == true)
            {
                MessageBox.Show("het cijfer " + tbInt.Text + "= true");
            }
            else
            {
                MessageBox.Show("het cijfer " + tbInt.Text + "= false");
            }  
        }

        private void btAddString_Click(object sender, EventArgs e)
        {
            String woord = tbString.Text;

            lijstString.addLijst(woord);
        }

        private void btRemoveString_Click(object sender, EventArgs e)
        {
            lijstString.RemoveLijst();
        }

        private void btDeleteAllString_Click(object sender, EventArgs e)
        {
            lijstString.Delete(tbString.Text);
        }

        private void btShowString_Click(object sender, EventArgs e)
        {
            lijstString.ToString();
            tbAnswer.Text = tbString.ToString();
        }

        private void btIsAanwezigString_Click(object sender, EventArgs e)
        {
            if (lijstString.isAanwezig(tbString.Text) == true)
            {
                MessageBox.Show("de woord " + tbString.Text + "= true");
            }
            else
            {
                MessageBox.Show("de woord " + tbString.Text + "= false");
            }
        }

        private void btAddKleine_Click(object sender, EventArgs e)
        {
            Persoon persoon = new Persoon(tbKleine.Text);
            lijstPersoon.addLijst(persoon);
        }

        private void btRemoveKleine_Click(object sender, EventArgs e)
        {
            lijstPersoon.RemoveLijst();
        }

        private void btDeleteallKleine_Click(object sender, EventArgs e)
        {
            /*lijstPersoon.Delete(lijstPersoon));*/
        }

        private void btShowKleine_Click(object sender, EventArgs e)
        {
            lijstPersoon.ToString();

            tbAnswer.Text = tbKleine.ToString();
        }

        private void btPresentKleine_Click(object sender, EventArgs e)
        {
            if (lijstint.isAanwezig(int.Parse(tbInt.Text)) == true)
            {
                MessageBox.Show("het Persoon " + tbKleine.Text + "= true");
            }
            else
            {
                MessageBox.Show("het Persoon " + tbKleine.Text + "= false");
            }
        }

        private void btCopyInt_Click(object sender, EventArgs e)
        {
            /*lijstint.Copy();*/
            // de copy function wilt niet werken
        }

        private void btCopyString_Click(object sender, EventArgs e)
        {

        }

        private void btCopyKleine_Click(object sender, EventArgs e)
        {

        }
    }
}
