namespace ATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tviet = new System.Windows.Forms.Button();
            this.english = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tviet
            // 
            this.Tviet.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Tviet.Location = new System.Drawing.Point(474, 213);
            this.Tviet.Name = "Tviet";
            this.Tviet.Size = new System.Drawing.Size(132, 42);
            this.Tviet.TabIndex = 0;
            this.Tviet.Text = "Tiếng Việt";
            this.Tviet.UseVisualStyleBackColor = false;
            this.Tviet.Click += new System.EventHandler(this.Tviet_Click);
            // 
            // english
            // 
            this.english.BackColor = System.Drawing.SystemColors.Highlight;
            this.english.Location = new System.Drawing.Point(474, 281);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(132, 42);
            this.english.TabIndex = 1;
            this.english.Text = "English";
            this.english.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 357);
            this.Controls.Add(this.english);
            this.Controls.Add(this.Tviet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Tviet;
        private System.Windows.Forms.Button english;
    }
}

