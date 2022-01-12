namespace ChuckForm
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
            this.GetJokeBtn = new System.Windows.Forms.Button();
            this.JokeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GetJokeBtn
            // 
            this.GetJokeBtn.Location = new System.Drawing.Point(41, 41);
            this.GetJokeBtn.Name = "GetJokeBtn";
            this.GetJokeBtn.Size = new System.Drawing.Size(75, 23);
            this.GetJokeBtn.TabIndex = 0;
            this.GetJokeBtn.Text = "Get Joke";
            this.GetJokeBtn.UseVisualStyleBackColor = true;
            this.GetJokeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // JokeBox
            // 
            this.JokeBox.Location = new System.Drawing.Point(40, 278);
            this.JokeBox.Multiline = true;
            this.JokeBox.Name = "JokeBox";
            this.JokeBox.Size = new System.Drawing.Size(421, 42);
            this.JokeBox.TabIndex = 1;
            this.JokeBox.Text = "Press the button, I dare You!\r\n\r\n";
            this.JokeBox.TextChanged += new System.EventHandler(this.JokeBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(503, 425);
            this.Controls.Add(this.JokeBox);
            this.Controls.Add(this.GetJokeBtn);
            this.Name = "Form1";
            this.Text = "ChuckNorrisJokeGenerator";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetJokeBtn;
        private System.Windows.Forms.TextBox JokeBox;
    }
}

