using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        //fields
        private Dictionary<string, List<List<string>>> dc;
        private List<string> localList;
        private bool permissAdd = true;
        private string FacultiesDirectory;
        private string AuditoriesPath;
        private string FullDirectory;
        private List<Teacher> teachers;
        private Dictionary<string, List<string>> coursesDC;
        private Dictionary<string, Dictionary<string, List<string>>> cathDC;
        private Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>> facultDC;
        private Dictionary<string, List<string>> auditoriesDC;

        //construct
        public Form1()
        {
            InitializeComponent();

            DataToolStripMenuItem.PerformClick();

            dc = new Dictionary<string, List<List<string>>>();
            coursesDC = new Dictionary<string, List<string>>();
            cathDC = new Dictionary<string, Dictionary<string, List<string>>>();
            facultDC = new Dictionary<string, Dictionary<string, Dictionary<string, List<string>>>>();
            auditoriesDC = new Dictionary<string, List<string>>();

            setAuditoriesFromFile();

            Courses c = new Courses();
            c.ReadAllCourses(coursesDC, cathDC, facultDC,FacultiesDirectory);

            setFacultiesNew();
        }

        //methods
        private void button1_Click(object sender, EventArgs e)
        {
            if (textField_Teacher.SelectedIndex > -1 && textField_Subject.SelectedIndex > -1 && textField_Group.SelectedIndex > -1 && textField_Aud.SelectedIndex > -1 && textField_Number.SelectedIndex > -1)
            {
                if(Permission())
                {
                    //MessageBox.Show("ACCESS GRANTED");

                    localList = new List<string>();

                    localList.Add(textField_Subject.Text);
                    localList.Add(textField_Group.Text);
                    localList.Add(textField_Aud.Text);
                    localList.Add(textField_Number.Text);

                    if(dc.ContainsKey(textField_Teacher.Text))
                    {
                        dc[textField_Teacher.Text].Add(localList);
                    }
                    else
                    {
                        List<List<string>> n = new List<List<string>>();
                        n.Add(localList);

                        dc.Add(textField_Teacher.Text,n);
                    }

                    this.Table.Rows.Add(textField_Teacher.Text, textField_Subject.Text, textField_Group.Text, textField_Aud.Text, textField_Number.Text);
                }
                else
                {
                    //MessageBox.Show("ACCESS DENIED");
                }
            }
            else
            {
                MessageBox.Show("ADD INFO");
            }
            permissAdd = true;
        }

        private bool Permission()
        {
            if(dc != null && dc.Count > 0 && dc.ContainsKey(textField_Teacher.Text))
            {
                foreach(List<string> list in dc[textField_Teacher.Text])
                {
                    if (textField_Number.Text == list[3])
                    {
                        permissAdd = false;
                        MessageBox.Show("На выбранной паре уже есть занятие");
                        return permissAdd;
                    }
                }
            }
            else if(dc == null)
            {
                dc = new Dictionary<string, List<List<string>>>();
                return permissAdd;
            }
            else
            {
                for (int i = 0; i < Table.RowCount - 1; i++)
                {
                    if (textField_Number.Text == Table.Rows[i].Cells[4].Value.ToString())
                    {
                        if (textField_Aud.Text == Table.Rows[i].Cells[3].Value.ToString())
                        {
                            MessageBox.Show("Выбранная вами аудитория уже занята");
                            permissAdd = false;
                            return permissAdd;
                        }
                        else
                        {
                            permissAdd = true;
                            return permissAdd;
                        }
                    }
                }
            }

            return permissAdd;
        }

        //sets
        public void setTeacherInfo(string path)
        {
            teachers = new List<Teacher>();
            foreach (string file in Directory.EnumerateFiles(path, "*.txt"))
            {
                string teacherName = Path.GetFileNameWithoutExtension(file);
                string[] subjects = File.ReadAllLines(file, Encoding.Unicode);
                
                teachers.Add(new Teacher(teacherName,new List<string>(subjects)));
            }

            foreach(Teacher teacher in teachers)
            {
                if (textField_Teacher.Items.IndexOf(teacher.getSurname()) > -1)
                {

                }
                else
                {
                    textField_Teacher.Items.Add(teacher.getSurname());
                }
            }
        }

        public void setFacultiesNew()
        {
            foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, List<string>>>> facult in facultDC)
            {
                dropList_Faculty.Items.Add(facult.Key);
            }
        }

        public void setDropList_Course()
        {
            foreach (KeyValuePair<string, Dictionary<string, List<string>>> cathedr in facultDC[dropList_Faculty.Text])
            {
                foreach (KeyValuePair<string, List<string>> course in cathedr.Value)
                {
                    dropList_Course.Items.Add(course.Key);
                }
            }
        }

        public void setCathedras()
        {
            foreach (KeyValuePair<string, Dictionary<string, List<string>>> cathedr in facultDC[dropList_Faculty.Text])
            {
                dropList_Cath.Items.Add(cathedr.Key);
            }
        }

        public void setAuditoriesFromFile()
        {
            try
            {
                string[] auditories = File.ReadAllLines(AuditoriesPath, Encoding.Unicode);
                string tmpKey = "";
                List<string> tmpList = new List<string>();

                for (int i = 0; i < auditories.Length; i++)
                {
                    if (auditories[i].Contains("ауд.") || auditories[i].Contains("лаб.") || auditories[i].Contains("ОЦ"))
                    {
                        tmpKey = auditories[i];
                    }
                    else if (auditories[i] == "" || auditories[i] == " ")
                    {
                        auditoriesDC.Add(tmpKey, tmpList);
                        tmpKey = "";
                        tmpList = new List<string>();
                    }
                    else
                    {
                        tmpList.Add(auditories[i]);
                        if (i == auditories.Length - 1)
                        {
                            auditoriesDC.Add(tmpKey, tmpList);
                            tmpKey = "";
                            tmpList = new List<string>();
                        }
                    }
                }

                foreach (KeyValuePair<string, List<string>> dc in auditoriesDC)
                {
                    textField_Aud.Items.Add(dc.Key);
                }
            }
            catch(FileNotFoundException e)
            {
                MessageBox.Show("File was not found");
            }
        }

        //events
        private void textField_Teacher_TextChanged(object sender, EventArgs e)
        {
            textField_Subject.Text = "";
            string SelectedTeacher = textField_Teacher.Text;

            foreach (Teacher teacher in teachers)
            {
                if (teacher.getSurname() == SelectedTeacher)
                {
                    textField_Subject.Items.Clear();

                    foreach(string s in teacher.getSubs())
                    {
                        textField_Subject.Items.Add(s);
                    }
                    break;
                }
            }
        }

        private void dropList_Course_TextChanged(object sender, EventArgs e)
        {
            textField_Group.Items.Clear();
            foreach(string s in coursesDC[dropList_Course.Text])
            {
                textField_Group.Items.Add(s);
            }
            textField_Group.Text = "";
        }

        private void dropList_Cath_TextChanged(object sender, EventArgs e)
        {
            clearFields();
            //file = faculty dir + choosed cathedra
            //teachers from file
            //courses/groups from file

            string totalPath = "";
            totalPath = FacultiesDirectory + "\\" + dropList_Faculty.Text + "\\" + dropList_Cath.Text; //teacher folder, course .txt
            var directories = Directory.GetDirectories(totalPath);
            setTeacherInfo(directories[0]);
            setDropList_Course();
            //Table.column
        }

        private void dropList_Faculty_TextChanged(object sender, EventArgs e)
        {
            setCathedras();
        }

        private void DataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseSearch.ShowDialog() == DialogResult.OK) FullDirectory = DatabaseSearch.SelectedPath;
            AuditoriesPath = FullDirectory + "\\Auditories.txt";
            FacultiesDirectory = FullDirectory + "\\Faculties";
        }

        private void AboutAuditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm inf = new InfoForm(auditoriesDC,AuditoriesPath);
            inf.ShowDialog();
        }

        //clear
        public void clearFields()
        {
            textField_Teacher.Text = "";
            textField_Subject.Text = "";
            textField_Group.Text = "";
            textField_Aud.Text = "";
            textField_Number.Text = "";
        }

        public void clearCourseField()
        {
            dropList_Course.Text = "";
        }

        public void all()
        {
            foreach (KeyValuePair<string, Dictionary<string, Dictionary<string, List<string>>>> facult in facultDC)
            {
                foreach (KeyValuePair<string, Dictionary<string, List<string>>> cathedr in facult.Value)
                {
                    foreach (KeyValuePair<string, List<string>> course in cathedr.Value)
                    {

                    }
                }
            }
        }
    }
}

/*
 You can use ContainsKey:

if (dict.ContainsKey(key)) { ... }

or TryGetValue:

dict.TryGetValue(key, out value);

 */