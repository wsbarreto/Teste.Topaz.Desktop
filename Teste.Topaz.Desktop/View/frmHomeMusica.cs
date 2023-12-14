using AutoMapper;
using System.Windows.Forms;
using Teste.Topaz.Desktop.Domain.Interface.Service;
using Teste.Topaz.Desktop.DTO;

namespace Teste.Topaz.Desktop.View;

public partial class frmHomeMusica : UserControl
{
    private readonly ICompactDiscService _discService;
    private readonly IGeneroService _generoService;
    private readonly IFaixaService _faixaService;
    private readonly IMapper _mapper;
    private readonly BoundUserControl _bound;

    public readonly string TituloFormulario = "listagem de discos";

    public frmHomeMusica(ICompactDiscService discService, IFaixaService faixaService, IGeneroService generoService, IMapper mapper, BoundUserControl bound, ref Label subTitulo)
    {
        InitializeComponent();

        this._discService = discService;
        this._generoService = generoService;
        this._faixaService = faixaService;
        this._mapper = mapper;
        this._bound = bound;
        subTitulo.Text = TituloFormulario;
    }

    private void btnPesquisa_Click(object sender, EventArgs e)
    {
        CarregaGridFiltroAsync(txtTituloAlbum.Text, txtArtista.Text, ((GeneroDTO)cboGenero.SelectedItem).NOME, txtNomeFaixa.Text);
    }

    #region Métodos de carregamento

    private async Task CarregaDetalhes(string tituloAlbum, string genero)
    {
        var listaDiscoDTO = await _discService.BuscaDiscoAsync(tituloAlbum, null, genero, null);

        this._bound.CarregaUserControl(typeof(frmDetalhesDisco), listaDiscoDTO);
    }

    private async Task CarregaGridFiltroAsync(string? tituloAlbum, string? artista, string? genero, string? nomeFaixa)
    {
        var listaDiscoDTO = await _discService.BuscaPorFiltroAsync(tituloAlbum, artista, genero, nomeFaixa);

        var dicColumns = new Dictionary<string, bool>();
        dicColumns.Add("ID", false);

        dgvDiscos.ConfigureDataGridView(listaDiscoDTO, dicColumns);
    }

    private async Task CarregaGeneroAsync()
    {
        try
        {
            var listaGenerosEntity = await this._generoService.GetAllAsync();
            var listaGenerosDto = GeneroDTO.ConvertListEntityToListDto(_mapper, listaGenerosEntity.ToList());

            listaGenerosDto.Add(new GeneroDTO { NOME = string.Empty });

            cboGenero.ConfigureRJComboBox(listaGenerosDto, "NOME", "ID");
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

        dgvDiscos.Columns["TITULO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        dgvDiscos.Columns["GENERO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        dgvDiscos.Columns["DATA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
    }

    private void AdicionarColuna()
    {
        dgvDiscos.AddColumnDataGridView("título álbum", "TituloAlbum", "TITULO");
        dgvDiscos.AddColumnDataGridView("gênero", "Genero", "GENERO");
        dgvDiscos.AddColumnDataGridView("cadastro", "DataCadastro", "DATA");
    }

    #endregion

    private void frmHomeMusica_Load(object sender, EventArgs e)
    {
        CarregaGridAsync();
        CarregaGeneroAsync();

        dgvDiscos.CellContentDoubleClick += DgvDiscos_CellContentDoubleClick;
        dgvDiscos.SharedStyleConfigurationDataGridView();
    }

    private void DgvDiscos_CellContentDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        var tituloAlbum = dgvDiscos["TITULO", e.RowIndex].Value.ToString();
        var genero = dgvDiscos["GENERO", e.RowIndex].Value.ToString();

        CarregaDetalhes(tituloAlbum, genero);
    }
}
