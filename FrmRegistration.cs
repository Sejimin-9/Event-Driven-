using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public static string value;
        public static FrmRegistration inst;
        StudentInfoClass sem = new StudentInfoClass();
        public FrmRegistration()
        {
            inst = this;
            InitializeComponent();
        }
        private DelegateText dValue;
        private DelegateNumber dNum;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = Int64.Parse(textBox1.Text);
            StudentInfoClass.Program = BSBA.Text.ToString();
            StudentInfoClass.LastName = textBox2.Text.ToString();
            StudentInfoClass.FirstName = textBox5.Text.ToString();
            StudentInfoClass.MiddleName = textBox7.Text.ToString();
            StudentInfoClass.Age = Int64.Parse(textBox3.Text);
            StudentInfoClass.ContactNo = Int64.Parse(textBox6.Text);
            StudentInfoClass.Address = textBox4.Text.ToString();
     
            FrmConfirm fcm = new FrmConfirm();
            fcm.ShowDialog();
        }
    }
}
