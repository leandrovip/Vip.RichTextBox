using System.ComponentModel;

namespace Vip.RichTextBox
{
    partial class RichTextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RichTextBox));
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBold = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfigureFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsFontColor = new System.Windows.Forms.ToolStripButton();
            this.tsFontBackColor = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFont = new System.Windows.Forms.ToolStripButton();
            this.tsFontName = new System.Windows.Forms.ToolStripComboBox();
            this.tsFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBold = new System.Windows.Forms.ToolStripButton();
            this.tsItalic = new System.Windows.Forms.ToolStripButton();
            this.tsUnderline = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.tsAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.tsAlignRight = new System.Windows.Forms.ToolStripButton();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.ctxMenu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb
            // 
            this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb.ContextMenuStrip = this.ctxMenu;
            this.rtb.EnableAutoDragDrop = true;
            this.rtb.HideSelection = false;
            this.rtb.Location = new System.Drawing.Point(3, 28);
            this.rtb.Name = "rtb";
            this.rtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtb.ShowSelectionMargin = true;
            this.rtb.Size = new System.Drawing.Size(614, 169);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "";
            this.rtb.HScroll += new System.EventHandler(this.rtb_HScroll);
            this.rtb.Protected += new System.EventHandler(this.rtb_Protected);
            this.rtb.SelectionChanged += new System.EventHandler(this.rtb_SelectionChanged);
            this.rtb.TextChanged += new System.EventHandler(this.rtb_TextChanged);
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEdit,
            this.tsmFont,
            this.tsmAlign});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.ShowImageMargin = false;
            this.ctxMenu.Size = new System.Drawing.Size(119, 70);
            // 
            // tsmEdit
            // 
            this.tsmEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSelectAll,
            this.tsmCopy,
            this.tsmCut,
            this.tsmPaste,
            this.tsmUndo,
            this.tsmRedo});
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(118, 22);
            this.tsmEdit.Text = "&Editar";
            // 
            // tsmSelectAll
            // 
            this.tsmSelectAll.Name = "tsmSelectAll";
            this.tsmSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmSelectAll.Size = new System.Drawing.Size(200, 22);
            this.tsmSelectAll.Text = "Selecionar Tudo";
            this.tsmSelectAll.Click += new System.EventHandler(this.tsmSelectAll_Click);
            // 
            // tsmCopy
            // 
            this.tsmCopy.Name = "tsmCopy";
            this.tsmCopy.ShortcutKeyDisplayString = "";
            this.tsmCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmCopy.Size = new System.Drawing.Size(200, 22);
            this.tsmCopy.Text = "Copiar";
            this.tsmCopy.Click += new System.EventHandler(this.tsmCopy_Click);
            // 
            // tsmCut
            // 
            this.tsmCut.Name = "tsmCut";
            this.tsmCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmCut.Size = new System.Drawing.Size(200, 22);
            this.tsmCut.Text = "Recortar";
            this.tsmCut.Click += new System.EventHandler(this.tsmCut_Click);
            // 
            // tsmPaste
            // 
            this.tsmPaste.Name = "tsmPaste";
            this.tsmPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmPaste.Size = new System.Drawing.Size(200, 22);
            this.tsmPaste.Text = "Colar";
            this.tsmPaste.Click += new System.EventHandler(this.tsmPaste_Click);
            // 
            // tsmUndo
            // 
            this.tsmUndo.Name = "tsmUndo";
            this.tsmUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmUndo.Size = new System.Drawing.Size(200, 22);
            this.tsmUndo.Text = "Desfazer";
            this.tsmUndo.Click += new System.EventHandler(this.tsmUndo_Click);
            // 
            // tsmRedo
            // 
            this.tsmRedo.Name = "tsmRedo";
            this.tsmRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmRedo.Size = new System.Drawing.Size(200, 22);
            this.tsmRedo.Text = "Refazer";
            this.tsmRedo.Click += new System.EventHandler(this.tsmRedo_Click);
            // 
            // tsmFont
            // 
            this.tsmFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBold,
            this.tsmItalic,
            this.tsmUnderline,
            this.tsmConfigureFont});
            this.tsmFont.Name = "tsmFont";
            this.tsmFont.Size = new System.Drawing.Size(118, 22);
            this.tsmFont.Text = "&Fonte";
            // 
            // tsmBold
            // 
            this.tsmBold.Name = "tsmBold";
            this.tsmBold.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.tsmBold.Size = new System.Drawing.Size(236, 22);
            this.tsmBold.Text = "Negrito";
            this.tsmBold.Click += new System.EventHandler(this.tsBold_Click);
            // 
            // tsmItalic
            // 
            this.tsmItalic.Name = "tsmItalic";
            this.tsmItalic.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.tsmItalic.Size = new System.Drawing.Size(236, 22);
            this.tsmItalic.Text = "Itálico";
            this.tsmItalic.Click += new System.EventHandler(this.tsItalic_Click);
            // 
            // tsmUnderline
            // 
            this.tsmUnderline.Name = "tsmUnderline";
            this.tsmUnderline.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.tsmUnderline.Size = new System.Drawing.Size(236, 22);
            this.tsmUnderline.Text = "Sublinhado";
            this.tsmUnderline.Click += new System.EventHandler(this.tsUnderline_Click);
            // 
            // tsmConfigureFont
            // 
            this.tsmConfigureFont.Name = "tsmConfigureFont";
            this.tsmConfigureFont.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.tsmConfigureFont.Size = new System.Drawing.Size(236, 22);
            this.tsmConfigureFont.Text = "Configurar Fonte";
            this.tsmConfigureFont.Click += new System.EventHandler(this.tsmConfigureFont_Click);
            // 
            // tsmAlign
            // 
            this.tsmAlign.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLeft,
            this.tsmCenter,
            this.tsmRight});
            this.tsmAlign.Name = "tsmAlign";
            this.tsmAlign.Size = new System.Drawing.Size(118, 22);
            this.tsmAlign.Text = "&Alinhamento";
            // 
            // tsmLeft
            // 
            this.tsmLeft.Name = "tsmLeft";
            this.tsmLeft.Size = new System.Drawing.Size(122, 22);
            this.tsmLeft.Text = "Esquerda";
            this.tsmLeft.Click += new System.EventHandler(this.tsAlignLeft_Click);
            // 
            // tsmCenter
            // 
            this.tsmCenter.Name = "tsmCenter";
            this.tsmCenter.Size = new System.Drawing.Size(122, 22);
            this.tsmCenter.Text = "Centro";
            this.tsmCenter.Click += new System.EventHandler(this.tsAlignCenter_Click);
            // 
            // tsmRight
            // 
            this.tsmRight.Name = "tsmRight";
            this.tsmRight.Size = new System.Drawing.Size(122, 22);
            this.tsmRight.Text = "Direita";
            this.tsmRight.Click += new System.EventHandler(this.tsAlignRight_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFontColor,
            this.tsFontBackColor,
            this.tsSeparator1,
            this.tsFont,
            this.tsFontName,
            this.tsFontSize,
            this.tsSeparator2,
            this.tsBold,
            this.tsItalic,
            this.tsUnderline,
            this.tsSeparator3,
            this.tsAlignLeft,
            this.tsAlignCenter,
            this.tsAlignRight});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(620, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 1;
            this.toolStrip.VisibleChanged += new System.EventHandler(this.toolStrip_VisibleChanged);
            // 
            // tsFontColor
            // 
            this.tsFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFontColor.Image = ((System.Drawing.Image)(resources.GetObject("tsFontColor.Image")));
            this.tsFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFontColor.Name = "tsFontColor";
            this.tsFontColor.Size = new System.Drawing.Size(23, 22);
            this.tsFontColor.Text = "Cor da Fonte";
            this.tsFontColor.ToolTipText = "Cor da Fonte";
            this.tsFontColor.Click += new System.EventHandler(this.tsFontColor_Click);
            // 
            // tsFontBackColor
            // 
            this.tsFontBackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFontBackColor.Image = ((System.Drawing.Image)(resources.GetObject("tsFontBackColor.Image")));
            this.tsFontBackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFontBackColor.Name = "tsFontBackColor";
            this.tsFontBackColor.Size = new System.Drawing.Size(23, 22);
            this.tsFontBackColor.Text = "Cor de Fundo";
            this.tsFontBackColor.ToolTipText = "Cor de Fundo";
            this.tsFontBackColor.Click += new System.EventHandler(this.tsFontBackColor_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsFont
            // 
            this.tsFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFont.Image = ((System.Drawing.Image)(resources.GetObject("tsFont.Image")));
            this.tsFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFont.Name = "tsFont";
            this.tsFont.Size = new System.Drawing.Size(23, 22);
            this.tsFont.Text = "Alterar Fonte";
            this.tsFont.ToolTipText = "Alterar Fonte";
            this.tsFont.Click += new System.EventHandler(this.tsmConfigureFont_Click);
            // 
            // tsFontName
            // 
            this.tsFontName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tsFontName.Name = "tsFontName";
            this.tsFontName.Size = new System.Drawing.Size(160, 25);
            this.tsFontName.ToolTipText = "Fonte";
            this.tsFontName.DropDown += new System.EventHandler(this.tsFontName_DropDown);
            this.tsFontName.SelectedIndexChanged += new System.EventHandler(this.tsFontName_SelectedIndexChanged);
            this.tsFontName.Validating += new System.ComponentModel.CancelEventHandler(this.tsFontName_Validating);
            this.tsFontName.TextChanged += new System.EventHandler(this.tsFontName_TextChanged);
            // 
            // tsFontSize
            // 
            this.tsFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "38",
            "48",
            "72"});
            this.tsFontSize.Name = "tsFontSize";
            this.tsFontSize.Size = new System.Drawing.Size(75, 25);
            this.tsFontSize.ToolTipText = "Tamanho da Fonte";
            this.tsFontSize.SelectedIndexChanged += new System.EventHandler(this.tsFontSize_SelectedIndexChanged);
            this.tsFontSize.Leave += new System.EventHandler(this.tsFontSize_Leave);
            this.tsFontSize.Validating += new System.ComponentModel.CancelEventHandler(this.tsFontSize_Validating);
            this.tsFontSize.TextChanged += new System.EventHandler(this.tsFontSize_TextChanged);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBold
            // 
            this.tsBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBold.Image = ((System.Drawing.Image)(resources.GetObject("tsBold.Image")));
            this.tsBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBold.Name = "tsBold";
            this.tsBold.Size = new System.Drawing.Size(23, 22);
            this.tsBold.Text = "Negrito";
            this.tsBold.ToolTipText = "Negrito";
            this.tsBold.Click += new System.EventHandler(this.tsBold_Click);
            // 
            // tsItalic
            // 
            this.tsItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsItalic.Image = ((System.Drawing.Image)(resources.GetObject("tsItalic.Image")));
            this.tsItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsItalic.Name = "tsItalic";
            this.tsItalic.Size = new System.Drawing.Size(23, 22);
            this.tsItalic.Text = "Itálico";
            this.tsItalic.ToolTipText = "Itálico";
            this.tsItalic.Click += new System.EventHandler(this.tsItalic_Click);
            // 
            // tsUnderline
            // 
            this.tsUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tsUnderline.Image")));
            this.tsUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUnderline.Name = "tsUnderline";
            this.tsUnderline.Size = new System.Drawing.Size(23, 22);
            this.tsUnderline.Text = "Sublinhado";
            this.tsUnderline.ToolTipText = "Sublinhado";
            this.tsUnderline.Click += new System.EventHandler(this.tsUnderline_Click);
            // 
            // tsSeparator3
            // 
            this.tsSeparator3.Name = "tsSeparator3";
            this.tsSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsAlignLeft
            // 
            this.tsAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsAlignLeft.Image")));
            this.tsAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAlignLeft.Name = "tsAlignLeft";
            this.tsAlignLeft.Size = new System.Drawing.Size(23, 22);
            this.tsAlignLeft.ToolTipText = "Alinhar à Esquerda";
            this.tsAlignLeft.Click += new System.EventHandler(this.tsAlignLeft_Click);
            // 
            // tsAlignCenter
            // 
            this.tsAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("tsAlignCenter.Image")));
            this.tsAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAlignCenter.Name = "tsAlignCenter";
            this.tsAlignCenter.Size = new System.Drawing.Size(23, 22);
            this.tsAlignCenter.Text = "Alinhar ao Centro";
            this.tsAlignCenter.ToolTipText = "Alinhar ao Centro";
            this.tsAlignCenter.Click += new System.EventHandler(this.tsAlignCenter_Click);
            // 
            // tsAlignRight
            // 
            this.tsAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("tsAlignRight.Image")));
            this.tsAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAlignRight.Name = "tsAlignRight";
            this.tsAlignRight.Size = new System.Drawing.Size(23, 22);
            this.tsAlignRight.Text = "Alinhar à Direita";
            this.tsAlignRight.ToolTipText = "Alinhar à Direita";
            this.tsAlignRight.Click += new System.EventHandler(this.tsAlignRight_Click);
            // 
            // dlgFont
            // 
            this.dlgFont.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlgFont.ShowColor = true;
            // 
            // RichTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.rtb);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RichTextBox";
            this.Size = new System.Drawing.Size(620, 197);
            this.Load += new System.EventHandler(this.RichTextBox_Load);
            this.Enter += new System.EventHandler(this.RichTextBox_Enter);
            this.Resize += new System.EventHandler(this.RichTextBox_Resize);
            this.ctxMenu.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton tsFontColor;
        private System.Windows.Forms.ToolStripButton tsFontBackColor;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripButton tsFont;
        private System.Windows.Forms.ToolStripComboBox tsFontName;
        private System.Windows.Forms.ToolStripComboBox tsFontSize;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.ToolStripButton tsBold;
        private System.Windows.Forms.ToolStripButton tsItalic;
        private System.Windows.Forms.ToolStripButton tsUnderline;
        private System.Windows.Forms.ToolStripSeparator tsSeparator3;
        private System.Windows.Forms.ToolStripButton tsAlignLeft;
        private System.Windows.Forms.ToolStripButton tsAlignCenter;
        private System.Windows.Forms.ToolStripButton tsAlignRight;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmFont;
        private System.Windows.Forms.ToolStripMenuItem tsmAlign;
        private System.Windows.Forms.ToolStripMenuItem tsmSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmCut;
        private System.Windows.Forms.ToolStripMenuItem tsmPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmUndo;
        private System.Windows.Forms.ToolStripMenuItem tsmRedo;
        private System.Windows.Forms.ToolStripMenuItem tsmBold;
        private System.Windows.Forms.ToolStripMenuItem tsmItalic;
        private System.Windows.Forms.ToolStripMenuItem tsmUnderline;
        private System.Windows.Forms.ToolStripMenuItem tsmConfigureFont;
        private System.Windows.Forms.ToolStripMenuItem tsmLeft;
        private System.Windows.Forms.ToolStripMenuItem tsmCenter;
        private System.Windows.Forms.ToolStripMenuItem tsmRight;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.ColorDialog dlgColor;
        internal System.Windows.Forms.ToolStrip toolStrip;
        internal System.Windows.Forms.RichTextBox rtb;
    }
}
