namespace ExcC14NTransform.Shell
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnCanonicalize = new System.Windows.Forms.Button();
            this.btnDigest = new System.Windows.Forms.Button();
            this.txtDigest = new System.Windows.Forms.TextBox();
            this.rbC14N = new System.Windows.Forms.RadioButton();
            this.rbExcC14N = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComputeHash = new System.Windows.Forms.Button();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.lblHashBase64 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 88);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(776, 166);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 302);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(776, 200);
            this.txtOutput.TabIndex = 0;
            // 
            // btnCanonicalize
            // 
            this.btnCanonicalize.Location = new System.Drawing.Point(713, 260);
            this.btnCanonicalize.Name = "btnCanonicalize";
            this.btnCanonicalize.Size = new System.Drawing.Size(75, 23);
            this.btnCanonicalize.TabIndex = 1;
            this.btnCanonicalize.Text = "Canonicalize";
            this.btnCanonicalize.UseVisualStyleBackColor = true;
            this.btnCanonicalize.Click += new System.EventHandler(this.btnCanonicalize_Click);
            // 
            // btnDigest
            // 
            this.btnDigest.Location = new System.Drawing.Point(274, 508);
            this.btnDigest.Name = "btnDigest";
            this.btnDigest.Size = new System.Drawing.Size(75, 23);
            this.btnDigest.TabIndex = 1;
            this.btnDigest.Text = "Digest";
            this.btnDigest.UseVisualStyleBackColor = true;
            this.btnDigest.Click += new System.EventHandler(this.btnDigest_Click);
            // 
            // txtDigest
            // 
            this.txtDigest.Location = new System.Drawing.Point(12, 537);
            this.txtDigest.Name = "txtDigest";
            this.txtDigest.Size = new System.Drawing.Size(337, 20);
            this.txtDigest.TabIndex = 0;
            // 
            // rbC14N
            // 
            this.rbC14N.AutoSize = true;
            this.rbC14N.Location = new System.Drawing.Point(6, 19);
            this.rbC14N.Name = "rbC14N";
            this.rbC14N.Size = new System.Drawing.Size(52, 17);
            this.rbC14N.TabIndex = 2;
            this.rbC14N.Text = "C14N";
            this.rbC14N.UseVisualStyleBackColor = true;
            // 
            // rbExcC14N
            // 
            this.rbExcC14N.AutoSize = true;
            this.rbExcC14N.Checked = true;
            this.rbExcC14N.Location = new System.Drawing.Point(6, 42);
            this.rbExcC14N.Name = "rbExcC14N";
            this.rbExcC14N.Size = new System.Drawing.Size(100, 17);
            this.rbExcC14N.TabIndex = 2;
            this.rbExcC14N.TabStop = true;
            this.rbExcC14N.Text = "Exclusive C14N";
            this.rbExcC14N.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbC14N);
            this.groupBox1.Controls.Add(this.rbExcC14N);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 70);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canonicalization";
            // 
            // btnComputeHash
            // 
            this.btnComputeHash.Location = new System.Drawing.Point(702, 508);
            this.btnComputeHash.Name = "btnComputeHash";
            this.btnComputeHash.Size = new System.Drawing.Size(86, 23);
            this.btnComputeHash.TabIndex = 1;
            this.btnComputeHash.Text = "ComputeHash";
            this.btnComputeHash.UseVisualStyleBackColor = true;
            this.btnComputeHash.Click += new System.EventHandler(this.btnComputeHash_Click);
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(451, 537);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(337, 20);
            this.txtHash.TabIndex = 0;
            // 
            // lblHashBase64
            // 
            this.lblHashBase64.AutoSize = true;
            this.lblHashBase64.Location = new System.Drawing.Point(448, 518);
            this.lblHashBase64.Name = "lblHashBase64";
            this.lblHashBase64.Size = new System.Drawing.Size(43, 13);
            this.lblHashBase64.TabIndex = 4;
            this.lblHashBase64.Text = "Base64";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Base64";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Base64";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(775, 1);
            this.label3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHashBase64);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnComputeHash);
            this.Controls.Add(this.btnDigest);
            this.Controls.Add(this.btnCanonicalize);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.txtDigest);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Canonicalization - SHA1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnCanonicalize;
        private System.Windows.Forms.Button btnDigest;
        private System.Windows.Forms.TextBox txtDigest;
        private System.Windows.Forms.RadioButton rbC14N;
        private System.Windows.Forms.RadioButton rbExcC14N;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnComputeHash;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Label lblHashBase64;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

