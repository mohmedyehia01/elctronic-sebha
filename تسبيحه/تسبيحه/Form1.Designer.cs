namespace تسبيحه
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            allahWeakbar = new Button();
            sbhanAllah = new Label();
            button2 = new Button();
            elhamd = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // allahWeakbar
            // 
            allahWeakbar.BackgroundImage = Properties.Resources.samsung_galaxy_s23_1920x1080_ultra_android_13_24399;
            allahWeakbar.BackgroundImageLayout = ImageLayout.Stretch;
            allahWeakbar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            allahWeakbar.Location = new Point(691, 228);
            allahWeakbar.Name = "allahWeakbar";
            allahWeakbar.Size = new Size(258, 123);
            allahWeakbar.TabIndex = 0;
            allahWeakbar.Text = "الله واكبر ";
            allahWeakbar.UseVisualStyleBackColor = true;
            allahWeakbar.Click += button1_Click;
            // 
            // sbhanAllah
            // 
            sbhanAllah.AutoSize = true;
            sbhanAllah.Location = new Point(466, 175);
            sbhanAllah.Name = "sbhanAllah";
            sbhanAllah.Size = new Size(13, 15);
            sbhanAllah.TabIndex = 1;
            sbhanAllah.Text = "0";
            sbhanAllah.Click += sbhanAllah_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.samsung_galaxy_s23_1920x1080_ultra_android_13_24399;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(361, 228);
            button2.Name = "button2";
            button2.Size = new Size(258, 123);
            button2.TabIndex = 2;
            button2.Text = "سبحان الله";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // elhamd
            // 
            elhamd.BackgroundImage = Properties.Resources.samsung_galaxy_s23_1920x1080_ultra_android_13_24399;
            elhamd.BackgroundImageLayout = ImageLayout.Stretch;
            elhamd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            elhamd.Location = new Point(37, 228);
            elhamd.Name = "elhamd";
            elhamd.Size = new Size(258, 123);
            elhamd.TabIndex = 3;
            elhamd.Text = "الحمد  لله";
            elhamd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(795, 175);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 4;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 175);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 5;
            label2.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(961, 543);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(elhamd);
            Controls.Add(button2);
            Controls.Add(sbhanAllah);
            Controls.Add(allahWeakbar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button allahWeakbar;
        private Label sbhanAllah;
        private Button button2;
        private Button elhamd;
        private Label label1;
        private Label label2;
    }
}
