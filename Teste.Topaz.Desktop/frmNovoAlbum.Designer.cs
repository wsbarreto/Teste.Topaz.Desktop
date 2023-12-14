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
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFaixas).BeginInit();
            SuspendLayout();
            // 
            // btnAddFaixa
            // 
            btnAddFaixa.BackColor = Color.Transparent;
            btnAddFaixa.Image = Properties.Resources.plus_circle;
            btnAddFaixa.Location = new Point(487, 121);
            btnAddFaixa.Name = "btnAddFaixa";
            btnAddFaixa.Size = new Size(30, 25);
            btnAddFaixa.TabIndex = 6;
            btnAddFaixa.UseVisualStyleBackColor = false;
            btnAddFaixa.Click += btnAddFaixa_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.System;
            label3.Location = new Point(330, 59);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 15;
            label3.Text = "gênero";
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(330, 77);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(185, 23);
            cboGenero.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.System;
            label2.Location = new Point(11, 59);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 13;
            label2.Text = "título álbum";
            // 
            // txtTituloAlbum
            // 
            txtTituloAlbum.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTituloAlbum.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            txtTituloAlbum.Location = new Point(11, 77);
            txtTituloAlbum.Name = "txtTituloAlbum";
            txtTituloAlbum.Size = new Size(313, 23);
            txtTituloAlbum.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.System;
            label1.Location = new Point(210, 103);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 11;
            label1.Text = "artista";
            // 
            // txtArtista
            // 
            txtArtista.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtArtista.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            txtArtista.Location = new Point(210, 121);
            txtArtista.Name = "txtArtista";
            txtArtista.Size = new Size(193, 23);
            txtArtista.TabIndex = 4;
            // 
            // dgvFaixas
            // 
            dgvFaixas.AllowUserToAddRows = false;
            dgvFaixas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFaixas.Location = new Point(11, 161);
            dgvFaixas.Name = "dgvFaixas";
            dgvFaixas.RowTemplate.Height = 25;
            dgvFaixas.Size = new Size(506, 150);
            dgvFaixas.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.System;
            label4.Location = new Point(11, 103);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 19;
            label4.Text = "título música";
            // 
            // txtTituloMusica
            // 
            txtTituloMusica.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTituloMusica.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            txtTituloMusica.Location = new Point(11, 121);
            txtTituloMusica.Name = "txtTituloMusica";
            txtTituloMusica.Size = new Size(193, 23);
            txtTituloMusica.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.System;
            label5.Location = new Point(409, 103);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 21;
            label5.Text = "duração";
            // 
            // txtDuracao
            // 
            txtDuracao.Location = new Point(409, 121);
            txtDuracao.Name = "txtDuracao";
            txtDuracao.Size = new Size(72, 23);
            txtDuracao.TabIndex = 5;
            txtDuracao.KeyDown += txtDuracao_KeyDown;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.LightGreen;
            btnSalvar.Image = Properties.Resources.floppy;
            btnSalvar.Location = new Point(465, 317);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(50, 37);
            btnSalvar.TabIndex = 7;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.IndianRed;
            btnVoltar.Image = Properties.Resources.box_arrow_left;
            btnVoltar.Location = new Point(409, 317);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(50, 37);
            btnVoltar.TabIndex = 22;
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += button1_Click;
            // 
            // frmNovoAlbum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 363);
            Controls.Add(btnVoltar);
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
            Text = "novo álbum";
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
        private Button btnVoltar;
    }
}