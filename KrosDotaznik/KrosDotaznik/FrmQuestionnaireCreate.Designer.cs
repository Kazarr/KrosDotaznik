namespace KrosDotaznik
{
    partial class FrmQuestionnaireCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuestionnaireCreate));
            this.chbxJobSpecification = new System.Windows.Forms.CheckBox();
            this.chbxChild = new System.Windows.Forms.CheckBox();
            this.chbxPrevious = new System.Windows.Forms.CheckBox();
            this.chbxEducation = new System.Windows.Forms.CheckBox();
            this.chbxPassword = new System.Windows.Forms.CheckBox();
            this.chbxContacts = new System.Windows.Forms.CheckBox();
            this.chbxEmployeeData = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelQuestion = new System.Windows.Forms.GroupBox();
            this.saveFileData = new System.Windows.Forms.SaveFileDialog();
            this.panelQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbxJobSpecification
            // 
            resources.ApplyResources(this.chbxJobSpecification, "chbxJobSpecification");
            this.chbxJobSpecification.Name = "chbxJobSpecification";
            this.chbxJobSpecification.UseVisualStyleBackColor = true;
            // 
            // chbxChild
            // 
            resources.ApplyResources(this.chbxChild, "chbxChild");
            this.chbxChild.Name = "chbxChild";
            this.chbxChild.UseVisualStyleBackColor = true;
            // 
            // chbxPrevious
            // 
            resources.ApplyResources(this.chbxPrevious, "chbxPrevious");
            this.chbxPrevious.Name = "chbxPrevious";
            this.chbxPrevious.UseVisualStyleBackColor = true;
            // 
            // chbxEducation
            // 
            resources.ApplyResources(this.chbxEducation, "chbxEducation");
            this.chbxEducation.Name = "chbxEducation";
            this.chbxEducation.UseVisualStyleBackColor = true;
            // 
            // chbxPassword
            // 
            resources.ApplyResources(this.chbxPassword, "chbxPassword");
            this.chbxPassword.Name = "chbxPassword";
            this.chbxPassword.UseVisualStyleBackColor = true;
            // 
            // chbxContacts
            // 
            resources.ApplyResources(this.chbxContacts, "chbxContacts");
            this.chbxContacts.Name = "chbxContacts";
            this.chbxContacts.UseVisualStyleBackColor = true;
            // 
            // chbxEmployeeData
            // 
            resources.ApplyResources(this.chbxEmployeeData, "chbxEmployeeData");
            this.chbxEmployeeData.Name = "chbxEmployeeData";
            this.chbxEmployeeData.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::KrosDotaznik.Properties.Resources.cancelS;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Image = global::KrosDotaznik.Properties.Resources.okS;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelQuestion
            // 
            resources.ApplyResources(this.panelQuestion, "panelQuestion");
            this.panelQuestion.Controls.Add(this.chbxPrevious);
            this.panelQuestion.Controls.Add(this.chbxEmployeeData);
            this.panelQuestion.Controls.Add(this.chbxContacts);
            this.panelQuestion.Controls.Add(this.chbxJobSpecification);
            this.panelQuestion.Controls.Add(this.chbxPassword);
            this.panelQuestion.Controls.Add(this.chbxChild);
            this.panelQuestion.Controls.Add(this.chbxEducation);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.TabStop = false;
            // 
            // saveFileData
            // 
            this.saveFileData.DefaultExt = "kpq";
            resources.ApplyResources(this.saveFileData, "saveFileData");
            this.saveFileData.RestoreDirectory = true;
            this.saveFileData.ValidateNames = false;
            // 
            // FrmQuestionnaireCreate
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "FrmQuestionnaireCreate";
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chbxJobSpecification;
        private System.Windows.Forms.CheckBox chbxChild;
        private System.Windows.Forms.CheckBox chbxPrevious;
        private System.Windows.Forms.CheckBox chbxEducation;
        private System.Windows.Forms.CheckBox chbxPassword;
        private System.Windows.Forms.CheckBox chbxContacts;
        private System.Windows.Forms.CheckBox chbxEmployeeData;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox panelQuestion;
        private System.Windows.Forms.SaveFileDialog saveFileData;
    }
}