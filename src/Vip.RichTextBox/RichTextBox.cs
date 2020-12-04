// ***********************************************************************
// Assembly         : Vip.RichTextBox
// Author           : Leandro Ferreira
// Created          : 04-06-2020
//
// ***********************************************************************
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2020 VIP Soluções
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Vip.RichTextBox
{
    public partial class RichTextBox : UserControl
    {
        #region Properties

        #region Private

        private bool _settingFont;
        private bool _trackingChanges = true;
        private bool _haveChangedText;
        private int _selectionOffset;
        private int _maxTextWidth;
        private const float _maxFontSize = 1638.35f;
        private const float selectionMargin = 8F;

        #endregion

        #region Public

        [Browsable(false)]
        public bool IsTextChanged
        {
            get => _haveChangedText;
            set
            {
                _haveChangedText = value;
                rtb.Modified = value;
                UpdateToolBar();
            }
        }

        [Browsable(true)]
        [Description("Enable or disable accept tabs in RichTextBox")]
        public bool AllowTab
        {
            get => rtb.AcceptsTab;
            set => rtb.AcceptsTab = value;
        }

        [Browsable(true)]
        [Category("Data")]
        [Description("Get Or set plain text of rich-text box")]
        public override string Text
        {
            get => rtb.Text;
            set
            {
                rtb.Text = value;
                rtb.Modified = true;
                UpdateToolBar();
            }
        }

        [Browsable(true)]
        [Category("Data")]
        [Description("Get Or set RTF text of rich-text box")]
        public string Rtf
        {
            get => rtb.Rtf;
            set
            {
                if (value != rtb.Rtf)
                {
                    rtb.Rtf = value;
                    UpdateToolBar();
                }
            }
        }

        [Browsable(true)] public System.Windows.Forms.RichTextBox rtbDefault => rtb;

        #endregion

        #endregion

        #region Constructor

        public RichTextBox()
        {
            InitializeComponent();
            toolStrip.Cursor = Cursors.Hand;
            _haveChangedText = false;
            rtb.Modified = false;
            _maxTextWidth = rtb.GetMaximumWidth();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        #endregion

        #region Methods Events

        #region UserControl

        private void RichTextBox_Load(object sender, EventArgs e)
        {
            RichTextBox_Enter(sender, e);
        }

        private void RichTextBox_Enter(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            UpdateToolbarNoChangesTracked();
            rtb.Focus();
        }

        private void RichTextBox_Resize(object sender, EventArgs e)
        {
            var positionY = 0;
            var rtbHeight = Height;

            GetHorizontalInfo();

            toolStrip.SetBounds(0, 0, Width, toolStrip.Height);
            positionY += toolStrip.Height;
            rtbHeight -= toolStrip.Height;
            rtb.SetBounds(0, positionY, Width, rtbHeight);
        }

        #endregion

        #region ToolStrip

        private void toolStrip_VisibleChanged(object sender, EventArgs e)
        {
            RichTextBox_Resize(sender, e);
        }

        #endregion

        #region RichTextBox

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            rtb_SelectionChanged(sender, e);
            HandleTrackedChange();
        }

        private void rtb_SelectionChanged(object sender, EventArgs e)
        {
            GetHorizontalInfo();

            var currentFont = rtb.SelectionFont;
            if (currentFont != null)
            {
                if (!_settingFont)
                {
                    _settingFont = true;
                    if (tsFontName.Text != currentFont.Name) tsFontName.Text = currentFont.Name;
                    if (tsFontSize.Text != currentFont.SizeInPoints.ToString()) tsFontSize.Text = currentFont.SizeInPoints.ToString();
                    _settingFont = false;
                }

                tsBold.Checked = currentFont.Bold;
                tsmBold.Checked = currentFont.Bold;
                tsItalic.Checked = currentFont.Italic;
                tsmItalic.Checked = currentFont.Italic;
                tsUnderline.Checked = currentFont.Underline;
                tsmUnderline.Checked = currentFont.Underline;
            }

            tsAlignLeft.Checked = rtb.SelectionAlignment == HorizontalAlignment.Left;
            tsAlignCenter.Checked = rtb.SelectionAlignment == HorizontalAlignment.Center;
            tsAlignRight.Checked = rtb.SelectionAlignment == HorizontalAlignment.Right;

            tsmLeft.Checked = tsAlignLeft.Checked;
            tsmCenter.Checked = tsAlignCenter.Checked;
            tsmRight.Checked = tsAlignRight.Checked;
        }

        private void rtb_Protected(object sender, EventArgs e)
        {
            if (rtb.TextLength == 0)
            {
                rtb.SelectionProtected = false;
                return;
            }

            var canceling = new CancelEventArgs {Cancel = false};
            OnTextProtected(canceling);
        }

        private void rtb_HScroll(object sender, EventArgs e)
        {
            var scrollPosition = rtb.GetScrollPosition();
            if (scrollPosition.X > _maxTextWidth - rtb.ClientRectangle.Width + _selectionOffset)
            {
                scrollPosition.X = _maxTextWidth - rtb.ClientRectangle.Width + _selectionOffset;
                rtb.SetScrollPosition(scrollPosition);
            }
        }

        #endregion

        #region ContextMenu

        private void tsmSelectAll_Click(object sender, EventArgs e)
        {
            rtb.SelectAll();
        }

        private void tsmCopy_Click(object sender, EventArgs e)
        {
            rtb.Copy();
        }

        private void tsmCut_Click(object sender, EventArgs e)
        {
            rtb.Cut();
        }

        private void tsmPaste_Click(object sender, EventArgs e)
        {
            rtb.Paste();
        }

        private void tsmUndo_Click(object sender, EventArgs e)
        {
            rtb.Undo();
        }

        private void tsmRedo_Click(object sender, EventArgs e)
        {
            rtb.Redo();
        }

        private void tsmConfigureFont_Click(object sender, EventArgs e)
        {
            dlgFont.Font = GetCurrentFont();
            dlgFont.Color = GetCurrentColor();

            if (dlgFont.ShowDialog() != DialogResult.Cancel)
            {
                rtb.SelectionFont = dlgFont.Font;
                rtb.SelectionColor = dlgFont.Color;
                UpdateToolbarNoChangesTracked();
            }
        }

        #endregion

        #region ToolStrip

        private void tsFontColor_Click(object sender, EventArgs e)
        {
            dlgColor.Color = GetCurrentColor();
            if (dlgColor.ShowDialog() != DialogResult.Cancel)
            {
                rtb.SelectionColor = dlgColor.Color;
                UpdateToolbarNoChangesTracked();
            }
        }

        private void tsFontBackColor_Click(object sender, EventArgs e)
        {
            dlgColor.Color = GetCurrentBackColor();
            if (dlgColor.ShowDialog() != DialogResult.Cancel)
            {
                rtb.SelectionBackColor = dlgColor.Color;
                UpdateToolbarNoChangesTracked();
            }
        }

        private void tsFontName_DropDown(object sender, EventArgs e)
        {
            tsFontName.Items.Clear();
            foreach (var fontFamily in FontFamily.Families) tsFontName.Items.Add(fontFamily.Name);
        }

        private void tsFontName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_settingFont)
            {
                _settingFont = true;
                SetValidFontName();
                _settingFont = false;
            }

            tsFontName.Select(tsFontName.Text.Length, 0);
        }

        private void tsFontName_TextChanged(object sender, EventArgs e)
        {
            if (!_settingFont)
            {
                _settingFont = true;
                SetValidFontName();
                tsFontName.Select(tsFontName.Text.Length, 0);
                _settingFont = false;
            }
        }

        private void tsFontName_Validating(object sender, CancelEventArgs e)
        {
            if (SetValidFontName())
                ResetFocus();
            else
                e.Cancel = true;
        }

        private void tsFontSize_Leave(object sender, EventArgs e)
        {
            if (SetValidFontSize())
                ResetFocus();
            else
                tsFontSize.Focus();
        }

        private void tsFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_settingFont)
            {
                _settingFont = true;
                SetValidFontSize();
                _settingFont = false;
            }

            tsFontSize.Select(tsFontSize.Text.Length, 0);
        }

        private void tsFontSize_TextChanged(object sender, EventArgs e)
        {
            if (!_settingFont)
            {
                _settingFont = true;
                SetValidFontSize();
                tsFontSize.Select(tsFontSize.Text.Length, 0);
                _settingFont = false;
            }
        }

        private void tsFontSize_Validating(object sender, CancelEventArgs e)
        {
            if (SetValidFontSize())
                rtb.Focus();
            else
                e.Cancel = true;
        }

        private void tsBold_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Bold);
            ResetFocus();
        }

        private void tsItalic_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Italic);
            ResetFocus();
        }

        private void tsUnderline_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Underline);
            ResetFocus();
        }

        private void tsAlignLeft_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Left;
            ResetFocus();
        }

        private void tsAlignCenter_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Center;
            ResetFocus();
        }

        private void tsAlignRight_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Right;
        }

        #endregion

        #endregion

        #region Methods

        private void GetHorizontalInfo()
        {
            _selectionOffset = rtb.Padding.Left + 1;
            if (rtb.ShowSelectionMargin) _selectionOffset += (int) (selectionMargin * rtb.ZoomFactor);

            _maxTextWidth = rtb.GetMaximumWidth();
            if (_maxTextWidth > rtb.ClientRectangle.Width - _selectionOffset)
            {
                rtb.WordWrap = false;
                rtb.ScrollBars = rtb.ScrollBars | RichTextBoxScrollBars.Horizontal;
            }

            if (rtb.RightMargin != _maxTextWidth) rtb.RightMargin = _maxTextWidth;
        }

        private Font GetCurrentFont()
        {
            TurnRedrawMode(false);
            var length = rtb.SelectionLength;
            rtb.SelectionLength = 0;
            var currentFont = rtb.SelectionFont;
            rtb.SelectionLength = length;
            TurnRedrawMode(true);

            return currentFont;
        }

        private Color GetCurrentColor()
        {
            var currentColor = rtb.SelectionColor;
            if (currentColor.IsEmpty)
            {
                TurnRedrawMode(false);
                var length = rtb.SelectionLength;
                rtb.SelectionLength = 0;
                currentColor = rtb.SelectionColor;
                rtb.SelectionLength = length;
                TurnRedrawMode(true);
            }

            return currentColor;
        }

        private Color GetCurrentBackColor()
        {
            var currentColor = rtb.SelectionBackColor;
            if (currentColor.IsEmpty)
            {
                TurnRedrawMode(false);
                var length = rtb.SelectionLength;
                rtb.SelectionLength = 0;
                currentColor = rtb.SelectionBackColor;
                rtb.SelectionLength = length;
                TurnRedrawMode(true);
            }

            return currentColor;
        }

        private void ToggleFontStyle(FontStyle style)
        {
            var currentFont = GetCurrentFont();
            if (currentFont != null)
            {
                var newFontStyle = currentFont.Style ^ style;
                rtb.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void UpdateToolbarNoChangesTracked()
        {
            _trackingChanges = false;
            UpdateToolBar();
            _trackingChanges = true;
        }

        private void UpdateToolBar()
        {
            rtb_TextChanged(rtb, new EventArgs());
            ResetFocus();
        }

        private void ResetFocus()
        {
            if (ActiveControl != rtb)
                rtb.Focus();
        }

        private void HandleTrackedChange()
        {
            if (_trackingChanges && rtb.Modified)
            {
                _haveChangedText = true;
                OnChangesMade(new EventArgs());
            }

            rtb.Modified = false;
        }

        private void TurnRedrawMode(bool value)
        {
            rtb.SetRedrawMode(value);
            toolStrip.SetRedrawMode(value);
            if (value)
                rtb.ResumeLayout();
            else
                rtb.SuspendLayout();
        }

        private bool SetValidFontName()
        {
            var newFontName = tsFontName.Text;
            if (!string.IsNullOrEmpty(newFontName))
                if (FontFamily.Families.Any(x => x.Name == newFontName))
                {
                    var currentFont = GetCurrentFont();
                    rtb.SelectionFont = new Font(newFontName, currentFont.Size, currentFont.Style);
                    return true;
                }

            return false;
        }

        private bool SetValidFontSize()
        {
            if (float.TryParse(tsFontSize.Text, out var newFontSize))
                if (newFontSize > 0 && newFontSize <= _maxFontSize)
                {
                    var currentFont = GetCurrentFont();
                    rtb.SelectionFont = new Font(currentFont.FontFamily, newFontSize, currentFont.Style);
                    return true;
                }

            return false;
        }

        #endregion

        #region Events

        public event ChangesMadeEventHandler ChangesMade;
        public event TextProtectedEventHandler TextProtected;

        public delegate void ChangesMadeEventHandler(object sender, EventArgs e);

        public delegate void TextProtectedEventHandler(object sender, CancelEventArgs e);

        protected virtual void OnChangesMade(EventArgs e)
        {
            ChangesMade?.Invoke(this, e);
        }

        protected virtual void OnTextProtected(CancelEventArgs e)
        {
            TextProtected?.Invoke(this, e);
        }

        #endregion
    }
}