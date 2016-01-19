namespace photoRenaming
{
    partial class PreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
            this.gridSplitContainer = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridPreview = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAttributes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSaveClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumnNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer)).BeginInit();
            this.gridSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSplitContainer
            // 
            this.gridSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer.Horizontal = false;
            this.gridSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer.Name = "gridSplitContainer";
            this.gridSplitContainer.Panel1.Controls.Add(this.gridPreview);
            this.gridSplitContainer.Panel1.Text = "Panel1";
            this.gridSplitContainer.Panel2.Controls.Add(this.btnSaveClose);
            this.gridSplitContainer.Panel2.MinSize = 80;
            this.gridSplitContainer.Panel2.Text = "Panel2";
            this.gridSplitContainer.Size = new System.Drawing.Size(782, 585);
            this.gridSplitContainer.SplitterPosition = 503;
            this.gridSplitContainer.TabIndex = 0;
            this.gridSplitContainer.Text = "splitContainerControl1";
            // 
            // gridPreview
            // 
            this.gridPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPreview.Location = new System.Drawing.Point(0, 0);
            this.gridPreview.MainView = this.gridViewMain;
            this.gridPreview.Name = "gridPreview";
            this.gridPreview.Size = new System.Drawing.Size(782, 500);
            this.gridPreview.TabIndex = 1;
            this.gridPreview.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnName,
            this.gridColumnNumber,
            this.gridColumnAttributes});
            this.gridViewMain.GridControl = this.gridPreview;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick_1);
            // 
            // gridColumnName
            // 
            this.gridColumnName.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumnName.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnName.Caption = "Name";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            // 
            // gridColumnAttributes
            // 
            this.gridColumnAttributes.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumnAttributes.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.gridColumnAttributes.AppearanceCell.Options.UseFont = true;
            this.gridColumnAttributes.AppearanceCell.Options.UseForeColor = true;
            this.gridColumnAttributes.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnAttributes.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumnAttributes.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnAttributes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnAttributes.Caption = "Attributes (Click to Toggle)";
            this.gridColumnAttributes.FieldName = "Attributes";
            this.gridColumnAttributes.Name = "gridColumnAttributes";
            this.gridColumnAttributes.Visible = true;
            this.gridColumnAttributes.VisibleIndex = 2;
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveClose.Appearance.Options.UseFont = true;
            this.btnSaveClose.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveClose.Image")));
            this.btnSaveClose.Location = new System.Drawing.Point(300, 4);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(173, 61);
            this.btnSaveClose.TabIndex = 0;
            this.btnSaveClose.Text = "Save && Close";
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // gridColumnNumber
            // 
            this.gridColumnNumber.Caption = "Number";
            this.gridColumnNumber.FieldName = "Number";
            this.gridColumnNumber.Name = "gridColumnNumber";
            this.gridColumnNumber.Visible = true;
            this.gridColumnNumber.VisibleIndex = 1;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 585);
            this.Controls.Add(this.gridSplitContainer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreviewForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreviewForm";
            this.Load += new System.EventHandler(this.PreviewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer)).EndInit();
            this.gridSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl gridSplitContainer;
        private DevExpress.XtraGrid.GridControl gridPreview;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.XtraEditors.SimpleButton btnSaveClose;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAttributes;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNumber;

    }
}