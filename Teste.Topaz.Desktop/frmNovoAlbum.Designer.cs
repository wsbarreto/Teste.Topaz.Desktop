namespace Teste.Topaz.Desktop
{
    partial class frmNovoAlbum
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
            btnAddFaixa = new Button();
            label3 = new Label();
            cboGenero = new ComboBox();
            label2 = new Label();
            txtTituloAlbum = new TextBox();
            label1 = new Label();
            txtArtista = new TextBox();
            dgvFaixas = new DataGridView();
            label4 = new Label();
            txtTituloMusica = new TextBox();
            label5 = new Label();
            txtDuracao = new TextBox();
            btnSalvar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFaixas).BeginInit();
            SuspendLayout();
            // 
            // btnAddFaixa
            // 
            btnAddFaixa.BackColor = Color.LightGreen;
            btnAddFaixa.Location = new Point(488, 73);
            btnAddFaixa.Name = "btnAddFaixa";
            btnAddFaixa.Size = new Size(30, 23);
            btnAddFaixa.TabIndex = 6;
            btnAddFaixa.Text = "&+";
            btnAddFaixa.UseVisualStyleBackColor = false;
            btnAddFaixa.Click += btnAddFaixa_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 11);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 15;
            label3.Text = "genero";
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(331, 29);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(185, 23);
            cboGenero.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 13;
            label2.Text = "titulo album";
            // 
            // txtTituloAlbum
            // 
            txtTituloAlbum.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTituloAlbum.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            txtTituloAlbum.Location = new Point(12, 29);
            txtTituloAlbum.Name = "txtTituloAlbum";
            txtTituloAlbum.Size = new Size(313, 23);
            txtTituloAlbum.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 55);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 11;
            label1.Text = "artista";
            // 
            // txtArtista
            // 
            txtArtista.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtArtista.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            txtArtista.Location = new Point(211, 73);
            txtArtista.Name = "txtArtista";
            txtArtista.Size = new Size(193, 23);
            txtArtista.TabIndex = 4;
            // 
            // dgvFaixas
            // 
            dgvFaixas.AllowUserToAddRows = false;
            dgvFaixas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFaixas.Location = new Point(12, 102);
            dgvFaixas.Name = "dgvFaixas";
            dgvFaixas.RowTemplate.Height = 25;
            dgvFaixas.Size = new Size(506, 150);
            dgvFaixas.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 55);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 19;
            label4.Text = "titulo musica";
            // 
            // txtTituloMusica
            // 
            txtTituloMusica.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTituloMusica.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            txtTituloMusica.Location = new Point(12, 73);
            txtTituloMusica.Name = "txtTituloMusica";
            txtTituloMusica.Size = new Size(193, 23);
            txtTituloMusica.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 55);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 21;
            label5.Text = "duracao";
            // 
            // txtDuracao
            // 
            txtDuracao.Location = new Point(410, 73);
            txtDuracao.Name = "txtDuracao";
            txtDuracao.Size = new Size(72, 23);
            txtDuracao.TabIndex = 5;
            txtDuracao.KeyDown += txtDuracao_KeyDown;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.LightGreen;
            btnSalvar.Location = new Point(410, 258);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(108, 23);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "&salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(12, 258);
            button1.Name = "button1";
            button1.Size = new Size(108, 23);
            button1.TabIndex = 22;
            button1.Text = "&sair";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmNovoAlbum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 288);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(label5);
            Controls.Add(txtDuracao);
            Controls.Add(label4);
            Controls.Add(txtTituloMusica);
            Controls.Add(dgvFaixas);
            Controls.Add(btnAddFaixa);
            Controls.Add(label3);
            Controls.Add(cboGenero);
            Controls.Add(label2);
            Controls.Add(txtTituloAlbum);
            Controls.Add(label1);
            Controls.Add(txtArtista);
            MaximizeBox = false;
            Name = "frmNovoAlbum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Album";
            Load += frmNovoAlbum_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFaixas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddFaixa;
        private Label label3;
        private ComboBox cboGenero;
        private Label label2;
        private TextBox txtTituloAlbum;
        private Label label1;
        private TextBox txtArtista;
        private DataGridView dgvFaixas;
        private Label label4;
        private TextBox txtTituloMusica;
        private Label label5;
        private TextBox txtDuracao;
        private Button btnSalvar;
        private Button button1;
    }
}