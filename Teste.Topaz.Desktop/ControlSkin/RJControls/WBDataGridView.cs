using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Teste.Topaz.Desktop.ControlSkin.RJControls;

public partial class WBDataGridView : DataGridView
{
    #region -> Fields
    //Fields
    private Color borderColor = Color.MediumSlateBlue;
    private Color borderFocusColor = Color.HotPink;
    private int borderSize = 2;
    private bool underlinedStyle = false;
    private bool isFocused = false;

    private int borderRadius = 0;

    #endregion

    //Events
    public event EventHandler _TextChanged;

    public WBDataGridView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        dataGridView1 = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Dock = DockStyle.Fill;
        dataGridView1.Location = new Point(0, 0);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.Size = new Size(382, 398);
        dataGridView1.TabIndex = 0;
        dataGridView1.Leave += dataGridView1_Leave;
        dataGridView1.Click += dataGridView1_Click;
        dataGridView1.MouseEnter += dataGridView1_MouseEnter;
        dataGridView1.MouseLeave += dataGridView1_MouseLeave;
        dataGridView1.KeyPress += dataGridView1_KeyPress;
        dataGridView1.DoubleClick += DataGridView1_DoubleClick;
        //dataGridView1.CellContentDoubleClick += DataGridView1_CellContentDoubleClick;
        // 
        // WBDataGridView
        // 
        //AutoScaleMode = AutoScaleMode.None;
        BackColor = SystemColors.Window;
        Controls.Add(dataGridView1);
        Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        ForeColor = Color.FromArgb(64, 64, 64);
        Name = "WBDataGridView";
        Size = new Size(382, 398);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    //private Dictionary<string, string> DataGridView1_CellContentDoubleClick(object? sender, DataGridViewCellEventArgs e)
    //{
    //    DataGridViewCellEventHandler dataGridViewCellEventHandler = null;

    //    var tituloAlbum = dataGridView1["TITULO", e.RowIndex].Value.ToString();
    //    var genero = dataGridView1["GENERO", e.RowIndex].Value.ToString();

    //    var dicResult = new Dictionary<string, string>();
    //    return dicResult.Add(tituloAlbum, genero);
    //}

    [Category("RJ Code Advance")]
    public int BorderRadius
    {
        get { return borderRadius; }
        set
        {
            if (value >= 0)
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
    }

    [Category("RJ Code Advance")]
    public override Font Font
    {
        get { return base.Font; }
        set
        {
            base.Font = value;
            dataGridView1.Font = value;
        }
    }

    private GraphicsPath GetFigurePath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        float curveSize = radius * 2F;

        path.StartFigure();
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
        path.CloseFigure();
        return path;
    }

    private void DataGridView1_DoubleClick(object? sender, EventArgs e) => this.OnDoubleClick(e);

    private DataGridView dataGridView1;

    private void dataGridView1_Leave(object sender, EventArgs e)
    {
        isFocused = false;
        this.Invalidate();
    }

    private void dataGridView1_Click(object sender, EventArgs e) => this.OnClick(e);

    private void dataGridView1_MouseEnter(object sender, EventArgs e) => this.OnMouseEnter(e);

    private void dataGridView1_MouseLeave(object sender, EventArgs e) => this.OnMouseLeave(e);

    private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e) => this.OnKeyPress(e);

    #region -> Overridden methods
    protected override void OnResize(EventArgs e) => base.OnResize(e);

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics graph = e.Graphics;

        if (borderRadius > 1)//Rounded TextBox
        {
            //-Fields
            var rectBorderSmooth = this.ClientRectangle;
            var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
            int smoothSize = borderSize > 0 ? borderSize : 1;

            using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
            using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                //-Drawing
                this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                if (isFocused) penBorder.Color = borderFocusColor;

                if (underlinedStyle) //Line Style
                {
                    //Draw border smoothing
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    //Draw border
                    graph.SmoothingMode = SmoothingMode.None;
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                }
                else //Normal Style
                {
                    //Draw border smoothing
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    //Draw border
                    graph.DrawPath(penBorder, pathBorder);
                }
            }
        }
        else //Square/Normal TextBox
        {
            //Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                this.Region = new Region(this.ClientRectangle);
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (isFocused) penBorder.Color = borderFocusColor;

                if (underlinedStyle) //Line Style
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else //Normal Style
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }
    }
    #endregion

}
