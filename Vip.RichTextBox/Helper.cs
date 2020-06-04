using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Vip.RichTextBox
{
    public static class Helper
    {
        #region Constants

        private const int WM_USER = (int) 0x400L;
        private const int EM_GETSCROLLPOS = WM_USER + 221;
        private const int EM_SETSCROLLPOS = WM_USER + 222;
        private const int WM_SETREDRAW = 0xB;
        public const float SelectionMargin = 8F;

        #endregion

        #region External Properties

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, ref Point lParam);

        [DllImport("user32.dll", EntryPoint = "GetScrollInfo")]
        private static extern bool GetScrollInfo(IntPtr hwnd, int nBar, ref ScrollInfo lpsi);

        #endregion

        #region Struct and Enums

        [Flags]
        public enum ScrollBarMask
        {
            Range = 1,
            PageSize = 2,
            Position = 4,
            TrackPosition = 16,
            Everything = Range | PageSize | Position | TrackPosition
        }

        [Flags]
        public enum ScrollBarType
        {
            Horizontal = 0,
            Vertical = 1,
            Control = 2
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ScrollInfo
        {
            public int SizeOfStructure;

            public int ScrollBarMask;

            public int MinimumScrollPosition;
            public int MaximumScrollPosition;
            public int PageSize;
            public int Position;
            public int TrackPosition;
        }

        #endregion

        #region Private Methods

        private static Font GetFontAtCharacterPosition(System.Windows.Forms.RichTextBox richTextBox, int charPos)
        {
            Font CharFont = default;
            if (richTextBox.SelectionStart == charPos && richTextBox.SelectionLength == 0)
            {
                // temporaily change selection
                int CurrentSS = richTextBox.SelectionStart;
                int CurrentSL = richTextBox.SelectionLength;
                richTextBox.SuspendLayout();
                richTextBox.Select(charPos, 0);
                CharFont = richTextBox.SelectionFont;
                richTextBox.Select(CurrentSS, CurrentSL);
                richTextBox.ResumeLayout();
            }
            else
            {
                CharFont = richTextBox.SelectionFont;
            }

            return CharFont;
        }

        private static int GetRightMostCharacterPosition(System.Windows.Forms.RichTextBox richTextBox)
        {
            var rightMostPos = 0;

            for (var lineNumber = 0; lineNumber <= richTextBox.Lines.GetUpperBound(0); lineNumber++)
            {
                var line = richTextBox.Lines[lineNumber];
                var lineLength = line.Length;

                if (lineLength > 0)
                {
                    var lineIndex = richTextBox.GetFirstCharIndexFromLine(lineNumber);
                    var charIndex = lineIndex + lineLength - 1;
                    var character = line.Substring(lineLength - 1, 1);
                    var lineWidth = richTextBox.GetPositionFromCharIndex(charIndex).X - richTextBox.GetPositionFromCharIndex(lineIndex).X;
                    var charFont = GetFontAtCharacterPosition(richTextBox, charIndex + 1);

                    int charWidth;
                    using (var g = richTextBox.CreateGraphics())
                        charWidth = (int) (g.MeasureString(character, charFont).Width * richTextBox.ZoomFactor);

                    lineWidth += charWidth;
                    if (lineWidth > rightMostPos) rightMostPos = lineWidth;
                }
            }

            return rightMostPos;
        }

        #endregion

        #region Public Methods

        public static Point GetScrollPosition(this System.Windows.Forms.RichTextBox RichTextBox)
        {
            Point RTBScrollPoint = default;
            SendMessage(RichTextBox.Handle, EM_GETSCROLLPOS, 0, ref RTBScrollPoint);
            return RTBScrollPoint;
        }

        public static void SetScrollPosition(this System.Windows.Forms.RichTextBox RichTextBox, Point RTBScrollPoint)
        {
            SendMessage(RichTextBox.Handle, EM_SETSCROLLPOS, 0, ref RTBScrollPoint);
        }

        public static ScrollInfo GetScrollBarInfo(this System.Windows.Forms.RichTextBox RichTextBox, ScrollBarType ScrollBarType, ScrollBarMask ScrollBarMask = ScrollBarMask.Everything)
        {
            var si = new ScrollInfo();
            si.SizeOfStructure = Marshal.SizeOf(si);
            si.ScrollBarMask = (int) ScrollBarMask;
            GetScrollInfo(RichTextBox.Handle, (int) ScrollBarType, ref si);
            return si;
        }

        public static int GetMaximumWidth(this System.Windows.Forms.RichTextBox RichTextBox)
        {
            if (RichTextBox.RightMargin > 0) return RichTextBox.RightMargin;

            var maxTextWidth = RichTextBox.ClientRectangle.Width;
            maxTextWidth -= (int) (RichTextBox.ZoomFactor * SelectionMargin);

            if (!RichTextBox.WordWrap)
            {
                if ((RichTextBox.ScrollBars & RichTextBoxScrollBars.Horizontal) == RichTextBoxScrollBars.Horizontal)
                    maxTextWidth += RichTextBox.GetScrollBarInfo(ScrollBarType.Horizontal).MaximumScrollPosition;

                maxTextWidth = Math.Max(maxTextWidth, GetRightMostCharacterPosition(RichTextBox));
            }

            return maxTextWidth;
        }

        public static void SetRedrawMode(this Control control, bool value)
        {
            SendMessage(control.Handle, WM_SETREDRAW, Convert.ToInt32(value) & 1, (IntPtr) 1);
            if (value) control.Invalidate();
        }

        #endregion
    }
}