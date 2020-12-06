
namespace WindowsFormsApp3
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
            this.Hello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hello
            // 
            this.Hello.Location = new System.Drawing.Point(288, 153);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(238, 103);
            this.Hello.TabIndex = 0;
            this.Hello.Text = "hello Baby";
            this.Hello.UseVisualStyleBackColor = true;
            this.Hello.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hello);
            this.Name = "Form1";
            this.Text = "message";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Hello;
    }
}

