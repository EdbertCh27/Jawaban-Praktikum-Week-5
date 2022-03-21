
namespace Jawaban_Praktikum
{
    partial class FormMateri
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
            this.listBoxKoleksi = new System.Windows.Forms.ListBox();
            this.labelData = new System.Windows.Forms.Label();
            this.labelKoleksi = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxWarna = new System.Windows.Forms.CheckBox();
            this.labelSetting = new System.Windows.Forms.Label();
            this.radioButtonMerah = new System.Windows.Forms.RadioButton();
            this.radioButtonBiru = new System.Windows.Forms.RadioButton();
            this.labelShow = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxKoleksi
            // 
            this.listBoxKoleksi.FormattingEnabled = true;
            this.listBoxKoleksi.ItemHeight = 20;
            this.listBoxKoleksi.Location = new System.Drawing.Point(49, 146);
            this.listBoxKoleksi.Name = "listBoxKoleksi";
            this.listBoxKoleksi.Size = new System.Drawing.Size(150, 104);
            this.listBoxKoleksi.TabIndex = 0;
            this.listBoxKoleksi.SelectedIndexChanged += new System.EventHandler(this.listBoxKoleksi_SelectedIndexChanged);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(49, 53);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(41, 20);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "Data";
            // 
            // labelKoleksi
            // 
            this.labelKoleksi.AutoSize = true;
            this.labelKoleksi.Location = new System.Drawing.Point(49, 111);
            this.labelKoleksi.Name = "labelKoleksi";
            this.labelKoleksi.Size = new System.Drawing.Size(56, 20);
            this.labelKoleksi.TabIndex = 2;
            this.labelKoleksi.Text = "Koleksi";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(137, 53);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(353, 27);
            this.textBoxData.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(566, 50);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxWarna
            // 
            this.checkBoxWarna.AutoSize = true;
            this.checkBoxWarna.Location = new System.Drawing.Point(531, 119);
            this.checkBoxWarna.Name = "checkBoxWarna";
            this.checkBoxWarna.Size = new System.Drawing.Size(62, 24);
            this.checkBoxWarna.TabIndex = 5;
            this.checkBoxWarna.Text = "Aktif";
            this.checkBoxWarna.UseVisualStyleBackColor = true;
            this.checkBoxWarna.CheckedChanged += new System.EventHandler(this.checkBoxWarna_CheckedChanged);
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(440, 120);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(56, 20);
            this.labelSetting.TabIndex = 6;
            this.labelSetting.Text = "Setting";
            // 
            // radioButtonMerah
            // 
            this.radioButtonMerah.AutoSize = true;
            this.radioButtonMerah.Location = new System.Drawing.Point(440, 178);
            this.radioButtonMerah.Name = "radioButtonMerah";
            this.radioButtonMerah.Size = new System.Drawing.Size(118, 24);
            this.radioButtonMerah.TabIndex = 7;
            this.radioButtonMerah.Text = "Warna Merah";
            this.radioButtonMerah.UseVisualStyleBackColor = true;
            this.radioButtonMerah.CheckedChanged += new System.EventHandler(this.radioButtonMerah_CheckedChanged);
            // 
            // radioButtonBiru
            // 
            this.radioButtonBiru.AutoSize = true;
            this.radioButtonBiru.Location = new System.Drawing.Point(440, 219);
            this.radioButtonBiru.Name = "radioButtonBiru";
            this.radioButtonBiru.Size = new System.Drawing.Size(102, 24);
            this.radioButtonBiru.TabIndex = 8;
            this.radioButtonBiru.Text = "Warna Biru";
            this.radioButtonBiru.UseVisualStyleBackColor = true;
            this.radioButtonBiru.CheckedChanged += new System.EventHandler(this.radioButtonBiru_CheckedChanged);
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelShow.Location = new System.Drawing.Point(499, 321);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(57, 38);
            this.labelShow.TabIndex = 9;
            this.labelShow.Text = "[....]";
            this.labelShow.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(426, 284);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(64, 20);
            this.labelOutput.TabIndex = 10;
            this.labelOutput.Text = "OUTPUT";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(384, 391);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(337, 29);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormMateri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.radioButtonBiru);
            this.Controls.Add(this.radioButtonMerah);
            this.Controls.Add(this.labelSetting);
            this.Controls.Add(this.checkBoxWarna);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.labelKoleksi);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.listBoxKoleksi);
            this.Name = "FormMateri";
            this.Text = "FormMateri";
            this.Load += new System.EventHandler(this.FormMateri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKoleksi;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelKoleksi;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkBoxWarna;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.RadioButton radioButtonMerah;
        private System.Windows.Forms.RadioButton radioButtonBiru;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonClear;
    }
}

