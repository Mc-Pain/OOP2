namespace OOP2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.First_textbox = new System.Windows.Forms.TextBox();
            this.Second_textbox = new System.Windows.Forms.TextBox();
            this.ElementsCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Extractbtn = new System.Windows.Forms.Button();
            this.Statelabel = new System.Windows.Forms.Label();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.Fwdbtn = new System.Windows.Forms.Button();
            this.descbtn = new System.Windows.Forms.Button();
            this.ascbtn = new System.Windows.Forms.Button();
            this.deldblbtn = new System.Windows.Forms.Button();
            this.countbtn = new System.Windows.Forms.Button();
            this.dumpbtn = new System.Windows.Forms.Button();
            this.restorebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первый элемент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Второй элемент";
            // 
            // First_textbox
            // 
            this.First_textbox.Location = new System.Drawing.Point(111, 13);
            this.First_textbox.Name = "First_textbox";
            this.First_textbox.Size = new System.Drawing.Size(100, 20);
            this.First_textbox.TabIndex = 2;
            // 
            // Second_textbox
            // 
            this.Second_textbox.Location = new System.Drawing.Point(111, 39);
            this.Second_textbox.Name = "Second_textbox";
            this.Second_textbox.Size = new System.Drawing.Size(100, 20);
            this.Second_textbox.TabIndex = 3;
            // 
            // ElementsCombo
            // 
            this.ElementsCombo.FormattingEnabled = true;
            this.ElementsCombo.Location = new System.Drawing.Point(414, 13);
            this.ElementsCombo.Name = "ElementsCombo";
            this.ElementsCombo.Size = new System.Drawing.Size(121, 21);
            this.ElementsCombo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(217, 13);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(76, 23);
            this.Addbtn.TabIndex = 6;
            this.Addbtn.Text = "Добавить";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Extractbtn
            // 
            this.Extractbtn.Location = new System.Drawing.Point(332, 13);
            this.Extractbtn.Name = "Extractbtn";
            this.Extractbtn.Size = new System.Drawing.Size(76, 23);
            this.Extractbtn.TabIndex = 7;
            this.Extractbtn.Text = "Извлечь";
            this.Extractbtn.UseVisualStyleBackColor = true;
            this.Extractbtn.Click += new System.EventHandler(this.Extractbtn_Click);
            // 
            // Statelabel
            // 
            this.Statelabel.AutoSize = true;
            this.Statelabel.Location = new System.Drawing.Point(12, 62);
            this.Statelabel.Name = "Statelabel";
            this.Statelabel.Size = new System.Drawing.Size(42, 13);
            this.Statelabel.TabIndex = 8;
            this.Statelabel.Text = "Готово";
            // 
            // Searchbtn
            // 
            this.Searchbtn.Location = new System.Drawing.Point(217, 35);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(76, 23);
            this.Searchbtn.TabIndex = 9;
            this.Searchbtn.Text = "Поиск";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(332, 37);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(35, 23);
            this.Backbtn.TabIndex = 10;
            this.Backbtn.Text = "<<";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Fwdbtn
            // 
            this.Fwdbtn.Location = new System.Drawing.Point(373, 37);
            this.Fwdbtn.Name = "Fwdbtn";
            this.Fwdbtn.Size = new System.Drawing.Size(35, 23);
            this.Fwdbtn.TabIndex = 11;
            this.Fwdbtn.Text = ">>";
            this.Fwdbtn.UseVisualStyleBackColor = true;
            this.Fwdbtn.Click += new System.EventHandler(this.Fwdbtn_Click);
            // 
            // descbtn
            // 
            this.descbtn.Location = new System.Drawing.Point(413, 37);
            this.descbtn.Name = "descbtn";
            this.descbtn.Size = new System.Drawing.Size(58, 23);
            this.descbtn.TabIndex = 12;
            this.descbtn.Text = "DESC";
            this.descbtn.UseVisualStyleBackColor = true;
            this.descbtn.Click += new System.EventHandler(this.descbtn_Click);
            // 
            // ascbtn
            // 
            this.ascbtn.Location = new System.Drawing.Point(477, 37);
            this.ascbtn.Name = "ascbtn";
            this.ascbtn.Size = new System.Drawing.Size(58, 23);
            this.ascbtn.TabIndex = 13;
            this.ascbtn.Text = "ASC";
            this.ascbtn.UseVisualStyleBackColor = true;
            this.ascbtn.Click += new System.EventHandler(this.ascbtn_Click);
            // 
            // deldblbtn
            // 
            this.deldblbtn.Location = new System.Drawing.Point(332, 66);
            this.deldblbtn.Name = "deldblbtn";
            this.deldblbtn.Size = new System.Drawing.Size(203, 23);
            this.deldblbtn.TabIndex = 14;
            this.deldblbtn.Text = "Удалить дублирующиеся";
            this.deldblbtn.UseVisualStyleBackColor = true;
            this.deldblbtn.Click += new System.EventHandler(this.deldblbtn_Click);
            // 
            // countbtn
            // 
            this.countbtn.Location = new System.Drawing.Point(217, 57);
            this.countbtn.Name = "countbtn";
            this.countbtn.Size = new System.Drawing.Size(76, 23);
            this.countbtn.TabIndex = 15;
            this.countbtn.Text = "Посчитать";
            this.countbtn.UseVisualStyleBackColor = true;
            this.countbtn.Click += new System.EventHandler(this.countbtn_Click);
            // 
            // dumpbtn
            // 
            this.dumpbtn.Location = new System.Drawing.Point(332, 95);
            this.dumpbtn.Name = "dumpbtn";
            this.dumpbtn.Size = new System.Drawing.Size(100, 23);
            this.dumpbtn.TabIndex = 16;
            this.dumpbtn.Text = "Сохранить";
            this.dumpbtn.UseVisualStyleBackColor = true;
            this.dumpbtn.Click += new System.EventHandler(this.dumpbtn_Click);
            // 
            // restorebtn
            // 
            this.restorebtn.Location = new System.Drawing.Point(435, 95);
            this.restorebtn.Name = "restorebtn";
            this.restorebtn.Size = new System.Drawing.Size(100, 23);
            this.restorebtn.TabIndex = 17;
            this.restorebtn.Text = "Восстановить";
            this.restorebtn.UseVisualStyleBackColor = true;
            this.restorebtn.Click += new System.EventHandler(this.restorebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 262);
            this.Controls.Add(this.restorebtn);
            this.Controls.Add(this.dumpbtn);
            this.Controls.Add(this.countbtn);
            this.Controls.Add(this.deldblbtn);
            this.Controls.Add(this.ascbtn);
            this.Controls.Add(this.descbtn);
            this.Controls.Add(this.Fwdbtn);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Statelabel);
            this.Controls.Add(this.Extractbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ElementsCombo);
            this.Controls.Add(this.Second_textbox);
            this.Controls.Add(this.First_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox First_textbox;
        private System.Windows.Forms.TextBox Second_textbox;
        private System.Windows.Forms.ComboBox ElementsCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Extractbtn;
        private System.Windows.Forms.Label Statelabel;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button Fwdbtn;
        private System.Windows.Forms.Button descbtn;
        private System.Windows.Forms.Button ascbtn;
        private System.Windows.Forms.Button deldblbtn;
        private System.Windows.Forms.Button countbtn;
        private System.Windows.Forms.Button dumpbtn;
        private System.Windows.Forms.Button restorebtn;
    }
}

