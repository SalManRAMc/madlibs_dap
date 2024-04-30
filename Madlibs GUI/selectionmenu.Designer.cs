namespace Madlibs_GUI
{
    partial class selectionmenu
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 39);
            label1.Name = "label1";
            label1.Size = new Size(191, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose From The Following Topics";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(214, 76);
            button1.Name = "button1";
            button1.Size = new Size(122, 50);
            button1.TabIndex = 1;
            button1.Text = "Love";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(214, 132);
            button2.Name = "button2";
            button2.Size = new Size(122, 50);
            button2.TabIndex = 2;
            button2.Text = "Horror";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(214, 188);
            button3.Name = "button3";
            button3.Size = new Size(122, 50);
            button3.TabIndex = 3;
            button3.Text = "Happy";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(214, 244);
            button4.Name = "button4";
            button4.Size = new Size(122, 50);
            button4.TabIndex = 4;
            button4.Text = "Sad";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(214, 300);
            button5.Name = "button5";
            button5.Size = new Size(122, 50);
            button5.TabIndex = 5;
            button5.Text = "Surprise Me";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // selectionmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 385);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "selectionmenu";
            Text = "selectionmenu";
            Load += selectionmenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}