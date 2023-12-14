namespace Teste.Topaz.Desktop.View
{
    partial class frmNovoDisco
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
            btnAddFaixa = new ControlSkin.RJControls.RJButton();
            label1 = new Label();
            cboGenero = new ControlSkin.RJControls.RJComboBox();
            label2 = new Label();
            txtTituloMusica = new ControlSkin.RJControls.RJTextBox();
            lblTituloAlbum = new Label();
            txtTituloAlbum = new ControlSkin.RJControls.RJTextBox();
            lblArtista = new Label();
            txtArtista = new ControlSkin.RJControls.RJTextBox();
            label3 = new Label();
            txtDuracao = new ControlSkin.RJControls.RJTextBox();
            btnSalvar = new ControlSkin.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)dgvFaixas).BeginInit();
            SuspendLayout();
            // 
            // dgvFaixas
            // 
            dgvFaixas.BorderStyle = BorderStyle.None;
            dgvFaixas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFaixas.Location = new Point(3, 168);
            dgvFaixas.Name = "dgvFaixas";
            dgvFaixas.RowTemplate.Height = 25;
            dgvFaixas.Size = new Size(616, 258);
            dgvFaixas.TabIndex = 21;
            // 
            // btnAddFaixa
            // 
            btnAddFaixa.BackColor = SystemColors.Control;
            btnAddFaixa.BackgroundColor = SystemColors.Control;
            btnAddFaixa.BorderColor = Color.PaleVioletRed;
            btnAddFaixa.BorderRadius = 0;
            btnAddFaixa.BorderSize = 0;
            btnAddFaixa.FlatAppearance.BorderSize = 0;
            btnAddFaixa.FlatStyle = FlatStyle.Flat;
            btnAddFaixa.ForeColor = Color.White;
            btnAddFaixa.Image = Properties.Resources.plus_circle1;
            btnAddFaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddFaixa.Location = new Point(593, 130);
            btnAddFaixa.Name = "btnAddFaixa";
            btnAddFaixa.Size = new Size(26, 32);
            btnAddFaixa.TabIndex = 18;
            btnAddFaixa.TextColor = Color.White;
            btnAddFaixa.UseVisualStyleBackColor = false;
            btnAddFaixa.Click += btnAddFaixa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64, 64);
            label1.Location = new Point(420, 49);
            label1.Name = "label1";
            label1.Size = new Size(60, 18);
            label1.TabIndex = 20;
            label1.Text = "gênero";
            // 
            // cboGenero
            // 
            cboGenero.BackColor = Color.WhiteSmoke;
            cboGenero.BorderColor = Color.MediumSlateBlue;
            cboGenero.BorderSize = 1;
            cboGenero.DropDownStyle = ComboBoxStyle.DropDown;
            cboGenero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboGenero.ForeColor = Color.DimGray;
            cboGenero.IconColor = Color.MediumSlateBlue;
            cboGenero.ListBackColor = Color.FromArgb(230, 228, 245);
            cboGenero.ListTextColor = Color.DimGray;
            cboGenero.Location = new Point(419, 71);
            cboGenero.MinimumSize = new Size(200, 30);
            cboGenero.Name = "cboGenero";
            cboGenero.Padding = new Padding(1);
            cboGenero.Size = new Size(200, 31);
            cboGenero.TabIndex = 14;
            cboGenero.Texts = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64, 64);
            label2.Location = new Point(5, 107);
            label2.Name = "label2";
            label2.Size = new Size(85, 18);
            label2.TabIndex = 19;
            label2.Text = "título faixa";
            // 
            // txtTituloMusica
            // 
            txtTituloMusica.BackColor = SystemColors.Window;
            txtTituloMusica.BorderColor = Color.MediumSlateBlue;
            txtTituloMusica.BorderFocusColor = Color.HotPink;
            txtTituloMusica.BorderRadius = 8;
            txtTituloMusica.BorderSize = 2;
            txtTituloMusica.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTituloMusica.ForeColor = Color.FromArgb(64, 64, 64);
            txtTituloMusica.Location = new Point(4, 130);
            txtTituloMusica.Margin = new Padding(4);
            txtTituloMusica.Multiline = false;
            txtTituloMusica.Name = "txtTituloMusica";
            txtTituloMusica.Padding = new Padding(10, 7, 10, 7);
            txtTituloMusica.PasswordChar = false;
            txtTituloMusica.PlaceholderColor = Color.DarkGray;
            txtTituloMusica.PlaceholderText = "";
            txtTituloMusica.Size = new Size(250, 31);
            txtTituloMusica.TabIndex = 17;
            txtTituloMusica.Texts = "";
            txtTituloMusica.UnderlinedStyle = false;
            // 
            // lblTituloAlbum
            // 
            lblTituloAlbum.AutoSize = true;
            lblTituloAlbum.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloAlbum.ForeColor = Color.FromArgb(64, 64, 64, 64);
            lblTituloAlbum.Location = new Point(4, 49);
            lblTituloAlbum.Name = "lblTituloAlbum";
            lblTituloAlbum.Size = new Size(95, 18);
            lblTituloAlbum.TabIndex = 15;
            lblTituloAlbum.Text = "título álbum";
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
            txtTituloAlbum.Location = new Point(4, 71);
            txtTituloAlbum.Margin = new Padding(4);
            txtTituloAlbum.Multiline = false;
            txtTituloAlbum.Name = "txtTituloAlbum";
            txtTituloAlbum.Padding = new Padding(10, 7, 10, 7);
            txtTituloAlbum.PasswordChar = false;
            txtTituloAlbum.PlaceholderColor = Color.DarkGray;
            txtTituloAlbum.PlaceholderText = "";
            txtTituloAlbum.Size = new Size(408, 31);
            txtTituloAlbum.TabIndex = 16;
            txtTituloAlbum.Texts = "";
            txtTituloAlbum.UnderlinedStyle = false;
            // 
            // lblArtista
            // 
            lblArtista.AutoSize = true;
            lblArtista.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblArtista.ForeColor = Color.FromArgb(64, 64, 64, 64);
            lblArtista.Location = new Point(262, 109);
            lblArtista.Name = "lblArtista";
            lblArtista.Size = new Size(55, 18);
            lblArtista.TabIndex = 12;
            lblArtista.Text = "artista";
            // 
            // txtArtista
            // 
            txtArtista.BackColor = SystemColors.Window;
            txtArtista.BorderColor = Color.MediumSlateBlue;
            txtArtista.BorderFocusColor = Color.HotPink;
            txtArtista.BorderRadius = 8;
            txtArtista.BorderSize = 2;
            txtArtista.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtArtista.ForeColor = Color.FromArgb(64, 64, 64);
            txtArtista.Location = new Point(262, 131);
            txtArtista.Margin = new Padding(4);
            txtArtista.Multiline = false;
            txtArtista.Name = "txtArtista";
            txtArtista.Padding = new Padding(10, 7, 10, 7);
            txtArtista.PasswordChar = false;
            txtArtista.PlaceholderColor = Color.DarkGray;
            txtArtista.PlaceholderText = "";
            txtArtista.Size = new Size(248, 31);
            txtArtista.TabIndex = 13;
            txtArtista.Texts = "";
            txtArtista.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64, 64);
            label3.Location = new Point(518, 109);
            label3.Name = "label3";
            label3.Size = new Size(68, 18);
            label3.TabIndex = 22;
            label3.Text = "duração";
            // 
            // txtDuracao
            // 
            txtDuracao.BackColor = SystemColors.Window;
            txtDuracao.BorderColor = Color.MediumSlateBlue;
            txtDuracao.BorderFocusColor = Color.HotPink;
            txtDuracao.BorderRadius = 8;
            txtDuracao.BorderSize = 2;
            txtDuracao.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtDuracao.ForeColor = Color.FromArgb(64, 64, 64);
            txtDuracao.Location = new Point(518, 131);
            txtDuracao.Margin = new Padding(4);
            txtDuracao.Multiline = false;
            txtDuracao.Name = "txtDuracao";
            txtDuracao.Padding = new Padding(10, 7, 10, 7);
            txtDuracao.PasswordChar = false;
            txtDuracao.PlaceholderColor = Color.DarkGray;
            txtDuracao.PlaceholderText = "";
            txtDuracao.Size = new Size(72, 31);
            txtDuracao.TabIndex = 23;
            txtDuracao.Texts = "";
            txtDuracao.UnderlinedStyle = false;
            txtDuracao.KeyDown += txtDuracao_KeyDown;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(25, 202, 211);
            btnSalvar.BackgroundColor = Color.FromArgb(25, 202, 211);
            btnSalvar.BorderColor = Color.PaleVioletRed;
            btnSalvar.BorderRadius = 3;
            btnSalvar.BorderSize = 0;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Image = Properties.Resources.floppy;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(5, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(72, 32);
            btnSalvar.TabIndex = 24;
            btnSalvar.Text = "  &salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleLeft;
            btnSalvar.TextColor = Color.White;
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmNovoDisco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSalvar);
            Controls.Add(label3);
            Controls.Add(txtDuracao);
            Controls.Add(dgvFaixas);
            Controls.Add(btnAddFaixa);
            Controls.Add(label1);
            Controls.Add(cboGenero);
            Controls.Add(label2);
            Controls.Add(txtTituloMusica);
            Controls.Add(lblTituloAlbum);
            Controls.Add(txtTituloAlbum);
            Controls.Add(lblArtista);
            Controls.Add(txtArtista);
            Name = "frmNovoDisco";
            Size = new Size(622, 429);
            Load += frmNovoDisco_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFaixas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFaixas;
        private ControlSkin.RJControls.RJButton btnAddFaixa;
        private Label label1;
        private ControlSkin.RJControls.RJComboBox cboGenero;
        private Label label2;
        private ControlSkin.RJControls.RJTextBox txtTituloMusica;
        private Label lblTituloAlbum;
        private ControlSkin.RJControls.RJTextBox txtTituloAlbum;
        private Label lblArtista;
        private ControlSkin.RJControls.RJTextBox txtArtista;
        private Label label3;
        private ControlSkin.RJControls.RJTextBox txtDuracao;
        private ControlSkin.RJControls.RJButton btnSalvar;
    }
}
