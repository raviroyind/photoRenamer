namespace photoRenaming
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnProcess = new DevExpress.XtraBars.BarButtonItem();
            this.btnBack = new DevExpress.XtraBars.BarButtonItem();
            this.btnPreview = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.chkUseRatings = new DevExpress.XtraBars.BarCheckItem();
            this.txtPlayerSequence = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.toggleSwitchLogic = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barToggle = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemToggleSwitch1 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.btnClear = new DevExpress.XtraBars.BarButtonItem();
            this.chkKeepTogather = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.groupControlDestination = new DevExpress.XtraEditors.GroupControl();
            this.chkNoSubFolders = new DevExpress.XtraEditors.CheckEdit();
            this.chkOpenWhenDone = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDestination = new DevExpress.XtraEditors.TextEdit();
            this.btnDestinationFolder = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlSource = new DevExpress.XtraEditors.GroupControl();
            this.chkIncludeSubFolder = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSuffix = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSourcePath = new DevExpress.XtraEditors.TextEdit();
            this.btnSourceFolder = new DevExpress.XtraEditors.SimpleButton();
            this.gc = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).BeginInit();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDestination)).BeginInit();
            this.groupControlDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkNoSubFolders.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOpenWhenDone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestination.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSource)).BeginInit();
            this.groupControlSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncludeSubFolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuffix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSourcePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            this.gc.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.btnProcess,
            this.btnBack,
            this.btnPreview,
            this.barStaticItem1,
            this.barStaticItem2,
            this.chkUseRatings,
            this.txtPlayerSequence,
            this.toggleSwitchLogic,
            this.barToggle,
            this.btnClear,
            this.chkKeepTogather});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 35;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemToggleSwitch1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(1349, 155);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Process";
            this.barButtonItem1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnProcess
            // 
            this.btnProcess.Caption = "Process";
            this.btnProcess.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProcess.Glyph")));
            this.btnProcess.Id = 2;
            this.btnProcess.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnProcess.ItemAppearance.Normal.Options.UseFont = true;
            this.btnProcess.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnProcess.LargeGlyph")));
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnProcess.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProcess_ItemClick);
            // 
            // btnBack
            // 
            this.btnBack.Caption = "Back";
            this.btnBack.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBack.Glyph")));
            this.btnBack.Id = 3;
            this.btnBack.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBack.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBack.LargeGlyph")));
            this.btnBack.Name = "btnBack";
            this.btnBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBack_ItemClick);
            // 
            // btnPreview
            // 
            this.btnPreview.Caption = "Preview";
            this.btnPreview.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPreview.Glyph")));
            this.btnPreview.Id = 4;
            this.btnPreview.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnPreview.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPreview.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPreview.LargeGlyph")));
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPreview_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Player Sequence";
            this.barStaticItem1.Id = 5;
            this.barStaticItem1.Name = "barStaticItem1";
            toolTipItem5.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipItem5.Appearance.Options.UseImage = true;
            toolTipItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolTipItem5.Image")));
            toolTipItem5.Text = "Enter comma separated player sequence.";
            superToolTip5.Items.Add(toolTipItem5);
            this.barStaticItem1.SuperTip = superToolTip5;
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Player Sequence.";
            this.barStaticItem2.Id = 7;
            this.barStaticItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.barStaticItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            toolTipItem6.Text = "Enter comman separated player sequence.";
            superToolTip6.Items.Add(toolTipItem6);
            this.barStaticItem2.SuperTip = superToolTip6;
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // chkUseRatings
            // 
            this.chkUseRatings.Caption = "Use Ratings";
            this.chkUseRatings.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText;
            this.chkUseRatings.Id = 16;
            this.chkUseRatings.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.chkUseRatings.ItemAppearance.Hovered.Options.UseFont = true;
            this.chkUseRatings.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.chkUseRatings.ItemAppearance.Normal.Options.UseFont = true;
            this.chkUseRatings.Name = "chkUseRatings";
            this.chkUseRatings.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkUseRatings.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.chkUseRatings_CheckedChanged);
            // 
            // txtPlayerSequence
            // 
            this.txtPlayerSequence.Edit = this.repositoryItemTextEdit1;
            this.txtPlayerSequence.Id = 17;
            this.txtPlayerSequence.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtPlayerSequence.ItemAppearance.Hovered.Options.UseFont = true;
            this.txtPlayerSequence.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtPlayerSequence.ItemAppearance.Normal.Options.UseFont = true;
            this.txtPlayerSequence.Name = "txtPlayerSequence";
            this.txtPlayerSequence.Width = 500;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // toggleSwitchLogic
            // 
            this.toggleSwitchLogic.Caption = "Logic";
            this.toggleSwitchLogic.Id = 19;
            this.toggleSwitchLogic.Name = "toggleSwitchLogic";
            // 
            // barToggle
            // 
            this.barToggle.Caption = "Logic";
            this.barToggle.Edit = this.repositoryItemToggleSwitch1;
            this.barToggle.EditHeight = 26;
            this.barToggle.Id = 20;
            this.barToggle.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.barToggle.ItemAppearance.Normal.Options.UseFont = true;
            this.barToggle.Name = "barToggle";
            this.barToggle.Width = 130;
            // 
            // repositoryItemToggleSwitch1
            // 
            this.repositoryItemToggleSwitch1.AutoHeight = false;
            this.repositoryItemToggleSwitch1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1";
            this.repositoryItemToggleSwitch1.OffText = "Use Lock";
            this.repositoryItemToggleSwitch1.OnText = "Use Ratings";
            this.repositoryItemToggleSwitch1.EditValueChanged += new System.EventHandler(this.repositoryItemToggleSwitch1_EditValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Caption = "Clear";
            this.btnClear.Glyph = ((System.Drawing.Image)(resources.GetObject("btnClear.Glyph")));
            this.btnClear.Id = 21;
            this.btnClear.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ItemAppearance.Normal.Options.UseFont = true;
            this.btnClear.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnClear.LargeGlyph")));
            this.btnClear.Name = "btnClear";
            this.btnClear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClear_ItemClick);
            // 
            // chkKeepTogather
            // 
            this.chkKeepTogather.Caption = "No Subfolders";
            this.chkKeepTogather.Id = 24;
            this.chkKeepTogather.Name = "chkKeepTogather";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Actions";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProcess, false, "", "", true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnClear);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPreview);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBack);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = " ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barStaticItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.txtPlayerSequence);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barToggle);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 688);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1349, 31);
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.groupControlDestination);
            this.panelSettings.Controls.Add(this.groupControlSource);
            this.panelSettings.Controls.Add(this.gc);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(0, 155);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(1349, 533);
            this.panelSettings.TabIndex = 2;
            // 
            // groupControlDestination
            // 
            this.groupControlDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControlDestination.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControlDestination.Controls.Add(this.labelControl3);
            this.groupControlDestination.Controls.Add(this.chkNoSubFolders);
            this.groupControlDestination.Controls.Add(this.chkOpenWhenDone);
            this.groupControlDestination.Controls.Add(this.labelControl4);
            this.groupControlDestination.Controls.Add(this.txtDestination);
            this.groupControlDestination.Controls.Add(this.btnDestinationFolder);
            this.groupControlDestination.Location = new System.Drawing.Point(755, 108);
            this.groupControlDestination.Name = "groupControlDestination";
            this.groupControlDestination.Size = new System.Drawing.Size(532, 235);
            this.groupControlDestination.TabIndex = 16;
            this.groupControlDestination.Text = "Destination";
            // 
            // chkNoSubFolders
            // 
            this.chkNoSubFolders.Location = new System.Drawing.Point(138, 106);
            this.chkNoSubFolders.MenuManager = this.ribbon;
            this.chkNoSubFolders.Name = "chkNoSubFolders";
            this.chkNoSubFolders.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkNoSubFolders.Properties.Appearance.Options.UseFont = true;
            this.chkNoSubFolders.Properties.Caption = " ";
            this.chkNoSubFolders.Size = new System.Drawing.Size(75, 25);
            this.chkNoSubFolders.TabIndex = 5;
            // 
            // chkOpenWhenDone
            // 
            this.chkOpenWhenDone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkOpenWhenDone.Location = new System.Drawing.Point(398, 106);
            this.chkOpenWhenDone.Name = "chkOpenWhenDone";
            this.chkOpenWhenDone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.chkOpenWhenDone.Properties.Appearance.Options.UseFont = true;
            this.chkOpenWhenDone.Properties.Caption = "Open when done.";
            this.chkOpenWhenDone.Size = new System.Drawing.Size(125, 20);
            this.chkOpenWhenDone.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.Location = new System.Drawing.Point(17, 49);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(115, 18);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Destination Folder";
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDestination.Location = new System.Drawing.Point(138, 40);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtDestination.Properties.Appearance.Options.UseFont = true;
            this.txtDestination.Size = new System.Drawing.Size(286, 36);
            this.txtDestination.TabIndex = 2;
            // 
            // btnDestinationFolder
            // 
            this.btnDestinationFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDestinationFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnDestinationFolder.Image")));
            this.btnDestinationFolder.Location = new System.Drawing.Point(425, 40);
            this.btnDestinationFolder.Name = "btnDestinationFolder";
            this.btnDestinationFolder.Size = new System.Drawing.Size(98, 37);
            this.btnDestinationFolder.TabIndex = 1;
            this.btnDestinationFolder.Text = "Select";
            this.btnDestinationFolder.Click += new System.EventHandler(this.btnDestinationFolder_Click);
            // 
            // groupControlSource
            // 
            this.groupControlSource.AllowDrop = true;
            this.groupControlSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControlSource.Controls.Add(this.chkIncludeSubFolder);
            this.groupControlSource.Controls.Add(this.labelControl2);
            this.groupControlSource.Controls.Add(this.txtSuffix);
            this.groupControlSource.Controls.Add(this.labelControl1);
            this.groupControlSource.Controls.Add(this.txtSourcePath);
            this.groupControlSource.Controls.Add(this.btnSourceFolder);
            this.groupControlSource.Location = new System.Drawing.Point(60, 108);
            this.groupControlSource.Name = "groupControlSource";
            this.groupControlSource.Size = new System.Drawing.Size(517, 235);
            this.groupControlSource.TabIndex = 15;
            this.groupControlSource.Text = "Source (Browse Or drag drop folder)";
            this.groupControlSource.UseDisabledStatePainter = false;
            this.groupControlSource.DragDrop += new System.Windows.Forms.DragEventHandler(this.groupControlSource_DragDrop);
            this.groupControlSource.DragEnter += new System.Windows.Forms.DragEventHandler(this.groupControlSource_DragEnter);
            // 
            // chkIncludeSubFolder
            // 
            this.chkIncludeSubFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkIncludeSubFolder.EditValue = true;
            this.chkIncludeSubFolder.Location = new System.Drawing.Point(362, 94);
            this.chkIncludeSubFolder.Name = "chkIncludeSubFolder";
            this.chkIncludeSubFolder.Properties.Caption = "Include Subfolders?";
            this.chkIncludeSubFolder.Size = new System.Drawing.Size(135, 20);
            this.chkIncludeSubFolder.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Location = new System.Drawing.Point(17, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 18);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Suffix";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSuffix.Location = new System.Drawing.Point(111, 93);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtSuffix.Properties.Appearance.Options.UseFont = true;
            this.txtSuffix.Size = new System.Drawing.Size(189, 36);
            this.txtSuffix.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(17, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Source Folder";
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSourcePath.Location = new System.Drawing.Point(111, 43);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtSourcePath.Properties.Appearance.Options.UseFont = true;
            this.txtSourcePath.Size = new System.Drawing.Size(286, 36);
            this.txtSourcePath.TabIndex = 2;
            // 
            // btnSourceFolder
            // 
            this.btnSourceFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSourceFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnSourceFolder.Image")));
            this.btnSourceFolder.Location = new System.Drawing.Point(399, 44);
            this.btnSourceFolder.Name = "btnSourceFolder";
            this.btnSourceFolder.Size = new System.Drawing.Size(98, 37);
            this.btnSourceFolder.TabIndex = 1;
            this.btnSourceFolder.Text = "Select";
            this.btnSourceFolder.Click += new System.EventHandler(this.btnSourceFolder_Click);
            // 
            // gc
            // 
            this.gc.Controls.Add(this.galleryControlClient1);
            this.gc.DesignGalleryGroupIndex = 0;
            this.gc.DesignGalleryItemIndex = 0;
            this.gc.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // galleryControlGallery1
            // 
            this.gc.Gallery.Appearance.GroupCaption.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gc.Gallery.Appearance.GroupCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gc.Gallery.Appearance.GroupCaption.Options.UseFont = true;
            this.gc.Gallery.Appearance.GroupCaption.Options.UseForeColor = true;
            this.gc.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gc.Gallery.Appearance.ItemDescriptionAppearance.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gc.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = true;
            this.gc.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseForeColor = true;
            this.gc.Gallery.Appearance.ItemDescriptionAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gc.Gallery.Appearance.ItemDescriptionAppearance.Normal.ForeColor = System.Drawing.Color.Red;
            this.gc.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = true;
            this.gc.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseForeColor = true;
            this.gc.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Italic);
            this.gc.Gallery.Appearance.ItemDescriptionAppearance.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gc.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = true;
            this.gc.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseForeColor = true;
            this.gc.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControlGallery1_ItemClick);
            this.gc.Location = new System.Drawing.Point(0, 0);
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(1349, 533);
            this.gc.TabIndex = 0;
            this.gc.Visible = false;
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.gc;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(1328, 529);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Location = new System.Drawing.Point(17, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 18);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "No Subfolders?";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 719);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "FrmSettings";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).EndInit();
            this.panelSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDestination)).EndInit();
            this.groupControlDestination.ResumeLayout(false);
            this.groupControlDestination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkNoSubFolders.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOpenWhenDone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestination.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSource)).EndInit();
            this.groupControlSource.ResumeLayout(false);
            this.groupControlSource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncludeSubFolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuffix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSourcePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            this.gc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.Panel panelSettings;
        private DevExpress.XtraEditors.GroupControl groupControlSource;
        private DevExpress.XtraEditors.CheckEdit chkIncludeSubFolder;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSuffix;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSourcePath;
        private DevExpress.XtraEditors.SimpleButton btnSourceFolder;
        private DevExpress.XtraEditors.GroupControl groupControlDestination;
        private DevExpress.XtraEditors.CheckEdit chkOpenWhenDone;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDestination;
        private DevExpress.XtraEditors.SimpleButton btnDestinationFolder;
        private DevExpress.XtraBars.Ribbon.GalleryControl gc;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnProcess;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnBack;
        private DevExpress.XtraBars.BarButtonItem btnPreview;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
       
       
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        
        
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
         
        
         
      
        private DevExpress.XtraBars.BarCheckItem chkUseRatings;
       
        private DevExpress.XtraBars.BarEditItem txtPlayerSequence;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarToggleSwitchItem toggleSwitchLogic;
        private DevExpress.XtraBars.BarEditItem barToggle;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch1;
        private DevExpress.XtraBars.BarButtonItem btnClear;
        private DevExpress.XtraBars.BarCheckItem chkKeepTogather;
        private DevExpress.XtraEditors.CheckEdit chkNoSubFolders;
        private DevExpress.XtraEditors.LabelControl labelControl3;
       
         
    }
}