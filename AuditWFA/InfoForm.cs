using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AuditWFA
{
    public partial class InfoForm : Form
    {
        private bool buttonsEnabled = false;
        private bool allFieldsFilled = true;
        private string AuditoriesPath;

        Dictionary<string, List<string>> auditoriesDC;
        public InfoForm(Dictionary<string, List<string>> auditoriesDC,string AuditoriesPath)
        {
            InitializeComponent();

            this.auditoriesDC = auditoriesDC;
            this.AuditoriesPath = AuditoriesPath;

            setAuditories();
            hideButtons();
        }

        public void hideButtons()
        {
            btt_OK.Visible = btt_Cancel.Visible = false;
            buttonsEnabled = false;
            readOnly(buttonsEnabled);
        }

        public void showButtons()
        {
            btt_OK.Visible = btt_Cancel.Visible = true;
            buttonsEnabled = true;
            readOnly(buttonsEnabled);
        }

        private void btt_Edit_Click(object sender, EventArgs e)
        {
            if (buttonsEnabled)
            {
                hideButtons();
            }
            else if(!buttonsEnabled)
            {
                showButtons();
            }
        }

        private void btt_OK_Click(object sender, EventArgs e)
        {
            if (checkForFilledFields())
            {
                auditoriesDC[dropList_Auditory.Text].Clear();

                auditoriesDC[dropList_Auditory.Text].Add(txt_Places.Text);
                auditoriesDC[dropList_Auditory.Text].Add(txt_PCs.Text);
                auditoriesDC[dropList_Auditory.Text].Add(txt_Projector.Text);
                auditoriesDC[dropList_Auditory.Text].Add(txt_Condition.Text);
                auditoriesDC[dropList_Auditory.Text].Add(txt_Secure.Text);

                saveEditedAuditories();

                hideButtons();
            }
            else
            {
                MessageBox.Show("ADD INFO");
            }
            
        }

        private void setFields()
        {
            txt_Places.Text = auditoriesDC[dropList_Auditory.Text][0];
            txt_PCs.Text = auditoriesDC[dropList_Auditory.Text][1];
            txt_Projector.Text = auditoriesDC[dropList_Auditory.Text][2];
            txt_Condition.Text = auditoriesDC[dropList_Auditory.Text][3];
            txt_Secure.Text = auditoriesDC[dropList_Auditory.Text][4];
        }

        private void clearFields()
        {
            txt_Places.Text = "";
            txt_PCs.Text = "";
            txt_Projector.Text = "";
            txt_Condition.Text = "";
            txt_Secure.Text = "";
        }

        private void dropList_Auditory_TextChanged(object sender, EventArgs e)
        {
            clearFields();
            setFields();
        }

        private void readOnly(bool state)
        {
            txt_Places.ReadOnly = !state;
            txt_PCs.ReadOnly = !state;
            txt_Projector.ReadOnly = !state;
            txt_Condition.ReadOnly = !state;
            txt_Secure.ReadOnly = !state;
        }

        private void setAuditories()
        {
            foreach(KeyValuePair<string,List<string>> dc in auditoriesDC)
            {
                dropList_Auditory.Items.Add(dc.Key);
            }
        }

        private bool checkForFilledFields()
        {
            if(txt_Places.Text != "" && txt_Places.Text != " " && txt_PCs.Text != "" && txt_PCs.Text != " " && txt_Projector.Text != "" && txt_Projector.Text != " " && txt_Condition.Text != "" && txt_Condition.Text != " " && txt_Secure.Text != "" && txt_Secure.Text != " ")
            {
                allFieldsFilled = true;
            }
            else
            {
                allFieldsFilled = false;
            }
            return allFieldsFilled;
        }

        private void saveEditedAuditories()
        {
            List<string> conts = new List<string>();

            foreach(KeyValuePair<string,List<string>> dc in auditoriesDC)
            {
                //аудитории из списка
                conts.Add(dc.Key);

                foreach(string s in dc.Value)
                {
                    //все параметры аудитории
                    conts.Add(s);
                }
                conts.Add(" ");
            }

            string[] contents = conts.Select(i => i.ToString()).ToArray();

            File.WriteAllLines(AuditoriesPath, contents, Encoding.Unicode);
        }
    }
}