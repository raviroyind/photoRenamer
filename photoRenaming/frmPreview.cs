using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native;
using photoRenaming.Core;

namespace photoRenaming
{
    public partial class frmPreview : DevExpress.XtraEditors.XtraForm
    {
        
        public RibbonHitInfo dragItemHitInfo { get; set; }private List<FileList> _fileLists=new List<FileList>();
        public frmPreview(List<FileList> fileLists)
        {
            InitializeComponent();
            _fileLists = fileLists;
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

            if (hitInfo.InGalleryItem)
                dragItemHitInfo = hitInfo;
            else
                dragItemHitInfo = null;
        }

        private void galleryControlGallery1_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            var item = e.Item;
            if (_fileLists.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes == FileAttributes.ReadOnly)
                _fileLists.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes = FileAttributes.Archive;
            else
                _fileLists.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes = FileAttributes.ReadOnly;

            LoadImages();
        }

        private void LoadImages()
        {
            var group1 = new GalleryItemGroup { Caption = @"Images" };
            gc.Gallery.Groups.Clear();
            gc.Gallery.Groups.Add(group1);

            foreach (var file in _fileLists)
            {
                var img = Image.FromFile(file.FullPath);
                group1.Items.Add(new GalleryItem(img, file.Name, GetAttributeString(file.Attributes)));
            }
        }

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