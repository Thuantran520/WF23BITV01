using System.Security.Cryptography;

namespace _20032026
{
    public partial class Form1 : Form
    {
        string fileName = string.Empty;
        bool isChanged = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void XuLyClickOpen(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Text files|*.txt|My Word|*.rtf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.EndsWith(".txt"))
                {
                    richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                    //richTextBox1.Text = File.ReadAllText(ofd.FileName);
                }
                else
                {
                    richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        //Save
        private void XuLySaveFile(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {

                saveDataToFile (fileName, richTextBox1);
            }
        }

        private void saveDataToFile(string fileName, RichTextBox richTextBox1)
        {
            if (fileName.EndsWith(".txt"))
            {
                richTextBox1.SaveFile(fileName, RichTextBoxStreamType.PlainText);
            }
            else
            {
                richTextBox1.SaveFile(fileName, RichTextBoxStreamType.RichText);
            }
        }

        // Select font
        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fd = new FontDialog();
            fd.ShowColor = true;
            fd.ShowApply = true;
            fd.Apply += new EventHandler(XuLyApplyFont);
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
                richTextBox1.SelectionColor = fd.Color;
            }
        }

        // Giu trang thai kieu chu
        private void fontToggleStyle(FontStyle styleToToggle)
        {
            if (richTextBox1 != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ styleToToggle;
                richTextBox1.SelectionFont = new Font(currentFont, newStyle);

            }
        }

        // In dam
        private void boldFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontToggleStyle(FontStyle.Bold);
            btnBold.Checked = richTextBox1.SelectionFont.Bold;
            boldToolStripMenuItem.Checked = richTextBox1.SelectionFont.Bold;
        }

        // In nghien
        private void ItalicFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontToggleStyle(FontStyle.Italic);
            btnItalic.Checked = richTextBox1.SelectionFont.Italic;
            italicToolStripMenuItem.Checked = richTextBox1.SelectionFont.Italic;

        }

        //Underline
        private void underlineFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontToggleStyle(FontStyle.Underline);
            btnUnderline.Checked = richTextBox1.SelectionFont.Underline;
            underlineToolStripMenuItem.Checked = richTextBox1.SelectionFont.Underline;
        }

        // Frmt lai kieu chu
        private void normalFontToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);

                btnBold.Checked = false;
                btnItalic.Checked = false;
                btnUnderline.Checked = false;

                boldToolStripMenuItem.Checked = false;
                italicToolStripMenuItem.Checked = false;
                underlineToolStripMenuItem.Checked = false;

                UpdateAlignmentButtons();
                UpdateIndentMenuState();
            }
        }

        // Apply Font
        private void XuLyApplyFont(object sender, EventArgs e)
        {
            var fd = sender as FontDialog;
            richTextBox1.SelectionFont = fd.Font;
            richTextBox1.SelectionColor = fd.Color;
        }

        // Màu chữ
        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        // Save As
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Text files|*.txt|My Word|*.rtf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;
                this.Text = "Document: " + fileName;
                saveDataToFile(fileName, richTextBox1);
            }
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = string.Empty;
            this.Text = "New document";
            richTextBox1.Clear();
        }

        // Copy
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        // Cắt
        private void cutToolStripMenuItem_Clicck(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        // Past
        private void pastToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        //Select All
        private void selectAllToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        //Undo
        private void undoToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        //Redo
        private void redoToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        // Chèn hình ảnh
        private void insertImagesScripMenuItem_Click(Object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image files: (*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png ";
            ofd.Title = "Chon hinh anh";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image img = Image.FromFile(ofd.FileName);
                    Clipboard.SetImage(img);
                    richTextBox1.Paste();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi khong the tai anh" + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Page color
        private void pagecolorScripMenuItem_Click(Object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = cd.Color;

                if (cd.Color == Color.Black)
                {
                    richTextBox1.ForeColor = Color.White;
                }
                else
                {
                    richTextBox1.ForeColor = Color.Black;
                }
            }
        }

        // Cap nhat trang thai (checked)
        private void UpdateAlignmentButtons()
        {
            btnAlignLeft.Checked = (richTextBox1.SelectionAlignment == HorizontalAlignment.Left);
            btnAlignCenter.Checked = (richTextBox1.SelectionAlignment == HorizontalAlignment.Center);
            btnAlignRight.Checked = (richTextBox1.SelectionAlignment == HorizontalAlignment.Right);

            leftToolStripMenuItem.Checked = (richTextBox1.SelectionAlignment == HorizontalAlignment.Left);
            rightToolStripMenuItem.Checked = (richTextBox1.SelectionAlignment == HorizontalAlignment.Right);
            centerToolStripMenuItem.Checked = (richTextBox1.SelectionAlignment == HorizontalAlignment.Center);
        }

        // Canh le trai
        private void btnAlignLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            UpdateAlignmentButtons();
        }

        // Canh giua
        private void btnAlignCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            UpdateAlignmentButtons();

        }

        // Canh phai
        private void btnAlignRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            UpdateAlignmentButtons();

        }

        private void SetParagraphIndent(int indentValue, ToolStripMenuItem clickedItem)
        {
            richTextBox1.SelectionIndent = indentValue;

            noneIndentToolStripMenuItem.Checked = false;
            pt5IndentToolStripMenuItem.Checked = false;
            pt10IndentToolStripMenuItem.Checked = false;
            pt15IndentToolStripMenuItem.Checked = false;
            pt20IndentToolStripMenuItem.Checked = false;

            clickedItem.Checked = true;
        }


        private void noneIndentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 0 = Không thụt lề
            SetParagraphIndent(0, (ToolStripMenuItem)sender);
        }

        private void pt5IndentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Thụt lề 5 đơn vị (bạn có thể nhân hệ số nếu muốn khoảng cách rộng hơn, ví dụ 10, 20 pixel)
            SetParagraphIndent(5, (ToolStripMenuItem)sender);
        }

        private void pt10IndentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetParagraphIndent(10, (ToolStripMenuItem)sender);
        }

        private void pt15IndentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetParagraphIndent(15, (ToolStripMenuItem)sender);
        }

        private void pt20IndentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetParagraphIndent(20, (ToolStripMenuItem)sender);
        }

        private void UpdateIndentMenuState()
        {
            int currentIndent = richTextBox1.SelectionIndent;

            noneIndentToolStripMenuItem.Checked = false;
            pt5IndentToolStripMenuItem.Checked = false;
            pt10IndentToolStripMenuItem.Checked = false;
            pt15IndentToolStripMenuItem.Checked = false;
            pt20IndentToolStripMenuItem.Checked = false;

            if (currentIndent == 0) noneIndentToolStripMenuItem.Checked = true;
            else if (currentIndent == 5) pt5IndentToolStripMenuItem.Checked = true;
            else if (currentIndent == 10) pt10IndentToolStripMenuItem.Checked = true;
            else if (currentIndent == 15) pt15IndentToolStripMenuItem.Checked = true;
            else if (currentIndent == 20) pt20IndentToolStripMenuItem.Checked = true;
        }
    }
}
