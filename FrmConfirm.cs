using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        public static FrmConfirm instance;
        public static DelegateText DelProgram, DelLastName, DelFirstName,  DelMiddleName, DelAddress;

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();
            instance = this;
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText (StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            label9.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            label10.Text = DelProgram(StudentInfoClass.Program).ToString();
            label11.Text = DelLastName(StudentInfoClass.LastName).ToString();
            label12.Text = DelFirstName(StudentInfoClass.FirstName).ToString(); 
            label13.Text = DelMiddleName(StudentInfoClass.MiddleName).ToString();   
            label14.Text = DelNumAge(StudentInfoClass.Age).ToString();
            label15.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            label16.Text = DelAddress(StudentInfoClass.Address).ToString();





        }
    }
}
