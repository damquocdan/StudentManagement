﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManagement
{
    public partial class FormRegesterSubjectClass : Form
    {
        StudentManagementEntities db = new StudentManagementEntities();
        private int[] ArrIdClass = new int[100];

        public FormRegesterSubjectClass(int id)
        {

            InitializeComponent();
            loadSubject();
        }
        public class SubjectWithTeacher
        {
            public int IdSubject { get; set; }
            public string SubjectName { get; set; }
            public int IdTeacher { get; set; }
            public string TeacherName { get; set; }
            public string FacultyName { get; set; }

            public string DisplayText => $"{SubjectName} - {TeacherName}";
            public string DisplayId => $"{IdSubject} - {IdTeacher}";
        }
        private List<SubjectWithTeacher> listSubject = new List<SubjectWithTeacher>();
        private List<SubjectWithTeacher> listSelectedSubject = new List<SubjectWithTeacher>();

        private void loadSubject()
        {
            var query = from c in db.Faculty
                        select new { id = c.IdFaculty, Khoa = c.FacultyName };
            for (int i = 0; i < query.Count(); i++)
            {
                comboBox2.Items.Add(query.ToArray()[i].Khoa);
            }

            var className = db.ClassRoom;
            for (int i = 0; i < className.Count(); i++)
            {
                ArrIdClass[i] = className.ToArray()[i].IdClass;
                comboBox1.Items.Add(className.ToArray()[i].ClassName);
            }



            listSubject = (from c in db.Subject
                           join u in db.Teacher
                           on c.IdTeacher equals u.IdTeacher
                           join z in db.Account
                           on u.idUser equals z.Id
                           select new SubjectWithTeacher
                           {
                               IdSubject = c.IdSubject,
                               SubjectName = c.SubjectName,
                               IdTeacher = u.IdTeacher,
                               TeacherName = z.FullName,
                               FacultyName = c.Faculty.FacultyName
                           }).ToList();
            lstMatHang.DataSource = listSubject;
            lstMatHang.DisplayMember = "DisplayText";
            lstMatHang.ValueMember = "DisplayId";
            lstMatHang.HorizontalScrollbar = true;
            lstDaChon.HorizontalScrollbar = true;
            listSelectedSubject.Clear();
            lstDaChon.DataSource = null;
        }

        private void btnMoveOne_Click(object sender, EventArgs e)
        {
            if (lstMatHang.SelectedItems.Count > 0)
            {
                SubjectWithTeacher selectedSubject = (SubjectWithTeacher)lstMatHang.SelectedItem;

                // Thêm môn học đã chọn vào danh sách "listSelectedSubject"
                listSelectedSubject.Add(selectedSubject);

                // Xóa môn học đã chọn khỏi danh sách "listSubject" và danh sách "lstMatHang"
                listSubject.Remove(selectedSubject);

                // Cập nhật lại danh sách nguồn cho danh sách "lstMatHang"
                lstMatHang.DataSource = null;
                lstMatHang.DataSource = listSubject;
                lstMatHang.DisplayMember = "DisplayText";
                lstMatHang.ValueMember = "DisplayId";

                // Cập nhật lại danh sách nguồn cho danh sách "lstDaChon"
                lstDaChon.DataSource = null;
                lstDaChon.DataSource = listSelectedSubject;
                lstDaChon.DisplayMember = "DisplayText";
                lstDaChon.ValueMember = "DisplayId";
            }
        }

        private void btnMoveAll_Click(object sender, EventArgs e)
        {
            if (lstMatHang.Items.Count > 0)
            {
                List<SubjectWithTeacher> allSubjects = listSubject.ToList();
                foreach (var subject in allSubjects)
                {
                    listSelectedSubject.Add(subject);
                }
                listSubject.Clear();
                lstMatHang.DataSource = null;
                lstMatHang.DataSource = listSubject;
                lstMatHang.DisplayMember = "DisplayText";
                lstMatHang.ValueMember = "DisplayId";

                // Cập nhật lại danh sách nguồn cho danh sách "lstDaChon"
                lstDaChon.DataSource = null;
                lstDaChon.DataSource = listSelectedSubject;
                lstDaChon.DisplayMember = "DisplayText";
                lstDaChon.ValueMember = "DisplayId";
            }
        }

        private void btnRemoveOne_Click(object sender, EventArgs e)
        {
            if (lstDaChon.SelectedItems.Count > 0)
            {
                SubjectWithTeacher selectedSubject = (SubjectWithTeacher)lstDaChon.SelectedItem;

                listSubject.Add(selectedSubject);
                listSelectedSubject.Remove(selectedSubject);

                lstMatHang.DataSource = null;
                lstMatHang.DataSource = listSubject;
                lstMatHang.DisplayMember = "DisplayText";
                lstMatHang.ValueMember = "DisplayId";

                lstDaChon.DataSource = null;
                lstDaChon.DataSource = listSelectedSubject;
                lstDaChon.DisplayMember = "DisplayText";
                lstDaChon.ValueMember = "DisplayId";
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (lstDaChon.Items.Count > 0)
            {
                // Lấy tất cả các môn học từ danh sách "listSelectedSubject"
                List<SubjectWithTeacher> allSelectedSubjects = listSelectedSubject.ToList();

                // Thêm tất cả các môn học vào danh sách "listSubject"
                foreach (var subject in allSelectedSubjects)
                {
                    listSubject.Add(subject);
                }

                // Xóa tất cả các môn học khỏi danh sách "listSelectedSubject"
                listSelectedSubject.Clear();

                // Cập nhật lại danh sách nguồn cho danh sách "lstMatHang"
                lstMatHang.DataSource = null;
                lstMatHang.DataSource = listSubject;
                lstMatHang.DisplayMember = "DisplayText";
                lstMatHang.ValueMember = "DisplayId";

                // Cập nhật lại danh sách nguồn cho danh sách "lstDaChon"
                lstDaChon.DataSource = null;
                lstDaChon.DataSource = listSelectedSubject;
                lstDaChon.DisplayMember = "DisplayText";
                lstDaChon.ValueMember = "DisplayId";
            }
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            listSubject.Clear();

            var data = (from c in db.Subject
                        join u in db.Teacher
                        on c.IdTeacher equals u.IdTeacher
                        join z in db.Account
                        on u.idUser equals z.Id
                        select new SubjectWithTeacher
                        {
                            IdSubject = c.IdSubject,
                            SubjectName = c.SubjectName,
                            IdTeacher = u.IdTeacher,
                            TeacherName = z.FullName,
                            FacultyName = c.Faculty.FacultyName,
                        });

            lstMatHang.HorizontalScrollbar = true;
            lstDaChon.HorizontalScrollbar = true;
            

            string monhoc = textBox1.Text;
            string khoa = comboBox2.Text;
            string giangvien = textBox3.Text;

            if (monhoc != "")
            {
                data = data.Where(c => c.SubjectName.Contains(monhoc));
            }

            if (giangvien != "")
            {
                data = data.Where(c => c.TeacherName.Contains(giangvien));
            }

            if (khoa != "Chọn khoa")
            {
                data = data.Where(c => c.FacultyName == khoa);
            }



            listSubject = data.ToList();

            listSelectedSubject.Clear();
            lstMatHang.DataSource = null;
            lstMatHang.DataSource = listSubject;
            lstMatHang.DisplayMember = "DisplayText";
            lstMatHang.ValueMember = "DisplayId";

            // Cập nhật lại danh sách nguồn cho danh sách "lstDaChon"
            lstDaChon.DataSource = null;
            lstDaChon.DataSource = listSelectedSubject;
            lstDaChon.DisplayMember = "DisplayText";
            lstDaChon.ValueMember = "DisplayId";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "Chọn lớp học")
            {
                int IdClassSelected = ArrIdClass[comboBox1.SelectedIndex];
                if (listSelectedSubject.Count > 0)
                {
                    var listStudent = db.Student.Where(c => c.IdClass == IdClassSelected).ToList();
                    try
                    {
                        foreach (var student in listStudent)
                        {
                            try
                            {
                                foreach (var subject in listSelectedSubject)
                                {
                                    var markFind = db.Mark.FirstOrDefault(m=> 
                                                m.IdStudent == student.IdStudent &&
                                                m.IdTeacher == subject.IdTeacher &&
                                                m.IdSubject == subject.IdSubject);
                                    if (markFind == null)
                                    {
                                        Mark mark = new Mark()
                                        {
                                            IdStudent = student.IdStudent,
                                            IdTeacher = subject.IdTeacher,
                                            IdSubject = subject.IdSubject,
                                        };
                                        db.Mark.Add(mark);
                                        db.SaveChanges();
                                    }
                                }
                            }
                            catch { }
                        }
                        MessageBox.Show("Đăng ký môn học thành công", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi server", "Thông báo");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn lớp học", "Thông báo");
            }
        }
    }
}
