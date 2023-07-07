using ADMIN.DTO;
using ADMIN.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customize();
            
        }
        private void customize()
        {
            subpanelQLC.Visible = false;
            subpanelQLKH.Visible = false;
            subpanelQLNV.Visible = false;
            subpanelQLTB.Visible = false;
        }
        private void HideSubMenu()
        {
            if (subpanelQLC.Visible == true)
                subpanelQLC.Visible = false;
            subpanelQLKH.Visible = false;
            if (subpanelQLKH.Visible == true)
                subpanelQLKH.Visible = false;
            subpanelQLC.Visible = false;
            if (subpanelQLNV.Visible == true)
                subpanelQLNV.Visible = false;
            subpanelQLKH.Visible = false;
            subpanelQLC.Visible = false;
            if(subpanelQLTB.Visible==true)
                subpanelQLTB.Visible=false;
                subpanelQLNV.Visible = false;
            subpanelQLKH.Visible = false;
            subpanelQLC.Visible = false;


        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void QLTB_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subpanelQLTB);
        }

        private void btnQLNV_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(subpanelQLNV);
        }

        private void btnQLC_Click_1(object sender, EventArgs e)
        {
            ShowSubMenu(subpanelQLC);
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subpanelQLKH);

        }

        private void but_TB_Click(object sender, EventArgs e)
        {
            HideSubMenu();
           panelfull.Controls.Clear();
            NEWSS nEWSS= new NEWSS();
            
            panelfull.Controls.Add(nEWSS);
           
             
        }

        private void butTTKH_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            panelfull.Controls.Clear();
            panelfull.Controls.Add(new TTKH());
           
        }
        private void but_record_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            panelfull.Controls.Clear();
            RECORD rECORD= new RECORD();
            rECORD.Visible = true;
           
            
            

        }
    }
}
