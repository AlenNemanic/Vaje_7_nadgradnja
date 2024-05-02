namespace Vozeca_ploscad_nadgradnja
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
            this.components = new System.ComponentModel.Container();
            this.Gumb = new System.Windows.Forms.Button();
            this.ploscad = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ploscad)).BeginInit();
            this.SuspendLayout();
            // 
            // Gumb
            // 
            this.Gumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gumb.Location = new System.Drawing.Point(76, 118);
            this.Gumb.Name = "Gumb";
            this.Gumb.Size = new System.Drawing.Size(150, 80);
            this.Gumb.TabIndex = 3;
            this.Gumb.Text = "Začni";
            this.Gumb.UseVisualStyleBackColor = true;
            this.Gumb.Click += new System.EventHandler(this.Gumb_Click);
            // 
            // ploscad
            // 
            this.ploscad.BackColor = System.Drawing.Color.Black;
            this.ploscad.Location = new System.Drawing.Point(12, 12);
            this.ploscad.Name = "ploscad";
            this.ploscad.Size = new System.Drawing.Size(15, 15);
            this.ploscad.TabIndex = 4;
            this.ploscad.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 311);
            this.Controls.Add(this.ploscad);
            this.Controls.Add(this.Gumb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ploscad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Gumb;
        private System.Windows.Forms.PictureBox ploscad;
        private System.Windows.Forms.Timer timer;
    }
}

