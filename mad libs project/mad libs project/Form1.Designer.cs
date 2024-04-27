namespace mad_libs_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(986, 90);
            label1.TabIndex = 0;
            label1.Text = "welcome  to  mad libs  :)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(426, 192);
            button1.Margin = new Padding(6, 4, 6, 4);
            button1.Name = "button1";
            button1.Size = new Size(265, 130);
            button1.TabIndex = 1;
            button1.Text = "Tap to play";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1122, 431);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 4, 6, 4);
            Name = "Form1";
            Text = "MAD LIBS";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}
