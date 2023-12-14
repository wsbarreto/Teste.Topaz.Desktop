using MetroFramework;
using Teste.Topaz.Desktop.ControlSkin.RJControls;

namespace Teste.Topaz.Desktop;

public static class ExtensionMethod
{
    #region Objetos

    #region DataGridView
    public static void ConfigureDataGridView<T>(this DataGridView dataGridView, List<T> listSource, IDictionary<string, bool> columnVisible)
    {
        dataGridView.DataSource = null;
        dataGridView.DataSource = listSource;
        
        foreach (var item in columnVisible)
        {
            dataGridView.Columns[item.Key].Visible = item.Value;
        }
        
        dataGridView.Refresh();
    }

    public static void AddColumnDataGridView(this DataGridView dataGridView, string headerText, string name, string dataPropertyName)
    {
        var colunaTitulo = new DataGridViewTextBoxColumn();
        colunaTitulo.HeaderText = headerText;
        colunaTitulo.Name = name;
        colunaTitulo.DataPropertyName = dataPropertyName;

        dataGridView.Columns.Add(colunaTitulo);
    }

    public static void SharedStyleConfigurationDataGridView(this DataGridView dataGridView)
    {
        var font = new Font("Verdana", 9, FontStyle.Regular);
        var foreColor = Color.MediumSlateBlue;
        var backgroundColor = Color.FromArgb(245, 245, 255); ;

        var headerStyle = new DataGridViewColumnHeaderCell();
        headerStyle.Style.Font = font;
        headerStyle.Style.ForeColor = foreColor;
        headerStyle.Style.BackColor = Color.Black;

        var style = new DataGridViewCellStyle();
        style.Font = font;
        style.ForeColor = foreColor;
        style.BackColor = backgroundColor;

        dataGridView.BorderStyle = BorderStyle.None;
        dataGridView.BackgroundColor = backgroundColor;
        dataGridView.DefaultCellStyle = style;
    }

    public static void ConfigureWBDataGridView<T>(this WBDataGridView dataGridView, List<T> listSource, IDictionary<string, bool> columnVisible)
    {
        dataGridView.DataSource = null;
        dataGridView.DataSource = listSource;

        foreach (var item in columnVisible)
        {
            dataGridView.Columns[item.Key].Visible = item.Value;
        }

        dataGridView.Refresh();
    }

    public static void AddColumnWBDataGridView(this WBDataGridView dataGridView, string headerText, string name, string dataPropertyName)
    {
        var colunaTitulo = new DataGridViewTextBoxColumn();
        colunaTitulo.HeaderText = headerText;
        colunaTitulo.Name = name;
        colunaTitulo.DataPropertyName = dataPropertyName;

        dataGridView.Columns.Add(colunaTitulo);
    }
    #endregion

    #region ComboBox
    public static void ConfigureComboBox<T>(this ComboBox combo, List<T> listSource, string displayMember, string valueMember)
    {
        combo.DataSource = listSource;
        combo.DisplayMember = displayMember;
        combo.ValueMember = valueMember;

        combo.SelectedIndex = combo.Items.Count - 1;
    }

    public static void ConfigureRJComboBox<T>(this RJComboBox combo, List<T> listSource, string displayMember, string valueMember)
    {
        combo.DataSource = listSource;
        combo.DisplayMember = displayMember;
        combo.ValueMember = valueMember;

        combo.SelectedIndex = combo.Items.Count - 1;
    }

    #endregion

    #endregion

    public static void ErrorShowMessagem(this Exception ex, IWin32Window form)
    {
        var messagem = $"message: {ex.Message}\n" +
            $"inner exception: {ex.InnerException}\n" +
            $"inner exception messagem: {ex.InnerException?.Message}";

        MetroMessageBox.Show(form, messagem, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
