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
            this.btnSvk = new System.Windows.Forms.Button();
            this.btnEng = new System.Windows.Forms.Button();
            this.chbxEmployeeData = new System.Windows.Forms.CheckBox();
            this.chbxContacts = new System.Windows.Forms.CheckBox();
            this.chbxPassword = new System.Windows.Forms.CheckBox();
            this.chbxEducation = new System.Windows.Forms.CheckBox();
            this.chbxPrevious = new System.Windows.Forms.CheckBox();
            this.chbxChild = new System.Windows.Forms.CheckBox();
            this.chbxJobSpecification = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnFill
            // 
            resources.ApplyResources(this.btnFill, "btnFill");
            this.btnFill.Name = "btnFill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnSvk
            // 
            resources.ApplyResources(this.btnSvk, "btnSvk");
            this.btnSvk.Name = "btnSvk";
            this.btnSvk.UseVisualStyleBackColor = true;
            this.btnSvk.Click += new System.EventHandler(this.btnSvk_Click);
            // 
            // btnEng
            // 
            resources.ApplyResources(this.btnEng, "btnEng");
            this.btnEng.Name = "btnEng";
            this.btnEng.UseVisualStyleBackColor = true;
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // chbxEmployeeData
            // 
            resources.ApplyResources(this.chbxEmployeeData, "chbxEmployeeData");
            this.chbxEmployeeData.Name = "chbxEmployeeData";
            this.chbxEmployeeData.UseVisualStyleBackColor = true;
            // 
            // chbxContacts
            // 
            resources.ApplyResources(this.chbxContacts, "chbxContacts");
            this.chbxContacts.Name = "chbxContacts";
            this.chbxContacts.UseVisualStyleBackColor = true;
            // 
            // chbxPassword
            // 
            resources.ApplyResources(this.chbxPassword, "chbxPassword");
            this.chbxPassword.Name = "chbxPassword";
            this.chbxPassword.UseVisualStyleBackColor = true;
            // 
            // chbxEducation
            // 
            resources.ApplyResources(this.chbxEducation, "chbxEducation");
            this.chbxEducation.Name = "chbxEducation";
            this.chbxEducation.UseVisualStyleBackColor = true;
            // 
            // chbxPrevious
            // 
            resources.ApplyResources(this.chbxPrevious, "chbxPrevious");
            this.chbxPrevious.Name = "chbxPrevious";
            this.chbxPrevious.UseVisualStyleBackColor = true;
            // 
            // chbxChild
            // 
            resources.ApplyResources(this.chbxChild, "chbxChild");
            this.chbxChild.Name = "chbxChild";
            this.chbxChild.UseVisualStyleBackColor = true;
            // 
            // chbxJobSpecification
            // 
            resources.ApplyResources(this.chbxJobSpecification, "chbxJobSpecification");
            this.chbxJobSpecification.Name = "chbxJobSpecification";
            this.chbxJobSpecification.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chbxJobSpecification);
            this.Controls.Add(this.chbxChild);
            this.Controls.Add(this.chbxPrevious);
            this.Controls.Add(this.chbxEducation);
            this.Controls.Add(this.chbxPassword);
            this.Controls.Add(this.chbxContacts);
            this.Controls.Add(this.chbxEmployeeData);
            this.Controls.Add(this.btnEng);
            this.Controls.Add(this.btnSvk);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnCreate);
            this.Name = "FrmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnSvk;
        private System.Windows.Forms.Button btnEng;
        private System.Windows.Forms.CheckBox chbxEmployeeData;
        private System.Windows.Forms.CheckBox chbxContacts;
        private System.Windows.Forms.CheckBox chbxPassword;
        private System.Windows.Forms.CheckBox chbxEducation;
        private System.Windows.Forms.CheckBox chbxPrevious;
        private System.Windows.Forms.CheckBox chbxChild;
        private System.Windows.Forms.CheckBox chbxJobSpecification;
    }
}

