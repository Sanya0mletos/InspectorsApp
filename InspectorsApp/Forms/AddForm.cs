using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InspectorsApp.Forms;
using InspectorsApp.Models;

namespace InspectorsApp.Forms
{
    public partial class AddForm : Form
    {
        public Drivers drivers { get; set; } = null;      
        public database db { get; set; }
        public AddForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (FirstName_Box.Text == "" || PassportBox.Text == "" || AddressBox.Text == ""
                 || JobBox.Text == "" || DoljonstBox.Text == "" || PhoneBox.Text == "" || emailBox.Text == "" || MiddleBox.Text == "")
            {
                MessageBox.Show("Нужно ввести все требуемые данные");
                return;
            }
            if (drivers == null)
            {
                Drivers drivers = new Drivers
                {
                    Name = $"{FirstName_Box.Text} {SecondName_Box.Text}",
                    MiddleName = MiddleBox.Text,
                    PassportSerial = Convert.ToInt32(PassportBox.Text),
                    PassportNumber = Convert.ToInt32(PassportNumberBox.Text),
                    Address = AddressBox.Text,
                    AddressLife = AddressLifeBox.Text,
                    Company = JobBox.Text,
                    JobName = DoljonstBox.Text,
                    Phone = PhoneBox.Text,
                    Email = emailBox.Text,
                    Description = OpisanieBox.Text
                };

                db.Drivers.Add(drivers);
            }
            else
            {
                drivers.Name = $"{FirstName_Box.Text} {SecondName_Box.Text}";
                drivers.MiddleName = MiddleBox.Text;
                drivers.PassportSerial = Convert.ToInt32(PassportBox.Text);
                drivers.PassportNumber = Convert.ToInt32(PassportNumberBox.Text);
                drivers.Address = AddressBox.Text;
                drivers.AddressLife = AddressLifeBox.Text;
                drivers.Company = JobBox.Text;
                drivers.JobName = DoljonstBox.Text;
                drivers.Phone = PhoneBox.Text;
                drivers.Email = emailBox.Text;
                drivers.Description = OpisanieBox.Text;
            }
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void MiddleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecondNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            if (drivers == null)
            {
                this.Text = "Добавление пользователя";
            }
            else
            {
                this.Text = "Изменение пользователя";
                IdentificatorBox.Text = Convert.ToString(drivers.ID);
                FirstName_Box.Text = drivers.Name;
                SecondName_Box.Enabled = false;
                MiddleBox.Text = drivers.MiddleName;
                PassportBox.Text = Convert.ToString(drivers.PassportSerial);
                PassportNumberBox.Text = Convert.ToString(drivers.PassportNumber);
                AddressBox.Text = drivers.Address;
                AddressLifeBox.Text = drivers.AddressLife;
                JobBox.Text = drivers.Company;
                DoljonstBox.Text = drivers.JobName;
                PhoneBox.Text = drivers.Phone;
                emailBox.Text = drivers.Email;
                OpisanieBox.Text = drivers.Description;
            }
            
        }
    }
}
