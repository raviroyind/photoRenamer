using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraPrinting.Native;
using photoRenaming.Core;

namespace photoRenaming
{
    public partial class FrmSettings : RibbonForm
    {public List<FileList> FileList;

         
        public bool UserRatings { get; set; }

        public FrmSettings()
        {
            InitializeComponent();
            btnBack.Visibility=BarItemVisibility.Never;
            btnPreview.Visibility = BarItemVisibility.Never;
            
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            
            FileList = new List<FileList>();
            using (var dialouge = new FolderBrowserDialog())
            {
                if (dialouge.ShowDialog() == DialogResult.OK)
                {
                    txtSourcePath.EditValue = dialouge.SelectedPath;

                    var dInfo = new DirectoryInfo(txtSourcePath.EditValue.ToString());

                    var fInfo = dInfo.GetFiles("*.jpg", chkIncludeSubFolder.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                    FileList.AddRange(fInfo.Select(file => new FileList
                    {
                        Name = file.Name,
                        Attributes = file.Attributes,
                        FullPath = file.FullName,
                        Rating = GetRating(file),
                    }));

                    if (FileList.Count > 0)
                    {
                        LoadImages();
                    }
                }
            }
        }

        private void btnDestinationFolder_Click(object sender, EventArgs e)
        {
            using (var dialouge = new FolderBrowserDialog())
            {
                if (dialouge.ShowDialog() == DialogResult.OK)
                {
                    txtDestination.EditValue = dialouge.SelectedPath;
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

            List<FileList> bucketList = new List<FileList>();

            foreach (var file in FileList)
            {
                bucketList.Add(file);
                if (UserRatings && !string.IsNullOrEmpty(file.Rating))
                {
                    CreateOutput(bucketList, txtDestination.EditValue.ToString());
                    bucketList.Clear();
                }
                else if (!UserRatings  && file.Attributes.ToString().Equals("ReadOnly, Archive"))
                {
                    CreateOutput(bucketList, txtDestination.EditValue.ToString());
                    bucketList.Clear();
                }
            }
        }

        public void SendFilesToParent(List<FileList> FileList)
        {
            this.FileList = FileList;
        }

        private static string GetRating(FileSystemInfo file)
        {
            var rating = string.Empty;
            var bitmap = (Bitmap)Image.FromFile(file.FullName);
            try
            {
                var propItem = bitmap.GetPropertyItem(18246);
                rating = BitConverter.ToInt16(propItem.Value, 0).ToString();
            }
            catch (Exception)
            { }
            return rating;
        }

        private static void CreateOutput(List<FileList> bucketList, string destinationFolder)
        {
            foreach (var file in bucketList)
            {
                using (var bmp = new Bitmap(file.FullPath))
                {
                    bmp.Save(destinationFolder + "\\" + Path.GetFileName(file.Name));
                    bmp.Dispose();
                }
            }
        }

        private void galleryControlGallery1_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            var item = e.Item;
          
            if (FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes.Equals(FileAttributes.ReadOnly | FileAttributes.Archive))
                FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes = FileAttributes.Archive;
            else if(FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes.Equals(FileAttributes.ReadOnly))
                FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes = FileAttributes.Archive;
            else if(FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes.Equals(FileAttributes.Archive))
                FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes = FileAttributes.ReadOnly;
            
            LoadImages();
        }

        private void LoadImages()
        {
            gc.Visible = true;
            gc.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            gc.Gallery.ImageSize = new Size(120, 90);
            gc.Gallery.ShowItemText = true;
            groupControl1.Visible = false;
            groupControl2.Visible = false;
            UserRatings = chkUseRatings.Checked;
            var group1 = new GalleryItemGroup { Caption = @"Click on Images to toggle current lock/ ratings." };
            gc.Gallery.Groups.Clear();
            gc.Gallery.Groups.Add(group1);
            btnBack.Visibility = BarItemVisibility.Always;
            btnPreview.Visibility=BarItemVisibility.Never;
            
            if (!UserRatings)
            {
                foreach (var file in FileList)
                {
                    var img = Image.FromFile(file.FullPath);
                    group1.Items.Add(new GalleryItem(img, file.Name, GetAttributeString(file.Attributes)));
                }
            }
            else if (UserRatings)
            {
                foreach (var file in FileList)
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
            {
                switch (ratings)
                {
                    case "1":
                        returnValue = "*";
                        break;case "2":
                        returnValue = "**";
                        break;
                    case "3":
                        returnValue = "***";
                        break;
                    case "4":
                        returnValue = "****";
                        break;
                    case "5":
                        returnValue = "*****";
                        break;
                }
            }
               
            return returnValue;
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

        private void btnProcess_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<FileList> bucketList = new List<FileList>();

            foreach (var file in FileList)
            {
                bucketList.Add(file);

                if (UserRatings && !string.IsNullOrEmpty(file.Rating))
                {
                    CreateOutput(bucketList, txtDestination.EditValue.ToString());
                    bucketList.Clear();
                }
                else if (!UserRatings && file.Attributes.ToString().Equals("ReadOnly, Archive"))
                {
                    CreateOutput(bucketList, txtDestination.EditValue.ToString());
                    bucketList.Clear();
                }}
            gc.Visible = false;groupControl1.Visible = true;
            groupControl2.Visible = true;
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gc.Visible = false;
            groupControl1.Visible = true;
            groupControl2.Visible = true;
            btnPreview.Visibility = txtSourcePath.EditValue != null ? BarItemVisibility.Always : BarItemVisibility.Never;
           
        }
        private void btnPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            var dInfo = new DirectoryInfo(txtSourcePath.EditValue.ToString());

            var fInfo = dInfo.GetFiles("*.jpg", chkIncludeSubFolder.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

            FileList.Clear();

            FileList.AddRange(fInfo.Select(file => new FileList
            {
                Name = file.Name,
                Attributes = file.Attributes,
                FullPath = file.FullName,
                Rating = GetRating(file),
            }));
            if (FileList.Count > 0)
            {
                LoadImages();
            }
        }

        private void txtSourcePath_TextChanged(object sender, EventArgs e)
        {
            if(txtSourcePath.EditValue==null)
                btnPreview.Visibility=BarItemVisibility.Never;else if (!string.IsNullOrEmpty(Convert.ToString(txtSourcePath.EditValue)))
                btnPreview.Visibility = BarItemVisibility.Always;
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            UserRatings = false;
            
        }

        private void chkUseRatings_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if(txtSourcePath.EditValue!=null)
                LoadImages();
        }

         
    }
}