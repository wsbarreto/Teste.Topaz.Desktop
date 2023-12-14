using AutoMapper;
using MaterialSkin.Controls;
using Teste.Topaz.Desktop.ControlSkin;
using Teste.Topaz.Desktop.Domain.Interface.Service;

namespace Teste.Topaz.Desktop;

public partial class frmMain : MaterialForm
{
    private readonly ICompactDiscService _discService;
    private readonly IGeneroService _generoService;
    private readonly IFaixaService _faixaService;
    private readonly IMapper _mapper;

    private readonly MaterialSkinManager materialSkinManager;
    private readonly ColorScheme colorSchema;

    private Button btnDropDown;
    private ContextMenuStrip contextMenu;

    public frmMain(ICompactDiscService discService, IGeneroService generoService, IFaixaService faixaService, IMapper mapper)
    {
        InitializeComponent();

        _discService = discService;
        _generoService = generoService;
        _faixaService = faixaService;
        _mapper = mapper;

        colorSchema = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        materialSkinManager.ColorScheme = colorSchema;

        panelMenu.BackColor = colorSchema.PrimaryColor;
    }

    private void menuItemCadastrar_Click(object sender, EventArgs e)
    {
        new frmNovoAlbum(_discService, _faixaService, _generoService, _mapper).ShowDialog(this);
    }

    private void menuItemConsultar_Click(object sender, EventArgs e)
    {
        new frmListaAlbum(_discService, _faixaService, _generoService, _mapper).ShowDialog(this);
    }

}