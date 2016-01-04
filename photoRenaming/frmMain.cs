using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;using System.Text;
using System.Windows.Forms;
using photoRenaming.Core;

namespace photoRenaming
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
            var fileList = new List<FileList>();
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

                    if (fileList.Count > 0){
                        var frmPreview = new frmPreview(fileList);
                        frmPreview.Show();
                        frmPreview.BringToFront();
                        frmPreview.Focus();
                    }
                }
            }
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
            {
                 
            }
            return rating;
        }
    }
}
