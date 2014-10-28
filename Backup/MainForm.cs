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
//using SHDocVw;
using System.Runtime.InteropServices;

namespace Watermarking
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
	#region Member Variables
        string CurrentFile;
        /*Image img;
        ImageCodecInfo myImageCodecInfo;
        System.Drawing.Imaging.Encoder myEncoder;
        EncoderParameter myEncoderParameter;
        EncoderParameters myEncoderParameters;*/
        System.Drawing.Color myWatermarkColor;
        System.Drawing.Font myFont;
        int Opac=0;
    #endregion
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			// setup default settings
			myWatermarkColor = Color.SteelBlue;
			txtBoxText.Text = "Watermark " +
			char.ConvertFromUtf32(169).ToString() + " " +
			DateTime.Now.Year.ToString() + ", All Rights Reserved";
			myFont = txtBoxText.Font;

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		OpenFileDialog openFileDlg = new OpenFileDialog();
		FolderBrowserDialog fbDlg = new FolderBrowserDialog();
		SaveFileDialog svDlg = new SaveFileDialog();
		
		/*private void ShowScrollBars()
		{
			vScrollBar1.Visible=true;
			hScrollBar1.Visible=true;
			/*if(picBoxImagePreview.Height>picBoxImagePreview.Image.Height)
			{
				vScrollBar1.Visible=false;
			}
			if(picBoxImagePreview.Width>picBoxImagePreview.Image.Width)
			{
				hScrollBar1.Visible = false;
			}
		}*/
		void MainFormLoad(object sender, EventArgs e)
		{
			lblDate.Text=DateTime.Now.ToShortDateString()+"||"+DateTime.Now.ToLongTimeString();
		}
		void Timer1Tick(object sender, System.EventArgs e)
		{
			lblDate.Text=DateTime.Now.ToShortDateString()+"||"+DateTime.Now.ToLongTimeString();
		}
		void PictureBox1Click(object sender, EventArgs e)
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
		
		void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			openFile();
		}
		
		void BtSetColorClick(object sender, EventArgs e)
		{
			ColorDialog CDialog = new ColorDialog();
			if(CDialog.ShowDialog()!= DialogResult.Cancel)

				txtBoxText.ForeColor=CDialog.Color;
				myWatermarkColor = CDialog.Color;
		}
		
		void BtSetFontClick(object sender, EventArgs e)
		{
			FontDialog FDialog = new FontDialog();
			if(FDialog.ShowDialog()!= DialogResult.Cancel)
			txtBoxText.Font = FDialog.Font;
			myFont = FDialog.Font;
		}
		
		void TxtBoxTextTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void ListViewImagesSelectedIndexChanged(object sender, EventArgs e)
		{
			
			if(listViewImages.SelectedItems.Count==1)
			{
				picBoxImagePreview.SizeMode =  System.Windows.Forms.PictureBoxSizeMode.StretchImage;
				picBoxImagePreview.ImageLocation=listViewImages.FocusedItem.Text;
			}
			else
			{
				
			}
				//if(openFileDlg.ShowDialog != DialogResult.Cancel)	
				//picBoxImagePreview.SizeMode =  System.Windows.Forms.PictureBoxSizeMode.AutoSize;
				//picBoxImagePreview.SizeMode =  System.Windows.Forms.PictureBoxSizeMode.CenterImage;
				//hScrollBar1.Maximum = picBoxImagePreview.Image.Width - picBoxImagePreview.Width;
				//vScrollBar1.Maximum = picBoxImagePreview.Image.Height -	picBoxImagePreview.Height;
				//ShowScrollBars();
				//picBoxImagePreview.ImageLocation=listViewImages.FocusedItem.Text;
				
			
		}
		
		void PicBoxImagePreviewClick(object sender, EventArgs e)
		{
			
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void ToolStripBtOpenFileClick(object sender, EventArgs e)
		{
			openFile();
		}
		
		void SelectFolderToolStripMenuItemClick(object sender, EventArgs e)
		{
			selectFolder();
		}
		
		void BtPreviewClick(object sender, EventArgs e)
		{
			
		}
		
		void ChBoxAdvancedCheckedChanged(object sender, EventArgs e)
		{
			/*if(chBoxAdvanced.Checked==true)
			{
				groupBox4.Enabled=false;
				cmbBoxPosition.Enabled=true;
			}
			else if(chBoxAdvanced.Checked==false)
			{
				groupBox4.Enabled=true;
				cmbBoxPosition.Enabled=false;
			}*/
		}
		
		void ChBoxOutCheckedChanged(object sender, EventArgs e)
		{
			if(chBoxOut.Checked==false)
			{
				lblSuffix.Enabled=false;
				lblAfter.Enabled=false;
				txtBoxSuffix.Enabled=false;
				lblOutFolder.Enabled=true;
				txtBoxOutFolder.Enabled=true;
				btBrowse.Enabled=true;
			}
			else if(chBoxOut.Checked==true)
			{
				lblSuffix.Enabled=true;
				lblAfter.Enabled=true;
				txtBoxSuffix.Enabled=true;
				lblOutFolder.Enabled=false;
				txtBoxOutFolder.Enabled=false;
				btBrowse.Enabled=false;
			}
		}
		
		void ToolStripBtOpenFolderClick(object sender, EventArgs e)
		{
			selectFolder();
		}
		
		void GrpBoxImagePreviewEnter(object sender, EventArgs e)
		{
			
		}
		
		void ToolStripBtSaveClick(object sender, EventArgs e)
		{
			svDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
			svDlg.Title="Save an Image File";
			//svDlg.ShowDialog();
			saveFile();
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			//txtBoxText.Text="ok";
		}
		
		void ListViewImages2SelectedIndexChanged(object sender, EventArgs e)
		{
				picBoxImagePreview2.SizeMode =  System.Windows.Forms.PictureBoxSizeMode.StretchImage;
				picBoxImagePreview2.ImageLocation=listViewImages2.FocusedItem.Text;
		}
		
		void ToolStripBtZoomInClick(object sender, EventArgs e)
		{
			
		}
		
		void BtApplyWatermarkClick(object sender, EventArgs e)
		{
			preview();
			/*this.lblMark = new Label();
			lblMark.AutoSize;
			lblMark.Text = txtBoxText.Text;
			lblMark.Enable = true;
			lblMark.Visible = true;
			picBoxImagePreview.Container.Add(lblMark);*/
			
		}
		
		/*public void ScrollBars_Scroll(object sender, ScrollEventArgs se)
		{
			Graphics graphics = picBoxImagePreview.CreateGraphics();
			graphics.DrawImage(picBoxImagePreview.Image, new Rectangle(0,0,
			picBoxImagePreview.Width - hScrollBar1.Height, picBoxImagePreview.Height
			- vScrollBar1.Width),new Rectangle(hScrollBar1.Value,
			- vScrollBar1.Value, picBoxImagePreview.Width -
			- hScrollBar1.Height, picBoxImagePreview.Height -
			- vScrollBar1.Width), GraphicsUnit.Pixel);
		}*/
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e)
		{
			AboutForm AbtFrm = new AboutForm();
			AbtFrm.Show();
		}
		
		void ToolStripBtFontClick(object sender, EventArgs e)
		{
			FontDialog FDialog = new FontDialog();
			FDialog.ShowDialog();
			txtBoxText.Font = FDialog.Font;
			myFont = FDialog.Font;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			foreach(ListViewItem item in listViewImages.Items)
			{
				item.Checked=true;
			}
		}
		
		void BtUnMarkClick(object sender, EventArgs e)
		{
			foreach(ListViewItem item in listViewImages.Items)
			{
				item.Checked=false;
			}
		}
		
		void ToolStripBtDeleteClick(object sender, EventArgs e)
		{
			foreach(ListViewItem item in listViewImages.Items)
			{
				if(item.Checked==true)
				{
					item.Remove();
					picBoxImagePreview.ImageLocation = null;
				}
			}
		}
		
		void selectFolder()
		{
			fbDlg.ShowNewFolderButton = false;
			//fbDlg.ShowDialog();
			
			if(fbDlg.ShowDialog()!= DialogResult.Cancel)
			{
				if(tabControl1.SelectedTab==tabPage1)
				{
					DirectoryInfo dir = new DirectoryInfo(fbDlg.SelectedPath.ToString());
					FileInfo[] files = dir.GetFiles();

				//MessageBox.Show(files[1].Extension.ToString());
					foreach (FileInfo file in files)
					{
						if(Equals(".jpg",file.Extension.ToLower())||Equals(".bmp",file.Extension.ToLower())||Equals(".gif",file.Extension.ToLower())||Equals(".png",file.Extension.ToLower())||Equals(".jpeg",file.Extension.ToLower()))
						listViewImages.Items.Add(fbDlg.SelectedPath.ToString()+"\\"+file.Name);
					}
				}
				else if(tabControl1.SelectedTab==tabPage2)
				{
					DirectoryInfo dir = new DirectoryInfo(fbDlg.SelectedPath.ToString());
					FileInfo[] files = dir.GetFiles();

					foreach (FileInfo file in files)
						listViewImages2.Items.Add(fbDlg.SelectedPath.ToString()+"\\"+file.Name);
				}
			}
		}
		
		void openFile()
		{
			openFileDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
			openFileDlg.Multiselect=Enabled;
			
			if(openFileDlg.ShowDialog()== DialogResult.OK)
			{
				if(tabControl1.SelectedTab==tabPage1)
				{
					//listViewImages.Items.Add(openFileDlg.FileNames.ToString());
					string[] files = openFileDlg.FileNames;
					for(int i=0;i<files.Length;i++)
					{
						listViewImages.Items.Add(files[i]);
						CurrentFile = files[i];
					}
				}
				else if(tabControl1.SelectedTab==tabPage2)
				{
					//listViewImages2.Items.Add(openFileDlg.FileName.ToString());
					string[] files = openFileDlg.FileNames;
					for(int i=0;i<files.Length;i++)
					{
						listViewImages2.Items.Add(files[i]);
						CurrentFile = files[i];
					}
				}
				
			}
		}
		
		 #region Preview Function
        private void preview()
        {
            // Update the applicaton by reloading the image
            picBoxImagePreview.Image = Image.FromFile(CurrentFile);
            // Get a graphics context
            Graphics g = Graphics.FromImage(picBoxImagePreview.Image);
            // Create a solid brush to write the watermark text on the image
            Brush myBrush = new SolidBrush(Color.FromArgb(Opac, myWatermarkColor));
            // Calculate the size of the text
            SizeF sz = g.MeasureString(txtBoxText.Text, myFont);
            // Creae a copy of variables to keep track of the drawing position (X,Y)
            /*int X;
            int Y;
            // Set the drawing position based on the users
            // selection of placing the text at the bottom or top of the image
            if (optTop.Checked == true)
            {
                X = (int)(picBoxImagePreview.Image.Width - sz.Width) / 2;
                Y = (int)(picBoxImagePreview.Top + sz.Height) / 2;
            }
            else
            {
                X = (int)(picBoxImagePreview.Image.Width - sz.Width) / 2;
                Y = (int)(picBoxImagePreview.Image.Height - sz.Height);
            }*/
            // draw the water mark text
            g.DrawString(txtBoxText.Text, myFont, myBrush,
            new Point(20,20));
            //}
        #endregion
        }
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			this.Close();
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
				svDlg.Filter = strExt + " Image Files|*." + strExt;
				svDlg.FilterIndex = 1;
				
				if(svDlg.ShowDialog()==DialogResult.OK)
				{
					if(svDlg.FileName == "")
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
					MessageBox.Show(CurrentFile.ToString() + " saved.","File Save");
				}
				else
				{
					MessageBox.Show("The save file request was cancelled by user.", "Save Cancelled");
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Image Save Error");
			}
		}
		#region set Opacity Value

		void TxtBoxOpacityTextChanged(object sender, EventArgs e)
		{
			 int opValue = 0;
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
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			
		}
		
		void ToolStripBtHomePageClick(object sender, EventArgs e)
		{
			/*explorer = new InternetExplorer(); 
			if (explorer != null) 
			{ 
  			   explorer.Visible = true; 
   				 object x = null;
     			explorer.Navigate(@"MyReport.htm", ref x, ref x, ref x, ref x); 
			} */
		}
    }
        #endregion
}
