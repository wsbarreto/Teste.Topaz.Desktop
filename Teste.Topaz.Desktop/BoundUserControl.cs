using AutoMapper;
using Teste.Topaz.Desktop.Domain.Interface.Service;
using Teste.Topaz.Desktop.DTO;
using Teste.Topaz.Desktop.View;

namespace Teste.Topaz.Desktop;

public class BoundUserControl
{
    private readonly ICompactDiscService _discService;
    private readonly IGeneroService _generoService;
    private readonly IFaixaService _faixaService;
    private readonly IMapper _mapper;
    private readonly Panel _panelContainer;
    private frmHomeMusica _frmHomeMusica;
    private frmDetalhesDisco _frmDetalhesDisco;
    private frmNovoDisco _frmNovoDisco;
    private UserControl objForm;
    private Label _lblSubTitulo;

    public BoundUserControl(ICompactDiscService discService, IGeneroService generoService, IFaixaService faixaService, IMapper mapper, Panel panelContainer, ref Label subTitulo)
    {
        this._discService = discService;
        this._generoService = generoService;
        this._faixaService = faixaService;
        this._mapper = mapper;

        this._panelContainer = panelContainer;
        this._lblSubTitulo = subTitulo;
    }

    public void CarregaUserControl(Type nameObj, List<DiscoDTO> listaDicoDto = null)
    {
        if (nameObj.Name is "frmHomeMusica")
            objForm = new frmHomeMusica(_discService, _faixaService, _generoService, _mapper, this, ref this._lblSubTitulo);
        if (nameObj.Name is "frmDetalhesDisco")
            objForm = new frmDetalhesDisco(listaDicoDto, this, ref this._lblSubTitulo);
        if (nameObj.Name is "frmNovoDisco")
            objForm = new frmNovoDisco(_discService, _faixaService, _generoService, _mapper, ref this._lblSubTitulo);

        this.objForm.Dock = DockStyle.Fill;
        this._panelContainer.Controls.Clear();
        this._panelContainer.Controls.Add(this.objForm);
    }

    public void DestroiInstancia(Type nameObj)
    {
        this._panelContainer.Controls[nameObj.Name].Dispose();
    }
}
