using System.Drawing;
using System.Windows.Forms;

namespace M_CGPA.Language.Font
{
    public class SetGroupBoxLabelFont
    {
        public SetGroupBoxLabelFont()
        {

        }
        
        public SetGroupBoxLabelFont(GroupBox groupBox1):this()
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is Label)
                {
                    control.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, (0));
                }
            }
        }

        public SetGroupBoxLabelFont(GroupBox groupBox1, GroupBox groupBox2):this(groupBox1)
        {
            foreach (Control control in groupBox2.Controls)
            {
                if (control is Label)
                {
                    control.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, (0));
                }
            }
        }

        public SetGroupBoxLabelFont(GroupBox groupBox1, GroupBox groupBox2, GroupBox groupBox3):this(groupBox1,groupBox2)
        {
            foreach (Control control in groupBox3.Controls)
            {
                if (control is Label)
                {
                    control.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, (0));
                }
            }
        }

        public SetGroupBoxLabelFont(GroupBox groupBox1, GroupBox groupBox2, GroupBox groupBox3, GroupBox groupBox4):this(groupBox1,groupBox2,groupBox3)
        {
            foreach (Control control in groupBox4.Controls)
            {
                if (control is Label)
                {
                    control.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, (0));
                }
            }
        }

        public SetGroupBoxLabelFont(GroupBox groupBox1, GroupBox groupBox2, GroupBox groupBox3, GroupBox groupBox4, GroupBox groupBox5):this(groupBox1,groupBox2,groupBox3, groupBox4)
        {
            foreach (Control control in groupBox5.Controls)
            {
                if (control is Label)
                {
                    control.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, (0));
                }
            }
        }





    }

}
