
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::unrailedSaver.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.selectFolderBtn);
            this.Controls.Add(this.restoreLastSaveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Unrailed Saver";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button restoreLastSaveBtn;
        private System.Windows.Forms.Button selectFolderBtn;
    }
}

