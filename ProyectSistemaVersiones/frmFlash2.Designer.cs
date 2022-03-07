namespace SistemasVersiones
{
    partial class frmFlash
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
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyR = new System.Windows.Forms.Label();
            this.LBLCompanyName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(307, 32);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(46, 17);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "label1";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(307, 73);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(46, 17);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "label2";
            // 
            // lblCopyR
            // 
            this.lblCopyR.AutoSize = true;
            this.lblCopyR.Location = new System.Drawing.Point(307, 108);
            this.lblCopyR.Name = "lblCopyR";
            this.lblCopyR.Size = new System.Drawing.Size(46, 17);
            this.lblCopyR.TabIndex = 2;
            this.lblCopyR.Text = "label3";
            // 
            // LBLCompanyName
            // 
            this.LBLCompanyName.AutoSize = true;
            this.LBLCompanyName.Location = new System.Drawing.Point(307, 154);
            this.LBLCompanyName.Name = "LBLCompanyName";
            this.LBLCompanyName.Size = new System.Drawing.Size(46, 17);
            this.LBLCompanyName.TabIndex = 3;
            this.LBLCompanyName.Text = "label4";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(310, 187);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(248, 67);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // frmFlash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 397);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.LBLCompanyName);
            this.Controls.Add(this.lblCopyR);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblNombreProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFlash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFlash";
            this.Load += new System.EventHandler(this.frmFlash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCopyR;
        private System.Windows.Forms.Label LBLCompanyName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}