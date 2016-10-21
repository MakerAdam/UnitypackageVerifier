using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPV
{
    public partial class frmApp : Form
    {
        public frmApp()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "unitypackage (*.unitypackage) | *.unitypackage";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                GetDetails(openFileDialog1.FileName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmApp_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);

            FileInfo oFile = new FileInfo(files[0]);
            if (oFile.Extension == ".unitypackage")
            {
                GetDetails(oFile.FullName);
            }
        }

        private void frmApp_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void GetDetails(string FilePath)
        {
            AssetItems.RootObject packageDetail = PackageStuff.GetPackageDetails(FilePath);
            if (packageDetail != null)
            {
                pnlNope.Visible = false;
                pnlYeah.Visible = true;
                pnlSup.Visible = false;
                lblAssetName.Text = "Title: " + packageDetail.title;
                lblAuthor.Text = "Publisher: " + packageDetail.publisher.label;
                lblVersion.Text = "File Version: " + packageDetail.version + " (" + packageDetail.pubdate + ")";
                lblUnityVersion.Text = "Unity Version :" + packageDetail.unity_version;

            }
            else

            {
                pnlNope.Visible = true;
                pnlYeah.Visible = false;
                pnlSup.Visible = false;
                txtHeader.Text = PackageStuff.Header;
            }
        }
    }
}
