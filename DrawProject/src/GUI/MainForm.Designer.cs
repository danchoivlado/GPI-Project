namespace Draw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.elipseStrButton = new System.Windows.Forms.ToolStripButton();
            this.triangleStrBtn = new System.Windows.Forms.ToolStripButton();
            this.fillColorStripButton = new System.Windows.Forms.ToolStripButton();
            this.borderColorButton = new System.Windows.Forms.ToolStripButton();
            this.exampleFigure = new System.Windows.Forms.ToolStripButton();
            this.groupSelectedButton = new System.Windows.Forms.ToolStripButton();
            this.removeGroupButton = new System.Windows.Forms.ToolStripButton();
            this.examShape9 = new System.Windows.Forms.ToolStripButton();
            this.examShapPolygon = new System.Windows.Forms.ToolStripButton();
            this.examShapeZero = new System.Windows.Forms.ToolStripButton();
            this.examShapeOne = new System.Windows.Forms.ToolStripButton();
            this.examShapeEight = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bordeWodthTextBox = new System.Windows.Forms.TextBox();
            this.borderWidthLabel = new System.Windows.Forms.Label();
            this.borderWidthButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.examShapeFive = new System.Windows.Forms.ToolStripButton();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.examShapeTwo = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(938, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 401);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(938, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // speedMenu
            // 
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawRectangleSpeedButton,
            this.pickUpSpeedButton,
            this.elipseStrButton,
            this.triangleStrBtn,
            this.fillColorStripButton,
            this.borderColorButton,
            this.exampleFigure,
            this.groupSelectedButton,
            this.removeGroupButton,
            this.examShape9,
            this.examShapPolygon,
            this.examShapeZero,
            this.examShapeOne,
            this.examShapeEight,
            this.examShapeFive,
            this.examShapeTwo});
            this.speedMenu.Location = new System.Drawing.Point(0, 24);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(938, 25);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            // 
            // elipseStrButton
            // 
            this.elipseStrButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.elipseStrButton.Image = ((System.Drawing.Image)(resources.GetObject("elipseStrButton.Image")));
            this.elipseStrButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.elipseStrButton.Name = "elipseStrButton";
            this.elipseStrButton.Size = new System.Drawing.Size(23, 22);
            this.elipseStrButton.Text = "toolStripButton1";
            this.elipseStrButton.Click += new System.EventHandler(this.elipseStrButton_Click);
            // 
            // triangleStrBtn
            // 
            this.triangleStrBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.triangleStrBtn.Image = ((System.Drawing.Image)(resources.GetObject("triangleStrBtn.Image")));
            this.triangleStrBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.triangleStrBtn.Name = "triangleStrBtn";
            this.triangleStrBtn.Size = new System.Drawing.Size(23, 22);
            this.triangleStrBtn.Text = "toolStripButton1";
            this.triangleStrBtn.Click += new System.EventHandler(this.triangleStrBtn_Click);
            // 
            // fillColorStripButton
            // 
            this.fillColorStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillColorStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fillColorStripButton.Image")));
            this.fillColorStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillColorStripButton.Name = "fillColorStripButton";
            this.fillColorStripButton.Size = new System.Drawing.Size(23, 22);
            this.fillColorStripButton.Text = "toolStripButton1";
            this.fillColorStripButton.Click += new System.EventHandler(this.fillColorStripButton_Click);
            // 
            // borderColorButton
            // 
            this.borderColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.borderColorButton.Image = ((System.Drawing.Image)(resources.GetObject("borderColorButton.Image")));
            this.borderColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.borderColorButton.Name = "borderColorButton";
            this.borderColorButton.Size = new System.Drawing.Size(23, 22);
            this.borderColorButton.Text = "toolStripButton1";
            this.borderColorButton.Click += new System.EventHandler(this.borderColorButton_Click);
            // 
            // exampleFigure
            // 
            this.exampleFigure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exampleFigure.Image = ((System.Drawing.Image)(resources.GetObject("exampleFigure.Image")));
            this.exampleFigure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exampleFigure.Name = "exampleFigure";
            this.exampleFigure.Size = new System.Drawing.Size(23, 22);
            this.exampleFigure.Text = "toolStripButton1";
            this.exampleFigure.Click += new System.EventHandler(this.exampleFigure_Click);
            // 
            // groupSelectedButton
            // 
            this.groupSelectedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupSelectedButton.Image = ((System.Drawing.Image)(resources.GetObject("groupSelectedButton.Image")));
            this.groupSelectedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groupSelectedButton.Name = "groupSelectedButton";
            this.groupSelectedButton.Size = new System.Drawing.Size(23, 22);
            this.groupSelectedButton.Text = "toolStripButton1";
            this.groupSelectedButton.Click += new System.EventHandler(this.groupSelectedButton_Click);
            // 
            // removeGroupButton
            // 
            this.removeGroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeGroupButton.Image = ((System.Drawing.Image)(resources.GetObject("removeGroupButton.Image")));
            this.removeGroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeGroupButton.Name = "removeGroupButton";
            this.removeGroupButton.Size = new System.Drawing.Size(23, 22);
            this.removeGroupButton.Text = "toolStripButton1";
            this.removeGroupButton.Click += new System.EventHandler(this.removeGroupButton_Click);
            // 
            // examShape9
            // 
            this.examShape9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.examShape9.Image = ((System.Drawing.Image)(resources.GetObject("examShape9.Image")));
            this.examShape9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.examShape9.Name = "examShape9";
            this.examShape9.Size = new System.Drawing.Size(23, 22);
            this.examShape9.Text = "examShape9";
            this.examShape9.Click += new System.EventHandler(this.examShape9_Click);
            // 
            // examShapPolygon
            // 
            this.examShapPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.examShapPolygon.Image = ((System.Drawing.Image)(resources.GetObject("examShapPolygon.Image")));
            this.examShapPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.examShapPolygon.Name = "examShapPolygon";
            this.examShapPolygon.Size = new System.Drawing.Size(23, 22);
            this.examShapPolygon.Text = "examShapPolygon";
            this.examShapPolygon.Click += new System.EventHandler(this.examShapPolygon_Click);
            // 
            // examShapeZero
            // 
            this.examShapeZero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.examShapeZero.Image = ((System.Drawing.Image)(resources.GetObject("examShapeZero.Image")));
            this.examShapeZero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.examShapeZero.Name = "examShapeZero";
            this.examShapeZero.Size = new System.Drawing.Size(23, 22);
            this.examShapeZero.Text = "examShapeZeroButton";
            this.examShapeZero.Click += new System.EventHandler(this.examShapeZero_Click);
            // 
            // examShapeOne
            // 
            this.examShapeOne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.examShapeOne.Image = ((System.Drawing.Image)(resources.GetObject("examShapeOne.Image")));
            this.examShapeOne.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.examShapeOne.Name = "examShapeOne";
            this.examShapeOne.Size = new System.Drawing.Size(23, 22);
            this.examShapeOne.Text = "examShapeOne";
            this.examShapeOne.Click += new System.EventHandler(this.examShapeOne_Click);
            // 
            // examShapeEight
            // 
            this.examShapeEight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.examShapeEight.Image = ((System.Drawing.Image)(resources.GetObject("examShapeEight.Image")));
            this.examShapeEight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.examShapeEight.Name = "examShapeEight";
            this.examShapeEight.Size = new System.Drawing.Size(23, 22);
            this.examShapeEight.Text = "examShapeEight";
            this.examShapeEight.Click += new System.EventHandler(this.examShapeEight_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bordeWodthTextBox
            // 
            this.bordeWodthTextBox.Location = new System.Drawing.Point(523, 4);
            this.bordeWodthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.bordeWodthTextBox.Name = "bordeWodthTextBox";
            this.bordeWodthTextBox.Size = new System.Drawing.Size(42, 20);
            this.bordeWodthTextBox.TabIndex = 11;
            // 
            // borderWidthLabel
            // 
            this.borderWidthLabel.AutoSize = true;
            this.borderWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borderWidthLabel.Location = new System.Drawing.Point(527, 26);
            this.borderWidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.borderWidthLabel.Name = "borderWidthLabel";
            this.borderWidthLabel.Size = new System.Drawing.Size(95, 18);
            this.borderWidthLabel.TabIndex = 10;
            this.borderWidthLabel.Text = "Border Width";
            // 
            // borderWidthButton
            // 
            this.borderWidthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borderWidthButton.Location = new System.Drawing.Point(568, 4);
            this.borderWidthButton.Margin = new System.Windows.Forms.Padding(2);
            this.borderWidthButton.Name = "borderWidthButton";
            this.borderWidthButton.Size = new System.Drawing.Size(43, 18);
            this.borderWidthButton.TabIndex = 12;
            this.borderWidthButton.Text = "set";
            this.borderWidthButton.UseVisualStyleBackColor = true;
            this.borderWidthButton.Click += new System.EventHandler(this.borderWidthButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(648, 4);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(177, 45);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Tag = "";
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 255;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(713, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Opacity";
            // 
            // examShapeFive
            // 
            this.examShapeFive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.examShapeFive.Image = ((System.Drawing.Image)(resources.GetObject("examShapeFive.Image")));
            this.examShapeFive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.examShapeFive.Name = "examShapeFive";
            this.examShapeFive.Size = new System.Drawing.Size(23, 22);
            this.examShapeFive.Text = "examShapeFive";
            this.examShapeFive.Click += new System.EventHandler(this.examShapeFive_Click);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 49);
            this.viewPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(938, 352);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // examShapeTwo
            // 
            this.examShapeTwo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.examShapeTwo.Image = ((System.Drawing.Image)(resources.GetObject("examShapeTwo.Image")));
            this.examShapeTwo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.examShapeTwo.Name = "examShapeTwo";
            this.examShapeTwo.Size = new System.Drawing.Size(23, 22);
            this.examShapeTwo.Text = "examShapeTwo";
            this.examShapeTwo.Click += new System.EventHandler(this.examShapeTwo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 423);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.borderWidthButton);
            this.Controls.Add(this.bordeWodthTextBox);
            this.Controls.Add(this.borderWidthLabel);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton elipseStrButton;
        private System.Windows.Forms.ToolStripButton triangleStrBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton fillColorStripButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton borderColorButton;
        private System.Windows.Forms.ToolStripButton exampleFigure;
        private System.Windows.Forms.ToolStripButton groupSelectedButton;
        private System.Windows.Forms.ToolStripButton removeGroupButton;
        private System.Windows.Forms.TextBox bordeWodthTextBox;
        private System.Windows.Forms.Label borderWidthLabel;
        private System.Windows.Forms.Button borderWidthButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton examShape9;
        private System.Windows.Forms.ToolStripButton examShapPolygon;
        private System.Windows.Forms.ToolStripButton examShapeZero;
        private System.Windows.Forms.ToolStripButton examShapeOne;
        private System.Windows.Forms.ToolStripButton examShapeEight;
        private System.Windows.Forms.ToolStripButton examShapeFive;
        private System.Windows.Forms.ToolStripButton examShapeTwo;
    }
}
