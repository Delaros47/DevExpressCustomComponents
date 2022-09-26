using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpressCustomComponents.CustomComponents.Components
{
    [ToolboxItem(true)]
    public class MyPictureEdit:PictureEdit
    {
        public MyPictureEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.NullText = "No Image";
            Properties.Appearance.ForeColor = Color.Maroon;
            Properties.ShowMenu = false;
            Properties.SizeMode = PictureSizeMode.Stretch;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
    }
}
