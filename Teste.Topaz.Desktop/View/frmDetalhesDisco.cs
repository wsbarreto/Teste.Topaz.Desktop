using Teste.Topaz.Desktop.DTO;

namespace Teste.Topaz.Desktop.View
{
    public partial class frmDetalhesDisco : UserControl
    {
        private readonly BoundUserControl _bound;
        private readonly List<DiscoDTO> _listaDicoDto;
        public event EventHandler FecharUserControl;
        
        public readonly string TituloFormulario = "detalhes do disco";

        public frmDetalhesDisco(List<DiscoDTO> listaDicoDto, BoundUserControl bound, ref Label subTitulo)
        {
            InitializeComponent();
            this._listaDicoDto = listaDicoDto;
            this._bound = bound;

            subTitulo.Text = TituloFormulario;
        }

        private void frmDetalhesDisco_Load(object sender, EventArgs e)
        {
            txtTituloAlbum.Enabled = false;
            txtGenero.Enabled = false;

            var listaFaixaDTO = new List<FaixaDTO>();

            foreach (var item in _listaDicoDto)
            {
                listaFaixaDTO.Add(new FaixaDTO { ARTISTA = item.ARTISTA, DURACAO = decimal.Parse(item.DURACAO), TITULO = item.MUSICA });
            }

            var dicColumns = new Dictionary<string, bool>();
            dicColumns.Add("ID", false);
            dicColumns.Add("DATA_CADASTRO", false);

            dgvFaixas.ConfigureDataGridView(listaFaixaDTO, dicColumns);

            dgvFaixas.Columns["ARTISTA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvFaixas.Columns["DURACAO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvFaixas.Columns["TITULO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvFaixas.SharedStyleConfigurationDataGridView();

            txtTituloAlbum.Text = _listaDicoDto.First().TITULO;
            txtGenero.Text = _listaDicoDto.First().GENERO;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var SubTitulo = string.Empty;
            this._bound.CarregaUserControl(typeof(frmHomeMusica));
        }
    }
}
