namespace StringFunctions
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
            this.lblxOutput = new System.Windows.Forms.ListBox();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.btnStartEnd = new System.Windows.Forms.Button();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnUpper = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnToChar = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInput.Location = new System.Drawing.Point(67, 7);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(339, 30);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "//** iakademi **\\\\";
            // 
            // lblxOutput
            // 
            this.lblxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblxOutput.FormattingEnabled = true;
            this.lblxOutput.ItemHeight = 20;
            this.lblxOutput.Location = new System.Drawing.Point(455, 32);
            this.lblxOutput.Name = "lblxOutput";
            this.lblxOutput.Size = new System.Drawing.Size(120, 304);
            this.lblxOutput.TabIndex = 1;
            // 
            // btnOriginal
            // 
            this.btnOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOriginal.Location = new System.Drawing.Point(67, 68);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(109, 40);
            this.btnOriginal.TabIndex = 2;
            this.btnOriginal.Text = "Original";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // btnStartEnd
            // 
            this.btnStartEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartEnd.Location = new System.Drawing.Point(182, 68);
            this.btnStartEnd.Name = "btnStartEnd";
            this.btnStartEnd.Size = new System.Drawing.Size(109, 40);
            this.btnStartEnd.TabIndex = 3;
            this.btnStartEnd.Text = "Start-End";
            this.btnStartEnd.UseVisualStyleBackColor = true;
            this.btnStartEnd.Click += new System.EventHandler(this.btnStartEnd_Click);
            // 
            // btnSubstring
            // 
            this.btnSubstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSubstring.Location = new System.Drawing.Point(297, 68);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(109, 40);
            this.btnSubstring.TabIndex = 4;
            this.btnSubstring.Text = "Substring";
            this.btnSubstring.UseVisualStyleBackColor = true;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInsert.Location = new System.Drawing.Point(297, 123);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(109, 40);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrim.Location = new System.Drawing.Point(182, 123);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(109, 40);
            this.btnTrim.TabIndex = 6;
            this.btnTrim.Text = "Trim";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // btnContains
            // 
            this.btnContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContains.Location = new System.Drawing.Point(67, 123);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(109, 40);
            this.btnContains.TabIndex = 5;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.Location = new System.Drawing.Point(182, 179);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 40);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReplace.Location = new System.Drawing.Point(297, 179);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(109, 40);
            this.btnReplace.TabIndex = 9;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIndexOf.Location = new System.Drawing.Point(67, 179);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(109, 40);
            this.btnIndexOf.TabIndex = 8;
            this.btnIndexOf.Text = "IndexOf";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnLower
            // 
            this.btnLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLower.Location = new System.Drawing.Point(297, 234);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(109, 40);
            this.btnLower.TabIndex = 13;
            this.btnLower.Text = "Lower";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnUpper
            // 
            this.btnUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpper.Location = new System.Drawing.Point(182, 234);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(109, 40);
            this.btnUpper.TabIndex = 12;
            this.btnUpper.Text = "Upper";
            this.btnUpper.UseVisualStyleBackColor = true;
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReverse.Location = new System.Drawing.Point(67, 234);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(109, 40);
            this.btnReverse.TabIndex = 11;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustom.Location = new System.Drawing.Point(297, 290);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(109, 40);
            this.btnCustom.TabIndex = 16;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSplit.Location = new System.Drawing.Point(182, 290);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(109, 40);
            this.btnSplit.TabIndex = 15;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnToChar
            // 
            this.btnToChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToChar.Location = new System.Drawing.Point(67, 290);
            this.btnToChar.Name = "btnToChar";
            this.btnToChar.Size = new System.Drawing.Size(109, 40);
            this.btnToChar.TabIndex = 14;
            this.btnToChar.Text = "ToChar";
            this.btnToChar.UseVisualStyleBackColor = true;
            this.btnToChar.Click += new System.EventHandler(this.btnToChar_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOutput.ForeColor = System.Drawing.Color.Red;
            this.lblOutput.Location = new System.Drawing.Point(72, 40);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(21, 25);
            this.lblOutput.TabIndex = 17;
            this.lblOutput.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 357);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnToChar);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnSubstring);
            this.Controls.Add(this.btnStartEnd);
            this.Controls.Add(this.btnOriginal);
            this.Controls.Add(this.lblxOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lblxOutput;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button btnStartEnd;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnToChar;
        private System.Windows.Forms.Label lblOutput;
    }
}

