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
            btnSpin = new Button();
            lblResult = new Label();
            txtStake = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(474, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(171, 200);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 103);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(320, 200);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 103);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(645, 303);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(50, 20);
            lblBalance.TabIndex = 3;
            lblBalance.Text = "label1";
            // 
            // btnSpin
            // 
            btnSpin.Location = new Point(633, 109);
            btnSpin.Name = "btnSpin";
            btnSpin.Size = new Size(49, 179);
            btnSpin.TabIndex = 4;
            btnSpin.Text = "btnSpin";
            btnSpin.UseVisualStyleBackColor = true;
            btnSpin.Click += btnSpin_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(355, 153);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 5;
            lblResult.Text = "label2";
            // 
            // txtStake
            // 
            txtStake.Location = new Point(645, 340);
            txtStake.Name = "txtStake";
            txtStake.Size = new Size(125, 27);
            txtStake.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStake);
            Controls.Add(lblResult);
            Controls.Add(btnSpin);
            Controls.Add(lblBalance);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblBalance;
        private Button btnSpin;
        private Label lblResult;
        private TextBox txtStake;
    }
}
