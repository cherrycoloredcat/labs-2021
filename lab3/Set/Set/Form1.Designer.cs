
namespace Set
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxComposite = new System.Windows.Forms.TextBox();
            this.textBoxPrime = new System.Windows.Forms.TextBox();
            this.buttonSeparate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.Location = new System.Drawing.Point(13, 12);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(194, 347);
            this.textBoxInput.TabIndex = 0;
            // 
            // textBoxComposite
            // 
            this.textBoxComposite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxComposite.Location = new System.Drawing.Point(485, 12);
            this.textBoxComposite.Multiline = true;
            this.textBoxComposite.Name = "textBoxComposite";
            this.textBoxComposite.ReadOnly = true;
            this.textBoxComposite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxComposite.Size = new System.Drawing.Size(194, 347);
            this.textBoxComposite.TabIndex = 0;
            // 
            // textBoxPrime
            // 
            this.textBoxPrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrime.Location = new System.Drawing.Point(285, 12);
            this.textBoxPrime.Multiline = true;
            this.textBoxPrime.Name = "textBoxPrime";
            this.textBoxPrime.ReadOnly = true;
            this.textBoxPrime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPrime.Size = new System.Drawing.Size(194, 347);
            this.textBoxPrime.TabIndex = 0;
            // 
            // buttonSeparate
            // 
            this.buttonSeparate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeparate.Location = new System.Drawing.Point(13, 366);
            this.buttonSeparate.Name = "buttonSeparate";
            this.buttonSeparate.Size = new System.Drawing.Size(194, 72);
            this.buttonSeparate.TabIndex = 1;
            this.buttonSeparate.Text = "Разделить";
            this.buttonSeparate.UseVisualStyleBackColor = true;
            this.buttonSeparate.Click += new System.EventHandler(this.buttonSeparate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(323, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Простые числа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(524, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Составные числа";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSeparate);
            this.Controls.Add(this.textBoxPrime);
            this.Controls.Add(this.textBoxComposite);
            this.Controls.Add(this.textBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "set";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxComposite;
        private System.Windows.Forms.TextBox textBoxPrime;
        private System.Windows.Forms.Button buttonSeparate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

