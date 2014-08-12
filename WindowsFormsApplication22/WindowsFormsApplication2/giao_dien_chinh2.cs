using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace WindowsFormsApplication2
{
    public partial class giao_dien_chinh2 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public giao_dien_chinh2()
        {
            InitializeComponent();
        }

        private void bar_nhaphang_ItemClick(object sender, ItemClickEventArgs e)
        {
            form_nv2_nhap n = new form_nv2_nhap();
            n.MdiParent = this;
            n.Show();
        }

        private void bar_xuathang_ItemClick(object sender, ItemClickEventArgs e)
        {
            form_nv_xuat n = new form_nv_xuat();
            n.MdiParent = this;
            n.Show();
        }

        private void bar_nhaphang2_ItemClick(object sender, ItemClickEventArgs e)
        {
            string gt;
            gt = "Chức năng đang được xây dựng" + System.Environment.NewLine;

            MessageBox.Show(gt, "Thông Tin Đồ Án", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bar_banhang_ItemClick(object sender, ItemClickEventArgs e)
        {
            string gt;
            gt = "Chức năng đang được xây dựng" + System.Environment.NewLine;

            MessageBox.Show(gt, "Thông Tin Đồ Án", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bar_hdsd_ItemClick(object sender, ItemClickEventArgs e)
        {
            string gt;
            gt = "Chức năng đang được xây dựng" + System.Environment.NewLine;

            MessageBox.Show(gt, "Thông Tin Đồ Án", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bar_thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng không?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void bar_gt_ItemClick(object sender, ItemClickEventArgs e)
        {
            string gt;
            gt = "Đồ án: Lập Trình Giao Diện" + System.Environment.NewLine;
            gt += "Giảng viên hướng dẫn: Thầy Nguyễn Kim Long" + System.Environment.NewLine;
            gt += "Sinh viên thực hiên:" + System.Environment.NewLine;
            gt += "Lê Dương Sang" + System.Environment.NewLine;
            gt += "Nguyễn Thị Minh Ngọc" + System.Environment.NewLine;
            gt += "Phạm Hoàng Cẩm" + System.Environment.NewLine;


            MessageBox.Show(gt, "Thông Tin Đồ Án", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}