using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraEditors;
using photoRenaming.Core;

namespace photoRenaming
{
    public partial class frmPreview : XtraForm
    {
        
        public RibbonHitInfo dragItemHitInfo { get; set; }
        public List<FileList> FileLists;
        public bool UserRatings { get; set; }

        public frmPreview(List<FileList> fileLists,bool useRatings=false)
        {
            InitializeComponent();
            FileLists = fileLists;
            UserRatings = useRatings;
        }
 
        private void frmPreview_Load(object sender, EventArgs e)
        {
            gc.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            gc.Gallery.ImageSize = new Size(120, 90);
            gc.Gallery.ShowItemText = true;
            gc.AllowDrop = true; 
            
            LoadImages();
        }
 
        private void galleryControl_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop) || e.Data.GetDataPresent(DataFormats.Text) || e.Data.GetDataPresent("DevExpress.XtraBars.Ribbon.GalleryItem"))
            {
                var galControl = (GalleryControl) sender;
                var hitInfo = galControl.CalcHitInfo(galControl.PointToClient(new Point(e.X, e.Y)));
                if (hitInfo.InGalleryGroup)
                {
                    var groupName = hitInfo.GalleryItemGroup.Caption;
                }
            }
        }

        private void galleryControl_MouseDown(object sender, MouseEventArgs e)
        {
            var gcControl = (GalleryControl) sender;
            var hitInfo = gcControl.CalcHitInfo(e.Location);

            if(hitInfo.InGalleryItem)
                dragItemHitInfo = hitInfo;
            else
                dragItemHitInfo = null;
        }

        private void galleryControlGallery1_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            var item = e.Item;
            if(FileLists.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes == FileAttributes.ReadOnly)
                FileLists.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes = FileAttributes.Archive;
            else
                FileLists.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes = FileAttributes.ReadOnly;

            FrmMain parent = (FrmMain)this.Owner;
            parent.SendFilesToParent(FileLists);
            LoadImages();
            
        }

        private void LoadImages()
        {
            var group1 = new GalleryItemGroup { Caption = @"Images" };
            gc.Gallery.Groups.Clear();
            gc.Gallery.Groups.Add(group1);

            if (!UserRatings)
            {
                foreach (var file in FileLists)
                {
                    var img = Image.FromFile(file.FullPath);
                    group1.Items.Add(new GalleryItem(img, file.Name, GetAttributeString(file.Attributes)));
                }
            }
            else if (UserRatings)
            {
                foreach (var file in FileLists)
                {
                    var img = Image.FromFile(file.FullPath);
                    group1.Items.Add(new GalleryItem(img, file.Name, GetRatingString(file.Rating)));
                }
            }
        }

        private static string GetRatingString(string ratings)
        {
            var returnValue = string.Empty;

            if (!string.IsNullOrEmpty(ratings))
                returnValue = " (Locked)";

            return returnValue;}

        private static string GetAttributeString(FileAttributes fileAttributes)
        {
            var returnValue = string.Empty;

            switch (fileAttributes.ToString())
            {
                case "ReadOnly, Archive":
                    returnValue = " (Locked)";
                    break;
                case "ReadOnly":
                    returnValue = " (Locked)";
                    break;
            }

            return returnValue;
        }
         
    }
}