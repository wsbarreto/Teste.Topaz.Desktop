using Teste.Topaz.Desktop.DTO;

namespace Teste.Topaz.Desktop;

public partial class frmDetalhe : Form
{
    private readonly List<DiscoDTO> _listaDicoDto;

    public frmDetalhe(List<DiscoDTO> listaDicoDto)
    {
        InitializeComponent();
        this._listaDicoDto = listaDicoDto;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void frmDetalhe_Load(object sender, EventArgs e)
    {
        var listaFaixaDTO = new List<FaixaDTO>();

        foreach (var item in _listaDicoDto)
        {
            listaFaixaDTO.Add(new FaixaDTO { ARTISTA = item.ARTISTA, DURACAO = decimal.Parse(item.DURACAO), TITULO = item.MUSICA });
        }

        dgvFaixas.DataSource = listaFaixaDTO;
        dgvFaixas.Columns["ID"].Visible = false;
        dgvFaixas.Columns["DATA_CADASTRO"].Visible = false;

        dgvFaixas.Columns["ARTISTA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        dgvFaixas.Columns["DURACAO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        dgvFaixas.Columns["TITULO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        txtTituloAlbum.Text = _listaDicoDto.First().TITULO;
        txtGenero.Text = _listaDicoDto.First().GENERO;
    }
}
