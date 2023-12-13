using AutoMapper;
using Teste.Topaz.Desktop.Domain.Interface.Service;
using Teste.Topaz.Desktop.DTO;
using MetroFramework.Forms;
using MetroFramework;

namespace Teste.Topaz.Desktop
{
    public partial class frmListaAlbum : MetroForm
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

        #region Métodos de carregamento

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

                cboGenero.ConfigureComboBox(listaGenerosDto, "NOME", "ID");
            }
            catch (Exception ex)
            {
                ex.ErrorShowMessagem(this);
                throw ex;
            }
        }

        private async Task CarregaGridAsync()
        {
            var listaDiscoDTO = await _discService.GetAllDiscDapperAsync();

            var dicColumns = new Dictionary<string, bool>();
            dicColumns.Add("ID", false);
            dicColumns.Add("MUSICA", false);
            dicColumns.Add("ARTISTA", false);
            dicColumns.Add("DURACAO", false);

            dgvDiscos.ConfigureDataGridView(listaDiscoDTO, dicColumns);
        }

        private void AdicionarColuna()
        {
            dgvDiscos.AddColumnDataGridView("título álbum", "TituloAlbum", "TITULO");
            dgvDiscos.AddColumnDataGridView("gênero", "Genero", "GENERO");
            dgvDiscos.AddColumnDataGridView("cadastro", "DataCadastro", "DATA");
        }

        #endregion
    }
}