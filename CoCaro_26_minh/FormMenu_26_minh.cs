using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaro_26_minh
{
    public partial class FormMenu_26_minh : Form
    {
        public FormMenu_26_minh()
        {
            InitializeComponent();
        }

        int[] rbValue_26_minh = {1, 3, 6, 10000 };

        private void btnAnh1_26_minh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog_26_minh = new OpenFileDialog();
            openFileDialog_26_minh.Title = "Chọn ảnh đại diện";
            openFileDialog_26_minh.Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog_26_minh.ShowDialog() == DialogResult.OK)
            {
                pbNC1_26_minh.Image = Image.FromFile(openFileDialog_26_minh.FileName);
            }
        }

        private void btnAnh2_26_minh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog_26_minh = new OpenFileDialog();
            openFileDialog_26_minh.Title = "Chọn ảnh đại diện";
            openFileDialog_26_minh.Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog_26_minh.ShowDialog() == DialogResult.OK)
            {
                pbNC2_26_minh.Image = Image.FromFile(openFileDialog_26_minh.FileName);
            }
        }

        private void btnExit_26_minh_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_26_minh_Click(object sender, EventArgs e)
        {
            if(txtTenNC1_26_minh.Text=="" || txtTenNC2_26_minh.Text == "")
            {
                MessageBox.Show("Phải nhập tên người chơi", "Thông báo");
                return;
            }
            int second_26_minh = 0;
            if(rb0s_26_minh.Checked)
            {
                second_26_minh = rbValue_26_minh[3];
            }
            if (rb10s_26_minh.Checked)
            {
                second_26_minh = rbValue_26_minh[0];
            }
            if (rb60s_26_minh.Checked)
            {
                second_26_minh = rbValue_26_minh[2];
            }
            if (rb30s_26_minh.Checked)
            {
                second_26_minh = rbValue_26_minh[1];
            }
            if (rb1515_26_minh.Checked)
            {
                 cons_26_minh.CHEST_WIDTH_26_MINH = 83;
                cons_26_minh.CHEST_HEIGHT_26_MINH = 72;
                    cons_26_minh.CHEST_BOARD_WIDTH_26_MINH = 15;
                cons_26_minh.CHEST_BOARD_HEIGHT_26_MINH = 14;
            }
            if (rb1010_16_minh.Checked)
            {
                cons_26_minh.CHEST_WIDTH_26_MINH = 100;
                cons_26_minh.CHEST_HEIGHT_26_MINH = 100;
                cons_26_minh.CHEST_BOARD_WIDTH_26_MINH = 10;
                cons_26_minh.CHEST_BOARD_HEIGHT_26_MINH = 10;
            }
            this.Hide();

            formGame_26_minh formGame_26_Minh = new formGame_26_minh(txtTenNC1_26_minh.Text,txtTenNC2_26_minh.Text,
                                                                     pbNC1_26_minh.Image, pbNC2_26_minh.Image,second_26_minh);
           
            formGame_26_Minh.ShowDialog();
           
            this.Show();
        }
    }
}
