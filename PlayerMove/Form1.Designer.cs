
namespace PlayerMove
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
            this.játékos = new PlayerMove.Játékos();
            ((System.ComponentModel.ISupportInitialize)(this.játékos)).BeginInit();
            this.SuspendLayout();
            // 
            // játékos
            // 
            this.játékos.BackColor = System.Drawing.Color.Fuchsia;
            this.játékos.Location = new System.Drawing.Point(361, 169);
            this.játékos.Name = "játékos";
            this.játékos.Size = new System.Drawing.Size(30, 30);
            this.játékos.TabIndex = 0;
            this.játékos.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.játékos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.játékos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Játékos játékos;
    }
}

