namespace WindowsFormsApplication2
{
    partial class giao_dien_chinh2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giao_dien_chinh2));
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bar_nhaphang = new DevExpress.XtraBars.BarButtonItem();
            this.bar_xuathang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bar_nhaphang2 = new DevExpress.XtraBars.BarButtonItem();
            this.bar_banhang = new DevExpress.XtraBars.BarButtonItem();
            this.bar_thoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar_gt = new DevExpress.XtraBars.BarButtonItem();
            this.bar_hdsd = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 502);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar.Size = new System.Drawing.Size(470, 31);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bar_nhaphang,
            this.bar_xuathang,
            this.barButtonItem3,
            this.bar_nhaphang2,
            this.bar_banhang,
            this.bar_thoat,
            this.bar_gt,
            this.bar_hdsd,
            this.ribbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbonControl1.PageHeaderItemLinks.Add(this.ribbonGalleryBarItem1);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(470, 131);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar;
            // 
            // bar_nhaphang
            // 
            this.bar_nhaphang.Caption = "Nhập hàng";
            this.bar_nhaphang.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_nhaphang.Glyph")));
            this.bar_nhaphang.Id = 3;
            this.bar_nhaphang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bar_nhaphang.LargeGlyph")));
            this.bar_nhaphang.Name = "bar_nhaphang";
            this.bar_nhaphang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_nhaphang_ItemClick);
            // 
            // bar_xuathang
            // 
            this.bar_xuathang.Caption = "Xuất Hàng";
            this.bar_xuathang.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_xuathang.Glyph")));
            this.bar_xuathang.Id = 4;
            this.bar_xuathang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bar_xuathang.LargeGlyph")));
            this.bar_xuathang.Name = "bar_xuathang";
            this.bar_xuathang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_xuathang_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thoát";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // bar_nhaphang2
            // 
            this.bar_nhaphang2.Caption = "Nhập hàng";
            this.bar_nhaphang2.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_nhaphang2.Glyph")));
            this.bar_nhaphang2.Id = 6;
            this.bar_nhaphang2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bar_nhaphang2.LargeGlyph")));
            this.bar_nhaphang2.Name = "bar_nhaphang2";
            this.bar_nhaphang2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_nhaphang2_ItemClick);
            // 
            // bar_banhang
            // 
            this.bar_banhang.Caption = "Bán hàng";
            this.bar_banhang.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_banhang.Glyph")));
            this.bar_banhang.Id = 8;
            this.bar_banhang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bar_banhang.LargeGlyph")));
            this.bar_banhang.Name = "bar_banhang";
            this.bar_banhang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_banhang_ItemClick);
            // 
            // bar_thoat
            // 
            this.bar_thoat.Caption = "Thoát";
            this.bar_thoat.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_thoat.Glyph")));
            this.bar_thoat.Id = 9;
            this.bar_thoat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bar_thoat.LargeGlyph")));
            this.bar_thoat.Name = "bar_thoat";
            this.bar_thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_thoat_ItemClick);
            // 
            // bar_gt
            // 
            this.bar_gt.Caption = "Giới thiệu";
            this.bar_gt.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_gt.Glyph")));
            this.bar_gt.Id = 10;
            this.bar_gt.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bar_gt.LargeGlyph")));
            this.bar_gt.Name = "bar_gt";
            this.bar_gt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_gt_ItemClick);
            // 
            // bar_hdsd
            // 
            this.bar_hdsd.Caption = "HDSD";
            this.bar_hdsd.Glyph = ((System.Drawing.Image)(resources.GetObject("bar_hdsd.Glyph")));
            this.bar_hdsd.Id = 11;
            this.bar_hdsd.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bar_hdsd.LargeGlyph")));
            this.bar_hdsd.Name = "bar_hdsd";
            this.bar_hdsd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_hdsd_ItemClick);
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 13;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thao Tác";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bar_nhaphang);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bar_xuathang);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Hệ Thống";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.bar_thoat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.bar_gt);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.ItemLinks.Add(this.bar_hdsd);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.ShowCaptionButton = false;
            // 
            // giao_dien_chinh2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 533);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "giao_dien_chinh2";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "giao_dien_chinh2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem bar_nhaphang;
        private DevExpress.XtraBars.BarButtonItem bar_xuathang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bar_nhaphang2;
        private DevExpress.XtraBars.BarButtonItem bar_banhang;
        private DevExpress.XtraBars.BarButtonItem bar_thoat;
        private DevExpress.XtraBars.BarButtonItem bar_gt;
        private DevExpress.XtraBars.BarButtonItem bar_hdsd;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
    }
}