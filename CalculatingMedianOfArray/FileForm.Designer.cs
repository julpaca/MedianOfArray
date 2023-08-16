
namespace CalculatingMedianOfArray
{
    partial class FileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaveArray = new System.Windows.Forms.Button();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveArray
            // 
            this.btnSaveArray.Location = new System.Drawing.Point(36, 30);
            this.btnSaveArray.Name = "btnSaveArray";
            this.btnSaveArray.Size = new System.Drawing.Size(132, 60);
            this.btnSaveArray.TabIndex = 0;
            this.btnSaveArray.Text = "Сохранить исходный массив";
            this.btnSaveArray.UseVisualStyleBackColor = true;
            this.btnSaveArray.Click += new System.EventHandler(this.btnSaveArray_Click);
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Location = new System.Drawing.Point(36, 118);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(132, 60);
            this.btnSaveResult.TabIndex = 1;
            this.btnSaveResult.Text = "Сохранить результат";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(36, 205);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(132, 60);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Загрузить массив из файла";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(210, 118);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 60);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Вернуться";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 302);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnSaveResult);
            this.Controls.Add(this.btnSaveArray);
            this.Name = "FileForm";
            this.Text = "FileForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveArray;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnReturn;
    }
}