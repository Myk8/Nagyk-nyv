namespace Nagykönyv
{
    partial class FrmLista
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
            this.konyvek = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helyezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.szerzokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujKonyvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.konyvek)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // konyvek
            // 
            this.konyvek.AllowUserToAddRows = false;
            this.konyvek.AllowUserToDeleteRows = false;
            this.konyvek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.konyvek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.helyezes,
            this.nev,
            this.cim});
            this.konyvek.Location = new System.Drawing.Point(16, 115);
            this.konyvek.Margin = new System.Windows.Forms.Padding(4);
            this.konyvek.Name = "konyvek";
            this.konyvek.ReadOnly = true;
            this.konyvek.RowHeadersWidth = 51;
            this.konyvek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.konyvek.Size = new System.Drawing.Size(689, 322);
            this.konyvek.TabIndex = 8;
            this.konyvek.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.konyvek_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "konyv(ID)";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // helyezes
            // 
            this.helyezes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.helyezes.HeaderText = "helyezes";
            this.helyezes.MinimumWidth = 6;
            this.helyezes.Name = "helyezes";
            this.helyezes.ReadOnly = true;
            // 
            // nev
            // 
            this.nev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nev.HeaderText = "nev";
            this.nev.MinimumWidth = 6;
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // cim
            // 
            this.cim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cim.HeaderText = "cim";
            this.cim.MinimumWidth = 6;
            this.cim.Name = "cim";
            this.cim.ReadOnly = true;
            // 
            // keres
            // 
            this.keres.Location = new System.Drawing.Point(162, 85);
            this.keres.Margin = new System.Windows.Forms.Padding(4);
            this.keres.Name = "keres";
            this.keres.Size = new System.Drawing.Size(371, 22);
            this.keres.TabIndex = 7;
            this.keres.TextChanged += new System.EventHandler(this.keres_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(171, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Keresés szerző vagy cím alapján";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerzokToolStripMenuItem,
            this.ujKonyvToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // szerzokToolStripMenuItem
            // 
            this.szerzokToolStripMenuItem.Name = "szerzokToolStripMenuItem";
            this.szerzokToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.szerzokToolStripMenuItem.Text = "Szerzők";
            // 
            // ujKonyvToolStripMenuItem
            // 
            this.ujKonyvToolStripMenuItem.Name = "ujKonyvToolStripMenuItem";
            this.ujKonyvToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.ujKonyvToolStripMenuItem.Text = "Új Könyv";
            this.ujKonyvToolStripMenuItem.Click += new System.EventHandler(this.ujKonyvToolStripMenuItem_Click);
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.konyvek);
            this.Controls.Add(this.keres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmLista";
            this.Text = "Nagykönyv";
            this.Activated += new System.EventHandler(this.FrmLista_Activated);
            this.Load += new System.EventHandler(this.FrmLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.konyvek)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView konyvek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn helyezes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cim;
        private System.Windows.Forms.TextBox keres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szerzokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujKonyvToolStripMenuItem;
    }
}