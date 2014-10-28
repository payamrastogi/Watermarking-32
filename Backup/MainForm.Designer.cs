/*
 * Created by SharpDevelop.
 * User: Payam Rastogi
 * Date: 12/2/2008
 * Time: 7:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Watermarking
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripBtOpenFile = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtOpenFolder = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtSetting = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtProcess = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtFont = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtImagePreview = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtPrint = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtZoomIn = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtZoomOut = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtHelp = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtHomePage = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtContactUs = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.grpBoxWatemarkText = new System.Windows.Forms.GroupBox();
			this.txtBoxOpacity = new System.Windows.Forms.TextBox();
			this.btSetColor = new System.Windows.Forms.Button();
			this.btSetFont = new System.Windows.Forms.Button();
			this.lblOpacity = new System.Windows.Forms.Label();
			this.txtBoxText = new System.Windows.Forms.TextBox();
			this.lblText = new System.Windows.Forms.Label();
			this.trackBarOpacity = new System.Windows.Forms.TrackBar();
			this.grpBoxImagePreview = new System.Windows.Forms.GroupBox();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.picBoxImagePreview = new System.Windows.Forms.PictureBox();
			this.grpBoxWPosition = new System.Windows.Forms.GroupBox();
			this.btBottomRight = new System.Windows.Forms.Button();
			this.btBottomCenter = new System.Windows.Forms.Button();
			this.btBottomLeft = new System.Windows.Forms.Button();
			this.btMiddleRight = new System.Windows.Forms.Button();
			this.btCenter = new System.Windows.Forms.Button();
			this.btMiddleLeft = new System.Windows.Forms.Button();
			this.btTopRight = new System.Windows.Forms.Button();
			this.btTopCenter = new System.Windows.Forms.Button();
			this.btTopLeft = new System.Windows.Forms.Button();
			this.grpBoxOutSet = new System.Windows.Forms.GroupBox();
			this.lblSave = new System.Windows.Forms.Label();
			this.cmbBoxSaveAs = new System.Windows.Forms.ComboBox();
			this.lblSaveAs = new System.Windows.Forms.Label();
			this.lblAfter = new System.Windows.Forms.Label();
			this.txtBoxSuffix = new System.Windows.Forms.TextBox();
			this.lblSuffix = new System.Windows.Forms.Label();
			this.chBoxOut = new System.Windows.Forms.CheckBox();
			this.btBrowse = new System.Windows.Forms.Button();
			this.txtBoxOutFolder = new System.Windows.Forms.TextBox();
			this.lblOutFolder = new System.Windows.Forms.Label();
			this.btApplyWatermark = new System.Windows.Forms.Button();
			this.listViewImages = new System.Windows.Forms.ListView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btUnMark = new System.Windows.Forms.Button();
			this.btMark = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.picBoxImagePreview2 = new System.Windows.Forms.PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.listViewImages2 = new System.Windows.Forms.ListView();
			this.button3 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lblDate = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.grpBoxWatemarkText.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
			this.grpBoxImagePreview.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBoxImagePreview)).BeginInit();
			this.grpBoxWPosition.SuspendLayout();
			this.grpBoxOutSet.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBoxImagePreview2)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(963, 26);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.openToolStripMenuItem,
									this.selectFolderToolStripMenuItem,
									this.saveToolStripMenuItem,
									this.saveAsToolStripMenuItem,
									this.toolStripSeparator2,
									this.printToolStripMenuItem,
									this.previewToolStripMenuItem,
									this.toolStripSeparator3,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
			this.openToolStripMenuItem.Text = "Open Images";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
			// 
			// selectFolderToolStripMenuItem
			// 
			this.selectFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectFolderToolStripMenuItem.Image")));
			this.selectFolderToolStripMenuItem.Name = "selectFolderToolStripMenuItem";
			this.selectFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
									| System.Windows.Forms.Keys.O)));
			this.selectFolderToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
			this.selectFolderToolStripMenuItem.Text = "Select a folder";
			this.selectFolderToolStripMenuItem.Click += new System.EventHandler(this.SelectFolderToolStripMenuItemClick);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
									| System.Windows.Forms.Keys.S)));
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
			this.saveAsToolStripMenuItem.Text = "Save As...";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(253, 6);
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.printToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
			this.printToolStripMenuItem.Text = "Print";
			// 
			// previewToolStripMenuItem
			// 
			this.previewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("previewToolStripMenuItem.Image")));
			this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
			this.previewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
									| System.Windows.Forms.Keys.P)));
			this.previewToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
			this.previewToolStripMenuItem.Text = "Preview";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(253, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.helpManualToolStripMenuItem,
									this.homePageToolStripMenuItem,
									this.toolStripSeparator1,
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// helpManualToolStripMenuItem
			// 
			this.helpManualToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpManualToolStripMenuItem.Image")));
			this.helpManualToolStripMenuItem.Name = "helpManualToolStripMenuItem";
			this.helpManualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.helpManualToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.helpManualToolStripMenuItem.Text = "Help Manual";
			// 
			// homePageToolStripMenuItem
			// 
			this.homePageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homePageToolStripMenuItem.Image")));
			this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
			this.homePageToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.homePageToolStripMenuItem.Text = "Home Page";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripBtOpenFile,
									this.toolStripBtOpenFolder,
									this.toolStripBtSave,
									this.toolStripBtDelete,
									this.toolStripSeparator4,
									this.toolStripBtSetting,
									this.toolStripBtProcess,
									this.toolStripBtFont,
									this.toolStripSeparator7,
									this.toolStripBtImagePreview,
									this.toolStripBtPrint,
									this.toolStripSeparator5,
									this.toolStripBtZoomIn,
									this.toolStripBtZoomOut,
									this.toolStripSeparator6,
									this.toolStripBtHelp,
									this.toolStripBtHomePage,
									this.toolStripBtContactUs,
									this.toolStripSeparator8,
									this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 26);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(963, 37);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripBtOpenFile
			// 
			this.toolStripBtOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtOpenFile.Image")));
			this.toolStripBtOpenFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripBtOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtOpenFile.Name = "toolStripBtOpenFile";
			this.toolStripBtOpenFile.Size = new System.Drawing.Size(34, 34);
			this.toolStripBtOpenFile.Text = "toolStripButton1";
			this.toolStripBtOpenFile.ToolTipText = "Select  Images    Ctrl + O";
			this.toolStripBtOpenFile.Click += new System.EventHandler(this.ToolStripBtOpenFileClick);
			// 
			// toolStripBtOpenFolder
			// 
			this.toolStripBtOpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtOpenFolder.Image")));
			this.toolStripBtOpenFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripBtOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtOpenFolder.Name = "toolStripBtOpenFolder";
			this.toolStripBtOpenFolder.Size = new System.Drawing.Size(34, 34);
			this.toolStripBtOpenFolder.Text = "toolStripButton2";
			this.toolStripBtOpenFolder.ToolTipText = "Select a folder containing images\r\nCtrl + Shift + O";
			this.toolStripBtOpenFolder.Click += new System.EventHandler(this.ToolStripBtOpenFolderClick);
			// 
			// toolStripBtSave
			// 
			this.toolStripBtSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtSave.Image")));
			this.toolStripBtSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripBtSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtSave.Name = "toolStripBtSave";
			this.toolStripBtSave.Size = new System.Drawing.Size(34, 34);
			this.toolStripBtSave.Text = "toolStripButton3";
			this.toolStripBtSave.ToolTipText = "Save    Ctrl + S";
			this.toolStripBtSave.Click += new System.EventHandler(this.ToolStripBtSaveClick);
			// 
			// toolStripBtDelete
			// 
			this.toolStripBtDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtDelete.Image")));
			this.toolStripBtDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripBtDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtDelete.Name = "toolStripBtDelete";
			this.toolStripBtDelete.Size = new System.Drawing.Size(34, 34);
			this.toolStripBtDelete.Text = "toolStripButton10";
			this.toolStripBtDelete.ToolTipText = "Delete    Ctrl + D";
			this.toolStripBtDelete.Click += new System.EventHandler(this.ToolStripBtDeleteClick);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
			// 
			// toolStripBtSetting
			// 
			this.toolStripBtSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtSetting.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtSetting.Image")));
			this.toolStripBtSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripBtSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtSetting.Name = "toolStripBtSetting";
			this.toolStripBtSetting.Size = new System.Drawing.Size(34, 34);
			this.toolStripBtSetting.Text = "toolStripButton11";
			this.toolStripBtSetting.ToolTipText = "Settings";
			// 
			// toolStripBtProcess
			// 
			this.toolStripBtProcess.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtProcess.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtProcess.Image")));
			this.toolStripBtProcess.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripBtProcess.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtProcess.Name = "toolStripBtProcess";
			this.toolStripBtProcess.Size = new System.Drawing.Size(34, 34);
			this.toolStripBtProcess.Text = "toolStripButton12";
			this.toolStripBtProcess.ToolTipText = "Apply Watermark";
			// 
			// toolStripBtFont
			// 
			this.toolStripBtFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtFont.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtFont.Image")));
			this.toolStripBtFont.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripBtFont.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtFont.Name = "toolStripBtFont";
			this.toolStripBtFont.Size = new System.Drawing.Size(34, 34);
			this.toolStripBtFont.Text = "toolStripButton13";
			this.toolStripBtFont.ToolTipText = "Font Settings";
			this.toolStripBtFont.Click += new System.EventHandler(this.ToolStripBtFontClick);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 37);
			// 
			// toolStripBtImagePreview
			// 
			this.toolStripBtImagePreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtImagePreview.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtImagePreview.Image")));
			this.toolStripBtImagePreview.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripBtImagePreview.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtImagePreview.Name = "toolStripBtImagePreview";
			this.toolStripBtImagePreview.Size = new System.Drawing.Size(34, 34);
			this.toolStripBtImagePreview.Text = "toolStripButton4";
			this.toolStripBtImagePreview.ToolTipText = "Image Preview\r\nCtrl + Shift + P";
			// 
			// toolStripBtPrint
			// 
			this.toolStripBtPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtPrint.Image")));
			this.toolStripBtPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripBtPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtPrint.Name = "toolStripBtPrint";
			this.toolStripBtPrint.Size = new System.Drawing.Size(34, 34);
			this.toolStripBtPrint.Text = "toolStripButton5";
			this.toolStripBtPrint.ToolTipText = "Print    Ctrl + P";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 37);
			// 
			// toolStripBtZoomIn
			// 
			this.toolStripBtZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtZoomIn.Image")));
			this.toolStripBtZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripBtZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtZoomIn.Name = "toolStripBtZoomIn";
			this.toolStripBtZoomIn.Size = new System.Drawing.Size(34, 34);
			this.toolStripBtZoomIn.Text = "toolStripButton6";
			this.toolStripBtZoomIn.ToolTipText = "Zoom In";
			this.toolStripBtZoomIn.Click += new System.EventHandler(this.ToolStripBtZoomInClick);
			// 
			// toolStripBtZoomOut
			// 
			this.toolStripBtZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtZoomOut.Image")));
			this.toolStripBtZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripBtZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtZoomOut.Name = "toolStripBtZoomOut";
			this.toolStripBtZoomOut.Size = new System.Drawing.Size(34, 34);
			this.toolStripBtZoomOut.Text = "toolStripButton7";
			this.toolStripBtZoomOut.ToolTipText = "Zoom Out";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 37);
			// 
			// toolStripBtHelp
			// 
			this.toolStripBtHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtHelp.Image")));
			this.toolStripBtHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripBtHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtHelp.Name = "toolStripBtHelp";
			this.toolStripBtHelp.Size = new System.Drawing.Size(34, 34);
			this.toolStripBtHelp.Text = "toolStripButton8";
			this.toolStripBtHelp.ToolTipText = "Help Manual    F1";
			// 
			// toolStripBtHomePage
			// 
			this.toolStripBtHomePage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtHomePage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtHomePage.Image")));
			this.toolStripBtHomePage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripBtHomePage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtHomePage.Name = "toolStripBtHomePage";
			this.toolStripBtHomePage.Size = new System.Drawing.Size(34, 34);
			this.toolStripBtHomePage.Text = "toolStripButton9";
			this.toolStripBtHomePage.ToolTipText = "Home Page";
			this.toolStripBtHomePage.Click += new System.EventHandler(this.ToolStripBtHomePageClick);
			// 
			// toolStripBtContactUs
			// 
			this.toolStripBtContactUs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtContactUs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtContactUs.Image")));
			this.toolStripBtContactUs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripBtContactUs.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtContactUs.Name = "toolStripBtContactUs";
			this.toolStripBtContactUs.Size = new System.Drawing.Size(34, 34);
			this.toolStripBtContactUs.Text = "toolStripButton14";
			this.toolStripBtContactUs.ToolTipText = "Contact Us";
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 37);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.AutoSize = false;
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(34, 34);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// grpBoxWatemarkText
			// 
			this.grpBoxWatemarkText.Controls.Add(this.txtBoxOpacity);
			this.grpBoxWatemarkText.Controls.Add(this.btSetColor);
			this.grpBoxWatemarkText.Controls.Add(this.btSetFont);
			this.grpBoxWatemarkText.Controls.Add(this.lblOpacity);
			this.grpBoxWatemarkText.Controls.Add(this.txtBoxText);
			this.grpBoxWatemarkText.Controls.Add(this.lblText);
			this.grpBoxWatemarkText.Controls.Add(this.trackBarOpacity);
			this.grpBoxWatemarkText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpBoxWatemarkText.Location = new System.Drawing.Point(315, 6);
			this.grpBoxWatemarkText.Name = "grpBoxWatemarkText";
			this.grpBoxWatemarkText.Size = new System.Drawing.Size(303, 149);
			this.grpBoxWatemarkText.TabIndex = 5;
			this.grpBoxWatemarkText.TabStop = false;
			this.grpBoxWatemarkText.Text = "Watermark Text";
			// 
			// txtBoxOpacity
			// 
			this.txtBoxOpacity.Location = new System.Drawing.Point(268, 118);
			this.txtBoxOpacity.Name = "txtBoxOpacity";
			this.txtBoxOpacity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtBoxOpacity.Size = new System.Drawing.Size(29, 26);
			this.txtBoxOpacity.TabIndex = 7;
			this.txtBoxOpacity.Text = "0";
			this.txtBoxOpacity.TextChanged += new System.EventHandler(this.TxtBoxOpacityTextChanged);
			// 
			// btSetColor
			// 
			this.btSetColor.Location = new System.Drawing.Point(8, 86);
			this.btSetColor.Name = "btSetColor";
			this.btSetColor.Size = new System.Drawing.Size(53, 26);
			this.btSetColor.TabIndex = 5;
			this.btSetColor.Text = "Color";
			this.btSetColor.UseVisualStyleBackColor = true;
			this.btSetColor.Click += new System.EventHandler(this.BtSetColorClick);
			// 
			// btSetFont
			// 
			this.btSetFont.Location = new System.Drawing.Point(8, 51);
			this.btSetFont.Name = "btSetFont";
			this.btSetFont.Size = new System.Drawing.Size(53, 26);
			this.btSetFont.TabIndex = 4;
			this.btSetFont.Text = "Font...";
			this.btSetFont.UseVisualStyleBackColor = true;
			this.btSetFont.Click += new System.EventHandler(this.BtSetFontClick);
			// 
			// lblOpacity
			// 
			this.lblOpacity.Location = new System.Drawing.Point(8, 120);
			this.lblOpacity.Name = "lblOpacity";
			this.lblOpacity.Size = new System.Drawing.Size(57, 23);
			this.lblOpacity.TabIndex = 2;
			this.lblOpacity.Text = "Opacity";
			// 
			// txtBoxText
			// 
			this.txtBoxText.Location = new System.Drawing.Point(65, 22);
			this.txtBoxText.Multiline = true;
			this.txtBoxText.Name = "txtBoxText";
			this.txtBoxText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBoxText.Size = new System.Drawing.Size(232, 90);
			this.txtBoxText.TabIndex = 1;
			this.txtBoxText.TextChanged += new System.EventHandler(this.TxtBoxTextTextChanged);
			// 
			// lblText
			// 
			this.lblText.Location = new System.Drawing.Point(24, 25);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(37, 23);
			this.lblText.TabIndex = 0;
			this.lblText.Text = "Text";
			this.lblText.Click += new System.EventHandler(this.Label1Click);
			// 
			// trackBarOpacity
			// 
			this.trackBarOpacity.AutoSize = false;
			this.trackBarOpacity.Cursor = System.Windows.Forms.Cursors.Hand;
			this.trackBarOpacity.Location = new System.Drawing.Point(65, 117);
			this.trackBarOpacity.Maximum = 255;
			this.trackBarOpacity.Name = "trackBarOpacity";
			this.trackBarOpacity.Size = new System.Drawing.Size(208, 26);
			this.trackBarOpacity.TabIndex = 6;
			this.trackBarOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBarOpacity.Scroll += new System.EventHandler(this.TrackBarOpacityScroll);
			// 
			// grpBoxImagePreview
			// 
			this.grpBoxImagePreview.Controls.Add(this.vScrollBar1);
			this.grpBoxImagePreview.Controls.Add(this.hScrollBar1);
			this.grpBoxImagePreview.Controls.Add(this.picBoxImagePreview);
			this.grpBoxImagePreview.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpBoxImagePreview.Location = new System.Drawing.Point(192, 161);
			this.grpBoxImagePreview.Name = "grpBoxImagePreview";
			this.grpBoxImagePreview.Size = new System.Drawing.Size(754, 420);
			this.grpBoxImagePreview.TabIndex = 6;
			this.grpBoxImagePreview.TabStop = false;
			this.grpBoxImagePreview.Text = "Image Preview";
			this.grpBoxImagePreview.Enter += new System.EventHandler(this.GrpBoxImagePreviewEnter);
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Location = new System.Drawing.Point(731, 22);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(17, 392);
			this.vScrollBar1.TabIndex = 2;
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(6, 397);
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(725, 17);
			this.hScrollBar1.TabIndex = 1;
			// 
			// picBoxImagePreview
			// 
			this.picBoxImagePreview.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.picBoxImagePreview.ImageLocation = "";
			this.picBoxImagePreview.Location = new System.Drawing.Point(6, 21);
			this.picBoxImagePreview.Name = "picBoxImagePreview";
			this.picBoxImagePreview.Size = new System.Drawing.Size(742, 393);
			this.picBoxImagePreview.TabIndex = 0;
			this.picBoxImagePreview.TabStop = false;
			this.picBoxImagePreview.Click += new System.EventHandler(this.PicBoxImagePreviewClick);
			// 
			// grpBoxWPosition
			// 
			this.grpBoxWPosition.Controls.Add(this.btBottomRight);
			this.grpBoxWPosition.Controls.Add(this.btBottomCenter);
			this.grpBoxWPosition.Controls.Add(this.btBottomLeft);
			this.grpBoxWPosition.Controls.Add(this.btMiddleRight);
			this.grpBoxWPosition.Controls.Add(this.btCenter);
			this.grpBoxWPosition.Controls.Add(this.btMiddleLeft);
			this.grpBoxWPosition.Controls.Add(this.btTopRight);
			this.grpBoxWPosition.Controls.Add(this.btTopCenter);
			this.grpBoxWPosition.Controls.Add(this.btTopLeft);
			this.grpBoxWPosition.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpBoxWPosition.Location = new System.Drawing.Point(6, 161);
			this.grpBoxWPosition.Name = "grpBoxWPosition";
			this.grpBoxWPosition.Size = new System.Drawing.Size(180, 137);
			this.grpBoxWPosition.TabIndex = 7;
			this.grpBoxWPosition.TabStop = false;
			this.grpBoxWPosition.Text = "Text Position";
			this.grpBoxWPosition.Enter += new System.EventHandler(this.GrpBoxWPositionEnter);
			// 
			// btBottomRight
			// 
			this.btBottomRight.Location = new System.Drawing.Point(118, 108);
			this.btBottomRight.Name = "btBottomRight";
			this.btBottomRight.Size = new System.Drawing.Size(50, 23);
			this.btBottomRight.TabIndex = 8;
			this.btBottomRight.UseVisualStyleBackColor = true;
			// 
			// btBottomCenter
			// 
			this.btBottomCenter.Location = new System.Drawing.Point(62, 108);
			this.btBottomCenter.Name = "btBottomCenter";
			this.btBottomCenter.Size = new System.Drawing.Size(56, 23);
			this.btBottomCenter.TabIndex = 7;
			this.btBottomCenter.UseVisualStyleBackColor = true;
			// 
			// btBottomLeft
			// 
			this.btBottomLeft.Location = new System.Drawing.Point(12, 108);
			this.btBottomLeft.Name = "btBottomLeft";
			this.btBottomLeft.Size = new System.Drawing.Size(50, 23);
			this.btBottomLeft.TabIndex = 6;
			this.btBottomLeft.UseVisualStyleBackColor = true;
			// 
			// btMiddleRight
			// 
			this.btMiddleRight.Location = new System.Drawing.Point(136, 41);
			this.btMiddleRight.Name = "btMiddleRight";
			this.btMiddleRight.Size = new System.Drawing.Size(32, 67);
			this.btMiddleRight.TabIndex = 5;
			this.btMiddleRight.UseVisualStyleBackColor = true;
			// 
			// btCenter
			// 
			this.btCenter.Location = new System.Drawing.Point(46, 41);
			this.btCenter.Name = "btCenter";
			this.btCenter.Size = new System.Drawing.Size(90, 67);
			this.btCenter.TabIndex = 4;
			this.btCenter.UseVisualStyleBackColor = true;
			// 
			// btMiddleLeft
			// 
			this.btMiddleLeft.Location = new System.Drawing.Point(12, 41);
			this.btMiddleLeft.Name = "btMiddleLeft";
			this.btMiddleLeft.Size = new System.Drawing.Size(32, 67);
			this.btMiddleLeft.TabIndex = 3;
			this.btMiddleLeft.UseVisualStyleBackColor = true;
			// 
			// btTopRight
			// 
			this.btTopRight.Location = new System.Drawing.Point(119, 18);
			this.btTopRight.Name = "btTopRight";
			this.btTopRight.Size = new System.Drawing.Size(50, 23);
			this.btTopRight.TabIndex = 2;
			this.btTopRight.UseVisualStyleBackColor = true;
			// 
			// btTopCenter
			// 
			this.btTopCenter.Location = new System.Drawing.Point(62, 18);
			this.btTopCenter.Name = "btTopCenter";
			this.btTopCenter.Size = new System.Drawing.Size(56, 23);
			this.btTopCenter.TabIndex = 1;
			this.btTopCenter.UseVisualStyleBackColor = true;
			// 
			// btTopLeft
			// 
			this.btTopLeft.Location = new System.Drawing.Point(12, 18);
			this.btTopLeft.Name = "btTopLeft";
			this.btTopLeft.Size = new System.Drawing.Size(50, 23);
			this.btTopLeft.TabIndex = 0;
			this.btTopLeft.UseVisualStyleBackColor = true;
			// 
			// grpBoxOutSet
			// 
			this.grpBoxOutSet.Controls.Add(this.lblSave);
			this.grpBoxOutSet.Controls.Add(this.cmbBoxSaveAs);
			this.grpBoxOutSet.Controls.Add(this.lblSaveAs);
			this.grpBoxOutSet.Controls.Add(this.lblAfter);
			this.grpBoxOutSet.Controls.Add(this.txtBoxSuffix);
			this.grpBoxOutSet.Controls.Add(this.lblSuffix);
			this.grpBoxOutSet.Controls.Add(this.chBoxOut);
			this.grpBoxOutSet.Controls.Add(this.btBrowse);
			this.grpBoxOutSet.Controls.Add(this.txtBoxOutFolder);
			this.grpBoxOutSet.Controls.Add(this.lblOutFolder);
			this.grpBoxOutSet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpBoxOutSet.Location = new System.Drawing.Point(624, 6);
			this.grpBoxOutSet.Name = "grpBoxOutSet";
			this.grpBoxOutSet.Size = new System.Drawing.Size(322, 149);
			this.grpBoxOutSet.TabIndex = 8;
			this.grpBoxOutSet.TabStop = false;
			this.grpBoxOutSet.Text = "Output Settings";
			// 
			// lblSave
			// 
			this.lblSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblSave.Image = ((System.Drawing.Image)(resources.GetObject("lblSave.Image")));
			this.lblSave.Location = new System.Drawing.Point(256, 116);
			this.lblSave.Name = "lblSave";
			this.lblSave.Size = new System.Drawing.Size(23, 23);
			this.lblSave.TabIndex = 23;
			this.lblSave.Click += new System.EventHandler(this.Label2Click);
			// 
			// cmbBoxSaveAs
			// 
			this.cmbBoxSaveAs.FormattingEnabled = true;
			this.cmbBoxSaveAs.Location = new System.Drawing.Point(89, 113);
			this.cmbBoxSaveAs.Name = "cmbBoxSaveAs";
			this.cmbBoxSaveAs.Size = new System.Drawing.Size(153, 26);
			this.cmbBoxSaveAs.TabIndex = 22;
			// 
			// lblSaveAs
			// 
			this.lblSaveAs.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSaveAs.Location = new System.Drawing.Point(6, 116);
			this.lblSaveAs.Name = "lblSaveAs";
			this.lblSaveAs.Size = new System.Drawing.Size(100, 23);
			this.lblSaveAs.TabIndex = 21;
			this.lblSaveAs.Text = "Save As";
			this.lblSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAfter
			// 
			this.lblAfter.Enabled = false;
			this.lblAfter.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAfter.Location = new System.Drawing.Point(248, 42);
			this.lblAfter.Name = "lblAfter";
			this.lblAfter.Size = new System.Drawing.Size(70, 35);
			this.lblAfter.TabIndex = 20;
			this.lblAfter.Text = "after file \r\nnames.";
			this.lblAfter.Click += new System.EventHandler(this.Label5Click);
			// 
			// txtBoxSuffix
			// 
			this.txtBoxSuffix.Enabled = false;
			this.txtBoxSuffix.Location = new System.Drawing.Point(89, 44);
			this.txtBoxSuffix.Name = "txtBoxSuffix";
			this.txtBoxSuffix.Size = new System.Drawing.Size(153, 26);
			this.txtBoxSuffix.TabIndex = 19;
			this.txtBoxSuffix.Text = "_Marked";
			// 
			// lblSuffix
			// 
			this.lblSuffix.Enabled = false;
			this.lblSuffix.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSuffix.Location = new System.Drawing.Point(6, 48);
			this.lblSuffix.Name = "lblSuffix";
			this.lblSuffix.Size = new System.Drawing.Size(99, 23);
			this.lblSuffix.TabIndex = 18;
			this.lblSuffix.Text = "Add suffix";
			// 
			// chBoxOut
			// 
			this.chBoxOut.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chBoxOut.Location = new System.Drawing.Point(6, 18);
			this.chBoxOut.Name = "chBoxOut";
			this.chBoxOut.Size = new System.Drawing.Size(291, 24);
			this.chBoxOut.TabIndex = 17;
			this.chBoxOut.Text = "Use the previous location as Output Folder ";
			this.chBoxOut.UseVisualStyleBackColor = true;
			this.chBoxOut.CheckedChanged += new System.EventHandler(this.ChBoxOutCheckedChanged);
			// 
			// btBrowse
			// 
			this.btBrowse.Location = new System.Drawing.Point(250, 80);
			this.btBrowse.Name = "btBrowse";
			this.btBrowse.Size = new System.Drawing.Size(34, 26);
			this.btBrowse.TabIndex = 16;
			this.btBrowse.Text = "...";
			this.btBrowse.UseVisualStyleBackColor = true;
			// 
			// txtBoxOutFolder
			// 
			this.txtBoxOutFolder.Location = new System.Drawing.Point(89, 78);
			this.txtBoxOutFolder.Name = "txtBoxOutFolder";
			this.txtBoxOutFolder.Size = new System.Drawing.Size(153, 26);
			this.txtBoxOutFolder.TabIndex = 15;
			// 
			// lblOutFolder
			// 
			this.lblOutFolder.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOutFolder.Location = new System.Drawing.Point(6, 76);
			this.lblOutFolder.Name = "lblOutFolder";
			this.lblOutFolder.Size = new System.Drawing.Size(55, 35);
			this.lblOutFolder.TabIndex = 14;
			this.lblOutFolder.Text = "Output \r\nFolder";
			// 
			// btApplyWatermark
			// 
			this.btApplyWatermark.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btApplyWatermark.Image = ((System.Drawing.Image)(resources.GetObject("btApplyWatermark.Image")));
			this.btApplyWatermark.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btApplyWatermark.Location = new System.Drawing.Point(6, 304);
			this.btApplyWatermark.Name = "btApplyWatermark";
			this.btApplyWatermark.Size = new System.Drawing.Size(180, 37);
			this.btApplyWatermark.TabIndex = 10;
			this.btApplyWatermark.Text = "Apply Watermark";
			this.btApplyWatermark.UseVisualStyleBackColor = true;
			this.btApplyWatermark.Click += new System.EventHandler(this.BtApplyWatermarkClick);
			// 
			// listViewImages
			// 
			this.listViewImages.CheckBoxes = true;
			this.listViewImages.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listViewImages.FullRowSelect = true;
			this.listViewImages.GridLines = true;
			this.listViewImages.Location = new System.Drawing.Point(6, 21);
			this.listViewImages.MultiSelect = false;
			this.listViewImages.Name = "listViewImages";
			this.listViewImages.Size = new System.Drawing.Size(291, 93);
			this.listViewImages.TabIndex = 9;
			this.listViewImages.UseCompatibleStateImageBehavior = false;
			this.listViewImages.View = System.Windows.Forms.View.SmallIcon;
			this.listViewImages.SelectedIndexChanged += new System.EventHandler(this.ListViewImagesSelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btUnMark);
			this.groupBox1.Controls.Add(this.listViewImages);
			this.groupBox1.Controls.Add(this.btMark);
			this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(303, 149);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Images";
			// 
			// btUnMark
			// 
			this.btUnMark.Location = new System.Drawing.Point(159, 116);
			this.btUnMark.Name = "btUnMark";
			this.btUnMark.Size = new System.Drawing.Size(110, 27);
			this.btUnMark.TabIndex = 15;
			this.btUnMark.Text = "Unmark All";
			this.btUnMark.UseVisualStyleBackColor = true;
			this.btUnMark.Click += new System.EventHandler(this.BtUnMarkClick);
			// 
			// btMark
			// 
			this.btMark.Location = new System.Drawing.Point(36, 116);
			this.btMark.Name = "btMark";
			this.btMark.Size = new System.Drawing.Size(110, 27);
			this.btMark.TabIndex = 14;
			this.btMark.Text = "Mark All";
			this.btMark.UseVisualStyleBackColor = true;
			this.btMark.Click += new System.EventHandler(this.Button1Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(0, 65);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(963, 618);
			this.tabControl1.TabIndex = 14;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
			this.tabPage1.Controls.Add(this.grpBoxWatemarkText);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.grpBoxImagePreview);
			this.tabPage1.Controls.Add(this.btApplyWatermark);
			this.tabPage1.Controls.Add(this.grpBoxOutSet);
			this.tabPage1.Controls.Add(this.grpBoxWPosition);
			this.tabPage1.Location = new System.Drawing.Point(4, 27);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(955, 587);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Marking";
			this.tabPage1.Click += new System.EventHandler(this.TabPage1Click);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
			this.tabPage2.Controls.Add(this.button6);
			this.tabPage2.Controls.Add(this.button5);
			this.tabPage2.Controls.Add(this.groupBox8);
			this.tabPage2.Controls.Add(this.groupBox7);
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Location = new System.Drawing.Point(4, 27);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(955, 587);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Extracting";
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(204, 350);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(121, 35);
			this.button6.TabIndex = 4;
			this.button6.Text = "Save As...";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(12, 350);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(121, 35);
			this.button5.TabIndex = 3;
			this.button5.Text = "Extract";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.textBox1);
			this.groupBox8.Location = new System.Drawing.Point(6, 194);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(328, 150);
			this.groupBox8.TabIndex = 2;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Watermarked Text";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 20);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(313, 124);
			this.textBox1.TabIndex = 0;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.picBoxImagePreview2);
			this.groupBox7.Location = new System.Drawing.Point(340, 6);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(607, 575);
			this.groupBox7.TabIndex = 1;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Image Preview";
			// 
			// picBoxImagePreview2
			// 
			this.picBoxImagePreview2.BackColor = System.Drawing.Color.White;
			this.picBoxImagePreview2.Location = new System.Drawing.Point(7, 21);
			this.picBoxImagePreview2.Name = "picBoxImagePreview2";
			this.picBoxImagePreview2.Size = new System.Drawing.Size(594, 548);
			this.picBoxImagePreview2.TabIndex = 0;
			this.picBoxImagePreview2.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button4);
			this.groupBox3.Controls.Add(this.listViewImages2);
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Location = new System.Drawing.Point(6, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(328, 182);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Images";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(209, 143);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(110, 28);
			this.button4.TabIndex = 2;
			this.button4.Text = "Unmark All";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// listViewImages2
			// 
			this.listViewImages2.CheckBoxes = true;
			this.listViewImages2.Location = new System.Drawing.Point(6, 21);
			this.listViewImages2.Name = "listViewImages2";
			this.listViewImages2.Size = new System.Drawing.Size(313, 116);
			this.listViewImages2.TabIndex = 0;
			this.listViewImages2.UseCompatibleStateImageBehavior = false;
			this.listViewImages2.View = System.Windows.Forms.View.SmallIcon;
			this.listViewImages2.SelectedIndexChanged += new System.EventHandler(this.ListViewImages2SelectedIndexChanged);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(6, 143);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(110, 28);
			this.button3.TabIndex = 1;
			this.button3.Text = "Mark All";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.74744F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.25256F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 318F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 341F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.progressBar1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblDate, 3, 0);
			this.tableLayoutPanel1.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 683);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(963, 21);
			this.tableLayoutPanel1.TabIndex = 15;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Status";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(56, 3);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(200, 14);
			this.progressBar1.TabIndex = 1;
			// 
			// lblDate
			// 
			this.lblDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.Location = new System.Drawing.Point(624, 0);
			this.lblDate.Name = "lblDate";
			this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblDate.Size = new System.Drawing.Size(335, 17);
			this.lblDate.TabIndex = 2;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(963, 704);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Watermarking";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.grpBoxWatemarkText.ResumeLayout(false);
			this.grpBoxWatemarkText.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
			this.grpBoxImagePreview.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picBoxImagePreview)).EndInit();
			this.grpBoxWPosition.ResumeLayout(false);
			this.grpBoxOutSet.ResumeLayout(false);
			this.grpBoxOutSet.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picBoxImagePreview2)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtBoxOpacity;
		private System.Windows.Forms.TrackBar trackBarOpacity;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.Button btBottomRight;
		private System.Windows.Forms.Button btBottomCenter;
		private System.Windows.Forms.Button btBottomLeft;
		private System.Windows.Forms.Button btMiddleRight;
		private System.Windows.Forms.Button btCenter;
		private System.Windows.Forms.Button btMiddleLeft;
		private System.Windows.Forms.Button btTopRight;
		private System.Windows.Forms.Button btTopCenter;
		private System.Windows.Forms.Button btTopLeft;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btUnMark;
		private System.Windows.Forms.Button btMark;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.PictureBox picBoxImagePreview2;
		private System.Windows.Forms.ListView listViewImages2;
		private System.Windows.Forms.Label lblSave;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtBoxText;
		private System.Windows.Forms.ToolStripMenuItem selectFolderToolStripMenuItem;
		private System.Windows.Forms.GroupBox grpBoxWatemarkText;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.Label lblOpacity;
		private System.Windows.Forms.Button btSetColor;
		private System.Windows.Forms.Button btSetFont;
		private System.Windows.Forms.ToolStripButton toolStripBtOpenFile;
		private System.Windows.Forms.ToolStripButton toolStripBtOpenFolder;
		private System.Windows.Forms.ToolStripButton toolStripBtSave;
		private System.Windows.Forms.ToolStripButton toolStripBtImagePreview;
		private System.Windows.Forms.ToolStripButton toolStripBtPrint;
		private System.Windows.Forms.ToolStripButton toolStripBtZoomIn;
		private System.Windows.Forms.ToolStripButton toolStripBtZoomOut;
		private System.Windows.Forms.ToolStripButton toolStripBtHelp;
		private System.Windows.Forms.ToolStripButton toolStripBtDelete;
		private System.Windows.Forms.ToolStripButton toolStripBtSetting;
		private System.Windows.Forms.ToolStripButton toolStripBtHomePage;
		private System.Windows.Forms.ToolStripButton toolStripBtProcess;
		private System.Windows.Forms.ToolStripButton toolStripBtFont;
		private System.Windows.Forms.ToolStripButton toolStripBtContactUs;
		private System.Windows.Forms.GroupBox grpBoxImagePreview;
		private System.Windows.Forms.GroupBox grpBoxWPosition;
		private System.Windows.Forms.PictureBox picBoxImagePreview;
		private System.Windows.Forms.GroupBox grpBoxOutSet;
		private System.Windows.Forms.TextBox txtBoxSuffix;
		private System.Windows.Forms.Label lblSuffix;
		private System.Windows.Forms.CheckBox chBoxOut;
		private System.Windows.Forms.Button btBrowse;
		private System.Windows.Forms.TextBox txtBoxOutFolder;
		private System.Windows.Forms.Label lblOutFolder;
		private System.Windows.Forms.Label lblAfter;
		private System.Windows.Forms.ListView listViewImages;
		private System.Windows.Forms.Button btApplyWatermark;
		private System.Windows.Forms.ComboBox cmbBoxSaveAs;
		private System.Windows.Forms.Label lblSaveAs;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpManualToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		
		void CmbBoxImageSizeSelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void SaveToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			svDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
			svDlg.Title="Save an Image File";
			svDlg.ShowDialog();
		}
		
		void GrpBoxWPositionEnter(object sender, System.EventArgs e)
		{
			
		}
		
		void TabPage1Click(object sender, System.EventArgs e)
		{
			
		}
	}
}
