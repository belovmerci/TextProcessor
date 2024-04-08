namespace TextProcessor
{
    partial class TextProcessor
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
            this.ChooseFilesButton = new System.Windows.Forms.Button();
            this.SaveFilesButton = new System.Windows.Forms.Button();
            this.DeleteAboveCheckbox = new System.Windows.Forms.CheckBox();
            this.DeletePunctuationCheckbox = new System.Windows.Forms.CheckBox();
            this.NumberOfFiles = new System.Windows.Forms.Label();
            this.ChosenFilesListBox = new System.Windows.Forms.ListBox();
            this.DeleteAboveTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChooseFilesButton
            // 
            this.ChooseFilesButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.ChooseFilesButton.Location = new System.Drawing.Point(13, 13);
            this.ChooseFilesButton.Name = "ChooseFilesButton";
            this.ChooseFilesButton.Size = new System.Drawing.Size(129, 55);
            this.ChooseFilesButton.TabIndex = 0;
            this.ChooseFilesButton.Text = "Выбрать файл(ы)";
            this.ChooseFilesButton.UseVisualStyleBackColor = true;
            // 
            // SaveFilesButton
            // 
            this.SaveFilesButton.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.SaveFilesButton.Location = new System.Drawing.Point(148, 12);
            this.SaveFilesButton.Name = "SaveFilesButton";
            this.SaveFilesButton.Size = new System.Drawing.Size(127, 56);
            this.SaveFilesButton.TabIndex = 1;
            this.SaveFilesButton.Text = "Сохранить файл(ы)";
            this.SaveFilesButton.UseVisualStyleBackColor = true;
            // 
            // DeleteAboveCheckbox
            // 
            this.DeleteAboveCheckbox.AutoSize = true;
            this.DeleteAboveCheckbox.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.DeleteAboveCheckbox.Location = new System.Drawing.Point(281, 17);
            this.DeleteAboveCheckbox.Name = "DeleteAboveCheckbox";
            this.DeleteAboveCheckbox.Size = new System.Drawing.Size(262, 25);
            this.DeleteAboveCheckbox.TabIndex = 2;
            this.DeleteAboveCheckbox.Text = "Удалить слова длиной менее:";
            this.DeleteAboveCheckbox.UseVisualStyleBackColor = true;
            // 
            // DeletePunctuationCheckbox
            // 
            this.DeletePunctuationCheckbox.AutoSize = true;
            this.DeletePunctuationCheckbox.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.DeletePunctuationCheckbox.Location = new System.Drawing.Point(281, 83);
            this.DeletePunctuationCheckbox.Name = "DeletePunctuationCheckbox";
            this.DeletePunctuationCheckbox.Size = new System.Drawing.Size(243, 25);
            this.DeletePunctuationCheckbox.TabIndex = 3;
            this.DeletePunctuationCheckbox.Text = "Удалить знаки препинания";
            this.DeletePunctuationCheckbox.UseVisualStyleBackColor = true;
            this.DeletePunctuationCheckbox.CheckedChanged += new System.EventHandler(this.deletePunctuationCheckbox_CheckedChanged);
            // 
            // NumberOfFiles
            // 
            this.NumberOfFiles.AutoSize = true;
            this.NumberOfFiles.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.NumberOfFiles.Location = new System.Drawing.Point(13, 71);
            this.NumberOfFiles.Name = "NumberOfFiles";
            this.NumberOfFiles.Size = new System.Drawing.Size(149, 21);
            this.NumberOfFiles.TabIndex = 4;
            this.NumberOfFiles.Text = "Number of Files: 0";
            // 
            // ChosenFilesListBox
            // 
            this.ChosenFilesListBox.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.ChosenFilesListBox.FormattingEnabled = true;
            this.ChosenFilesListBox.ItemHeight = 21;
            this.ChosenFilesListBox.Location = new System.Drawing.Point(16, 102);
            this.ChosenFilesListBox.Name = "ChosenFilesListBox";
            this.ChosenFilesListBox.Size = new System.Drawing.Size(259, 214);
            this.ChosenFilesListBox.TabIndex = 5;
            // 
            // DeleteAboveTextBox
            // 
            this.DeleteAboveTextBox.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.DeleteAboveTextBox.Location = new System.Drawing.Point(281, 48);
            this.DeleteAboveTextBox.Name = "DeleteAboveTextBox";
            this.DeleteAboveTextBox.Size = new System.Drawing.Size(281, 29);
            this.DeleteAboveTextBox.TabIndex = 6;
            this.DeleteAboveTextBox.TextChanged += new System.EventHandler(this.DeleteAboveTextBox_TextChanged);
            // 
            // TextProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 365);
            this.Controls.Add(this.DeleteAboveTextBox);
            this.Controls.Add(this.ChosenFilesListBox);
            this.Controls.Add(this.NumberOfFiles);
            this.Controls.Add(this.DeletePunctuationCheckbox);
            this.Controls.Add(this.DeleteAboveCheckbox);
            this.Controls.Add(this.SaveFilesButton);
            this.Controls.Add(this.ChooseFilesButton);
            this.Name = "TextProcessor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseFilesButton;
        private System.Windows.Forms.Button SaveFilesButton;
        private System.Windows.Forms.CheckBox DeleteAboveCheckbox;
        private System.Windows.Forms.CheckBox DeletePunctuationCheckbox;
        private System.Windows.Forms.Label NumberOfFiles;
        private System.Windows.Forms.ListBox ChosenFilesListBox;
        private System.Windows.Forms.TextBox DeleteAboveTextBox;
    }
}

