using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;

namespace DevExpressCustomComponents.CustomComponents.Components
{
    [ToolboxItem(true)]
    public class MyCalcEdit:CalcEdit
    {
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.Mask.MaskType = MaskType.Numeric;
            Properties.Mask.EditMask = "n2";
        }

        public override bool EnterMoveNextControl { get; set; } = true;
    }
}
