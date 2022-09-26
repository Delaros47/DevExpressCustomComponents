using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace DevExpressCustomComponents.CustomComponents.Components
{
    [ToolboxItem(true)]
    public class MySimpleButton:SimpleButton
    {
        public MySimpleButton()
        {
            ForeColor = Color.Maroon;
        }
    }
}
