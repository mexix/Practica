namespace Lavanderia
{
    partial class imagen
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
            this.imgInicio = new System.Windows.Forms.PictureBox();
            this.barraCarga = new System.Windows.Forms.ProgressBar();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // imgInicio
            // 
            this.imgInicio.Image = global::Lavanderia.Properties.Resources.lavanderia_big;
            this.imgInicio.Location = new System.Drawing.Point(12, 12);
            this.imgInicio.Name = "imgInicio";
            this.imgInicio.Size = new System.Drawing.Size(776, 331);
            this.imgInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgInicio.TabIndex = 0;
            this.imgInicio.TabStop = false;
            // 
            // barraCarga
            // 
            this.barraCarga.Location = new System.Drawing.Point(21, 373);
            this.barraCarga.Name = "barraCarga";
            this.barraCarga.Size = new System.Drawing.Size(745, 32);
            this.barraCarga.TabIndex = 1;
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Location = new System.Drawing.Point(369, 373);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(35, 13);
            this.lblProgreso.TabIndex = 2;
            this.lblProgreso.Text = "label1";
            this.lblProgreso.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.barraCarga);
            this.Controls.Add(this.imgInicio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "imagen";
            this.Text = "imagen";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            ((System.ComponentModel.ISupportInitialize)(this.imgInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgInicio;
        private System.Windows.Forms.ProgressBar barraCarga;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.Timer timer1;
    }
}