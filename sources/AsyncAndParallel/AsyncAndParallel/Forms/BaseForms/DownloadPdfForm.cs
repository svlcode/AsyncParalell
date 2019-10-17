using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncAndParallel.Forms.BaseForms;

namespace AsyncAndParallel
{
    public partial class DownloadPdfForm : BaseListBoxForm
    {
        public DownloadPdfForm()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            StartDownload();
        }

        protected void StartDownload()
        {
            string url = txtUrl.Text;
            string destinationFile = CreateFileNameFromUrl(url);
            if (destinationFile.ToLower().EndsWith(".pdf"))
            {
                DeleteAllPDF_FilesFromCurrentDir();
                DownloadPDF_FromUrlToFile(url, destinationFile);
            }
            else
            {
                MessageBox.Show("Invalid PDF file");
            }
        }

        private string CreateFileNameFromUrl(string uriString)
        {
            Uri uri = new Uri(uriString);
            return System.IO.Path.GetFileName(uri.AbsolutePath);
        }

        private void DeleteAllPDF_FilesFromCurrentDir()
        {
            var currentDir = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            var files = Directory.GetFiles(currentDir, "*.pdf");
            foreach (var file in files)
            {
                File.Delete(file);
            }
        }

        private void DownloadPDF_FromUrlToFile(string url, string destinationFile)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(url, destinationFile);
            }
        }
    }
}
