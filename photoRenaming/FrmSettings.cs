using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraSplashScreen;
using photoRenaming.Core;

namespace photoRenaming
{
    public partial class FrmSettings : RibbonForm
    {
        public List<ImageFile> FileList;
        public bool UseRatings { get; set; }

        public string ValidationMessage { get; set; }

        public FrmSettings()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.sorter_logo;btnBack.Visibility=BarItemVisibility.Never;
            btnPreview.Visibility = BarItemVisibility.Never;
            
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            FileList = null;
            FileList = new List<ImageFile>();
            using (var dialouge = new FolderBrowserDialog())
            {
                if (dialouge.ShowDialog() == DialogResult.OK)
                {
                    SplashScreenManager.ShowForm(this, typeof(ProgressForm), true, true, false);

                    SplashScreenManager.Default.SetWaitFormDescription("Importing...");

                    txtSourcePath.EditValue = dialouge.SelectedPath;

                    var dInfo = new DirectoryInfo(txtSourcePath.EditValue.ToString());

                    var fInfo = dInfo.GetFiles("*.jpg", chkIncludeSubFolder.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                     
                    FileList.AddRange(fInfo.Select(file => new ImageFile
                    {
                        Name = file.Name,
                        Attributes = file.Attributes,
                        FullPath = file.FullName,
                        Rating = UseRatings ? GetRating(file) : ""
                    }));
                      
                    SplashScreenManager.CloseForm(false);

                    if (FileList.Count > 0)
                    {
                        btnPreview.Visibility = BarItemVisibility.Always;using (var form = new PreviewForm(FileList,UseRatings))
                        {
                            form.ShowDialog(this);
                        }
                    }}
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
        private static string GetRating(FileSystemInfo file)
        {
            var returnValue = string.Empty;
            SplashScreenManager.Default.SetWaitFormDescription("Processing Image Ratings: "+file.Name);
          var bitmap = (Bitmap) Image.FromFile(file.FullName);try
            {
                var propItem = bitmap.GetPropertyItem(18246);
                var rating =  BitConverter.ToInt16(propItem.Value, 0).ToString();

                switch (rating)
                {
                    case "1":
                        returnValue = "*";
                        break;
                    case "2":
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
            catch (Exception)
            {
                bitmap.Dispose();
            }
            return returnValue;
        }

        private void galleryControlGallery1_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            var item = e.Item;

            if (!UseRatings) 
            { 
                if (FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes.Equals(FileAttributes.ReadOnly | FileAttributes.Archive))
                    FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes = FileAttributes.Archive;
                else if(FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes.Equals(FileAttributes.ReadOnly))
                    FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes = FileAttributes.Archive;
                else if(FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes.Equals(FileAttributes.Archive))
                    FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes = FileAttributes.ReadOnly;

                e.Item.Description =
                    GetAttributeString(FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Attributes);

            }
            else
            {
                if (!string.IsNullOrEmpty(FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Rating))
                    FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Rating = string.Empty;
                else if (string.IsNullOrEmpty(FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Rating))
                    FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Rating = "5";

                e.Item.Description =
                    GetRatingString(FileList.FirstOrDefault(f => f.Name.Equals(item.Caption)).Rating);
            }
             
            //LoadImages();
        }

        private void LoadImages()
        {
            gc.Visible = true;
            gc.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            gc.Gallery.ImageSize = new Size(120, 90);
            gc.Gallery.ShowItemText = true;
            groupControlSource.Visible = false;
            groupControlDestination.Visible = false;
           // UseRatings = chkUseRatings.Checked;
            var group1 = new GalleryItemGroup { Caption = @"Click on Images to toggle current lock/ ratings." };
            gc.Gallery.Groups.Clear();
            gc.Gallery.Groups.Add(group1);
            btnBack.Visibility = BarItemVisibility.Always;
            btnPreview.Visibility=BarItemVisibility.Never;
            SplashScreenManager.ShowForm(this, typeof(ProgressForm), true, true, false);

            SplashScreenManager.Default.SetWaitFormDescription("Loading...");

            if (!UseRatings)
            {
                foreach (var file in FileList)
                {
                    var img = Image.FromFile(file.FullPath);
                    group1.Items.Add(new GalleryItem(img, file.Name, GetAttributeString(file.Attributes)));
                }
            }
            else if (UseRatings)
            {
                foreach (var file in FileList)
                {
                    var img = Image.FromFile(file.FullPath);
                    group1.Items.Add(new GalleryItem(img, file.Name, GetRatingString(file.Rating)));
                }
            }

            SplashScreenManager.CloseForm(false);
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
                    returnValue = " (Locked)";break;
            }

            return returnValue;
        }

        private void btnProcess_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              
            if (ValidateForm())
            {
                List<ImageFile> bucketList = new List<ImageFile>();

                var sequenceArray = txtPlayerSequence.EditValue.ToString().Split(',');
                List<ImageFile> imageSets;
           
                if (!UseRatings)
                {
                    imageSets = FileList.Where(f => f.Attributes.Equals(FileAttributes.ReadOnly | FileAttributes.Archive) || f.Attributes.Equals(FileAttributes.ReadOnly)).ToList();
                }
                else
                {
                    imageSets = FileList.Where(f => f.Rating!="").ToList();
                }

                if (imageSets.Count != sequenceArray.Length)
                {
                    XtraMessageBox.Show("Number of player sequence does not match image set.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                 var iCount = 0;
                 SplashScreenManager.ShowForm(this, typeof(ProgressForm), true, true, false);

                 SplashScreenManager.Default.SetWaitFormDescription("Processing Images...");
                foreach (var file in FileList)
                { 
                    file.ImageSet = sequenceArray[iCount].ToString();

                    bucketList.Add(file);

                    if (UseRatings && !string.IsNullOrEmpty(file.Rating))
                    {

                        

                        CreateOutput(bucketList, txtDestination.EditValue.ToString());
                        bucketList.Clear();

                        if (iCount < sequenceArray.Length - 1) 
                            iCount++;
                    }
                    else if (!UseRatings && (file.Attributes.Equals(FileAttributes.ReadOnly) || (file.Attributes.Equals(FileAttributes.ReadOnly | FileAttributes.Archive))))
                    {
                        CreateOutput(bucketList, txtDestination.EditValue.ToString());
                        bucketList.Clear();

                        if (iCount < sequenceArray.Length-1)
                            iCount++;
                    }
                }

                SplashScreenManager.CloseForm(false);

                if (!chkOpenWhenDone.Checked)
                    XtraMessageBox.Show("Image sets created successfully.",
                        "Operation Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    System.Diagnostics.Process.Start(txtDestination.EditValue.ToString());

               
                //FileList.Clear();
            }
            else
            {
                XtraMessageBox.Show(ValidationMessage, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CreateOutput(List<ImageFile> bucketList, string destinationFolder)
        {
             
            var outPath = destinationFolder + "\\";
            if (!chkNoSubFolders.Checked)
            {
                outPath = destinationFolder + "\\" + bucketList.FirstOrDefault().ImageSet + "\\";
            }
            
            if (!Directory.Exists(outPath))
                Directory.CreateDirectory(outPath);
             
            var iCount = 1;
            foreach (var file in bucketList)
            {
                SplashScreenManager.Default.SetWaitFormDescription("Processing "+ file.Name);
                using (var bmp = new Bitmap(file.FullPath))
                {
                    var finalName = outPath + file.ImageSet;

                    if (txtSuffix.EditValue != null)
                        finalName += txtSuffix.EditValue.ToString();

                        finalName += "(" + iCount + ")" + Path.GetExtension(file.FullPath);

                    bmp.Save(finalName);
                    bmp.Dispose();
                    iCount++;
                }
            }}

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gc.Visible = false;
            groupControlSource.Visible = true;
            groupControlDestination.Visible = true;
            btnPreview.Visibility = txtSourcePath.EditValue != null ? BarItemVisibility.Always : BarItemVisibility.Never;
           
        }
        private void btnPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtSourcePath.EditValue != null)
            {
                if (FileList == null)
                {
                    FileList = new List<ImageFile>();
                    btnPreview.Visibility = BarItemVisibility.Always;
                    SplashScreenManager.ShowForm(this, typeof(ProgressForm), true, true, false);
                    SplashScreenManager.Default.SetWaitFormDescription("Processing Images...");

                    var dInfo = new DirectoryInfo(txtSourcePath.EditValue.ToString());

                    var fInfo = dInfo.GetFiles("*.jpg", chkIncludeSubFolder.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                    FileList.AddRange(fInfo.Select(file => new ImageFile
                    {
                        Name = file.Name,
                        Attributes = file.Attributes,
                        FullPath = file.FullName,
                        Rating = UseRatings ? GetRating(file) : ""
                    }));

                    SplashScreenManager.CloseForm(false);
                }
                 
                if (FileList.Count > 0)
                {
                    var preview = new PreviewForm(FileList, UseRatings);
                    preview.ShowDialog(this);
                }
            }
            
        }

        private void txtSourcePath_TextChanged(object sender, EventArgs e)
        {
            if(txtSourcePath.EditValue==null)
                btnPreview.Visibility=BarItemVisibility.Never;
            else if (!string.IsNullOrEmpty(Convert.ToString(txtSourcePath.EditValue)))
            {
                FileList = new List<ImageFile>();
                  
                var dInfo = new DirectoryInfo(txtSourcePath.EditValue.ToString());

                var fInfo = dInfo.GetFiles("*.jpg", chkIncludeSubFolder.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                FileList.AddRange(fInfo.Select(file => new ImageFile
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
                     
                btnPreview.Visibility = BarItemVisibility.Always;
            }
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            if (barToggle.EditValue == null)
            {
                barToggle.EditValue=false;
                UseRatings = false;
            }
            else
            {
                UseRatings = Convert.ToBoolean(barToggle.EditValue);
            }

            if (txtSourcePath.EditValue != null)
                btnPreview.Visibility = BarItemVisibility.Always;
        }

        private void chkUseRatings_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (txtSourcePath.EditValue != null)
            {
                FileList = null;
                FileList = new List<ImageFile>();

                var dInfo = new DirectoryInfo(txtSourcePath.EditValue.ToString());

                var fInfo = dInfo.GetFiles("*.jpg", chkIncludeSubFolder.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                FileList.AddRange(fInfo.Select(file => new ImageFile
                {
                    Name = file.Name,
                    Attributes = file.Attributes,
                    FullPath = file.FullName,
                    Rating = UseRatings ? GetRating(file) : ""
                }));

                
                if (FileList.Count > 0)
                {
                    var preview = new PreviewForm(FileList,UseRatings);
                    preview.ShowDialog(this);
                }
                      
                    //LoadImages();
            }
        }

        private bool ValidateForm()
        {
            ValidationMessage = string.Empty;var isValid = true;

            if (txtSourcePath.EditValue == null)
            {
                isValid = false;
                ValidationMessage += "Please select source path." + Environment.NewLine;
            }

            if (txtDestination.EditValue == null)
            {
                isValid = false;
                ValidationMessage += "Please select destination path." + Environment.NewLine;
            }

            if (txtPlayerSequence.EditValue == null)
            {
                isValid = false;
                ValidationMessage += "Please enter player sequence." + Environment.NewLine;
            }

            return isValid;
        }

        private void repositoryItemToggleSwitch1_EditValueChanged(object sender, EventArgs e)
        {
           var editor = (ToggleSwitch) sender;
           var logic  =  editor.EditValue;
           UseRatings =(bool)logic;

           if (txtSourcePath.EditValue != null)
           {
               FileList = null;
               FileList = new List<ImageFile>();
               btnPreview.Visibility = BarItemVisibility.Always;
               SplashScreenManager.ShowForm(this, typeof(ProgressForm), true, true, false);
               SplashScreenManager.Default.SetWaitFormDescription("Processing Images...");

               var dInfo = new DirectoryInfo(txtSourcePath.EditValue.ToString());

               var fInfo = dInfo.GetFiles("*.jpg", chkIncludeSubFolder.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

               FileList.AddRange(fInfo.Select(file => new ImageFile
               {
                   Name = file.Name,
                   Attributes = file.Attributes,
                   FullPath = file.FullName,
                   Rating = UseRatings ? GetRating(file) : ""
               }));
               SplashScreenManager.CloseForm(false);
               if (FileList.Count > 0)
               {
                   var preview = new PreviewForm(FileList, UseRatings);
                   preview.ShowDialog(this);
               }
            }
        }

        private void groupControlSource_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void groupControlSource_DragDrop(object sender, DragEventArgs e)
        {
            var directory = string.Empty;

            string[] location = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            FileAttributes attr = File.GetAttributes(location[0].ToString());
            if(attr.HasFlag(FileAttributes.Directory))
                directory = location[0].ToString();
            else
                directory = Path.GetDirectoryName(location[0].ToString());
            txtSourcePath.EditValue = directory;

            if (!string.IsNullOrEmpty(directory))
            {
                FileList = null;
                FileList = new List<ImageFile>();
                
                SplashScreenManager.ShowForm(this, typeof(ProgressForm), true, true, false);

                SplashScreenManager.Default.SetWaitFormDescription("Importing...");

                txtSourcePath.EditValue = directory;

                var dInfo = new DirectoryInfo(txtSourcePath.EditValue.ToString());

                var fInfo = dInfo.GetFiles("*.jpg", chkIncludeSubFolder.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                FileList.AddRange(fInfo.Select(file => new ImageFile
                {
                    Name = file.Name,
                    Attributes = file.Attributes,
                    FullPath = file.FullName,
                    Rating = UseRatings ? GetRating(file) : ""
                }));

                SplashScreenManager.CloseForm(false);

                if (FileList.Count > 0)
                {
                    btnPreview.Visibility = BarItemVisibility.Always; using (var form = new PreviewForm(FileList, UseRatings))
                    {
                        form.ShowDialog(this);
                    }
                }
              
            }
        }

        private void btnClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtSourcePath.EditValue = null;
            txtDestination.EditValue = null;
            txtPlayerSequence.EditValue = null;
            txtSuffix.EditValue = null;
            gc.Visible = false;
            groupControlSource.Visible = true;
            groupControlDestination.Visible = true;
            btnPreview.Visibility =BarItemVisibility.Never;
            FileList.Clear();UseRatings = false;
            toggleSwitchLogic.Checked = false;
        }


        public void SendToParent(List<ImageFile> list)
        {
            this.FileList = list;
        }
    }
}