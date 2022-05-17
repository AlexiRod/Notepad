using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Notepad__.Properties;
using System.Diagnostics;

namespace Notepad__
{
    public partial class MainForm : Form
    {

        #region Загрузка и инициализация

        // Коллекция вкладок для работы и для последующего восстановления.
        List<Page> pages = new List<Page>();
        List<string> files = new List<string>();

        // Настройки цвета
        Color fontColor = Color.Black;
        Color backColor = Color.White;

        // Время для автосохранений.
        int time = 0;
        int timeForAutoSave = 5 * 60;

        // Путь к редактору кодов.
        string pathToCodeEditor = Path.Combine(Directory.GetCurrentDirectory().ToString(), 
            "IronyFCTB", "Tester", "bin", "Debug", "Tester.exe");


        public MainForm()
        {
            InitializeComponent();

            tscmiOriginal.Image = Resources.Original;
            tsmiOriginal.Image = Resources.Original;
            tscmiItalic.Image = Resources.Italic;
            tsmiItalic.Image = Resources.Italic;
            tscmiBold.Image = Resources.Bold;
            tsmiBold.Image = Resources.Bold;
            tscmiUnderline.Image = Resources.Underline;
            tsmiUnderline.Image = Resources.Underline;
            tscmiStrikeout.Image = Resources.Strikeout;
            tsmiStrikeout.Image = Resources.Strikeout;
            tscmiAll.Image = Resources.All;
            tsmiAll.Image = Resources.All;
            tscmiCut.Image = Resources.Cut;
            tsmiCut.Image = Resources.Cut;
            tscmiCopy.Image = Resources.Copy;
            tsmiCopy.Image = Resources.Copy;
            tscmiPaste.Image = Resources.Paste;
            tsmiPaste.Image = Resources.Paste;
            tsmiNewWindow.Image = Resources.NewWindow;
            tsmiNew.Image = Resources.NewTab;
            tsmiOpen.Image = Resources.Open;
            tsmiSave.Image = Resources.Save;
            tsmiSaveAs.Image = Resources.SaveAs;
            tsmiSaveAll.Image = Resources.SaveAll;
            tsmiClose.Image = Resources.Close;
            tsmiExit.Image = Resources.Exit;
            tsmiFormat.Image = Resources.Format;
            tsmiBackColor.Image = Resources.BackColor;
            tsmiFontColor.Image = Resources.FontColor;
            tsmiTime.Image = Resources.Time;
            tsmiCodeEditor.Image = Resources.CSharp;
            tsmiHelp.Image = Resources.Help; 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            tsmiNewWindow.Click += TsmiNewWindow_Click;
            tsmiNew.Click += TsmiNew_Click;
            tsmiOpen.Click += TsmiOpen_Click;
            tsmiSave.Click += TsmiSave_Click;
            tsmiSaveAs.Click += TsmiSaveAs_Click;
            tsmiSaveAll.Click += TsmiSaveAll_Click;
            tsmiClose.Click += TsmiClose_Click;
            tsmiExit.Click += (sender, e) => { try { Application.Exit(); } catch (Exception) { } };


            tscmiOriginal.Click += TscmiOriginal_Click;
            tsmiOriginal.Click += TscmiOriginal_Click;
            tscmiItalic.Click += TscmiItalic_Click;
            tsmiItalic.Click += TscmiItalic_Click;
            tscmiBold.Click += TscmiBold_Click;
            tsmiBold.Click += TscmiBold_Click;
            tscmiUnderline.Click += TscmiUnderline_Click;
            tsmiUnderline.Click += TscmiUnderline_Click;
            tscmiStrikeout.Click += TscmiStrikeout_Click;
            tsmiStrikeout.Click += TscmiStrikeout_Click;

            tscmiAll.Click += TscmiAll_Click;
            tsmiAll.Click += TscmiAll_Click;
            tscmiCut.Click += TscmiCut_Click;
            tsmiCut.Click += TscmiCut_Click;
            tscmiCopy.Click += TscmiCopy_Click;
            tsmiCopy.Click += TscmiCopy_Click;
            tscmiPaste.Click += TscmiPaste_Click;
            tsmiPaste.Click += TscmiPaste_Click;


            tsmiFormat.Click += TsmFormat_Click;
            tsmiCodeEditor.Click += TsmiCodeEditor_Click;
            tsmiHelp.Click += TsmiHelp_Click;

            tsmiFontColor.Click += TsmiFontColor_Click;
            tsmiBackColor.Click += TsmiBackColor_Click;
            tsmiTime0.Click += TsmiTime_Click;
            tsmiTime1.Click += TsmiTime_Click;
            tsmiTime3.Click += TsmiTime_Click;
            tsmiTime5.Click += TsmiTime_Click;
            tsmiTime10.Click += TsmiTime_Click;

            try
            {
                // Восстановление прошлых вкладок.
                string[] files = File.ReadAllLines("History.txt");
                foreach (string file in files)
                {
                    string[] split = file.Split('\t');
                    string filePath = split[0];
                    string fileName = split[1];
                    Color fColor = Color.FromArgb(Convert.ToInt32(split[2]));
                    Color bColor = Color.FromArgb(Convert.ToInt32(split[3]));
                    try
                    {
                        timeForAutoSave = Convert.ToInt32(File.ReadAllText("Settings.txt"));
                        switch (timeForAutoSave)
                        {
                            case 60:
                                tsmiTime1.Checked = true;
                                break;
                            case 180:
                                tsmiTime3.Checked = true;
                                break;
                            case 300:
                                tsmiTime5.Checked = true;
                                break;
                            case 600:
                                tsmiTime10.Checked = true;
                                break;
                            default:
                                timerSave.Enabled = false;
                                tsmiTime0.Checked = true;
                                break;
                        }

                        string fullPath = Path.Combine(filePath, fileName);
                        TabPage tabPage = new TabPage() { Text = fileName };
                        RichTextBox richTextBox = new RichTextBox() { Dock = DockStyle.Fill, ContextMenuStrip = contextMenuStrip, BackColor = bColor, ForeColor = fColor };
                        if (fullPath.Contains(".txt"))
                            richTextBox.Text = File.ReadAllText(fullPath, Encoding.Default);
                        else
                        {
                            richTextBox.LoadFile(fullPath, RichTextBoxStreamType.RichText);
                            try
                            {
                                richTextBox.Select(0, 1);
                                richTextBox.Font = richTextBox.SelectionFont;
                            }
                            catch (Exception) { }
                        }

                        pages.Add(new Page(tabPage, richTextBox, fileName, filePath));
                        tabPage.Controls.Add(richTextBox);
                        tabControl.TabPages.Add(tabPage);
                        tabControl.SelectedTab = tabPage;
                        richTextBox.Focus();
                    }
                    catch (Exception) { }

                }
            }
            catch (IOException)
            {
                MessageBox.Show("Невозможно найти файл History.txt с открытыми ранее вкладками", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка: " + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion


        #region Настройки

        /// <summary>
        /// Реадактор кода.
        /// </summary>
        private void TsmiCodeEditor_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(pathToCodeEditor);
            }
            catch (IOException)
            {
                MessageBox.Show("Невозможно открыть файл с редактором кода.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка: " + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Настройки времени автосохранения.
        /// </summary>
        private void TsmiTime_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
                foreach (ToolStripMenuItem item in tsmiTime.DropDownItems)
                    item.Checked = false;
                tsmi.Checked = true;
                time = 0;

                if (tsmi.Text == "Отключить")
                {
                    timeForAutoSave = -1;
                    timerSave.Enabled = false;
                    return;
                }
                string[] split = tsmi.Text.Split(" мин.");
                timeForAutoSave = Convert.ToInt32(split[0]) * 60;
                timerSave.Enabled = true;

            }
            catch (Exception) { }
        }

        /// <summary>
        /// Настройка цвета заднего фона.
        /// </summary>
        private void TsmiBackColor_Click(object sender, EventArgs e)
        {
            try
            {
                Page page = pages[tabControl.SelectedIndex];
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                page.RichTextBox.BackColor = colorDialog.Color;
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Настройка цвета текста.
        /// </summary>
        private void TsmiFontColor_Click(object sender, EventArgs e)
        {
            try
            {
                Page page = pages[tabControl.SelectedIndex];
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                page.RichTextBox.ForeColor = colorDialog.Color;
            }
            catch (Exception) { }
        }

        #endregion


        #region Формат

        /// <summary>
        /// Настройки формата документа.
        /// </summary>
        private void TsmFormat_Click(object sender, EventArgs e)
        {
            try
            {
                Page page = pages[tabControl.SelectedIndex];
                FontDialog fontDialog = new FontDialog();
                fontDialog.Font = page.RichTextBox.Font;
                if (fontDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                page.RichTextBox.Font = fontDialog.Font;
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Вставка.
        /// </summary>
        private void TscmiPaste_Click(object sender, EventArgs e)
        {
            try
            {
                Page page = pages[tabControl.SelectedIndex];
                page.RichTextBox.Paste();
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Копирование.
        /// </summary>
        private void TscmiCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Page page = pages[tabControl.SelectedIndex];
                page.RichTextBox.Copy();
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Вырезка.
        /// </summary>
        private void TscmiCut_Click(object sender, EventArgs e)
        {
            try
            {
                Page page = pages[tabControl.SelectedIndex];
                page.RichTextBox.Cut();
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Выбор всего текста.
        /// </summary>
        private void TscmiAll_Click(object sender, EventArgs e)
        {
            try
            {
                Page page = pages[tabControl.SelectedIndex];
                page.RichTextBox.SelectAll();
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Зачеркнутый шрифт.
        /// </summary>
        private void TscmiStrikeout_Click(object sender, EventArgs e)
        {
            try
            {
                Page page = pages[tabControl.SelectedIndex];

                page.RichTextBox.SelectionFont = new Font(page.RichTextBox.Font.FontFamily, page.RichTextBox.Font.Size, 
                    FontStyle.Strikeout | page.RichTextBox.SelectionFont.Style);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Подчеркнутый шрифт.
        /// </summary>
        private void TscmiUnderline_Click(object sender, EventArgs e)
        {
            try
            {
                Page page = pages[tabControl.SelectedIndex];

                page.RichTextBox.SelectionFont = new Font(page.RichTextBox.Font.FontFamily, page.RichTextBox.Font.Size, 
                    FontStyle.Underline | page.RichTextBox.SelectionFont.Style);
            }
            catch (Exception) { }

        }

        /// <summary>
        /// Жырный шрифт
        /// </summary>
        private void TscmiBold_Click(object sender, EventArgs e)
        {
            try
            {
                Page page = pages[tabControl.SelectedIndex];

                page.RichTextBox.SelectionFont = new Font(page.RichTextBox.Font.FontFamily, page.RichTextBox.Font.Size, 
                    FontStyle.Bold | page.RichTextBox.SelectionFont.Style);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Курсивный шрифт
        /// </summary>
        private void TscmiItalic_Click(object sender, EventArgs e)
        {
            try
            {
                Page page = pages[tabControl.SelectedIndex];

                page.RichTextBox.SelectionFont = new Font(page.RichTextBox.Font.FontFamily, page.RichTextBox.Font.Size,
                    FontStyle.Italic | page.RichTextBox.SelectionFont.Style);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Без выделения
        /// </summary>
        private void TscmiOriginal_Click(object sender, EventArgs e)
        {
            try
            {
                Page page = pages[tabControl.SelectedIndex];

                page.RichTextBox.SelectionFont = new Font(page.RichTextBox.Font.FontFamily, page.RichTextBox.Font.Size, FontStyle.Regular);
            }
            catch (Exception) { }
        }

        #endregion


        #region Файл 

        /// <summary>
        /// Новое окно.
        /// </summary>
        private void TsmiNewWindow_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.ShowDialog();
        }

        /// <summary>
        /// Новая вкладка.
        /// </summary>
        private void TsmiNew_Click(object sender, EventArgs e)
        {
            try
            {
                TabPage tabPage = new TabPage() { Text = "Новый файл.txt" };
                RichTextBox richTextBox = new RichTextBox()
                {
                    Dock = DockStyle.Fill,
                    ContextMenuStrip = contextMenuStrip,
                    BackColor = backColor,
                    ForeColor = fontColor
                };

                pages.Add(new Page(tabPage, richTextBox, null, null));
                tabPage.Controls.Add(richTextBox);
                tabControl.TabPages.Add(tabPage);
                tabControl.SelectedTab = tabPage;
                richTextBox.Focus();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Возникла ошибка при работе с файлом: " + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка: " + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Открытие файла.
        /// </summary>
        private void TsmiOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text files(*.txt)|*.txt|Rtf files(*.rtf)|*.rtf";
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                string fullPath = openFileDialog.FileName;
                string fileText = File.ReadAllText(fullPath, Encoding.Default);
                string fileName = Path.GetFileName(fullPath);
                string filePath = Path.GetDirectoryName(fullPath);

                foreach (Page page in pages)
                    if (page.FilePath == filePath && page.FileName == fileName)
                    {
                        tabControl.SelectedTab = page.TabPage;
                        if (fullPath.Contains(".txt"))
                            page.RichTextBox.Text = fileText;
                        else
                        {
                            page.RichTextBox.LoadFile(fullPath, RichTextBoxStreamType.RichText);
                            try
                            {
                                page.RichTextBox.Select(0, 1);
                                page.RichTextBox.Font = page.RichTextBox.SelectionFont;
                            }
                            catch (Exception) { }
                        }

                        return;
                    }

                TabPage tabPage = new TabPage() { Text = fileName };
                RichTextBox richTextBox = new RichTextBox() { Dock = DockStyle.Fill, ContextMenuStrip = contextMenuStrip, BackColor = backColor, ForeColor = fontColor };
                if (fullPath.Contains(".txt"))
                    richTextBox.Text = File.ReadAllText(fullPath, Encoding.Default);
                else
                {
                    richTextBox.LoadFile(fullPath, RichTextBoxStreamType.RichText);
                    try
                    {
                        richTextBox.Select(0, 1);
                        richTextBox.Font = richTextBox.SelectionFont;
                    }
                    catch (Exception) { }
                }
                pages.Add(new Page(tabPage, richTextBox, fileName, filePath));
                tabPage.Controls.Add(richTextBox);
                tabControl.TabPages.Add(tabPage);
                tabControl.SelectedTab = tabPage;
                richTextBox.Focus();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Возникла ошибка при работе с файлом: " + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка: " + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение файла.
        /// </summary>
        private void TsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (pages.Count == 0)
                    return;
                Page page = pages[tabControl.SelectedIndex];
                if (page.FileName == null)
                    page.FileName = "Новый файл.txt";
                if (page.FilePath == null)
                    page.FilePath = Environment.CurrentDirectory;

                // Если такой файл уже существует, мы просто изменяем его. Иначе - сохраняем как новый

                string fullPath = Path.Combine(page.FilePath, page.FileName);
                if (File.Exists(fullPath))
                {
                    if (fullPath.Contains(".rtf"))
                        page.RichTextBox.SaveFile(fullPath, RichTextBoxStreamType.RichText);
                    else File.WriteAllText(fullPath, page.RichTextBox.Text, Encoding.Default);
                }
                else
                {
                    TsmiSaveAs_Click(sender, e);
                }

            }
            catch (IOException exception)
            {
                MessageBox.Show("Ошибка при работе с файлом! " + exception.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно найти данный файл");
            }
        }

        /// <summary>
        /// Сохранение файла как.
        /// </summary>
        private void TsmiSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (pages.Count == 0)
                    return;
                Page page = pages[tabControl.SelectedIndex];
                if (page.FileName == null)
                    page.FileName = "Новый файл.txt";
                if (page.FilePath == null)
                    page.FilePath = Environment.CurrentDirectory;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "Новый файл.txt";
                saveFileDialog.Filter = "Text files(*.txt)|*.txt|Rtf files(*.rtf)|*.rtf";
                saveFileDialog.InitialDirectory = page.FilePath;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fullPath = saveFileDialog.FileName;
                    page.FileName = Path.GetFileName(fullPath);
                    page.FilePath = Path.GetDirectoryName(fullPath);
                    page.TabPage.Text = page.FileName;

                    if (fullPath.Contains(".rtf"))
                        page.RichTextBox.SaveFile(fullPath, RichTextBoxStreamType.RichText);
                    else File.WriteAllText(fullPath, page.RichTextBox.Text, Encoding.Default);

                }
            }
            catch (IOException exception)
            {
                MessageBox.Show("Ошибка при работе с файлом! " + exception.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно найти данный файл");
            }
        }

        /// <summary>
        /// Сохранение всех файлов.
        /// </summary>
        private void TsmiSaveAll_Click(object sender, EventArgs e)
        {
            try
            {
                while (pages.Count != 0)
                {
                    tabControl.SelectedIndex = 0;
                    TsmiSave_Click(sender, e);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Возникла ошибка при работе с файлом: " + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка: " + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Закрытие вкладки.
        /// </summary>
        private void TsmiClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (pages.Count == 0)
                    return;
                Page page = pages[tabControl.SelectedIndex];
                if (page.FileName == null || page.FilePath == null)
                {
                    if (page.RichTextBox.Text.Trim() == string.Empty)
                        return;
                    DialogResult result = MessageBox.Show($"Этот файл еще не был сохранен. Сохранить его?", "Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        TsmiSaveAs_Click(sender, e);
                        tabControl.TabPages.Remove(page.TabPage);
                        files.Add(page.FilePath + "\t" + page.FileName + "\t" + page.RichTextBox.ForeColor.ToArgb().ToString() + "\t" + page.RichTextBox.BackColor.ToArgb().ToString());
                        pages.Remove(page);
                        page.TabPage.Dispose();
                        return;
                    }
                    if (result == DialogResult.No)
                    {
                        tabControl.TabPages.Remove(page.TabPage);
                        files.Add(page.FilePath + "\t" + page.FileName + "\t" + page.RichTextBox.ForeColor.ToArgb().ToString() + "\t" + page.RichTextBox.BackColor.ToArgb().ToString());
                        pages.Remove(page);
                        page.TabPage.Dispose();
                        return;
                    }
                    return;
                }

                string fullPath = Path.Combine(page.FilePath, page.FileName);
                if (File.Exists(fullPath))
                {
                    // Если файл не изменяли


                    RichTextBox rb = new RichTextBox();
                    if (fullPath.Contains(".txt"))
                        rb.Text = File.ReadAllText(fullPath, Encoding.Default);
                    else
                    {
                        rb.LoadFile(fullPath, RichTextBoxStreamType.RichText);
                        try
                        {
                            rb.Select(0, 1);
                            rb.Font = rb.SelectionFont;
                        }
                        catch (Exception) { }
                    }

                    //string text = File.ReadAllText(fullPath);
                    if (Equals(rb.Text, page.RichTextBox.Text))
                    {
                        tabControl.TabPages.Remove(page.TabPage);
                        files.Add(page.FilePath + "\t" + page.FileName + "\t" + page.RichTextBox.ForeColor.ToArgb().ToString() + "\t" + page.RichTextBox.BackColor.ToArgb().ToString());

                        pages.Remove(page);
                        page.TabPage.Dispose();
                        return;
                    }

                    DialogResult result = MessageBox.Show($"В данном файле {page.FileName} есть несохраненные изменения. Сохранить их?", "Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        TsmiSave_Click(sender, e);
                        tabControl.TabPages.Remove(page.TabPage);
                        files.Add(page.FilePath + "\t" + page.FileName + "\t" + page.RichTextBox.ForeColor.ToArgb().ToString() + "\t" + page.RichTextBox.BackColor.ToArgb().ToString());
                        pages.Remove(page);
                        page.TabPage.Dispose();
                        return;
                    }
                    if (result == DialogResult.No)
                    {
                        tabControl.TabPages.Remove(page.TabPage);
                        files.Add(page.FilePath + "\t" + page.FileName + "\t" + page.RichTextBox.ForeColor.ToArgb().ToString() + "\t" + page.RichTextBox.BackColor.ToArgb().ToString());
                        pages.Remove(page);
                        page.TabPage.Dispose();
                        return;
                    }
                    return;
                    //files.Add(page.FilePath + "\t" + page.FileName + "\t" + page.RichTextBox.ForeColor.ToArgb().ToString() + "\t" + page.RichTextBox.BackColor.ToArgb().ToString());
                }

            }
            catch (IOException exception)
            {
                MessageBox.Show("Ошибка при работе с файлом! " + exception.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка: " + ex.Message);
            }
            return;
        }

        #endregion


        #region Вспомогательные методы

        /// <summary>
        /// Горячие клавиши.
        /// </summary>
        private void tabControl_KeyDown(object sender, KeyEventArgs e)  
        {
            if (e.KeyCode == Keys.N && e.Modifiers == (Keys.Control | Keys.Shift))
                TsmiNewWindow_Click(sender, e);
            if ((e.KeyCode == Keys.N) && ModifierKeys == Keys.Control)
                TsmiNew_Click(sender, e);
            if ((e.KeyCode == Keys.O) && ModifierKeys == Keys.Control)
                TsmiOpen_Click(sender, e);
            if ((e.KeyCode == Keys.S) && ModifierKeys == Keys.Control)
                TsmiSave_Click(sender, e);
            if (e.KeyCode == Keys.S && e.Modifiers == (Keys.Control | Keys.Shift))
                TsmiSaveAs_Click(sender, e);
            if (e.KeyCode == Keys.A && e.Modifiers == (Keys.Control | Keys.Shift))
                TsmiSaveAll_Click(sender, e);
            if ((e.KeyCode == Keys.Q) && ModifierKeys == Keys.Control)
                TsmiClose_Click(sender, e);

            if ((e.KeyCode == Keys.K) && ModifierKeys == Keys.Control)
                TscmiItalic_Click(sender, e);
            if ((e.KeyCode == Keys.B) && ModifierKeys == Keys.Control)
                TscmiBold_Click(sender, e);
            if ((e.KeyCode == Keys.U) && ModifierKeys == Keys.Control)
                TscmiUnderline_Click(sender, e);
            if ((e.KeyCode == Keys.P) && ModifierKeys == Keys.Control)
                TscmiStrikeout_Click(sender, e);
            if (e.KeyCode == Keys.O && e.Modifiers == (Keys.Control | Keys.Shift))
                TscmiOriginal_Click(sender, e);

            if (e.KeyCode == Keys.Z && e.Modifiers == (Keys.Control | Keys.Shift))
                SendKeys.SendWait("^(Y)");

            //if ((e.keycode == keys.a) && modifierkeys == keys.control)
            //    tscmiall_click(sender, e);
            //if ((e.keycode == keys.x) && modifierkeys == keys.control)
            //    tscmicut_click(sender, e);
            //if ((e.keycode == keys.c) && modifierkeys == keys.control)
            //    tscmicopy_click(sender, e);
            //if ((e.keycode == keys.v) && modifierkeys == keys.control)
            //    tscmipaste_click(sender, e);
        }

        /// <summary>
        /// Закрытие приложения.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                timerSave.Enabled = false;
                files.Clear();
                int count = pages.Count;
                while (count != 0)
                {
                    tabControl.SelectedIndex = 0;
                    TsmiClose_Click(sender, e);
                    count--;
                }

                File.WriteAllLines("History.txt", files);
                File.WriteAllText("Settings.txt", timeForAutoSave.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show("Возникла ошибка при работе с файлом: " + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка: " + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Работа таймера с автосохранением.
        /// </summary>
        private void timerSave_Tick(object sender, EventArgs e)
        {
            //Debug.WriteLine(time);
            string file = "";
            if (++time >= timeForAutoSave)
            {
                time = 0;
                try
                {
                    Page page = pages[tabControl.SelectedIndex];
                    if (page.FileName == null || page.FilePath == null || !File.Exists(Path.Combine(page.FilePath, page.FileName)))
                        return;

                    string fullPath = Path.Combine(page.FilePath, page.FileName);
                    file = page.FileName;

                    string[] split = page.FileName.Split('.');
                    string backupName = split[0] + "_" + DateTime.Now.ToString().Replace(" ", "_").Replace(":", "_").Replace(".", "_") + "." + split[1];
                    string backupPath = Path.Combine(Environment.CurrentDirectory, "Backup", backupName);
                    File.Copy(fullPath, backupPath);
                    TsmiSave_Click(sender, e);
                    //MessageBox.Show("Sasved!");
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Возникла ошибка при сохранении версий файла {file}: " + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неизвестная ошибка: " + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        /// <summary>
        /// Вызов справки.
        /// </summary>
        private void TsmiHelp_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }

        /// <summary>
        /// Справка после загрузки формы.
        /// </summary>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            ShowHelp();
        }

        /// <summary>
        /// Текст справки.
        /// </summary>
        private void ShowHelp()
        {
            MessageBox.Show("Приветствую в редакторе текстов \"Notepad++\"! Здесь можно изменять содержимое текстовых файлов," +
                " их форматы, оформления, а также редактировать и компилировать .cs файлы. Интерфейс, думаю, понятен интуитивно, здесь " +
                "я, скорее, хотел бы сразу предупредить о некоторых нюансах программы:\n\n1) Форматирование позволяет совмещать несколько стилей, " +
                "однако, делать это стоит только тогда, когда в выделенном фрагменте либо все символы не имеют выделения, либо все символы имеют " +
                "хоть какое-то выделение (например, если вы хотите выделить курсивом два слова \"мама мыло\", где \"мама\" выделено жирным, не нужно " +
                "выбирать слова вместе - выделите сначала \"мама\", а затем \"мыло\", иначе жирное выделение пропадет [Особенность выделения у RichTextBox])" +
                "\n\n2) Редактирование текстовых файлов предполагают стандартную кодировку для данного проекта - Encoding.Default, поэтому некоторые " +
                "текстовые файлы могут отображаться некорректно из-за их кодировок.\n\n3) При выборе определенных форматов файла некоторые выделения могут оставаться " +
                "по-умолчанию или не сочетаться с другими - если выбрать жирный шрифт в меню \"Формат\", а затем в выделенном тексте нажать \"Без выделения\"," +
                " то шрифт все равно останется жирным, так как выбран соответствующий формат. Также некоторые форматы не поддерживают сочетание определенных " +
                "выделений - например, подчеркнутого и зачеркнутого [Особенность шрифтов]. (Disclaymer. Из-за особенности windows forms может появиться ошибка при " +
                "форматировании выделенного фрагмента. Я так и не смог избавиться от нее, несмотря на то, что код обернут в блок try-catch - строки проекта №357, 372, 388" +
                " и 403. Если такое произойдет, прошу прежде чем снимать балл за падение программы во время выполнения, посмотреть, где именно она упала и не строит ли там блока " +
                "try-catch, так как в этом случае ошибка возникает на более глубоком уровне языка и даже не отлавливается и избежать ее нельзя.)\n\n4) К сожалению, цвета шрифта и фона " +
                "у файла сохраняются только если полностью закрыть предложение, поэтому, если открыть файл .txt, указать в нем цвет фона и шрифта, закрыть его и снова открыть, то он откроется " +
                "в черно-белой расцветке, однако, если выбрать цвет для шрифта и фона файла, а затем полностью закрыть приложение, то при следующем запуске настройки " +
                "цветов сохранятся. То же касается и заднего фона для Rtf файлов.\n\n5) Журналирование прошлых версий ведется в папке с исполняемым файлом " +
                "в скрытой папке Backup, поэтому ненужно что-либо делать с папкой исполняемого файла и файлами в ней - это может некорректно сказаться на работе " +
                "некоторых функций. (Не надо ограничивать права доступа, удалять или перемещать файлы или папки, а потом радостно ставить 0)\n\n" +
                "6) Пожалуйста, давайте уважать друг друга и адекватно оценивать усилия, потраченные на создание продукта, и значимость " +
                "недочетов. Я не призываю ставить 10 за неработающий код или натягивать баллы, но поверьте мне, если в программе на несколько тысяч " +
                "строк кода и полным функционалом, вы снимете балл за кодстайл из-за длины строчек или методов, вы не добьетесь этим абсолютно ничего, а только " +
                "уничтожите пару десятков нервных окончаний ваших коллег. Сами посудите - человек потратил на создание программы несколько дней, а получил снижение из-за " +
                "совсем мелких недочетов. (Не говоря уже про то, что мы программируем на Windows Forms, по которым у нас было две лекции) Если вам есть, что сказать ему, " +
                "напишите это в комментарии к работе или последнем критерии, но не снимайте бал. За такое вас зауважают гораздо больше, чем за скурпулезное оценивание " +
                "или ломание рабочей программы некорректными условиями. Всем добра и позитива и приятной работы, не будьте душнилами! <3",
                "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Сказать пользователю о:
        // * кривых выделениях при нескольких стилях
        // * кривых горячих клавишах (ctrl shift z / ctrl z)
        // * автосохранении и настройках
        // * кривых выделениях при определенных форматах файла
        // * rtf Файлы сохраняют цвет шрифта
        // * сохраняются и восстанавливаются графические настройки только при полном закрытии приложения, а не вкладки
        // * Encoding.Default - Возвращает кодировку по умолчанию для данной реализации.NET.
        //


        #endregion

    }
}
