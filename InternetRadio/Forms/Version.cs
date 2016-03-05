using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using InternetRadio.Engine;

namespace MIr
{
    public partial class VersionForm : Form
    {
        public VersionForm()
        {
            InitializeComponent();
        }
       // ListBox Date = new ListBox();
       // ListBox Change = new ListBox();
        ListBox VersionL = new ListBox();
        ListBox Date = new ListBox();
        ListBox Changes = new ListBox();

        private void VersionFormLoad(object sender, EventArgs e)
        {
            dtAddDate.MaxDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            dtDate.MaxDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            dtDate.MinDate = Convert.ToDateTime("22.11.2011");
            dtAddDate.Value = Convert.ToDateTime( DateTime.Now.ToShortDateString());
            lCurVer.Text = ProductVersion;
            lbVersion.Items.Clear();
            var tempStr = "";
            VersionHelper.LoadVersion(out VersionL, out Date, out Changes);
            foreach (string VARIABLE in VersionL.Items )
            {
                lbVersion.Items.Add(VARIABLE);
                if(VARIABLE==ProductVersion)
                {
                    tempStr = VARIABLE.ToString();
                }

            }

            lbVersion.SelectedItem = tempStr;
         //   string[] tempStrVer = null;
          //  string st= ProductVersion.Last().ToString();
         //   st = (Convert.ToInt32(st) + 1).ToString();
            var curVer = ProductVersion;

            string stVerNew = curVer.Remove(ProductVersion.Length - 1, 1).Insert(ProductVersion.Length-1,
                                                                                 (Convert.ToInt32(ProductVersion.Last().ToString()) + 1).ToString());
            



            tbAddVer.Text = stVerNew;
           
            // tbAddVer.Text = tbAddVer.Text.Where(tbAddVer.Text.ToArray()[(int)tbAddVer.Text.Length]+=1);// .ToArray().Where()[(int)tbAddVer.Text.Length].ToString();




        }

          
        private void LbVersionSelectedValueChanged(object sender, EventArgs e)
        {
           
              dtDate.Value = Convert.ToDateTime(Date.Items[lbVersion.SelectedIndex]);
            tbChanges.Text = Changes.Items[lbVersion.SelectedIndex].ToString();
           

        }

        private void bAddVersion_Click(object sender, EventArgs e)
        {

            if (tbAddChanges.Text != null && tbAddChanges.Text.Length>3)
            {
                char[] s = tbAddVer.Text.ToCharArray();
                for (int i = 0; i < tbAddVer.Text.Length; i++)
                {
                    if (s[i] == Convert.ToChar(","))
                    {
                        s[i] = Convert.ToChar(".");
                    }

                }
                string stmp = "";
                foreach (char c in s)
                {
                    stmp += c.ToString();

                }

                VersionL.Items.Add(stmp);
                Date.Items.Add(dtAddDate.Value.ToShortDateString());
                Changes.Items.Add(tbAddChanges.Text);
                VersionHelper.AddVersion(VersionL, Date, Changes);
                tbAddChanges.Text = null;
                MessageBox.Show(bAddVersion, "Версия добавлена, измени версию в проэкте!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VersionFormLoad(sender, e);
            }
            else
            { MessageBox.Show(bAddVersion,"Информация не добавлена. В описании меньше 3 символов, или что не так", "Что-то не так!",MessageBoxButtons.OK,MessageBoxIcon.Error);}


        }

        private void tbAddVer_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

       

        private void VersionForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void VersionForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                MessageBox.Show("", "");
            }
        }

        private void VersionForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                MessageBox.Show("", "");
            }
        }

        
    }
}