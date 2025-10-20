namespace apc
{
    partial class frm_all_vac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_all_vac));
            this.SimpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.employBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.docvacanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnbr_cons = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbr_rest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_vac_out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_vac_in = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_interim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplace_vac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvacance_year1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_vacnace1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.docvacaneplusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_vac_plus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltitre_vacplus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_out_vacpus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_in_vacplus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbr_day_vac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvacance_year = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_vacnace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employBindingSource)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docvacanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docvacaneplusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // SimpleButton3
            // 
            this.SimpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButton3.Image")));
            this.SimpleButton3.Location = new System.Drawing.Point(953, 442);
            this.SimpleButton3.Name = "SimpleButton3";
            this.SimpleButton3.Size = new System.Drawing.Size(122, 51);
            this.SimpleButton3.TabIndex = 56;
            this.SimpleButton3.Text = "طبـــاعة";
            this.SimpleButton3.Click += new System.EventHandler(this.SimpleButton3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(932, 166);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(158, 46);
            this.groupBox5.TabIndex = 54;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "لقب الموظف :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employBindingSource, "nom_ar", true));
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(932, 283);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(158, 46);
            this.groupBox6.TabIndex = 55;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "اسم الموظف :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employBindingSource, "prenom_ar", true));
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "label6";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label4);
            this.groupBox12.Location = new System.Drawing.Point(932, 72);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox12.Size = new System.Drawing.Size(152, 46);
            this.groupBox12.TabIndex = 53;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "رقم التسلسلي للموظف :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employBindingSource, "id", true));
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.Buttons.CancelEdit.Visible = false;
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.Remove.Visible = false;
            this.dataNavigator1.DataSource = this.docvacanceBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(30, 12);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(294, 24);
            this.dataNavigator1.TabIndex = 1;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // docvacanceBindingSource
            // 
            this.docvacanceBindingSource.DataSource = typeof(apc.Modele.doc_vacance);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(588, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(125, 39);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "حذف العطلــــة ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(29, 49);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(881, 586);
            this.xtraTabControl1.TabIndex = 67;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(875, 558);
            this.xtraTabPage1.Text = "العطــــــــــــــــــــل السنـــــــــــــــوية";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.docvacanceBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(875, 558);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnbr_cons,
            this.colnbr_rest,
            this.coldate_vac_out,
            this.coldate_vac_in,
            this.colnom_interim,
            this.colplace_vac,
            this.colvacance_year1,
            this.colid_vacnace1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nbr_cons", this.colnbr_cons, "somme={0}", 0),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Min, "nbr_rest", this.colnbr_rest, "Reset={0}", 3)});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colvacance_year1, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldate_vac_in, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colnbr_cons
            // 
            this.colnbr_cons.Caption = "عدد  أيام العطلـــة";
            this.colnbr_cons.FieldName = "nbr_cons";
            this.colnbr_cons.Name = "colnbr_cons";
            this.colnbr_cons.Visible = true;
            this.colnbr_cons.VisibleIndex = 1;
            this.colnbr_cons.Width = 123;
            // 
            // colnbr_rest
            // 
            this.colnbr_rest.Caption = "عدد  الأيام المتبقية";
            this.colnbr_rest.FieldName = "nbr_rest";
            this.colnbr_rest.Name = "colnbr_rest";
            this.colnbr_rest.Visible = true;
            this.colnbr_rest.VisibleIndex = 2;
            this.colnbr_rest.Width = 120;
            // 
            // coldate_vac_out
            // 
            this.coldate_vac_out.Caption = "تاريخ الخروج";
            this.coldate_vac_out.FieldName = "date_vac_out";
            this.coldate_vac_out.Name = "coldate_vac_out";
            this.coldate_vac_out.Visible = true;
            this.coldate_vac_out.VisibleIndex = 3;
            this.coldate_vac_out.Width = 142;
            // 
            // coldate_vac_in
            // 
            this.coldate_vac_in.Caption = "تاريخ الدخول";
            this.coldate_vac_in.FieldName = "date_vac_in";
            this.coldate_vac_in.Name = "coldate_vac_in";
            this.coldate_vac_in.Visible = true;
            this.coldate_vac_in.VisibleIndex = 4;
            this.coldate_vac_in.Width = 150;
            // 
            // colnom_interim
            // 
            this.colnom_interim.Caption = "اسم المستخلـــــف ";
            this.colnom_interim.FieldName = "nom_interim";
            this.colnom_interim.Name = "colnom_interim";
            this.colnom_interim.Visible = true;
            this.colnom_interim.VisibleIndex = 6;
            this.colnom_interim.Width = 281;
            // 
            // colplace_vac
            // 
            this.colplace_vac.Caption = "مكان قضاء العطلة";
            this.colplace_vac.FieldName = "place_vac";
            this.colplace_vac.Name = "colplace_vac";
            this.colplace_vac.Visible = true;
            this.colplace_vac.VisibleIndex = 5;
            this.colplace_vac.Width = 144;
            // 
            // colvacance_year1
            // 
            this.colvacance_year1.Caption = "سنة العطلة";
            this.colvacance_year1.FieldName = "vacance_year";
            this.colvacance_year1.Name = "colvacance_year1";
            this.colvacance_year1.Visible = true;
            this.colvacance_year1.VisibleIndex = 6;
            // 
            // colid_vacnace1
            // 
            this.colid_vacnace1.Caption = "رقم العطلة";
            this.colid_vacnace1.FieldName = "id_vacnace";
            this.colid_vacnace1.Name = "colid_vacnace1";
            this.colid_vacnace1.Visible = true;
            this.colid_vacnace1.VisibleIndex = 0;
            this.colid_vacnace1.Width = 84;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(875, 558);
            this.xtraTabPage2.Text = "العطــــــــــــــــــل المرضية و الاستثنائيــــــــــــــــــة / عطلة أمومــــــ" +
    "ــة";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.docvacaneplusBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(875, 558);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_vac_plus,
            this.coltitre_vacplus,
            this.coldate_out_vacpus,
            this.coldate_in_vacplus,
            this.colnbr_day_vac});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colid_vac_plus
            // 
            this.colid_vac_plus.Caption = "رقم العطـــلة";
            this.colid_vac_plus.FieldName = "id_vac_plus";
            this.colid_vac_plus.Name = "colid_vac_plus";
            this.colid_vac_plus.Visible = true;
            this.colid_vac_plus.VisibleIndex = 0;
            // 
            // coltitre_vacplus
            // 
            this.coltitre_vacplus.Caption = "عنوان العطـــلة";
            this.coltitre_vacplus.FieldName = "titre_vacplus";
            this.coltitre_vacplus.Name = "coltitre_vacplus";
            this.coltitre_vacplus.Visible = true;
            this.coltitre_vacplus.VisibleIndex = 1;
            // 
            // coldate_out_vacpus
            // 
            this.coldate_out_vacpus.Caption = "تاريخ الخروج";
            this.coldate_out_vacpus.FieldName = "date_out_vacpus";
            this.coldate_out_vacpus.Name = "coldate_out_vacpus";
            this.coldate_out_vacpus.Visible = true;
            this.coldate_out_vacpus.VisibleIndex = 3;
            // 
            // coldate_in_vacplus
            // 
            this.coldate_in_vacplus.Caption = "تاريخ الدخول";
            this.coldate_in_vacplus.FieldName = "date_in_vacplus";
            this.coldate_in_vacplus.Name = "coldate_in_vacplus";
            this.coldate_in_vacplus.Visible = true;
            this.coldate_in_vacplus.VisibleIndex = 4;
            // 
            // colnbr_day_vac
            // 
            this.colnbr_day_vac.Caption = "عدد أيام العطلة";
            this.colnbr_day_vac.FieldName = "nbr_day_vac";
            this.colnbr_day_vac.Name = "colnbr_day_vac";
            this.colnbr_day_vac.Visible = true;
            this.colnbr_day_vac.VisibleIndex = 2;
            // 
            // colvacance_year
            // 
            this.colvacance_year.Caption = "سنـــــــة العطـــلة";
            this.colvacance_year.FieldName = "vacance_year";
            this.colvacance_year.Name = "colvacance_year";
            // 
            // colid_vacnace
            // 
            this.colid_vacnace.Caption = "رقم العطـــلة";
            this.colid_vacnace.FieldName = "id_vacnace";
            this.colid_vacnace.Name = "colid_vacnace";
            // 
            // frm_all_vac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 637);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.dataNavigator1);
            this.Controls.Add(this.SimpleButton3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox12);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_all_vac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العطل السنوية الخاصة بالموظفين";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employBindingSource)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docvacanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docvacaneplusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.SimpleButton SimpleButton3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.BindingSource employBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colid_vac_plus;
        private DevExpress.XtraGrid.Columns.GridColumn coltitre_vacplus;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_out_vacpus;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_in_vacplus;
        private DevExpress.XtraGrid.Columns.GridColumn colnbr_day_vac;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource docvacanceBindingSource;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnbr_cons;
        private DevExpress.XtraGrid.Columns.GridColumn colnbr_rest;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_vac_out;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_vac_in;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_interim;
        private DevExpress.XtraGrid.Columns.GridColumn colplace_vac;
        private System.Windows.Forms.BindingSource docvacaneplusBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colvacance_year;
        private DevExpress.XtraGrid.Columns.GridColumn colid_vacnace;
        private DevExpress.XtraGrid.Columns.GridColumn colvacance_year1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_vacnace1;
    }
}