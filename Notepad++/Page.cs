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

namespace Notepad__
{
    class Page
    {
        public TabPage TabPage { get; private set; }
        public RichTextBox RichTextBox { get; private set; }
        public string FileName { get;  set; }
        public string FilePath { get;  set; }

        /// <summary>
        /// Страница с окном для вывода текста.
        /// </summary>
        /// <param name="tabPage">Элемент для TabControl.</param>
        /// <param name="richTextBox">Окно с выводом файла.</param>
        /// <param name="name">Название файла с расширением.</param>
        /// <param name="path">Директория, в которой находится файл.</param>
        public Page(TabPage tabPage, RichTextBox richTextBox, string name, string path)
        {
            TabPage = tabPage;
            FileName = name;
            FilePath = path;
            RichTextBox = richTextBox;
        }
    }
}
