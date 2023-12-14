namespace Teste.Topaz.Desktop
{
    partial class frmListaAlbum
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDiscos = new DataGridView();
            txtArtista = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtTituloAlbum = new TextBox();
            cboGenero = new ComboBox();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            txtNomeFaixa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDiscos).BeginInit();
            SuspendLayout();
            // 
            // dgvDiscos
            // 
            dgvDiscos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiscos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiscos.Location = new Point(12, 136);
            dgvDiscos.Name = "dgvDiscos";
            dgvDiscos.RowTemplate.Height = 25;
            dgvDiscos.Size = new Size(516, 258);
            dgvDiscos.TabIndex = 0;
            // 
            // txtArtista
            // 
            txtArtista.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtArtista.Location = new Point(12, 63);
            txtArtista.Name = "txtArtista";
            txtArtista.PlaceholderText = "digite o nome do artista";
            txtArtista.Size = new Size(317, 23);
            txtArtista.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Image = Properties.Resources.plus_circle;
            button1.Location = new Point(12, 11);
            button1.Name = "button1";
            button1.Size = new Size(39, 31);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "artista";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 5;
            label2.Text = "título álbum";
            // 
            // txtTituloAlbum
            // 
            txtTituloAlbum.Location = new Point(12, 106);
            txtTituloAlbum.Name = "txtTituloAlbum";
            txtTituloAlbum.PlaceholderText = "digite o título do album";
            txtTituloAlbum.Size = new Size(253, 23);
            txtTituloAlbum.TabIndex = 4;
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(335, 63);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(193, 23);
            cboGenero.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Location = new Point(335, 45);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "gênero";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Image = Properties.Resources.search;
            button2.Location = new Point(482, 106);
            button2.Name = "button2";
            button2.Size = new Size(46, 23);
            button2.TabIndex = 8;
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Location = new Point(271, 89);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 10;
            label4.Text = "título faixa";
            // 
            // txtNomeFaixa
            // 
            txtNomeFaixa.Location = new Point(271, 107);
            txtNomeFaixa.Name = "txtNomeFaixa";
            txtNomeFaixa.PlaceholderText = "digite o título da faixa";
            txtNomeFaixa.Size = new Size(205, 23);
            txtNomeFaixa.TabIndex = 9;
            // 
            // frmListaAlbum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 255);
            ClientSize = new Size(540, 408);
            Controls.Add(label4);
            Controls.Add(txtNomeFaixa);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(cboGenero);
            Controls.Add(label2);
            Controls.Add(txtTituloAlbum);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtArtista);
            Controls.Add(dgvDiscos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListaAlbum";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "lista de discos";
            Load += frmListaAlbum_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiscos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDiscos;
        private TextBox txtArtista;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtTituloAlbum;
        private ComboBox cboGenero;
        private Label label3;
        private Button button2;
        private Label label4;
        private TextBox txtNomeFaixa;
    }
}