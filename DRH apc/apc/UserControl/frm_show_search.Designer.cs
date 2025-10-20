namespace apc.UserControl
{
    partial class frm_show_search
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.employBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_ar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprenom_ar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_fr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprenom_fr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_n = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_n_prisime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collieu_n = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprenom_pere = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_install = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrank_orgnl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coln_ccp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coln_cnas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsituation_fml = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcatgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnbr_children = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colservice_nationale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coletat_emply = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrotba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiplome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbranche = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapc_annex_catgr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapc_annex_catgr_detail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_out_work = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.employBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1062, 578);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnom_ar,
            this.colprenom_ar,
            this.colnom_fr,
            this.colprenom_fr,
            this.colsex,
            this.coldate_n,
            this.coldate_n_prisime,
            this.collieu_n,
            this.colprenom_pere,
            this.coladresse,
            this.coldate_install,
            this.colrank_orgnl,
            this.coln_ccp,
            this.coln_cnas,
            this.colsituation_fml,
            this.colcatgr,
            this.colnbr_children,
            this.colservice_nationale,
            this.coletat_emply,
            this.colrotba,
            this.coldiplome,
            this.colbranche,
            this.colapc_annex_catgr,
            this.colapc_annex_catgr_detail,
            this.coldate_out_work});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // colid
            // 
            this.colid.Caption = "الرقم";
            this.colid.FieldName = "id";
            this.colid.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 43;
            // 
            // colnom_ar
            // 
            this.colnom_ar.Caption = "اللقب";
            this.colnom_ar.FieldName = "nom_ar";
            this.colnom_ar.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colnom_ar.Name = "colnom_ar";
            this.colnom_ar.Visible = true;
            this.colnom_ar.VisibleIndex = 1;
            // 
            // colprenom_ar
            // 
            this.colprenom_ar.Caption = "الاسم";
            this.colprenom_ar.FieldName = "prenom_ar";
            this.colprenom_ar.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colprenom_ar.Name = "colprenom_ar";
            this.colprenom_ar.Visible = true;
            this.colprenom_ar.VisibleIndex = 2;
            // 
            // colnom_fr
            // 
            this.colnom_fr.Caption = "nom";
            this.colnom_fr.FieldName = "nom_fr";
            this.colnom_fr.Name = "colnom_fr";
            this.colnom_fr.Visible = true;
            this.colnom_fr.VisibleIndex = 3;
            this.colnom_fr.Width = 97;
            // 
            // colprenom_fr
            // 
            this.colprenom_fr.Caption = "prenom";
            this.colprenom_fr.FieldName = "prenom_fr";
            this.colprenom_fr.Name = "colprenom_fr";
            this.colprenom_fr.Visible = true;
            this.colprenom_fr.VisibleIndex = 4;
            this.colprenom_fr.Width = 82;
            // 
            // colsex
            // 
            this.colsex.Caption = "الجنس";
            this.colsex.FieldName = "sex";
            this.colsex.Name = "colsex";
            this.colsex.Visible = true;
            this.colsex.VisibleIndex = 5;
            this.colsex.Width = 95;
            // 
            // coldate_n
            // 
            this.coldate_n.Caption = "تاريخ  الميلاد";
            this.coldate_n.FieldName = "date_n";
            this.coldate_n.Name = "coldate_n";
            this.coldate_n.Visible = true;
            this.coldate_n.VisibleIndex = 6;
            this.coldate_n.Width = 85;
            // 
            // coldate_n_prisime
            // 
            this.coldate_n_prisime.Caption = "ميلاد خلال تاريخ";
            this.coldate_n_prisime.FieldName = "date_n_prisime";
            this.coldate_n_prisime.Name = "coldate_n_prisime";
            this.coldate_n_prisime.Visible = true;
            this.coldate_n_prisime.VisibleIndex = 7;
            this.coldate_n_prisime.Width = 103;
            // 
            // collieu_n
            // 
            this.collieu_n.Caption = "مكان الميلاد";
            this.collieu_n.FieldName = "lieu_n";
            this.collieu_n.Name = "collieu_n";
            this.collieu_n.Visible = true;
            this.collieu_n.VisibleIndex = 8;
            this.collieu_n.Width = 93;
            // 
            // colprenom_pere
            // 
            this.colprenom_pere.Caption = "اسم الأب";
            this.colprenom_pere.FieldName = "prenom_pere";
            this.colprenom_pere.Name = "colprenom_pere";
            this.colprenom_pere.Visible = true;
            this.colprenom_pere.VisibleIndex = 12;
            this.colprenom_pere.Width = 102;
            // 
            // coladresse
            // 
            this.coladresse.Caption = "العنوان الشخصي";
            this.coladresse.FieldName = "adresse";
            this.coladresse.Name = "coladresse";
            this.coladresse.Visible = true;
            this.coladresse.VisibleIndex = 9;
            this.coladresse.Width = 182;
            // 
            // coldate_install
            // 
            this.coldate_install.Caption = "تاريخ التثبيت";
            this.coldate_install.FieldName = "date_install";
            this.coldate_install.Name = "coldate_install";
            this.coldate_install.Visible = true;
            this.coldate_install.VisibleIndex = 18;
            this.coldate_install.Width = 123;
            // 
            // colrank_orgnl
            // 
            this.colrank_orgnl.Caption = "الرتبةالأصلية";
            this.colrank_orgnl.FieldName = "rank_orgnl";
            this.colrank_orgnl.Name = "colrank_orgnl";
            this.colrank_orgnl.Visible = true;
            this.colrank_orgnl.VisibleIndex = 20;
            this.colrank_orgnl.Width = 271;
            // 
            // coln_ccp
            // 
            this.coln_ccp.Caption = "N°ccp";
            this.coln_ccp.FieldName = "n_ccp";
            this.coln_ccp.Name = "coln_ccp";
            this.coln_ccp.Visible = true;
            this.coln_ccp.VisibleIndex = 14;
            this.coln_ccp.Width = 126;
            // 
            // coln_cnas
            // 
            this.coln_cnas.Caption = "N° cnas";
            this.coln_cnas.FieldName = "n_cnas";
            this.coln_cnas.Name = "coln_cnas";
            this.coln_cnas.Visible = true;
            this.coln_cnas.VisibleIndex = 15;
            this.coln_cnas.Width = 122;
            // 
            // colsituation_fml
            // 
            this.colsituation_fml.Caption = "الحالة العائلية";
            this.colsituation_fml.FieldName = "situation_fml";
            this.colsituation_fml.Name = "colsituation_fml";
            this.colsituation_fml.Visible = true;
            this.colsituation_fml.VisibleIndex = 10;
            this.colsituation_fml.Width = 82;
            // 
            // colcatgr
            // 
            this.colcatgr.Caption = "طبيعة الموظف";
            this.colcatgr.FieldName = "catgr";
            this.colcatgr.Name = "colcatgr";
            this.colcatgr.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colcatgr.Visible = true;
            this.colcatgr.VisibleIndex = 16;
            this.colcatgr.Width = 134;
            // 
            // colnbr_children
            // 
            this.colnbr_children.Caption = "عدد الاولاد";
            this.colnbr_children.FieldName = "nbr_children";
            this.colnbr_children.Name = "colnbr_children";
            this.colnbr_children.Visible = true;
            this.colnbr_children.VisibleIndex = 11;
            this.colnbr_children.Width = 67;
            // 
            // colservice_nationale
            // 
            this.colservice_nationale.Caption = "الخدمة الوطنية";
            this.colservice_nationale.FieldName = "service_nationale";
            this.colservice_nationale.Name = "colservice_nationale";
            this.colservice_nationale.Visible = true;
            this.colservice_nationale.VisibleIndex = 13;
            this.colservice_nationale.Width = 108;
            // 
            // coletat_emply
            // 
            this.coletat_emply.Caption = "حالة الموظف";
            this.coletat_emply.FieldName = "etat_emply";
            this.coletat_emply.Name = "coletat_emply";
            this.coletat_emply.Visible = true;
            this.coletat_emply.VisibleIndex = 19;
            this.coletat_emply.Width = 136;
            // 
            // colrotba
            // 
            this.colrotba.Caption = "الرتبة";
            this.colrotba.FieldName = "rotba.nom_rotba";
            this.colrotba.Name = "colrotba";
            this.colrotba.Visible = true;
            this.colrotba.VisibleIndex = 22;
            this.colrotba.Width = 294;
            // 
            // coldiplome
            // 
            this.coldiplome.Caption = "المستوى الدراسي";
            this.coldiplome.FieldName = "diplome";
            this.coldiplome.Name = "coldiplome";
            this.coldiplome.Visible = true;
            this.coldiplome.VisibleIndex = 17;
            this.coldiplome.Width = 114;
            // 
            // colbranche
            // 
            this.colbranche.Caption = "شعبة الموظف";
            this.colbranche.FieldName = "branche.nom_branche";
            this.colbranche.Name = "colbranche";
            this.colbranche.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List;
            this.colbranche.Visible = true;
            this.colbranche.VisibleIndex = 21;
            this.colbranche.Width = 224;
            // 
            // colapc_annex_catgr
            // 
            this.colapc_annex_catgr.Caption = "المصلحة";
            this.colapc_annex_catgr.FieldName = "apc_annex_catgr.nom_apc_annex";
            this.colapc_annex_catgr.Name = "colapc_annex_catgr";
            this.colapc_annex_catgr.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List;
            this.colapc_annex_catgr.Visible = true;
            this.colapc_annex_catgr.VisibleIndex = 23;
            this.colapc_annex_catgr.Width = 154;
            // 
            // colapc_annex_catgr_detail
            // 
            this.colapc_annex_catgr_detail.Caption = "مكان التعيين";
            this.colapc_annex_catgr_detail.FieldName = "apc_annex_catgr_detail.nom_annex_detail";
            this.colapc_annex_catgr_detail.Name = "colapc_annex_catgr_detail";
            this.colapc_annex_catgr_detail.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.List;
            this.colapc_annex_catgr_detail.Visible = true;
            this.colapc_annex_catgr_detail.VisibleIndex = 24;
            this.colapc_annex_catgr_detail.Width = 225;
            // 
            // coldate_out_work
            // 
            this.coldate_out_work.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.coldate_out_work.AppearanceCell.Options.UseForeColor = true;
            this.coldate_out_work.AppearanceCell.Options.UseImage = true;
            this.coldate_out_work.Caption = "تاريخ التقاعد";
            this.coldate_out_work.FieldName = "date_out_work";
            this.coldate_out_work.Name = "coldate_out_work";
            this.coldate_out_work.Visible = true;
            this.coldate_out_work.VisibleIndex = 25;
            this.coldate_out_work.Width = 104;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.Buttons.CancelEdit.Visible = false;
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.Remove.Visible = false;
            this.dataNavigator1.DataSource = this.employBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(720, 7);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(240, 34);
            this.dataNavigator1.TabIndex = 4;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(540, 13);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.checkEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.checkEdit1.Properties.Caption = "تصفية المحتوى";
            this.checkEdit1.Size = new System.Drawing.Size(95, 19);
            this.checkEdit1.TabIndex = 6;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // frm_show_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.dataNavigator1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frm_show_search";
            this.Size = new System.Drawing.Size(1062, 578);
            this.Load += new System.EventHandler(this.frm_show_search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_ar;
        private DevExpress.XtraGrid.Columns.GridColumn colprenom_ar;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_fr;
        private DevExpress.XtraGrid.Columns.GridColumn colprenom_fr;
        private DevExpress.XtraGrid.Columns.GridColumn colsex;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_n;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_n_prisime;
        private DevExpress.XtraGrid.Columns.GridColumn collieu_n;
        private DevExpress.XtraGrid.Columns.GridColumn colprenom_pere;
        private DevExpress.XtraGrid.Columns.GridColumn coladresse;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_install;
        private DevExpress.XtraGrid.Columns.GridColumn colrank_orgnl;
        private DevExpress.XtraGrid.Columns.GridColumn coln_ccp;
        private DevExpress.XtraGrid.Columns.GridColumn coln_cnas;
        private DevExpress.XtraGrid.Columns.GridColumn colsituation_fml;
        private DevExpress.XtraGrid.Columns.GridColumn colcatgr;
        private DevExpress.XtraGrid.Columns.GridColumn colnbr_children;
        private DevExpress.XtraGrid.Columns.GridColumn colservice_nationale;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_out_work;
        private DevExpress.XtraGrid.Columns.GridColumn coletat_emply;
        private DevExpress.XtraGrid.Columns.GridColumn colrotba;
        private DevExpress.XtraGrid.Columns.GridColumn colbranche;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource employBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colapc_annex_catgr;
        private DevExpress.XtraGrid.Columns.GridColumn colapc_annex_catgr_detail;
        private DevExpress.XtraGrid.Columns.GridColumn coldiplome;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
