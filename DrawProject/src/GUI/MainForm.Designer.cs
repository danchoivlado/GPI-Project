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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.Resize = new System.Windows.Forms.Button();
            this.bordeWodthTextBox = new System.Windows.Forms.TextBox();
            this.borderWidthLabel = new System.Windows.Forms.Label();
            this.borderWidthButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mainMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mainMenu.Size = new System.Drawing.Size(1201, 25);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
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
            this.statusBar.Location = new System.Drawing.Point(0, 629);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusBar.Size = new System.Drawing.Size(1201, 22);
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
            this.removeGroupButton});
            this.speedMenu.Location = new System.Drawing.Point(0, 25);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.speedMenu.Size = new System.Drawing.Size(1201, 25);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthLabel.Location = new System.Drawing.Point(375, 38);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(56, 22);
            this.widthLabel.TabIndex = 5;
            this.widthLabel.Text = "Width";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(485, 38);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(61, 26);
            this.widthTextBox.TabIndex = 6;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(485, 0);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(61, 26);
            this.heightTextBox.TabIndex = 8;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.Location = new System.Drawing.Point(375, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(62, 22);
            this.heightLabel.TabIndex = 7;
            this.heightLabel.Text = "Height";
            // 
            // Resize
            // 
            this.Resize.Location = new System.Drawing.Point(574, 8);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(90, 52);
            this.Resize.TabIndex = 9;
            this.Resize.Text = "Resize";
            this.Resize.UseVisualStyleBackColor = true;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // bordeWodthTextBox
            // 
            this.bordeWodthTextBox.Location = new System.Drawing.Point(707, 8);
            this.bordeWodthTextBox.Name = "bordeWodthTextBox";
            this.bordeWodthTextBox.Size = new System.Drawing.Size(61, 26);
            this.bordeWodthTextBox.TabIndex = 11;
            // 
            // borderWidthLabel
            // 
            this.borderWidthLabel.AutoSize = true;
            this.borderWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borderWidthLabel.Location = new System.Drawing.Point(714, 42);
            this.borderWidthLabel.Name = "borderWidthLabel";
            this.borderWidthLabel.Size = new System.Drawing.Size(95, 18);
            this.borderWidthLabel.TabIndex = 10;
            this.borderWidthLabel.Text = "Border Width";
            // 
            // borderWidthButton
            // 
            this.borderWidthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.borderWidthButton.Location = new System.Drawing.Point(774, 8);
            this.borderWidthButton.Name = "borderWidthButton";
            this.borderWidthButton.Size = new System.Drawing.Size(64, 27);
            this.borderWidthButton.TabIndex = 12;
            this.borderWidthButton.Text = "set";
            this.borderWidthButton.UseVisualStyleBackColor = true;
            this.borderWidthButton.Click += new System.EventHandler(this.borderWidthButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(894, 8);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(266, 45);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.Tag = "";
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 255;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(991, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Opacity";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 50);
            this.viewPort.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(1201, 579);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 651);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.borderWidthButton);
            this.Controls.Add(this.bordeWodthTextBox);
            this.Controls.Add(this.borderWidthLabel);
            this.Controls.Add(this.Resize);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button Resize;
        private System.Windows.Forms.TextBox bordeWodthTextBox;
        private System.Windows.Forms.Label borderWidthLabel;
        private System.Windows.Forms.Button borderWidthButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
