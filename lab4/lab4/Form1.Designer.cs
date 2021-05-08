
namespace lab4
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonAddLetter = new System.Windows.Forms.Button();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.textBoxLetter = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.textBoxTableSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLetter3 = new System.Windows.Forms.TextBox();
            this.textBoxLetter2 = new System.Windows.Forms.TextBox();
            this.buttonFind2 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFind3 = new System.Windows.Forms.TextBox();
            this.buttonAddN3 = new System.Windows.Forms.Button();
            this.buttonAddN1 = new System.Windows.Forms.Button();
            this.buttonFind3 = new System.Windows.Forms.Button();
            this.buttonAddN2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxOutput);
            this.splitContainer1.Size = new System.Drawing.Size(1106, 601);
            this.splitContainer1.SplitterDistance = 644;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonAddLetter);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxInput1);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxLetter);
            this.splitContainer2.Panel1.Controls.Add(this.buttonFind);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(642, 599);
            this.splitContainer2.SplitterDistance = 173;
            this.splitContainer2.TabIndex = 0;
            // 
            // buttonAddLetter
            // 
            this.buttonAddLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddLetter.Location = new System.Drawing.Point(469, 12);
            this.buttonAddLetter.Name = "buttonAddLetter";
            this.buttonAddLetter.Size = new System.Drawing.Size(163, 26);
            this.buttonAddLetter.TabIndex = 2;
            this.buttonAddLetter.Text = "Хешировать";
            this.buttonAddLetter.UseVisualStyleBackColor = true;
            this.buttonAddLetter.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput1.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput1.Multiline = true;
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput1.Size = new System.Drawing.Size(451, 142);
            this.textBoxInput1.TabIndex = 1;
            // 
            // textBoxLetter
            // 
            this.textBoxLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLetter.Location = new System.Drawing.Point(469, 83);
            this.textBoxLetter.MaxLength = 1;
            this.textBoxLetter.Name = "textBoxLetter";
            this.textBoxLetter.Size = new System.Drawing.Size(163, 38);
            this.textBoxLetter.TabIndex = 3;
            this.textBoxLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind.Location = new System.Drawing.Point(469, 127);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(163, 26);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Поиск";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.textBoxTableSize);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.textBoxLetter3);
            this.splitContainer3.Panel1.Controls.Add(this.textBoxLetter2);
            this.splitContainer3.Panel1.Controls.Add(this.buttonFind2);
            this.splitContainer3.Panel1.Controls.Add(this.buttonDelete);
            this.splitContainer3.Panel1.Controls.Add(this.label4);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.buttonAdd2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label8);
            this.splitContainer3.Panel2.Controls.Add(this.label7);
            this.splitContainer3.Panel2.Controls.Add(this.label6);
            this.splitContainer3.Panel2.Controls.Add(this.textBoxFind3);
            this.splitContainer3.Panel2.Controls.Add(this.buttonAddN3);
            this.splitContainer3.Panel2.Controls.Add(this.buttonAddN1);
            this.splitContainer3.Panel2.Controls.Add(this.buttonFind3);
            this.splitContainer3.Panel2.Controls.Add(this.buttonAddN2);
            this.splitContainer3.Panel2.Controls.Add(this.label5);
            this.splitContainer3.Size = new System.Drawing.Size(642, 422);
            this.splitContainer3.SplitterDistance = 214;
            this.splitContainer3.TabIndex = 0;
            // 
            // textBoxTableSize
            // 
            this.textBoxTableSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTableSize.Location = new System.Drawing.Point(468, 32);
            this.textBoxTableSize.MaxLength = 10;
            this.textBoxTableSize.Name = "textBoxTableSize";
            this.textBoxTableSize.Size = new System.Drawing.Size(163, 38);
            this.textBoxTableSize.TabIndex = 3;
            this.textBoxTableSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(477, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Удалить по букве";
            // 
            // textBoxLetter3
            // 
            this.textBoxLetter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLetter3.Location = new System.Drawing.Point(290, 138);
            this.textBoxLetter3.Name = "textBoxLetter3";
            this.textBoxLetter3.Size = new System.Drawing.Size(163, 38);
            this.textBoxLetter3.TabIndex = 3;
            this.textBoxLetter3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLetter2
            // 
            this.textBoxLetter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLetter2.Location = new System.Drawing.Point(468, 138);
            this.textBoxLetter2.MaxLength = 1;
            this.textBoxLetter2.Name = "textBoxLetter2";
            this.textBoxLetter2.Size = new System.Drawing.Size(163, 38);
            this.textBoxLetter2.TabIndex = 3;
            this.textBoxLetter2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonFind2
            // 
            this.buttonFind2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind2.Location = new System.Drawing.Point(290, 182);
            this.buttonFind2.Name = "buttonFind2";
            this.buttonFind2.Size = new System.Drawing.Size(163, 26);
            this.buttonFind2.TabIndex = 2;
            this.buttonFind2.Text = "Поиск";
            this.buttonFind2.UseVisualStyleBackColor = true;
            this.buttonFind2.Click += new System.EventHandler(this.buttonFind2_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(468, 182);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(163, 26);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Данные берутся из файла textexample.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(486, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Размер таблицы";
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd2.Location = new System.Drawing.Point(468, 76);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(163, 32);
            this.buttonAdd2.TabIndex = 2;
            this.buttonAdd2.Text = "Хешировать";
            this.buttonAdd2.UseVisualStyleBackColor = true;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(331, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "num_3.txt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(211, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "num_2.txt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(94, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "num_1.txt";
            // 
            // textBoxFind3
            // 
            this.textBoxFind3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFind3.Location = new System.Drawing.Point(458, 115);
            this.textBoxFind3.Name = "textBoxFind3";
            this.textBoxFind3.Size = new System.Drawing.Size(163, 38);
            this.textBoxFind3.TabIndex = 3;
            this.textBoxFind3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAddN3
            // 
            this.buttonAddN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddN3.Location = new System.Drawing.Point(314, 159);
            this.buttonAddN3.Name = "buttonAddN3";
            this.buttonAddN3.Size = new System.Drawing.Size(114, 32);
            this.buttonAddN3.TabIndex = 2;
            this.buttonAddN3.Text = "Хешировать";
            this.buttonAddN3.UseVisualStyleBackColor = true;
            this.buttonAddN3.Click += new System.EventHandler(this.buttonAddN3_Click);
            // 
            // buttonAddN1
            // 
            this.buttonAddN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddN1.Location = new System.Drawing.Point(74, 159);
            this.buttonAddN1.Name = "buttonAddN1";
            this.buttonAddN1.Size = new System.Drawing.Size(114, 32);
            this.buttonAddN1.TabIndex = 2;
            this.buttonAddN1.Text = "Хешировать";
            this.buttonAddN1.UseVisualStyleBackColor = true;
            this.buttonAddN1.Click += new System.EventHandler(this.buttonAddN1_Click);
            // 
            // buttonFind3
            // 
            this.buttonFind3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind3.Location = new System.Drawing.Point(458, 159);
            this.buttonFind3.Name = "buttonFind3";
            this.buttonFind3.Size = new System.Drawing.Size(163, 33);
            this.buttonFind3.TabIndex = 2;
            this.buttonFind3.Text = "Поиск";
            this.buttonFind3.UseVisualStyleBackColor = true;
            this.buttonFind3.Click += new System.EventHandler(this.buttonFind3_Click);
            // 
            // buttonAddN2
            // 
            this.buttonAddN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddN2.Location = new System.Drawing.Point(194, 159);
            this.buttonAddN2.Name = "buttonAddN2";
            this.buttonAddN2.Size = new System.Drawing.Size(114, 32);
            this.buttonAddN2.TabIndex = 2;
            this.buttonAddN2.Text = "Хешировать";
            this.buttonAddN2.UseVisualStyleBackColor = true;
            this.buttonAddN2.Click += new System.EventHandler(this.buttonAddN2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(2, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Данные берутся из файлов nums_1.txt;\r\nnums_2.txt; nums_3.txt";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutput.Location = new System.Drawing.Point(16, 12);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(430, 575);
            this.textBoxOutput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 601);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBoxLetter;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonAddLetter;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox textBoxTableSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLetter2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd2;
        private System.Windows.Forms.TextBox textBoxLetter3;
        private System.Windows.Forms.Button buttonFind2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFind3;
        private System.Windows.Forms.Button buttonAddN3;
        private System.Windows.Forms.Button buttonAddN1;
        private System.Windows.Forms.Button buttonFind3;
        private System.Windows.Forms.Button buttonAddN2;
        private System.Windows.Forms.Label label5;
    }
}

