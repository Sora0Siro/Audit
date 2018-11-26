﻿using System;
using System.IO;

namespace AuditWFA
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
            this.Table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dropList_Faculty = new System.Windows.Forms.ComboBox();
            this.facultyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textField_Teacher = new System.Windows.Forms.ComboBox();
            this.textField_Subject = new System.Windows.Forms.ComboBox();
            this.textField_Group = new System.Windows.Forms.ComboBox();
            this.textField_Aud = new System.Windows.Forms.ComboBox();
            this.textField_Number = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dropList_Cath = new System.Windows.Forms.ComboBox();
            this.courseLabel = new System.Windows.Forms.Label();
            this.dropList_Course = new System.Windows.Forms.ComboBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.DataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutAuditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseSearch = new System.Windows.Forms.FolderBrowserDialog();
            this.gB_Schedule = new System.Windows.Forms.GroupBox();
            this.btt_DeleteSchLine = new System.Windows.Forms.Button();
            this.dtp_Teach = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.Menu.SuspendLayout();
            this.gB_Schedule.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3,
            this.numberColumn});
            this.Table.Location = new System.Drawing.Point(23, 46);
            this.Table.Name = "Table";
            this.Table.RowHeadersVisible = false;
            this.Table.Size = new System.Drawing.Size(496, 341);
            this.Table.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Teacher";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Subject";
            this.Column4.Name = "Column4";
            this.Column4.Width = 160;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Group";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Auditorium";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // numberColumn
            // 
            this.numberColumn.HeaderText = "№";
            this.numberColumn.Name = "numberColumn";
            this.numberColumn.Width = 30;
            // 
            // dropList_Faculty
            // 
            this.dropList_Faculty.BackColor = System.Drawing.SystemColors.Window;
            this.dropList_Faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropList_Faculty.FormattingEnabled = true;
            this.dropList_Faculty.Location = new System.Drawing.Point(116, 24);
            this.dropList_Faculty.Name = "dropList_Faculty";
            this.dropList_Faculty.Size = new System.Drawing.Size(174, 26);
            this.dropList_Faculty.TabIndex = 7;
            this.dropList_Faculty.TextChanged += new System.EventHandler(this.dropList_Faculty_TextChanged);
            // 
            // facultyLabel
            // 
            this.facultyLabel.AutoSize = true;
            this.facultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultyLabel.Location = new System.Drawing.Point(16, 26);
            this.facultyLabel.Name = "facultyLabel";
            this.facultyLabel.Size = new System.Drawing.Size(94, 20);
            this.facultyLabel.TabIndex = 9;
            this.facultyLabel.Text = "Факультет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Преподаватель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(96, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Предмет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(267, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Группа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(372, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Аудитория";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(380, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "№ пары";
            // 
            // textField_Teacher
            // 
            this.textField_Teacher.FormattingEnabled = true;
            this.textField_Teacher.Location = new System.Drawing.Point(34, 87);
            this.textField_Teacher.Name = "textField_Teacher";
            this.textField_Teacher.Size = new System.Drawing.Size(199, 21);
            this.textField_Teacher.TabIndex = 21;
            this.textField_Teacher.TextChanged += new System.EventHandler(this.textField_Teacher_TextChanged);
            // 
            // textField_Subject
            // 
            this.textField_Subject.FormattingEnabled = true;
            this.textField_Subject.Location = new System.Drawing.Point(34, 140);
            this.textField_Subject.Name = "textField_Subject";
            this.textField_Subject.Size = new System.Drawing.Size(199, 21);
            this.textField_Subject.TabIndex = 22;
            // 
            // textField_Group
            // 
            this.textField_Group.FormattingEnabled = true;
            this.textField_Group.Location = new System.Drawing.Point(239, 140);
            this.textField_Group.Name = "textField_Group";
            this.textField_Group.Size = new System.Drawing.Size(119, 21);
            this.textField_Group.TabIndex = 23;
            // 
            // textField_Aud
            // 
            this.textField_Aud.FormattingEnabled = true;
            this.textField_Aud.Location = new System.Drawing.Point(364, 87);
            this.textField_Aud.Name = "textField_Aud";
            this.textField_Aud.Size = new System.Drawing.Size(119, 21);
            this.textField_Aud.TabIndex = 24;
            // 
            // textField_Number
            // 
            this.textField_Number.FormattingEnabled = true;
            this.textField_Number.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.textField_Number.Location = new System.Drawing.Point(364, 140);
            this.textField_Number.Name = "textField_Number";
            this.textField_Number.Size = new System.Drawing.Size(119, 21);
            this.textField_Number.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(224, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "РАСПИСАНИЕ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(19, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Кафедра";
            // 
            // dropList_Cath
            // 
            this.dropList_Cath.BackColor = System.Drawing.SystemColors.Window;
            this.dropList_Cath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropList_Cath.FormattingEnabled = true;
            this.dropList_Cath.Location = new System.Drawing.Point(116, 56);
            this.dropList_Cath.Name = "dropList_Cath";
            this.dropList_Cath.Size = new System.Drawing.Size(174, 26);
            this.dropList_Cath.TabIndex = 31;
            this.dropList_Cath.TextChanged += new System.EventHandler(this.dropList_Cath_TextChanged);
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.courseLabel.Location = new System.Drawing.Point(272, 58);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(43, 20);
            this.courseLabel.TabIndex = 34;
            this.courseLabel.Text = "Курс";
            // 
            // dropList_Course
            // 
            this.dropList_Course.BackColor = System.Drawing.SystemColors.Window;
            this.dropList_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dropList_Course.FormattingEnabled = true;
            this.dropList_Course.Location = new System.Drawing.Point(239, 87);
            this.dropList_Course.Name = "dropList_Course";
            this.dropList_Course.Size = new System.Drawing.Size(119, 21);
            this.dropList_Course.TabIndex = 33;
            this.dropList_Course.TextChanged += new System.EventHandler(this.dropList_Course_TextChanged);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataToolStripMenuItem,
            this.AboutAuditToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(550, 24);
            this.Menu.TabIndex = 35;
            this.Menu.Text = "menuStrip1";
            // 
            // DataToolStripMenuItem
            // 
            this.DataToolStripMenuItem.Name = "DataToolStripMenuItem";
            this.DataToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.DataToolStripMenuItem.Text = "Файл";
            this.DataToolStripMenuItem.Click += new System.EventHandler(this.DataToolStripMenuItem_Click);
            // 
            // AboutAuditToolStripMenuItem
            // 
            this.AboutAuditToolStripMenuItem.Name = "AboutAuditToolStripMenuItem";
            this.AboutAuditToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.AboutAuditToolStripMenuItem.Text = "Аудитория";
            this.AboutAuditToolStripMenuItem.Click += new System.EventHandler(this.AboutAuditToolStripMenuItem_Click);
            // 
            // gB_Schedule
            // 
            this.gB_Schedule.BackColor = System.Drawing.Color.Ivory;
            this.gB_Schedule.Controls.Add(this.btt_DeleteSchLine);
            this.gB_Schedule.Controls.Add(this.Table);
            this.gB_Schedule.Controls.Add(this.label8);
            this.gB_Schedule.Location = new System.Drawing.Point(0, 373);
            this.gB_Schedule.Name = "gB_Schedule";
            this.gB_Schedule.Size = new System.Drawing.Size(550, 436);
            this.gB_Schedule.TabIndex = 37;
            this.gB_Schedule.TabStop = false;
            // 
            // btt_DeleteSchLine
            // 
            this.btt_DeleteSchLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btt_DeleteSchLine.Location = new System.Drawing.Point(164, 393);
            this.btt_DeleteSchLine.Name = "btt_DeleteSchLine";
            this.btt_DeleteSchLine.Size = new System.Drawing.Size(221, 29);
            this.btt_DeleteSchLine.TabIndex = 37;
            this.btt_DeleteSchLine.Text = "Удалить выбранную пару";
            this.btt_DeleteSchLine.UseVisualStyleBackColor = true;
            this.btt_DeleteSchLine.Click += new System.EventHandler(this.btt_DeleteSchLine_Click);
            // 
            // dtp_Teach
            // 
            this.dtp_Teach.Location = new System.Drawing.Point(249, 26);
            this.dtp_Teach.Name = "dtp_Teach";
            this.dtp_Teach.Size = new System.Drawing.Size(200, 20);
            this.dtp_Teach.TabIndex = 38;
            this.dtp_Teach.ValueChanged += new System.EventHandler(this.dtp_Teach_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(99, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Выберите Дату: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Ivory;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_Teach);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.courseLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dropList_Course);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textField_Teacher);
            this.groupBox1.Controls.Add(this.textField_Subject);
            this.groupBox1.Controls.Add(this.textField_Group);
            this.groupBox1.Controls.Add(this.textField_Number);
            this.groupBox1.Controls.Add(this.textField_Aud);
            this.groupBox1.Location = new System.Drawing.Point(0, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 232);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Ivory;
            this.groupBox2.Controls.Add(this.facultyLabel);
            this.groupBox2.Controls.Add(this.dropList_Faculty);
            this.groupBox2.Controls.Add(this.dropList_Cath);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(0, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 100);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(550, 800);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gB_Schedule);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audit";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.gB_Schedule.ResumeLayout(false);
            this.gB_Schedule.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.ComboBox dropList_Faculty;
        private System.Windows.Forms.Label facultyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox textField_Teacher;
        private System.Windows.Forms.ComboBox textField_Subject;
        private System.Windows.Forms.ComboBox textField_Group;
        private System.Windows.Forms.ComboBox textField_Aud;
        private System.Windows.Forms.ComboBox textField_Number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox dropList_Cath;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.ComboBox dropList_Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberColumn;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem DataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutAuditToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog DatabaseSearch;
        private System.Windows.Forms.GroupBox gB_Schedule;
        private System.Windows.Forms.DateTimePicker dtp_Teach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btt_DeleteSchLine;
    }
}