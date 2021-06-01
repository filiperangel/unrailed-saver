
namespace unrailedSaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.restoreLastSaveBtn = new System.Windows.Forms.Button();
            this.selectFolderBtn = new System.Windows.Forms.Button();
            this.comboLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.helpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restoreLastSaveBtn
            // 
            this.restoreLastSaveBtn.Location = new System.Drawing.Point(126, 179);
            this.restoreLastSaveBtn.Name = "restoreLastSaveBtn";
            this.restoreLastSaveBtn.Size = new System.Drawing.Size(245, 94);
            this.restoreLastSaveBtn.TabIndex = 0;
            this.restoreLastSaveBtn.Text = "Restaurar Ultimo Save";
            this.restoreLastSaveBtn.UseVisualStyleBackColor = true;
            this.restoreLastSaveBtn.Click += new System.EventHandler(this.restoreLastSaveBtn_Click);
            // 
            // selectFolderBtn
            // 
            this.selectFolderBtn.Location = new System.Drawing.Point(126, 307);
            this.selectFolderBtn.Name = "selectFolderBtn";
            this.selectFolderBtn.Size = new System.Drawing.Size(245, 94);
            this.selectFolderBtn.TabIndex = 1;
            this.selectFolderBtn.Text = "Selecionar Pasta do Jogo";
            this.selectFolderBtn.UseVisualStyleBackColor = true;
            this.selectFolderBtn.Click += new System.EventHandler(this.selectFolderBtn_Click);
            // 
            // comboLanguage
            // 
            this.comboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLanguage.FormattingEnabled = true;
            this.comboLanguage.ItemHeight = 13;
            this.comboLanguage.Items.AddRange(new object[] {
            "Português",
            "English"});
            this.comboLanguage.Location = new System.Drawing.Point(617, 40);
            this.comboLanguage.Name = "comboLanguage";
            this.comboLanguage.Size = new System.Drawing.Size(128, 21);
            this.comboLanguage.TabIndex = 2;
            this.comboLanguage.SelectedIndexChanged += new System.EventHandler(this.comboLanguage_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(619, 13);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(72, 24);
            this.lblLanguage.TabIndex = 3;
            this.lblLanguage.Text = "Idioma";
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(126, 447);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(245, 49);
            this.helpBtn.TabIndex = 4;
            this.helpBtn.Text = "Ajuda";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::unrailedSaver.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.comboLanguage);
            this.Controls.Add(this.selectFolderBtn);
            this.Controls.Add(this.restoreLastSaveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Unrailed Saver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button restoreLastSaveBtn;
        private System.Windows.Forms.Button selectFolderBtn;
        private System.Windows.Forms.ComboBox comboLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Button helpBtn;
    }
}

