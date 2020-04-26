namespace Calculator_CS
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
            this.TextBoxWartosc1 = new System.Windows.Forms.TextBox();
            this.TextBoxWartosc2 = new System.Windows.Forms.TextBox();
            this.DropDownListDzialanie = new System.Windows.Forms.ComboBox();
            this.licz = new System.Windows.Forms.Button();
            this.TextBoxWynik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxWartosc1
            // 
            this.TextBoxWartosc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxWartosc1.Location = new System.Drawing.Point(201, 90);
            this.TextBoxWartosc1.Name = "TextBoxWartosc1";
            this.TextBoxWartosc1.Size = new System.Drawing.Size(356, 35);
            this.TextBoxWartosc1.TabIndex = 0;
            // 
            // TextBoxWartosc2
            // 
            this.TextBoxWartosc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxWartosc2.Location = new System.Drawing.Point(201, 199);
            this.TextBoxWartosc2.Name = "TextBoxWartosc2";
            this.TextBoxWartosc2.Size = new System.Drawing.Size(356, 35);
            this.TextBoxWartosc2.TabIndex = 1;
            // 
            // DropDownListDzialanie
            // 
            this.DropDownListDzialanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DropDownListDzialanie.FormattingEnabled = true;
            this.DropDownListDzialanie.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.DropDownListDzialanie.Location = new System.Drawing.Point(201, 143);
            this.DropDownListDzialanie.Name = "DropDownListDzialanie";
            this.DropDownListDzialanie.Size = new System.Drawing.Size(356, 37);
            this.DropDownListDzialanie.TabIndex = 2;
            this.DropDownListDzialanie.SelectedIndexChanged += new System.EventHandler(this.DropDownListDzialanie_SelectedIndexChanged);
            // 
            // licz
            // 
            this.licz.Location = new System.Drawing.Point(201, 244);
            this.licz.Name = "licz";
            this.licz.Size = new System.Drawing.Size(356, 59);
            this.licz.TabIndex = 3;
            this.licz.Text = "=";
            this.licz.UseVisualStyleBackColor = true;
            this.licz.Click += new System.EventHandler(this.licz_Click);
            // 
            // TextBoxWynik
            // 
            this.TextBoxWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxWynik.Location = new System.Drawing.Point(201, 327);
            this.TextBoxWynik.Name = "TextBoxWynik";
            this.TextBoxWynik.ReadOnly = true;
            this.TextBoxWynik.Size = new System.Drawing.Size(356, 35);
            this.TextBoxWynik.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxWynik);
            this.Controls.Add(this.licz);
            this.Controls.Add(this.DropDownListDzialanie);
            this.Controls.Add(this.TextBoxWartosc2);
            this.Controls.Add(this.TextBoxWartosc1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxWartosc1;
        private System.Windows.Forms.TextBox TextBoxWartosc2;
        private System.Windows.Forms.ComboBox DropDownListDzialanie;
        private System.Windows.Forms.Button licz;
        private System.Windows.Forms.TextBox TextBoxWynik;
    }
}

