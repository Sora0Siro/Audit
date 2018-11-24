namespace AuditWFA
{
    partial class InfoForm
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
            this.dropList_Auditory = new System.Windows.Forms.ComboBox();
            this.AuditLabel = new System.Windows.Forms.Label();
            this.PlacesLabel = new System.Windows.Forms.Label();
            this.ProjectorLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.SecurityLabel = new System.Windows.Forms.Label();
            this.txt_Places = new System.Windows.Forms.TextBox();
            this.txt_Projector = new System.Windows.Forms.TextBox();
            this.txt_Condition = new System.Windows.Forms.TextBox();
            this.txt_Secure = new System.Windows.Forms.TextBox();
            this.btt_Edit = new System.Windows.Forms.Button();
            this.btt_OK = new System.Windows.Forms.Button();
            this.btt_Cancel = new System.Windows.Forms.Button();
            this.txt_PCs = new System.Windows.Forms.TextBox();
            this.ComputersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dropList_Auditory
            // 
            this.dropList_Auditory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropList_Auditory.FormattingEnabled = true;
            this.dropList_Auditory.Location = new System.Drawing.Point(205, 23);
            this.dropList_Auditory.Name = "dropList_Auditory";
            this.dropList_Auditory.Size = new System.Drawing.Size(121, 33);
            this.dropList_Auditory.TabIndex = 0;
            this.dropList_Auditory.TextChanged += new System.EventHandler(this.dropList_Auditory_TextChanged);
            // 
            // AuditLabel
            // 
            this.AuditLabel.AutoSize = true;
            this.AuditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuditLabel.Location = new System.Drawing.Point(12, 26);
            this.AuditLabel.Name = "AuditLabel";
            this.AuditLabel.Size = new System.Drawing.Size(124, 25);
            this.AuditLabel.TabIndex = 1;
            this.AuditLabel.Text = "Аудитория:";
            // 
            // PlacesLabel
            // 
            this.PlacesLabel.AutoSize = true;
            this.PlacesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlacesLabel.Location = new System.Drawing.Point(11, 82);
            this.PlacesLabel.Name = "PlacesLabel";
            this.PlacesLabel.Size = new System.Drawing.Size(67, 24);
            this.PlacesLabel.TabIndex = 2;
            this.PlacesLabel.Text = "Мест: ";
            // 
            // ProjectorLabel
            // 
            this.ProjectorLabel.AutoSize = true;
            this.ProjectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProjectorLabel.Location = new System.Drawing.Point(11, 146);
            this.ProjectorLabel.Name = "ProjectorLabel";
            this.ProjectorLabel.Size = new System.Drawing.Size(107, 24);
            this.ProjectorLabel.TabIndex = 3;
            this.ProjectorLabel.Text = "Проектор: ";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConditionLabel.Location = new System.Drawing.Point(11, 182);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(143, 24);
            this.ConditionLabel.TabIndex = 5;
            this.ConditionLabel.Text = "Кондиционер: ";
            // 
            // SecurityLabel
            // 
            this.SecurityLabel.AutoSize = true;
            this.SecurityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecurityLabel.Location = new System.Drawing.Point(11, 219);
            this.SecurityLabel.Name = "SecurityLabel";
            this.SecurityLabel.Size = new System.Drawing.Size(188, 24);
            this.SecurityLabel.TabIndex = 6;
            this.SecurityLabel.Text = "Охранная система: ";
            // 
            // txt_Places
            // 
            this.txt_Places.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Places.Location = new System.Drawing.Point(205, 80);
            this.txt_Places.Name = "txt_Places";
            this.txt_Places.Size = new System.Drawing.Size(177, 26);
            this.txt_Places.TabIndex = 7;
            // 
            // txt_Projector
            // 
            this.txt_Projector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Projector.Location = new System.Drawing.Point(205, 144);
            this.txt_Projector.Name = "txt_Projector";
            this.txt_Projector.Size = new System.Drawing.Size(177, 26);
            this.txt_Projector.TabIndex = 8;
            // 
            // txt_Condition
            // 
            this.txt_Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Condition.Location = new System.Drawing.Point(205, 180);
            this.txt_Condition.Name = "txt_Condition";
            this.txt_Condition.Size = new System.Drawing.Size(177, 26);
            this.txt_Condition.TabIndex = 9;
            // 
            // txt_Secure
            // 
            this.txt_Secure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Secure.Location = new System.Drawing.Point(205, 217);
            this.txt_Secure.Name = "txt_Secure";
            this.txt_Secure.Size = new System.Drawing.Size(177, 26);
            this.txt_Secure.TabIndex = 10;
            // 
            // btt_Edit
            // 
            this.btt_Edit.Location = new System.Drawing.Point(15, 315);
            this.btt_Edit.Name = "btt_Edit";
            this.btt_Edit.Size = new System.Drawing.Size(75, 23);
            this.btt_Edit.TabIndex = 12;
            this.btt_Edit.Text = "Edit";
            this.btt_Edit.UseVisualStyleBackColor = true;
            this.btt_Edit.Click += new System.EventHandler(this.btt_Edit_Click);
            // 
            // btt_OK
            // 
            this.btt_OK.Location = new System.Drawing.Point(214, 315);
            this.btt_OK.Name = "btt_OK";
            this.btt_OK.Size = new System.Drawing.Size(75, 23);
            this.btt_OK.TabIndex = 13;
            this.btt_OK.Text = "Save";
            this.btt_OK.UseVisualStyleBackColor = true;
            this.btt_OK.Visible = false;
            this.btt_OK.Click += new System.EventHandler(this.btt_OK_Click);
            // 
            // btt_Cancel
            // 
            this.btt_Cancel.Location = new System.Drawing.Point(306, 315);
            this.btt_Cancel.Name = "btt_Cancel";
            this.btt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btt_Cancel.TabIndex = 14;
            this.btt_Cancel.Text = "Cancel";
            this.btt_Cancel.UseVisualStyleBackColor = true;
            this.btt_Cancel.Visible = false;
            // 
            // txt_PCs
            // 
            this.txt_PCs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_PCs.Location = new System.Drawing.Point(205, 112);
            this.txt_PCs.Name = "txt_PCs";
            this.txt_PCs.Size = new System.Drawing.Size(177, 26);
            this.txt_PCs.TabIndex = 16;
            // 
            // ComputersLabel
            // 
            this.ComputersLabel.AutoSize = true;
            this.ComputersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComputersLabel.Location = new System.Drawing.Point(11, 114);
            this.ComputersLabel.Name = "ComputersLabel";
            this.ComputersLabel.Size = new System.Drawing.Size(141, 24);
            this.ComputersLabel.TabIndex = 15;
            this.ComputersLabel.Text = "Компьютеров:";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 386);
            this.Controls.Add(this.txt_PCs);
            this.Controls.Add(this.ComputersLabel);
            this.Controls.Add(this.btt_Cancel);
            this.Controls.Add(this.btt_OK);
            this.Controls.Add(this.btt_Edit);
            this.Controls.Add(this.txt_Secure);
            this.Controls.Add(this.txt_Condition);
            this.Controls.Add(this.txt_Projector);
            this.Controls.Add(this.txt_Places);
            this.Controls.Add(this.SecurityLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProjectorLabel);
            this.Controls.Add(this.PlacesLabel);
            this.Controls.Add(this.AuditLabel);
            this.Controls.Add(this.dropList_Auditory);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dropList_Auditory;
        private System.Windows.Forms.Label AuditLabel;
        private System.Windows.Forms.Label PlacesLabel;
        private System.Windows.Forms.Label ProjectorLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label SecurityLabel;
        private System.Windows.Forms.TextBox txt_Places;
        private System.Windows.Forms.TextBox txt_Projector;
        private System.Windows.Forms.TextBox txt_Condition;
        private System.Windows.Forms.TextBox txt_Secure;
        private System.Windows.Forms.Button btt_Edit;
        private System.Windows.Forms.Button btt_OK;
        private System.Windows.Forms.Button btt_Cancel;
        private System.Windows.Forms.TextBox txt_PCs;
        private System.Windows.Forms.Label ComputersLabel;
    }
}