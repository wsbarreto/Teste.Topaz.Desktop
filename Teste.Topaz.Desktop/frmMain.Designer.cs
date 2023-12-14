namespace Teste.Topaz.Desktop
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialContextMenuStrip1 = new ControlSkin.Controls.MaterialContextMenuStrip();
            novoToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            panelMenu = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            materialContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            materialContextMenuStrip1.BackColor = Color.FromArgb(255, 255, 255);
            materialContextMenuStrip1.Depth = 0;
            materialContextMenuStrip1.Items.AddRange(new ToolStripItem[] { novoToolStripMenuItem, consultarToolStripMenuItem });
            materialContextMenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            materialContextMenuStrip1.MouseState = ControlSkin.MouseState.HOVER;
            materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            materialContextMenuStrip1.ShowCheckMargin = true;
            materialContextMenuStrip1.ShowImageMargin = false;
            materialContextMenuStrip1.Size = new Size(124, 48);
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(123, 22);
            novoToolStripMenuItem.Text = "novo";
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(123, 22);
            consultarToolStripMenuItem.Text = "consultar";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(55, 71, 79);
            panelMenu.Location = new Point(0, 62);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 388);
            panelMenu.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(55, 71, 79);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(68, 30);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(18, 26);
            iconButton1.TabIndex = 0;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(iconButton1);
            Controls.Add(panelMenu);
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Disc";
            materialContextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ControlSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}