namespace apc
{
    partial class emply_who_inVac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emply_who_inVac));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.docvacanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_vacnace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvacance_year = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbr_cons = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_vac_out = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_vac_in = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_interim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemploy_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplace_vac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docvacanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.docvacanceBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 125);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(930, 486);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // docvacanceBindingSource
            // 
            this.docvacanceBindingSource.DataSource = typeof(apc.Modele.doc_vacance);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_vacnace,
            this.colvacance_year,
            this.colnbr_cons,
            this.coldate_vac_out,
            this.coldate_vac_in,
            this.colnom_interim,
            this.colemploy_id,
            this.colplace_vac,
            this.gridColumn2,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_vacnace
            // 
            this.colid_vacnace.Caption = "رقم العطلة";
            this.colid_vacnace.FieldName = "id_vacnace";
            this.colid_vacnace.Name = "colid_vacnace";
            this.colid_vacnace.Visible = true;
            this.colid_vacnace.VisibleIndex = 3;
            this.colid_vacnace.Width = 66;
            // 
            // colvacance_year
            // 
            this.colvacance_year.Caption = "سنة العطلة";
            this.colvacance_year.FieldName = "vacance_year";
            this.colvacance_year.Name = "colvacance_year";
            this.colvacance_year.Visible = true;
            this.colvacance_year.VisibleIndex = 4;
            this.colvacance_year.Width = 72;
            // 
            // colnbr_cons
            // 
            this.colnbr_cons.Caption = "أيام العطلة";
            this.colnbr_cons.FieldName = "nbr_cons";
            this.colnbr_cons.Name = "colnbr_cons";
            this.colnbr_cons.Visible = true;
            this.colnbr_cons.VisibleIndex = 5;
            this.colnbr_cons.Width = 68;
            // 
            // coldate_vac_out
            // 
            this.coldate_vac_out.Caption = "تاريخ بداية العطلة";
            this.coldate_vac_out.FieldName = "date_vac_out";
            this.coldate_vac_out.Name = "coldate_vac_out";
            this.coldate_vac_out.Visible = true;
            this.coldate_vac_out.VisibleIndex = 6;
            this.coldate_vac_out.Width = 98;
            // 
            // coldate_vac_in
            // 
            this.coldate_vac_in.Caption = "تاريخ نهاية العطلة";
            this.coldate_vac_in.FieldName = "date_vac_in";
            this.coldate_vac_in.Name = "coldate_vac_in";
            this.coldate_vac_in.Visible = true;
            this.coldate_vac_in.VisibleIndex = 7;
            this.coldate_vac_in.Width = 104;
            // 
            // colnom_interim
            // 
            this.colnom_interim.Caption = "اسم المستخلف";
            this.colnom_interim.FieldName = "nom_interim";
            this.colnom_interim.Name = "colnom_interim";
            this.colnom_interim.Visible = true;
            this.colnom_interim.VisibleIndex = 8;
            this.colnom_interim.Width = 111;
            // 
            // colemploy_id
            // 
            this.colemploy_id.Caption = "رقم الموظف";
            this.colemploy_id.FieldName = "employ_id";
            this.colemploy_id.Name = "colemploy_id";
            this.colemploy_id.Visible = true;
            this.colemploy_id.VisibleIndex = 0;
            this.colemploy_id.Width = 67;
            // 
            // colplace_vac
            // 
            this.colplace_vac.Caption = "مكان قضاء العطلة";
            this.colplace_vac.FieldName = "place_vac";
            this.colplace_vac.Name = "colplace_vac";
            this.colplace_vac.Visible = true;
            this.colplace_vac.VisibleIndex = 9;
            this.colplace_vac.Width = 145;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "لقب الموظف";
            this.gridColumn2.FieldName = "employ.nom_ar";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 85;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "اسم الموظف";
            this.gridColumn1.FieldName = "employ.prenom_ar";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 93;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(659, 22);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(155, 42);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Excel تصدير الجدول الى";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(820, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(113, 42);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "طباعــــــة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Location = new System.Drawing.Point(110, 12);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(525, 94);
            this.filterControl1.TabIndex = 4;
            this.filterControl1.Text = "filterControl1";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(12, 29);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(92, 35);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "بحـــــث";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // emply_who_inVac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 623);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.filterControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "emply_who_inVac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمـــــــــــــة الموظفيــن في حالة عطلـــــــــــــــة";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docvacanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource docvacanceBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_vacnace;
        private DevExpress.XtraGrid.Columns.GridColumn colvacance_year;
        private DevExpress.XtraGrid.Columns.GridColumn colnbr_cons;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_vac_out;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_vac_in;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_interim;
        private DevExpress.XtraGrid.Columns.GridColumn colemploy_id;
        private DevExpress.XtraGrid.Columns.GridColumn colplace_vac;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        public DevExpress.XtraEditors.FilterControl filterControl1;
    }
}