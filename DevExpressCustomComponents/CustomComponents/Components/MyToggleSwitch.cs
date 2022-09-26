using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpressCustomComponents.CustomComponents.Components
{
    [ToolboxItem(true)]
    public class MyToggleSwitch:ToggleSwitch
    {
        public MyToggleSwitch()
        {
            Properties.OnText = "Active";
            Properties.OffText = "Passive";
            Properties.Appearance.ForeColor = Color.Maroon;
            Properties.GlyphAlignment = HorzAlignment.Far;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
    }
}
