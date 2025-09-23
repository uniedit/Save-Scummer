namespace Save_Scummer
{
    partial class Menu
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btn_Load = new CustomButton();
            lbl_SteamState = new Label();
            skeetGroupBox1 = new SkeetFramework.SkeetGroupBox();
            tbtn_Overwrite = new ToggleButton();
            btn_Open = new CustomButton();
            txt_Location = new TextBox();
            btn_Undo = new CustomButton();
            btn_Save = new CustomButton();
            pictureBox2 = new PictureBox();
            lstDirectory = new ListBox();
            skeetGroupBox2 = new SkeetFramework.SkeetGroupBox();
            skeetGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) pictureBox2).BeginInit();
            skeetGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Load
            // 
            btn_Load.BackColor = SystemColors.WindowFrame;
            btn_Load.BackgroundColor = SystemColors.WindowFrame;
            btn_Load.BorderColor = Color.FromArgb(  61,   61,   61);
            btn_Load.BorderRadius = 0;
            btn_Load.BorderSize = 0;
            btn_Load.Enabled = false;
            btn_Load.FlatAppearance.BorderSize = 0;
            btn_Load.FlatStyle = FlatStyle.Flat;
            btn_Load.Font = new Font("JetBrains Mono NL SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point,  0);
            btn_Load.ForeColor = Color.White;
            btn_Load.Location = new Point(18, 258);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(433, 48);
            btn_Load.TabIndex = 1;
            btn_Load.Text = "Load";
            btn_Load.TextColor = Color.White;
            btn_Load.UseVisualStyleBackColor = false;
            btn_Load.Click += btn_Load_Click;
            // 
            // lbl_SteamState
            // 
            lbl_SteamState.AutoSize = true;
            lbl_SteamState.Font = new Font("JetBrains Mono SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lbl_SteamState.Location = new Point(18, 220);
            lbl_SteamState.Name = "lbl_SteamState";
            lbl_SteamState.Size = new Size(168, 18);
            lbl_SteamState.TabIndex = 3;
            lbl_SteamState.Text = "Overwrite Everything";
            // 
            // skeetGroupBox1
            // 
            skeetGroupBox1.BackColor = SystemColors.Control;
            skeetGroupBox1.Controls.Add(tbtn_Overwrite);
            skeetGroupBox1.Controls.Add(btn_Open);
            skeetGroupBox1.Controls.Add(txt_Location);
            skeetGroupBox1.Controls.Add(btn_Undo);
            skeetGroupBox1.Controls.Add(lbl_SteamState);
            skeetGroupBox1.Controls.Add(btn_Save);
            skeetGroupBox1.Controls.Add(btn_Load);
            skeetGroupBox1.Font = new Font("JetBrains Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point,  0);
            skeetGroupBox1.Location = new Point(12, 22);
            skeetGroupBox1.Name = "skeetGroupBox1";
            skeetGroupBox1.Size = new Size(467, 462);
            skeetGroupBox1.TabIndex = 4;
            skeetGroupBox1.TabStop = false;
            skeetGroupBox1.Text = "Save & Load Files";
            // 
            // tbtn_Overwrite
            // 
            tbtn_Overwrite.BackColor = Color.Transparent;
            tbtn_Overwrite.Location = new Point(204, 217);
            tbtn_Overwrite.MinimumSize = new Size(45, 22);
            tbtn_Overwrite.Name = "tbtn_Overwrite";
            tbtn_Overwrite.OffBackColor = Color.Gray;
            tbtn_Overwrite.OffToggleColor = Color.Gainsboro;
            tbtn_Overwrite.OnBackColor = Color.FromArgb(  170,   3,   27);
            tbtn_Overwrite.OnToggleColor = Color.WhiteSmoke;
            tbtn_Overwrite.Size = new Size(53, 26);
            tbtn_Overwrite.TabIndex = 7;
            tbtn_Overwrite.UseVisualStyleBackColor = false;
            tbtn_Overwrite.CheckedChanged += tbtn_Overwrite_CheckedChanged;
            // 
            // btn_Open
            // 
            btn_Open.BackColor = Color.FromArgb(  64,   64,   64);
            btn_Open.BackgroundColor = Color.FromArgb(  64,   64,   64);
            btn_Open.BorderColor = Color.FromArgb(  61,   61,   61);
            btn_Open.BorderRadius = 0;
            btn_Open.BorderSize = 0;
            btn_Open.FlatAppearance.BorderSize = 0;
            btn_Open.FlatStyle = FlatStyle.Flat;
            btn_Open.Font = new Font("JetBrains Mono NL SemiBold", 7F, FontStyle.Bold, GraphicsUnit.Point,  0);
            btn_Open.ForeColor = Color.White;
            btn_Open.Location = new Point(418, 55);
            btn_Open.Name = "btn_Open";
            btn_Open.Size = new Size(33, 25);
            btn_Open.TabIndex = 10;
            btn_Open.Text = "...";
            btn_Open.TextColor = Color.White;
            btn_Open.UseVisualStyleBackColor = false;
            btn_Open.Click += btn_Open_Click;
            // 
            // txt_Location
            // 
            txt_Location.BackColor = Color.FromArgb(  33,   33,   33);
            txt_Location.BorderStyle = BorderStyle.FixedSingle;
            txt_Location.Cursor = Cursors.IBeam;
            txt_Location.Font = new Font("JetBrains Mono NL", 10F, FontStyle.Regular, GraphicsUnit.Point,  0);
            txt_Location.ForeColor = Color.Transparent;
            txt_Location.ImeMode = ImeMode.NoControl;
            txt_Location.Location = new Point(18, 55);
            txt_Location.Name = "txt_Location";
            txt_Location.Size = new Size(394, 25);
            txt_Location.TabIndex = 9;
            txt_Location.Text = "File Location";
            txt_Location.MouseClick += txt_Location_MouseClick;
            txt_Location.TextChanged += txt_Location_TextChanged;
            // 
            // btn_Undo
            // 
            btn_Undo.BackColor = SystemColors.WindowFrame;
            btn_Undo.BackgroundColor = SystemColors.WindowFrame;
            btn_Undo.BorderColor = Color.FromArgb(  61,   61,   61);
            btn_Undo.BorderRadius = 0;
            btn_Undo.BorderSize = 0;
            btn_Undo.FlatAppearance.BorderSize = 0;
            btn_Undo.FlatStyle = FlatStyle.Flat;
            btn_Undo.Font = new Font("JetBrains Mono NL SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point,  0);
            btn_Undo.ForeColor = Color.White;
            btn_Undo.Location = new Point(18, 382);
            btn_Undo.Name = "btn_Undo";
            btn_Undo.Size = new Size(433, 48);
            btn_Undo.TabIndex = 6;
            btn_Undo.Text = "Undo";
            btn_Undo.TextColor = Color.White;
            btn_Undo.UseVisualStyleBackColor = false;
            btn_Undo.Click += btn_Undo_Click;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = SystemColors.WindowFrame;
            btn_Save.BackgroundColor = SystemColors.WindowFrame;
            btn_Save.BorderColor = Color.FromArgb(  61,   61,   61);
            btn_Save.BorderRadius = 0;
            btn_Save.BorderSize = 0;
            btn_Save.FlatAppearance.BorderSize = 0;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Font = new Font("JetBrains Mono NL SemiBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point,  0);
            btn_Save.ForeColor = Color.White;
            btn_Save.Location = new Point(18, 103);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(433, 44);
            btn_Save.TabIndex = 5;
            btn_Save.Text = "Save";
            btn_Save.TextColor = Color.White;
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image) resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(-11, -4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(768, 20);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // lstDirectory
            // 
            lstDirectory.BackColor = SystemColors.Control;
            lstDirectory.BorderStyle = BorderStyle.None;
            lstDirectory.Dock = DockStyle.Fill;
            lstDirectory.FormattingEnabled = true;
            lstDirectory.Location = new Point(3, 19);
            lstDirectory.Name = "lstDirectory";
            lstDirectory.Size = new Size(228, 440);
            lstDirectory.TabIndex = 9;
            lstDirectory.SelectedIndexChanged += lstDirectory_SelectedIndexChanged;
            // 
            // skeetGroupBox2
            // 
            skeetGroupBox2.BackColor = SystemColors.Control;
            skeetGroupBox2.Controls.Add(lstDirectory);
            skeetGroupBox2.Font = new Font("JetBrains Mono SemiBold", 9F, FontStyle.Bold);
            skeetGroupBox2.Location = new Point(485, 22);
            skeetGroupBox2.Name = "skeetGroupBox2";
            skeetGroupBox2.Size = new Size(234, 462);
            skeetGroupBox2.TabIndex = 10;
            skeetGroupBox2.TabStop = false;
            skeetGroupBox2.Text = "Files Visualizer";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(731, 492);
            Controls.Add(skeetGroupBox2);
            Controls.Add(pictureBox2);
            Controls.Add(skeetGroupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Save Scummer";
            skeetGroupBox1.ResumeLayout(false);
            skeetGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) pictureBox2).EndInit();
            skeetGroupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CustomButton btn_Load;
        private Label lbl_SteamState;
        private SkeetFramework.SkeetGroupBox skeetGroupBox1;
        private CustomButton btn_Save;
        private CustomButton btn_Undo;
        private PictureBox pictureBox2;
        private TextBox txt_Location;
        private CustomButton btn_Open;
        private ToggleButton tbtn_Overwrite;
        private ListBox lstDirectory;
        private SkeetFramework.SkeetGroupBox skeetGroupBox2;
    }
}
