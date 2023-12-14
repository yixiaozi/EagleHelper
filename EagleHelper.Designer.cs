namespace EagleHelper
{
    partial class EagleHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EagleHelper));
            eagleFolderPath = new TextBox();
            label1 = new Label();
            openFileDialog_SelectPath = new OpenFileDialog();
            btn_SelectFolder = new Button();
            OnlyOneFolder = new Button();
            SuspendLayout();
            // 
            // eagleFolderPath
            // 
            eagleFolderPath.Location = new Point(118, 12);
            eagleFolderPath.Name = "eagleFolderPath";
            eagleFolderPath.Size = new Size(448, 23);
            eagleFolderPath.TabIndex = 0;
            eagleFolderPath.Text = "H:\\Photos\\个人.library";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 1;
            label1.Text = "Eagle库文件夹：";
            // 
            // openFileDialog_SelectPath
            // 
            openFileDialog_SelectPath.FileName = "openFileDialog1";
            // 
            // btn_SelectFolder
            // 
            btn_SelectFolder.Location = new Point(572, 12);
            btn_SelectFolder.Name = "btn_SelectFolder";
            btn_SelectFolder.Size = new Size(75, 23);
            btn_SelectFolder.TabIndex = 2;
            btn_SelectFolder.Text = "浏览";
            btn_SelectFolder.UseVisualStyleBackColor = true;
            btn_SelectFolder.Click += btn_SelectFolder_Click;
            // 
            // OnlyOneFolder
            // 
            OnlyOneFolder.Location = new Point(24, 236);
            OnlyOneFolder.Name = "OnlyOneFolder";
            OnlyOneFolder.Size = new Size(179, 44);
            OnlyOneFolder.TabIndex = 3;
            OnlyOneFolder.Text = "一个照片只保留一个文件夹";
            OnlyOneFolder.UseVisualStyleBackColor = true;
            OnlyOneFolder.Click += OnlyOneFolder_Click;
            // 
            // EagleHelper
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(659, 450);
            Controls.Add(OnlyOneFolder);
            Controls.Add(btn_SelectFolder);
            Controls.Add(label1);
            Controls.Add(eagleFolderPath);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EagleHelper";
            Text = "EagleHelper";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox eagleFolderPath;
        private Label label1;
        private OpenFileDialog openFileDialog_SelectPath;
        private Button btn_SelectFolder;
        private Button OnlyOneFolder;
    }
}