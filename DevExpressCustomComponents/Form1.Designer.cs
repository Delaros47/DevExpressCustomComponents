namespace DevExpressCustomComponents
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.myCalcEdit1 = new DevExpressCustomComponents.CustomComponents.Components.MyCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.myCalcEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(210, 196);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(90, 30);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Temp";
            // 
            // myCalcEdit1
            // 
            this.myCalcEdit1.EnterMoveNextControl = true;
            this.myCalcEdit1.Location = new System.Drawing.Point(178, 91);
            this.myCalcEdit1.Name = "myCalcEdit1";
            this.myCalcEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.myCalcEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.myCalcEdit1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.myCalcEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myCalcEdit1.Properties.Mask.EditMask = "n2";
            this.myCalcEdit1.Properties.MaskSettings.Set("mask", "n2");
            this.myCalcEdit1.Size = new System.Drawing.Size(162, 20);
            this.myCalcEdit1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 303);
            this.Controls.Add(this.myCalcEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myCalcEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private CustomComponents.Components.MyCalcEdit myCalcEdit1;
    }
}