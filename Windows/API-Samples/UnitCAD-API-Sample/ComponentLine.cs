using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using risersoft.shared.portable;
using UnitCAD_API_Sample.Properties;
using risersoft.UnitCAD.API;
using Inventor;
using System.Collections;

namespace UnitCAD_API_Sample
{
    public partial class ComponentLine : UserControl, IParamEditorControl
    {


        private IComponentDocument m_thePart;

        private EditorWindowConfig m_controlConfiguration;

        public Inventor.Application InventorApplication;

        public AssemblyDocument o_AssDoc;

        private CultureInfo ci = new CultureInfo("de-de");

        public bool ModelValid;

        public List<string> lst_ComponentType = new List<string>();

        public List<string> lst_ComponentLength = new List<string>();

        public List<string> lst_ComponentAngle = new List<string>();

        public string Parameterstring;

        IComponentDocument  IParamEditorControl.ContextDocument
        {
            get
            {
                return this.m_thePart;
            }
            set
            {
                this.m_thePart = value;
                this.MyRefreshData();
            }
        }

        EditorWindowConfig IParamEditorControl.WindowConfiguration
        {
            get
            {
                return this.m_controlConfiguration;
            }
        }

        object IParamEditorControl.InventorInteractionEventsObject
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public ComponentLine()
        {

            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
            this.InitializeComponent();
            ComboBox.ObjectCollection items = this.cmb_AssemblySheet_paperSize.Items;
            object[] objArray = new object[] { "A3", "A2", "A1", "A0" };
            items.AddRange(objArray);
            this.m_controlConfiguration = new EditorWindowConfig()
            {
                AllowStandardPartEditor = true,
                IsResizable = false,
                PreferredSize = base.Size
            };
        }

        bool IParamEditorControl.ApplyChanges()
        {
            this.SetRuleFormulaIfChanged("width", this.txt_width.Text);
            this.SetRuleFormulaIfChanged("height", this.txt_height.Text);
            string Ausgabe_Text = "";
            for (int i = 0; i < this.lst_Component.Items.Count; i++)
            {
                string[] strArrays = new string[] { Ausgabe_Text, "ComponentName;", this.lst_Component.Items[i].ToString().Replace(",", "."), ";ComponentType;", this.lst_ComponentType[i].ToString().Replace(",", "."), ";ComponentLength;", this.lst_ComponentLength[i].ToString().Replace(",", "."), ";ComponentAngle;", this.lst_ComponentAngle[i].ToString().Replace(",", "."), "|" };
                Ausgabe_Text = string.Concat(strArrays);
            }
            this.SetRuleValueIfChanged("ParameterString", Ausgabe_Text);
            this.SetRuleValueIfChanged("AssemblySheet_papersize", this.cmb_AssemblySheet_paperSize.Text);
            return true;
        }

        IDictionary<string, object> IParamEditorControl.GetRulesCurrentValues()
        {
            return new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
        }

        void IParamEditorControl.RefreshData()
        {
            this.MyRefreshData();
        }

        void IParamEditorControl.RefreshFromRulesCurrentValues(IDictionary<string, object> modifiedRules)
        {
        }

        private void but_Add_Component_Click(object sender, EventArgs e)
        {
            int aktiver_Index = -1;
            string ComponentName = "";
            if (ComponentName != "")
            {
                if (this.lst_Component.Items.Count > 0 && this.lst_Component.SelectedIndex >= 0)
                {
                    ComponentName = this.NxtKeyCode(this.lst_Component.SelectedItem.ToString());
                }
            }
            else if (this.lst_Component.Items.Count == 0)
            {
                ComponentName = "Comp_01";
                if (this.cmb_ComponentType.Text == "")
                {
                    this.cmb_ComponentType.Text = this.cmb_ComponentType.Items[0].ToString();
                }
            }
            else if (this.lst_Component.SelectedIndex >= 0)
            {
                ComponentName = this.NxtKeyCode(this.lst_Component.SelectedItem.ToString());
            }
            if (this.lst_Component.Items.Contains(ComponentName))
            {
                MessageBox.Show(string.Concat("Component  ", ComponentName, "  already exists!"), "Error");
                this.lst_Component.Select();
                aktiver_Index = this.lst_Component.FindString(ComponentName);
                this.lst_Component.SetSelected(aktiver_Index, true);
            }
            else if (ComponentName != "")
            {
                this.lst_Component.Items.Add(ComponentName.ToString());
                this.lst_ComponentType.Add(this.cmb_ComponentType.Items[0].ToString());
                this.lst_ComponentLength.Add("2000");
                this.lst_ComponentAngle.Add("0");
                try
                {
                    this.lst_Component.Select();
                    aktiver_Index = this.lst_Component.FindString(ComponentName);
                    this.lst_Component.SetSelected(aktiver_Index, true);
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("Spaces are not allowed!", "Error");
            }
            this.Component_Tab_refresh();
        }

        private async void but_AssemblySheet_Click(object sender, EventArgs e)
        {
            this.SetRuleValueIfChanged("AssemblySheet_papersize", this.cmb_AssemblySheet_paperSize.Text);
            await this.m_thePart.RunSnapshotRule("drawing");
        }

        private void but_Del_Component_Click(object sender, EventArgs e)
        {
            if (this.lst_Component.Items.Count > 0 && this.lst_Component.SelectedIndex >= 0)
            {
                int index_to_be_deleted = this.lst_Component.SelectedIndex;
                try
                {
                    this.lst_Component.Select();
                    this.lst_Component.Items.Remove(this.lst_Component.Text);
                }
                catch
                {
                    MessageBox.Show("Error in but_Del_Component_Click");
                }
                this.lst_ComponentType.RemoveAt(index_to_be_deleted);
                this.lst_ComponentLength.RemoveAt(index_to_be_deleted);
                this.lst_ComponentAngle.RemoveAt(index_to_be_deleted);
                if (this.lst_Component.Items.Count <= 0)
                {
                    this.lst_Component.SelectedIndex = -1;
                }
                else if (index_to_be_deleted >= this.lst_Component.Items.Count - 1)
                {
                    this.lst_Component.SelectedIndex = this.lst_Component.Items.Count - 1;
                }
                else
                {
                    this.lst_Component.SelectedIndex = index_to_be_deleted;
                }
            }
            this.Component_Tab_refresh();
        }

        private void but_down_Click(object sender, EventArgs e)
        {
            int oldIndex = this.lst_Component.SelectedIndex;
            if (oldIndex < this.lst_Component.Items.Count - 1 && oldIndex > -1)
            {
                int newIndex = oldIndex + 1;
                string parken = this.lst_Component.Items[newIndex].ToString();
                this.lst_Component.Items[newIndex] = this.lst_Component.Items[oldIndex];
                this.lst_Component.SelectedIndex = newIndex;
                this.lst_Component.Items[oldIndex] = parken;
                string ComponentLength = this.lst_ComponentLength[newIndex];
                this.lst_ComponentLength[newIndex] = this.lst_ComponentLength[oldIndex];
                this.lst_ComponentLength[oldIndex] = ComponentLength;
                this.txt_ComponentLength.Text = this.lst_ComponentLength[this.lst_Component.SelectedIndex].ToString();
                string ComponentAngle = this.lst_ComponentAngle[newIndex];
                this.lst_ComponentAngle[newIndex] = this.lst_ComponentAngle[oldIndex];
                this.lst_ComponentAngle[oldIndex] = ComponentAngle;
                this.txt_ComponentAngle.Text = this.lst_ComponentAngle[this.lst_Component.SelectedIndex];
                string ComponentType = this.lst_ComponentType[newIndex];
                this.lst_ComponentType[newIndex] = this.lst_ComponentType[oldIndex];
                this.lst_ComponentType[oldIndex] = ComponentType;
                this.cmb_ComponentType.Text = this.lst_ComponentType[this.lst_Component.SelectedIndex].ToString();
            }
        }

        private void but_up_Click(object sender, EventArgs e)
        {
            int oldIndex = this.lst_Component.SelectedIndex;
            if (oldIndex > 0)
            {
                int newIndex = oldIndex - 1;
                string parken = this.lst_Component.Items[newIndex].ToString();
                this.lst_Component.Items[newIndex] = this.lst_Component.Items[oldIndex];
                this.lst_Component.SelectedIndex = newIndex;
                this.lst_Component.Items[oldIndex] = parken;
                string ComponentLength = this.lst_ComponentLength[newIndex];
                this.lst_ComponentLength[newIndex] = this.lst_ComponentLength[oldIndex];
                this.lst_ComponentLength[oldIndex] = ComponentLength;
                this.txt_ComponentLength.Text = this.lst_ComponentLength[this.lst_Component.SelectedIndex].ToString();
                string ComponentAngle = this.lst_ComponentAngle[newIndex];
                this.lst_ComponentAngle[newIndex] = this.lst_ComponentAngle[oldIndex];
                this.lst_ComponentAngle[oldIndex] = ComponentAngle;
                this.txt_ComponentAngle.Text = this.lst_ComponentAngle[this.lst_Component.SelectedIndex];
                string ComponentType = this.lst_ComponentType[newIndex];
                this.lst_ComponentType[newIndex] = this.lst_ComponentType[oldIndex];
                this.lst_ComponentType[oldIndex] = ComponentType;
                this.cmb_ComponentType.Text = this.lst_ComponentType[this.lst_Component.SelectedIndex].ToString();
            }
        }

        private void cmb_AssemblySheet_paperSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetRuleValueIfChanged("AssemblySheet_papersize", this.cmb_AssemblySheet_paperSize.Text);
        }

        private void cmb_ComponentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lst_Component.SelectedIndex >= 0 && this.lst_Component.SelectedIndex <= this.lst_Component.Items.Count - 1)
            {
                this.lst_ComponentType[this.lst_Component.SelectedIndex] = this.cmb_ComponentType.Text;
            }
            if (this.cmb_ComponentType.Text == "StraightComponent")
            {
                this.txt_ComponentAngle.Text = "0";
                if (this.txt_ComponentLength.Text == "0" || this.txt_ComponentLength.Text == "")
                {
                    this.txt_ComponentLength.Text = "2000";
                }
            }
            else if (this.cmb_ComponentType.Text == "LeftCurvedComponent" || this.cmb_ComponentType.Text == "RightCurvedComponent")
            {
                this.txt_ComponentLength.Text = "0";
                if (this.txt_ComponentAngle.Text == "0" || this.txt_ComponentAngle.Text == "")
                {
                    this.txt_ComponentAngle.Text = "90";
                }
            }
            this.Component_Tab_refresh();
        }

        private void Component_Tab_refresh()
        {
            if (this.lst_Component.SelectedIndex >= 0)
            {
                this.txt_ComponentLength.Text = this.lst_ComponentLength[this.lst_Component.SelectedIndex];
                this.txt_ComponentAngle.Text = this.lst_ComponentAngle[this.lst_Component.SelectedIndex];
                this.cmb_ComponentType.Text = this.lst_ComponentType[this.lst_Component.SelectedIndex];
            }
            else if (this.lst_Component.Items.Count > 0)
            {
                this.lst_Component.SelectedIndex = this.lst_Component.Items.Count - 1;
            }
            if (this.cmb_ComponentType.Text == "StraightComponent")
            {
                this.pic_Component.Image = Resources.straight;
                this.txt_ComponentAngle.Visible = false;
                this.txt_ComponentLength.Visible = true;
                this.txt_ComponentLength.Location = new System.Drawing.Point(263, 242);
                return;
            }
            if (this.cmb_ComponentType.Text == "LeftCurvedComponent")
            {
                this.pic_Component.Image = Resources.left_curved;
                this.txt_ComponentAngle.Visible = true;
                this.txt_ComponentLength.Visible = false;
                this.txt_ComponentAngle.Location = new System.Drawing.Point(344, 135);
                return;
            }
            if (this.cmb_ComponentType.Text == "RightCurvedComponent")
            {
                this.pic_Component.Image = Resources.right_curved;
                this.txt_ComponentAngle.Visible = true;
                this.txt_ComponentLength.Visible = false;
                this.txt_ComponentAngle.Location = new System.Drawing.Point(174, 155);
            }
        }

     
        private void lst_Component_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Component_Tab_refresh();
        }

        private void MyRefreshData()
        {
            this.txt_width.Text = this.m_thePart.GetRuleValue("width").ToString();
            this.txt_height.Text = this.m_thePart.GetRuleValue("height").ToString();
            this.cmb_AssemblySheet_paperSize.Text = this.m_thePart.GetRuleValue("AssemblySheet_papersize").ToString();
            if (this.lst_Component.Items.Count == 0)
            {
                try
                {
                    string[] strArrays = this.m_thePart.GetRuleValue("ParameterString").ToString().Split(new char[] { '|' });
                    for (int i = 0; i < (int)strArrays.Length; i++)
                    {
                        object o_Component = strArrays[i];
                        ListBox.ObjectCollection items = this.lst_Component.Items;
                        string str = o_Component.ToString();
                        char[] chrArray = new char[] { ';' };
                        items.Add(str.Split(chrArray)[1].ToString());
                        List<string> lstComponentType = this.lst_ComponentType;
                        string str1 = o_Component.ToString();
                        char[] chrArray1 = new char[] { ';' };
                        lstComponentType.Add(str1.Split(chrArray1)[3].ToString().Replace(":", ""));
                        List<string> lstComponentLength = this.lst_ComponentLength;
                        string str2 = o_Component.ToString();
                        char[] chrArray2 = new char[] { ';' };
                        lstComponentLength.Add(str2.Split(chrArray2)[5].ToString());
                        List<string> lstComponentAngle = this.lst_ComponentAngle;
                        string str3 = o_Component.ToString();
                        char[] chrArray3 = new char[] { ';' };
                        lstComponentAngle.Add(str3.Split(chrArray3)[7].ToString());
                    }
                }
                catch
                {
                }
            }
            if (this.cmb_ComponentType.Items.Count == 0)
            {
                var lst = (IUcList)this.m_thePart.GetRuleValue("ComponentChoicelist");
                if (lst!=null) this.cmb_ComponentType.Items.AddRange(lst.ToValueArray());
            }
            this.UpdateButtons(this.validateAllParameters());
            this.Component_Tab_refresh();
        }

        // ETOChildListDemo_PE.ComponentLine
        public string NxtKeyCode(string KeyCode)
        {
            byte[] ASCIIValues = System.Text.Encoding.ASCII.GetBytes(KeyCode);
            int StringLength = ASCIIValues.Length;
            bool isAllZed = true;
            bool isAllNine = true;
            for (int i = 0; i < StringLength - 1; i++)
            {
                if (ASCIIValues[i] != 90)
                {
                    isAllZed = false;
                    break;
                }
            }
            if (isAllZed && ASCIIValues[StringLength - 1] == 57)
            {
                ASCIIValues[StringLength - 1] = 64;
            }
            for (int j = 0; j < StringLength; j++)
            {
                if (ASCIIValues[j] != 57)
                {
                    isAllNine = false;
                    break;
                }
            }
            if (isAllNine)
            {
                ASCIIValues[StringLength - 1] = 47;
                ASCIIValues[0] = 65;
                for (int k = 1; k < StringLength - 1; k++)
                {
                    ASCIIValues[k] = 48;
                }
            }
            for (int l = StringLength; l > 0; l--)
            {
                if (l - StringLength == 0)
                {
                    byte[] expr_A0_cp_0 = ASCIIValues;
                    int expr_A0_cp_1 = l - 1;
                    expr_A0_cp_0[expr_A0_cp_1] += 1;
                }
                if (ASCIIValues[l - 1] == 58)
                {
                    ASCIIValues[l - 1] = 48;
                    if (l - 2 == -1)
                    {
                        break;
                    }
                    byte[] expr_D1_cp_0 = ASCIIValues;
                    int expr_D1_cp_1 = l - 2;
                    expr_D1_cp_0[expr_D1_cp_1] += 1;
                }
                else
                {
                    if (ASCIIValues[l - 1] != 91)
                    {
                        break;
                    }
                    ASCIIValues[l - 1] = 65;
                    if (l - 2 == -1)
                    {
                        break;
                    }
                    byte[] expr_104_cp_0 = ASCIIValues;
                    int expr_104_cp_1 = l - 2;
                    expr_104_cp_0[expr_104_cp_1] += 1;
                }
            }
            KeyCode = System.Text.Encoding.ASCII.GetString(ASCIIValues);
            return KeyCode;
        }

        private void SetRuleFormulaIfChanged(string ruleName, string ruleFormula)
        {
            if (this.m_thePart.GetRuleValue(ruleName).ToString().Replace(",", ".") != ruleFormula)
            {
                this.m_thePart.SetRuleFormula(ruleName, ruleFormula);
            }
        }

        private void SetRuleValueBoolIfChanged(string ruleName, bool ruleFormula)
        {
            if ((bool)this.m_thePart.GetRuleValue(ruleName) != ruleFormula)
            {
                this.m_thePart.SetRuleValue(ruleName, ruleFormula);
            }
        }

        private void SetRuleValueIfChanged(string ruleName, string ruleFormula)
        {
            if (this.m_thePart.GetRuleValue(ruleName).ToString() != ruleFormula)
            {
                this.m_thePart.SetRuleValue(ruleName, ruleFormula);
            }
        }

        private void txt_ComponentAngle_TextChanged(object sender, EventArgs e)
        {
            if (this.lst_Component.SelectedIndex >= 0 && this.lst_Component.SelectedIndex <= this.lst_Component.Items.Count - 1)
            {
                this.lst_ComponentAngle[this.lst_Component.SelectedIndex] = this.txt_ComponentAngle.Text;
            }
        }

        private void txt_ComponentLength_TextChanged(object sender, EventArgs e)
        {
            if (this.lst_Component.SelectedIndex >= 0 && this.lst_Component.SelectedIndex <= this.lst_Component.Items.Count - 1)
            {
                this.lst_ComponentLength[this.lst_Component.SelectedIndex] = this.txt_ComponentLength.Text;
            }
        }

        private void UpdateButtons(bool enable)
        {
            if (this.UpdateApplyButton != null)
            {
                this.UpdateApplyButton(this, new UpdateButtonEventArgs(enable));
            }
            if (this.UpdateOkButton != null)
            {
                this.UpdateOkButton(this, new UpdateButtonEventArgs(enable));
            }
        }

        private bool validateAllParameters()
        {
            return true;
        }

        private bool validateSyntax(System.Windows.Forms.TextBox tbox)
        {
            string txt = tbox.Text;
            //Source src = new Source(txt);
            //bool valid = IntentAPI.Instance.Utilities.IsValidFormula(src);
            bool valid = true;
            if (txt.Length <= 0 || valid)
            {
                tbox.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                tbox.ForeColor = System.Drawing.Color.Red;
            }
            return valid;
        }

        public event EventHandler<UpdateButtonEventArgs> UpdateApplyButton;

        public event EventHandler<UpdateButtonEventArgs> UpdateOkButton;

    }
}
