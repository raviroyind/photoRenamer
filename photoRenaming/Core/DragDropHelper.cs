using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace photoRenaming.Core
{
    public class DragDropHelper
    {
        RibbonHitInfo dragItemHitInfo = null;
        GalleryControl sourceGallery, targetGallery;

        public DragDropHelper(GalleryControl sourceGallery, GalleryControl targetGallery)
        {
            this.sourceGallery = sourceGallery;
            this.targetGallery = targetGallery;
        }

        public void EnableDragDrop()
        {
            sourceGallery.MouseDown += OnSourceGalleryMouseDown;
            sourceGallery.MouseMove += OnSourceGalleryMouseMove;

            targetGallery.AllowDrop = true;
            targetGallery.DragDrop += OnTargetGalleryDragDrop;
            targetGallery.DragOver += OnTargetGalleryDragOver;
        }

        private void OnSourceGalleryMouseDown(object sender, MouseEventArgs e)
        {
            GalleryControl galControl = (GalleryControl)sender;
            RibbonHitInfo hitInfo = galControl.CalcHitInfo(e.Location);
            if (hitInfo.InGalleryItem)
            {
                dragItemHitInfo = hitInfo;
                return;
            }

            dragItemHitInfo = null;
        }

        private void OnSourceGalleryMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || Control.ModifierKeys != Keys.None || dragItemHitInfo == null)
                return;

            Size dragSize = SystemInformation.DragSize;
            Rectangle dragRect = new Rectangle(dragItemHitInfo.HitPoint.X - dragSize.Width / 2, dragItemHitInfo.HitPoint.Y - dragSize.Height / 2, dragSize.Width, dragSize.Height);
            if (!(dragRect.Contains(e.Location)))
                sourceGallery.DoDragDrop(dragItemHitInfo.GalleryItem, DragDropEffects.Copy);
        }

        private void OnTargetGalleryDragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(GalleryItem)))
                e.Effect = DragDropEffects.Copy;
        }

        private void OnTargetGalleryDragDrop(object sender, DragEventArgs e)
        {
            if (!(e.Data.GetDataPresent(typeof(GalleryItem))))
                return;

            GalleryItem draggedItem = e.Data.GetData(typeof(GalleryItem)) as GalleryItem;

            GalleryControl galControl = (GalleryControl)sender;
            RibbonHitInfo hitInfo = galControl.CalcHitInfo(galControl.PointToClient(new Point(e.X, e.Y)));
            if (hitInfo.InGalleryGroup)
            {
                hitInfo.GalleryItemGroup.Items.Add((GalleryItem)draggedItem.Clone());
            }
            else
            {
                int groupIndex = galControl.Gallery.Groups.Add(new GalleryItemGroup());
                galControl.Gallery.Groups[groupIndex].Caption = draggedItem.GalleryGroup.Caption;
                galControl.Gallery.Groups[groupIndex].Items.Add((GalleryItem)draggedItem.Clone());
            }
        }

        public void DisableDragDrop()
        {
            sourceGallery.MouseDown -= OnSourceGalleryMouseDown;
            sourceGallery.MouseMove -= OnSourceGalleryMouseMove;

            targetGallery.AllowDrop = false;
            targetGallery.DragDrop -= OnTargetGalleryDragDrop;
            targetGallery.DragOver -= OnTargetGalleryDragOver;
        }
    }
}
