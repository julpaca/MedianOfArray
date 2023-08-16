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
using System.Runtime;
using System.Diagnostics;

namespace CalculatingMedianOfArray
{
    public partial class MainForm
    {
        public void Greeting()
        {
            try
            {
                string greetingStatus = System.IO.File.ReadAllText("Cache.txt");
            }

            catch (FileNotFoundException ex)
            {
                string addMs = " Файл будет повторно создан со значением \"Greeting is enabled\".";
                MessageBox.Show(ex.Message + addMs);

                File.Create("Cache.txt").Close();
                using (StreamWriter streamWr = File.AppendText("Cache.txt"))
                {
                    streamWr.Write("Greeting is enabled");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                string greetingStatus = System.IO.File.ReadAllText("Cache.txt");

                if (greetingStatus.Contains("Greeting is enabled") && !greetingStatus.Contains("Work with files..."))
                {
                    MessageBox.Show("Работа #2, вариант 1, выполнила Науменко Юлия. Программа предназначена для поиска медианы массива из вещественных чисел. Массив вводит пользователь.\n\nПод медианой массива подразумевается ячейка массива, сумма элементов слева от которой минимально отличается от суммы элементов справа");
                    cbGreetingStatus.Checked = false;
                }

                if (greetingStatus.Contains("Greeting is disabled"))
                {
                    cbGreetingStatus.Checked = true;
                }
            }
        }

        private void CheckingCb(object sender, EventArgs e)
        {
            if (cbGreetingStatus.Checked == true)
                System.IO.File.WriteAllText("Cache.txt", "Greeting is disabled");
            if (cbGreetingStatus.Checked == false)
                System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cbGreetingStatus.Checked == true)
            {
                System.IO.File.WriteAllText("Cache.txt", "Greeting is disabled");
            }

            if (cbGreetingStatus.Checked == false)
            {
                System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
            }
        }
    }
}