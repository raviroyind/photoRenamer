namespace photoRenaming
{
    partial class frmPreview
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gc = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            this.gc.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gc);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1024, 501);
            this.splitContainerControl1.SplitterPosition = 401;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
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
            this.gc.Size = new System.Drawing.Size(1024, 401);
            this.gc.TabIndex = 0;
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.gc;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(1003, 397);
            // 
            // frmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 501);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmPreview";
            this.Text = "frmPreview";
            this.Load += new System.EventHandler(this.frmPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            this.gc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControl gc;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;


    }
}