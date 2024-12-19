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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblBalance = new Label();
            lblResult = new Label();
            txtStake = new TextBox();
            pictureBox4 = new PictureBox();
            btnSpin = new PictureBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSpin).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(532, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 79);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(328, 237);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 79);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(431, 237);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(82, 79);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(38, 137);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(50, 20);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "label1";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(47, 73);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "label2";
            // 
            // txtStake
            // 
            txtStake.Location = new Point(28, 197);
            txtStake.Name = "txtStake";
            txtStake.Size = new Size(85, 27);
            txtStake.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Assets.Assets.slot_machine4;
            pictureBox4.Location = new Point(148, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(594, 493);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // btnSpin
            // 
            btnSpin.BackColor = Color.Transparent;
            btnSpin.BackgroundImage = Assets.Assets.slot_machine2;
            btnSpin.BackgroundImageLayout = ImageLayout.Zoom;
            btnSpin.Location = new Point(689, 272);
            btnSpin.Name = "btnSpin";
            btnSpin.Size = new Size(53, 150);
            btnSpin.TabIndex = 8;
            btnSpin.TabStop = false;
            btnSpin.Click += btnSpin_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "FRUITS", "ANIMALS", "JEWELS", "NUMBERS" });
            comboBox1.Location = new Point(778, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 493);
            Controls.Add(comboBox1);
            Controls.Add(btnSpin);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSpin).EndInit();
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
        private PictureBox btnSpin;
        private PictureBox pictureBox4;
        private ComboBox comboBox1;
    }
}
