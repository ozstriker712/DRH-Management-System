namespace apc
{
    partial class frm_vac_plus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_vac_plus));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.employBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.docvacaneplusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.textEdit7 = new DevExpress.XtraEditors.DateEdit();
            this.textEdit5 = new DevExpress.XtraEditors.DateEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.textEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.SimpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SimpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docvacaneplusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox12);
            this.groupBox1.Location = new System.Drawing.Point(134, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelControl3);
            this.groupBox6.Location = new System.Drawing.Point(38, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(169, 46);
            this.groupBox6.TabIndex = 54;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "اسم الموظف :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employBindingSource, "prenom_ar", true));
            this.labelControl3.Location = new System.Drawing.Point(40, 20);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "labelControl3";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelControl2);
            this.groupBox5.Location = new System.Drawing.Point(291, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(195, 46);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "لقب الموظف :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employBindingSource, "nom_ar", true));
            this.labelControl2.Location = new System.Drawing.Point(52, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "labelControl2";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.labelControl1);
            this.groupBox12.Location = new System.Drawing.Point(593, 20);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox12.Size = new System.Drawing.Size(143, 46);
            this.groupBox12.TabIndex = 52;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "رقم التسلسلي للموظف :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employBindingSource, "id", true));
            this.labelControl1.Location = new System.Drawing.Point(40, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "labelControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.Label6);
            this.groupControl1.Controls.Add(this.Label5);
            this.groupControl1.Controls.Add(this.textEdit7);
            this.groupControl1.Controls.Add(this.textEdit5);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.Label2);
            this.groupControl1.Controls.Add(this.Label1);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Location = new System.Drawing.Point(134, 117);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(760, 314);
            this.groupControl1.TabIndex = 1;
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.docvacaneplusBindingSource, "nbr_day_vac", true));
            this.textEdit3.Location = new System.Drawing.Point(578, 170);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(53, 20);
            this.textEdit3.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 173);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "عدد أيام العطلة :";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(271, 237);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label6.Size = new System.Drawing.Size(69, 13);
            this.Label6.TabIndex = 74;
            this.Label6.Text = "تاريخ الدخول :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(643, 241);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label5.Size = new System.Drawing.Size(68, 13);
            this.Label5.TabIndex = 73;
            this.Label5.Text = "تاريخ الخروج :";
            // 
            // textEdit7
            // 
            this.textEdit7.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.docvacaneplusBindingSource, "date_out_vacpus", true));
            this.textEdit7.EditValue = null;
            this.textEdit7.Location = new System.Drawing.Point(488, 238);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit7.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit7.Properties.EditValueChangedDelay = 100;
            this.textEdit7.Size = new System.Drawing.Size(144, 20);
            this.textEdit7.TabIndex = 76;
            this.textEdit7.DateTimeChanged += new System.EventHandler(this.textEdit7_DateTimeChanged);
            // 
            // textEdit5
            // 
            this.textEdit5.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.docvacaneplusBindingSource, "date_in_vacplus", true));
            this.textEdit5.EditValue = null;
            this.textEdit5.Location = new System.Drawing.Point(137, 234);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit5.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit5.Size = new System.Drawing.Size(128, 20);
            this.textEdit5.TabIndex = 75;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.docvacaneplusBindingSource, "id_vac_plus", true));
            this.textEdit1.Location = new System.Drawing.Point(531, 52);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 69;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(642, 112);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(82, 13);
            this.Label2.TabIndex = 68;
            this.Label2.Text = "عنوان العطـــلة :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(642, 55);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(73, 13);
            this.Label1.TabIndex = 67;
            this.Label1.Text = "رقم العطـــلة :";
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.docvacaneplusBindingSource, "titre_vacplus", true));
            this.textEdit2.Location = new System.Drawing.Point(501, 109);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit2.Properties.Items.AddRange(new object[] {
            "عطلة مرضية",
            "عطلة استثنائية",
            "عطلة أمومة"});
            this.textEdit2.Size = new System.Drawing.Size(130, 20);
            this.textEdit2.TabIndex = 70;
            // 
            // SimpleButton2
            // 
            this.SimpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButton2.Image")));
            this.SimpleButton2.Location = new System.Drawing.Point(12, 392);
            this.SimpleButton2.Name = "SimpleButton2";
            this.SimpleButton2.Size = new System.Drawing.Size(85, 39);
            this.SimpleButton2.TabIndex = 50;
            this.SimpleButton2.Text = "اغلاق";
            this.SimpleButton2.Click += new System.EventHandler(this.SimpleButton2_Click);
            // 
            // SimpleButton1
            // 
            this.SimpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("SimpleButton1.Image")));
            this.SimpleButton1.Location = new System.Drawing.Point(12, 26);
            this.SimpleButton1.Name = "SimpleButton1";
            this.SimpleButton1.Size = new System.Drawing.Size(101, 39);
            this.SimpleButton1.TabIndex = 49;
            this.SimpleButton1.Text = "اضافة ";
            this.SimpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // frm_vac_plus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 459);
            this.Controls.Add(this.SimpleButton2);
            this.Controls.Add(this.SimpleButton1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_vac_plus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة عطلة مرضية أو استثنائية / عطلة أمومــــــــــــة";
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docvacaneplusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.GroupBox groupBox12;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton2;
        internal DevExpress.XtraEditors.SimpleButton SimpleButton1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        private DevExpress.XtraEditors.DateEdit textEdit7;
        public DevExpress.XtraEditors.DateEdit textEdit5;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit2;
        private System.Windows.Forms.BindingSource docvacaneplusBindingSource;
        private System.Windows.Forms.BindingSource employBindingSource;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        internal System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.TextEdit textEdit1;
    }
}