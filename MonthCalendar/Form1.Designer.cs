namespace MonthCalendar
{
    partial class Form1
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
            this.mCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mCalendar1
            // 
            this.mCalendar1.Location = new System.Drawing.Point(18, 18);
            this.mCalendar1.Name = "mCalendar1";
            this.mCalendar1.TabIndex = 0;
            this.mCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(71, 192);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(124, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Odaberite termin";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 242);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.mCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mCalendar1;
        private System.Windows.Forms.Button btn1;
    }
}

