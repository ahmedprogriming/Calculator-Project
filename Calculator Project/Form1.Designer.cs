namespace Calculator_Project
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
            this.butEq = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butMines = new System.Windows.Forms.Button();
            this.butMult = new System.Windows.Forms.Button();
            this.butDiv = new System.Windows.Forms.Button();
            this.butMod = new System.Windows.Forms.Button();
            this.butDE = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.butRe = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butEq
            // 
            this.butEq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butEq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butEq.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.butEq.FlatAppearance.BorderSize = 3;
            this.butEq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEq.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEq.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butEq.Location = new System.Drawing.Point(319, 452);
            this.butEq.Name = "butEq";
            this.butEq.Size = new System.Drawing.Size(67, 58);
            this.butEq.TabIndex = 0;
            this.butEq.Tag = "=";
            this.butEq.Text = "=";
            this.butEq.UseVisualStyleBackColor = false;
            this.butEq.Click += new System.EventHandler(this.EquleEnd);
            // 
            // butAdd
            // 
            this.butAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butAdd.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.butAdd.FlatAppearance.BorderSize = 3;
            this.butAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAdd.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butAdd.Location = new System.Drawing.Point(319, 368);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(67, 58);
            this.butAdd.TabIndex = 0;
            this.butAdd.Tag = "+";
            this.butAdd.Text = "+";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.OpretorButton);
            // 
            // butMines
            // 
            this.butMines.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butMines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butMines.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.butMines.FlatAppearance.BorderSize = 3;
            this.butMines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMines.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMines.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butMines.Location = new System.Drawing.Point(319, 279);
            this.butMines.Name = "butMines";
            this.butMines.Size = new System.Drawing.Size(67, 58);
            this.butMines.TabIndex = 0;
            this.butMines.Tag = "-";
            this.butMines.Text = "-";
            this.butMines.UseVisualStyleBackColor = false;
            this.butMines.Click += new System.EventHandler(this.OpretorButton);
            // 
            // butMult
            // 
            this.butMult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butMult.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.butMult.FlatAppearance.BorderSize = 3;
            this.butMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMult.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butMult.Location = new System.Drawing.Point(319, 196);
            this.butMult.Name = "butMult";
            this.butMult.Size = new System.Drawing.Size(67, 58);
            this.butMult.TabIndex = 0;
            this.butMult.Tag = "X";
            this.butMult.Text = "*";
            this.butMult.UseVisualStyleBackColor = false;
            this.butMult.Click += new System.EventHandler(this.OpretorButton);
            // 
            // butDiv
            // 
            this.butDiv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butDiv.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.butDiv.FlatAppearance.BorderSize = 3;
            this.butDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDiv.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDiv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butDiv.Location = new System.Drawing.Point(319, 115);
            this.butDiv.Name = "butDiv";
            this.butDiv.Size = new System.Drawing.Size(67, 58);
            this.butDiv.TabIndex = 0;
            this.butDiv.Tag = "/";
            this.butDiv.Text = "/";
            this.butDiv.UseVisualStyleBackColor = false;
            this.butDiv.Click += new System.EventHandler(this.OpretorButton);
            // 
            // butMod
            // 
            this.butMod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butMod.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.butMod.FlatAppearance.BorderSize = 3;
            this.butMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMod.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butMod.Location = new System.Drawing.Point(207, 115);
            this.butMod.Name = "butMod";
            this.butMod.Size = new System.Drawing.Size(75, 58);
            this.butMod.TabIndex = 0;
            this.butMod.Tag = "%";
            this.butMod.Text = "%";
            this.butMod.UseVisualStyleBackColor = false;
            this.butMod.Click += new System.EventHandler(this.OpretorButton);
            // 
            // butDE
            // 
            this.butDE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butDE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butDE.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.butDE.FlatAppearance.BorderSize = 3;
            this.butDE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDE.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butDE.Location = new System.Drawing.Point(12, 115);
            this.butDE.Name = "butDE";
            this.butDE.Size = new System.Drawing.Size(91, 58);
            this.butDE.TabIndex = 0;
            this.butDE.Text = "DE";
            this.butDE.UseVisualStyleBackColor = false;
            this.butDE.Click += new System.EventHandler(this.DeleteNumber);
            // 
            // but7
            // 
            this.but7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.but7.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but7.Location = new System.Drawing.Point(12, 192);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(75, 66);
            this.but7.TabIndex = 1;
            this.but7.Tag = "7";
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = false;
            this.but7.Click += new System.EventHandler(this.Numberbutton);
            // 
            // but8
            // 
            this.but8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.but8.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but8.Location = new System.Drawing.Point(111, 192);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(75, 66);
            this.but8.TabIndex = 1;
            this.but8.Tag = "8";
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = false;
            this.but8.Click += new System.EventHandler(this.Numberbutton);
            // 
            // but9
            // 
            this.but9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.but9.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but9.Location = new System.Drawing.Point(209, 196);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(75, 66);
            this.but9.TabIndex = 1;
            this.but9.Tag = "9";
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = false;
            this.but9.Click += new System.EventHandler(this.Numberbutton);
            // 
            // but4
            // 
            this.but4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.but4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but4.Location = new System.Drawing.Point(12, 279);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(75, 66);
            this.but4.TabIndex = 1;
            this.but4.Tag = "4";
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = false;
            this.but4.Click += new System.EventHandler(this.Numberbutton);
            // 
            // but5
            // 
            this.but5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.but5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but5.Location = new System.Drawing.Point(111, 279);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(75, 66);
            this.but5.TabIndex = 1;
            this.but5.Tag = "5";
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = false;
            this.but5.Click += new System.EventHandler(this.Numberbutton);
            // 
            // but6
            // 
            this.but6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.but6.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but6.Location = new System.Drawing.Point(209, 279);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(75, 66);
            this.but6.TabIndex = 1;
            this.but6.Tag = "6";
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = false;
            this.but6.Click += new System.EventHandler(this.Numberbutton);
            // 
            // but1
            // 
            this.but1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.but1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.Location = new System.Drawing.Point(12, 364);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(75, 66);
            this.but1.TabIndex = 1;
            this.but1.Tag = "1";
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = false;
            this.but1.Click += new System.EventHandler(this.Numberbutton);
            // 
            // but2
            // 
            this.but2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.but2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.Location = new System.Drawing.Point(111, 364);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(75, 66);
            this.but2.TabIndex = 1;
            this.but2.Tag = "2";
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = false;
            this.but2.Click += new System.EventHandler(this.Numberbutton);
            // 
            // but0
            // 
            this.but0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.but0.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but0.Location = new System.Drawing.Point(12, 444);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(174, 66);
            this.but0.TabIndex = 1;
            this.but0.Tag = "0";
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = false;
            this.but0.Click += new System.EventHandler(this.Numberbutton);
            // 
            // but3
            // 
            this.but3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.but3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but3.Location = new System.Drawing.Point(209, 364);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(75, 66);
            this.but3.TabIndex = 1;
            this.but3.Tag = "3";
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = false;
            this.but3.Click += new System.EventHandler(this.Numberbutton);
            // 
            // btnDot
            // 
            this.btnDot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDot.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDot.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(209, 444);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(75, 66);
            this.btnDot.TabIndex = 1;
            this.btnDot.Tag = ".";
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.Numberbutton);
            // 
            // butRe
            // 
            this.butRe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.butRe.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.butRe.FlatAppearance.BorderSize = 3;
            this.butRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRe.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butRe.Location = new System.Drawing.Point(111, 115);
            this.butRe.Name = "butRe";
            this.butRe.Size = new System.Drawing.Size(90, 58);
            this.butRe.TabIndex = 0;
            this.butRe.Text = "RE";
            this.butRe.UseVisualStyleBackColor = false;
            this.butRe.Click += new System.EventHandler(this.DeleteNumber);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(0, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 77);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(402, 522);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.but6);
            this.Controls.Add(this.but5);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but0);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.but9);
            this.Controls.Add(this.but8);
            this.Controls.Add(this.but7);
            this.Controls.Add(this.butRe);
            this.Controls.Add(this.butDE);
            this.Controls.Add(this.butMod);
            this.Controls.Add(this.butDiv);
            this.Controls.Add(this.butMult);
            this.Controls.Add(this.butMines);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butEq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butEq;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butMines;
        private System.Windows.Forms.Button butMult;
        private System.Windows.Forms.Button butDiv;
        private System.Windows.Forms.Button butMod;
        private System.Windows.Forms.Button butDE;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button butRe;
        private System.Windows.Forms.TextBox textBox1;
    }
}

