namespace Nagykönyv
{
    partial class FrmKonyv
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
            this.szerzo = new System.Windows.Forms.ComboBox();
            this.tor = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.rog = new System.Windows.Forms.Button();
            this.helyezes = new System.Windows.Forms.TextBox();
            this.cim = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // szerzo
            // 
            this.szerzo.FormattingEnabled = true;
            this.szerzo.Location = new System.Drawing.Point(118, 102);
            this.szerzo.Margin = new System.Windows.Forms.Padding(4);
            this.szerzo.Name = "szerzo";
            this.szerzo.Size = new System.Drawing.Size(232, 24);
            this.szerzo.TabIndex = 22;
            // 
            // tor
            // 
            this.tor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tor.Location = new System.Drawing.Point(370, 272);
            this.tor.Margin = new System.Windows.Forms.Padding(4);
            this.tor.Name = "tor";
            this.tor.Size = new System.Drawing.Size(153, 69);
            this.tor.TabIndex = 21;
            this.tor.Text = "Törlés";
            this.tor.UseVisualStyleBackColor = true;
            this.tor.Click += new System.EventHandler(this.tor_Click);
            // 
            // mod
            // 
            this.mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mod.Location = new System.Drawing.Point(197, 272);
            this.mod.Margin = new System.Windows.Forms.Padding(4);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(153, 69);
            this.mod.TabIndex = 20;
            this.mod.Text = "Módosítás";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // rog
            // 
            this.rog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rog.Location = new System.Drawing.Point(4, 272);
            this.rog.Margin = new System.Windows.Forms.Padding(4);
            this.rog.Name = "rog";
            this.rog.Size = new System.Drawing.Size(153, 69);
            this.rog.TabIndex = 19;
            this.rog.Text = "Rögzítés";
            this.rog.UseVisualStyleBackColor = true;
            this.rog.Click += new System.EventHandler(this.rog_Click);
            // 
            // helyezes
            // 
            this.helyezes.Location = new System.Drawing.Point(118, 217);
            this.helyezes.Margin = new System.Windows.Forms.Padding(4);
            this.helyezes.Name = "helyezes";
            this.helyezes.Size = new System.Drawing.Size(232, 22);
            this.helyezes.TabIndex = 18;
            // 
            // cim
            // 
            this.cim.Location = new System.Drawing.Point(118, 161);
            this.cim.Margin = new System.Windows.Forms.Padding(4);
            this.cim.Name = "cim";
            this.cim.Size = new System.Drawing.Size(232, 22);
            this.cim.TabIndex = 17;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(118, 30);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(232, 22);
            this.id.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(-1, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "helyezés:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(47, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "cím:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "szerző:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // FrmKonyv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 348);
            this.Controls.Add(this.szerzo);
            this.Controls.Add(this.tor);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.rog);
            this.Controls.Add(this.helyezes);
            this.Controls.Add(this.cim);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmKonyv";
            this.Text = "KÖNYV";
            this.Load += new System.EventHandler(this.FrmKonyv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox szerzo;
        private System.Windows.Forms.Button tor;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button rog;
        private System.Windows.Forms.TextBox helyezes;
        private System.Windows.Forms.TextBox cim;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}