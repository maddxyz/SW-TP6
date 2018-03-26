namespace GameOfThronesTournamentWPF
{
    partial class CtrlMaison
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Hname = new System.Windows.Forms.Label();
            this.Bhname = new System.Windows.Forms.Label();
            this.NbUnits = new System.Windows.Forms.Label();
            this.BnbUnits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hname
            // 
            this.Hname.AutoSize = true;
            this.Hname.Location = new System.Drawing.Point(3, 7);
            this.Hname.Name = "Hname";
            this.Hname.Size = new System.Drawing.Size(38, 13);
            this.Hname.TabIndex = 0;
            this.Hname.Text = "Name:";
            this.Hname.Click += new System.EventHandler(this.Hname_Click);
            // 
            // Bhname
            // 
            this.Bhname.AutoSize = true;
            this.Bhname.Location = new System.Drawing.Point(66, 7);
            this.Bhname.Name = "Bhname";
            this.Bhname.Size = new System.Drawing.Size(35, 13);
            this.Bhname.TabIndex = 1;
            this.Bhname.Text = "Name";
            // 
            // NbUnits
            // 
            this.NbUnits.AutoSize = true;
            this.NbUnits.Location = new System.Drawing.Point(140, 7);
            this.NbUnits.Name = "NbUnits";
            this.NbUnits.Size = new System.Drawing.Size(41, 13);
            this.NbUnits.TabIndex = 2;
            this.NbUnits.Text = "#Units:";
            // 
            // BnbUnits
            // 
            this.BnbUnits.AutoSize = true;
            this.BnbUnits.Location = new System.Drawing.Point(210, 7);
            this.BnbUnits.Name = "BnbUnits";
            this.BnbUnits.Size = new System.Drawing.Size(38, 13);
            this.BnbUnits.TabIndex = 3;
            this.BnbUnits.Text = "#Units";
            // 
            // CtrlMaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BnbUnits);
            this.Controls.Add(this.NbUnits);
            this.Controls.Add(this.Bhname);
            this.Controls.Add(this.Hname);
            this.Name = "CtrlMaison";
            this.Size = new System.Drawing.Size(276, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hname;
        private System.Windows.Forms.Label Bhname;
        private System.Windows.Forms.Label NbUnits;
        private System.Windows.Forms.Label BnbUnits;
    }
}
