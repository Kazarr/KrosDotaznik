namespace KrosDotaznik
{
    partial class FrmMain
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnSvk = new System.Windows.Forms.Button();
            this.btnEng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreate.Location = new System.Drawing.Point(146, 182);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(224, 45);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "vytvor";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnFill
            // 
            this.btnFill.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFill.Location = new System.Drawing.Point(376, 182);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(224, 45);
            this.btnFill.TabIndex = 2;
            this.btnFill.Text = "vypln";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnSvk
            // 
            this.btnSvk.Location = new System.Drawing.Point(330, 29);
            this.btnSvk.Name = "btnSvk";
            this.btnSvk.Size = new System.Drawing.Size(40, 40);
            this.btnSvk.TabIndex = 3;
            this.btnSvk.Text = "SVK";
            this.btnSvk.UseVisualStyleBackColor = true;
            this.btnSvk.Click += new System.EventHandler(this.btnSvk_Click);
            // 
            // btnEng
            // 
            this.btnEng.Location = new System.Drawing.Point(376, 29);
            this.btnEng.Name = "btnEng";
            this.btnEng.Size = new System.Drawing.Size(40, 40);
            this.btnEng.TabIndex = 4;
            this.btnEng.Text = "EN";
            this.btnEng.UseVisualStyleBackColor = true;
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEng);
            this.Controls.Add(this.btnSvk);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnCreate);
            this.Name = "FrmMain";
            this.Text = "Dotazník";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnSvk;
        private System.Windows.Forms.Button btnEng;
    }
}

