
using System.Drawing;
using System.Windows.Forms;

namespace M_CGPA.Language.Font
{
    class SetPanelButtonFont
    {
        //
        //
        // Congrol 5 GroupBox for Label
        //
        //

        private const float FontSize = 14;
        private const string FontName = "Microsoft Sans Serif";
        private const FontStyle Style = FontStyle.Regular;

        public SetPanelButtonFont()
        {

        }
        
        public SetPanelButtonFont(Panel panel1):this()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button)
                {
                    control.Font = new System.Drawing.Font(FontName, FontSize, Style, GraphicsUnit.Point, (0));
                }
            }
        }

        public SetPanelButtonFont(Panel panel1, Panel panel2) : this(panel1)
        {
            foreach (Control control in panel2.Controls)
            {
                if (control is Button)
                {
                    control.Font = new System.Drawing.Font(FontName, FontSize, Style, GraphicsUnit.Point, (0));
                }
            }
        }

        public SetPanelButtonFont(Panel panel1, Panel panel2, Panel panel3) : this(panel1, panel2)
        {
            foreach (Control control in panel3.Controls)
            {
                if (control is Button)
                {
                    control.Font = new System.Drawing.Font(FontName, FontSize, Style, GraphicsUnit.Point, (0));
                }
            }
        }

        public SetPanelButtonFont(Panel panel1, Panel panel2, Panel panel3, Panel panel4) : this(panel1, panel2, panel3)
        {
            foreach (Control control in panel4.Controls)
            {
                if (control is Button)
                {
                    control.Font = new System.Drawing.Font(FontName, FontSize, Style, GraphicsUnit.Point, (0));
                }
            }
        }

        public SetPanelButtonFont(Panel panel1, Panel panel2, Panel panel3, Panel panel4, Panel panel5)
            : this(panel1, panel2, panel3, panel4)
        {
            foreach (Control control in panel5.Controls)
            {
                if (control is Button)
                {
                    control.Font = new System.Drawing.Font(FontName, FontSize, Style, GraphicsUnit.Point, (0));
                }
            }
        }
    }
}
