using System.Collections.Generic;

namespace HittaJulita_koduppgift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.streetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contains1 = new System.Windows.Forms.CheckBox();
            this.contains = new System.Windows.Forms.CheckBox();
            this.and = new System.Windows.Forms.RadioButton();
            this.or = new System.Windows.Forms.RadioButton();
            this.Gatuplats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // streetName
            // 
            this.streetName.Location = new System.Drawing.Point(141, 219);
            this.streetName.Name = "streetName";
            this.streetName.Size = new System.Drawing.Size(233, 23);
            this.streetName.TabIndex = 0;
            this.streetName.TextChanged += new System.EventHandler(this.streetName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Tag = "Gatuplats";
            this.label1.Text = "Gatuplats";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // zip
            // 
            this.zip.Location = new System.Drawing.Point(141, 289);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(233, 23);
            this.zip.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Tag = "Gatuplats";
            this.label2.Text = "Postnummer";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(196, 371);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(116, 23);
            this.search.TabIndex = 2;
            this.search.Text = "Sök";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(161, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "HittaIJulita-sökmotor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // contains1
            // 
            this.contains1.AutoSize = true;
            this.contains1.Location = new System.Drawing.Point(437, 291);
            this.contains1.Name = "contains1";
            this.contains1.Size = new System.Drawing.Size(330, 19);
            this.contains1.TabIndex = 4;
            this.contains1.Text = "Innehåller (utelämnas om du söker efter ett exakt resultat)";
            this.contains1.UseVisualStyleBackColor = true;
            // 
            // contains
            // 
            this.contains.AutoSize = true;
            this.contains.Location = new System.Drawing.Point(437, 218);
            this.contains.Name = "contains";
            this.contains.Size = new System.Drawing.Size(330, 19);
            this.contains.TabIndex = 4;
            this.contains.Text = "Innehåller (utelämnas om du söker efter ett exakt resultat)";
            this.contains.UseVisualStyleBackColor = true;
            // 
            // and
            // 
            this.and.AutoSize = true;
            this.and.Location = new System.Drawing.Point(152, 248);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(51, 19);
            this.and.TabIndex = 5;
            this.and.TabStop = true;
            this.and.Text = "OCH";
            this.and.UseVisualStyleBackColor = true;
            // 
            // or
            // 
            this.or.AutoSize = true;
            this.or.Location = new System.Drawing.Point(273, 248);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(56, 19);
            this.or.TabIndex = 6;
            this.or.TabStop = true;
            this.or.Text = "ELLER";
            this.or.UseVisualStyleBackColor = true;
            // 
            // Gatuplats
            // 
            this.Gatuplats.HeaderText = "Gatuplats";
            this.Gatuplats.Name = "Gatuplats";
            // 
            // Postkod
            // 
            this.Postkod.HeaderText = "Postkod";
            this.Postkod.Name = "Postkod";
            // 
            // Plats
            // 
            this.Plats.HeaderText = "Plats";
            this.Plats.Name = "Plats";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gatuplats,
            this.Postkod,
            this.Plats});
            this.dataGridView1.Location = new System.Drawing.Point(898, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 437);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(78, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "HittaIJulita sökmotor är en tjänst som hjälper dig att hitta bättre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 57);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 472);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.or);
            this.Controls.Add(this.and);
            this.Controls.Add(this.contains);
            this.Controls.Add(this.contains1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.streetName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Tag = "Gatuplats";
            this.Text = "Gatuplats";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox streetName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox contains1;
        private System.Windows.Forms.CheckBox contains;
        private System.Windows.Forms.RadioButton and;
        private System.Windows.Forms.RadioButton or;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gatuplats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plats;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

