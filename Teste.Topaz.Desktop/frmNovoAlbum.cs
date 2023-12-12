using AutoMapper;
using Teste.Topaz.Desktop.Domain.Entity;
using Teste.Topaz.Desktop.Domain.Interface.Service;
using Teste.Topaz.Desktop.DTO;

namespace Teste.Topaz.Desktop;

public partial class frmNovoAlbum : Form
{
    private readonly ICompactDiscService _discService;
    private readonly IGeneroService _generoService;
    private readonly IFaixaService _faixaService;
    private readonly IMapper _mapper;
    private readonly List<FaixaDTO> listaFaixa;
    private readonly List<CompactDiscDTO> listaDiscoDTO;
    private GeneroDTO Genero;

    public frmNovoAlbum(ICompactDiscService discService, IFaixaService faixaService, IGeneroService generoService, IMapper mapper)
    {
        InitializeComponent();

        this._discService = discService ?? throw new ArgumentNullException(nameof(ICompactDiscService));
        this._generoService = generoService ?? throw new ArgumentNullException(nameof(IGeneroService));
        this._faixaService = faixaService ?? throw new ArgumentNullException(nameof(IFaixaService));
        this._mapper = mapper ?? throw new ArgumentNullException(nameof(IMapper));

        this.listaFaixa = new List<FaixaDTO>();
        this.listaDiscoDTO = new List<CompactDiscDTO>();
    }

    private void frmNovoAlbum_Load(object sender, EventArgs e)
    {
        CarregaGenero();
    }

    private async Task CarregaGenero()
    {
        try
        {
            var listaGenerosEntity = await this._generoService.GetAllAsync();
            var listaGenerosDto = GeneroDTO.ConvertListEntityToListDto(_mapper, listaGenerosEntity.ToList());

            cboGenero.DataSource = listaGenerosDto;
            cboGenero.DisplayMember = "NOME";
            cboGenero.ValueMember = "ID";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw ex;
        }
    }

    private void btnAddFaixa_Click(object sender, EventArgs e)
    {
        Genero = cboGenero.SelectedItem as GeneroDTO;

        AlteraGenero();
        AlteraTituloAlbum();

        var faixa = new FaixaDTO { ARTISTA = txtArtista.Text, DURACAO = decimal.Parse(txtDuracao.Text), TITULO = txtTituloMusica.Text };
        this.listaFaixa.Add(faixa);

        this.listaDiscoDTO.Add(new CompactDiscDTO { TB_FAIXA_ID = faixa.ID, TB_GENERO_ID = Genero.ID, TITULO = txtTituloAlbum.Text });

        dgvFaixas.DataSource = null;
        dgvFaixas.DataSource = listaFaixa;

        dgvFaixas.Columns["ID"].Visible = false;
        dgvFaixas.Columns["DATA_CADASTRO"].Visible = false;
        dgvFaixas.Refresh();

        LimpaCampos();
    }

    private void AlteraGenero()
    {
        listaDiscoDTO.Where(w => w.TB_GENERO_ID != Genero.ID).ToList().ForEach((item) =>
        {
            item.TB_GENERO_ID = Genero.ID;
        });
    }

    private void AlteraTituloAlbum()
    {
        listaDiscoDTO.Where(w => w.TITULO != txtTituloAlbum.Text).ToList().ForEach((item) =>
        {
            item.TITULO = txtTituloAlbum.Text;
        });
    }

    private void LimpaCampos()
    {
        txtArtista.Clear();
        txtDuracao.Clear();
        txtTituloMusica.Clear();
        txtTituloMusica.Focus();
    }

    private bool IsValid()
    {
        if (string.IsNullOrWhiteSpace(txtTituloAlbum.Text)) return false;
        if (cboGenero.SelectedIndex < 0) return false;
        if (dgvFaixas.Rows.Count <= 0) return false;

        return true;
    }

    private bool IsRangeValid()
    {
        if(string.IsNullOrWhiteSpace(txtTituloMusica.Text)) return false;
        if(string.IsNullOrWhiteSpace(txtArtista.Text)) return false;
        if(string.IsNullOrWhiteSpace(txtDuracao.Text)) return false;

        return true;
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
        if (IsValid() is false)
        {
            MessageBox.Show("preencha todos os campos obrigatorios", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            var listaFaixaEntity = _mapper.Map<List<FaixaEntity>>(listaFaixa);
            var listaDiscoEntity = _mapper.Map<List<CompactDiscEntity>>(listaDiscoDTO);

            this._faixaService.InserirListAsync(listaFaixaEntity);
            this._discService.InserirListaAsync(listaDiscoEntity);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            throw ex;
        }

        MessageBox.Show("cd cadastrado com sucesso", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void txtDuracao_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyValue.Equals(13))
            btnAddFaixa_Click(sender, e);
    }
}
