namespace Teste.Topaz.Desktop
{
    partial class frmDetalhe
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
            button1 = new Button();
            label4 = new Label();
            txtGenero = new TextBox();
            dgvFaixas = new DataGridView();
            label2 = new Label();
            txtTituloAlbum = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFaixas).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(12, 209);
            button1.Name = "button1";
            button1.Size = new Size(108, 23);
            button1.TabIndex = 36;
            button1.Text = "&sair";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 6);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 34;
            label4.Text = "genero";
            // 
            // txtGenero
            // 
            txtGenero.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtGenero.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            txtGenero.Location = new Point(331, 24);
            txtGenero.Name = "txtGenero";
            txtGenero.ReadOnly = true;
            txtGenero.Size = new Size(193, 23);
            txtGenero.TabIndex = 25;
            // 
            // dgvFaixas
            // 
            dgvFaixas.AllowUserToAddRows = false;
            dgvFaixas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFaixas.Location = new Point(12, 53);
            dgvFaixas.Name = "dgvFaixas";
            dgvFaixas.ReadOnly = true;
            dgvFaixas.RowTemplate.Height = 25;
            dgvFaixas.Size = new Size(512, 150);
            dgvFaixas.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 31;
            label2.Text = "titulo album";
            // 
            // txtTituloAlbum
            // 
            txtTituloAlbum.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTituloAlbum.AutoCompleteSource = AutoCompleteSource.RecentlyUsedList;
            txtTituloAlbum.Location = new Point(12, 24);
            txtTituloAlbum.Name = "txtTituloAlbum";
            txtTituloAlbum.ReadOnly = true;
            txtTituloAlbum.Size = new Size(313, 23);
            txtTituloAlbum.TabIndex = 23;
            // 
            // frmDetalhe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 238);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtGenero);
            Controls.Add(dgvFaixas);
            Controls.Add(label2);
            Controls.Add(txtTituloAlbum);
            Name = "frmDetalhe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDetalhe";
            Load += frmDetalhe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFaixas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label4;
        private TextBox txtGenero;
        private DataGridView dgvFaixas;
        private Label label2;
        private TextBox txtTituloAlbum;
    }
}