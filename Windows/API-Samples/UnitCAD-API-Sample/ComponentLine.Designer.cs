using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using UnitCAD_API_Sample.Properties;

namespace UnitCAD_API_Sample
{
    partial class ComponentLine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_04 = new TabPage();
            this.cmb_AssemblySheet_paperSize = new ComboBox();
            this.lbl_Drawings = new Label();
            this.but_AssemblySheet = new Button();
            this.tab_03 = new TabPage();
            this.txt_ComponentAngle = new System.Windows.Forms.TextBox();
            this.txt_ComponentLength = new System.Windows.Forms.TextBox();
            this.cmb_ComponentType = new ComboBox();
            this.but_Del = new Button();
            this.but_Add = new Button();
            this.but_ab_Päckchen = new Button();
            this.but_auf_Päckchen = new Button();
            this.lst_Component = new ListBox();
            this.pic_Component = new PictureBox();
            this.tab_02 = new TabPage();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new PictureBox();
            this.tab_01 = new TabPage();
            this.lbl_ApplicationName = new Label();
            this.lbl_Kunden_Name = new Label();
            this.pictureBox2 = new PictureBox();
            this.tabControl1 = new TabControl();
            this.tab_04.SuspendLayout();
            this.tab_03.SuspendLayout();
            ((ISupportInitialize)this.pic_Component).BeginInit();
            this.tab_02.SuspendLayout();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.tab_01.SuspendLayout();
            ((ISupportInitialize)this.pictureBox2).BeginInit();
            this.tabControl1.SuspendLayout();
            base.SuspendLayout();
            this.tab_04.Controls.Add(this.cmb_AssemblySheet_paperSize);
            this.tab_04.Controls.Add(this.lbl_Drawings);
            this.tab_04.Controls.Add(this.but_AssemblySheet);
            this.tab_04.Location = new System.Drawing.Point(4, 22);
            this.tab_04.Name = "tab_04";
            this.tab_04.Size = new System.Drawing.Size(412, 339);
            this.tab_04.TabIndex = 4;
            this.tab_04.Text = "Output";
            this.tab_04.UseVisualStyleBackColor = true;
            this.cmb_AssemblySheet_paperSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmb_AssemblySheet_paperSize.FormattingEnabled = true;
            this.cmb_AssemblySheet_paperSize.Location = new System.Drawing.Point(274, 108);
            this.cmb_AssemblySheet_paperSize.Name = "cmb_AssemblySheet_paperSize";
            this.cmb_AssemblySheet_paperSize.Size = new System.Drawing.Size(49, 24);
            this.cmb_AssemblySheet_paperSize.TabIndex = 7;
            this.cmb_AssemblySheet_paperSize.Text = "A3";
            this.cmb_AssemblySheet_paperSize.SelectedIndexChanged += new EventHandler(this.cmb_AssemblySheet_paperSize_SelectedIndexChanged);
            this.lbl_Drawings.AutoSize = true;
            this.lbl_Drawings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbl_Drawings.Location = new System.Drawing.Point(119, 37);
            this.lbl_Drawings.Name = "lbl_Drawings";
            this.lbl_Drawings.Size = new System.Drawing.Size(72, 16);
            this.lbl_Drawings.TabIndex = 1;
            this.lbl_Drawings.Text = "Drawings";
            this.but_AssemblySheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.but_AssemblySheet.Image = Resources.Drawing;
            this.but_AssemblySheet.Location = new System.Drawing.Point(68, 67);
            this.but_AssemblySheet.Name = "but_AssemblySheet";
            this.but_AssemblySheet.Size = new System.Drawing.Size(177, 126);
            this.but_AssemblySheet.TabIndex = 0;
            this.but_AssemblySheet.UseVisualStyleBackColor = true;
            this.but_AssemblySheet.Click += new EventHandler(this.but_AssemblySheet_Click);
            this.tab_03.Controls.Add(this.txt_ComponentAngle);
            this.tab_03.Controls.Add(this.txt_ComponentLength);
            this.tab_03.Controls.Add(this.cmb_ComponentType);
            this.tab_03.Controls.Add(this.but_Del);
            this.tab_03.Controls.Add(this.but_Add);
            this.tab_03.Controls.Add(this.but_ab_Päckchen);
            this.tab_03.Controls.Add(this.but_auf_Päckchen);
            this.tab_03.Controls.Add(this.lst_Component);
            this.tab_03.Controls.Add(this.pic_Component);
            this.tab_03.Location = new System.Drawing.Point(4, 22);
            this.tab_03.Name = "tab_03";
            this.tab_03.Size = new System.Drawing.Size(412, 339);
            this.tab_03.TabIndex = 5;
            this.tab_03.Text = "Components";
            this.tab_03.UseVisualStyleBackColor = true;
            this.txt_ComponentAngle.Location = new System.Drawing.Point(344, 135);
            this.txt_ComponentAngle.Name = "txt_ComponentAngle";
            this.txt_ComponentAngle.Size = new System.Drawing.Size(39, 20);
            this.txt_ComponentAngle.TabIndex = 8;
            this.txt_ComponentAngle.TextChanged += new EventHandler(this.txt_ComponentAngle_TextChanged);
            this.txt_ComponentLength.Location = new System.Drawing.Point(263, 242);
            this.txt_ComponentLength.Name = "txt_ComponentLength";
            this.txt_ComponentLength.Size = new System.Drawing.Size(39, 20);
            this.txt_ComponentLength.TabIndex = 7;
            this.txt_ComponentLength.TextChanged += new EventHandler(this.txt_ComponentLength_TextChanged);
            this.cmb_ComponentType.FormattingEnabled = true;
            this.cmb_ComponentType.Location = new System.Drawing.Point(13, 48);
            this.cmb_ComponentType.Name = "cmb_ComponentType";
            this.cmb_ComponentType.Size = new System.Drawing.Size(140, 21);
            this.cmb_ComponentType.TabIndex = 6;
            this.cmb_ComponentType.SelectedIndexChanged += new EventHandler(this.cmb_ComponentType_SelectedIndexChanged);
            this.but_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.but_Del.Location = new System.Drawing.Point(88, 305);
            this.but_Del.Name = "but_Del";
            this.but_Del.Size = new System.Drawing.Size(40, 25);
            this.but_Del.TabIndex = 4;
            this.but_Del.Text = "Del";
            this.but_Del.UseVisualStyleBackColor = true;
            this.but_Del.Click += new EventHandler(this.but_Del_Component_Click);
            this.but_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.but_Add.Location = new System.Drawing.Point(13, 305);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(40, 25);
            this.but_Add.TabIndex = 5;
            this.but_Add.Text = "Add";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new EventHandler(this.but_Add_Component_Click);
            this.but_ab_Päckchen.Image = Resources.down;
            this.but_ab_Päckchen.Location = new System.Drawing.Point(134, 269);
            this.but_ab_Päckchen.Name = "but_ab_Päckchen";
            this.but_ab_Päckchen.Size = new System.Drawing.Size(19, 30);
            this.but_ab_Päckchen.TabIndex = 3;
            this.but_ab_Päckchen.UseVisualStyleBackColor = true;
            this.but_ab_Päckchen.Click += new EventHandler(this.but_down_Click);
            this.but_auf_Päckchen.Image = Resources.up;
            this.but_auf_Päckchen.Location = new System.Drawing.Point(134, 75);
            this.but_auf_Päckchen.Name = "but_auf_Päckchen";
            this.but_auf_Päckchen.Size = new System.Drawing.Size(19, 30);
            this.but_auf_Päckchen.TabIndex = 1;
            this.but_auf_Päckchen.UseVisualStyleBackColor = true;
            this.but_auf_Päckchen.Click += new EventHandler(this.but_up_Click);
            this.lst_Component.FormattingEnabled = true;
            this.lst_Component.Location = new System.Drawing.Point(13, 74);
            this.lst_Component.Name = "lst_Component";
            this.lst_Component.Size = new System.Drawing.Size(115, 225);
            this.lst_Component.TabIndex = 2;
            this.lst_Component.SelectedIndexChanged += new EventHandler(this.lst_Component_SelectedIndexChanged);
            this.pic_Component.Image = Resources.straight;
            this.pic_Component.Location = new System.Drawing.Point(162, 48);
            this.pic_Component.Name = "pic_Component";
            this.pic_Component.Size = new System.Drawing.Size(250, 250);
            this.pic_Component.TabIndex = 9;
            this.pic_Component.TabStop = false;
            this.tab_02.Controls.Add(this.txt_height);
            this.tab_02.Controls.Add(this.txt_width);
            this.tab_02.Controls.Add(this.pictureBox1);
            this.tab_02.Location = new System.Drawing.Point(4, 22);
            this.tab_02.Name = "tab_02";
            this.tab_02.Size = new System.Drawing.Size(412, 339);
            this.tab_02.TabIndex = 2;
            this.tab_02.Text = "Basic Parameter";
            this.tab_02.UseVisualStyleBackColor = true;
            this.txt_height.Location = new System.Drawing.Point(301, 118);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(40, 20);
            this.txt_height.TabIndex = 9;
            this.txt_width.Location = new System.Drawing.Point(143, 256);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(40, 20);
            this.txt_width.TabIndex = 8;
            this.pictureBox1.Image = Resources.StraightComponent;
            this.pictureBox1.Location = new System.Drawing.Point(44, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 270);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.tab_01.Controls.Add(this.lbl_ApplicationName);
            this.tab_01.Controls.Add(this.lbl_Kunden_Name);
            this.tab_01.Controls.Add(this.pictureBox2);
            this.tab_01.Location = new System.Drawing.Point(4, 22);
            this.tab_01.Name = "tab_01";
            this.tab_01.Padding = new System.Windows.Forms.Padding(3);
            this.tab_01.Size = new System.Drawing.Size(412, 339);
            this.tab_01.TabIndex = 0;
            this.tab_01.Text = "Start";
            this.tab_01.UseVisualStyleBackColor = true;
            this.lbl_ApplicationName.AutoSize = true;
            this.lbl_ApplicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbl_ApplicationName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_ApplicationName.Location = new System.Drawing.Point(36, 20);
            this.lbl_ApplicationName.Name = "lbl_ApplicationName";
            this.lbl_ApplicationName.Size = new System.Drawing.Size(306, 42);
            this.lbl_ApplicationName.TabIndex = 3;
            this.lbl_ApplicationName.Text = "Component Line";
            this.lbl_Kunden_Name.AutoSize = true;
            this.lbl_Kunden_Name.Font = new System.Drawing.Font("Arial Narrow", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lbl_Kunden_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Kunden_Name.Location = new System.Drawing.Point(161, 296);
            this.lbl_Kunden_Name.Name = "lbl_Kunden_Name";
            this.lbl_Kunden_Name.Size = new System.Drawing.Size(210, 29);
            this.lbl_Kunden_Name.TabIndex = 2;
            this.lbl_Kunden_Name.Text = "www.IntentDesign.de";
            this.pictureBox2.Image = Resources.ComponentLine;
            this.pictureBox2.Location = new System.Drawing.Point(19, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(352, 228);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.tabControl1.Controls.Add(this.tab_01);
            this.tabControl1.Controls.Add(this.tab_02);
            this.tabControl1.Controls.Add(this.tab_03);
            this.tabControl1.Controls.Add(this.tab_04);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 365);
            this.tabControl1.TabIndex = 46;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.Controls.Add(this.tabControl1);
            base.Name = "ComponentLine";
            base.Size = new System.Drawing.Size(426, 370);
            this.tab_04.ResumeLayout(false);
            this.tab_04.PerformLayout();
            this.tab_03.ResumeLayout(false);
            this.tab_03.PerformLayout();
            ((ISupportInitialize)this.pic_Component).EndInit();
            this.tab_02.ResumeLayout(false);
            this.tab_02.PerformLayout();
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.tab_01.ResumeLayout(false);
            this.tab_01.PerformLayout();
            ((ISupportInitialize)this.pictureBox2).EndInit();
            this.tabControl1.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        private TabPage tab_04;

        private ComboBox cmb_AssemblySheet_paperSize;

        private Label lbl_Drawings;

        private Button but_AssemblySheet;

        private TabPage tab_03;

        private Button but_Del;

        private Button but_Add;

        private Button but_ab_Päckchen;

        private Button but_auf_Päckchen;

        private ListBox lst_Component;

        private TabPage tab_02;

        private TabPage tab_01;

        private Label lbl_ApplicationName;

        private Label lbl_Kunden_Name;

        private TabControl tabControl1;

        private ComboBox cmb_ComponentType;

        private System.Windows.Forms.TextBox txt_height;

        private System.Windows.Forms.TextBox txt_width;

        private System.Windows.Forms.TextBox txt_ComponentAngle;

        private System.Windows.Forms.TextBox txt_ComponentLength;

        private PictureBox pictureBox1;

        private PictureBox pictureBox2;

        private PictureBox pic_Component;


        #endregion
    }
}
