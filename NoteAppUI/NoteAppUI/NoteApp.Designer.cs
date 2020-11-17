
namespace NoteAppUI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategorysComboBox = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeletButton = new System.Windows.Forms.Button();
            this.TitlesListBox = new System.Windows.Forms.ListBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.ChangeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            this.removeNoteToolStripMenuItem.Click += new System.EventHandler(this.removeNoteToolStripMenuItem_Click);
            // 
            // helpButton
            // 
            this.helpButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(44, 20);
            this.helpButton.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // CategorysComboBox
            // 
            this.CategorysComboBox.FormattingEnabled = true;
            this.CategorysComboBox.Location = new System.Drawing.Point(100, 16);
            this.CategorysComboBox.Name = "CategorysComboBox";
            this.CategorysComboBox.Size = new System.Drawing.Size(163, 21);
            this.CategorysComboBox.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DeletButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddButton);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.CategorysComboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.ChangeDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.CreateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.TitleTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.CategoryTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.NoteTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(800, 422);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show Category:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TitlesListBox);
            this.panel1.Location = new System.Drawing.Point(3, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 335);
            this.panel1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.BackgroundImage = global::NoteAppUI.Properties.Resources.folder_add_black_interface_symbol_icon_icons_com_54529;
            this.AddButton.Location = new System.Drawing.Point(3, 384);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(36, 31);
            this.AddButton.TabIndex = 0;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackgroundImage = global::NoteAppUI.Properties.Resources.edit_modify_icon_icons_com_72390_1_;
            this.EditButton.Location = new System.Drawing.Point(45, 384);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(36, 31);
            this.EditButton.TabIndex = 2;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeletButton
            // 
            this.DeletButton.BackgroundImage = global::NoteAppUI.Properties.Resources.cancel_close_delete_exit_logout_remove_x_icon_123217;
            this.DeletButton.Location = new System.Drawing.Point(87, 384);
            this.DeletButton.Name = "DeletButton";
            this.DeletButton.Size = new System.Drawing.Size(36, 31);
            this.DeletButton.TabIndex = 3;
            this.DeletButton.UseVisualStyleBackColor = true;
            this.DeletButton.Click += new System.EventHandler(this.DeletButton_Click);
            // 
            // TitlesListBox
            // 
            this.TitlesListBox.FormattingEnabled = true;
            this.TitlesListBox.Location = new System.Drawing.Point(3, 3);
            this.TitlesListBox.Name = "TitlesListBox";
            this.TitlesListBox.Size = new System.Drawing.Size(254, 329);
            this.TitlesListBox.TabIndex = 0;
            this.TitlesListBox.SelectedIndexChanged += new System.EventHandler(this.TitlesListBox_SelectedIndexChanged);
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.NoteTextBox.Location = new System.Drawing.Point(3, 108);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextBox.Size = new System.Drawing.Size(515, 307);
            this.NoteTextBox.TabIndex = 0;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.CategoryTextBox.Enabled = false;
            this.CategoryTextBox.Location = new System.Drawing.Point(100, 54);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.CategoryTextBox.TabIndex = 1;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TitleTextBox.Enabled = false;
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleTextBox.Location = new System.Drawing.Point(12, 17);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(515, 22);
            this.TitleTextBox.TabIndex = 2;
            // 
            // ChangeDateTimePicker
            // 
            this.ChangeDateTimePicker.Enabled = false;
            this.ChangeDateTimePicker.Location = new System.Drawing.Point(294, 82);
            this.ChangeDateTimePicker.Name = "ChangeDateTimePicker";
            this.ChangeDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.ChangeDateTimePicker.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Modified:";
            // 
            // CreateDateTimePicker
            // 
            this.CreateDateTimePicker.Enabled = false;
            this.CreateDateTimePicker.Location = new System.Drawing.Point(87, 82);
            this.CreateDateTimePicker.Name = "CreateDateTimePicker";
            this.CreateDateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.CreateDateTimePicker.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Created:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Show Category";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ComboBox CategorysComboBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button DeletButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox TitlesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.DateTimePicker ChangeDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker CreateDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

