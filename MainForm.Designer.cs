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
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExternallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.picBoxImagePreview = new System.Windows.Forms.PictureBox();
            this.progressBar2 = new VistaStyleProgressBar.ProgressBar();
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
            this.listViewImages = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btUnMark = new System.Windows.Forms.Button();
            this.btMark = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkGrayscale = new System.Windows.Forms.CheckBox();
            this.chkHideMessage = new System.Windows.Forms.CheckBox();
            this.grpBoxKey = new System.Windows.Forms.GroupBox();
            this.btnSaveBitmap = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.txtKeyText = new System.Windows.Forms.TextBox();
            this.rdoKeyText = new System.Windows.Forms.RadioButton();
            this.txtKeyFile = new System.Windows.Forms.TextBox();
            this.btBrowse2 = new System.Windows.Forms.Button();
            this.rdoFilename = new System.Windows.Forms.RadioButton();
            this.btApplyWatermark = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtExtractedMsgFile = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKey2Text = new System.Windows.Forms.TextBox();
            this.rdoKey2Text = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtKey2File = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button6 = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtExtractedMsgText = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.picBoxImagePreview2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btUnmarkallExtract = new System.Windows.Forms.Button();
            this.listViewImages2 = new System.Windows.Forms.ListView();
            this.btMarkallExtract = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.fileinProcess = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.btStop = new System.Windows.Forms.Button();
            this.btExtract = new System.Windows.Forms.Button();
            this.txtExtBitmap = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button42 = new System.Windows.Forms.Button();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button41 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button40 = new System.Windows.Forms.Button();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.txtVFile = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button29 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button39 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btvBottomRight = new System.Windows.Forms.Button();
            this.btvBottomMiddle = new System.Windows.Forms.Button();
            this.btvBottomLeft = new System.Windows.Forms.Button();
            this.btvMiddleRight = new System.Windows.Forms.Button();
            this.btvCenter = new System.Windows.Forms.Button();
            this.btvMiddleLeft = new System.Windows.Forms.Button();
            this.btvTopRight = new System.Windows.Forms.Button();
            this.btvTopMiddle = new System.Windows.Forms.Button();
            this.btVTopLeft = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.picBoxPreview3 = new System.Windows.Forms.PictureBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblCnt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtVOpacity = new System.Windows.Forms.TextBox();
            this.trackBarVOpacity = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btVColor = new System.Windows.Forms.Button();
            this.btVFont = new System.Windows.Forms.Button();
            this.txtVWatermark = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.picBoxFrame = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
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
            this.grpBoxKey.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImagePreview2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPreview3)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVOpacity)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrame)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.exitToolStripMenuItem,
            this.deleteToolStripMenuItem});
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
            this.openToolStripMenuItem.Text = "Open File";
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
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
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
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editExternallyToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // editExternallyToolStripMenuItem
            // 
            this.editExternallyToolStripMenuItem.Name = "editExternallyToolStripMenuItem";
            this.editExternallyToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.editExternallyToolStripMenuItem.Text = "Edit Externally";
            this.editExternallyToolStripMenuItem.Click += new System.EventHandler(this.editExternallyToolStripMenuItem_Click);
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
            this.toolStripBtOpenFile.ToolTipText = "Select  Files    Ctrl + O";
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
            this.toolStripBtSetting.Click += new System.EventHandler(this.toolStripBtSetting_Click);
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
            this.toolStripBtImagePreview.Enabled = false;
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
            this.toolStripBtPrint.Enabled = false;
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
            this.toolStripBtZoomIn.Enabled = false;
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
            this.toolStripBtZoomOut.Enabled = false;
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
            this.toolStripBtHelp.Enabled = false;
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
            this.toolStripBtContactUs.Click += new System.EventHandler(this.toolStripBtContactUs_Click);
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
            this.grpBoxWatemarkText.Enabled = false;
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
            this.txtBoxOpacity.Text = "100";
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
            this.trackBarOpacity.Value = 100;
            this.trackBarOpacity.Scroll += new System.EventHandler(this.TrackBarOpacityScroll);
            // 
            // grpBoxImagePreview
            // 
            this.grpBoxImagePreview.Controls.Add(this.picBoxImagePreview);
            this.grpBoxImagePreview.Controls.Add(this.progressBar2);
            this.grpBoxImagePreview.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxImagePreview.Location = new System.Drawing.Point(192, 161);
            this.grpBoxImagePreview.Name = "grpBoxImagePreview";
            this.grpBoxImagePreview.Size = new System.Drawing.Size(754, 420);
            this.grpBoxImagePreview.TabIndex = 6;
            this.grpBoxImagePreview.TabStop = false;
            this.grpBoxImagePreview.Text = "Image Preview";
            this.grpBoxImagePreview.Enter += new System.EventHandler(this.GrpBoxImagePreviewEnter);
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
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Transparent;
            this.progressBar2.Location = new System.Drawing.Point(-186, 251);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(180, 14);
            this.progressBar2.TabIndex = 14;
            this.progressBar2.ValueChanged += new VistaStyleProgressBar.ProgressBar.ValueChangedHandler(this.progressBar2_ValueChanged);
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
            this.btBottomRight.Click += new System.EventHandler(this.btBottomRight_Click_1);
            // 
            // btBottomCenter
            // 
            this.btBottomCenter.Location = new System.Drawing.Point(62, 108);
            this.btBottomCenter.Name = "btBottomCenter";
            this.btBottomCenter.Size = new System.Drawing.Size(56, 23);
            this.btBottomCenter.TabIndex = 7;
            this.btBottomCenter.UseVisualStyleBackColor = true;
            this.btBottomCenter.Click += new System.EventHandler(this.btBottomCenter_Click_1);
            // 
            // btBottomLeft
            // 
            this.btBottomLeft.Location = new System.Drawing.Point(12, 108);
            this.btBottomLeft.Name = "btBottomLeft";
            this.btBottomLeft.Size = new System.Drawing.Size(50, 23);
            this.btBottomLeft.TabIndex = 6;
            this.btBottomLeft.UseVisualStyleBackColor = true;
            this.btBottomLeft.Click += new System.EventHandler(this.btBottomLeft_Click_1);
            // 
            // btMiddleRight
            // 
            this.btMiddleRight.Location = new System.Drawing.Point(136, 41);
            this.btMiddleRight.Name = "btMiddleRight";
            this.btMiddleRight.Size = new System.Drawing.Size(32, 67);
            this.btMiddleRight.TabIndex = 5;
            this.btMiddleRight.UseVisualStyleBackColor = true;
            this.btMiddleRight.Click += new System.EventHandler(this.btMiddleRight_Click_1);
            // 
            // btCenter
            // 
            this.btCenter.Location = new System.Drawing.Point(46, 41);
            this.btCenter.Name = "btCenter";
            this.btCenter.Size = new System.Drawing.Size(90, 67);
            this.btCenter.TabIndex = 4;
            this.btCenter.UseVisualStyleBackColor = true;
            this.btCenter.Click += new System.EventHandler(this.btCenter_Click_1);
            // 
            // btMiddleLeft
            // 
            this.btMiddleLeft.Location = new System.Drawing.Point(12, 41);
            this.btMiddleLeft.Name = "btMiddleLeft";
            this.btMiddleLeft.Size = new System.Drawing.Size(32, 67);
            this.btMiddleLeft.TabIndex = 3;
            this.btMiddleLeft.UseVisualStyleBackColor = true;
            this.btMiddleLeft.Click += new System.EventHandler(this.btMiddleLeft_Click_1);
            // 
            // btTopRight
            // 
            this.btTopRight.Location = new System.Drawing.Point(119, 18);
            this.btTopRight.Name = "btTopRight";
            this.btTopRight.Size = new System.Drawing.Size(50, 23);
            this.btTopRight.TabIndex = 2;
            this.btTopRight.UseVisualStyleBackColor = true;
            this.btTopRight.Click += new System.EventHandler(this.btTopRight_Click_1);
            // 
            // btTopCenter
            // 
            this.btTopCenter.Location = new System.Drawing.Point(62, 18);
            this.btTopCenter.Name = "btTopCenter";
            this.btTopCenter.Size = new System.Drawing.Size(56, 23);
            this.btTopCenter.TabIndex = 1;
            this.btTopCenter.UseVisualStyleBackColor = true;
            this.btTopCenter.Click += new System.EventHandler(this.btTopCenter_Click_1);
            // 
            // btTopLeft
            // 
            this.btTopLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTopLeft.Location = new System.Drawing.Point(12, 18);
            this.btTopLeft.Name = "btTopLeft";
            this.btTopLeft.Size = new System.Drawing.Size(50, 23);
            this.btTopLeft.TabIndex = 0;
            this.btTopLeft.UseVisualStyleBackColor = true;
            this.btTopLeft.Click += new System.EventHandler(this.btTopLeft_Click_1);
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
            this.grpBoxOutSet.Enabled = false;
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
            this.cmbBoxSaveAs.Enabled = false;
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
            this.txtBoxSuffix.Location = new System.Drawing.Point(89, 44);
            this.txtBoxSuffix.Name = "txtBoxSuffix";
            this.txtBoxSuffix.Size = new System.Drawing.Size(153, 26);
            this.txtBoxSuffix.TabIndex = 19;
            this.txtBoxSuffix.Text = "_Marked";
            // 
            // lblSuffix
            // 
            this.lblSuffix.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuffix.Location = new System.Drawing.Point(6, 48);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(99, 23);
            this.lblSuffix.TabIndex = 18;
            this.lblSuffix.Text = "Add suffix";
            // 
            // chBoxOut
            // 
            this.chBoxOut.Checked = true;
            this.chBoxOut.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.btBrowse.Enabled = false;
            this.btBrowse.Location = new System.Drawing.Point(250, 80);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(34, 26);
            this.btBrowse.TabIndex = 16;
            this.btBrowse.Text = "...";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // txtBoxOutFolder
            // 
            this.txtBoxOutFolder.Enabled = false;
            this.txtBoxOutFolder.Location = new System.Drawing.Point(89, 78);
            this.txtBoxOutFolder.Name = "txtBoxOutFolder";
            this.txtBoxOutFolder.Size = new System.Drawing.Size(153, 26);
            this.txtBoxOutFolder.TabIndex = 15;
            this.txtBoxOutFolder.TextChanged += new System.EventHandler(this.txtBoxOutFolder_TextChanged);
            // 
            // lblOutFolder
            // 
            this.lblOutFolder.Enabled = false;
            this.lblOutFolder.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutFolder.Location = new System.Drawing.Point(6, 76);
            this.lblOutFolder.Name = "lblOutFolder";
            this.lblOutFolder.Size = new System.Drawing.Size(55, 35);
            this.lblOutFolder.TabIndex = 14;
            this.lblOutFolder.Text = "Output \r\nFolder";
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
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 620);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.chkGrayscale);
            this.tabPage1.Controls.Add(this.chkHideMessage);
            this.tabPage1.Controls.Add(this.grpBoxKey);
            this.tabPage1.Controls.Add(this.grpBoxWatemarkText);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grpBoxImagePreview);
            this.tabPage1.Controls.Add(this.btApplyWatermark);
            this.tabPage1.Controls.Add(this.grpBoxOutSet);
            this.tabPage1.Controls.Add(this.grpBoxWPosition);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Marking";
            this.tabPage1.Click += new System.EventHandler(this.TabPage1Click);
            // 
            // chkGrayscale
            // 
            this.chkGrayscale.AutoSize = true;
            this.chkGrayscale.Location = new System.Drawing.Point(8, 332);
            this.chkGrayscale.Name = "chkGrayscale";
            this.chkGrayscale.Size = new System.Drawing.Size(179, 22);
            this.chkGrayscale.TabIndex = 16;
            this.chkGrayscale.Text = "Produce Grayscale Noise";
            this.chkGrayscale.UseVisualStyleBackColor = true;
            // 
            // chkHideMessage
            // 
            this.chkHideMessage.AutoSize = true;
            this.chkHideMessage.Location = new System.Drawing.Point(8, 304);
            this.chkHideMessage.Name = "chkHideMessage";
            this.chkHideMessage.Size = new System.Drawing.Size(114, 22);
            this.chkHideMessage.TabIndex = 15;
            this.chkHideMessage.Text = "Hide Mesaage";
            this.chkHideMessage.UseVisualStyleBackColor = true;
            this.chkHideMessage.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grpBoxKey
            // 
            this.grpBoxKey.Controls.Add(this.btnSaveBitmap);
            this.grpBoxKey.Controls.Add(this.btnHide);
            this.grpBoxKey.Controls.Add(this.txtKeyText);
            this.grpBoxKey.Controls.Add(this.rdoKeyText);
            this.grpBoxKey.Controls.Add(this.txtKeyFile);
            this.grpBoxKey.Controls.Add(this.btBrowse2);
            this.grpBoxKey.Controls.Add(this.rdoFilename);
            this.grpBoxKey.Location = new System.Drawing.Point(6, 360);
            this.grpBoxKey.Name = "grpBoxKey";
            this.grpBoxKey.Size = new System.Drawing.Size(180, 178);
            this.grpBoxKey.TabIndex = 14;
            this.grpBoxKey.TabStop = false;
            this.grpBoxKey.Text = "Key";
            // 
            // btnSaveBitmap
            // 
            this.btnSaveBitmap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBitmap.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveBitmap.Image")));
            this.btnSaveBitmap.Location = new System.Drawing.Point(145, 149);
            this.btnSaveBitmap.Name = "btnSaveBitmap";
            this.btnSaveBitmap.Size = new System.Drawing.Size(23, 23);
            this.btnSaveBitmap.TabIndex = 24;
            this.btnSaveBitmap.Click += new System.EventHandler(this.btnSaveBitmap_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(5, 147);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(113, 25);
            this.btnHide.TabIndex = 5;
            this.btnHide.Text = "Hide Message";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtKeyText
            // 
            this.txtKeyText.Location = new System.Drawing.Point(5, 115);
            this.txtKeyText.Name = "txtKeyText";
            this.txtKeyText.Size = new System.Drawing.Size(163, 26);
            this.txtKeyText.TabIndex = 4;
            this.txtKeyText.TextChanged += new System.EventHandler(this.txtKeyText_TextChanged);
            // 
            // rdoKeyText
            // 
            this.rdoKeyText.AutoSize = true;
            this.rdoKeyText.Checked = true;
            this.rdoKeyText.Location = new System.Drawing.Point(6, 87);
            this.rdoKeyText.Name = "rdoKeyText";
            this.rdoKeyText.Size = new System.Drawing.Size(53, 22);
            this.rdoKeyText.TabIndex = 3;
            this.rdoKeyText.TabStop = true;
            this.rdoKeyText.Text = "Text";
            this.rdoKeyText.UseVisualStyleBackColor = true;
            this.rdoKeyText.CheckedChanged += new System.EventHandler(this.rdoKeyText_CheckedChanged);
            // 
            // txtKeyFile
            // 
            this.txtKeyFile.Enabled = false;
            this.txtKeyFile.Location = new System.Drawing.Point(6, 54);
            this.txtKeyFile.Name = "txtKeyFile";
            this.txtKeyFile.Size = new System.Drawing.Size(162, 26);
            this.txtKeyFile.TabIndex = 2;
            // 
            // btBrowse2
            // 
            this.btBrowse2.Enabled = false;
            this.btBrowse2.Location = new System.Drawing.Point(97, 16);
            this.btBrowse2.Name = "btBrowse2";
            this.btBrowse2.Size = new System.Drawing.Size(71, 32);
            this.btBrowse2.TabIndex = 1;
            this.btBrowse2.Text = "Browse...";
            this.btBrowse2.UseVisualStyleBackColor = true;
            this.btBrowse2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdoFilename
            // 
            this.rdoFilename.AutoSize = true;
            this.rdoFilename.Enabled = false;
            this.rdoFilename.Location = new System.Drawing.Point(6, 26);
            this.rdoFilename.Name = "rdoFilename";
            this.rdoFilename.Size = new System.Drawing.Size(84, 22);
            this.rdoFilename.TabIndex = 0;
            this.rdoFilename.Text = "Filename";
            this.rdoFilename.UseVisualStyleBackColor = true;
            this.rdoFilename.CheckedChanged += new System.EventHandler(this.rdoFilename_CheckedChanged);
            // 
            // btApplyWatermark
            // 
            this.btApplyWatermark.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApplyWatermark.Image = ((System.Drawing.Image)(resources.GetObject("btApplyWatermark.Image")));
            this.btApplyWatermark.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btApplyWatermark.Location = new System.Drawing.Point(8, 544);
            this.btApplyWatermark.Name = "btApplyWatermark";
            this.btApplyWatermark.Size = new System.Drawing.Size(180, 37);
            this.btApplyWatermark.TabIndex = 10;
            this.btApplyWatermark.Text = "Apply Watermark";
            this.btApplyWatermark.UseVisualStyleBackColor = true;
            this.btApplyWatermark.Click += new System.EventHandler(this.BtApplyWatermarkClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.btnExtract);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extracting";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtExtractedMsgFile);
            this.groupBox5.Controls.Add(this.button8);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(6, 455);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(328, 85);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // txtExtractedMsgFile
            // 
            this.txtExtractedMsgFile.Enabled = false;
            this.txtExtractedMsgFile.Location = new System.Drawing.Point(6, 53);
            this.txtExtractedMsgFile.Name = "txtExtractedMsgFile";
            this.txtExtractedMsgFile.Size = new System.Drawing.Size(313, 26);
            this.txtExtractedMsgFile.TabIndex = 12;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(201, 13);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 33);
            this.button8.TabIndex = 11;
            this.button8.Text = "Browse...";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Save Extracted Message to File";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKey2Text);
            this.groupBox2.Controls.Add(this.rdoKey2Text);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtKey2File);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(6, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 145);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key";
            // 
            // txtKey2Text
            // 
            this.txtKey2Text.Location = new System.Drawing.Point(6, 113);
            this.txtKey2Text.Name = "txtKey2Text";
            this.txtKey2Text.Size = new System.Drawing.Size(313, 26);
            this.txtKey2Text.TabIndex = 10;
            // 
            // rdoKey2Text
            // 
            this.rdoKey2Text.AutoSize = true;
            this.rdoKey2Text.Location = new System.Drawing.Point(6, 85);
            this.rdoKey2Text.Name = "rdoKey2Text";
            this.rdoKey2Text.Size = new System.Drawing.Size(53, 22);
            this.rdoKey2Text.TabIndex = 9;
            this.rdoKey2Text.TabStop = true;
            this.rdoKey2Text.Text = "Text";
            this.rdoKey2Text.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(198, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtKey2File
            // 
            this.txtKey2File.Enabled = false;
            this.txtKey2File.Location = new System.Drawing.Point(6, 53);
            this.txtKey2File.Name = "txtKey2File";
            this.txtKey2File.Size = new System.Drawing.Size(313, 26);
            this.txtKey2File.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(6, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 22);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Filename";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(215, 546);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 35);
            this.button6.TabIndex = 4;
            this.button6.Text = "Save As...";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(6, 546);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(121, 35);
            this.btnExtract.TabIndex = 3;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtExtractedMsgText);
            this.groupBox8.Location = new System.Drawing.Point(6, 194);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(328, 110);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Watermarked Text";
            // 
            // txtExtractedMsgText
            // 
            this.txtExtractedMsgText.Location = new System.Drawing.Point(6, 20);
            this.txtExtractedMsgText.Multiline = true;
            this.txtExtractedMsgText.Name = "txtExtractedMsgText";
            this.txtExtractedMsgText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtExtractedMsgText.Size = new System.Drawing.Size(313, 82);
            this.txtExtractedMsgText.TabIndex = 0;
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
            this.groupBox3.Controls.Add(this.btUnmarkallExtract);
            this.groupBox3.Controls.Add(this.listViewImages2);
            this.groupBox3.Controls.Add(this.btMarkallExtract);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 182);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Images";
            // 
            // btUnmarkallExtract
            // 
            this.btUnmarkallExtract.Location = new System.Drawing.Point(209, 143);
            this.btUnmarkallExtract.Name = "btUnmarkallExtract";
            this.btUnmarkallExtract.Size = new System.Drawing.Size(110, 28);
            this.btUnmarkallExtract.TabIndex = 2;
            this.btUnmarkallExtract.Text = "Unmark All";
            this.btUnmarkallExtract.UseVisualStyleBackColor = true;
            this.btUnmarkallExtract.Click += new System.EventHandler(this.btUnmarkallExtract_Click);
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
            // btMarkallExtract
            // 
            this.btMarkallExtract.Location = new System.Drawing.Point(6, 143);
            this.btMarkallExtract.Name = "btMarkallExtract";
            this.btMarkallExtract.Size = new System.Drawing.Size(110, 28);
            this.btMarkallExtract.TabIndex = 1;
            this.btMarkallExtract.Text = "Mark All";
            this.btMarkallExtract.UseVisualStyleBackColor = true;
            this.btMarkallExtract.Click += new System.EventHandler(this.btMarkallExtract_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(72, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(173, 14);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.95305F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.04695F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 440F));
            this.tableLayoutPanel1.Controls.Add(this.lblStatus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.fileinProcess, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Californian FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 713);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(963, 21);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 17);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(525, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(335, 17);
            this.lblDate.TabIndex = 2;
            // 
            // fileinProcess
            // 
            this.fileinProcess.Location = new System.Drawing.Point(349, 0);
            this.fileinProcess.Name = "fileinProcess";
            this.fileinProcess.Size = new System.Drawing.Size(170, 21);
            this.fileinProcess.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(0, 66);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(963, 646);
            this.tabControl2.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.tabControl1);
            this.tabPage3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(955, 615);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Image";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage4.Controls.Add(this.tabControl3);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(955, 615);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Video";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Location = new System.Drawing.Point(2, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(957, 617);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox16);
            this.tabPage5.Controls.Add(this.groupBox15);
            this.tabPage5.Controls.Add(this.button40);
            this.tabPage5.Controls.Add(this.groupBox14);
            this.tabPage5.Controls.Add(this.checkBox1);
            this.tabPage5.Controls.Add(this.checkBox2);
            this.tabPage5.Controls.Add(this.groupBox12);
            this.tabPage5.Controls.Add(this.groupBox13);
            this.tabPage5.Controls.Add(this.groupBox11);
            this.tabPage5.Controls.Add(this.groupBox10);
            this.tabPage5.Controls.Add(this.groupBox9);
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(949, 586);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Marking";
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.btStop);
            this.groupBox16.Controls.Add(this.btExtract);
            this.groupBox16.Controls.Add(this.txtExtBitmap);
            this.groupBox16.Controls.Add(this.label15);
            this.groupBox16.Controls.Add(this.button42);
            this.groupBox16.Location = new System.Drawing.Point(0, 51);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(253, 109);
            this.groupBox16.TabIndex = 24;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Extract";
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(136, 80);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(111, 24);
            this.btStop.TabIndex = 27;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.button44_Click);
            // 
            // btExtract
            // 
            this.btExtract.Location = new System.Drawing.Point(6, 79);
            this.btExtract.Name = "btExtract";
            this.btExtract.Size = new System.Drawing.Size(114, 24);
            this.btExtract.TabIndex = 26;
            this.btExtract.Text = "Extract Bitmaps";
            this.btExtract.UseVisualStyleBackColor = true;
            this.btExtract.Click += new System.EventHandler(this.button43_Click);
            // 
            // txtExtBitmap
            // 
            this.txtExtBitmap.Location = new System.Drawing.Point(8, 50);
            this.txtExtBitmap.Name = "txtExtBitmap";
            this.txtExtBitmap.Size = new System.Drawing.Size(239, 26);
            this.txtExtBitmap.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 18);
            this.label15.TabIndex = 23;
            this.label15.Text = "Extract Bitmap to...";
            // 
            // button42
            // 
            this.button42.Location = new System.Drawing.Point(161, 18);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(86, 26);
            this.button42.TabIndex = 22;
            this.button42.Text = "Browse...";
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.label14);
            this.groupBox15.Controls.Add(this.label16);
            this.groupBox15.Controls.Add(this.textBox8);
            this.groupBox15.Controls.Add(this.label17);
            this.groupBox15.Controls.Add(this.checkBox3);
            this.groupBox15.Controls.Add(this.button41);
            this.groupBox15.Controls.Add(this.textBox9);
            this.groupBox15.Controls.Add(this.label18);
            this.groupBox15.Enabled = false;
            this.groupBox15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.Location = new System.Drawing.Point(0, 443);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(376, 137);
            this.groupBox15.TabIndex = 21;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Output Settings";
            // 
            // label14
            // 
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.Location = new System.Drawing.Point(332, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 23);
            this.label14.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.Enabled = false;
            this.label16.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(247, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 35);
            this.label16.TabIndex = 20;
            this.label16.Text = "after file \r\nnames.";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(89, 44);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(153, 26);
            this.textBox8.TabIndex = 19;
            this.textBox8.Text = "_Marked";
            // 
            // label17
            // 
            this.label17.Enabled = false;
            this.label17.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 23);
            this.label17.TabIndex = 18;
            this.label17.Text = "Add suffix";
            // 
            // checkBox3
            // 
            this.checkBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(6, 18);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(291, 24);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "Use the previous location as Output Folder ";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button41
            // 
            this.button41.Location = new System.Drawing.Point(250, 93);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(34, 26);
            this.button41.TabIndex = 16;
            this.button41.Text = "...";
            this.button41.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(89, 93);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(153, 26);
            this.textBox9.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 35);
            this.label18.TabIndex = 14;
            this.label18.Text = "Output \r\nFolder";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // button40
            // 
            this.button40.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button40.Image = ((System.Drawing.Image)(resources.GetObject("button40.Image")));
            this.button40.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button40.Location = new System.Drawing.Point(38, 400);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(180, 37);
            this.button40.TabIndex = 20;
            this.button40.Text = "Apply Watermark";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.txtVFile);
            this.groupBox14.Location = new System.Drawing.Point(2, 3);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(251, 48);
            this.groupBox14.TabIndex = 19;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Videofile";
            // 
            // txtVFile
            // 
            this.txtVFile.Location = new System.Drawing.Point(6, 16);
            this.txtVFile.Name = "txtVFile";
            this.txtVFile.Size = new System.Drawing.Size(239, 26);
            this.txtVFile.TabIndex = 0;
            this.txtVFile.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(6, 186);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(179, 22);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Produce Grayscale Noise";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(6, 166);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 22);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Hide Mesaage";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label13);
            this.groupBox12.Controls.Add(this.label12);
            this.groupBox12.Controls.Add(this.button29);
            this.groupBox12.Controls.Add(this.textBox5);
            this.groupBox12.Controls.Add(this.radioButton2);
            this.groupBox12.Controls.Add(this.textBox6);
            this.groupBox12.Controls.Add(this.button39);
            this.groupBox12.Controls.Add(this.radioButton3);
            this.groupBox12.Enabled = false;
            this.groupBox12.Location = new System.Drawing.Point(0, 208);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(253, 186);
            this.groupBox12.TabIndex = 15;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Key";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(142, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "Save As...";
            // 
            // label12
            // 
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(224, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 23);
            this.label12.TabIndex = 24;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(6, 142);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(104, 35);
            this.button29.TabIndex = 5;
            this.button29.Text = "Hide Message";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 106);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(241, 26);
            this.textBox5.TabIndex = 4;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 80);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 22);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Text";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 48);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(241, 26);
            this.textBox6.TabIndex = 2;
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(161, 16);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(86, 26);
            this.button39.TabIndex = 1;
            this.button39.Text = "Browse...";
            this.button39.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(84, 22);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "Filename";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.btvBottomRight);
            this.groupBox13.Controls.Add(this.btvBottomMiddle);
            this.groupBox13.Controls.Add(this.btvBottomLeft);
            this.groupBox13.Controls.Add(this.btvMiddleRight);
            this.groupBox13.Controls.Add(this.btvCenter);
            this.groupBox13.Controls.Add(this.btvMiddleLeft);
            this.groupBox13.Controls.Add(this.btvTopRight);
            this.groupBox13.Controls.Add(this.btvTopMiddle);
            this.groupBox13.Controls.Add(this.btVTopLeft);
            this.groupBox13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(382, 443);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(180, 137);
            this.groupBox13.TabIndex = 9;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Text Position";
            // 
            // btvBottomRight
            // 
            this.btvBottomRight.Location = new System.Drawing.Point(118, 108);
            this.btvBottomRight.Name = "btvBottomRight";
            this.btvBottomRight.Size = new System.Drawing.Size(50, 23);
            this.btvBottomRight.TabIndex = 8;
            this.btvBottomRight.UseVisualStyleBackColor = true;
            this.btvBottomRight.Click += new System.EventHandler(this.btvBottomRight_Click);
            // 
            // btvBottomMiddle
            // 
            this.btvBottomMiddle.Location = new System.Drawing.Point(62, 108);
            this.btvBottomMiddle.Name = "btvBottomMiddle";
            this.btvBottomMiddle.Size = new System.Drawing.Size(56, 23);
            this.btvBottomMiddle.TabIndex = 7;
            this.btvBottomMiddle.UseVisualStyleBackColor = true;
            this.btvBottomMiddle.Click += new System.EventHandler(this.btvBottomMiddle_Click);
            // 
            // btvBottomLeft
            // 
            this.btvBottomLeft.Location = new System.Drawing.Point(12, 108);
            this.btvBottomLeft.Name = "btvBottomLeft";
            this.btvBottomLeft.Size = new System.Drawing.Size(50, 23);
            this.btvBottomLeft.TabIndex = 6;
            this.btvBottomLeft.UseVisualStyleBackColor = true;
            this.btvBottomLeft.Click += new System.EventHandler(this.btvBottomLeft_Click);
            // 
            // btvMiddleRight
            // 
            this.btvMiddleRight.Location = new System.Drawing.Point(136, 41);
            this.btvMiddleRight.Name = "btvMiddleRight";
            this.btvMiddleRight.Size = new System.Drawing.Size(32, 67);
            this.btvMiddleRight.TabIndex = 5;
            this.btvMiddleRight.UseVisualStyleBackColor = true;
            this.btvMiddleRight.Click += new System.EventHandler(this.btvMiddleRight_Click);
            // 
            // btvCenter
            // 
            this.btvCenter.Location = new System.Drawing.Point(46, 41);
            this.btvCenter.Name = "btvCenter";
            this.btvCenter.Size = new System.Drawing.Size(90, 67);
            this.btvCenter.TabIndex = 4;
            this.btvCenter.UseVisualStyleBackColor = true;
            this.btvCenter.Click += new System.EventHandler(this.btvCenter_Click);
            // 
            // btvMiddleLeft
            // 
            this.btvMiddleLeft.Location = new System.Drawing.Point(12, 41);
            this.btvMiddleLeft.Name = "btvMiddleLeft";
            this.btvMiddleLeft.Size = new System.Drawing.Size(32, 67);
            this.btvMiddleLeft.TabIndex = 3;
            this.btvMiddleLeft.UseVisualStyleBackColor = true;
            this.btvMiddleLeft.Click += new System.EventHandler(this.btvMiddleLeft_Click);
            // 
            // btvTopRight
            // 
            this.btvTopRight.Location = new System.Drawing.Point(119, 18);
            this.btvTopRight.Name = "btvTopRight";
            this.btvTopRight.Size = new System.Drawing.Size(50, 23);
            this.btvTopRight.TabIndex = 2;
            this.btvTopRight.UseVisualStyleBackColor = true;
            this.btvTopRight.Click += new System.EventHandler(this.btvTopRight_Click);
            // 
            // btvTopMiddle
            // 
            this.btvTopMiddle.Location = new System.Drawing.Point(62, 18);
            this.btvTopMiddle.Name = "btvTopMiddle";
            this.btvTopMiddle.Size = new System.Drawing.Size(56, 23);
            this.btvTopMiddle.TabIndex = 1;
            this.btvTopMiddle.UseVisualStyleBackColor = true;
            this.btvTopMiddle.Click += new System.EventHandler(this.btvTopMiddle_Click);
            // 
            // btVTopLeft
            // 
            this.btVTopLeft.Location = new System.Drawing.Point(12, 18);
            this.btVTopLeft.Name = "btVTopLeft";
            this.btVTopLeft.Size = new System.Drawing.Size(50, 23);
            this.btVTopLeft.TabIndex = 0;
            this.btVTopLeft.UseVisualStyleBackColor = true;
            this.btVTopLeft.Click += new System.EventHandler(this.btVTopLeft_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.picBoxPreview3);
            this.groupBox11.Enabled = false;
            this.groupBox11.Location = new System.Drawing.Point(259, 208);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(303, 233);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Preview";
            // 
            // picBoxPreview3
            // 
            this.picBoxPreview3.BackColor = System.Drawing.Color.White;
            this.picBoxPreview3.Location = new System.Drawing.Point(6, 17);
            this.picBoxPreview3.Name = "picBoxPreview3";
            this.picBoxPreview3.Size = new System.Drawing.Size(291, 210);
            this.picBoxPreview3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPreview3.TabIndex = 0;
            this.picBoxPreview3.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblCnt);
            this.groupBox10.Controls.Add(this.label6);
            this.groupBox10.Location = new System.Drawing.Point(259, 158);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(303, 50);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Show Frames";
            // 
            // lblCnt
            // 
            this.lblCnt.Location = new System.Drawing.Point(174, 22);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(123, 18);
            this.lblCnt.TabIndex = 7;
            this.lblCnt.Text = "Cnt";
            this.lblCnt.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "No. of Frames Extracted";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtVOpacity);
            this.groupBox9.Controls.Add(this.trackBarVOpacity);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Controls.Add(this.btVColor);
            this.groupBox9.Controls.Add(this.btVFont);
            this.groupBox9.Controls.Add(this.txtVWatermark);
            this.groupBox9.Location = new System.Drawing.Point(259, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(303, 149);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Watermark Text";
            // 
            // txtVOpacity
            // 
            this.txtVOpacity.Location = new System.Drawing.Point(268, 115);
            this.txtVOpacity.Name = "txtVOpacity";
            this.txtVOpacity.Size = new System.Drawing.Size(29, 26);
            this.txtVOpacity.TabIndex = 5;
            this.txtVOpacity.Text = "100";
            this.txtVOpacity.TextChanged += new System.EventHandler(this.txtVOpacity_TextChanged);
            // 
            // trackBarVOpacity
            // 
            this.trackBarVOpacity.AutoSize = false;
            this.trackBarVOpacity.Location = new System.Drawing.Point(65, 115);
            this.trackBarVOpacity.Maximum = 255;
            this.trackBarVOpacity.Name = "trackBarVOpacity";
            this.trackBarVOpacity.Size = new System.Drawing.Size(208, 26);
            this.trackBarVOpacity.TabIndex = 5;
            this.trackBarVOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVOpacity.Value = 100;
            this.trackBarVOpacity.Scroll += new System.EventHandler(this.trackBarVOpacity_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Opacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Text";
            // 
            // btVColor
            // 
            this.btVColor.Location = new System.Drawing.Point(6, 80);
            this.btVColor.Name = "btVColor";
            this.btVColor.Size = new System.Drawing.Size(53, 26);
            this.btVColor.TabIndex = 6;
            this.btVColor.Text = "Color";
            this.btVColor.UseVisualStyleBackColor = true;
            this.btVColor.Click += new System.EventHandler(this.btVColor_Click);
            // 
            // btVFont
            // 
            this.btVFont.Location = new System.Drawing.Point(6, 48);
            this.btVFont.Name = "btVFont";
            this.btVFont.Size = new System.Drawing.Size(53, 26);
            this.btVFont.TabIndex = 5;
            this.btVFont.Text = "Font...";
            this.btVFont.UseVisualStyleBackColor = true;
            this.btVFont.Click += new System.EventHandler(this.btVFont_Click);
            // 
            // txtVWatermark
            // 
            this.txtVWatermark.Location = new System.Drawing.Point(65, 16);
            this.txtVWatermark.Multiline = true;
            this.txtVWatermark.Name = "txtVWatermark";
            this.txtVWatermark.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtVWatermark.Size = new System.Drawing.Size(232, 90);
            this.txtVWatermark.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.picBoxFrame);
            this.groupBox6.Location = new System.Drawing.Point(568, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(375, 205);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Frames";
            // 
            // picBoxFrame
            // 
            this.picBoxFrame.BackColor = System.Drawing.Color.White;
            this.picBoxFrame.Location = new System.Drawing.Point(8, 16);
            this.picBoxFrame.Name = "picBoxFrame";
            this.picBoxFrame.Size = new System.Drawing.Size(361, 183);
            this.picBoxFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFrame.TabIndex = 0;
            this.picBoxFrame.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBox4.Location = new System.Drawing.Point(568, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 372);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(8, 17);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(361, 348);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Location = new System.Drawing.Point(4, 27);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(949, 586);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Extracting";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(29, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "100";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Color";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 26);
            this.button5.TabIndex = 4;
            this.button5.Text = "Font...";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opacity";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(232, 90);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Text";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(65, 117);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(208, 26);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(118, 108);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 23);
            this.button7.TabIndex = 8;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(62, 108);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 23);
            this.button9.TabIndex = 7;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 108);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 23);
            this.button10.TabIndex = 6;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(136, 41);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(32, 67);
            this.button11.TabIndex = 5;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(46, 41);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(90, 67);
            this.button12.TabIndex = 4;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(12, 41);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(32, 67);
            this.button13.TabIndex = 3;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(119, 18);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(50, 23);
            this.button14.TabIndex = 2;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(62, 18);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(56, 23);
            this.button15.TabIndex = 1;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(12, 18);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(50, 23);
            this.button16.TabIndex = 0;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(118, 108);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(50, 23);
            this.button20.TabIndex = 8;
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(62, 108);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(56, 23);
            this.button21.TabIndex = 7;
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(12, 108);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(50, 23);
            this.button22.TabIndex = 6;
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(136, 41);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(32, 67);
            this.button23.TabIndex = 5;
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(46, 41);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(90, 67);
            this.button24.TabIndex = 4;
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(12, 41);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(32, 67);
            this.button25.TabIndex = 3;
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(119, 18);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(50, 23);
            this.button26.TabIndex = 2;
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(62, 18);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(56, 23);
            this.button27.TabIndex = 1;
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(12, 18);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(50, 23);
            this.button28.TabIndex = 0;
            this.button28.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(323, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "For Further Extension";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 734);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
            this.tabPage1.PerformLayout();
            this.grpBoxKey.ResumeLayout(false);
            this.grpBoxKey.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImagePreview2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPreview3)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVOpacity)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrame)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
		private System.Windows.Forms.PictureBox picBoxImagePreview2;
		private System.Windows.Forms.ListView listViewImages2;
		private System.Windows.Forms.Label lblSave;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.TextBox txtExtractedMsgText;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Button btnExtract;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button btMarkallExtract;
		private System.Windows.Forms.Button btUnmarkallExtract;
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
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExternallyToolStripMenuItem;
        private System.Windows.Forms.Label fileinProcess;
        private VistaStyleProgressBar.ProgressBar progressBar2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtKey2Text;
        private System.Windows.Forms.RadioButton rdoKey2Text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtKey2File;
        private System.Windows.Forms.CheckBox chkGrayscale;
        private System.Windows.Forms.CheckBox chkHideMessage;
        private System.Windows.Forms.GroupBox grpBoxKey;
        private System.Windows.Forms.TextBox txtKeyFile;
        private System.Windows.Forms.Button btBrowse2;
        private System.Windows.Forms.RadioButton rdoFilename;
        private System.Windows.Forms.RadioButton rdoKeyText;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.TextBox txtKeyText;
        private System.Windows.Forms.Label btnSaveBitmap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtExtractedMsgFile;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox picBoxFrame;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtVWatermark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btVColor;
        private System.Windows.Forms.Button btVFont;
        private System.Windows.Forms.TextBox txtVOpacity;
        private System.Windows.Forms.TrackBar trackBarVOpacity;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button btvBottomRight;
        private System.Windows.Forms.Button btvBottomMiddle;
        private System.Windows.Forms.Button btvBottomLeft;
        private System.Windows.Forms.Button btvMiddleRight;
        private System.Windows.Forms.Button btvCenter;
        private System.Windows.Forms.Button btvMiddleLeft;
        private System.Windows.Forms.Button btvTopRight;
        private System.Windows.Forms.Button btvTopMiddle;
        private System.Windows.Forms.Button btVTopLeft;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox txtVFile;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button btExtract;
        private System.Windows.Forms.TextBox txtExtBitmap;
        private System.Windows.Forms.Button btStop;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.PictureBox picBoxPreview3;
        private System.Windows.Forms.Label label7;
	}
}
