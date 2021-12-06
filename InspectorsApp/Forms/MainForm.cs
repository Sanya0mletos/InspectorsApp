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
    public partial class MainForm : Form
    {
        public database db = new database();

        public Drivers dr { get; set; }
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            driversBindingSource.DataSource = db.Drivers.ToList();          
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            AddForm addform = new AddForm();
          //  addform.Show();
            addform.db = db;
            if (addform.ShowDialog() == DialogResult.OK)
            {
                driversBindingSource.DataSource = db.Drivers.ToList();
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            Drivers driver = (Drivers)driversBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить роль - " + driver.ID.ToString(),
                "Удаление роли", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                db.Drivers.Remove(driver);
            }
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            driversBindingSource.DataSource = db.Drivers.ToList();
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            Drivers driver = (Drivers)driversBindingSource.Current;
            AddForm addform = new AddForm();
            addform.db = db;
            addform.drivers = driver;
            if (addform.ShowDialog() == DialogResult.OK)
            {
                driversBindingSource.DataSource = db.Drivers.ToList();
            }
        }
    }
}
