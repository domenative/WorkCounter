namespace WorkCounter.Views
{
    partial class useDashboard
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
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lbcHoursWorked = new DevExpress.XtraEditors.LabelControl();
            this.lbcDaysWorked = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDaysWorked = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lbcDaysWorkedText = new DevExpress.XtraEditors.LabelControl();
            this.lciDaysWorkedText = new DevExpress.XtraLayout.LayoutControlItem();
            this.lbcHoursWorkedText = new DevExpress.XtraEditors.LabelControl();
            this.lciHoursWorkedText = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDaysWorked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDaysWorkedText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHoursWorkedText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lbcHoursWorkedText);
            this.layoutControl1.Controls.Add(this.lbcDaysWorkedText);
            this.layoutControl1.Controls.Add(this.lbcHoursWorked);
            this.layoutControl1.Controls.Add(this.lbcDaysWorked);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(860, 239, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(681, 546);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "licControler";
            // 
            // lbcHoursWorked
            // 
            this.lbcHoursWorked.Appearance.Font = new System.Drawing.Font("Digital-7 Mono", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcHoursWorked.Appearance.Options.UseFont = true;
            this.lbcHoursWorked.Appearance.Options.UseTextOptions = true;
            this.lbcHoursWorked.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcHoursWorked.Location = new System.Drawing.Point(324, 101);
            this.lbcHoursWorked.Name = "lbcHoursWorked";
            this.lbcHoursWorked.Size = new System.Drawing.Size(345, 59);
            this.lbcHoursWorked.StyleController = this.layoutControl1;
            this.lbcHoursWorked.TabIndex = 5;
            this.lbcHoursWorked.Text = "00:00";
            // 
            // lbcDaysWorked
            // 
            this.lbcDaysWorked.Appearance.Font = new System.Drawing.Font("Digital-7 Mono", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcDaysWorked.Appearance.Options.UseFont = true;
            this.lbcDaysWorked.Appearance.Options.UseTextOptions = true;
            this.lbcDaysWorked.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcDaysWorked.Location = new System.Drawing.Point(12, 101);
            this.lbcDaysWorked.Name = "lbcDaysWorked";
            this.lbcDaysWorked.Size = new System.Drawing.Size(308, 59);
            this.lbcDaysWorked.StyleController = this.layoutControl1;
            this.lbcDaysWorked.TabIndex = 4;
            this.lbcDaysWorked.Text = "00:00";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDaysWorked,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.lciDaysWorkedText,
            this.lciHoursWorkedText,
            this.emptySpaceItem5,
            this.emptySpaceItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(681, 546);
            this.Root.TextVisible = false;
            // 
            // lciDaysWorked
            // 
            this.lciDaysWorked.Control = this.lbcDaysWorked;
            this.lciDaysWorked.Location = new System.Drawing.Point(0, 89);
            this.lciDaysWorked.MinSize = new System.Drawing.Size(67, 17);
            this.lciDaysWorked.Name = "lciDaysWorked";
            this.lciDaysWorked.Size = new System.Drawing.Size(312, 63);
            this.lciDaysWorked.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDaysWorked.TextSize = new System.Drawing.Size(0, 0);
            this.lciDaysWorked.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lbcHoursWorked;
            this.layoutControlItem2.Location = new System.Drawing.Point(312, 89);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(67, 17);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(349, 63);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(312, 24);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(312, 0);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(349, 24);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(312, 152);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(349, 374);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 152);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(312, 374);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lbcDaysWorkedText
            // 
            this.lbcDaysWorkedText.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcDaysWorkedText.Appearance.Options.UseFont = true;
            this.lbcDaysWorkedText.Appearance.Options.UseTextOptions = true;
            this.lbcDaysWorkedText.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcDaysWorkedText.Location = new System.Drawing.Point(12, 36);
            this.lbcDaysWorkedText.Name = "lbcDaysWorkedText";
            this.lbcDaysWorkedText.Size = new System.Drawing.Size(308, 37);
            this.lbcDaysWorkedText.StyleController = this.layoutControl1;
            this.lbcDaysWorkedText.TabIndex = 6;
            this.lbcDaysWorkedText.Text = "Tage Gearbeitet:";
            // 
            // lciDaysWorkedText
            // 
            this.lciDaysWorkedText.Control = this.lbcDaysWorkedText;
            this.lciDaysWorkedText.Location = new System.Drawing.Point(0, 24);
            this.lciDaysWorkedText.MinSize = new System.Drawing.Size(67, 17);
            this.lciDaysWorkedText.Name = "lciDaysWorkedText";
            this.lciDaysWorkedText.Size = new System.Drawing.Size(312, 41);
            this.lciDaysWorkedText.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDaysWorkedText.TextSize = new System.Drawing.Size(0, 0);
            this.lciDaysWorkedText.TextVisible = false;
            // 
            // lbcHoursWorkedText
            // 
            this.lbcHoursWorkedText.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            this.lbcHoursWorkedText.Appearance.Options.UseFont = true;
            this.lbcHoursWorkedText.Appearance.Options.UseTextOptions = true;
            this.lbcHoursWorkedText.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbcHoursWorkedText.Location = new System.Drawing.Point(324, 36);
            this.lbcHoursWorkedText.Name = "lbcHoursWorkedText";
            this.lbcHoursWorkedText.Size = new System.Drawing.Size(345, 37);
            this.lbcHoursWorkedText.StyleController = this.layoutControl1;
            this.lbcHoursWorkedText.TabIndex = 7;
            this.lbcHoursWorkedText.Text = "Stunden Gearbeitet";
            // 
            // lciHoursWorkedText
            // 
            this.lciHoursWorkedText.Control = this.lbcHoursWorkedText;
            this.lciHoursWorkedText.Location = new System.Drawing.Point(312, 24);
            this.lciHoursWorkedText.MinSize = new System.Drawing.Size(67, 17);
            this.lciHoursWorkedText.Name = "lciHoursWorkedText";
            this.lciHoursWorkedText.Size = new System.Drawing.Size(349, 41);
            this.lciHoursWorkedText.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciHoursWorkedText.TextSize = new System.Drawing.Size(0, 0);
            this.lciHoursWorkedText.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(312, 65);
            this.emptySpaceItem5.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(349, 24);
            this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 65);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(312, 24);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // useDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "useDashboard";
            this.Size = new System.Drawing.Size(681, 546);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDaysWorked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDaysWorkedText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHoursWorkedText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LabelControl lbcHoursWorked;
        private DevExpress.XtraEditors.LabelControl lbcDaysWorked;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciDaysWorked;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.LabelControl lbcHoursWorkedText;
        private DevExpress.XtraEditors.LabelControl lbcDaysWorkedText;
        private DevExpress.XtraLayout.LayoutControlItem lciDaysWorkedText;
        private DevExpress.XtraLayout.LayoutControlItem lciHoursWorkedText;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
    }
}
