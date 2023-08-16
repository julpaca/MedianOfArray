using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace CalculatingMedianOfArray
{
    public partial class MainForm : Form
    {
        Array array = new Array();
        bool canArrayBeSaved = false;
        bool canResultBeSaved = false;

        public MainForm(Array arr, bool canArrSave, bool canResSave)
        {
            InitializeComponent();
            Greeting();

            array = arr;
            canArrayBeSaved = canArrSave;
            canResultBeSaved = canResSave;

            try
            {
                foreach (double elem in array.Arr)
                {
                    tbArray.Text += Convert.ToString(elem) + " ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox objTb = (TextBox)sender;
            string txt = objTb.Text;
            //bool isDigit = int.TryParse(txt, out int n);
            try
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;

                if (e.KeyChar == '-') return;

                if (e.KeyChar == ',') return;

                if ((e.KeyChar == (char)Keys.Back)) return;

                if ((e.KeyChar == (char)Keys.Space)) return;

                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnFindMedian_Click(object sender, EventArgs e)
        {
            array.Arr = array.ConvertArrayInTb(tbArray.Text);
            tbMedian.Text = Convert.ToString(array.FindingOfMedian());
        }

        private void btnGoToFileForm_Click(object sender, EventArgs e)
        {
            canArrayBeSaved = false;
            canResultBeSaved = false;

            if (array.isTbNotEmpty(tbArray.Text) == true)
            {
                array.Arr = array.ConvertArrayInTb(tbArray.Text);
                canArrayBeSaved = true;

                if (array.isTbNotEmpty(tbMedian.Text) == true)
                {
                    canResultBeSaved = true;
                }
            }
            
            CheckingCb(sender, e);
            File.AppendAllText("Cache.txt", "\n\nWork with files...");
            MainForm.ActiveForm.Hide();
            FileForm fileWork = new FileForm(array, canArrayBeSaved, canResultBeSaved);
            fileWork.ShowDialog();
            Close();
        }
    }
}
