namespace Задание_1_г
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Xlabel = new System.Windows.Forms.Label();
            this.Ylabel = new System.Windows.Forms.Label();
            this.Ot = new System.Windows.Forms.TextBox();
            this.Otlabel = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.NumericUpDown();
            this.Y = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Xlabel.Location = new System.Drawing.Point(49, 31);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(173, 28);
            this.Xlabel.TabIndex = 0;
            this.Xlabel.Text = "Координата x ";
            // 
            // Ylabel
            // 
            this.Ylabel.AutoSize = true;
            this.Ylabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ylabel.Location = new System.Drawing.Point(49, 84);
            this.Ylabel.Name = "Ylabel";
            this.Ylabel.Size = new System.Drawing.Size(168, 28);
            this.Ylabel.TabIndex = 1;
            this.Ylabel.Text = "Координата y";
            // 
            // Ot
            // 
            this.Ot.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ot.Location = new System.Drawing.Point(179, 183);
            this.Ot.Name = "Ot";
            this.Ot.ReadOnly = true;
            this.Ot.Size = new System.Drawing.Size(211, 36);
            this.Ot.TabIndex = 2;
            // 
            // Otlabel
            // 
            this.Otlabel.AutoSize = true;
            this.Otlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Otlabel.Location = new System.Drawing.Point(49, 186);
            this.Otlabel.Name = "Otlabel";
            this.Otlabel.Size = new System.Drawing.Size(79, 28);
            this.Otlabel.TabIndex = 3;
            this.Otlabel.Text = "Точка";
            // 
            // X
            // 
            this.X.DecimalPlaces = 5;
            this.X.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.Location = new System.Drawing.Point(270, 29);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(120, 36);
            this.X.TabIndex = 4;
            this.X.ValueChanged += new System.EventHandler(this.XandY_ValueChanged);
            // 
            // Y
            // 
            this.Y.DecimalPlaces = 5;
            this.Y.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(270, 82);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(120, 36);
            this.Y.TabIndex = 5;
            this.Y.ValueChanged += new System.EventHandler(this.XandY_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(428, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 185);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 242);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Otlabel);
            this.Controls.Add(this.Ot);
            this.Controls.Add(this.Ylabel);
            this.Controls.Add(this.Xlabel);
            this.Name = "Form1";
            this.Text = "Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Label Ylabel;
        private System.Windows.Forms.TextBox Ot;
        private System.Windows.Forms.Label Otlabel;
        private System.Windows.Forms.NumericUpDown X;
        private System.Windows.Forms.NumericUpDown Y;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

