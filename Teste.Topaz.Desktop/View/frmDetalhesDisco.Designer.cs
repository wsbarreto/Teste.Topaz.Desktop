namespace Teste.Topaz.Desktop.View
{
    partial class frmDetalhesDisco
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dgvFaixas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtTituloAlbum = new ControlSkin.RJControls.RJTextBox();
            txtGenero = new ControlSkin.RJControls.RJTextBox();
            btnVoltar = new ControlSkin.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)dgvFaixas).BeginInit();
            SuspendLayout();
            // 
            // dgvFaixas
            // 
            dgvFaixas.AllowUserToAddRows = false;
            dgvFaixas.AllowUserToDeleteRows = false;
            dgvFaixas.BorderStyle = BorderStyle.None;
            dgvFaixas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFaixas.Location = new Point(3, 111);
            dgvFaixas.Name = "dgvFaixas";
            dgvFaixas.ReadOnly = true;
            dgvFaixas.RowTemplate.Height = 25;
            dgvFaixas.Size = new Size(557, 258);
            dgvFaixas.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64, 64);
            label1.Location = new Point(361, 51);
            label1.Name = "label1";
            label1.Size = new Size(60, 18);
            label1.TabIndex = 25;
            label1.Text = "gênero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64, 64);
            label2.Location = new Point(5, 50);
            label2.Name = "label2";
            label2.Size = new Size(85, 18);
            label2.TabIndex = 24;
            label2.Text = "título faixa";
            // 
            // txtTituloAlbum
            // 
            txtTituloAlbum.BackColor = SystemColors.Window;
            txtTituloAlbum.BorderColor = Color.MediumSlateBlue;
            txtTituloAlbum.BorderFocusColor = Color.HotPink;
            txtTituloAlbum.BorderRadius = 8;
            txtTituloAlbum.BorderSize = 2;
            txtTituloAlbum.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTituloAlbum.ForeColor = Color.FromArgb(64, 64, 64);
            txtTituloAlbum.Location = new Point(4, 73);
            txtTituloAlbum.Margin = new Padding(4);
            txtTituloAlbum.Multiline = false;
            txtTituloAlbum.Name = "txtTituloAlbum";
            txtTituloAlbum.Padding = new Padding(10, 7, 10, 7);
            txtTituloAlbum.PasswordChar = false;
            txtTituloAlbum.PlaceholderColor = Color.DarkGray;
            txtTituloAlbum.PlaceholderText = "";
            txtTituloAlbum.Size = new Size(349, 31);
            txtTituloAlbum.TabIndex = 23;
            txtTituloAlbum.Texts = "";
            txtTituloAlbum.UnderlinedStyle = false;
            // 
            // txtGenero
            // 
            txtGenero.BackColor = SystemColors.Window;
            txtGenero.BorderColor = Color.MediumSlateBlue;
            txtGenero.BorderFocusColor = Color.HotPink;
            txtGenero.BorderRadius = 8;
            txtGenero.BorderSize = 2;
            txtGenero.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtGenero.ForeColor = Color.FromArgb(64, 64, 64);
            txtGenero.Location = new Point(361, 73);
            txtGenero.Margin = new Padding(4);
            txtGenero.Multiline = false;
            txtGenero.Name = "txtGenero";
            txtGenero.Padding = new Padding(10, 7, 10, 7);
            txtGenero.PasswordChar = false;
            txtGenero.PlaceholderColor = Color.DarkGray;
            txtGenero.PlaceholderText = "";
            txtGenero.Size = new Size(199, 31);
            txtGenero.TabIndex = 27;
            txtGenero.Texts = "";
            txtGenero.UnderlinedStyle = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.MediumSlateBlue;
            btnVoltar.BackgroundColor = Color.MediumSlateBlue;
            btnVoltar.BorderColor = Color.PaleVioletRed;
            btnVoltar.BorderRadius = 3;
            btnVoltar.BorderSize = 0;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Image = Properties.Resources.box_arrow_left;
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(5, 3);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(72, 32);
            btnVoltar.TabIndex = 28;
            btnVoltar.Text = "   &voltar";
            btnVoltar.TextAlign = ContentAlignment.MiddleLeft;
            btnVoltar.TextColor = Color.White;
            btnVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmDetalhesDisco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnVoltar);
            Controls.Add(txtGenero);
            Controls.Add(dgvFaixas);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtTituloAlbum);
            Name = "frmDetalhesDisco";
            Size = new Size(563, 372);
            Load += frmDetalhesDisco_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFaixas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFaixas;
        private Label label1;
        private Label label2;
        private ControlSkin.RJControls.RJTextBox txtTituloAlbum;
        private ControlSkin.RJControls.RJTextBox txtGenero;
        private ControlSkin.RJControls.RJButton btnVoltar;
    }
}
