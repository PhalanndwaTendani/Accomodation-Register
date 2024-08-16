using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023393305_Question2._1
{
    public partial class frmAccomodationSystem : Form
    {
        public frmAccomodationSystem()
        {
            InitializeComponent();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnKhaki_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            RadioButton rbtnClicked = (RadioButton)sender;

            if (rbtnClicked == rbtnKhaki)
            {
                this.BackColor = Color.Khaki;
            }
            else if (rbtnClicked == rbtnLime )
            {
                this.BackColor = Color.Lime;
            }
            else if (rbtnClicked ==rbtnYellow)
            {
                this.BackColor = Color.Yellow;
            }
            else if (rbtnClicked == rbtnSilver)
            {
                this.BackColor = Color.Silver;
            }
            else if (rbtnClicked == rbtnCoral)
            {
                this.BackColor = Color.Coral;
            }
            else if (rbtnClicked==rbtnGold)
            {
                this.BackColor = Color.Gold;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInitials.Clear();
            txtPhone.Clear();
            txtStudentNumber.Clear();
            txtSurname.Clear();
            nudAge.ResetText();
            dtpMoveInDate.ResetText();
            cmbGender.ResetText();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string sStudentNo = txtStudentNumber.Text;
            string sSurname = txtSurname.Text;
            string sInitials = txtInitials.Text;
            string sPhone = txtPhone.Text;
            string sGender = cmbGender.Text;
            string sAge = nudAge.Text;
            string sMoveInDate = dtpMoveInDate.Value.ToShortDateString();

            if (string.IsNullOrWhiteSpace(txtStudentNumber.Text)) 
            {
                MessageBox.Show("Student Number is missing","Confirmation",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Surname is missing", "Confirmation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtInitials.Text))
            {
                MessageBox.Show("Initials are missing", "Confirmation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (cmbGender.SelectedIndex==-1)
            {
                MessageBox.Show("Select a valid gender", "Confirmation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(nudAge.Text,out int age) || age <=0)
            {
                MessageBox.Show("Please select a valid age ", "Confirmation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone Number is missing", "Confirmation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thank you for your application.The following are your details: \n" + "\n"
                  + "Student Number: " + sStudentNo + "\n" + "Surname: " + sSurname + "\n"
                  + "Initials: " + sInitials + "\n" + "Gender: "+sGender + "\n" + "Age: " + sAge + "\n" + "Phone: " + sPhone +"\n" +
                  "Date: " + sMoveInDate, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmAccomodationSystem_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
        }
    }
}
