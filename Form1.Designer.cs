namespace SlotMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblBalance = new Label();
            lblResult = new Label();
            txtStake = new TextBox();
            pictureBox4 = new PictureBox();
            comboBox1 = new ComboBox();
            lblStake = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(280, 232);
            pictureBox1.Margin = new Padding(30, 3, 3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(30, 0, 0, 0);
            pictureBox1.Size = new Size(82, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(75, 232);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 81);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(177, 232);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(82, 81);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(541, 176);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(95, 29);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "label1";
            lblBalance.Click += lblBalance_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(542, 130);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(131, 29);
            lblResult.TabIndex = 5;
            lblResult.Text = "WINNINGS";
            lblResult.Click += lblResult_Click;
            // 
            // txtStake
            // 
            txtStake.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStake.Location = new Point(668, 430);
            txtStake.Name = "txtStake";
            txtStake.Size = new Size(125, 26);
            txtStake.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.Location = new Point(1, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(507, 490);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += btnSpin_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(668, 276);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 37);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblStake
            // 
            lblStake.AutoSize = true;
            lblStake.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStake.Location = new Point(684, 398);
            lblStake.Name = "lblStake";
            lblStake.Size = new Size(88, 29);
            lblStake.TabIndex = 10;
            lblStake.Text = "Stake";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(684, 244);
            label1.Name = "label1";
            label1.Size = new Size(95, 29);
            label1.TabIndex = 11;
            label1.Text = "theme";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 493);
            Controls.Add(label1);
            Controls.Add(lblStake);
            Controls.Add(comboBox1);
            Controls.Add(txtStake);
            Controls.Add(lblResult);
            Controls.Add(lblBalance);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblBalance;
        private Label lblResult;
        private TextBox txtStake;
        private PictureBox pictureBox4;
        private ComboBox comboBox1;
        private Label lblStake;
        private Label label1;
    }
}
