namespace apc.imprission
{
    partial class who_charge_poste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(who_charge_poste));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.doc2chargeposteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coln_9arar_charge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_start_charge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_fin_charge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemploy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapc_annex_catgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapc_annex_catgr_detail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkEdit9 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit8 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit6 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit5 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit4 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkEdit7 = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doc2chargeposteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit7.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.doc2chargeposteBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 120);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1006, 630);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // doc2chargeposteBindingSource
            // 
            this.doc2chargeposteBindingSource.DataSource = typeof(apc.Modele.doc2_charge_poste);
            this.doc2chargeposteBindingSource.CurrentChanged += new System.EventHandler(this.doc2chargeposteBindingSource_CurrentChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coln_9arar_charge,
            this.coldate_start_charge,
            this.coldate_fin_charge,
            this.colemploy,
            this.colapc_annex_catgr,
            this.colapc_annex_catgr_detail,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gridView1_CustomRowFilter);
            // 
            // coln_9arar_charge
            // 
            this.coln_9arar_charge.Caption = "رقم القرار";
            this.coln_9arar_charge.FieldName = "n_9arar_charge";
            this.coln_9arar_charge.Name = "coln_9arar_charge";
            this.coln_9arar_charge.Visible = true;
            this.coln_9arar_charge.VisibleIndex = 2;
            this.coln_9arar_charge.Width = 67;
            // 
            // coldate_start_charge
            // 
            this.coldate_start_charge.Caption = "تاريخ بداية التكليف";
            this.coldate_start_charge.FieldName = "date_start_charge";
            this.coldate_start_charge.Name = "coldate_start_charge";
            this.coldate_start_charge.Visible = true;
            this.coldate_start_charge.VisibleIndex = 3;
            this.coldate_start_charge.Width = 120;
            // 
            // coldate_fin_charge
            // 
            this.coldate_fin_charge.Caption = "تاريخ نهاية التكليف";
            this.coldate_fin_charge.FieldName = "date_fin_charge";
            this.coldate_fin_charge.Name = "coldate_fin_charge";
            this.coldate_fin_charge.Visible = true;
            this.coldate_fin_charge.VisibleIndex = 4;
            this.coldate_fin_charge.Width = 118;
            // 
            // colemploy
            // 
            this.colemploy.Caption = "لقب الموظف";
            this.colemploy.FieldName = "employ.nom_ar";
            this.colemploy.Name = "colemploy";
            this.colemploy.Visible = true;
            this.colemploy.VisibleIndex = 0;
            this.colemploy.Width = 135;
            // 
            // colapc_annex_catgr
            // 
            this.colapc_annex_catgr.Caption = "نوع المصلحة";
            this.colapc_annex_catgr.FieldName = "apc_annex_catgr.nom_apc_annex";
            this.colapc_annex_catgr.Name = "colapc_annex_catgr";
            this.colapc_annex_catgr.Visible = true;
            this.colapc_annex_catgr.VisibleIndex = 5;
            this.colapc_annex_catgr.Width = 129;
            // 
            // colapc_annex_catgr_detail
            // 
            this.colapc_annex_catgr_detail.Caption = "اسم الملحقة أو المصلحة";
            this.colapc_annex_catgr_detail.FieldName = "apc_annex_catgr_detail.nom_annex_detail";
            this.colapc_annex_catgr_detail.Name = "colapc_annex_catgr_detail";
            this.colapc_annex_catgr_detail.Visible = true;
            this.colapc_annex_catgr_detail.VisibleIndex = 6;
            this.colapc_annex_catgr_detail.Width = 291;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "اسم الموظف";
            this.gridColumn1.FieldName = "employ.prenom_ar";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 128;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 114);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkEdit9);
            this.groupBox2.Controls.Add(this.checkEdit8);
            this.groupBox2.Controls.Add(this.checkEdit6);
            this.groupBox2.Controls.Add(this.checkEdit5);
            this.groupBox2.Controls.Add(this.checkEdit4);
            this.groupBox2.Controls.Add(this.checkEdit3);
            this.groupBox2.Controls.Add(this.checkEdit2);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 55);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // checkEdit9
            // 
            this.checkEdit9.Location = new System.Drawing.Point(551, 20);
            this.checkEdit9.Name = "checkEdit9";
            this.checkEdit9.Properties.Caption = "المذبح";
            this.checkEdit9.Size = new System.Drawing.Size(75, 19);
            this.checkEdit9.TabIndex = 6;
            this.checkEdit9.CheckedChanged += new System.EventHandler(this.checkEdit9_CheckedChanged);
            // 
            // checkEdit8
            // 
            this.checkEdit8.Location = new System.Drawing.Point(470, 20);
            this.checkEdit8.Name = "checkEdit8";
            this.checkEdit8.Properties.Caption = "الحضائر";
            this.checkEdit8.Size = new System.Drawing.Size(75, 19);
            this.checkEdit8.TabIndex = 5;
            this.checkEdit8.CheckedChanged += new System.EventHandler(this.checkEdit8_CheckedChanged);
            // 
            // checkEdit6
            // 
            this.checkEdit6.Location = new System.Drawing.Point(368, 20);
            this.checkEdit6.Name = "checkEdit6";
            this.checkEdit6.Properties.Caption = "المناصب العليا";
            this.checkEdit6.Size = new System.Drawing.Size(87, 19);
            this.checkEdit6.TabIndex = 4;
            this.checkEdit6.CheckedChanged += new System.EventHandler(this.checkEdit6_CheckedChanged);
            // 
            // checkEdit5
            // 
            this.checkEdit5.Location = new System.Drawing.Point(290, 20);
            this.checkEdit5.Name = "checkEdit5";
            this.checkEdit5.Properties.Caption = "المكاتب";
            this.checkEdit5.Size = new System.Drawing.Size(75, 19);
            this.checkEdit5.TabIndex = 3;
            this.checkEdit5.CheckedChanged += new System.EventHandler(this.checkEdit5_CheckedChanged);
            // 
            // checkEdit4
            // 
            this.checkEdit4.Location = new System.Drawing.Point(217, 20);
            this.checkEdit4.Name = "checkEdit4";
            this.checkEdit4.Properties.Caption = "المدارس";
            this.checkEdit4.Size = new System.Drawing.Size(67, 19);
            this.checkEdit4.TabIndex = 2;
            this.checkEdit4.CheckedChanged += new System.EventHandler(this.checkEdit4_CheckedChanged);
            // 
            // checkEdit3
            // 
            this.checkEdit3.Location = new System.Drawing.Point(111, 20);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Caption = "المصالح الادارية";
            this.checkEdit3.Size = new System.Drawing.Size(100, 19);
            this.checkEdit3.TabIndex = 1;
            this.checkEdit3.CheckedChanged += new System.EventHandler(this.checkEdit3_CheckedChanged);
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(6, 20);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "ملحقات البلدية";
            this.checkEdit2.Size = new System.Drawing.Size(99, 19);
            this.checkEdit2.TabIndex = 0;
            this.checkEdit2.CheckedChanged += new System.EventHandler(this.checkEdit2_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkEdit7);
            this.groupBox3.Location = new System.Drawing.Point(235, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 43);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // checkEdit7
            // 
            this.checkEdit7.Location = new System.Drawing.Point(36, 15);
            this.checkEdit7.Name = "checkEdit7";
            this.checkEdit7.Properties.Caption = "تكليف ســـــــــاري المفعول";
            this.checkEdit7.Size = new System.Drawing.Size(174, 19);
            this.checkEdit7.TabIndex = 0;
            this.checkEdit7.CheckedChanged += new System.EventHandler(this.checkEdit7_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkEdit1);
            this.groupBox1.Location = new System.Drawing.Point(685, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 53);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(6, 20);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.checkEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.checkEdit1.Properties.Caption = "تصفية و فرز الجدول";
            this.checkEdit1.Size = new System.Drawing.Size(131, 19);
            this.checkEdit1.TabIndex = 7;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(839, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(155, 42);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Excel تصدير الجدول الى";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(839, 60);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(89, 42);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "طباعــــــة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // who_charge_poste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 676);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "who_charge_poste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "القائمـــــــــــــــــــــة الاسمية للموظفين المكلفيــــــــــــــن ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doc2chargeposteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit7.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource doc2chargeposteBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coln_9arar_charge;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_start_charge;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_fin_charge;
        private DevExpress.XtraGrid.Columns.GridColumn colemploy;
        private DevExpress.XtraGrid.Columns.GridColumn colapc_annex_catgr;
        private DevExpress.XtraGrid.Columns.GridColumn colapc_annex_catgr_detail;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        private DevExpress.XtraEditors.CheckEdit checkEdit4;
        private DevExpress.XtraEditors.CheckEdit checkEdit5;
        private DevExpress.XtraEditors.CheckEdit checkEdit6;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.CheckEdit checkEdit7;
        private DevExpress.XtraEditors.CheckEdit checkEdit8;
        private DevExpress.XtraEditors.CheckEdit checkEdit9;
    }
}