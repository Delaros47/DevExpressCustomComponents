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
    public class MyDateEdit:DateEdit
    {
        public MyDateEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
    }
}
