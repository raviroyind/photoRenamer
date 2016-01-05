using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using photoRenaming.Core;

namespace photoRenaming
{
    public partial class FrmMain : RibbonForm
    {
        public List<FileList> fileList;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void groupControl1_DragDrop(object sender, DragEventArgs e)
        {
            var ex = e.Data.GetData(DataFormats.FileDrop, false);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            var ex = e;
        }

        private void groupControl1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            fileList = new List<FileList>();
            using (var dialouge = new FolderBrowserDialog())
            {
                if (dialouge.ShowDialog() == DialogResult.OK)
                {
                    txtSourcePath.EditValue = dialouge.SelectedPath;

                    var dInfo = new DirectoryInfo(txtSourcePath.EditValue.ToString());

                    var fInfo = dInfo.GetFiles("*.jpg", chkIncludeSubFolder.Checked? SearchOption.AllDirectories: SearchOption.TopDirectoryOnly);
                    
                    fileList.AddRange(fInfo.Select(file => new FileList
                    {
                        Name = file.Name, Attributes = file.Attributes, FullPath = file.FullName,Rating = GetRating(file),
                    }));

                    if (fileList.Count > 0)
                    { 
                        using (var form = new frmPreview(fileList,toggleSwitchLogic.IsOn))
                        {
                            form.ShowDialog(this);
                        }
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


        public void SendFilesToParent(List<FileList> fileLists)
        {
            this.fileList = fileLists;
        }

        private static string GetRating(FileSystemInfo file)
        {
            var rating = string.Empty;
            var bitmap=(Bitmap) Image.FromFile(file.FullName);
            try
            {
                var propItem = bitmap.GetPropertyItem(18246);
                rating = BitConverter.ToInt16(propItem.Value, 0).ToString();
            }
            catch (Exception)
            { }
            return rating;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            List<FileList> bucketList=new List<FileList>();

            foreach (var file in fileList)
            {
                bucketList.Add(file);

                if (toggleSwitchLogic.IsOn &&  !string.IsNullOrEmpty(file.Rating))
                {
                    CreateOutput(bucketList, txtDestination.EditValue.ToString());
                    bucketList.Clear();
                }
                else if (!toggleSwitchLogic.IsOn && file.Attributes.ToString().Equals("ReadOnly, Archive"))
                {
                    CreateOutput(bucketList, txtDestination.EditValue.ToString());
                    bucketList.Clear();
                }
            }
        }
        private static void CreateOutput(List<FileList> bucketList, string destinationFolder)
        {
            foreach (var file in bucketList)
            {
                using (var bmp = new Bitmap(file.FullPath))
                {
                    bmp.Save(destinationFolder + "\\" +Path.GetFileName(file.Name));
                    bmp.Dispose();
                }
            }
        }

       
    }
}
