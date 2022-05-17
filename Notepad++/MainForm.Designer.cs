namespace Notepad__
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOriginal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBold = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStrikeout = new System.Windows.Forms.ToolStripMenuItem();
            this.sepEdit = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.sepSettings = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTime0 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTime1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTime3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTime5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTime10 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCodeEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCodeEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tscmiOriginal = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmiItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmiBold = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmiUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmiStrikeout = new System.Windows.Forms.ToolStripMenuItem();
            this.sepContextMenu = new System.Windows.Forms.ToolStripSeparator();
            this.tscmiAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tscmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1178, 710);
            this.tabControl.TabIndex = 0;
            this.tabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl_KeyDown);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmEdit,
            this.tsmFormat,
            this.tsmSettings,
            this.tsmCodeEditor,
            this.tsmHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1178, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "Контекстное меню";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewWindow,
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.tsmiSaveAll,
            this.tsmiClose,
            this.tsmiExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(59, 24);
            this.tsmFile.Text = "Файл";
            // 
            // tsmiNewWindow
            // 
            this.tsmiNewWindow.Name = "tsmiNewWindow";
            this.tsmiNewWindow.Size = new System.Drawing.Size(308, 26);
            this.tsmiNewWindow.Text = "Новое окно (Ctrl + Shift + N)";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(308, 26);
            this.tsmiNew.Text = "Создать (Ctrl + N)";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(308, 26);
            this.tsmiOpen.Text = "Открыть (Ctrl + O)";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(308, 26);
            this.tsmiSave.Text = "Сохранить (Ctrl + S)";
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Size = new System.Drawing.Size(308, 26);
            this.tsmiSaveAs.Text = "Сохранить как (Ctrl + Shift + S)";
            // 
            // tsmiSaveAll
            // 
            this.tsmiSaveAll.Name = "tsmiSaveAll";
            this.tsmiSaveAll.Size = new System.Drawing.Size(308, 26);
            this.tsmiSaveAll.Text = "Сохранить все (Ctrl + Shift + A)";
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(308, 26);
            this.tsmiClose.Text = "Закрыть (Ctrl + Q)";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(308, 26);
            this.tsmiExit.Text = "Закрыть приложение (Alt + F4)";
            // 
            // tsmEdit
            // 
            this.tsmEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOriginal,
            this.tsmiItalic,
            this.tsmiBold,
            this.tsmiUnderline,
            this.tsmiStrikeout,
            this.sepEdit,
            this.tsmiAll,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste});
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(74, 24);
            this.tsmEdit.Text = "Правка";
            // 
            // tsmiOriginal
            // 
            this.tsmiOriginal.Name = "tsmiOriginal";
            this.tsmiOriginal.Size = new System.Drawing.Size(311, 26);
            this.tsmiOriginal.Text = "Без выделения (Ctrl + Shift + O)";
            // 
            // tsmiItalic
            // 
            this.tsmiItalic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tsmiItalic.Name = "tsmiItalic";
            this.tsmiItalic.Size = new System.Drawing.Size(311, 26);
            this.tsmiItalic.Text = "Курсив (Ctrl + K)";
            // 
            // tsmiBold
            // 
            this.tsmiBold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsmiBold.Name = "tsmiBold";
            this.tsmiBold.Size = new System.Drawing.Size(311, 26);
            this.tsmiBold.Text = "Жирный (Ctrl + B)";
            // 
            // tsmiUnderline
            // 
            this.tsmiUnderline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.tsmiUnderline.Name = "tsmiUnderline";
            this.tsmiUnderline.Size = new System.Drawing.Size(311, 26);
            this.tsmiUnderline.Text = "Подчеркнутый (Ctrl + U)";
            // 
            // tsmiStrikeout
            // 
            this.tsmiStrikeout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.tsmiStrikeout.Name = "tsmiStrikeout";
            this.tsmiStrikeout.Size = new System.Drawing.Size(311, 26);
            this.tsmiStrikeout.Text = "Зачеркнутый (Ctrl + P)";
            // 
            // sepEdit
            // 
            this.sepEdit.Name = "sepEdit";
            this.sepEdit.Size = new System.Drawing.Size(308, 6);
            // 
            // tsmiAll
            // 
            this.tsmiAll.Name = "tsmiAll";
            this.tsmiAll.Size = new System.Drawing.Size(311, 26);
            this.tsmiAll.Text = "Выбрать все (Ctrl + A)";
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.Size = new System.Drawing.Size(311, 26);
            this.tsmiCut.Text = "Вырезать (Ctrl +X)";
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(311, 26);
            this.tsmiCopy.Text = "Копировать (Ctrl + C)";
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(311, 26);
            this.tsmiPaste.Text = "Вставить (Ctrl + V)";
            // 
            // tsmFormat
            // 
            this.tsmFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFormat});
            this.tsmFormat.Name = "tsmFormat";
            this.tsmFormat.Size = new System.Drawing.Size(77, 24);
            this.tsmFormat.Text = "Формат";
            // 
            // tsmiFormat
            // 
            this.tsmiFormat.Name = "tsmiFormat";
            this.tsmiFormat.Size = new System.Drawing.Size(193, 26);
            this.tsmiFormat.Text = "Формат файла";
            // 
            // tsmSettings
            // 
            this.tsmSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFontColor,
            this.tsmiBackColor,
            this.sepSettings,
            this.tsmiTime});
            this.tsmSettings.Name = "tsmSettings";
            this.tsmSettings.Size = new System.Drawing.Size(98, 24);
            this.tsmSettings.Text = "Настройки";
            // 
            // tsmiFontColor
            // 
            this.tsmiFontColor.Name = "tsmiFontColor";
            this.tsmiFontColor.Size = new System.Drawing.Size(255, 26);
            this.tsmiFontColor.Text = "Цвет текста";
            // 
            // tsmiBackColor
            // 
            this.tsmiBackColor.Name = "tsmiBackColor";
            this.tsmiBackColor.Size = new System.Drawing.Size(255, 26);
            this.tsmiBackColor.Text = "Цвет фона";
            // 
            // sepSettings
            // 
            this.sepSettings.Name = "sepSettings";
            this.sepSettings.Size = new System.Drawing.Size(252, 6);
            // 
            // tsmiTime
            // 
            this.tsmiTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTime0,
            this.tsmiTime1,
            this.tsmiTime3,
            this.tsmiTime5,
            this.tsmiTime10});
            this.tsmiTime.Name = "tsmiTime";
            this.tsmiTime.Size = new System.Drawing.Size(255, 26);
            this.tsmiTime.Text = "Время автосохранения";
            // 
            // tsmiTime0
            // 
            this.tsmiTime0.Name = "tsmiTime0";
            this.tsmiTime0.Size = new System.Drawing.Size(167, 26);
            this.tsmiTime0.Text = "Отключить";
            // 
            // tsmiTime1
            // 
            this.tsmiTime1.Name = "tsmiTime1";
            this.tsmiTime1.Size = new System.Drawing.Size(167, 26);
            this.tsmiTime1.Text = "1 мин.";
            // 
            // tsmiTime3
            // 
            this.tsmiTime3.Name = "tsmiTime3";
            this.tsmiTime3.Size = new System.Drawing.Size(167, 26);
            this.tsmiTime3.Text = "3 мин.";
            // 
            // tsmiTime5
            // 
            this.tsmiTime5.Name = "tsmiTime5";
            this.tsmiTime5.Size = new System.Drawing.Size(167, 26);
            this.tsmiTime5.Text = "5 мин.";
            // 
            // tsmiTime10
            // 
            this.tsmiTime10.Name = "tsmiTime10";
            this.tsmiTime10.Size = new System.Drawing.Size(167, 26);
            this.tsmiTime10.Text = "10 мин.";
            // 
            // tsmCodeEditor
            // 
            this.tsmCodeEditor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCodeEditor});
            this.tsmCodeEditor.Name = "tsmCodeEditor";
            this.tsmCodeEditor.Size = new System.Drawing.Size(122, 24);
            this.tsmCodeEditor.Text = "Редактор кода";
            // 
            // tsmiCodeEditor
            // 
            this.tsmiCodeEditor.Name = "tsmiCodeEditor";
            this.tsmiCodeEditor.Size = new System.Drawing.Size(228, 26);
            this.tsmiCodeEditor.Text = "Запустить редактор";
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(81, 24);
            this.tsmHelp.Text = "Справка";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(215, 26);
            this.tsmiHelp.Text = "Показать справку";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscmiOriginal,
            this.tscmiItalic,
            this.tscmiBold,
            this.tscmiUnderline,
            this.tscmiStrikeout,
            this.sepContextMenu,
            this.tscmiAll,
            this.tscmiCut,
            this.tscmiCopy,
            this.tscmiPaste});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(298, 226);
            // 
            // tscmiOriginal
            // 
            this.tscmiOriginal.Name = "tscmiOriginal";
            this.tscmiOriginal.Size = new System.Drawing.Size(297, 24);
            this.tscmiOriginal.Text = "Без выделения (Ctrl + Shift + O)";
            // 
            // tscmiItalic
            // 
            this.tscmiItalic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tscmiItalic.Name = "tscmiItalic";
            this.tscmiItalic.Size = new System.Drawing.Size(297, 24);
            this.tscmiItalic.Text = "Курсив (Ctrl + K)";
            // 
            // tscmiBold
            // 
            this.tscmiBold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tscmiBold.Name = "tscmiBold";
            this.tscmiBold.Size = new System.Drawing.Size(297, 24);
            this.tscmiBold.Text = "Жирный (Ctrl + B)";
            // 
            // tscmiUnderline
            // 
            this.tscmiUnderline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.tscmiUnderline.Name = "tscmiUnderline";
            this.tscmiUnderline.Size = new System.Drawing.Size(297, 24);
            this.tscmiUnderline.Text = "Подчеркнутый (Ctrl + U)";
            // 
            // tscmiStrikeout
            // 
            this.tscmiStrikeout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.tscmiStrikeout.Name = "tscmiStrikeout";
            this.tscmiStrikeout.Size = new System.Drawing.Size(297, 24);
            this.tscmiStrikeout.Text = "Зачеркнутый (Ctrl + P)";
            // 
            // sepContextMenu
            // 
            this.sepContextMenu.Name = "sepContextMenu";
            this.sepContextMenu.Size = new System.Drawing.Size(294, 6);
            // 
            // tscmiAll
            // 
            this.tscmiAll.Name = "tscmiAll";
            this.tscmiAll.Size = new System.Drawing.Size(297, 24);
            this.tscmiAll.Text = "Выделить все (Ctrl + A)";
            // 
            // tscmiCut
            // 
            this.tscmiCut.Name = "tscmiCut";
            this.tscmiCut.Size = new System.Drawing.Size(297, 24);
            this.tscmiCut.Text = "Вырезать (Ctrl + X)";
            // 
            // tscmiCopy
            // 
            this.tscmiCopy.Name = "tscmiCopy";
            this.tscmiCopy.Size = new System.Drawing.Size(297, 24);
            this.tscmiCopy.Text = "Копировать (Ctrl + C)";
            // 
            // tscmiPaste
            // 
            this.tscmiPaste.Name = "tscmiPaste";
            this.tscmiPaste.Size = new System.Drawing.Size(297, 24);
            this.tscmiPaste.Text = "Вставить (Ctrl + V)";
            // 
            // timerSave
            // 
            this.timerSave.Enabled = true;
            this.timerSave.Interval = 1000;
            this.timerSave.Tick += new System.EventHandler(this.timerSave_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1178, 738);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad++";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tscmiItalic;
        private System.Windows.Forms.ToolStripMenuItem tscmiBold;
        private System.Windows.Forms.ToolStripMenuItem tscmiUnderline;
        private System.Windows.Forms.ToolStripMenuItem tscmiStrikeout;
        private System.Windows.Forms.ToolStripSeparator sepContextMenu;
        private System.Windows.Forms.ToolStripMenuItem tscmiAll;
        private System.Windows.Forms.ToolStripMenuItem tscmiOriginal;
        private System.Windows.Forms.ToolStripMenuItem tscmiCut;
        private System.Windows.Forms.ToolStripMenuItem tscmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tscmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiOriginal;
        private System.Windows.Forms.ToolStripMenuItem tsmiItalic;
        private System.Windows.Forms.ToolStripMenuItem tsmiBold;
        private System.Windows.Forms.ToolStripMenuItem tsmiUnderline;
        private System.Windows.Forms.ToolStripMenuItem tsmiStrikeout;
        private System.Windows.Forms.ToolStripSeparator sepEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiFormat;
        private System.Windows.Forms.ToolStripMenuItem tsmiFontColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackColor;
        private System.Windows.Forms.ToolStripSeparator sepSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiTime1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTime3;
        private System.Windows.Forms.ToolStripMenuItem tsmiTime5;
        private System.Windows.Forms.ToolStripMenuItem tsmiTime10;
        private System.Windows.Forms.Timer timerSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiTime0;
        private System.Windows.Forms.ToolStripMenuItem tsmCodeEditor;
        private System.Windows.Forms.ToolStripMenuItem tsmiCodeEditor;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}

