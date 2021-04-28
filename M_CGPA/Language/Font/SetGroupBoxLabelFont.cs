using System.Drawing;
using System.Windows.Forms;

namespace M_CGPA.Language.Font
{
    public class SetGroupBoxLabelFont
    {
        //
        //
        // Control 5 GroupBox for Label
        //
        //

        private const float FontSize = 16;
        private const string FontName = "Microsoft Sans Serif";
        private const FontStyle Style = FontStyle.Regular;

        public SetGroupBoxLabelFont()
        {

        }
        
        public SetGroupBoxLabelFont(GroupBox groupBox1):this()
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is Label)
                {
                    control.Font = new System.Drawing.Font(FontName, FontSize, Style, GraphicsUnit.Point, (0));
                }
            }
        }

        public SetGroupBoxLabelFont(GroupBox groupBox1, GroupBox groupBox2):this(groupBox1)
        {
            foreach (Control control in groupBox2.Controls)
            {
                if (control is Label)
                {
                    control.Font = new System.Drawing.Font(FontName, FontSize, Style, GraphicsUnit.Point, (0));
                }
            }
        }

        public SetGroupBoxLabelFont(GroupBox groupBox1, GroupBox groupBox2, GroupBox groupBox3):this(groupBox1,groupBox2)
        {
            foreach (Control control in groupBox3.Controls)
            {
                if (control is Label)
                {
                    control.Font = new System.Drawing.Font(FontName, FontSize, Style, GraphicsUnit.Point, (0));
                }
            }
        }

        public SetGroupBoxLabelFont(GroupBox groupBox1, GroupBox groupBox2, GroupBox groupBox3, GroupBox groupBox4):this(groupBox1,groupBox2,groupBox3)
        {
            foreach (Control control in groupBox4.Controls)
            {
                if (control is Label)
                {
                    control.Font = new System.Drawing.Font(FontName, FontSize, Style, GraphicsUnit.Point, (0));
                }
            }
        }

        public SetGroupBoxLabelFont(GroupBox groupBox1, GroupBox groupBox2, GroupBox groupBox3, GroupBox groupBox4, GroupBox groupBox5):this(groupBox1,groupBox2,groupBox3, groupBox4)
        {
            foreach (Control control in groupBox5.Controls)
            {
                if (control is Label)
                {
                    control.Font = new System.Drawing.Font(FontName, FontSize, Style, GraphicsUnit.Point, (0));
                }
            }
        }





    }

}
