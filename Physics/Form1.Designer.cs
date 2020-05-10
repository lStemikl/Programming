namespace Physics
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
            this.labScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.labScore.Location = new System.Drawing.Point(62, 9);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(93, 29);
            this.labScore.TabIndex = 16;
            this.labScore.Text = "Очки:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 313);
            this.Controls.Add(this.labScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "2048";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labScore;
    }
}

