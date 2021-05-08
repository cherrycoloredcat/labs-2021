
namespace lab5
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
            this.buttonSelectionSort = new System.Windows.Forms.Button();
            this.buttonBinInsertSort = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonHalfSorted = new System.Windows.Forms.Button();
            this.buttonInverted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelectionSort
            // 
            this.buttonSelectionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectionSort.Location = new System.Drawing.Point(11, 241);
            this.buttonSelectionSort.Name = "buttonSelectionSort";
            this.buttonSelectionSort.Size = new System.Drawing.Size(170, 55);
            this.buttonSelectionSort.TabIndex = 1;
            this.buttonSelectionSort.Text = "Прямой выбор";
            this.buttonSelectionSort.UseVisualStyleBackColor = true;
            this.buttonSelectionSort.Click += new System.EventHandler(this.buttonSelectionSort_Click);
            // 
            // buttonBinInsertSort
            // 
            this.buttonBinInsertSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBinInsertSort.Location = new System.Drawing.Point(208, 241);
            this.buttonBinInsertSort.Name = "buttonBinInsertSort";
            this.buttonBinInsertSort.Size = new System.Drawing.Size(170, 55);
            this.buttonBinInsertSort.TabIndex = 1;
            this.buttonBinInsertSort.Text = "Бинарные включения";
            this.buttonBinInsertSort.UseVisualStyleBackColor = true;
            this.buttonBinInsertSort.Click += new System.EventHandler(this.buttonBinInsertSort_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(11, 389);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(367, 155);
            this.textBox2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(204, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(366, 155);
            this.textBox1.TabIndex = 0;
            // 
            // buttonRandom
            // 
            this.buttonRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRandom.Location = new System.Drawing.Point(11, 15);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(112, 43);
            this.buttonRandom.TabIndex = 1;
            this.buttonRandom.Text = "Случайный";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonHalfSorted
            // 
            this.buttonHalfSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHalfSorted.Location = new System.Drawing.Point(139, 15);
            this.buttonHalfSorted.Name = "buttonHalfSorted";
            this.buttonHalfSorted.Size = new System.Drawing.Size(112, 43);
            this.buttonHalfSorted.TabIndex = 1;
            this.buttonHalfSorted.Text = "Частично";
            this.buttonHalfSorted.UseVisualStyleBackColor = true;
            this.buttonHalfSorted.Click += new System.EventHandler(this.buttonHalfSorted_Click);
            // 
            // buttonInverted
            // 
            this.buttonInverted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInverted.Location = new System.Drawing.Point(266, 15);
            this.buttonInverted.Name = "buttonInverted";
            this.buttonInverted.Size = new System.Drawing.Size(112, 43);
            this.buttonInverted.TabIndex = 1;
            this.buttonInverted.Text = "Обратный";
            this.buttonInverted.UseVisualStyleBackColor = true;
            this.buttonInverted.Click += new System.EventHandler(this.buttonInverted_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBinInsertSort);
            this.Controls.Add(this.buttonSelectionSort);
            this.Controls.Add(this.buttonInverted);
            this.Controls.Add(this.buttonHalfSorted);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSelectionSort;
        private System.Windows.Forms.Button buttonBinInsertSort;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonHalfSorted;
        private System.Windows.Forms.Button buttonInverted;
    }
}

