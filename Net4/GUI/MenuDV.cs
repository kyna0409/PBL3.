using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using Net4;
using System.Reflection.Emit;
using System.Collections;
using System.Security.Policy;
using Net4.DTO;
//using Net4.BLL;
using Net4.DAL;

namespace Net4
{

    public partial class MenuDV : Form
    {
        public string user_name;
        public string role_name;
        public System.Windows.Forms.Label reflb = new System.Windows.Forms.Label();
        bool cancel = false;
        public event EnableOrderButton eob = null;
        Modify modify = new Modify();
        DataTable dataTable;
        Boolean down = false, enter = false;
        int X, Y, MX, MY;
        ChatForm cf;
        SENDORDER so;
        DataTable dtOrder1,dtProduct1,dtProduct2,dtProduct3;
        SENDFEEDBACK sf;
        List<DataTable> listDT;
        DataTable createDTorder()
        {
            DataTable dtOrder = new DataTable();
            dtOrder.Columns.Add("id", typeof(int));
            dtOrder.Columns.Add("prices", typeof(int));
            dtOrder.Columns.Add("quantity", typeof(int));
            return dtOrder;
        }

        public DataTable createDTProduct()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("product_name", typeof(String));
            dataTable.Columns.Add("prices", typeof(int));
            dataTable.Columns.Add("id_product_category", typeof(int));
            //dataTable.Columns.Add("image_url", typeof(String));
            return dataTable;
        }

        private DataTable getProductByID(int id)
        {
            DataTable dt = new DataTable();
            dt = createDTProduct();
            foreach (DataRow row in listDT[3].Rows)
            {
                if (row["id_product_category"].ToString() == id.ToString())
                {
                    dt.Rows.Add(Convert.ToInt32(row["id"]), row["product_name"].ToString(), Convert.ToInt32(row["prices"]), Convert.ToInt32(row["id_product_category"]));
                }
            }
            return dt;
        }

        private DataTable getProductByName(int id,String name)
        {
            DataTable dt = new DataTable();
            dt = createDTProduct();
            if (id == 1)
            {
                foreach (DataRow row in dtProduct1.Rows)
                {
                    if (row["product_name"].ToString().IndexOf(name) != -1)
                    {
                        dt.Rows.Add(row);
                    }
                }
            }
            else if (id == 2)
            {
                foreach (DataRow row in dtProduct2.Rows)
                {
                    if (row["product_name"].ToString().IndexOf(name) != -1)
                    {
                        dt.Rows.Add(row);
                    }
                }
            }
            else if (id == 3)
            {
                foreach (DataRow row in dtProduct3.Rows)
                {
                    if (row["product_name"].ToString().IndexOf(name) != -1)
                    {
                        dt.Rows.Add(row);
                    }
                }
            }
            return dt;
        }
        public MenuDV(string user_name, string role_name, List<DataTable> list)
        {
                InitializeComponent();
                listDT = new List<DataTable>();
                listDT = list.ToList();
                dtProduct1= new DataTable();
                dtProduct1 = getProductByID(1);
                dtProduct2 = new DataTable();
                dtProduct2 = getProductByID(2);
                dtProduct3 = new DataTable();
                dtProduct3 = getProductByID(3);
                btnHome.dt = listDT[4];
                btnHome.Visible = false;
                listdrink1.Visible = false;
                addcart1.Visible = false;
                addcart1.btnThanhToan.Click += BtnThanhToan_Click;
                feedback1.Visible = false;
                entertains1.Visible = false;
                manage1.Visible = false;
                news1.Visible = false;
                btchat1.Visible = false;
                btchat1.button1.Click += BTCHATBUT_Click;
                sf = new SENDFEEDBACK();
                cf = new ChatForm();
                so = new SENDORDER();
                feedback1.button1.Click += fbButton1_Click;
                feedback1.button2.Click += fbButton2_Click;
                feedback1.button3.Click += fbButton3_Click;
                feedback1.button4.Click += fbButton4_Click;
                feedback1.button5.Click += fbButton5_Click;
                feedback1.button6.Click += fbButton6_Click;
                feedback1.button7.Click += fbButton7_Click;
                feedback1.button8.Click += fbButton8_Click;
                feedback1.button9.Click += fbButton9_Click;
                feedback1.button10.Click += fbButton10_Click;
                feedback1.button11.Click += fbButton11_Click;
                feedback1.button12.Click += fbButton12_Click;
                feedback1.button13.Click += fbButton13_Click;
                feedback1.button14.Click += fbButton14_Click;
                feedback1.button15.Click += fbButton15_Click;
                this.user_name = user_name;
                this.role_name = role_name;
                //dataTable = NEWSS_BLL.Instance.GetAllNEWS();
                foreach (DataRow row in listDT[5].Rows)
                {
                    PUBLICNEWS pn = new PUBLICNEWS();
                    pn.Size = new System.Drawing.Size(726, 300);
                    pn.labelDate.Text = ((DateTime)row["create_date"]).ToShortDateString();
                    pn.labelType.Text = row["typee"].ToString();
                    pn.labelTitle.Text = row["title"].ToString();
                    pn.labelContent.Text = row["content"].ToString();
                    news1.flowLayoutPanel1.Controls.Add(pn);
                }
        }

        private void fbButton1_Click(object sender, EventArgs e)
        {
            sf.Send(feedback1.label1.Text);
            MessageBox.Show("Phản hồi của bạn về việc " + feedback1.label1.Text + " đã được gửi đi thành công");
        }
        private void fbButton2_Click(object sender, EventArgs e)
        {
            sf.Send(feedback1.label2.Text);
            MessageBox.Show("Phản hồi của bạn về việc " + feedback1.label2.Text + " đã được gửi đi thành công");
        }
        private void fbButton3_Click(object sender, EventArgs e)
        {
            sf.Send(feedback1.label3.Text);
            MessageBox.Show("Phản hồi của bạn về việc " + feedback1.label3.Text + " đã được gửi đi thành công");
        }

        private void fbButton4_Click(object sender, EventArgs e)
        {
            sf.Send(feedback1.label4.Text);
            MessageBox.Show("Phản hồi của bạn về việc " + feedback1.label4.Text + " đã được gửi đi thành công");
        }

        private void fbButton5_Click(object sender, EventArgs e)
        {
            sf.Send(feedback1.label5.Text);
            MessageBox.Show("Phản hồi của bạn về việc " + feedback1.label5.Text + " đã được gửi đi thành công");
        }
        private void fbButton6_Click(object sender, EventArgs e)
        {
            sf.Send(feedback1.label6.Text);
            MessageBox.Show("Phản hồi của bạn về việc " + feedback1.label6.Text + " đã được gửi đi thành công");
        }

        private void fbButton7_Click(object sender, EventArgs e)
        {
            sf.Send(feedback1.label7.Text);
            MessageBox.Show("Phản hồi của bạn về việc " + feedback1.label7.Text + " đã được gửi đi thành công");
        }

        private void fbButton8_Click(object sender, EventArgs e)
        {
            sf.Send(feedback1.label8.Text);
            MessageBox.Show("Phản hồi của bạn về việc " + feedback1.label8.Text + " đã được gửi đi thành công");
        }

        private void fbButton9_Click(object sender, EventArgs e)
        {
            sf.Send(feedback1.label9.Text);
            MessageBox.Show("Phản hồi của bạn về việc " + feedback1.label9.Text + " đã được gửi đi thành công");
        }

        private void fbButton10_Click(object sender, EventArgs e)
        {
            sf.Send(feedback1.label10.Text);
            MessageBox.Show("Phản hồi của bạn về việc " + feedback1.label10.Text + " đã được gửi đi thành công");
        }

        private void fbButton11_Click(object sender, EventArgs e)
        {
            sf.Send(feedback1.label11.Text);
            MessageBox.Show("Phản hồi của bạn về việc " + feedback1.label11.Text + " đã được gửi đi thành công");
        }

        private void fbButton12_Click(object sender, EventArgs e)
        {
            sf.Send(feedback1.label12.Text);
            MessageBox.Show("Phản hồi của bạn về việc " + feedback1.label12.Text + " đã được gửi đi thành công");
        }

        private void fbButton13_Click(object sender, EventArgs e)
        {
            sf.Send(feedback1.label13.Text);
            MessageBox.Show("Phản hồi của bạn về việc " + feedback1.label13.Text + " đã được gửi đi thành công");
        }

        private void fbButton14_Click(object sender, EventArgs e)
        {
            sf.Send(feedback1.label14.Text);
            MessageBox.Show("Phản hồi của bạn về việc " + feedback1.label14.Text + " đã được gửi đi thành công");
        }

        private void fbButton15_Click(object sender, EventArgs e)
        {
            sf.Send(feedback1.label1.Text);
            MessageBox.Show("Phản hồi của bạn về việc " + feedback1.label15.Text + " đã được gửi đi thành công");
        }
        private void BTCHATBUT_Click(object sender, EventArgs e)
        {
            cf.Show();
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Số tiền thanh toán của bạn là " + addcart1.lbMoney.Text + " đồng\n Bạn có chắc muốn thanh toán ?", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                dtOrder1 = createDTorder();
                foreach(CARTITEM ci in addcart1.flowLayoutPanel1.Controls)
                {
                    string s = ci.lbPrice.Text.Substring(0, ci.lbPrice.Text.Length - 1);
                    dtOrder1.Rows.Add(Convert.ToInt32(ci.lbID.Text), Convert.ToInt32(s), Convert.ToInt32(ci.txbSoLuong.Text));
                    PRIVATENEWS pn = new PRIVATENEWS();
                    pn.label1.Text = "Đơn hàng " + ci.label1.Text + " (x" + ci.txbSoLuong.Text + ") đang được xử lý";
                    pn.panel1.BackColor = ci.panel1.BackColor;
                    pn.pictureBox1.Image = ci.pictureBox1.Image;
                    pn.label2.Text = "Đặt hàng";
                    news1.flowLayoutPanel2.Controls.Add(pn);
                }
                addcart1.flowLayoutPanel1.Controls.Clear();
                MessageBox.Show("Thanh toán thành công!");
                so.receiveData(dtOrder1);
                so.Send();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.BackColor = Color.Firebrick;
            panel3.BackColor = Color.Firebrick;
            panel4.Show();
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            panel4.BackColor = Color.Firebrick;
            button7.BackColor = Color.Firebrick;
            button8.BackColor = Color.Firebrick;
            button9.BackColor = Color.Firebrick;
            btnHome.Visible = true;
            news1.Visible = false;
            listdrink1.Visible = false;
            addcart1.Visible = false;
            btchat1.Visible = false;
            feedback1.Visible = false;
            entertains1.Visible = false;
            manage1.Visible = false;
            
            btnHome.BringToFront();
            this.BackgroundImage = null;
            label1.Text = "Home";
            label2.Text = "Main Menu";
        }
        MemoryStream ms;

        private void button2_Click(object sender, EventArgs e)
        {
                panel3.Visible = true;
                panel2.BackColor = Color.DarkOrange;
                panel3.BackColor = Color.DarkOrange;
                panel4.Show();
                panel4.Height = button2.Height;
                panel4.Top = button2.Top;
                panel4.BringToFront();
                panel4.BackColor = Color.DarkOrange;
                button7.BackColor = Color.DarkOrange;
                button8.BackColor = Color.DarkOrange;
                button9.BackColor = Color.DarkOrange;
                news1.Visible = false;
                btnHome.Visible = false;
                btchat1.Visible = false;
                feedback1.Visible = false;
                entertains1.Visible = false;
                manage1.Visible = false;
                
                listdrink1.Visible = true;
                listdrink1.lbTitle.Text = "List Drink";
                listdrink1.flowLayoutPanel1.Controls.Clear();
                //dataTable = PRODUCT_BLL.Instance.getProductByID(1);

                
                foreach (DataRow row in dtProduct1.Rows)
                {
                    BTDRINK bTDRINK = new BTDRINK();
                    bTDRINK.Size = new System.Drawing.Size(183, 217);
                    bTDRINK.lbID.Text = row["id"].ToString();
                    bTDRINK.label1.Text = row["prices"].ToString() + "đ";
                    bTDRINK.label2.Text = row["product_name"].ToString();
                    bTDRINK.button1.BackColor = Color.DarkOrange;
                    bTDRINK.button1.Click += Button1_Click;
                    bTDRINK.pictureBox1.Image = bTDRINK.drinkimage.Image;
                    listdrink1.flowLayoutPanel1.Controls.Add(bTDRINK);
                }
                addcart1.Visible = true;
                listdrink1.BringToFront();
                this.BackgroundImage = null;
                label1.Text = "Drink";
                label2.Text = "Drink Menu";
        }

        private void button3_Click(object sender, EventArgs e)
        {
                panel3.Visible = true;
                panel2.BackColor = Color.Gold;
                panel3.BackColor = Color.Gold;
                panel4.Height = button3.Height;
                panel4.Show();
                panel4.Top = button3.Top;
                panel4.BringToFront();
                panel4.BackColor = Color.Gold;
                button7.BackColor = Color.Gold;
                button8.BackColor = Color.Gold;
                button9.BackColor = Color.Gold;
                listdrink1.lbTitle.Text = "List Food";
                listdrink1.flowLayoutPanel1.Controls.Clear();
                //dataTable = PRODUCT_BLL.Instance.getProductByID(2);
                foreach (DataRow row in dtProduct2.Rows)
                {
                    BTDRINK bTDRINK = new BTDRINK();
                    bTDRINK.Size = new System.Drawing.Size(183, 217);
                    bTDRINK.lbID.Text = row["id"].ToString();
                    bTDRINK.label1.Text = row["prices"].ToString() + "đ";
                    bTDRINK.label2.Text = row["product_name"].ToString();
                    bTDRINK.button1.BackColor = Color.Gold;
                    bTDRINK.button1.Click += Button1_Click;
                    bTDRINK.pictureBox1.Image = bTDRINK.foodimage.Image;
                    listdrink1.flowLayoutPanel1.Controls.Add(bTDRINK);
                }
                news1.Visible = false;
                addcart1.Visible = true;
                btnHome.Visible = false;
                feedback1.Visible = false;
                listdrink1.Visible = true;
                entertains1.Visible = false;
                btchat1.Visible = false;
                manage1.Visible = false;
                listdrink1.lbTitle.Text = "List Food";
                this.BackgroundImage = null;
                label1.Text = "Food";
                label2.Text = "Food Menu";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cancel = false;
            Button btn = sender as Button;
            BTDRINK btd = new BTDRINK();
            btd = (BTDRINK)btn.Parent.Parent;
            if (btd.label2.Text == "Nạp tự chọn")
            {
                
                reflb.Text = "0";
                OptRecharge optrecharges1 = new OptRecharge();
                optrecharges1.moneyAcception += new MoneyAcception(Optrecharges1_moneyAcception);
                optrecharges1.exit += new Exit(Optrecharges1_exit);
                optrecharges1.ShowDialog();
                btd.label1.Text = reflb.Text + "đ";
            }
            if (!cancel)
            {
                CARTITEM cARTITEM = new CARTITEM();
                cARTITEM.Size = new System.Drawing.Size(266, 122);
                cARTITEM.lbID.Text = btd.lbID.Text;
                cARTITEM.label1.Text = btd.label2.Text;
                cARTITEM.lbPrice.Text = btd.label1.Text;
                cARTITEM.panel1.BackColor = btd.button1.BackColor;
                cARTITEM.pictureBox1.Image = btd.pictureBox1.Image;
                cARTITEM.btnExit.Click += BtnExit_Click;
                cARTITEM.txbSoLuong.TextChanged += TxbSoLuong_TextChanged;
                addcart1.flowLayoutPanel1.Controls.Add(cARTITEM);
            }
        }

        private void Optrecharges1_exit()
        {
            cancel = true;
            return;
        }

        private void Optrecharges1_moneyAcception(Naptien nt)
        {
            reflb.Text = nt.money;
        }


        private void TxbSoLuong_TextChanged(object sender, EventArgs e)
        {
            int s = 0;
            foreach (CARTITEM ci in addcart1.flowLayoutPanel1.Controls)
            {
                s += (Convert.ToInt32(ci.lbPrice.Text.TrimEnd('đ')) * Convert.ToInt32(ci.txbSoLuong.Text));
            }
            ADDCART ac = new ADDCART();
            ac = (ADDCART)addcart1.flowLayoutPanel1.Parent;
            ac.lbMoney.Text = s.ToString() + "đ";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            CARTITEM ci = new CARTITEM();
            ci = (CARTITEM)btn.Parent.Parent;
            addcart1.flowLayoutPanel1.Controls.Remove(ci);
        }

        private void button4_Click(object sender, EventArgs e)
        {
                panel3.Visible = true;
                panel2.BackColor = Color.ForestGreen;
                panel3.BackColor = Color.ForestGreen;
                panel4.Show();
                panel4.Height = button4.Height;
                panel4.Top = button4.Top;
                panel4.BringToFront();
                panel4.BackColor = Color.ForestGreen;
                button7.BackColor = Color.ForestGreen;
                button8.BackColor = Color.ForestGreen;
                button9.BackColor = Color.ForestGreen;
                addcart1.Visible = true;
                news1.Visible = false;
                btnHome.Visible = false;
                feedback1.Visible = false;
                btchat1.Visible = false;
                listdrink1.Visible = true;
                entertains1.Visible = false;
                manage1.Visible = false;
                
                listdrink1.lbTitle.Text = "List Recharge";
                listdrink1.flowLayoutPanel1.Controls.Clear();
                //dataTable = PRODUCT_BLL.Instance.getProductByID(3);
                foreach (DataRow row in dtProduct3.Rows)
                {
                    BTDRINK bTDRINK = new BTDRINK();
                    bTDRINK.Size = new System.Drawing.Size(183, 217);
                    bTDRINK.lbID.Text = row["id"].ToString();
                    bTDRINK.label1.Text = row["prices"].ToString() + "đ";
                    bTDRINK.label2.Text = row["product_name"].ToString();
                    bTDRINK.button1.BackColor = Color.ForestGreen;
                    bTDRINK.button1.Click += Button1_Click;
                    bTDRINK.pictureBox1.Image = bTDRINK.rechargeimage.Image;
                    listdrink1.flowLayoutPanel1.Controls.Add(bTDRINK);
                }
                this.BackgroundImage = null;
                label1.Text = "Recharge";
                label2.Text = "Recharge Account";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.BackColor = Color.DeepSkyBlue;
            panel3.BackColor = Color.DeepSkyBlue;
            panel4.Show();
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
            panel4.BringToFront();
            panel4.BackColor = Color.DeepSkyBlue;
            button7.BackColor = Color.DeepSkyBlue;
            button8.BackColor = Color.DeepSkyBlue;
            button9.BackColor = Color.DeepSkyBlue;
            news1.Visible = false;
            addcart1.Visible = false;
            btnHome.Visible = false;
            entertains1.Visible = false;
            listdrink1.Visible = false;
            feedback1.Visible = false;
            manage1.Visible = false;
            btchat1.Visible = true;
            //cf.Show();
            this.BackgroundImage = null;
            label1.Text = "Communication";
            label2.Text = "Chat Box";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.BackColor = Color.DarkViolet;
            panel3.BackColor = Color.DarkViolet;
            panel4.Show();
            panel4.Height = button6.Height;
            panel4.Top = button6.Top;
            panel4.BringToFront();
            panel4.BackColor = Color.DarkViolet;
            button7.BackColor = Color.DarkViolet;
            button8.BackColor = Color.DarkViolet;
            button9.BackColor = Color.DarkViolet;
            feedback1.Visible = true;
            feedback1.BringToFront();
            news1.Visible = false;
            addcart1.Visible = false;
            btnHome.Visible = false;
            entertains1.Visible = false;
            listdrink1.Visible = false;
            manage1.Visible = false;
            btchat1.Visible = false;

            this.BackgroundImage = null;
            label1.Text = "Feedback";
            label2.Text = "User Feedback";
        }

        private void Home_Load(object sender, EventArgs e)
        {
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
            so.Dispose();
            sf.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listdrink1_Load(object sender, EventArgs e)
        {
            listdrink1.txbSearch.TextChanged += TxbSearch_TextChanged;
        }

        string query;
        private void TxbSearch_TextChanged(object sender, EventArgs e)
        {
                if (listdrink1.txbSearch.Text != "Tìm Kiếm")
                {
                    listdrink1.flowLayoutPanel1.Controls.Clear();
                    if (listdrink1.lbTitle.Text == "List Drink") dataTable = getProductByName(1, listdrink1.txbSearch.Text);
                    else if (listdrink1.lbTitle.Text == "List Food") dataTable = getProductByName(2, listdrink1.txbSearch.Text);
                else if (listdrink1.lbTitle.Text == "List Recharge") dataTable = getProductByName(3, listdrink1.txbSearch.Text);
                foreach (DataRow row in dataTable.Rows)
                    {
                        BTDRINK bTDRINK = new BTDRINK();
                        bTDRINK.Size = new System.Drawing.Size(183, 217);
                        bTDRINK.label1.Text = row["prices"].ToString() + "đ";
                        bTDRINK.label2.Text = row["product_name"].ToString();
                        if (listdrink1.lbTitle.Text == "List Drink")
                        {
                            bTDRINK.button1.BackColor = Color.DarkOrange;
                            bTDRINK.pictureBox1.Image = bTDRINK.drinkimage.Image;
                        }
                        else if (listdrink1.lbTitle.Text == "List Food")
                        {
                            bTDRINK.button1.BackColor = Color.Gold;
                            bTDRINK.pictureBox1.Image = bTDRINK.foodimage.Image;
                        }
                        else if (listdrink1.lbTitle.Text == "List Recharge")
                        {
                            bTDRINK.button1.BackColor = Color.ForestGreen;
                            bTDRINK.pictureBox1.Image = bTDRINK.rechargeimage.Image;
                        }

                    listdrink1.flowLayoutPanel1.Controls.Add(bTDRINK);
                        bTDRINK.button1.Click += Button1_Click;
                    }
                }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.BackColor = Color.HotPink;
            panel3.BackColor = Color.HotPink;
            panel4.Height = button6.Height;
            panel4.Show();
            panel4.Top = button11.Top;
            panel4.BringToFront();
            panel4.BackColor = Color.HotPink;
            button7.BackColor = Color.HotPink;
            button8.BackColor = Color.HotPink;
            button9.BackColor = Color.HotPink;
            addcart1.Visible = false;
            btnHome.Visible = false;
            news1.Visible = false;
            entertains1.Visible = false;
            listdrink1.Visible = false;
            btchat1.Visible = false;
            manage1.Visible = true;
            manage1.BringToFront();
            this.BackgroundImage = null;
            feedback1.Visible = false;
            label1.Text = "Management";
            label2.Text = "Edit Database";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.BackColor = Color.SaddleBrown;
            panel3.BackColor = Color.SaddleBrown;
            panel4.Show();
            panel4.Height = button6.Height;
            panel4.Top = button12.Top;
            panel4.BringToFront();
            panel4.BackColor = Color.SaddleBrown;
            button7.BackColor = Color.SaddleBrown;
            button8.BackColor = Color.SaddleBrown;
            button9.BackColor = Color.SaddleBrown;
            news1.Visible = false;
            addcart1.Visible = false;
            btnHome.Visible = false;
            listdrink1.Visible = false;
            feedback1.Visible = false;
            manage1.Visible = false;
            btchat1.Visible = false;
            entertains1.Visible = true;
            entertains1.BringToFront();
            this.BackgroundImage = null;
            label1.Text = "Entertainment";
            label2.Text = "Other activities";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.RoyalBlue;
            panel3.Visible = false;
            button7.BackColor = Color.RoyalBlue;
            button8.BackColor = Color.RoyalBlue;
            button9.BackColor = Color.RoyalBlue;
            addcart1.Visible = false;
            btnHome.Visible = false;
            entertains1.Visible = false;
            listdrink1.Visible = false;
            feedback1.Visible = false;
            manage1.Visible = false;
            btchat1.Visible = false;
            news1.Visible = true;
            news1.BringToFront();
            this.BackgroundImage = null;
        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            down = true;
            MX = e.X;
            MY = e.Y;
            X = this.Location.X;
            Y = this.Location.Y;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            enter = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            down = false;
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (enter && down)
            {
                this.Location = new Point(X + (e.X - MX), Y + (e.Y - MY));
                this.BringToFront();
            }
        }
    }
}
