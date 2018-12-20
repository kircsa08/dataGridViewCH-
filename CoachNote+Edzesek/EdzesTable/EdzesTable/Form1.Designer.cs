namespace EdzesTable
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
            this.dataGridViewEdzesek = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonModosit = new System.Windows.Forms.Button();
            this.buttonMegse = new System.Windows.Forms.Button();
            this.buttonTorol = new System.Windows.Forms.Button();
            this.buttonUj = new System.Windows.Forms.Button();
            this.buttonMent = new System.Windows.Forms.Button();
            this.buttonKilep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdzesek)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEdzesek
            // 
            this.dataGridViewEdzesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEdzesek.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEdzesek.Name = "dataGridViewEdzesek";
            this.dataGridViewEdzesek.Size = new System.Drawing.Size(662, 425);
            this.dataGridViewEdzesek.TabIndex = 0;
            this.dataGridViewEdzesek.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEdzesek_CellValueChanged);
            this.dataGridViewEdzesek.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewEdzesek_DefaultValuesNeeded);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Betöltés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonModosit
            // 
            this.buttonModosit.Location = new System.Drawing.Point(694, 90);
            this.buttonModosit.Name = "buttonModosit";
            this.buttonModosit.Size = new System.Drawing.Size(75, 23);
            this.buttonModosit.TabIndex = 2;
            this.buttonModosit.Text = "Módosít";
            this.buttonModosit.UseVisualStyleBackColor = true;
            // 
            // buttonMegse
            // 
            this.buttonMegse.Location = new System.Drawing.Point(694, 143);
            this.buttonMegse.Name = "buttonMegse";
            this.buttonMegse.Size = new System.Drawing.Size(75, 23);
            this.buttonMegse.TabIndex = 3;
            this.buttonMegse.Text = "Mégse";
            this.buttonMegse.UseVisualStyleBackColor = true;
            this.buttonMegse.Click += new System.EventHandler(this.buttonMegse_Click);
            // 
            // buttonTorol
            // 
            this.buttonTorol.Location = new System.Drawing.Point(694, 198);
            this.buttonTorol.Name = "buttonTorol";
            this.buttonTorol.Size = new System.Drawing.Size(75, 23);
            this.buttonTorol.TabIndex = 4;
            this.buttonTorol.Text = "Töröl";
            this.buttonTorol.UseVisualStyleBackColor = true;
            this.buttonTorol.Click += new System.EventHandler(this.buttonTorol_Click);
            // 
            // buttonUj
            // 
            this.buttonUj.Location = new System.Drawing.Point(694, 258);
            this.buttonUj.Name = "buttonUj";
            this.buttonUj.Size = new System.Drawing.Size(75, 23);
            this.buttonUj.TabIndex = 5;
            this.buttonUj.Text = "Új Edzés";
            this.buttonUj.UseVisualStyleBackColor = true;
            this.buttonUj.Click += new System.EventHandler(this.buttonUj_Click);
            // 
            // buttonMent
            // 
            this.buttonMent.Location = new System.Drawing.Point(694, 319);
            this.buttonMent.Name = "buttonMent";
            this.buttonMent.Size = new System.Drawing.Size(75, 23);
            this.buttonMent.TabIndex = 6;
            this.buttonMent.Text = "Mentés";
            this.buttonMent.UseVisualStyleBackColor = true;
            this.buttonMent.Click += new System.EventHandler(this.buttonMent_Click);
            // 
            // buttonKilep
            // 
            this.buttonKilep.Location = new System.Drawing.Point(694, 379);
            this.buttonKilep.Name = "buttonKilep";
            this.buttonKilep.Size = new System.Drawing.Size(75, 23);
            this.buttonKilep.TabIndex = 7;
            this.buttonKilep.Text = "Kilépés";
            this.buttonKilep.UseVisualStyleBackColor = true;
            this.buttonKilep.Click += new System.EventHandler(this.buttonKilep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKilep);
            this.Controls.Add(this.buttonMent);
            this.Controls.Add(this.buttonUj);
            this.Controls.Add(this.buttonTorol);
            this.Controls.Add(this.buttonMegse);
            this.Controls.Add(this.buttonModosit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewEdzesek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdzesek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEdzesek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonModosit;
        private System.Windows.Forms.Button buttonMegse;
        private System.Windows.Forms.Button buttonTorol;
        private System.Windows.Forms.Button buttonUj;
        private System.Windows.Forms.Button buttonMent;
        private System.Windows.Forms.Button buttonKilep;
    }
}

