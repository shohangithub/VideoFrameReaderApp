using System;
using System.Windows.Forms;
using System.Drawing.Imaging;
using GleamTech.VideoUltimate;

namespace VideoFrameReaderApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                txtSource.Text = ofd.FileName;
            }
        }
        private void btnGenerateFrame_Click(object sender, EventArgs e)
        {
         
            //string path = @"F:\Grapics\video.mp4";
      
            string path = txtSource.Text; //Get video path from source path
            using (var videoFrameReader = new VideoFrameReader(path))
            {
                if (videoFrameReader.Read()) //Only if frame was read successfully
                {
                    var resultCount = videoFrameReader.FrameRate * videoFrameReader.Duration.TotalSeconds;

                    progressBar.Maximum = (int)resultCount; // set maximum value of progress bar
                    
                    int i = 1;
                    foreach (var frame in videoFrameReader)
                    {
                        progressBar.Value += 1; // increement progess bar value
                        using (frame) //save generated frame
                        {
                            frame.Save(@$"F:\Grapics\Frame\Frame{i}.jpg", ImageFormat.Jpeg);
                            i++;
                        }
                    }

                    progressBar.Value = 0; // reset progress bar
                }
            }
        }
    }
}
