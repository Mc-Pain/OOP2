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
            this.Addbtn.Location = new System.Drawing.Point(217, 12);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 6;
            this.Addbtn.Text = "Добавить";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Extractbtn
            // 
            this.Extractbtn.Location = new System.Drawing.Point(333, 13);
            this.Extractbtn.Name = "Extractbtn";
            this.Extractbtn.Size = new System.Drawing.Size(75, 23);
            this.Extractbtn.TabIndex = 7;
            this.Extractbtn.Text = "Извлечь";
            this.Extractbtn.UseVisualStyleBackColor = true;
            // 
            // Statelabel
            // 
            this.Statelabel.AutoSize = true;
            this.Statelabel.Location = new System.Drawing.Point(108, 62);
            this.Statelabel.Name = "Statelabel";
            this.Statelabel.Size = new System.Drawing.Size(42, 13);
            this.Statelabel.TabIndex = 8;
            this.Statelabel.Text = "Готово";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 262);
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
    }
}

