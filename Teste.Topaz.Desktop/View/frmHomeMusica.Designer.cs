namespace Teste.Topaz.Desktop.View
{
    partial class frmHomeMusica
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
            txtArtista = new ControlSkin.RJControls.RJTextBox();
            lblArtista = new Label();
            lblTituloAlbum = new Label();
            txtTituloAlbum = new ControlSkin.RJControls.RJTextBox();
            label2 = new Label();
            txtNomeFaixa = new ControlSkin.RJControls.RJTextBox();
            cboGenero = new ControlSkin.RJControls.RJComboBox();
            label1 = new Label();
            btnPesquisa = new ControlSkin.RJControls.RJButton();
            dgvDiscos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDiscos).BeginInit();
            SuspendLayout();
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
            txtArtista.Location = new Point(3, 25);
            txtArtista.Margin = new Padding(4);
            txtArtista.Multiline = false;
            txtArtista.Name = "txtArtista";
            txtArtista.Padding = new Padding(10, 7, 10, 7);
            txtArtista.PasswordChar = false;
            txtArtista.PlaceholderColor = Color.DarkGray;
            txtArtista.PlaceholderText = "";
            txtArtista.Size = new Size(333, 31);
            txtArtista.TabIndex = 1;
            txtArtista.Texts = "";
            txtArtista.UnderlinedStyle = false;
            // 
            // lblArtista
            // 
            lblArtista.AutoSize = true;
            lblArtista.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblArtista.ForeColor = Color.FromArgb(64, 64, 64, 64);
            lblArtista.Location = new Point(3, 3);
            lblArtista.Name = "lblArtista";
            lblArtista.Size = new Size(55, 18);
            lblArtista.TabIndex = 1;
            lblArtista.Text = "artista";
            // 
            // lblTituloAlbum
            // 
            lblTituloAlbum.AutoSize = true;
            lblTituloAlbum.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloAlbum.ForeColor = Color.FromArgb(64, 64, 64, 64);
            lblTituloAlbum.Location = new Point(3, 62);
            lblTituloAlbum.Name = "lblTituloAlbum";
            lblTituloAlbum.Size = new Size(95, 18);
            lblTituloAlbum.TabIndex = 3;
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
            txtTituloAlbum.Location = new Point(3, 84);
            txtTituloAlbum.Margin = new Padding(4);
            txtTituloAlbum.Multiline = false;
            txtTituloAlbum.Name = "txtTituloAlbum";
            txtTituloAlbum.Padding = new Padding(10, 7, 10, 7);
            txtTituloAlbum.PasswordChar = false;
            txtTituloAlbum.PlaceholderColor = Color.DarkGray;
            txtTituloAlbum.PlaceholderText = "";
            txtTituloAlbum.Size = new Size(250, 31);
            txtTituloAlbum.TabIndex = 3;
            txtTituloAlbum.Texts = "";
            txtTituloAlbum.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64, 64);
            label2.Location = new Point(261, 62);
            label2.Name = "label2";
            label2.Size = new Size(85, 18);
            label2.TabIndex = 5;
            label2.Text = "título faixa";
            // 
            // txtNomeFaixa
            // 
            txtNomeFaixa.BackColor = SystemColors.Window;
            txtNomeFaixa.BorderColor = Color.MediumSlateBlue;
            txtNomeFaixa.BorderFocusColor = Color.HotPink;
            txtNomeFaixa.BorderRadius = 8;
            txtNomeFaixa.BorderSize = 2;
            txtNomeFaixa.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeFaixa.ForeColor = Color.FromArgb(64, 64, 64);
            txtNomeFaixa.Location = new Point(260, 84);
            txtNomeFaixa.Margin = new Padding(4);
            txtNomeFaixa.Multiline = false;
            txtNomeFaixa.Name = "txtNomeFaixa";
            txtNomeFaixa.Padding = new Padding(10, 7, 10, 7);
            txtNomeFaixa.PasswordChar = false;
            txtNomeFaixa.PlaceholderColor = Color.DarkGray;
            txtNomeFaixa.PlaceholderText = "";
            txtNomeFaixa.Size = new Size(250, 31);
            txtNomeFaixa.TabIndex = 4;
            txtNomeFaixa.Texts = "";
            txtNomeFaixa.UnderlinedStyle = false;
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
            cboGenero.Location = new Point(343, 25);
            cboGenero.MinimumSize = new Size(200, 30);
            cboGenero.Name = "cboGenero";
            cboGenero.Padding = new Padding(1);
            cboGenero.Size = new Size(200, 31);
            cboGenero.TabIndex = 2;
            cboGenero.Texts = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64, 64);
            label1.Location = new Point(344, 3);
            label1.Name = "label1";
            label1.Size = new Size(60, 18);
            label1.TabIndex = 7;
            label1.Text = "gênero";
            // 
            // btnPesquisa
            // 
            btnPesquisa.BackColor = Color.MediumSlateBlue;
            btnPesquisa.BackgroundColor = Color.MediumSlateBlue;
            btnPesquisa.BorderColor = Color.PaleVioletRed;
            btnPesquisa.BorderRadius = 3;
            btnPesquisa.BorderSize = 0;
            btnPesquisa.FlatAppearance.BorderSize = 0;
            btnPesquisa.FlatStyle = FlatStyle.Flat;
            btnPesquisa.ForeColor = Color.White;
            btnPesquisa.Image = Properties.Resources.search;
            btnPesquisa.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisa.Location = new Point(517, 84);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(26, 32);
            btnPesquisa.TabIndex = 5;
            btnPesquisa.TextColor = Color.White;
            btnPesquisa.UseVisualStyleBackColor = false;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // dgvDiscos
            // 
            dgvDiscos.BackgroundColor = SystemColors.Control;
            dgvDiscos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiscos.Location = new Point(3, 122);
            dgvDiscos.Name = "dgvDiscos";
            dgvDiscos.RowTemplate.Height = 25;
            dgvDiscos.Size = new Size(540, 258);
            dgvDiscos.TabIndex = 11;
            // 
            // frmHomeMusica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvDiscos);
            Controls.Add(btnPesquisa);
            Controls.Add(label1);
            Controls.Add(cboGenero);
            Controls.Add(label2);
            Controls.Add(txtNomeFaixa);
            Controls.Add(lblTituloAlbum);
            Controls.Add(txtTituloAlbum);
            Controls.Add(lblArtista);
            Controls.Add(txtArtista);
            Name = "frmHomeMusica";
            Size = new Size(546, 383);
            Load += frmHomeMusica_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiscos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ControlSkin.RJControls.RJTextBox txtArtista;
        private Label lblArtista;
        private Label lblTituloAlbum;
        private ControlSkin.RJControls.RJTextBox txtTituloAlbum;
        private Label label2;
        private ControlSkin.RJControls.RJTextBox txtNomeFaixa;
        private ControlSkin.RJControls.RJComboBox cboGenero;
        private Label label1;
        private ControlSkin.RJControls.RJButton btnPesquisa;
        private DataGridView dgvDiscos;
    }
}
