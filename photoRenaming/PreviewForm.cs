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
using DevExpress.XtraGrid.Views.Grid;
using photoRenaming.Core;

namespace photoRenaming
{
    public partial class PreviewForm : DevExpress.XtraEditors.XtraForm
    {
        private List<ImageFile> _imageFiles;
        private bool _useRating;

        public PreviewForm(List<ImageFile> imageFiles, bool useRating)
        {
            InitializeComponent();
            this._imageFiles = imageFiles;
            _useRating = useRating;
        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {
            gridPreview.Dock = DockStyle.Fill;
            gridPreview.ViewCollection.Add(gridViewMain);
            gridPreview.MainView = gridViewMain;
            
           
           

            if (_useRating)
            {
                gridViewMain.Columns[2].Caption = "Ratings (Click to Toggle)";
                gridViewMain.Columns[2].FieldName = "Rating";

                this.gridColumnAttributes.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
                this.gridColumnAttributes.AppearanceCell.ForeColor = System.Drawing.Color.Red;
                this.gridColumnAttributes.AppearanceCell.Options.UseFont = true;
                this.gridColumnAttributes.AppearanceCell.Options.UseForeColor = true;
                this.gridColumnAttributes.AppearanceCell.Options.UseTextOptions = true;
            }else
            {
                this.gridColumnAttributes.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
                this.gridColumnAttributes.AppearanceCell.ForeColor = System.Drawing.Color.Black;
                this.gridColumnAttributes.AppearanceCell.Options.UseFont = true;
                this.gridColumnAttributes.AppearanceCell.Options.UseForeColor = true;
                this.gridColumnAttributes.AppearanceCell.Options.UseTextOptions = true;
                gridViewMain.Columns[2].Caption = "Attributes (Click to Toggle)";
                gridViewMain.Columns[2].FieldName = "Attributes";
            }

            gridViewMain.OptionsView.ShowAutoFilterRow = false;
            gridViewMain.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            gridViewMain.OptionsSelection.MultiSelect = true;
            gridViewMain.OptionsBehavior.ReadOnly = true;

            gridPreview.DataSource = _imageFiles;
            gridViewMain.SelectAll();
        }
 
        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            FrmSettings parent = (FrmSettings)this.Owner;
            parent.SendToParent(_imageFiles);
            this.Close();}

        private void gridView1_RowClick_1(object sender, RowClickEventArgs e)
        {

            try
            {
                var row = (gridPreview.FocusedView as GridView).GetRow(e.RowHandle);

                var file = (ImageFile)row;

                if (!_useRating) { 
                if (file.Attributes.Equals(FileAttributes.ReadOnly | FileAttributes.Archive))
                    file.Attributes = FileAttributes.Archive;
                else if (file.Attributes.Equals(FileAttributes.ReadOnly))
                    file.Attributes = FileAttributes.Archive;
                else if (file.Attributes.Equals(FileAttributes.Archive))
                    file.Attributes = FileAttributes.ReadOnly;
                }else if (_useRating)
                {
                    file.Rating = file.Rating.Contains("*") ? "" : "*****";
                }
                gridPreview.RefreshDataSource();
            }
            catch (Exception)
            { }
            
        }
         
    }
}