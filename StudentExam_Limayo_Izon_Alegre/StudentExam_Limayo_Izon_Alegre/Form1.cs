using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExam_Limayo_Izon_Alegre
{
    public partial class Form1 : Form
    {
        double quizScore, examScore, myExamScore, myQuiz, ave, totalquiz;
        string quiz, totave;
        StudentExam_Limayo_Izon_Alegre.Models.Student newStudent = new StudentExam_Limayo_Izon_Alegre.Models.Student();
        StudentExam_Limayo_Izon_Alegre.Models.Exam newExam = new StudentExam_Limayo_Izon_Alegre.Models.Exam();
        Boolean a = false, b = false, c = false, d = false, ed = false, f = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            try
            {
                if (a == false)
                {

                    lbl1.Text = "Quiz 2:";
                    quizScore = Convert.ToDouble(txtInput.Text);
                    quiz = "Quiz 1: " + quizScore;
                    newStudent.myGrade.Add(quizScore);
                    listBoxGrades.Items.Add(quiz);
                    totalquiz = quizScore;
                    myQuiz = newExam.ComputeExam(0, totalquiz);

                    a = true;
                    b = false;
                    c = false;
                    d = false;
                    ed = false;
                    txtInput.Text = "";
                    txtInput.Select();
                }
                else if (b == false)
                {
                    lbl1.Text = "Quiz 3:";
                    quizScore = Convert.ToDouble(txtInput.Text);
                    quiz = "Quiz 2: " + quizScore;
                    newStudent.myGrade.Add(quizScore);
                    listBoxGrades.Items.Add(quiz);
                    totalquiz = totalquiz + quizScore;
                    myQuiz = newExam.ComputeExam(0, totalquiz);

                    a = true;
                    b = true;
                    c = false;
                    d = false;
                    ed = false;
                    txtInput.Text = "";
                    txtInput.Select();
                }
                else if (c == false)
                {
                    lbl1.Text = "Quiz 4:";
                    quizScore = Convert.ToDouble(txtInput.Text);
                    quiz = "Quiz 3: " + quizScore;
                    newStudent.myGrade.Add(quizScore);
                    listBoxGrades.Items.Add(quiz);
                    totalquiz = totalquiz + quizScore;
                    myQuiz = newExam.ComputeExam(0, totalquiz);

                    a = true;
                    b = true;
                    c = true;
                    d = false;
                    ed = false;
                    txtInput.Text = "";
                    txtInput.Select();
                }
                else if (d == false)
                {
                    lbl1.Text = "Final Exam:";
                    quizScore = Convert.ToDouble(txtInput.Text);
                    quiz = "Quiz 4: " + quizScore;
                    newStudent.myGrade.Add(quizScore);
                    listBoxGrades.Items.Add(quiz);
                    totalquiz = totalquiz + quizScore;
                    myQuiz = newExam.ComputeExam(0, totalquiz);


                    newExam.Score = totalquiz;
                    listBoxGrades.Items.Add(myQuiz);

                    a = true;
                    b = true;
                    c = true;
                    d = true;
                    ed = false;
                    txtInput.Text = "";
                    txtInput.Select();
                }
                else if (ed == false)
                {
                    examScore = Convert.ToDouble(txtInput.Text);
                    quiz = "Final Exam: " + quizScore;
                    newStudent.myGrade.Add(quizScore);
                    listBoxGrades.Items.Add(quiz);
                    myExamScore = newExam.ComputeExam(1, examScore);
                    listBoxGrades.Items.Add(myExamScore);
                    a = true;
                    b = true;
                    c = true;
                    d = true;
                    ed = true;
                    txtInput.Text = "";
                    txtInput.Enabled = false;
                    btnInput.Enabled = false;
                    lbl6.Show();
                    lbl_ave.Show();
                }
            }
            catch (Exception er) { MessageBox.Show("Grade is number "); txtInput.Text = ""; }
        }

        private void txtStudentNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            txtInput.Enabled = true;
            btn_compute.Enabled = true;
            newStudent.StudentNumber = Convert.ToString(txtStudentNumber.Text);
            newStudent.Name = Convert.ToString(txtName.Text);
            try
            {
                newStudent.Age = Convert.ToInt32(txtAge.Text);
            }
            catch (Exception es) { MessageBox.Show("Age must be number "); txtAge.Text = ""; }
            newStudent.Gender = Convert.ToString(txtGender.Text);
            if (txtAge.Text != "" && txtName.Text != "" && txtGender.Text != "" && txtStudentNumber.Text != "")
            {
                //label
                lbl1.Show();
                txtInput.Show();
                btnInput.Show();
                btnCompute.Show();
                listBoxGrades.Show();
            }
        }

        private void btn_compute_Click(object sender, EventArgs e)
        {
            if (btn_compute.Text == "COMPUTE")
            {
                newStudent.ComputeGrade(myQuiz, myExamScore);

                lbl_ave.Text = Convert.ToString(newStudent.FinalGrade);
                totave = "Average is " + newStudent.FinalGrade + ":)))";
                listBoxGrades.Items.Add(totave);
                listBoxGrades.Items.Add(newStudent.passed);
                btn_compute.Text = "RESET";
                btnExit.Show();
            }
            else
            {
                lbl_ave.Hide();
                lbl6.Hide();
                lbl1.Hide();
                txtInput.Hide();
                btnInput.Hide();
                btn_compute.Hide();
                listBoxGrades.Hide();
                lbl1.Text = "Quiz 1:";
                txtAge.Text = "";
                txtInput.Text = "";
                txtGender.Text = "";
                txtName.Text = "";
                txtStudentNumber.Text = "";
                listBoxGrades.Items.Clear();
                txtStudentNumber.Select();
                btn_compute.Text = "COMPUTE";
                btnExit.Hide();
                a = false;
                b = false;
                c = false;
                d = false;
                ed = false;
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
