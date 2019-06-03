using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Models;

namespace ccb_ef6
{
    public partial class frmNewOrUpdateCourse : Form
    {
        private Course Course = null;
        private bool IsNewCourse;

        public frmNewOrUpdateCourse()
        {
            InitializeComponent();
        }

        public frmNewOrUpdateCourse(Course Course)
        {
            InitializeComponent();
            this.Course = Course;
            FillTextBoxSince(Course);
            txtTitle.ReadOnly = true;
        }

        private void frmNewOrUpdateCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            //Registrar cliente en la BD
            if (Course == null)
            {
                IsNewCourse = true;
                Course = new Course();

                AssignDataFromTextBox(Course);

                try
                {
                    //Creo al cliente e inmediatamente creo su cuenta correspondiente
                    BLL.CourseServices.AddNew(Course);

                    MessageBox.Show("Cliente agregado satisfactoriamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else//Actualizar cliente en la BD
            {
                try
                {
                    IsNewCourse = false;
                    AssignDataFromTextBox(Course);
                    BLL.CourseServices.Update(Course);
                    MessageBox.Show("Cliente actualizado satisfactoriamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, "Debe ingresar un nombre");
                txtTitle.Focus();
                return false;
            }
            errorProvider1.SetError(txtTitle, "");

            if (string.IsNullOrEmpty(txtCredits.Text))
            {
                errorProvider1.SetError(txtCredits, "Debe ingresar el apellido paterno");
                txtCredits.Focus();
                return false;
            }
            errorProvider1.SetError(txtCredits, "");

            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, "Debe ingresar un nombre de usuario");
                txtTitle.Focus();
                return false;
            }
            errorProvider1.SetError(txtTitle, "");


            if (BLL.CustomerServices.UsernameExists(txtTitle.Text) && IsNewCourse)
            {
                errorProvider1.SetError(txtTitle, "El nombre de usuario ya existe, elija uno diferente");
                txtTitle.Focus();
                return false;
            }
            errorProvider1.SetError(txtTitle, "");

            return true;
        }

        private void AssignDataFromTextBox(Course Course)
        {
            Course.Title = txtTitle.Text;
            Course.Credits = Convert.ToInt32( txtCredits.Text);
        }

        private void FillTextBoxSince(Course Course)
        {
            txtTitle.Text = Course.Title;
            txtCredits.Text = Convert.ToString(Course.Credits);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                var student = new Student { FirstMidName = "Carson", LastName = "Alexander", EnrollmentDate = DateTime.Parse("2005-09-01") };

                db.Students.Add(student);
                db.SaveChanges();
            }
 
        }
    }
}
