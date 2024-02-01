namespace GameCaro
{
    partial class CaroGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaroGame));
            pnlChessBoard = new Panel();
            pnlTitle = new Panel();
            pictureBox1 = new PictureBox();
            pnlPlayerInfo = new Panel();
            progressBar1 = new ProgressBar();
            txtPlayerName = new TextBox();
            lblTitle = new Label();
            txtIP = new TextBox();
            btnConnect = new Button();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlPlayerInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.AutoScroll = true;
            pnlChessBoard.BackColor = SystemColors.Info;
            pnlChessBoard.Location = new Point(12, 12);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(480, 480);
            pnlChessBoard.TabIndex = 0;
            // 
            // pnlTitle
            // 
            pnlTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlTitle.BackColor = SystemColors.Info;
            pnlTitle.Controls.Add(pictureBox1);
            pnlTitle.Location = new Point(511, 12);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(300, 250);
            pnlTitle.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.thumb;
            pictureBox1.Location = new Point(49, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlPlayerInfo
            // 
            pnlPlayerInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlPlayerInfo.BackColor = SystemColors.Window;
            pnlPlayerInfo.Controls.Add(progressBar1);
            pnlPlayerInfo.Controls.Add(txtPlayerName);
            pnlPlayerInfo.Controls.Add(lblTitle);
            pnlPlayerInfo.Controls.Add(txtIP);
            pnlPlayerInfo.Controls.Add(btnConnect);
            pnlPlayerInfo.Location = new Point(511, 268);
            pnlPlayerInfo.Name = "pnlPlayerInfo";
            pnlPlayerInfo.Size = new Size(300, 224);
            pnlPlayerInfo.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.Control;
            progressBar1.Location = new Point(3, 113);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(294, 30);
            progressBar1.TabIndex = 4;
            // 
            // txtPlayerName
            // 
            txtPlayerName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlayerName.Location = new Point(3, 72);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.ReadOnly = true;
            txtPlayerName.Size = new Size(294, 35);
            txtPlayerName.TabIndex = 3;
            txtPlayerName.Text = "Player 1";
            txtPlayerName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTitle
            // 
            lblTitle.BorderStyle = BorderStyle.FixedSingle;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(3, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(294, 64);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Game Caro V1";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtIP
            // 
            txtIP.BackColor = SystemColors.Control;
            txtIP.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtIP.Location = new Point(3, 149);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(294, 35);
            txtIP.TabIndex = 1;
            txtIP.Text = "127.0.0.1";
            txtIP.TextAlign = HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            btnConnect.BackgroundImageLayout = ImageLayout.None;
            btnConnect.FlatStyle = FlatStyle.Popup;
            btnConnect.Location = new Point(3, 190);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(294, 31);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "CONNECT";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += Connect;
            // 
            // CaroGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(823, 503);
            Controls.Add(pnlPlayerInfo);
            Controls.Add(pnlTitle);
            Controls.Add(pnlChessBoard);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CaroGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caro Game";
            pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlPlayerInfo.ResumeLayout(false);
            pnlPlayerInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChessBoard;
        private Panel pnlTitle;
        private Panel pnlPlayerInfo;
        private Button btnConnect;
        private TextBox txtIP;
        private Label lblTitle;
        private TextBox txtPlayerName;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
    }
}
