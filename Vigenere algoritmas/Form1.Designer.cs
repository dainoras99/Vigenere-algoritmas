
namespace Vigenere_algoritmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.encryptRadioButton = new System.Windows.Forms.RadioButton();
            this.decryptRadioButton = new System.Windows.Forms.RadioButton();
            this.cleanButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(273, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vigenere algoritmas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(58, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raktas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(949, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Bisque;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(62, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Šifravimas / Dešifravimas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Bisque;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(644, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 43);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rezultatas";
            // 
            // keyTextBox
            // 
            this.keyTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.keyTextBox.Location = new System.Drawing.Point(142, 205);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(180, 23);
            this.keyTextBox.TabIndex = 7;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(199, 549);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 36);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "PRADĖTI";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Window;
            this.textBox.Location = new System.Drawing.Point(47, 294);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(396, 197);
            this.textBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(92, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(315, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Šifruojamas/Dešifruojamas tekstas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 588);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(949, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Sienna;
            this.treeView1.Location = new System.Drawing.Point(491, 117);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(2, 446);
            this.treeView1.TabIndex = 5;
            // 
            // encryptRadioButton
            // 
            this.encryptRadioButton.AutoSize = true;
            this.encryptRadioButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.encryptRadioButton.ForeColor = System.Drawing.Color.Navy;
            this.encryptRadioButton.Location = new System.Drawing.Point(96, 507);
            this.encryptRadioButton.Name = "encryptRadioButton";
            this.encryptRadioButton.Size = new System.Drawing.Size(87, 22);
            this.encryptRadioButton.TabIndex = 20;
            this.encryptRadioButton.TabStop = true;
            this.encryptRadioButton.Text = "ŠIFRUOTI";
            this.encryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // decryptRadioButton
            // 
            this.decryptRadioButton.AutoSize = true;
            this.decryptRadioButton.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.decryptRadioButton.ForeColor = System.Drawing.Color.Navy;
            this.decryptRadioButton.Location = new System.Drawing.Point(303, 507);
            this.decryptRadioButton.Name = "decryptRadioButton";
            this.decryptRadioButton.Size = new System.Drawing.Size(104, 22);
            this.decryptRadioButton.TabIndex = 21;
            this.decryptRadioButton.TabStop = true;
            this.decryptRadioButton.Text = "DEŠIFRUOTI";
            this.decryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(701, 549);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 22;
            this.cleanButton.Text = "IŠVALYTI";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(538, 205);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(396, 324);
            this.resultTextBox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(983, 607);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.decryptRadioButton);
            this.Controls.Add(this.encryptRadioButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RadioButton encryptRadioButton;
        private System.Windows.Forms.RadioButton decryptRadioButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

