
namespace CalculatingMedianOfArray
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbArray = new System.Windows.Forms.TextBox();
            this.labelDescriptionOfEnter = new System.Windows.Forms.Label();
            this.btnFindMedian = new System.Windows.Forms.Button();
            this.btnModuleTests = new System.Windows.Forms.Button();
            this.btnGoToFileForm = new System.Windows.Forms.Button();
            this.cbGreetingStatus = new System.Windows.Forms.CheckBox();
            this.tbMedian = new System.Windows.Forms.TextBox();
            this.labelAboutResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbArray
            // 
            this.tbArray.Location = new System.Drawing.Point(23, 161);
            this.tbArray.Name = "tbArray";
            this.tbArray.Size = new System.Drawing.Size(384, 20);
            this.tbArray.TabIndex = 0;
            this.tbArray.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // labelDescriptionOfEnter
            // 
            this.labelDescriptionOfEnter.AutoSize = true;
            this.labelDescriptionOfEnter.Location = new System.Drawing.Point(20, 130);
            this.labelDescriptionOfEnter.Name = "labelDescriptionOfEnter";
            this.labelDescriptionOfEnter.Size = new System.Drawing.Size(387, 13);
            this.labelDescriptionOfEnter.TabIndex = 1;
            this.labelDescriptionOfEnter.Text = "Введите элементы массива. Элементы должны быть отделены пробелом.";
            // 
            // btnFindMedian
            // 
            this.btnFindMedian.Location = new System.Drawing.Point(23, 212);
            this.btnFindMedian.Name = "btnFindMedian";
            this.btnFindMedian.Size = new System.Drawing.Size(117, 44);
            this.btnFindMedian.TabIndex = 2;
            this.btnFindMedian.Text = "Найти медиану";
            this.btnFindMedian.UseVisualStyleBackColor = true;
            this.btnFindMedian.Click += new System.EventHandler(this.btnFindMedian_Click);
            // 
            // btnModuleTests
            // 
            this.btnModuleTests.Location = new System.Drawing.Point(164, 212);
            this.btnModuleTests.Name = "btnModuleTests";
            this.btnModuleTests.Size = new System.Drawing.Size(125, 44);
            this.btnModuleTests.TabIndex = 3;
            this.btnModuleTests.Text = "Модульные тесты";
            this.btnModuleTests.UseVisualStyleBackColor = true;
            // 
            // btnGoToFileForm
            // 
            this.btnGoToFileForm.Location = new System.Drawing.Point(319, 212);
            this.btnGoToFileForm.Name = "btnGoToFileForm";
            this.btnGoToFileForm.Size = new System.Drawing.Size(125, 44);
            this.btnGoToFileForm.TabIndex = 4;
            this.btnGoToFileForm.Text = "Работа с файлами";
            this.btnGoToFileForm.UseVisualStyleBackColor = true;
            this.btnGoToFileForm.Click += new System.EventHandler(this.btnGoToFileForm_Click);
            // 
            // cbGreetingStatus
            // 
            this.cbGreetingStatus.AutoSize = true;
            this.cbGreetingStatus.Location = new System.Drawing.Point(23, 318);
            this.cbGreetingStatus.Name = "cbGreetingStatus";
            this.cbGreetingStatus.Size = new System.Drawing.Size(130, 17);
            this.cbGreetingStatus.TabIndex = 5;
            this.cbGreetingStatus.Text = "Убрать приветствие";
            this.cbGreetingStatus.UseVisualStyleBackColor = true;
            // 
            // tbMedian
            // 
            this.tbMedian.Location = new System.Drawing.Point(527, 161);
            this.tbMedian.Name = "tbMedian";
            this.tbMedian.Size = new System.Drawing.Size(45, 20);
            this.tbMedian.TabIndex = 6;
            // 
            // labelAboutResults
            // 
            this.labelAboutResults.AutoSize = true;
            this.labelAboutResults.Location = new System.Drawing.Point(524, 130);
            this.labelAboutResults.Name = "labelAboutResults";
            this.labelAboutResults.Size = new System.Drawing.Size(244, 13);
            this.labelAboutResults.TabIndex = 7;
            this.labelAboutResults.Text = "Медиана введённого массива (ячейка) равна: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.labelAboutResults);
            this.Controls.Add(this.tbMedian);
            this.Controls.Add(this.cbGreetingStatus);
            this.Controls.Add(this.btnGoToFileForm);
            this.Controls.Add(this.btnModuleTests);
            this.Controls.Add(this.btnFindMedian);
            this.Controls.Add(this.labelDescriptionOfEnter);
            this.Controls.Add(this.tbArray);
            this.Name = "MainForm";
            this.Text = "Поиск медианы массива";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbArray;
        private System.Windows.Forms.Label labelDescriptionOfEnter;
        private System.Windows.Forms.Button btnFindMedian;
        private System.Windows.Forms.Button btnModuleTests;
        private System.Windows.Forms.Button btnGoToFileForm;
        private System.Windows.Forms.CheckBox cbGreetingStatus;
        private System.Windows.Forms.TextBox tbMedian;
        private System.Windows.Forms.Label labelAboutResults;
    }
}

