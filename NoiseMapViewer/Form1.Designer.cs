namespace NoiseMapViewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Position = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_Pictures = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Up = new System.Windows.Forms.Button();
            this.button_Down = new System.Windows.Forms.Button();
            this.button_Left = new System.Windows.Forms.Button();
            this.button_Right = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Reload = new System.Windows.Forms.Button();
            this.label_YPos = new System.Windows.Forms.Label();
            this.numericUpDown_YPos = new System.Windows.Forms.NumericUpDown();
            this.label_X = new System.Windows.Forms.Label();
            this.numericUpDown_XPos = new System.Windows.Forms.NumericUpDown();
            this.label_Tiles = new System.Windows.Forms.Label();
            this.numericUpDown_Tiles = new System.Windows.Forms.NumericUpDown();
            this.button_ZoomOut = new System.Windows.Forms.Button();
            this.button_ZoomIn = new System.Windows.Forms.Button();
            this.comboBox_TileSize = new System.Windows.Forms.ComboBox();
            this.comboBox_Zoom = new System.Windows.Forms.ComboBox();
            this.comboBox_Seed = new System.Windows.Forms.ComboBox();
            this.button_Load = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_YPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_XPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tiles)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Position});
            this.statusStrip1.Location = new System.Drawing.Point(0, 324);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(480, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Position
            // 
            this.toolStripStatusLabel_Position.Name = "toolStripStatusLabel_Position";
            this.toolStripStatusLabel_Position.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel_Position.Text = "toolStripStatusLabel1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel_Pictures);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(335, 263);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.SizeChanged += new System.EventHandler(this.flowLayoutPanel1_SizeChanged);
            // 
            // flowLayoutPanel_Pictures
            // 
            this.flowLayoutPanel_Pictures.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel_Pictures.Name = "flowLayoutPanel_Pictures";
            this.flowLayoutPanel_Pictures.Size = new System.Drawing.Size(297, 297);
            this.flowLayoutPanel_Pictures.TabIndex = 0;
            // 
            // button_Up
            // 
            this.button_Up.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Up.Location = new System.Drawing.Point(35, 3);
            this.button_Up.Name = "button_Up";
            this.button_Up.Size = new System.Drawing.Size(25, 25);
            this.button_Up.TabIndex = 4;
            this.button_Up.Text = "é";
            this.button_Up.UseVisualStyleBackColor = true;
            this.button_Up.Click += new System.EventHandler(this.button_Up_Click);
            // 
            // button_Down
            // 
            this.button_Down.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Down.Location = new System.Drawing.Point(35, 65);
            this.button_Down.Name = "button_Down";
            this.button_Down.Size = new System.Drawing.Size(25, 25);
            this.button_Down.TabIndex = 6;
            this.button_Down.Text = "ê";
            this.button_Down.UseVisualStyleBackColor = true;
            this.button_Down.Click += new System.EventHandler(this.button_Down_Click);
            // 
            // button_Left
            // 
            this.button_Left.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Left.Location = new System.Drawing.Point(4, 34);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(25, 25);
            this.button_Left.TabIndex = 7;
            this.button_Left.Text = "ç";
            this.button_Left.UseVisualStyleBackColor = true;
            this.button_Left.Click += new System.EventHandler(this.button_Left_Click);
            // 
            // button_Right
            // 
            this.button_Right.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Right.Location = new System.Drawing.Point(66, 34);
            this.button_Right.Name = "button_Right";
            this.button_Right.Size = new System.Drawing.Size(25, 25);
            this.button_Right.TabIndex = 8;
            this.button_Right.Text = "è";
            this.button_Right.UseVisualStyleBackColor = true;
            this.button_Right.Click += new System.EventHandler(this.button_Right_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Reload);
            this.panel1.Controls.Add(this.label_YPos);
            this.panel1.Controls.Add(this.numericUpDown_YPos);
            this.panel1.Controls.Add(this.label_X);
            this.panel1.Controls.Add(this.numericUpDown_XPos);
            this.panel1.Controls.Add(this.label_Tiles);
            this.panel1.Controls.Add(this.numericUpDown_Tiles);
            this.panel1.Controls.Add(this.button_ZoomOut);
            this.panel1.Controls.Add(this.button_ZoomIn);
            this.panel1.Controls.Add(this.button_Left);
            this.panel1.Controls.Add(this.button_Up);
            this.panel1.Controls.Add(this.button_Right);
            this.panel1.Controls.Add(this.button_Down);
            this.panel1.Location = new System.Drawing.Point(353, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 263);
            this.panel1.TabIndex = 10;
            // 
            // button_Reload
            // 
            this.button_Reload.Location = new System.Drawing.Point(4, 228);
            this.button_Reload.Name = "button_Reload";
            this.button_Reload.Size = new System.Drawing.Size(87, 23);
            this.button_Reload.TabIndex = 17;
            this.button_Reload.Text = "Reload";
            this.button_Reload.UseVisualStyleBackColor = true;
            this.button_Reload.Click += new System.EventHandler(this.button_Reload_Click);
            // 
            // label_YPos
            // 
            this.label_YPos.AutoSize = true;
            this.label_YPos.Location = new System.Drawing.Point(9, 201);
            this.label_YPos.Name = "label_YPos";
            this.label_YPos.Size = new System.Drawing.Size(36, 15);
            this.label_YPos.TabIndex = 16;
            this.label_YPos.Text = "Y Pos";
            // 
            // numericUpDown_YPos
            // 
            this.numericUpDown_YPos.Location = new System.Drawing.Point(45, 199);
            this.numericUpDown_YPos.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_YPos.Name = "numericUpDown_YPos";
            this.numericUpDown_YPos.Size = new System.Drawing.Size(46, 23);
            this.numericUpDown_YPos.TabIndex = 15;
            this.numericUpDown_YPos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_YPos.ValueChanged += new System.EventHandler(this.UpdateNumericValues);
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(9, 172);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(36, 15);
            this.label_X.TabIndex = 14;
            this.label_X.Text = "X Pos";
            // 
            // numericUpDown_XPos
            // 
            this.numericUpDown_XPos.Location = new System.Drawing.Point(45, 170);
            this.numericUpDown_XPos.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_XPos.Name = "numericUpDown_XPos";
            this.numericUpDown_XPos.Size = new System.Drawing.Size(46, 23);
            this.numericUpDown_XPos.TabIndex = 13;
            this.numericUpDown_XPos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_XPos.ValueChanged += new System.EventHandler(this.UpdateNumericValues);
            // 
            // label_Tiles
            // 
            this.label_Tiles.AutoSize = true;
            this.label_Tiles.Location = new System.Drawing.Point(9, 143);
            this.label_Tiles.Name = "label_Tiles";
            this.label_Tiles.Size = new System.Drawing.Size(30, 15);
            this.label_Tiles.TabIndex = 12;
            this.label_Tiles.Text = "Tiles";
            // 
            // numericUpDown_Tiles
            // 
            this.numericUpDown_Tiles.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_Tiles.Location = new System.Drawing.Point(45, 141);
            this.numericUpDown_Tiles.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown_Tiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Tiles.Name = "numericUpDown_Tiles";
            this.numericUpDown_Tiles.Size = new System.Drawing.Size(46, 23);
            this.numericUpDown_Tiles.TabIndex = 11;
            this.numericUpDown_Tiles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Tiles.ValueChanged += new System.EventHandler(this.UpdateNumericValues);
            // 
            // button_ZoomOut
            // 
            this.button_ZoomOut.Location = new System.Drawing.Point(45, 96);
            this.button_ZoomOut.Name = "button_ZoomOut";
            this.button_ZoomOut.Size = new System.Drawing.Size(46, 25);
            this.button_ZoomOut.TabIndex = 10;
            this.button_ZoomOut.Text = "🔍-";
            this.button_ZoomOut.UseVisualStyleBackColor = true;
            this.button_ZoomOut.Click += new System.EventHandler(this.button_ZoomOut_Click);
            // 
            // button_ZoomIn
            // 
            this.button_ZoomIn.Location = new System.Drawing.Point(4, 96);
            this.button_ZoomIn.Name = "button_ZoomIn";
            this.button_ZoomIn.Size = new System.Drawing.Size(46, 25);
            this.button_ZoomIn.TabIndex = 9;
            this.button_ZoomIn.Text = "🔍+";
            this.button_ZoomIn.UseVisualStyleBackColor = true;
            this.button_ZoomIn.Click += new System.EventHandler(this.button_ZoomIn_Click);
            // 
            // comboBox_TileSize
            // 
            this.comboBox_TileSize.FormattingEnabled = true;
            this.comboBox_TileSize.Location = new System.Drawing.Point(12, 12);
            this.comboBox_TileSize.Name = "comboBox_TileSize";
            this.comboBox_TileSize.Size = new System.Drawing.Size(121, 23);
            this.comboBox_TileSize.TabIndex = 11;
            this.comboBox_TileSize.SelectedValueChanged += new System.EventHandler(this.comboBox_TileSize_SelectedValueChanged);
            // 
            // comboBox_Zoom
            // 
            this.comboBox_Zoom.FormattingEnabled = true;
            this.comboBox_Zoom.Location = new System.Drawing.Point(139, 12);
            this.comboBox_Zoom.Name = "comboBox_Zoom";
            this.comboBox_Zoom.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Zoom.TabIndex = 12;
            this.comboBox_Zoom.SelectedValueChanged += new System.EventHandler(this.comboBox_Zoom_SelectedValueChanged);
            // 
            // comboBox_Seed
            // 
            this.comboBox_Seed.FormattingEnabled = true;
            this.comboBox_Seed.Location = new System.Drawing.Point(266, 12);
            this.comboBox_Seed.Name = "comboBox_Seed";
            this.comboBox_Seed.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Seed.TabIndex = 13;
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(393, 11);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(75, 23);
            this.button_Load.TabIndex = 14;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 346);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.comboBox_Seed);
            this.Controls.Add(this.comboBox_Zoom);
            this.Controls.Add(this.comboBox_TileSize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_YPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_XPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel_Position;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button_Up;
        private Button button_Down;
        private Button button_Left;
        private Button button_Right;
        private FlowLayoutPanel flowLayoutPanel_Pictures;
        private Panel panel1;
        private Button button_ZoomOut;
        private Button button_ZoomIn;
        private Label label_Tiles;
        private NumericUpDown numericUpDown_Tiles;
        private Label label_YPos;
        private NumericUpDown numericUpDown_YPos;
        private Label label_X;
        private NumericUpDown numericUpDown_XPos;
        private Button button_Reload;
        private ComboBox comboBox_TileSize;
        private ComboBox comboBox_Zoom;
        private ComboBox comboBox_Seed;
        private Button button_Load;
    }
}