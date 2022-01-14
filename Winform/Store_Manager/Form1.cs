using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Store_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            customDesign();
        }

        private void customDesign()
        {
            panelSelector.Visible = false;

        }

        private void showMenu()
        {
            if (panelSelector.Visible == false)
                panelSelector.Visible = true;
        }

        private void hidePanel()
        {
            showMenu();
            if (panelSelector.Visible == true)
                panelSelector.Visible = false;
        }

        private Form activityForm = null;
        private void openForm(Form childrenForm)
        {
            if (activityForm != null)
                activityForm.Close();

            activityForm = childrenForm;
            childrenForm.FormBorderStyle = FormBorderStyle.None; // Bỏ viền ngoài của Form
            childrenForm.Dock = DockStyle.Fill;  //Đổ đầy form store vào panelChild
            childrenForm.TopLevel = false; // Không thêm thì dòng dưới không chạy
            panelChild.Controls.Add(childrenForm); //Thêm Form lene panelChild
            childrenForm.BringToFront(); //Store form nằm trên panelChild
            childrenForm.Show();
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            showMenu();
        }

        private void vegetableBtn_Click(object sender, EventArgs e)
        {
            openForm(new Store());
            hidePanel();
        }

        private void meatBtn_Click(object sender, EventArgs e)
        {
            openForm(new Store());
            hidePanel();
        }

        private void spiceBtn_Click(object sender, EventArgs e)
        {
            openForm(new Store());
            hidePanel();
        }

        private void connect()
        {
            SqlConnection vegetable = new SqlConnection();
            SqlConnection meat = new SqlConnection();
            SqlConnection spice = new SqlConnection();
            SqlConnection dataList = new SqlConnection();
        }

            private void helpBtn_Click(object sender, EventArgs e)
        {
            openForm(new Help());
            hidePanel();

        }
    }
}
