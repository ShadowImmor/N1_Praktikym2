namespace Задание_2_г
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
            this.NumMeslabel = new System.Windows.Forms.Label();
            this.Otlabel = new System.Windows.Forms.Label();
            this.Ot = new System.Windows.Forms.TextBox();
            this.NumMeS = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumMeS)).BeginInit();
            this.SuspendLayout();
            // 
            // NumMeslabel
            // 
            this.NumMeslabel.AutoSize = true;
            this.NumMeslabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumMeslabel.Location = new System.Drawing.Point(38, 30);
            this.NumMeslabel.Name = "NumMeslabel";
            this.NumMeslabel.Size = new System.Drawing.Size(310, 28);
            this.NumMeslabel.TabIndex = 0;
            this.NumMeslabel.Text = "Порядкомы номер месяца";
            // 
            // Otlabel
            // 
            this.Otlabel.AutoSize = true;
            this.Otlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Otlabel.Location = new System.Drawing.Point(38, 112);
            this.Otlabel.Name = "Otlabel";
            this.Otlabel.Size = new System.Drawing.Size(380, 28);
            this.Otlabel.TabIndex = 1;
            this.Otlabel.Text = "До конца года осталось месяцев:";
            // 
            // Ot
            // 
            this.Ot.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ot.Location = new System.Drawing.Point(448, 109);
            this.Ot.Name = "Ot";
            this.Ot.ReadOnly = true;
            this.Ot.Size = new System.Drawing.Size(100, 36);
            this.Ot.TabIndex = 2;
            // 
            // NumMeS
            // 
            this.NumMeS.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumMeS.Location = new System.Drawing.Point(369, 28);
            this.NumMeS.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumMeS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumMeS.Name = "NumMeS";
            this.NumMeS.Size = new System.Drawing.Size(62, 36);
            this.NumMeS.TabIndex = 3;
            this.NumMeS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumMeS.ValueChanged += new System.EventHandler(this.NumMeS_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 184);
            this.Controls.Add(this.NumMeS);
            this.Controls.Add(this.Ot);
            this.Controls.Add(this.Otlabel);
            this.Controls.Add(this.NumMeslabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumMeS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumMeslabel;
        private System.Windows.Forms.Label Otlabel;
        private System.Windows.Forms.TextBox Ot;
        private System.Windows.Forms.NumericUpDown NumMeS;
    }
}

