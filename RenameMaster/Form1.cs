﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClosedXML.Excel;

namespace RenameMaster
{
    public partial class Form1 : Form
    {
        private class PathSet
        {
            public string srcPath;
            public string dstPath;
            public int row;
            public PathSet(int row)
            {
                this.srcPath = "";
                this.dstPath = "";
                this.row = row;
            }
        }

        List<PathSet> pathList;
        public Form1()
        {
            InitializeComponent();

            this.pathList = new List<PathSet>();
        }

        private void execute_button_Click(object sender, EventArgs e)
        {
            this.LogTextBox.Text = "";
            int res = LoadExcelFile(excelPath_textBox.Text);
            if (res == 0)
            {
                foreach (PathSet ps in this.pathList)
                {
                    bool go = true;
                    if (ps.srcPath == "")
                    {
                        LogTextBox.Text += ps.row.ToString() + "行目: " + "【失敗】コピー元Pathが未指定です。" + "\n\r";
                        go = false;
                    }
                    else if (!File.Exists(ps.srcPath))
                    {
                        LogTextBox.Text += ps.row.ToString() + "行目: " + "【失敗】コピー元Pathが存在しません。(" + ps.srcPath + ")" + "\r\n";
                        go = false;
                    }

                    if (ps.dstPath == "")
                    {
                        LogTextBox.Text += ps.row.ToString() + "行目: " + "【失敗】コピー先Pathが未指定です。" + "\r\n";
                        go = false;
                    }
                    else if (File.Exists(ps.dstPath))
                    {
                        if (overwrite_check.Checked)
                        {
                            LogTextBox.Text += ps.row.ToString() + "行目: " + "上書きしました。(" + ps.dstPath + ")" + "\r\n";
                        }
                        else
                        {
                            LogTextBox.Text += ps.row.ToString() + "行目: " + "【失敗】コピー先Pathがすでに存在します。(" + ps.dstPath + ")" + "\r\n";
                            go = false;
                        }
                    }

                    if (go)
                    {
                        CreateDirAndCopyFile(ps.srcPath, ps.dstPath);
                        LogTextBox.Text += ps.row.ToString() + "行目: " + "うまくいきました。\r\n";
                    }

                }
            }
        }

        private void CreateDirAndCopyFile(string sourceFullPath, string distFullPath)
        {
            string distDir = Path.GetDirectoryName(distFullPath);
            if (!Directory.Exists(distDir))
            {
                Directory.CreateDirectory(distDir);
                LogTextBox.Text += "フォルダを作成しました。(" + distDir + ")" + "\r\n";
            }

            File.Copy(sourceFullPath, distFullPath, true);
        }

        private int LoadExcelFile(string excelPath)
        {
            XLWorkbook workbook;
            try
            {
                if(excelPath == "")
                {
                    MessageBox.Show("まずエクセルファイルを指定してください(>_<)");
                    return -1;
                }
                workbook = new XLWorkbook(excelPath);

            }
            catch(IOException)
            {
                MessageBox.Show("エクセルファイルを閉じてください(>_<)");
                return -1;
            }
            IXLWorksheet worksheet = workbook.Worksheet(1);

            int rowmax = worksheet.LastRowUsed().RowNumber();
            int colmax = worksheet.LastColumnUsed().ColumnNumber();

            for(int r = 1; r <= rowmax; r++)
            {
                var ps = new PathSet(r);
                bool go = false;
                bool from = false;
                bool to = false;
                for(int c = 1; c <= colmax; c++)
                {
                    IXLCell cell = worksheet.Cell(r, c);
                    string val = (string)cell.Value;
                    
                    if (!go)
                    {
                        if (val == "GO")
                        {
                            go = true;
                        }
                    }
                    else
                    {
                        if (val == "from")
                        {
                            from = true;
                            to = false;
                        }
                        else if (val == "to")
                        {
                            from = false;
                            to = true;
                        }
                        else if (val == "END")
                        {
                            from = false;
                            to = false;
                            go = false;
                            this.pathList.Add(ps);
                        }
                        else
                        {
                            if (from)
                            {
                                ps.srcPath += val;
                            }

                            if (to)
                            {
                                ps.dstPath += val;
                            }
                        }
                    }
                }
            }
            return 0;
        }

        private void openExcel_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                excelPath_textBox.Text = openFileDialog1.FileName;
            }
        }
    }
}
