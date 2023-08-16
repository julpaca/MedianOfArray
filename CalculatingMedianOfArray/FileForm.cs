using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatingMedianOfArray
{
    public partial class FileForm : Form
    {
        //List <double> array = default;
        Array array = new Array();
        bool canArrayBeSaved = false;
        bool canResultBeSaved = false;

        public FileForm(Array arr, bool canArrSave, bool canResSave)
        {
            InitializeComponent();
            array = arr;
            canArrayBeSaved = canArrSave;
            canResultBeSaved = canResSave;
            if (canArrayBeSaved == false)
            {
                MessageBox.Show("Данные о массиве не были получены, поэтому функции сохранения будут отключены.", "Упс!");
                btnSaveArray.Enabled = false;
                btnSaveResult.Enabled = false;
            }

            else if (canResultBeSaved == false)
            {
                MessageBox.Show("Данные о медиане массива не были получены, поэтому функция сохранения результатов будет отключена.", "Упс!");
                btnSaveResult.Enabled = false;
            }
            /*else
                array = arr;*/
        }

        private void btnSaveArray_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            //List<double> _doubleArray = array.Arr;
            fileDialog.Filter = "*.txt|*.txt";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(File.Create(fileDialog.FileName));

                for (int i = 0; i < array.Arr.Count(); i++)
                {
                    writer.Write(array.Arr[i] + " ");
                }
                writer.Dispose();

                MessageBox.Show("Данные успешно сохранены.", "Поздравляю!");
                writer.Close();
            }
            GC.Collect();
        }
        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "*.txt|*.txt";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(File.Create(fileDialog.FileName));

                writer.Write("Массив, в котором ищется медиана: ");
                for (int i = 0; i < array.Arr.Count(); i++)
                {
                    writer.Write(array.Arr[i] + " ");
                }
                writer.WriteLine();
                writer.WriteLine();
                writer.Write("Медиана массива (номер ячейки массива): ");
                writer.Write(array.Median);
                writer.Dispose();

                MessageBox.Show("Данные успешно сохранены.", "Поздравляю!");
                writer.Close();
            }
            GC.Collect();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            bool lenExeption = false;
            Stream myStream = null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string file = openFile.FileName;
                    if (!file.Contains(".txt"))
                    {
                        MessageBox.Show("Файл недопустимого типа.", "Упс!");
                        openFile.ShowDialog();
                    }

                    if ((myStream = openFile.OpenFile()) != null)
                    {
                        using (StreamReader fileReader = new StreamReader(openFile.FileName))
                        {
                            string[] values = fileReader.ReadToEnd().Split(' ');

                            if (values.Contains(""))
                                values = values.Take(values.Count() - 1).ToArray();

                            for (int i = 0; i < values.Length - 1; i++)
                            {
                                array.Arr.Add(i);
                                //inputData = Convert.ToDouble(values[i]);
                            }

                            FileForm.ActiveForm.Hide();
                            MessageBox.Show("Данные были успешно загружены.", "Поздравляю!");
                            MainForm mainForm = new MainForm(array, canArrayBeSaved, canResultBeSaved);
                            mainForm.ShowDialog();
                            Close();
                        }
                    }

                }

                catch (Exception ex)
                {
                    if (lenExeption == false)
                        MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            FileForm.ActiveForm.Hide();
            MainForm MainForm = new MainForm(array, canArrayBeSaved, canResultBeSaved);
            MainForm.ShowDialog();
            Close();
        }
        private void FileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string greetingStatus = System.IO.File.ReadAllText("Cache.txt");
            if (greetingStatus.Contains("Work with files...") && greetingStatus.Contains("Greeting is enabled"))
            {
                System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
            }
            else if (greetingStatus.Contains("Work with files...") && greetingStatus.Contains("Greeting is disabled"))
            {
                System.IO.File.WriteAllText("Cache.txt", "Greeting is disabled");
            }
            else if (greetingStatus.Contains("Work with files..."))
            {
                System.IO.File.WriteAllText("Cache.txt", "Greeting is enabled");
            }
        }
    }
}
