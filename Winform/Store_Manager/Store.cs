using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Manager
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();

            customeDeisgn();
        }

        private void customeDeisgn()
        {
            panelSelector.Visible = false;
            tittle.Text = "Store data:";
            tittleData.Visible = false;
            storeData.Location = new Point(335, 80);
            dataList.Visible = false;
            receiptBtn.Visible = false;
            deleBtn.Visible = false;
            panelStatistical.Visible = false;
        }

        private void showMenu()
        {
            if(panelSelector.Visible == false || tittleData.Visible == false || deleBtn.Visible == false ||
                receiptBtn.Visible == false || dataList.Visible == false)
            {
                panelSelector.Visible = true;
                tittleData.Visible = true;
                storeData.Location = new Point(820, 75);
                dataList.Visible = true;
                receiptBtn.Visible = true;
                deleBtn.Visible = true;
            }
        }

        private void hidePanelForStatistical()
        {
            showMenu();
            if (panelSelector.Visible == true || tittleData.Visible == true || deleBtn.Visible == true ||
                receiptBtn.Visible == true || dataList.Visible == true)
            {
                panelSelector.Visible = false;
                tittleData.Visible = false;
                dataList.Visible = false;
                receiptBtn.Visible = false;
                deleBtn.Visible = false;
            }
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
            panelStatistical.Controls.Add(childrenForm); //Thêm Form lene panelChild
            childrenForm.BringToFront(); //Store form nằm trên panelChild
            childrenForm.Show();
        }

        private void wareBtn_Click(object sender, EventArgs e)
        {
            panelStatistical.Visible = false;
            tittle.Text = "In put:";
            showMenu();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            panelStatistical.Visible = false;
            tittle.Text = "Out put:";
            showMenu();
        }

        private void statisticalBtn_Click(object sender, EventArgs e)
        {
            hidePanelForStatistical();
            panelStatistical.Visible = true;
            receiptBtn.Visible = false;
            deleBtn.Visible = false;
            openForm(new Statistical());
        }

        private void receiptBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void deleBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
