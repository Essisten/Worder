
namespace Worder
{
    partial class WorderWondow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextSizeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSizeSelecter = new System.Windows.Forms.ToolStripComboBox();
            this.TextFontButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TextChangeColourButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditClearAllButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FontCollectionSelecter = new System.Windows.Forms.ToolStripComboBox();
            this.FontColorSelecter = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTextBox
            // 
            this.MainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTextBox.Location = new System.Drawing.Point(0, 24);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(1200, 599);
            this.MainTextBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.textToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Options";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpenButton,
            this.FileSaveButton,
            this.FileSaveAsButton});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // FileOpenButton
            // 
            this.FileOpenButton.Name = "FileOpenButton";
            this.FileOpenButton.Size = new System.Drawing.Size(114, 22);
            this.FileOpenButton.Text = "Open";
            this.FileOpenButton.Click += new System.EventHandler(this.FileOpenButton_Click);
            // 
            // FileSaveButton
            // 
            this.FileSaveButton.Name = "FileSaveButton";
            this.FileSaveButton.Size = new System.Drawing.Size(114, 22);
            this.FileSaveButton.Text = "Save";
            this.FileSaveButton.Click += new System.EventHandler(this.FileSaveButton_Click);
            // 
            // FileSaveAsButton
            // 
            this.FileSaveAsButton.Name = "FileSaveAsButton";
            this.FileSaveAsButton.Size = new System.Drawing.Size(114, 22);
            this.FileSaveAsButton.Text = "Save As";
            this.FileSaveAsButton.Click += new System.EventHandler(this.FileSaveAsButton_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextSizeButton,
            this.TextFontButton,
            this.TextChangeColourButton});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.textToolStripMenuItem.Text = "Text";
            // 
            // TextSizeButton
            // 
            this.TextSizeButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontSizeSelecter});
            this.TextSizeButton.Name = "TextSizeButton";
            this.TextSizeButton.Size = new System.Drawing.Size(180, 22);
            this.TextSizeButton.Text = "Size";
            // 
            // FontSizeSelecter
            // 
            this.FontSizeSelecter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FontSizeSelecter.Name = "FontSizeSelecter";
            this.FontSizeSelecter.Size = new System.Drawing.Size(75, 27);
            this.FontSizeSelecter.SelectedIndexChanged += new System.EventHandler(this.FontSizeSelecter_SelectedIndexChanged);
            // 
            // TextFontButton
            // 
            this.TextFontButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontCollectionSelecter});
            this.TextFontButton.Name = "TextFontButton";
            this.TextFontButton.Size = new System.Drawing.Size(180, 22);
            this.TextFontButton.Text = "Font";
            // 
            // TextChangeColourButton
            // 
            this.TextChangeColourButton.Name = "TextChangeColourButton";
            this.TextChangeColourButton.Size = new System.Drawing.Size(180, 22);
            this.TextChangeColourButton.Text = "Change Colour";
            this.TextChangeColourButton.Click += new System.EventHandler(this.TextChangeColourButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditClearAllButton});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // EditClearAllButton
            // 
            this.EditClearAllButton.Name = "EditClearAllButton";
            this.EditClearAllButton.Size = new System.Drawing.Size(118, 22);
            this.EditClearAllButton.Text = "Clear All";
            this.EditClearAllButton.Click += new System.EventHandler(this.EditClearAllButton_Click);
            // 
            // FontCollectionSelecter
            // 
            this.FontCollectionSelecter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FontCollectionSelecter.Name = "FontCollectionSelecter";
            this.FontCollectionSelecter.Size = new System.Drawing.Size(121, 27);
            this.FontCollectionSelecter.SelectedIndexChanged += new System.EventHandler(this.FontCollectionSelecter_SelectedIndexChanged);
            // 
            // WorderWondow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "WorderWondow";
            this.Text = "Worder";
            this.Load += new System.EventHandler(this.WorderWondow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileOpenButton;
        private System.Windows.Forms.ToolStripMenuItem FileSaveButton;
        private System.Windows.Forms.ToolStripMenuItem FileSaveAsButton;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TextSizeButton;
        private System.Windows.Forms.ToolStripMenuItem TextFontButton;
        private System.Windows.Forms.ToolStripMenuItem TextChangeColourButton;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditClearAllButton;
        private System.Windows.Forms.ToolStripComboBox FontSizeSelecter;
        private System.Windows.Forms.ToolStripComboBox FontCollectionSelecter;
        private System.Windows.Forms.ColorDialog FontColorSelecter;
    }
}

