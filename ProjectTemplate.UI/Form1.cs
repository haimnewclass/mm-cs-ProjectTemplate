using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Entities;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ProjectTemplate.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entities.MainManager.Instance.Students.AddNewStudent(textBox1.Text, 20);
        }

        private void button2_Click(object sender, EventArgs e)
        {


            MainManager.Instance.Students.CalcMilga();

           
        }
    }
}
