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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnEng = new System.Windows.Forms.Button();
            this.btnSvk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.Image = global::KrosDotaznik.Properties.Resources.fillI;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnFill, "btnFill");
            this.btnFill.Image = global::KrosDotaznik.Properties.Resources.createI;
            this.btnFill.Name = "btnFill";
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnEng
            // 
            resources.ApplyResources(this.btnEng, "btnEng");
            this.btnEng.Image = global::KrosDotaznik.Properties.Resources.englishFlag;
            this.btnEng.Name = "btnEng";
            this.btnEng.UseVisualStyleBackColor = true;
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // btnSvk
            // 
            resources.ApplyResources(this.btnSvk, "btnSvk");
            this.btnSvk.Name = "btnSvk";
            this.btnSvk.UseVisualStyleBackColor = true;
            this.btnSvk.Click += new System.EventHandler(this.btnSvk_Click);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btnEng);
            this.Controls.Add(this.btnSvk);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnCreate);
            this.Name = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnSvk;
        private System.Windows.Forms.Button btnEng;
    }
}

