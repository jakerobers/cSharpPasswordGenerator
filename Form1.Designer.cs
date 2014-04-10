namespace WindowsFormsApplication2
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
            this.components = new System.ComponentModel.Container();
            this.Numbers = new System.Windows.Forms.CheckBox();
            this.Symbols = new System.Windows.Forms.CheckBox();
            this.Similars = new System.Windows.Forms.CheckBox();
            this.Title = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.Capitals = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Numbers
            // 
            this.Numbers.AutoSize = true;
            this.Numbers.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numbers.Location = new System.Drawing.Point(107, 52);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(90, 25);
            this.Numbers.TabIndex = 0;
            this.Numbers.Text = "Numbers";
            this.Numbers.UseVisualStyleBackColor = true;
            // 
            // Symbols
            // 
            this.Symbols.AutoSize = true;
            this.Symbols.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Symbols.Location = new System.Drawing.Point(203, 52);
            this.Symbols.Name = "Symbols";
            this.Symbols.Size = new System.Drawing.Size(86, 25);
            this.Symbols.TabIndex = 1;
            this.Symbols.Text = "Symbols";
            this.Symbols.UseVisualStyleBackColor = true;
            // 
            // Similars
            // 
            this.Similars.AutoSize = true;
            this.Similars.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Similars.Location = new System.Drawing.Point(295, 52);
            this.Similars.Name = "Similars";
            this.Similars.Size = new System.Drawing.Size(85, 25);
            this.Similars.TabIndex = 2;
            this.Similars.Text = "Similars";
            this.Similars.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(195, 21);
            this.Title.TabIndex = 4;
            this.Title.Text = "Random Password Generator";
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(435, 56);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(46, 22);
            this.Length.TabIndex = 5;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(104, 105);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(77, 17);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password: ";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthLabel.Location = new System.Drawing.Point(386, 56);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(54, 21);
            this.LengthLabel.TabIndex = 8;
            this.LengthLabel.Text = "Length";
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(16, 96);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(87, 33);
            this.Generate.TabIndex = 9;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Capitals
            // 
            this.Capitals.AutoSize = true;
            this.Capitals.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capitals.Location = new System.Drawing.Point(16, 52);
            this.Capitals.Name = "Capitals";
            this.Capitals.Size = new System.Drawing.Size(85, 25);
            this.Capitals.TabIndex = 10;
            this.Capitals.Text = "Capitals";
            this.Capitals.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(200, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(534, 28);
            this.menuStrip2.TabIndex = 11;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleToolStripMenuItem,
            this.bulkToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // singleToolStripMenuItem
            // 
            this.singleToolStripMenuItem.Name = "singleToolStripMenuItem";
            this.singleToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.singleToolStripMenuItem.Text = "Single";
            // 
            // bulkToolStripMenuItem
            // 
            this.bulkToolStripMenuItem.Name = "bulkToolStripMenuItem";
            this.bulkToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.bulkToolStripMenuItem.Text = "Bulk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 158);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.Capitals);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Similars);
            this.Controls.Add(this.Symbols);
            this.Controls.Add(this.Numbers);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "Random Password Generator";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Numbers;
        private System.Windows.Forms.CheckBox Symbols;
        private System.Windows.Forms.CheckBox Similars;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.CheckBox Capitals;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulkToolStripMenuItem;

    }
}

