namespace QRCodeGenerate
{
    partial class frmQR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQR));
            this.qr = new System.Windows.Forms.Label();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtWhatYouWant = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // qr
            // 
            this.qr.AutoSize = true;
            this.qr.BackColor = System.Drawing.Color.Transparent;
            this.qr.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.qr.ForeColor = System.Drawing.Color.Salmon;
            this.qr.Location = new System.Drawing.Point(233, 14);
            this.qr.Name = "qr";
            this.qr.Size = new System.Drawing.Size(255, 29);
            this.qr.TabIndex = 0;
            this.qr.Text = "QR CODE GENERATE";
            // 
            // pbQR
            // 
            this.pbQR.BackColor = System.Drawing.Color.White;
            this.pbQR.Location = new System.Drawing.Point(233, 46);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(250, 250);
            this.pbQR.TabIndex = 1;
            this.pbQR.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.White;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ForeColor = System.Drawing.Color.Salmon;
            this.btnGenerate.Location = new System.Drawing.Point(382, 385);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(101, 58);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "QR Code Generater";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtWhatYouWant
            // 
            this.txtWhatYouWant.BackColor = System.Drawing.Color.White;
            this.txtWhatYouWant.Location = new System.Drawing.Point(233, 302);
            this.txtWhatYouWant.Multiline = true;
            this.txtWhatYouWant.Name = "txtWhatYouWant";
            this.txtWhatYouWant.Size = new System.Drawing.Size(250, 77);
            this.txtWhatYouWant.TabIndex = 3;
            // 
            // frmQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.txtWhatYouWant);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pbQR);
            this.Controls.Add(this.qr);
            this.Name = "frmQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR";
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label qr;
        private PictureBox pbQR;
        private Button btnGenerate;
        private TextBox txtWhatYouWant;
    }
}