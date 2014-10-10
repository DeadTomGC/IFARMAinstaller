namespace IFARMAinstaller
{
    partial class IFARMAinstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IFARMAinstaller));
            this.ifl = new System.Windows.Forms.Button();
            this.A2l = new System.Windows.Forms.Button();
            this.AOAl = new System.Windows.Forms.Button();
            this.tmpdir = new System.Windows.Forms.Button();
            this.tfsize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ifl
            // 
            this.ifl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ifl.BackColor = System.Drawing.Color.OliveDrab;
            this.ifl.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.ifl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ifl.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ifl.Location = new System.Drawing.Point(330, 34);
            this.ifl.Name = "ifl";
            this.ifl.Size = new System.Drawing.Size(150, 29);
            this.ifl.TabIndex = 0;
            this.ifl.Text = "IronFront Location";
            this.ifl.UseVisualStyleBackColor = false;
            // 
            // A2l
            // 
            this.A2l.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.A2l.BackColor = System.Drawing.Color.Olive;
            this.A2l.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.A2l.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A2l.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2l.Location = new System.Drawing.Point(330, 69);
            this.A2l.Name = "A2l";
            this.A2l.Size = new System.Drawing.Size(150, 29);
            this.A2l.TabIndex = 1;
            this.A2l.Text = "ARMA 2 Location";
            this.A2l.UseVisualStyleBackColor = false;
            // 
            // AOAl
            // 
            this.AOAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AOAl.BackColor = System.Drawing.Color.Goldenrod;
            this.AOAl.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.AOAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AOAl.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AOAl.Location = new System.Drawing.Point(330, 104);
            this.AOAl.Name = "AOAl";
            this.AOAl.Size = new System.Drawing.Size(150, 29);
            this.AOAl.TabIndex = 2;
            this.AOAl.Text = "ARMA 2 OA Location";
            this.AOAl.UseVisualStyleBackColor = false;
            // 
            // tmpdir
            // 
            this.tmpdir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tmpdir.BackColor = System.Drawing.Color.Gold;
            this.tmpdir.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.tmpdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tmpdir.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmpdir.Location = new System.Drawing.Point(330, 139);
            this.tmpdir.Name = "tmpdir";
            this.tmpdir.Size = new System.Drawing.Size(150, 29);
            this.tmpdir.TabIndex = 3;
            this.tmpdir.Text = "Temp Folder DIR";
            this.tmpdir.UseVisualStyleBackColor = false;
            // 
            // tfsize
            // 
            this.tfsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tfsize.AutoSize = true;
            this.tfsize.BackColor = System.Drawing.Color.Gold;
            this.tfsize.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfsize.Location = new System.Drawing.Point(330, 179);
            this.tfsize.Name = "tfsize";
            this.tfsize.Size = new System.Drawing.Size(119, 14);
            this.tfsize.TabIndex = 4;
            this.tfsize.Text = "0 MBs inTemp DIR";
            // 
            // IFARMAinstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 545);
            this.Controls.Add(this.tfsize);
            this.Controls.Add(this.tmpdir);
            this.Controls.Add(this.AOAl);
            this.Controls.Add(this.A2l);
            this.Controls.Add(this.ifl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IFARMAinstaller";
            this.Text = "IFARMAinstaller";
            this.Load += new System.EventHandler(this.IFARMAinstaller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ifl;
        private System.Windows.Forms.Button A2l;
        private System.Windows.Forms.Button AOAl;
        private System.Windows.Forms.Button tmpdir;
        private System.Windows.Forms.Label tfsize;
    }
}

