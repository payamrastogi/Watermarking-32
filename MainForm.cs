/*
 * Created by SharpDevelop.
 * User: Payam Rastogi
 * Date: 12/2/2008
 * Time: 7:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using User.DirectShow;
using AviFile;
using System.Threading;

namespace Watermarking
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
    public partial class MainForm : Form
    {
        #region Member Variables
        string CurrentFile;
        string CurrentFolder;
        Image img;
        //ImageCodecInfo myImageCodecInfo;
        //System.Drawing.Imaging.Encoder myEncoder;
        //EncoderParameter myEncoderParameter;
        //EncoderParameters myEncoderParameters;
        System.Drawing.Color myWatermarkColor;
        System.Drawing.Color myVWatermarkColor;
        System.Drawing.Font myFont;
        System.Drawing.Font myVFont;
        int Opac = 100;
        int VOpac = 100;
        int X = 20;          //X-location of the watermark text
        int Y = 20;          //Y-location of the watermark text
        int VX = 20;         //X-location of the watermark text-video
        int VY = 20;         //Y-location of the watermark text-video
        Button prevButton;  //To store the current watermark location button
        Button vPrevButton; //To store the current watermark location button-video
        //string selectedPath;
        private string pathFILE;
        int count = 1;
        float rate;
        #endregion

        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            // setup default settings
            #region Default Settings
            myWatermarkColor = Color.SteelBlue;
            txtBoxText.Text = "Watermark " +
            char.ConvertFromUtf32(169).ToString() + " " +
            DateTime.Now.Year.ToString() + ", All Rights Reserved";
            myFont = txtBoxText.Font;
            prevButton = btTopLeft;
            myVWatermarkColor = Color.SteelBlue;
            txtVWatermark.Text = "Watermark " +
            char.ConvertFromUtf32(169).ToString() + " " +
            DateTime.Now.Year.ToString() + ", All Rights Reserved";
            myVFont = txtVWatermark.Font;
            vPrevButton = btVTopLeft;
            #endregion

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        OpenFileDialog openFileDlg = new OpenFileDialog();
        FolderBrowserDialog fbDlg = new FolderBrowserDialog();
        SaveFileDialog svDlg = new SaveFileDialog();

        

        #region MainForm Load
        void MainFormLoad(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString() + "||" + DateTime.Now.ToLongTimeString();
            lblStatus.Text = "Ready";
            //txtBoxOutFolder.Text = @"C:\Documents and Settings\Payam Rastogi\My Documents\My Pictures";
            //txtBoxOutFolder.Text = @"C:\Documents and Settings\Payam Rastogi\Desktop\Wallpapers";
        }
        #endregion

        #region Time Settings
        void Timer1Tick(object sender, System.EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString() + "||" + DateTime.Now.ToLongTimeString();
        }
        #endregion

        #region OpenFile
        void ToolStripBtOpenFileClick(object sender, EventArgs e)
        {
            openFile();
            grpBoxWatemarkText.Enabled = true;
            grpBoxOutSet.Enabled = true;
            grpBoxWPosition.Enabled = true;
            chkHideMessage.Enabled = true;
            btApplyWatermark.Enabled = true;
        }

        void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            openFile();
            grpBoxWatemarkText.Enabled = true;
            grpBoxOutSet.Enabled = true;
            grpBoxWPosition.Enabled = true;
            chkHideMessage.Enabled = true;
            btApplyWatermark.Enabled = true;
        }

        void openFile()
        {
            if (tabControl2.SelectedTab == tabPage3)
            {
                openFileDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
                openFileDlg.Multiselect = Enabled;
                openFileDlg.InitialDirectory = @"D:\Wallpapers";

                if (openFileDlg.ShowDialog() == DialogResult.OK)
                {
                    if (tabControl1.SelectedTab == tabPage1)
                    {
                        //listViewImages.Items.Add(openFileDlg.FileNames.ToString());
                        string[] files = openFileDlg.FileNames;
                        for (int i = 0; i < files.Length; i++)
                        {
                            listViewImages.Items.Add(files[i]);
                            CurrentFile = files[i];
                        }
                    }
                    else if (tabControl1.SelectedTab == tabPage2)
                    {
                        //listViewImages2.Items.Add(openFileDlg.FileName.ToString());
                        string[] files = openFileDlg.FileNames;
                        for (int i = 0; i < files.Length; i++)
                        {
                            listViewImages2.Items.Add(files[i]);
                            CurrentFile = files[i];
                        }
                    }
                }
            }
            else if (tabControl2.SelectedTab == tabPage4)
            {
                openFileDlg.Filter = "MPEG Files|*.mpg|MPG Files|*.mpg|AVI Files|*.avi";
                openFileDlg.InitialDirectory = @"D:\Songs\Angrezi\Misc Videos";

                if (openFileDlg.ShowDialog() == DialogResult.OK)
                {
                    if (tabControl3.SelectedTab == tabPage5)
                    {
                        txtVFile.Text = openFileDlg.FileName.ToString();
                        //fg = new FrameGrabber(txtVFile.Text);
                        pathFILE = txtVFile.Text;
                    }
                }
            }
        }
        #endregion

        #region ListView box
        void ListViewImagesSelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewImages.SelectedItems.Count == 1)
            {
                img = Image.FromFile(listViewImages.FocusedItem.Text);
                picBoxImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                picBoxImagePreview.ImageLocation = listViewImages.FocusedItem.Text;
                CurrentFile = listViewImages.FocusedItem.Text;
                grpBoxWatemarkText.Enabled = true;
                grpBoxOutSet.Enabled = true;
                grpBoxWPosition.Enabled = true;
                this.Text = "Watermark Utility: " + CurrentFile;      
            }
        }

        void ChBoxOutCheckedChanged(object sender, EventArgs e)
        {
            if (chBoxOut.Checked == false)
            {
                chBoxOut.Text = "Use following folder and keep same file name(s)";  
                lblSuffix.Enabled = false;
                lblAfter.Enabled = false;
                txtBoxSuffix.Enabled = false;
                lblOutFolder.Enabled = true;
                txtBoxOutFolder.Enabled = true;
                btBrowse.Enabled = true;
            }
            else if (chBoxOut.Checked == true)
            {
                chBoxOut.Text = "Use the previous location as Output Folder";
                lblSuffix.Enabled = true;
                lblAfter.Enabled = true;
                txtBoxSuffix.Enabled = true;
                lblOutFolder.Enabled = false;
                txtBoxOutFolder.Enabled = false;
                btBrowse.Enabled = false;
            }
        }//checkBox in output settings Group Box

        void ListViewImages2SelectedIndexChanged(object sender, EventArgs e)
        {
            picBoxImagePreview2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picBoxImagePreview2.ImageLocation = listViewImages2.FocusedItem.Text;
        }
        #endregion

        #region label Save
        void Label2Click(object sender, EventArgs e)
        {
            //txtBoxText.Text="ok";
            //textBox2.Text = CurrentFolder;
            //progressBar2.MaxValue = listViewImages.CheckedItems.Count;
            lblStatus.Text = "Saving...";
            progressBar1.Maximum = listViewImages.CheckedItems.Count;
            //textBox2.Text = listViewImages.CheckedItems.Count.ToString();
            if (chBoxOut.Checked == false && txtBoxOutFolder.Text.Equals(CurrentFolder))
            {
                MessageBox.Show("Output folder can not be same as input folder", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string srcPic, dstPic;
                //progressIndicator2.Start();
                for (int i = 0; i < listViewImages.Items.Count; i++)
                {
                    if (listViewImages.Items[i].Checked == true)
                    {
                        srcPic = listViewImages.Items[i].Text;
                        //fileinProcess.Text = listViewImages.Items[i].Text;
                        CurrentFile = srcPic;
                        preview();
                        if (chBoxOut.Checked == true)
                            dstPic = srcPic.Insert(srcPic.LastIndexOf("."), txtBoxSuffix.Text);
                        else
                            dstPic = txtBoxOutFolder.Text + "\\" + srcPic.Substring(srcPic.LastIndexOf("\\") + 1);
                        picBoxImagePreview.Image.Save(dstPic);
                        //progressBar1.Increment(1);
                        //lblStatus.Text = "";

                        progressBar1.Visible = true;
                        progressBar1.Value++;
                        //progressBar2.Value+=1;
                        //textBox2.Text = progressBar1.Value.ToString();
                    }
                }
                //progressBar2.Value = 0;
                //progressIndicator2.Stop();
                lblStatus.Text = "Ready";
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                //progressBar1.Visible = false;
            }
        }
        #endregion

        #region Buttons
        void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            AboutForm AbtFrm = new AboutForm();
            AbtFrm.Show();
        }//About Form

        private void btMarkallExtract_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewImages2.Items)
            {
                item.Checked = true;
            }
        }//Mark All Extract Button

        private void btUnmarkallExtract_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewImages2.Items)
            {
                item.Checked = false;
            }
        }//Unmark all Extract Button

        void Button1Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewImages.Items)
            {
                item.Checked = true;
            }
        }//Mark all Button

        void BtUnMarkClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewImages.Items)
            {
                item.Checked = false;
            }
        }//Unmark all Button

        void ToolStripBtDeleteClick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                foreach (ListViewItem item in listViewImages.Items)
                {
                    if (item.Checked == true)
                    {
                        item.Remove();
                    }
                }
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                foreach (ListViewItem item in listViewImages2.Items)
                {
                    if (item.Checked == true)
                    {
                        item.Remove();
                    }
                }
            }
            CurrentFile = null;
            picBoxImagePreview.ImageLocation = null;
        }//Delete Button on ToolStrip

        void BtSetColorClick(object sender, EventArgs e)
        {
            ColorDialog CDialog = new ColorDialog();
            if (CDialog.ShowDialog() != DialogResult.Cancel)
            {
                txtBoxText.ForeColor = CDialog.Color;
                myWatermarkColor = CDialog.Color;
            }
        }//color button

        void ToolStripButton1Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //Exit Button on Toolstrip

        #endregion

        #region SetFont Button
        void BtSetFontClick(object sender, EventArgs e)
        {
            FontDialog FDialog = new FontDialog();
            if (FDialog.ShowDialog() != DialogResult.Cancel)
            {
                txtBoxText.Font = FDialog.Font;
                myFont = FDialog.Font;
            }
        }

        void ToolStripBtFontClick(object sender, EventArgs e)
        {
            FontDialog FDialog = new FontDialog();
            if (FDialog.ShowDialog() != DialogResult.Cancel)
            {
                txtBoxText.Font = FDialog.Font;
                myFont = FDialog.Font;
            }
        }
        #endregion

        #region SelectFolder
        void ToolStripBtOpenFolderClick(object sender, EventArgs e)
        {
            selectFolder();
            grpBoxWatemarkText.Enabled = true;
            grpBoxOutSet.Enabled = true;
            grpBoxWPosition.Enabled = true;
            chkHideMessage.Enabled = true;
            btApplyWatermark.Enabled = true;
        }

        void SelectFolderToolStripMenuItemClick(object sender, EventArgs e)
        {
                selectFolder();
                grpBoxWatemarkText.Enabled = true;
                grpBoxOutSet.Enabled = true;
                grpBoxWPosition.Enabled = true;
                chkHideMessage.Enabled = true;
                btApplyWatermark.Enabled = true;
            
        }
        void selectFolder()
        {
            if (tabControl2.SelectedTab == tabPage3)
            {
                fbDlg.ShowNewFolderButton = false;
                fbDlg.SelectedPath = @"D:\Wallpapers\Cars from Games";
                //fbDlg.ShowDialog();

                if (fbDlg.ShowDialog() != DialogResult.Cancel)
                {
                    if (tabControl1.SelectedTab == tabPage1)
                    {
                        DirectoryInfo dir = new DirectoryInfo(fbDlg.SelectedPath.ToString());
                        CurrentFolder = dir.ToString();
                        FileInfo[] files = dir.GetFiles();

                        //MessageBox.Show(files[1].Extension.ToString());
                        foreach (FileInfo file in files)
                        {
                            if (Equals(".jpg", file.Extension.ToLower()) || Equals(".bmp", file.Extension.ToLower()) || Equals(".gif", file.Extension.ToLower()) || Equals(".png", file.Extension.ToLower()) || Equals(".jpeg", file.Extension.ToLower()))
                                listViewImages.Items.Add(fbDlg.SelectedPath.ToString() + "\\" + file.Name);
                        }
                    }
                    else if (tabControl1.SelectedTab == tabPage2)
                    {
                        DirectoryInfo dir = new DirectoryInfo(fbDlg.SelectedPath.ToString());
                        FileInfo[] files = dir.GetFiles();

                        foreach (FileInfo file in files)
                            listViewImages2.Items.Add(fbDlg.SelectedPath.ToString() + "\\" + file.Name);
                    }
                }
            }
            else if (tabControl2.SelectedTab == tabPage4)
            {
                MessageBox.Show("Selection of Folder:Not Allowed");
            }
        }
        #endregion

        #region Preview Function

        void BtApplyWatermarkClick(object sender, EventArgs e)
        {
            preview();
        }

        private void preview()
        {
            // Update the applicaton by reloading the image
            if (CurrentFile == null)
            {
                MessageBox.Show("No Image Selected", "Select Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                picBoxImagePreview.Image = Image.FromFile(CurrentFile);
                // Get a graphics context
                Graphics g = Graphics.FromImage(picBoxImagePreview.Image);
                // Create a solid brush to write the watermark text on the image
                Brush myBrush = new SolidBrush(Color.FromArgb(Opac, myWatermarkColor));
                // Calculate the size of the text
                SizeF sz = g.MeasureString(txtBoxText.Text, myFont);
                // Creae a copy of variables to keep track of the drawing position (X,Y)
                g.DrawString(txtBoxText.Text, myFont, myBrush, new Point(X, Y));
            }
        }
        #endregion

        #region saveFile
        void ToolStripBtSaveClick(object sender, EventArgs e)
        {
            svDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
            svDlg.Title = "Save an Image File";
            //svDlg.ShowDialog();
            saveFile();
        }

        void saveFile()
        {
            try
            {
                //get the extension to figure out how to limit the save
                //option to current image file type
                string strExt;
                //SaveFileDialog svDlg = new SaveFileDialog();
                strExt = System.IO.Path.GetExtension(CurrentFile);
                strExt = strExt.ToUpper();
                strExt = strExt.ToLower();

                //if the current image is, for example, a gif, only
                //allow the user to save the file with watermark
                //as a gif
                svDlg.Title = "Save File";
                svDlg.DefaultExt = strExt;
                svDlg.Filter = strExt + " Image Files|" + strExt;
                svDlg.FilterIndex = 1;

                if (svDlg.ShowDialog() == DialogResult.OK)
                {
                    if (svDlg.FileName == "")
                    {
                        return;
                    }
                    else
                    {
                        //save the current image file to point to the newly
                        picBoxImagePreview.Image.Save(svDlg.FileName);
                    }
                    //update the current image file to point to the newly
                    //saved image
                    CurrentFile = svDlg.FileName;
                    this.Text = "Watermark Utility: " + CurrentFile;
                    MessageBox.Show(CurrentFile.ToString() + " saved.", "File Save");
                }
                else
                {
                    MessageBox.Show("The save file request was cancelled by user.", "Save Cancelled");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Image Save Error");
            }
        }
        #endregion

        #region set Opacity Value

        void TxtBoxOpacityTextChanged(object sender, EventArgs e)
        {
            int opValue = 100;
            if (txtBoxOpacity.Text == "")
            {
                trackBarOpacity.Value = 0;
                txtBoxOpacity.Text = "0";
            }
            else
            {
                opValue = Convert.ToInt32(txtBoxOpacity.Text);
                if (opValue > 255)
                {
                    MessageBox.Show("Value Too Large. Specified Value should be in the Range: 0 - 255.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxOpacity.Text = txtBoxOpacity.Text.Substring(0, 2);
                    opValue = Convert.ToInt32(txtBoxOpacity.Text);
                }
                trackBarOpacity.Value = opValue;
            }
            Opac = opValue;
        }

        void TrackBarOpacityScroll(object sender, EventArgs e)
        {
            txtBoxOpacity.Text = trackBarOpacity.Value.ToString();
            //preview();
        }
        #endregion

        #region Webpage Link
        void ToolStripBtHomePageClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Utilities\C#\Webpages\index.html");
        }
        #endregion

        #region Edit Externally
        private void editExternallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\mspaint.exe", CurrentFile);
        }
        #endregion

        #region Hide Message Button-Image
        private void button7_Click(object sender, EventArgs e)//Hide Message Button
        {
            Bitmap bitmap = (Bitmap)picBoxImagePreview.Image;

            //get a stream for the message to hide
            Stream messageStream = GetMessageStream();
            if (messageStream.Length == 0)
            {
                MessageBox.Show("Please enter a message or select a file.");
                txtBoxText.Focus();
            }
            else
            {
                //get a stream for the key
                Stream keyStream = GetKeyStream();
                if (keyStream.Length == 0)
                {
                    MessageBox.Show("Please enter a password or select a key file.");
                    txtKeyText.Focus();
                }
                else
                {

                    try
                    {
                        //hide the message
                        CryptUtility.HideMessageInBitmap(messageStream, bitmap, keyStream, chkGrayscale.Checked);
                        //display result
                        picBoxImagePreview.Image = bitmap;
                        btnSaveBitmap.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception:\r\n" + ex.Message);
                    }
                }
                keyStream.Close();
            }
            messageStream.Close();
            bitmap = null;
        }
        #endregion

        #region GetMessageStream-Image
        /// <summary>Creates a stream to read the message from a string or a file</summary>
        /// <returns>FileStream for a message file, or MemoryStream</returns>
        private Stream GetMessageStream()
        {
            Stream messageStream;
            //if (rdoMessageText.Checked)
            //{
            byte[] messageBytes = UnicodeEncoding.Unicode.GetBytes(txtBoxText.Text);
            messageStream = new MemoryStream(messageBytes);
            //}
            /* else
             {
                 messageStream = new FileStream(txtMessageFile.Text, FileMode.Open, FileAccess.Read);
             }*/
            return messageStream;
        }
        #endregion

        #region GetKeyStream-Image
        /// <summary>Creates a stream to read the key from a string or a file</summary>
        /// <returns>FileStream for a key file, or MemoryStream for a password</returns>
        private Stream GetKeyStream()
        {
            Stream keyStream;
            if (rdoKeyText.Checked)
            {
                byte[] keyBytes = UnicodeEncoding.Unicode.GetBytes(txtKeyText.Text);
                keyStream = new MemoryStream(keyBytes);
            }
            else
            {
                keyStream = new FileStream(txtKeyFile.Text, FileMode.Open, FileAccess.Read);
            }
            return keyStream;
        }
        #endregion

        #region Extract Button(Hiding)-Image
        private void button5_Click(object sender, EventArgs e)//Extract Button
        {
            Bitmap bitmap = (Bitmap)picBoxImagePreview2.Image;

            //empty stream for the extracted message
            Stream messageStream = new MemoryStream();

            //get a stream for the key
            Stream keyStream = GetKeyStream2();
            if (keyStream.Length == 0)
            {
                MessageBox.Show("Please enter a password or select a key file.");
                txtKeyText.Focus();
            }
            else
            {

                try
                {
                    //extract the hidden message from the bitmap
                    CryptUtility.ExtractMessageFromBitmap(bitmap, keyStream, ref messageStream);

                    //save the message, if a filename is available
                    if (txtExtractedMsgFile.Text.Length > 0)
                    {
                        messageStream.Seek(0, SeekOrigin.Begin);
                        FileStream fs = new FileStream(txtExtractedMsgFile.Text, FileMode.Create);
                        byte[] streamContent = new Byte[messageStream.Length];
                        messageStream.Read(streamContent, 0, streamContent.Length);
                        fs.Write(streamContent, 0, streamContent.Length);
                    }

                    //display the message - displays chaos, if it's no unicode text
                    messageStream.Seek(0, SeekOrigin.Begin);
                    StreamReader reader = new StreamReader(messageStream, UnicodeEncoding.Unicode);
                    String readerContent = reader.ReadToEnd();
                    if (readerContent.Length > txtExtractedMsgText.MaxLength)
                    {
                        readerContent = readerContent.Substring(0, txtExtractedMsgText.MaxLength);
                    }
                    txtExtractedMsgText.Text = readerContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception:\r\n" + ex.Message);
                }
            }
            //close the streams
            messageStream.Close();
            keyStream.Close();
            bitmap = null;
        }
        #endregion

        #region GetKeyStream2-Extracting
        private Stream GetKeyStream2()
        {
            Stream keyStream;
            if (rdoKey2Text.Checked)
            {
                byte[] keyBytes = UnicodeEncoding.Unicode.GetBytes(txtKey2Text.Text);
                keyStream = new MemoryStream(keyBytes);
            }
            else
            {
                keyStream = new FileStream(txtKey2File.Text, FileMode.Open, FileAccess.Read);
            }
            return keyStream;
        }
        #endregion

        #region Save Button(hiding)
        private void btnSaveBitmap_Click(object sender, EventArgs e)//Save Button (Hiding)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Bitmaps (*.bmp)|*.bmp|Tagged Image File Format(*.tif)|*.tif|PNG-24(*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Bmp;

                if (dlg.FilterIndex == 1)
                {
                    format = System.Drawing.Imaging.ImageFormat.Tiff;
                }
                else if (dlg.FilterIndex == 2)
                {
                    format = System.Drawing.Imaging.ImageFormat.Png;
                }

                //copy the bitmap
                Image img = new Bitmap(picBoxImagePreview.Image);

                //close bitmap file
                this.SuspendLayout();
                picBoxImagePreview.Image.Dispose();
                picBoxImagePreview.Image = null;
                //btnSaveBitmap.Enabled = btnHide.Enabled = btnExtract.Enabled = false;
                //txtImageFile.Text = String.Empty;
                this.ResumeLayout();

                //save new bitmap
                img.Save(dlg.FileName, format);
            }
        }
        #endregion

        #region chkHideMessage
        private void checkBox1_CheckedChanged(object sender, EventArgs e)//CheckBox HideMessage
        {
            if (chkHideMessage.Checked == true)
            {
                btSetColor.Enabled = false;
                btSetFont.Enabled = false;
                trackBarOpacity.Enabled = false;
                lblOpacity.Enabled = false;
                txtBoxOpacity.Enabled = false;
                grpBoxOutSet.Enabled = false;
                grpBoxWPosition.Enabled = false;
                btApplyWatermark.Enabled = false;
                grpBoxKey.Enabled = true;
                chkGrayscale.Enabled = true;
            }
            else if (chkHideMessage.Checked == false)
            {
                grpBoxKey.Enabled = false;
                chkGrayscale.Enabled = false;
                btSetColor.Enabled = true;
                btSetFont.Enabled = true;
                trackBarOpacity.Enabled = true;
                lblOpacity.Enabled = true;
                txtBoxOpacity.Enabled = true;
                grpBoxOutSet.Enabled = true;
                grpBoxWPosition.Enabled = true;
                btApplyWatermark.Enabled = true;
            }

        }
        #endregion

        #region radiobuttons
        private void rdoKeyText_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoKeyText.Checked == true)
            {
                btBrowse2.Enabled = false;
                txtKeyFile.Enabled = false;
                txtKeyText.Enabled = true;
            }
        }

        private void rdoFilename_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFilename.Checked == true)
            {
                txtKeyText.Enabled = false;
                btBrowse2.Enabled = true;
                txtKeyFile.Enabled = true;
            }
        }
        #endregion

        #region FrameGrabbing-Video

        private void button42_Click(object sender, EventArgs e)//Browse Button for Videofile-Bitmap
        {
            try
            {
                fbDlg.ShowNewFolderButton = true;
                if (fbDlg.ShowDialog() == DialogResult.OK)
                {
                    txtExtBitmap.Text = fbDlg.SelectedPath;
                }
            }
            catch { }
        }
      
        private void button43_Click(object sender, EventArgs e)//Extract Button
        {
            if (txtExtBitmap.Text == "")
            {
                MessageBox.Show("Specify the Output Folder");
                return;
            }
            else
            {
                string outPath = txtExtBitmap.Text;
                System.IO.Directory.CreateDirectory(outPath);

                try
                {
                    string[] A = { pathFILE, outPath };
                    backgroundWorker1.WorkerReportsProgress = true;
                    backgroundWorker1.WorkerSupportsCancellation = true;
                    backgroundWorker1.RunWorkerAsync(A);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("{Error: " + ex.ToString());
                }
            }
         }

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
		}
 
        private void button44_Click(object sender, EventArgs e)//Stop Button
        {
            backgroundWorker1.CancelAsync();
            lblCnt.Visible = true;

            lblCnt.Text = count.ToString()+" ( "+rate.ToString()+" fps"+" )";
        }

       private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //lets get back our paths
            string[] S = (string[])e.Argument;

            // the source video path

            string sourcePATH = S[0];

            // the path to write the file to

            string destPATH = S[1];

            //keep track of out background worker

            BackgroundWorker bwAsync = sender as BackgroundWorker;

            //now lets initiate an instance of the class that proccesses the video.

            FrameGrabber fg = new FrameGrabber(sourcePATH);
            rate=(float)fg.FrameRate;
            Image PREVIEW;

            if (fg != null)
            {
                foreach (FrameGrabber.Frame f in fg)
                {
                    using (f)
                    {
                        PREVIEW = (Bitmap)f.Image.Clone();
                        f.Image.Save(System.IO.Path.Combine(destPATH, "frame" + f.FrameIndex + ".bmp"), System.Drawing.Imaging.ImageFormat.Bmp);
                        count++;
                        Application.DoEvents();
                        int IProgressPercentage = fg.FrameCount / fg.FrameCount; //doesn't report which frame its on, so couldn't proccess this, could have edited the library to do so, but that's outside the scope of this example.
                        backgroundWorker1.ReportProgress(IProgressPercentage, PREVIEW);
                        //check if we have been canceled
                        if (bwAsync.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }

                    if (fg == null)
                    {
                        return;
                    }
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
             if (e.Error == null)
             {
                if (e.Cancelled == true)
                {
                    MessageBox.Show("Canceled");
                    return;
                }
                else
                {
                    MessageBox.Show("Finished");
                }
             }
             else
             {
                MessageBox.Show("ERROR " + e.Error.ToString());
             }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            picBoxFrame.Image = (Image)e.UserState;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int i = 150;
            axWindowsMediaPlayer1.URL = txtVFile.Text;
            FrameGrabber fgPreview = new FrameGrabber(txtVFile.Text);
            FrameGrabber.Frame fr = fgPreview.GetFrame(i);
            if (fgPreview != null)
            {
                using (fr)
                {
                    picBoxPreview3.Image = (Bitmap)fr.Image.Clone();
                    //f.Image.Save(System.IO.Path.Combine(outPath, "frame" + f.FrameIndex + ".bmp"), System.Drawing.Imaging.ImageFormat.Bmp);
                    Application.DoEvents();
                }
                if (fgPreview == null)
                {
                    return;
                }
            }
        }

        private void button40_Click(object sender, EventArgs e)//Applywatermark Button
        {
            openFileDlg.Filter = "Bitmap Image|*.bmp";
            openFileDlg.Multiselect = Enabled;
            //string filePath;
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                string[] files = openFileDlg.FileNames;
                Bitmap bmp = (Bitmap)Image.FromFile(files[0]);
                /*try
                {
                    fbDlg.ShowNewFolderButton = true;
                    if (fbDlg.ShowDialog() == DialogResult.OK)
                    {
                        filePath=fbDlg.SelectedPath;
                    }
                }
                catch { }
                //textBox6.Text = filePath;*/
                AviManager aviManager = new AviManager(@"C:\Documents and Settings\Payam Rastogi\Desktop\Wallpapers\new.avi", false);
                //AviManager aviManager = new AviManager(filePath.ToString(), false);
                VideoStream aviStream = aviManager.AddVideoStream(false, 25.00, bmp);

                Bitmap bitmap;
                //int count = 1;
                for (int i = 1; i < files.Length; i++)
                {

                    bitmap = (Bitmap)Bitmap.FromFile(files[i]);
                    aviStream.AddFrame(bitmap);
                    bitmap.Dispose();
                    count++;
                }
                aviManager.Close();
            }
        }
        #endregion

        #region Watermark Position Buttons & Functions


        private void btTopLeft_Click_1(object sender, EventArgs e)
        {
            X = 20;
            Y = 20;
            funcBtnStateChange(btTopLeft);
        }

        private void btTopCenter_Click_1(object sender, EventArgs e)
        {
            X = (int)(picBoxImagePreview.Width - funcSizeofString().Width) / 2;
            Y = 20;
            funcBtnStateChange(btTopCenter);
        }

        private void btTopRight_Click_1(object sender, EventArgs e)
        {
            X = (int)(picBoxImagePreview.Width - funcSizeofString().Width) + 20;
            Y = 20;
            funcBtnStateChange(btTopRight);
        }

        private void btMiddleLeft_Click_1(object sender, EventArgs e)
        {
            X = 20;
            Y = (int)(picBoxImagePreview.Image.Height - funcSizeofString().Height) / 2;
            funcBtnStateChange(btMiddleLeft);
        }

        private void btCenter_Click_1(object sender, EventArgs e)
        {
            X = (int)(picBoxImagePreview.Width - funcSizeofString().Width) / 2;
            Y = (int)(picBoxImagePreview.Image.Height - funcSizeofString().Height) / 2;
            funcBtnStateChange(btCenter);
        }

        private void btMiddleRight_Click_1(object sender, EventArgs e)
        {
            X = (int)(picBoxImagePreview.Width - funcSizeofString().Width) + 20;
            Y = (int)(picBoxImagePreview.Image.Height - funcSizeofString().Height) / 2;
            funcBtnStateChange(btMiddleRight);
        }

        private void btBottomLeft_Click_1(object sender, EventArgs e)
        {
            X = 20;
            Y = (int)(picBoxImagePreview.Image.Height - funcSizeofString().Height);
            funcBtnStateChange(btBottomLeft);
        }

        private void btBottomCenter_Click_1(object sender, EventArgs e)
        {
            X = (int)(picBoxImagePreview.Width - funcSizeofString().Width) / 2;
            Y = (int)(picBoxImagePreview.Image.Height - funcSizeofString().Height);
            funcBtnStateChange(btBottomCenter);
        }

        private void btBottomRight_Click_1(object sender, EventArgs e)
        {
            X = (int)(picBoxImagePreview.Width - funcSizeofString().Width) + 20;
            Y = (int)(picBoxImagePreview.Image.Height - funcSizeofString().Height);
            funcBtnStateChange(btBottomRight);
        }

        private SizeF funcSizeofString()
        {
            Graphics g = Graphics.FromImage(picBoxImagePreview.Image);
            SizeF sz = g.MeasureString(txtBoxText.Text, myFont);
            return sz;
        }

        private void funcBtnStateChange(Button p)
        {
            prevButton.FlatStyle = FlatStyle.Standard;
            prevButton = p;
            prevButton.FlatStyle = FlatStyle.Flat;
            preview();
        }
        #endregion           
       
        #region Unused

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtKeyText_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtBoxOutFolder_TextChanged(object sender, EventArgs e)
        {

        }

        void PictureBox1Click(object sender, EventArgs e)
        {

        }

        void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        void Label1Click(object sender, EventArgs e)
        {

        }

        void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void RadioButton2CheckedChanged(object sender, EventArgs e)
        {

        }

        void TextBox2TextChanged(object sender, EventArgs e)
        {

        }

        void Label5Click(object sender, EventArgs e)
        {

        }

        void TxtBoxTextTextChanged(object sender, EventArgs e)
        {

        }

        void PicBoxImagePreviewClick(object sender, EventArgs e)
        {

        }

        void CheckBox1CheckedChanged(object sender, EventArgs e)
        {

        }

        void BtPreviewClick(object sender, EventArgs e)
        {

        }

        void GrpBoxImagePreviewEnter(object sender, EventArgs e)
        {

        }



        void ChBoxAdvancedCheckedChanged(object sender, EventArgs e)
        {

        }

        void ToolStripBtZoomInClick(object sender, EventArgs e)
        {

        }

        private void progressBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)//Show General Information Button
        {
            /*AviManager aviManager = new AviManager(txtVFile.Text, true);
            VideoStream stream = aviManager.GetVideoStream();
            lblWidth.Text =  stream.Width.ToString();
            lblHeight.Text = stream.Height.ToString();
            lblFrames.Text = stream.CountFrames.ToString();
            lblRate.Text =  stream.FrameRate.ToString();

            //txtReportRead.Text += "\r\nWave Sound:";

            /*try
            {
                AudioStream waveStream = aviManager.GetWaveStream();
                txtReportRead.Text += "\r\nSamples per Second: " + waveStream.CountSamplesPerSecond.ToString();
                txtReportRead.Text += "\r\nBits per Sample: " + waveStream.CountBitsPerSample.ToString();
                txtReportRead.Text += "\r\nChannels: " + waveStream.CountChannels.ToString();
            }
            catch
            {
                txtReportRead.Text += " None";
            }*/
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion           

        private void btVFont_Click(object sender, EventArgs e)
        {
            FontDialog FDialog = new FontDialog();
            if (FDialog.ShowDialog() != DialogResult.Cancel)
            {
                txtVWatermark.Font = FDialog.Font;
                myVFont = FDialog.Font;
            }
        }

        private void btVColor_Click(object sender, EventArgs e)
        {
            ColorDialog CDialog = new ColorDialog();
            if (CDialog.ShowDialog() != DialogResult.Cancel)
            {
                txtVWatermark.ForeColor = CDialog.Color;
                myVWatermarkColor = CDialog.Color;
            }
        }

        private void btVTopLeft_Click(object sender, EventArgs e)
        {
            VX = 20;
            VY = 20;
            vfuncBtnStateChange(btVTopLeft);
        }

        private void btvTopMiddle_Click(object sender, EventArgs e)
        {
            VX = (int)(picBoxPreview3.Width - VFuncSizeofString().Width) / 2;
            VY = 20;
            vfuncBtnStateChange(btvTopMiddle);
        }

        private void btvTopRight_Click(object sender, EventArgs e)
        {
            VX = (int)(picBoxPreview3.Width - VFuncSizeofString().Width) + 20;
            VY = 20;
            vfuncBtnStateChange(btvTopRight);
        }

        private void btvMiddleLeft_Click(object sender, EventArgs e)
        {
            VX = 20;
            VY = (int)(picBoxPreview3.Image.Height - VFuncSizeofString().Height) / 2;
            vfuncBtnStateChange(btvMiddleLeft);
        }

        private void btvCenter_Click(object sender, EventArgs e)
        {
            VX = (int)(picBoxPreview3.Width - VFuncSizeofString().Width) / 2;
            VY = (int)(picBoxPreview3.Image.Height - VFuncSizeofString().Height) / 2;
            vfuncBtnStateChange(btvCenter);
        }

        private void btvMiddleRight_Click(object sender, EventArgs e)
        {
            VX = (int)(picBoxPreview3.Width - VFuncSizeofString().Width) + 20;
            VY = (int)(picBoxPreview3.Image.Height - VFuncSizeofString().Height) / 2;
            vfuncBtnStateChange(btvMiddleRight);
        }

        private void btvBottomLeft_Click(object sender, EventArgs e)
        {
            VX = 20;
            VY = (int)(picBoxPreview3.Image.Height - VFuncSizeofString().Height);
            vfuncBtnStateChange(btvBottomLeft);
        }

        private void btvBottomMiddle_Click(object sender, EventArgs e)
        {
            VX = (int)(picBoxPreview3.Width - VFuncSizeofString().Width) / 2;
            VY = (int)(picBoxPreview3.Image.Height - VFuncSizeofString().Height);
            vfuncBtnStateChange(btvBottomMiddle);
        }

        private void btvBottomRight_Click(object sender, EventArgs e)
        {
            VX = (int)(picBoxPreview3.Width - VFuncSizeofString().Width) + 20;
            VY = (int)(picBoxPreview3.Image.Height - VFuncSizeofString().Height);
            vfuncBtnStateChange(btvBottomRight);
        }

        private SizeF VFuncSizeofString()
        {
            Graphics vg = Graphics.FromImage(picBoxPreview3.Image);
            SizeF vsz = vg.MeasureString(txtVWatermark.Text, myVFont);
            return vsz;
        }

        private void vfuncBtnStateChange(Button p)
        {
            vPrevButton.FlatStyle = FlatStyle.Standard;
            vPrevButton = p;
            vPrevButton.FlatStyle = FlatStyle.Flat;
            vpreview();
        }

        private void vpreview()
        {
            // Update the applicaton by reloading the image
            //if (CurrentFile == null)
            //{
            //  MessageBox.Show("No Image Selected", "Select Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //picBoxImagePreview.Image = Image.FromFile(CurrentFile);
            // Get a graphics context
            Graphics vg = Graphics.FromImage(picBoxPreview3.Image);
            // Create a solid brush to write the watermark text on the image
            Brush myVBrush = new SolidBrush(Color.FromArgb(VOpac, myVWatermarkColor));
            // Calculate the size of the text
            SizeF vsz = vg.MeasureString(txtVWatermark.Text, myVFont);
            // Creae a copy of variables to keep track of the drawing position (X,Y)
            vg.DrawString(txtVWatermark.Text, myVFont, myVBrush, new Point(VX, VY));
            Application.DoEvents();
        }

        private void trackBarVOpacity_Scroll(object sender, EventArgs e)
        {
            txtVOpacity.Text = trackBarVOpacity.Value.ToString();
        }

        private void txtVOpacity_TextChanged(object sender, EventArgs e)
        {
            int vopValue = 100;
            if (txtVOpacity.Text == "")
            {
                trackBarVOpacity.Value = 0;
                txtVOpacity.Text = "0";
            }
            else
            {
                vopValue = Convert.ToInt32(txtVOpacity.Text);
                if (vopValue > 255)
                {
                    MessageBox.Show("Value Too Large. Specified Value should be in the Range: 0 - 255.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVOpacity.Text = txtVOpacity.Text.Substring(0, 2);
                    vopValue = Convert.ToInt32(txtVOpacity.Text);
                }
                trackBarVOpacity.Value = vopValue;
            }
            VOpac = vopValue;
        }
        private void btBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                fbDlg.ShowNewFolderButton = true;
                if (fbDlg.ShowDialog() == DialogResult.OK)
                {
                    txtBoxOutFolder.Text = fbDlg.SelectedPath;
                }
            }
            catch { }
        }

        private void toolStripBtSetting_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\mspaint.exe", CurrentFile);
        }

        private void toolStripBtContactUs_Click(object sender, EventArgs e)
        {

        }
    }
}
