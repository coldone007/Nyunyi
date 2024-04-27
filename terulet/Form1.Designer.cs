using System.Windows.Forms;

namespace terulet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.szamit = new System.Windows.Forms.Button();
            this.oldalX = new System.Windows.Forms.TextBox();
            this.oldalY = new System.Windows.Forms.TextBox();
            this.nyunyi = new System.Windows.Forms.Label();
            this.oldalZ = new System.Windows.Forms.TextBox();
            this.LBLoldalX = new System.Windows.Forms.Label();
            this.LBLoldalY = new System.Windows.Forms.Label();
            this.LBLoldalZ = new System.Windows.Forms.Label();
            this.elozmenyek = new System.Windows.Forms.ListBox();
            this.shapeList = new System.Windows.Forms.ListBox();
            this.unitList = new System.Windows.Forms.ListBox();
            this.groupBoxAlap = new System.Windows.Forms.GroupBox();
            this.debug2 = new System.Windows.Forms.RichTextBox();
            this.groupBoxEredmeny = new System.Windows.Forms.GroupBox();
            this.groupBoxAdatok = new System.Windows.Forms.GroupBox();
            this.groupBoxElozmenyek = new System.Windows.Forms.GroupBox();
            this.t = new System.Windows.Forms.ToolTip(this.components);
            this.litermasol = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxTragya = new System.Windows.Forms.GroupBox();
            this.godorelozmeny = new System.Windows.Forms.ListBox();
            this.tragyaszamit = new System.Windows.Forms.Button();
            this.TXTtragyakell = new System.Windows.Forms.TextBox();
            this.LBLszukseg = new System.Windows.Forms.Label();
            this.LBLtragya = new System.Windows.Forms.Label();
            this.LBLgodor = new System.Windows.Forms.Label();
            this.TXTtragya = new System.Windows.Forms.TextBox();
            this.TXTgodor = new System.Windows.Forms.TextBox();
            this.groupBoxElolnezet = new System.Windows.Forms.GroupBox();
            this.pictureBoxElolnezet = new System.Windows.Forms.PictureBox();
            this.groupBoxUnit = new System.Windows.Forms.GroupBox();
            this.buttonLove = new System.Windows.Forms.Button();
            this.groupBoxAlap.SuspendLayout();
            this.groupBoxEredmeny.SuspendLayout();
            this.groupBoxAdatok.SuspendLayout();
            this.groupBoxElozmenyek.SuspendLayout();
            this.groupBoxTragya.SuspendLayout();
            this.groupBoxElolnezet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElolnezet)).BeginInit();
            this.groupBoxUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // szamit
            // 
            this.szamit.BackColor = System.Drawing.SystemColors.Window;
            this.szamit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szamit.Location = new System.Drawing.Point(168, 238);
            this.szamit.Name = "szamit";
            this.szamit.Size = new System.Drawing.Size(130, 38);
            this.szamit.TabIndex = 0;
            this.szamit.Text = "Számít";
            this.szamit.UseVisualStyleBackColor = false;
            this.szamit.Click += new System.EventHandler(this.szamit_Click);
            // 
            // oldalX
            // 
            this.oldalX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldalX.Location = new System.Drawing.Point(17, 39);
            this.oldalX.Name = "oldalX";
            this.oldalX.Size = new System.Drawing.Size(100, 20);
            this.oldalX.TabIndex = 1;
            this.oldalX.Visible = false;
            // 
            // oldalY
            // 
            this.oldalY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldalY.Location = new System.Drawing.Point(17, 78);
            this.oldalY.Name = "oldalY";
            this.oldalY.Size = new System.Drawing.Size(100, 20);
            this.oldalY.TabIndex = 2;
            this.oldalY.Visible = false;
            // 
            // nyunyi
            // 
            this.nyunyi.AutoSize = true;
            this.nyunyi.BackColor = System.Drawing.Color.Transparent;
            this.nyunyi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nyunyi.ForeColor = System.Drawing.Color.White;
            this.nyunyi.Location = new System.Drawing.Point(7, 9);
            this.nyunyi.Name = "nyunyi";
            this.nyunyi.Size = new System.Drawing.Size(281, 25);
            this.nyunyi.TabIndex = 4;
            this.nyunyi.Text = "Nyünyi számitási segédje =)";
            // 
            // oldalZ
            // 
            this.oldalZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldalZ.Location = new System.Drawing.Point(17, 117);
            this.oldalZ.Name = "oldalZ";
            this.oldalZ.Size = new System.Drawing.Size(100, 20);
            this.oldalZ.TabIndex = 7;
            this.oldalZ.Visible = false;
            // 
            // LBLoldalX
            // 
            this.LBLoldalX.AutoSize = true;
            this.LBLoldalX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBLoldalX.ForeColor = System.Drawing.Color.Red;
            this.LBLoldalX.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBLoldalX.Location = new System.Drawing.Point(14, 23);
            this.LBLoldalX.Name = "LBLoldalX";
            this.LBLoldalX.Size = new System.Drawing.Size(19, 13);
            this.LBLoldalX.TabIndex = 8;
            this.LBLoldalX.Text = "X:";
            this.LBLoldalX.Visible = false;
            // 
            // LBLoldalY
            // 
            this.LBLoldalY.AutoSize = true;
            this.LBLoldalY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBLoldalY.ForeColor = System.Drawing.Color.Red;
            this.LBLoldalY.Location = new System.Drawing.Point(14, 62);
            this.LBLoldalY.Name = "LBLoldalY";
            this.LBLoldalY.Size = new System.Drawing.Size(19, 13);
            this.LBLoldalY.TabIndex = 9;
            this.LBLoldalY.Text = "Y:";
            this.LBLoldalY.Visible = false;
            // 
            // LBLoldalZ
            // 
            this.LBLoldalZ.AutoSize = true;
            this.LBLoldalZ.BackColor = System.Drawing.Color.Transparent;
            this.LBLoldalZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBLoldalZ.ForeColor = System.Drawing.Color.Red;
            this.LBLoldalZ.Location = new System.Drawing.Point(14, 101);
            this.LBLoldalZ.Name = "LBLoldalZ";
            this.LBLoldalZ.Size = new System.Drawing.Size(19, 13);
            this.LBLoldalZ.TabIndex = 10;
            this.LBLoldalZ.Text = "Z:";
            this.LBLoldalZ.Visible = false;
            // 
            // elozmenyek
            // 
            this.elozmenyek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elozmenyek.FormattingEnabled = true;
            this.elozmenyek.HorizontalScrollbar = true;
            this.elozmenyek.Location = new System.Drawing.Point(10, 20);
            this.elozmenyek.Name = "elozmenyek";
            this.elozmenyek.Size = new System.Drawing.Size(492, 106);
            this.elozmenyek.TabIndex = 17;
            // 
            // shapeList
            // 
            this.shapeList.BackColor = System.Drawing.SystemColors.Window;
            this.shapeList.FormattingEnabled = true;
            this.shapeList.Items.AddRange(new object[] {
            "Négyzet",
            "Kör",
            "Kocka",
            "Téglatest",
            "Henger",
            "Gömb"});
            this.shapeList.Location = new System.Drawing.Point(10, 20);
            this.shapeList.Name = "shapeList";
            this.shapeList.Size = new System.Drawing.Size(130, 82);
            this.shapeList.TabIndex = 21;
            this.shapeList.Tag = "";
            this.shapeList.SelectedIndexChanged += new System.EventHandler(this.shapeList_SelectedIndexChanged);
            // 
            // unitList
            // 
            this.unitList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitList.FormattingEnabled = true;
            this.unitList.Items.AddRange(new object[] {
            "m",
            "cm",
            "mm"});
            this.unitList.Location = new System.Drawing.Point(10, 20);
            this.unitList.Name = "unitList";
            this.unitList.Size = new System.Drawing.Size(130, 67);
            this.unitList.TabIndex = 22;
            // 
            // groupBoxAlap
            // 
            this.groupBoxAlap.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAlap.Controls.Add(this.shapeList);
            this.groupBoxAlap.ForeColor = System.Drawing.Color.White;
            this.groupBoxAlap.Location = new System.Drawing.Point(12, 46);
            this.groupBoxAlap.Name = "groupBoxAlap";
            this.groupBoxAlap.Size = new System.Drawing.Size(150, 112);
            this.groupBoxAlap.TabIndex = 23;
            this.groupBoxAlap.TabStop = false;
            this.groupBoxAlap.Text = "Forma";
            // 
            // debug2
            // 
            this.debug2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debug2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.debug2.Location = new System.Drawing.Point(10, 20);
            this.debug2.Name = "debug2";
            this.debug2.Size = new System.Drawing.Size(492, 83);
            this.debug2.TabIndex = 24;
            this.debug2.Text = "";
            this.t.SetToolTip(this.debug2, "Ez a szöveg másolható!");
            // 
            // groupBoxEredmeny
            // 
            this.groupBoxEredmeny.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEredmeny.Controls.Add(this.debug2);
            this.groupBoxEredmeny.ForeColor = System.Drawing.Color.White;
            this.groupBoxEredmeny.Location = new System.Drawing.Point(12, 282);
            this.groupBoxEredmeny.Name = "groupBoxEredmeny";
            this.groupBoxEredmeny.Size = new System.Drawing.Size(512, 113);
            this.groupBoxEredmeny.TabIndex = 25;
            this.groupBoxEredmeny.TabStop = false;
            this.groupBoxEredmeny.Text = "Eredmény";
            // 
            // groupBoxAdatok
            // 
            this.groupBoxAdatok.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAdatok.Controls.Add(this.oldalX);
            this.groupBoxAdatok.Controls.Add(this.oldalY);
            this.groupBoxAdatok.Controls.Add(this.oldalZ);
            this.groupBoxAdatok.Controls.Add(this.LBLoldalX);
            this.groupBoxAdatok.Controls.Add(this.LBLoldalZ);
            this.groupBoxAdatok.Controls.Add(this.LBLoldalY);
            this.groupBoxAdatok.ForeColor = System.Drawing.Color.White;
            this.groupBoxAdatok.Location = new System.Drawing.Point(168, 46);
            this.groupBoxAdatok.Name = "groupBoxAdatok";
            this.groupBoxAdatok.Size = new System.Drawing.Size(130, 186);
            this.groupBoxAdatok.TabIndex = 26;
            this.groupBoxAdatok.TabStop = false;
            this.groupBoxAdatok.Text = "Adatok";
            // 
            // groupBoxElozmenyek
            // 
            this.groupBoxElozmenyek.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxElozmenyek.Controls.Add(this.elozmenyek);
            this.groupBoxElozmenyek.ForeColor = System.Drawing.Color.White;
            this.groupBoxElozmenyek.Location = new System.Drawing.Point(12, 401);
            this.groupBoxElozmenyek.Name = "groupBoxElozmenyek";
            this.groupBoxElozmenyek.Size = new System.Drawing.Size(512, 136);
            this.groupBoxElozmenyek.TabIndex = 27;
            this.groupBoxElozmenyek.TabStop = false;
            this.groupBoxElozmenyek.Text = "Előzmények";
            // 
            // t
            // 
            this.t.AutoPopDelay = 5000;
            this.t.InitialDelay = 50;
            this.t.ReshowDelay = 0;
            // 
            // litermasol
            // 
            this.litermasol.Enabled = false;
            this.litermasol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.litermasol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.litermasol.Location = new System.Drawing.Point(224, 17);
            this.litermasol.Name = "litermasol";
            this.litermasol.Size = new System.Drawing.Size(55, 20);
            this.litermasol.TabIndex = 7;
            this.litermasol.Text = "Másol";
            this.t.SetToolTip(this.litermasol, "Kiszámolt űrtartalom másolása.");
            this.litermasol.UseVisualStyleBackColor = true;
            this.litermasol.Click += new System.EventHandler(this.litermasol_Click);
            // 
            // groupBoxTragya
            // 
            this.groupBoxTragya.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTragya.Controls.Add(this.godorelozmeny);
            this.groupBoxTragya.Controls.Add(this.litermasol);
            this.groupBoxTragya.Controls.Add(this.tragyaszamit);
            this.groupBoxTragya.Controls.Add(this.TXTtragyakell);
            this.groupBoxTragya.Controls.Add(this.LBLszukseg);
            this.groupBoxTragya.Controls.Add(this.LBLtragya);
            this.groupBoxTragya.Controls.Add(this.LBLgodor);
            this.groupBoxTragya.Controls.Add(this.TXTtragya);
            this.groupBoxTragya.Controls.Add(this.TXTgodor);
            this.groupBoxTragya.ForeColor = System.Drawing.Color.White;
            this.groupBoxTragya.Location = new System.Drawing.Point(12, 543);
            this.groupBoxTragya.Name = "groupBoxTragya";
            this.groupBoxTragya.Size = new System.Drawing.Size(512, 238);
            this.groupBoxTragya.TabIndex = 28;
            this.groupBoxTragya.TabStop = false;
            this.groupBoxTragya.Text = "Trágya koncentráció";
            // 
            // godorelozmeny
            // 
            this.godorelozmeny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.godorelozmeny.FormattingEnabled = true;
            this.godorelozmeny.HorizontalScrollbar = true;
            this.godorelozmeny.Location = new System.Drawing.Point(10, 121);
            this.godorelozmeny.Name = "godorelozmeny";
            this.godorelozmeny.Size = new System.Drawing.Size(492, 106);
            this.godorelozmeny.TabIndex = 8;
            // 
            // tragyaszamit
            // 
            this.tragyaszamit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tragyaszamit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tragyaszamit.Location = new System.Drawing.Point(19, 67);
            this.tragyaszamit.Name = "tragyaszamit";
            this.tragyaszamit.Size = new System.Drawing.Size(199, 22);
            this.tragyaszamit.TabIndex = 6;
            this.tragyaszamit.Text = "Számít";
            this.tragyaszamit.UseVisualStyleBackColor = true;
            this.tragyaszamit.Click += new System.EventHandler(this.tragyaszamit_Click);
            // 
            // TXTtragyakell
            // 
            this.TXTtragyakell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTtragyakell.Location = new System.Drawing.Point(118, 95);
            this.TXTtragyakell.Name = "TXTtragyakell";
            this.TXTtragyakell.Size = new System.Drawing.Size(100, 20);
            this.TXTtragyakell.TabIndex = 5;
            // 
            // LBLszukseg
            // 
            this.LBLszukseg.AutoSize = true;
            this.LBLszukseg.Location = new System.Drawing.Point(16, 97);
            this.LBLszukseg.Name = "LBLszukseg";
            this.LBLszukseg.Size = new System.Drawing.Size(96, 13);
            this.LBLszukseg.TabIndex = 4;
            this.LBLszukseg.Text = "Trágya szükséglet:";
            // 
            // LBLtragya
            // 
            this.LBLtragya.AutoSize = true;
            this.LBLtragya.Location = new System.Drawing.Point(20, 45);
            this.LBLtragya.Name = "LBLtragya";
            this.LBLtragya.Size = new System.Drawing.Size(93, 13);
            this.LBLtragya.TabIndex = 3;
            this.LBLtragya.Text = "Trágya százaléka:";
            // 
            // LBLgodor
            // 
            this.LBLgodor.AutoSize = true;
            this.LBLgodor.Location = new System.Drawing.Point(28, 19);
            this.LBLgodor.Name = "LBLgodor";
            this.LBLgodor.Size = new System.Drawing.Size(84, 13);
            this.LBLgodor.TabIndex = 2;
            this.LBLgodor.Text = "Gödör térfogata:";
            // 
            // TXTtragya
            // 
            this.TXTtragya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTtragya.Location = new System.Drawing.Point(118, 43);
            this.TXTtragya.Name = "TXTtragya";
            this.TXTtragya.Size = new System.Drawing.Size(100, 20);
            this.TXTtragya.TabIndex = 1;
            // 
            // TXTgodor
            // 
            this.TXTgodor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTgodor.Location = new System.Drawing.Point(118, 17);
            this.TXTgodor.Name = "TXTgodor";
            this.TXTgodor.Size = new System.Drawing.Size(100, 20);
            this.TXTgodor.TabIndex = 0;
            // 
            // groupBoxElolnezet
            // 
            this.groupBoxElolnezet.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxElolnezet.Controls.Add(this.pictureBoxElolnezet);
            this.groupBoxElolnezet.ForeColor = System.Drawing.Color.White;
            this.groupBoxElolnezet.Location = new System.Drawing.Point(304, 46);
            this.groupBoxElolnezet.Name = "groupBoxElolnezet";
            this.groupBoxElolnezet.Size = new System.Drawing.Size(220, 230);
            this.groupBoxElolnezet.TabIndex = 29;
            this.groupBoxElolnezet.TabStop = false;
            this.groupBoxElolnezet.Text = "Képes elölnézet";
            // 
            // pictureBoxElolnezet
            // 
            this.pictureBoxElolnezet.BackColor = System.Drawing.Color.White;
            this.pictureBoxElolnezet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxElolnezet.Location = new System.Drawing.Point(10, 20);
            this.pictureBoxElolnezet.Name = "pictureBoxElolnezet";
            this.pictureBoxElolnezet.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxElolnezet.TabIndex = 0;
            this.pictureBoxElolnezet.TabStop = false;
            // 
            // groupBoxUnit
            // 
            this.groupBoxUnit.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxUnit.Controls.Add(this.unitList);
            this.groupBoxUnit.ForeColor = System.Drawing.Color.White;
            this.groupBoxUnit.Location = new System.Drawing.Point(12, 170);
            this.groupBoxUnit.Name = "groupBoxUnit";
            this.groupBoxUnit.Size = new System.Drawing.Size(150, 106);
            this.groupBoxUnit.TabIndex = 30;
            this.groupBoxUnit.TabStop = false;
            this.groupBoxUnit.Text = "Mértékegység";
            // 
            // buttonLove
            // 
            this.buttonLove.BackColor = System.Drawing.Color.Transparent;
            this.buttonLove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLove.Image = global::terulet.Properties.Resources.sziv_30x30;
            this.buttonLove.Location = new System.Drawing.Point(493, 12);
            this.buttonLove.Name = "buttonLove";
            this.buttonLove.Size = new System.Drawing.Size(31, 31);
            this.buttonLove.TabIndex = 31;
            this.buttonLove.UseVisualStyleBackColor = false;
            this.buttonLove.Click += new System.EventHandler(this.buttonLove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::terulet.Properties.Resources.DRM_0iIn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 791);
            this.Controls.Add(this.buttonLove);
            this.Controls.Add(this.groupBoxUnit);
            this.Controls.Add(this.groupBoxElolnezet);
            this.Controls.Add(this.groupBoxTragya);
            this.Controls.Add(this.groupBoxElozmenyek);
            this.Controls.Add(this.szamit);
            this.Controls.Add(this.groupBoxAdatok);
            this.Controls.Add(this.groupBoxEredmeny);
            this.Controls.Add(this.groupBoxAlap);
            this.Controls.Add(this.nyunyi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ultimate Nyünyi segéd";
            this.groupBoxAlap.ResumeLayout(false);
            this.groupBoxEredmeny.ResumeLayout(false);
            this.groupBoxAdatok.ResumeLayout(false);
            this.groupBoxAdatok.PerformLayout();
            this.groupBoxElozmenyek.ResumeLayout(false);
            this.groupBoxTragya.ResumeLayout(false);
            this.groupBoxTragya.PerformLayout();
            this.groupBoxElolnezet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElolnezet)).EndInit();
            this.groupBoxUnit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button szamit;
        private System.Windows.Forms.TextBox oldalX;
        private System.Windows.Forms.TextBox oldalY;
        private System.Windows.Forms.Label nyunyi;
        private System.Windows.Forms.TextBox oldalZ;
        private System.Windows.Forms.Label LBLoldalX;
        private System.Windows.Forms.Label LBLoldalY;
        private System.Windows.Forms.Label LBLoldalZ;
        private System.Windows.Forms.ListBox elozmenyek;
        private System.Windows.Forms.ListBox shapeList;
        private System.Windows.Forms.ListBox unitList;
        private System.Windows.Forms.GroupBox groupBoxAlap;
        private System.Windows.Forms.RichTextBox debug2;
        private System.Windows.Forms.GroupBox groupBoxEredmeny;
        private System.Windows.Forms.GroupBox groupBoxAdatok;
        private System.Windows.Forms.GroupBox groupBoxElozmenyek;
        private ToolTip t;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBoxTragya;
        private Label LBLtragya;
        private Label LBLgodor;
        private TextBox TXTtragya;
        private TextBox TXTgodor;
        private TextBox TXTtragyakell;
        private Label LBLszukseg;
        private Button tragyaszamit;
        private Button litermasol;
        private ListBox godorelozmeny;
        private GroupBox groupBoxElolnezet;
        private PictureBox pictureBoxElolnezet;
        private GroupBox groupBoxUnit;
        private Button buttonLove;
    }
}

