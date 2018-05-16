namespace PonyMaze
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateMaze = new System.Windows.Forms.Button();
            this.lblMazeWidth = new System.Windows.Forms.Label();
            this.lblMazeHeight = new System.Windows.Forms.Label();
            this.edtMazeWidth = new System.Windows.Forms.NumericUpDown();
            this.edtMazeHeight = new System.Windows.Forms.NumericUpDown();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.edtDifficulty = new System.Windows.Forms.NumericUpDown();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.edtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edtMazeId = new System.Windows.Forms.TextBox();
            this.lblMazeId = new System.Windows.Forms.Label();
            this.btnLoadMaze = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblManual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMazeWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMazeHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDifficulty)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPlayerName);
            this.panel1.Controls.Add(this.edtPlayerName);
            this.panel1.Controls.Add(this.edtDifficulty);
            this.panel1.Controls.Add(this.lblDifficulty);
            this.panel1.Controls.Add(this.edtMazeHeight);
            this.panel1.Controls.Add(this.edtMazeWidth);
            this.panel1.Controls.Add(this.lblMazeHeight);
            this.panel1.Controls.Add(this.lblMazeWidth);
            this.panel1.Controls.Add(this.btnCreateMaze);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 142);
            this.panel1.TabIndex = 0;
            // 
            // btnCreateMaze
            // 
            this.btnCreateMaze.Location = new System.Drawing.Point(25, 108);
            this.btnCreateMaze.Name = "btnCreateMaze";
            this.btnCreateMaze.Size = new System.Drawing.Size(129, 23);
            this.btnCreateMaze.TabIndex = 0;
            this.btnCreateMaze.Text = "Create new Maze";
            this.btnCreateMaze.UseVisualStyleBackColor = true;
            this.btnCreateMaze.Click += new System.EventHandler(this.btnCreateMaze_Click);
            // 
            // lblMazeWidth
            // 
            this.lblMazeWidth.AutoSize = true;
            this.lblMazeWidth.Location = new System.Drawing.Point(3, 11);
            this.lblMazeWidth.Name = "lblMazeWidth";
            this.lblMazeWidth.Size = new System.Drawing.Size(64, 13);
            this.lblMazeWidth.TabIndex = 1;
            this.lblMazeWidth.Text = "Maze Width";
            // 
            // lblMazeHeight
            // 
            this.lblMazeHeight.AutoSize = true;
            this.lblMazeHeight.Location = new System.Drawing.Point(3, 34);
            this.lblMazeHeight.Name = "lblMazeHeight";
            this.lblMazeHeight.Size = new System.Drawing.Size(67, 13);
            this.lblMazeHeight.TabIndex = 2;
            this.lblMazeHeight.Text = "Maze Height";
            // 
            // edtMazeWidth
            // 
            this.edtMazeWidth.Location = new System.Drawing.Point(87, 9);
            this.edtMazeWidth.Name = "edtMazeWidth";
            this.edtMazeWidth.Size = new System.Drawing.Size(88, 20);
            this.edtMazeWidth.TabIndex = 3;
            // 
            // edtMazeHeight
            // 
            this.edtMazeHeight.Location = new System.Drawing.Point(87, 32);
            this.edtMazeHeight.Name = "edtMazeHeight";
            this.edtMazeHeight.Size = new System.Drawing.Size(88, 20);
            this.edtMazeHeight.TabIndex = 4;
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Location = new System.Drawing.Point(13, 13);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(194, 13);
            this.lblStep1.TabIndex = 1;
            this.lblStep1.Text = "Step 1. Create new Maze or Load by ID";
            // 
            // edtDifficulty
            // 
            this.edtDifficulty.Location = new System.Drawing.Point(87, 56);
            this.edtDifficulty.Name = "edtDifficulty";
            this.edtDifficulty.Size = new System.Drawing.Size(88, 20);
            this.edtDifficulty.TabIndex = 6;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(3, 58);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(47, 13);
            this.lblDifficulty.TabIndex = 5;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // edtPlayerName
            // 
            this.edtPlayerName.Location = new System.Drawing.Point(87, 80);
            this.edtPlayerName.Name = "edtPlayerName";
            this.edtPlayerName.Size = new System.Drawing.Size(88, 20);
            this.edtPlayerName.TabIndex = 7;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(3, 83);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(67, 13);
            this.lblPlayerName.TabIndex = 8;
            this.lblPlayerName.Text = "Player Name";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnLoadMaze);
            this.panel2.Controls.Add(this.lblMazeId);
            this.panel2.Controls.Add(this.edtMazeId);
            this.panel2.Location = new System.Drawing.Point(12, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 80);
            this.panel2.TabIndex = 2;
            // 
            // edtMazeId
            // 
            this.edtMazeId.Location = new System.Drawing.Point(3, 24);
            this.edtMazeId.Name = "edtMazeId";
            this.edtMazeId.Size = new System.Drawing.Size(189, 20);
            this.edtMazeId.TabIndex = 0;
            // 
            // lblMazeId
            // 
            this.lblMazeId.AutoSize = true;
            this.lblMazeId.Location = new System.Drawing.Point(3, 6);
            this.lblMazeId.Name = "lblMazeId";
            this.lblMazeId.Size = new System.Drawing.Size(47, 13);
            this.lblMazeId.TabIndex = 6;
            this.lblMazeId.Text = "Maze ID";
            // 
            // btnLoadMaze
            // 
            this.btnLoadMaze.Location = new System.Drawing.Point(57, 50);
            this.btnLoadMaze.Name = "btnLoadMaze";
            this.btnLoadMaze.Size = new System.Drawing.Size(75, 23);
            this.btnLoadMaze.TabIndex = 7;
            this.btnLoadMaze.Text = "Load Maze";
            this.btnLoadMaze.UseVisualStyleBackColor = true;
            this.btnLoadMaze.Click += new System.EventHandler(this.btnLoadMaze_Click);
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLog.Location = new System.Drawing.Point(477, 10);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(727, 673);
            this.txtLog.TabIndex = 3;
            this.txtLog.Text = "";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnGO);
            this.panel3.Controls.Add(this.txtSequence);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblManual);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnUp);
            this.panel3.Controls.Add(this.btnSolve);
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Location = new System.Drawing.Point(234, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 229);
            this.panel3.TabIndex = 4;
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Location = new System.Drawing.Point(234, 10);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(218, 13);
            this.lblStep2.TabIndex = 5;
            this.lblStep2.Text = "Next Step. Solve The maze, or play manually";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(113, 203);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Call Print API";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(13, 6);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 1;
            this.btnSolve.Text = "Solve it!";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(90, 123);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(36, 23);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "N";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "S";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "W";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(132, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "E";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.Location = new System.Drawing.Point(10, 98);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(97, 13);
            this.lblManual.TabIndex = 6;
            this.lblManual.Text = "Or control manually";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Copy-Paste solution here, and click GO";
            // 
            // txtSequence
            // 
            this.txtSequence.Location = new System.Drawing.Point(13, 58);
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(155, 20);
            this.txtSequence.TabIndex = 8;
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(174, 56);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(34, 23);
            this.btnGO.TabIndex = 9;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 695);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "PonyMaze";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMazeWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMazeHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtDifficulty)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox edtPlayerName;
        private System.Windows.Forms.NumericUpDown edtDifficulty;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.NumericUpDown edtMazeHeight;
        private System.Windows.Forms.NumericUpDown edtMazeWidth;
        private System.Windows.Forms.Label lblMazeHeight;
        private System.Windows.Forms.Label lblMazeWidth;
        private System.Windows.Forms.Button btnCreateMaze;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLoadMaze;
        private System.Windows.Forms.Label lblMazeId;
        private System.Windows.Forms.TextBox edtMazeId;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.TextBox txtSequence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblManual;
    }
}

