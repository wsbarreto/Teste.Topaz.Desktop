using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using Teste.Topaz.Desktop.Domain.Interface.Service;
using Teste.Topaz.Desktop.DTO;

namespace Teste.Topaz.Desktop
{
    public partial class frmListaAlbum : Form
    {
        private readonly ICompactDiscService _discService;
        private readonly IGeneroService _generoService;
        private readonly IFaixaService _faixaService;
        private readonly IMapper _mapper;

        public frmListaAlbum(ICompactDiscService discService, IGeneroService generoService, IFaixaService faixaService, IMapper mapper) : base()
        {
            InitializeComponent();
            _discService = discService;
            _generoService = generoService;
            _faixaService = faixaService;
            _mapper = mapper;
        }

        private void frmListaAlbum_Load(object sender, EventArgs e)
        {
            CarregaGridAsync();
            CarregaGeneroAsync();

            dgvDiscos.CellContentDoubleClick += DgvDiscos_CellContentDoubleClick;
        }

        private void DgvDiscos_CellContentDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            var tituloAlbum = dgvDiscos["TITULO", e.RowIndex].Value.ToString();
            var genero = dgvDiscos["GENERO", e.RowIndex].Value.ToString();

            CarregaDetalhes(tituloAlbum, genero);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmNovoAlbum(_discService, _faixaService, _generoService, _mapper).ShowDialog(this);
            frmListaAlbum_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarregaGridFiltroAsync(txtTituloAlbum.Text, txtArtista.Text, ((GeneroDTO)cboGenero.SelectedItem).NOME, txtNomeFaixa.Text);
        }

        #region M�todos de carregamento

        private async Task CarregaDetalhes(string tituloAlbum, string genero)
        {
            var listaDiscoDTO = await _discService.BuscaDiscoAsync(tituloAlbum, null, genero, null);

            new frmDetalhe(listaDiscoDTO).ShowDialog(this);
        }

        private async Task CarregaGridFiltroAsync(string? tituloAlbum, string? artista, string? genero, string? nomeFaixa)
        {
            var listaDiscoDTO = await _discService.BuscaPorFiltroAsync(tituloAlbum, artista, genero, nomeFaixa);

            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaDiscoDTO;

            dgvDiscos.Columns["ID"].Visible = false;

            dgvDiscos.Refresh();
        }

        private async Task CarregaGeneroAsync()
        {
            try
            {
                var listaGenerosEntity = await this._generoService.GetAllAsync();
                var listaGenerosDto = GeneroDTO.ConvertListEntityToListDto(_mapper, listaGenerosEntity.ToList());

                listaGenerosDto.Add(new GeneroDTO { NOME = string.Empty });

                cboGenero.DataSource = listaGenerosDto;
                cboGenero.DisplayMember = "NOME";
                cboGenero.ValueMember = "ID";

                cboGenero.SelectedIndex = cboGenero.Items.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private async Task CarregaGridAsync()
        {
            var listaDiscoDTO = await _discService.GetAllDiscDapperAsync();

            dgvDiscos.DataSource = listaDiscoDTO;
            dgvDiscos.Columns["ID"].Visible = false;
            dgvDiscos.Columns["MUSICA"].Visible = false;
            dgvDiscos.Columns["ARTISTA"].Visible = false;
            dgvDiscos.Columns["DURACAO"].Visible = false;
        }

        private void AdicionarColuna()
        {
            var colunaTitulo = new DataGridViewTextBoxColumn();
            colunaTitulo.HeaderText = "titulo album";
            colunaTitulo.Name = "TituloAlbum";
            colunaTitulo.DataPropertyName = "TITULO";

            dgvDiscos.Columns.Add(colunaTitulo);

            var colunaGenero = new DataGridViewTextBoxColumn();
            colunaGenero.HeaderText = "genero";
            colunaGenero.Name = "Genero";
            colunaGenero.DataPropertyName = "GENERO";

            dgvDiscos.Columns.Add(colunaGenero);

            var colunaData = new DataGridViewTextBoxColumn();
            colunaData.HeaderText = "cadastro";
            colunaData.Name = "DataCadastro";
            colunaData.DataPropertyName = "DATA";

            dgvDiscos.Columns.Add(colunaData);
        }

        #endregion
    }
}