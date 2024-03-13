using StylesheetNET;
namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CSSSheet sheet = new CSSSheet()
            {
                Charset = "UTF-8",
                Root = new Root()
                {
                    All = AllOptions.Unset,
                    ["--color"] = "blue"
                },

                [".head .account"] = new Element()
                {
                    //Also u can write them this way too

                    //Height = new Height("10px"),
                    //Height = new Height(HeightOptions.Auto)
                    //Height = HeightOptions.Auto;

                    Height = "40px !important",
                    Width = "40px !important",
                    Position = PositionOptions.Absolute,
                    Top = "12px",
                    Left = "15px",
                    BorderRadius = "20px",
                    Border = "2px #837A78 solid",
                    Display = DisplayOptions.Flex,
                    JustifyContent = JustifyContentOptions.Center,
                    AlignItems = AlignItemsOptions.Center,
                    Animation = "flash",
                },
                ["#dot"] = new ElementHover()
                {
                    //Also u can write this way

                    //Height = new Height("10px"),
                    //Height = new Height(HeightOptions.Auto)
                    //Height = HeightOptions.Auto;

                    Height = "10px",
                    Width = "10px",
                    Position = PositionOptions.Absolute,
                    Top = "16px",
                    Right = "13px",
                    BackgroundColor = "#F16842",
                    BorderRadius = "5px",
                    Display = DisplayOptions.Block

                },

                [AtRuleType.MediaQuery] = new MediaQuery(new AtRule().MinWidth("0px").And.MaxWidth("319px"))
                {
                    ["a[target=\"_blank\"]"] = new Element()
                    {
                        Position = PositionOptions.Absolute,
                        Top = "20px",
                        Left = "0",
                        ZIndex = "99"
                    }
                },

                [AtRuleType.Keyframes] = new Keyframes("flash")
                {
                    ["0%, 50%, to"] = new Keyframe()
                    {
                        Opacity = "1"
                    },
                    ["55%"] = new Keyframe()
                    {
                        Opacity = "0.5"
                    },
                    ["25%, 75%"] = new Keyframe()
                    {
                        Opacity = "0"
                    }
                }
            };

            sheet.AddFontFace("lilitaone-regular", "font/lilitaone-regular.ttf");
            richTextBox2.Text = sheet;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            CSSSheet sh = new CSSSheet();
            MessageBox.Show(sh["11"].Top);
        }
    }
}
