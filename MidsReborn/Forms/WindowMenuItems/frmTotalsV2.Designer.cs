﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using mrbControls;

namespace Mids_Reborn.Forms.WindowMenuItems
{
    partial class frmTotalsV2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTotalsV2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.graphEnd = new mrbControls.ctlMultiGraph();
            this.graphHP = new mrbControls.ctlMultiGraph();
            this.graphRes = new mrbControls.ctlMultiGraph();
            this.graphDef = new mrbControls.ctlMultiGraph();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.graphThreat = new mrbControls.ctlMultiGraph();
            this.graphEndRdx = new mrbControls.ctlMultiGraph();
            this.graphDamage = new mrbControls.ctlMultiGraph();
            this.graphAccuracy = new mrbControls.ctlMultiGraph();
            this.graphToHit = new mrbControls.ctlMultiGraph();
            this.graphHaste = new mrbControls.ctlMultiGraph();
            this.graphPerception = new mrbControls.ctlMultiGraph();
            this.graphMovement = new mrbControls.ctlMultiGraph();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.graphStatusRes = new mrbControls.ctlMultiGraph();
            this.graphStatusProt = new mrbControls.ctlMultiGraph();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.graphElusivity = new mrbControls.ctlMultiGraph();
            this.graphDebuffRes = new mrbControls.ctlMultiGraph();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbTopMost = new System.Windows.Forms.PictureBox();
            this.ctlTotalsTabStrip1 = new mrbControls.ctlTotalsTabStrip();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopMost)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(130, 21);
            this.tabControl1.Location = new System.Drawing.Point(-3, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 770);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.graphEnd);
            this.tabPage1.Controls.Add(this.graphHP);
            this.tabPage1.Controls.Add(this.graphRes);
            this.tabPage1.Controls.Add(this.graphDef);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(615, 741);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Core Stats";
            // 
            // graphEnd
            // 
            this.graphEnd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphEnd.BackgroundImage")));
            this.graphEnd.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphEnd.BaseBarColors")));
            this.graphEnd.Border = true;
            this.graphEnd.BorderColor = System.Drawing.Color.RoyalBlue;
            this.graphEnd.Clickable = false;
            this.graphEnd.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphEnd.ColorBase = System.Drawing.Color.Blue;
            this.graphEnd.ColorEnh = System.Drawing.Color.Yellow;
            this.graphEnd.ColorFadeEnd = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(224)))));
            this.graphEnd.ColorFadeStart = System.Drawing.Color.Black;
            this.graphEnd.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphEnd.ColorLines = System.Drawing.Color.Black;
            this.graphEnd.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphEnd.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphEnd.ColorOvercap = System.Drawing.Color.Black;
            this.graphEnd.DifferentiateColors = true;
            this.graphEnd.Dual = true;
            this.graphEnd.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphEnd.EnhBarColors")));
            this.graphEnd.ForcedMax = 0F;
            this.graphEnd.Highlight = true;
            this.graphEnd.ItemHeight = 13;
            this.graphEnd.Lines = true;
            this.graphEnd.Location = new System.Drawing.Point(8, 608);
            this.graphEnd.MarkerValue = 0F;
            this.graphEnd.Max = 100F;
            this.graphEnd.MaxItems = 3;
            this.graphEnd.Name = "graphEnd";
            this.graphEnd.OuterBorder = true;
            this.graphEnd.Overcap = true;
            this.graphEnd.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphEnd.OvercapColors")));
            this.graphEnd.PaddingX = 4F;
            this.graphEnd.PaddingY = 6F;
            this.graphEnd.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphEnd.PerItemScales")));
            this.graphEnd.ScaleHeight = 32;
            this.graphEnd.ScaleIndex = 8;
            this.graphEnd.ShowScale = false;
            this.graphEnd.Size = new System.Drawing.Size(600, 62);
            this.graphEnd.Style = mrbBase.Enums.GraphStyle.Stacked;
            this.graphEnd.TabIndex = 108;
            this.graphEnd.TextWidth = 187;
            // 
            // graphHP
            // 
            this.graphHP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphHP.BackgroundImage")));
            this.graphHP.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphHP.BaseBarColors")));
            this.graphHP.Border = true;
            this.graphHP.BorderColor = System.Drawing.Color.PaleGreen;
            this.graphHP.Clickable = false;
            this.graphHP.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphHP.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(51)))));
            this.graphHP.ColorEnh = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(64)))));
            this.graphHP.ColorFadeEnd = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(251)))), ((int)(((byte)(150)))));
            this.graphHP.ColorFadeStart = System.Drawing.Color.Black;
            this.graphHP.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphHP.ColorLines = System.Drawing.Color.Black;
            this.graphHP.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphHP.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphHP.ColorOvercap = System.Drawing.Color.Black;
            this.graphHP.DifferentiateColors = true;
            this.graphHP.Dual = true;
            this.graphHP.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphHP.EnhBarColors")));
            this.graphHP.ForcedMax = 0F;
            this.graphHP.Highlight = true;
            this.graphHP.ItemHeight = 13;
            this.graphHP.Lines = true;
            this.graphHP.Location = new System.Drawing.Point(8, 511);
            this.graphHP.MarkerValue = 0F;
            this.graphHP.Max = 4000F;
            this.graphHP.MaxItems = 2;
            this.graphHP.Name = "graphHP";
            this.graphHP.OuterBorder = true;
            this.graphHP.Overcap = true;
            this.graphHP.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphHP.OvercapColors")));
            this.graphHP.PaddingX = 4F;
            this.graphHP.PaddingY = 6F;
            this.graphHP.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphHP.PerItemScales")));
            this.graphHP.ScaleHeight = 32;
            this.graphHP.ScaleIndex = 19;
            this.graphHP.ShowScale = false;
            this.graphHP.Size = new System.Drawing.Size(600, 46);
            this.graphHP.Style = mrbBase.Enums.GraphStyle.Stacked;
            this.graphHP.TabIndex = 107;
            this.graphHP.TabStop = false;
            this.graphHP.TextWidth = 187;
            // 
            // graphRes
            // 
            this.graphRes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphRes.BackgroundImage")));
            this.graphRes.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphRes.BaseBarColors")));
            this.graphRes.Border = true;
            this.graphRes.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.graphRes.Clickable = false;
            this.graphRes.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphRes.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.graphRes.ColorEnh = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.graphRes.ColorFadeEnd = System.Drawing.Color.LightSeaGreen;
            this.graphRes.ColorFadeStart = System.Drawing.Color.Black;
            this.graphRes.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphRes.ColorLines = System.Drawing.Color.Black;
            this.graphRes.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphRes.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphRes.ColorOvercap = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.graphRes.DifferentiateColors = false;
            this.graphRes.Dual = true;
            this.graphRes.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphRes.EnhBarColors")));
            this.graphRes.ForcedMax = 0F;
            this.graphRes.Highlight = true;
            this.graphRes.ItemHeight = 13;
            this.graphRes.Lines = true;
            this.graphRes.Location = new System.Drawing.Point(8, 305);
            this.graphRes.Margin = new System.Windows.Forms.Padding(4);
            this.graphRes.MarkerValue = 0F;
            this.graphRes.Max = 100F;
            this.graphRes.MaxItems = 8;
            this.graphRes.Name = "graphRes";
            this.graphRes.OuterBorder = true;
            this.graphRes.Overcap = true;
            this.graphRes.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphRes.OvercapColors")));
            this.graphRes.PaddingX = 4F;
            this.graphRes.PaddingY = 6F;
            this.graphRes.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphRes.PerItemScales")));
            this.graphRes.ScaleHeight = 32;
            this.graphRes.ScaleIndex = 8;
            this.graphRes.ShowScale = false;
            this.graphRes.Size = new System.Drawing.Size(600, 160);
            this.graphRes.Style = mrbBase.Enums.GraphStyle.Stacked;
            this.graphRes.TabIndex = 106;
            this.graphRes.TabStop = false;
            this.graphRes.TextWidth = 187;
            // 
            // graphDef
            // 
            this.graphDef.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphDef.BackgroundImage")));
            this.graphDef.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphDef.BaseBarColors")));
            this.graphDef.Border = true;
            this.graphDef.BorderColor = System.Drawing.Color.BlueViolet;
            this.graphDef.Clickable = false;
            this.graphDef.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphDef.ColorBase = System.Drawing.Color.Magenta;
            this.graphDef.ColorEnh = System.Drawing.Color.Magenta;
            this.graphDef.ColorFadeEnd = System.Drawing.Color.Purple;
            this.graphDef.ColorFadeStart = System.Drawing.Color.Black;
            this.graphDef.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphDef.ColorLines = System.Drawing.Color.Black;
            this.graphDef.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphDef.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphDef.ColorOvercap = System.Drawing.Color.Black;
            this.graphDef.DifferentiateColors = false;
            this.graphDef.Dual = true;
            this.graphDef.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphDef.EnhBarColors")));
            this.graphDef.ForcedMax = 0F;
            this.graphDef.Highlight = true;
            this.graphDef.ItemHeight = 13;
            this.graphDef.Lines = true;
            this.graphDef.Location = new System.Drawing.Point(8, 48);
            this.graphDef.Margin = new System.Windows.Forms.Padding(4);
            this.graphDef.MarkerValue = 0F;
            this.graphDef.Max = 100F;
            this.graphDef.MaxItems = 11;
            this.graphDef.Name = "graphDef";
            this.graphDef.OuterBorder = true;
            this.graphDef.Overcap = false;
            this.graphDef.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphDef.OvercapColors")));
            this.graphDef.PaddingX = 4F;
            this.graphDef.PaddingY = 6F;
            this.graphDef.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphDef.PerItemScales")));
            this.graphDef.ScaleHeight = 32;
            this.graphDef.ScaleIndex = 8;
            this.graphDef.ShowScale = false;
            this.graphDef.Size = new System.Drawing.Size(600, 217);
            this.graphDef.Style = mrbBase.Enums.GraphStyle.enhOnly;
            this.graphDef.TabIndex = 105;
            this.graphDef.TabStop = false;
            this.graphDef.TextWidth = 187;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 109;
            this.label1.Text = "Defense:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(12, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 110;
            this.label2.Text = "Resistance:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(12, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 111;
            this.label3.Text = "Health:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(12, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 112;
            this.label4.Text = "Endurance:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.radioButton4);
            this.tabPage2.Controls.Add(this.graphThreat);
            this.tabPage2.Controls.Add(this.graphEndRdx);
            this.tabPage2.Controls.Add(this.graphDamage);
            this.tabPage2.Controls.Add(this.graphAccuracy);
            this.tabPage2.Controls.Add(this.graphToHit);
            this.tabPage2.Controls.Add(this.graphHaste);
            this.tabPage2.Controls.Add(this.graphPerception);
            this.tabPage2.Controls.Add(this.graphMovement);
            this.tabPage2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(615, 741);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Misc Buffs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(12, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 112;
            this.label7.Text = "Misc:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(12, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 111;
            this.label6.Text = "Stealth:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 110;
            this.label5.Text = "Movement:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButton1.Location = new System.Drawing.Point(23, 137);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 23);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "MPH";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButton2.Location = new System.Drawing.Point(153, 137);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 23);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "KPH";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButton3.Location = new System.Drawing.Point(276, 137);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 23);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Feet/Sec";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButton4.Location = new System.Drawing.Point(421, 137);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(98, 23);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Meters/Sec";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // graphThreat
            // 
            this.graphThreat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphThreat.BackgroundImage")));
            this.graphThreat.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphThreat.BaseBarColors")));
            this.graphThreat.Border = true;
            this.graphThreat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.graphThreat.Clickable = false;
            this.graphThreat.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphThreat.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(86)))), ((int)(((byte)(168)))));
            this.graphThreat.ColorEnh = System.Drawing.Color.MediumPurple;
            this.graphThreat.ColorFadeEnd = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(61)))), ((int)(((byte)(137)))));
            this.graphThreat.ColorFadeStart = System.Drawing.Color.Black;
            this.graphThreat.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphThreat.ColorLines = System.Drawing.Color.Black;
            this.graphThreat.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphThreat.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphThreat.ColorOvercap = System.Drawing.Color.MediumPurple;
            this.graphThreat.DifferentiateColors = false;
            this.graphThreat.Dual = true;
            this.graphThreat.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphThreat.EnhBarColors")));
            this.graphThreat.ForcedMax = 0F;
            this.graphThreat.Highlight = true;
            this.graphThreat.ItemHeight = 13;
            this.graphThreat.Lines = true;
            this.graphThreat.Location = new System.Drawing.Point(8, 484);
            this.graphThreat.MarkerValue = 0F;
            this.graphThreat.Max = 600F;
            this.graphThreat.MaxItems = 1;
            this.graphThreat.Name = "graphThreat";
            this.graphThreat.OuterBorder = true;
            this.graphThreat.Overcap = false;
            this.graphThreat.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphThreat.OvercapColors")));
            this.graphThreat.PaddingX = 4F;
            this.graphThreat.PaddingY = 6F;
            this.graphThreat.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphThreat.PerItemScales")));
            this.graphThreat.ScaleHeight = 32;
            this.graphThreat.ScaleIndex = 13;
            this.graphThreat.ShowScale = false;
            this.graphThreat.Size = new System.Drawing.Size(600, 27);
            this.graphThreat.Style = mrbBase.Enums.GraphStyle.Stacked;
            this.graphThreat.TabIndex = 7;
            this.graphThreat.TextWidth = 187;
            // 
            // graphEndRdx
            // 
            this.graphEndRdx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphEndRdx.BackgroundImage")));
            this.graphEndRdx.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphEndRdx.BaseBarColors")));
            this.graphEndRdx.Border = true;
            this.graphEndRdx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(112)))), ((int)(((byte)(255)))));
            this.graphEndRdx.Clickable = false;
            this.graphEndRdx.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphEndRdx.ColorBase = System.Drawing.Color.RoyalBlue;
            this.graphEndRdx.ColorEnh = System.Drawing.Color.RoyalBlue;
            this.graphEndRdx.ColorFadeEnd = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(89)))), ((int)(((byte)(203)))));
            this.graphEndRdx.ColorFadeStart = System.Drawing.Color.Black;
            this.graphEndRdx.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphEndRdx.ColorLines = System.Drawing.Color.Black;
            this.graphEndRdx.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphEndRdx.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphEndRdx.ColorOvercap = System.Drawing.Color.RoyalBlue;
            this.graphEndRdx.DifferentiateColors = false;
            this.graphEndRdx.Dual = true;
            this.graphEndRdx.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphEndRdx.EnhBarColors")));
            this.graphEndRdx.ForcedMax = 0F;
            this.graphEndRdx.Highlight = true;
            this.graphEndRdx.ItemHeight = 13;
            this.graphEndRdx.Lines = true;
            this.graphEndRdx.Location = new System.Drawing.Point(8, 450);
            this.graphEndRdx.MarkerValue = 0F;
            this.graphEndRdx.Max = 100F;
            this.graphEndRdx.MaxItems = 1;
            this.graphEndRdx.Name = "graphEndRdx";
            this.graphEndRdx.OuterBorder = true;
            this.graphEndRdx.Overcap = false;
            this.graphEndRdx.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphEndRdx.OvercapColors")));
            this.graphEndRdx.PaddingX = 4F;
            this.graphEndRdx.PaddingY = 6F;
            this.graphEndRdx.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphEndRdx.PerItemScales")));
            this.graphEndRdx.ScaleHeight = 32;
            this.graphEndRdx.ScaleIndex = 8;
            this.graphEndRdx.ShowScale = false;
            this.graphEndRdx.Size = new System.Drawing.Size(600, 27);
            this.graphEndRdx.Style = mrbBase.Enums.GraphStyle.enhOnly;
            this.graphEndRdx.TabIndex = 6;
            this.graphEndRdx.TextWidth = 187;
            // 
            // graphDamage
            // 
            this.graphDamage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphDamage.BackgroundImage")));
            this.graphDamage.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphDamage.BaseBarColors")));
            this.graphDamage.Border = true;
            this.graphDamage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.graphDamage.Clickable = false;
            this.graphDamage.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphDamage.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.graphDamage.ColorEnh = System.Drawing.Color.Red;
            this.graphDamage.ColorFadeEnd = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.graphDamage.ColorFadeStart = System.Drawing.Color.Black;
            this.graphDamage.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphDamage.ColorLines = System.Drawing.Color.Black;
            this.graphDamage.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphDamage.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphDamage.ColorOvercap = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.graphDamage.DifferentiateColors = false;
            this.graphDamage.Dual = true;
            this.graphDamage.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphDamage.EnhBarColors")));
            this.graphDamage.ForcedMax = 0F;
            this.graphDamage.Highlight = true;
            this.graphDamage.ItemHeight = 13;
            this.graphDamage.Lines = true;
            this.graphDamage.Location = new System.Drawing.Point(8, 416);
            this.graphDamage.MarkerValue = 0F;
            this.graphDamage.Max = 900F;
            this.graphDamage.MaxItems = 1;
            this.graphDamage.Name = "graphDamage";
            this.graphDamage.OuterBorder = true;
            this.graphDamage.Overcap = true;
            this.graphDamage.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphDamage.OvercapColors")));
            this.graphDamage.PaddingX = 4F;
            this.graphDamage.PaddingY = 6F;
            this.graphDamage.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphDamage.PerItemScales")));
            this.graphDamage.ScaleHeight = 32;
            this.graphDamage.ScaleIndex = 14;
            this.graphDamage.ShowScale = false;
            this.graphDamage.Size = new System.Drawing.Size(600, 27);
            this.graphDamage.Style = mrbBase.Enums.GraphStyle.Stacked;
            this.graphDamage.TabIndex = 5;
            this.graphDamage.TextWidth = 187;
            // 
            // graphAccuracy
            // 
            this.graphAccuracy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphAccuracy.BackgroundImage")));
            this.graphAccuracy.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphAccuracy.BaseBarColors")));
            this.graphAccuracy.Border = true;
            this.graphAccuracy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.graphAccuracy.Clickable = false;
            this.graphAccuracy.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphAccuracy.ColorBase = System.Drawing.Color.Yellow;
            this.graphAccuracy.ColorEnh = System.Drawing.Color.Yellow;
            this.graphAccuracy.ColorFadeEnd = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(0)))));
            this.graphAccuracy.ColorFadeStart = System.Drawing.Color.Black;
            this.graphAccuracy.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphAccuracy.ColorLines = System.Drawing.Color.Black;
            this.graphAccuracy.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphAccuracy.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphAccuracy.ColorOvercap = System.Drawing.Color.Yellow;
            this.graphAccuracy.DifferentiateColors = false;
            this.graphAccuracy.Dual = true;
            this.graphAccuracy.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphAccuracy.EnhBarColors")));
            this.graphAccuracy.ForcedMax = 0F;
            this.graphAccuracy.Highlight = true;
            this.graphAccuracy.ItemHeight = 13;
            this.graphAccuracy.Lines = true;
            this.graphAccuracy.Location = new System.Drawing.Point(8, 382);
            this.graphAccuracy.MarkerValue = 0F;
            this.graphAccuracy.Max = 100F;
            this.graphAccuracy.MaxItems = 1;
            this.graphAccuracy.Name = "graphAccuracy";
            this.graphAccuracy.OuterBorder = true;
            this.graphAccuracy.Overcap = false;
            this.graphAccuracy.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphAccuracy.OvercapColors")));
            this.graphAccuracy.PaddingX = 4F;
            this.graphAccuracy.PaddingY = 6F;
            this.graphAccuracy.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphAccuracy.PerItemScales")));
            this.graphAccuracy.ScaleHeight = 32;
            this.graphAccuracy.ScaleIndex = 8;
            this.graphAccuracy.ShowScale = false;
            this.graphAccuracy.Size = new System.Drawing.Size(600, 27);
            this.graphAccuracy.Style = mrbBase.Enums.GraphStyle.enhOnly;
            this.graphAccuracy.TabIndex = 4;
            this.graphAccuracy.TextWidth = 187;
            // 
            // graphToHit
            // 
            this.graphToHit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphToHit.BackgroundImage")));
            this.graphToHit.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphToHit.BaseBarColors")));
            this.graphToHit.Border = true;
            this.graphToHit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.graphToHit.Clickable = false;
            this.graphToHit.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphToHit.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.graphToHit.ColorEnh = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.graphToHit.ColorFadeEnd = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.graphToHit.ColorFadeStart = System.Drawing.Color.Black;
            this.graphToHit.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphToHit.ColorLines = System.Drawing.Color.Black;
            this.graphToHit.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphToHit.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphToHit.ColorOvercap = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.graphToHit.DifferentiateColors = false;
            this.graphToHit.Dual = true;
            this.graphToHit.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphToHit.EnhBarColors")));
            this.graphToHit.ForcedMax = 0F;
            this.graphToHit.Highlight = true;
            this.graphToHit.ItemHeight = 13;
            this.graphToHit.Lines = true;
            this.graphToHit.Location = new System.Drawing.Point(8, 348);
            this.graphToHit.MarkerValue = 0F;
            this.graphToHit.Max = 100F;
            this.graphToHit.MaxItems = 1;
            this.graphToHit.Name = "graphToHit";
            this.graphToHit.OuterBorder = true;
            this.graphToHit.Overcap = false;
            this.graphToHit.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphToHit.OvercapColors")));
            this.graphToHit.PaddingX = 4F;
            this.graphToHit.PaddingY = 6F;
            this.graphToHit.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphToHit.PerItemScales")));
            this.graphToHit.ScaleHeight = 32;
            this.graphToHit.ScaleIndex = 8;
            this.graphToHit.ShowScale = false;
            this.graphToHit.Size = new System.Drawing.Size(600, 27);
            this.graphToHit.Style = mrbBase.Enums.GraphStyle.enhOnly;
            this.graphToHit.TabIndex = 3;
            this.graphToHit.TextWidth = 187;
            // 
            // graphHaste
            // 
            this.graphHaste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphHaste.BackgroundImage")));
            this.graphHaste.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphHaste.BaseBarColors")));
            this.graphHaste.Border = true;
            this.graphHaste.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.graphHaste.Clickable = false;
            this.graphHaste.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphHaste.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.graphHaste.ColorEnh = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.graphHaste.ColorFadeEnd = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(62)))), ((int)(((byte)(0)))));
            this.graphHaste.ColorFadeStart = System.Drawing.Color.Black;
            this.graphHaste.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphHaste.ColorLines = System.Drawing.Color.Black;
            this.graphHaste.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphHaste.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphHaste.ColorOvercap = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(56)))), ((int)(((byte)(0)))));
            this.graphHaste.DifferentiateColors = false;
            this.graphHaste.Dual = true;
            this.graphHaste.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphHaste.EnhBarColors")));
            this.graphHaste.ForcedMax = 0F;
            this.graphHaste.Highlight = true;
            this.graphHaste.ItemHeight = 13;
            this.graphHaste.Lines = true;
            this.graphHaste.Location = new System.Drawing.Point(8, 314);
            this.graphHaste.MarkerValue = 0F;
            this.graphHaste.Max = 450F;
            this.graphHaste.MaxItems = 1;
            this.graphHaste.Name = "graphHaste";
            this.graphHaste.OuterBorder = true;
            this.graphHaste.Overcap = true;
            this.graphHaste.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphHaste.OvercapColors")));
            this.graphHaste.PaddingX = 4F;
            this.graphHaste.PaddingY = 6F;
            this.graphHaste.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphHaste.PerItemScales")));
            this.graphHaste.ScaleHeight = 32;
            this.graphHaste.ScaleIndex = 12;
            this.graphHaste.ShowScale = false;
            this.graphHaste.Size = new System.Drawing.Size(600, 27);
            this.graphHaste.Style = mrbBase.Enums.GraphStyle.Stacked;
            this.graphHaste.TabIndex = 2;
            this.graphHaste.TextWidth = 187;
            // 
            // graphPerception
            // 
            this.graphPerception.BackColor = System.Drawing.Color.Black;
            this.graphPerception.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphPerception.BackgroundImage")));
            this.graphPerception.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphPerception.BaseBarColors")));
            this.graphPerception.Border = true;
            this.graphPerception.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(104)))), ((int)(((byte)(237)))));
            this.graphPerception.Clickable = false;
            this.graphPerception.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphPerception.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(95)))), ((int)(((byte)(107)))));
            this.graphPerception.ColorEnh = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(121)))), ((int)(((byte)(136)))));
            this.graphPerception.ColorFadeEnd = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(61)))), ((int)(((byte)(137)))));
            this.graphPerception.ColorFadeStart = System.Drawing.Color.Black;
            this.graphPerception.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphPerception.ColorLines = System.Drawing.Color.Black;
            this.graphPerception.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphPerception.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphPerception.ColorOvercap = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.graphPerception.DifferentiateColors = false;
            this.graphPerception.Dual = true;
            this.graphPerception.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphPerception.EnhBarColors")));
            this.graphPerception.ForcedMax = 0F;
            this.graphPerception.Highlight = true;
            this.graphPerception.ItemHeight = 13;
            this.graphPerception.Lines = true;
            this.graphPerception.Location = new System.Drawing.Point(8, 202);
            this.graphPerception.MarkerValue = 0F;
            this.graphPerception.Max = 1200F;
            this.graphPerception.MaxItems = 3;
            this.graphPerception.Name = "graphPerception";
            this.graphPerception.OuterBorder = true;
            this.graphPerception.Overcap = true;
            this.graphPerception.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphPerception.OvercapColors")));
            this.graphPerception.PaddingX = 4F;
            this.graphPerception.PaddingY = 6F;
            this.graphPerception.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphPerception.PerItemScales")));
            this.graphPerception.ScaleHeight = 32;
            this.graphPerception.ScaleIndex = 15;
            this.graphPerception.ShowScale = false;
            this.graphPerception.Size = new System.Drawing.Size(600, 64);
            this.graphPerception.Style = mrbBase.Enums.GraphStyle.Stacked;
            this.graphPerception.TabIndex = 1;
            this.graphPerception.TextWidth = 187;
            // 
            // graphMovement
            // 
            this.graphMovement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphMovement.BackgroundImage")));
            this.graphMovement.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphMovement.BaseBarColors")));
            this.graphMovement.Border = true;
            this.graphMovement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(170)))));
            this.graphMovement.Clickable = false;
            this.graphMovement.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphMovement.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(94)))));
            this.graphMovement.ColorEnh = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.graphMovement.ColorFadeEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(95)))));
            this.graphMovement.ColorFadeStart = System.Drawing.Color.Black;
            this.graphMovement.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphMovement.ColorLines = System.Drawing.Color.Black;
            this.graphMovement.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphMovement.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphMovement.ColorOvercap = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(32)))));
            this.graphMovement.DifferentiateColors = false;
            this.graphMovement.Dual = true;
            this.graphMovement.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphMovement.EnhBarColors")));
            this.graphMovement.ForcedMax = 0F;
            this.graphMovement.Highlight = true;
            this.graphMovement.ItemHeight = 13;
            this.graphMovement.Lines = true;
            this.graphMovement.Location = new System.Drawing.Point(8, 47);
            this.graphMovement.MarkerValue = 0F;
            this.graphMovement.Max = 225F;
            this.graphMovement.MaxItems = 4;
            this.graphMovement.Name = "graphMovement";
            this.graphMovement.OuterBorder = true;
            this.graphMovement.Overcap = true;
            this.graphMovement.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphMovement.OvercapColors")));
            this.graphMovement.PaddingX = 4F;
            this.graphMovement.PaddingY = 6F;
            this.graphMovement.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphMovement.PerItemScales")));
            this.graphMovement.ScaleHeight = 32;
            this.graphMovement.ScaleIndex = 10;
            this.graphMovement.ShowScale = false;
            this.graphMovement.Size = new System.Drawing.Size(600, 82);
            this.graphMovement.Style = mrbBase.Enums.GraphStyle.Stacked;
            this.graphMovement.TabIndex = 0;
            this.graphMovement.TextWidth = 187;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.graphStatusRes);
            this.tabPage3.Controls.Add(this.graphStatusProt);
            this.tabPage3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(615, 741);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Status Protection";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(12, 301);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 113;
            this.label9.Text = "Status Resistance:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(12, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 112;
            this.label8.Text = "Status Protection:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // graphStatusRes
            // 
            this.graphStatusRes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphStatusRes.BackgroundImage")));
            this.graphStatusRes.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphStatusRes.BaseBarColors")));
            this.graphStatusRes.Border = true;
            this.graphStatusRes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(0)))));
            this.graphStatusRes.Clickable = false;
            this.graphStatusRes.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphStatusRes.ColorBase = System.Drawing.Color.Yellow;
            this.graphStatusRes.ColorEnh = System.Drawing.Color.Yellow;
            this.graphStatusRes.ColorFadeEnd = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.graphStatusRes.ColorFadeStart = System.Drawing.Color.Black;
            this.graphStatusRes.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphStatusRes.ColorLines = System.Drawing.Color.Black;
            this.graphStatusRes.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphStatusRes.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphStatusRes.ColorOvercap = System.Drawing.Color.Yellow;
            this.graphStatusRes.DifferentiateColors = false;
            this.graphStatusRes.Dual = true;
            this.graphStatusRes.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphStatusRes.EnhBarColors")));
            this.graphStatusRes.ForcedMax = 0F;
            this.graphStatusRes.Highlight = true;
            this.graphStatusRes.ItemHeight = 13;
            this.graphStatusRes.Lines = false;
            this.graphStatusRes.Location = new System.Drawing.Point(8, 327);
            this.graphStatusRes.MarkerValue = 0F;
            this.graphStatusRes.Max = 600F;
            this.graphStatusRes.MaxItems = 11;
            this.graphStatusRes.Name = "graphStatusRes";
            this.graphStatusRes.OuterBorder = true;
            this.graphStatusRes.Overcap = false;
            this.graphStatusRes.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphStatusRes.OvercapColors")));
            this.graphStatusRes.PaddingX = 4F;
            this.graphStatusRes.PaddingY = 6F;
            this.graphStatusRes.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphStatusRes.PerItemScales")));
            this.graphStatusRes.ScaleHeight = 32;
            this.graphStatusRes.ScaleIndex = 13;
            this.graphStatusRes.ShowScale = false;
            this.graphStatusRes.Size = new System.Drawing.Size(600, 218);
            this.graphStatusRes.Style = mrbBase.Enums.GraphStyle.enhOnly;
            this.graphStatusRes.TabIndex = 1;
            this.graphStatusRes.TabStop = false;
            this.graphStatusRes.TextWidth = 187;
            // 
            // graphStatusProt
            // 
            this.graphStatusProt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphStatusProt.BackgroundImage")));
            this.graphStatusProt.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphStatusProt.BaseBarColors")));
            this.graphStatusProt.Border = true;
            this.graphStatusProt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            this.graphStatusProt.Clickable = false;
            this.graphStatusProt.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphStatusProt.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.graphStatusProt.ColorEnh = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.graphStatusProt.ColorFadeEnd = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.graphStatusProt.ColorFadeStart = System.Drawing.Color.Black;
            this.graphStatusProt.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphStatusProt.ColorLines = System.Drawing.Color.Black;
            this.graphStatusProt.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphStatusProt.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphStatusProt.ColorOvercap = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.graphStatusProt.DifferentiateColors = false;
            this.graphStatusProt.Dual = true;
            this.graphStatusProt.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphStatusProt.EnhBarColors")));
            this.graphStatusProt.ForcedMax = 0F;
            this.graphStatusProt.Highlight = true;
            this.graphStatusProt.ItemHeight = 13;
            this.graphStatusProt.Lines = false;
            this.graphStatusProt.Location = new System.Drawing.Point(8, 47);
            this.graphStatusProt.MarkerValue = 0F;
            this.graphStatusProt.Max = 50F;
            this.graphStatusProt.MaxItems = 11;
            this.graphStatusProt.Name = "graphStatusProt";
            this.graphStatusProt.OuterBorder = true;
            this.graphStatusProt.Overcap = false;
            this.graphStatusProt.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphStatusProt.OvercapColors")));
            this.graphStatusProt.PaddingX = 4F;
            this.graphStatusProt.PaddingY = 6F;
            this.graphStatusProt.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphStatusProt.PerItemScales")));
            this.graphStatusProt.ScaleHeight = 32;
            this.graphStatusProt.ScaleIndex = 6;
            this.graphStatusProt.ShowScale = false;
            this.graphStatusProt.Size = new System.Drawing.Size(600, 218);
            this.graphStatusProt.Style = mrbBase.Enums.GraphStyle.enhOnly;
            this.graphStatusProt.TabIndex = 0;
            this.graphStatusProt.TabStop = false;
            this.graphStatusProt.TextWidth = 187;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.graphElusivity);
            this.tabPage4.Controls.Add(this.graphDebuffRes);
            this.tabPage4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(615, 741);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Debuff Resistances";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(12, 304);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 114;
            this.label11.Text = "Elusivity:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(12, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 20);
            this.label10.TabIndex = 113;
            this.label10.Text = "Debuff Resistance:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // graphElusivity
            // 
            this.graphElusivity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphElusivity.BackgroundImage")));
            this.graphElusivity.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphElusivity.BaseBarColors")));
            this.graphElusivity.Border = true;
            this.graphElusivity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(1)))), ((int)(((byte)(255)))));
            this.graphElusivity.Clickable = false;
            this.graphElusivity.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphElusivity.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(1)))), ((int)(((byte)(231)))));
            this.graphElusivity.ColorEnh = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(1)))), ((int)(((byte)(231)))));
            this.graphElusivity.ColorFadeEnd = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(2)))), ((int)(((byte)(200)))));
            this.graphElusivity.ColorFadeStart = System.Drawing.Color.Black;
            this.graphElusivity.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphElusivity.ColorLines = System.Drawing.Color.Black;
            this.graphElusivity.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphElusivity.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphElusivity.ColorOvercap = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(1)))), ((int)(((byte)(231)))));
            this.graphElusivity.DifferentiateColors = false;
            this.graphElusivity.Dual = true;
            this.graphElusivity.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphElusivity.EnhBarColors")));
            this.graphElusivity.ForcedMax = 0F;
            this.graphElusivity.Highlight = true;
            this.graphElusivity.ItemHeight = 13;
            this.graphElusivity.Lines = true;
            this.graphElusivity.Location = new System.Drawing.Point(8, 330);
            this.graphElusivity.MarkerValue = 0F;
            this.graphElusivity.Max = 100F;
            this.graphElusivity.MaxItems = 60;
            this.graphElusivity.Name = "graphElusivity";
            this.graphElusivity.OuterBorder = true;
            this.graphElusivity.Overcap = false;
            this.graphElusivity.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphElusivity.OvercapColors")));
            this.graphElusivity.PaddingX = 10F;
            this.graphElusivity.PaddingY = 6F;
            this.graphElusivity.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphElusivity.PerItemScales")));
            this.graphElusivity.ScaleHeight = 32;
            this.graphElusivity.ScaleIndex = 8;
            this.graphElusivity.ShowScale = false;
            this.graphElusivity.Size = new System.Drawing.Size(600, 235);
            this.graphElusivity.Style = mrbBase.Enums.GraphStyle.baseOnly;
            this.graphElusivity.TabIndex = 2;
            this.graphElusivity.TabStop = false;
            this.graphElusivity.TextWidth = 187;
            // 
            // graphDebuffRes
            // 
            this.graphDebuffRes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphDebuffRes.BackgroundImage")));
            this.graphDebuffRes.BaseBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphDebuffRes.BaseBarColors")));
            this.graphDebuffRes.Border = true;
            this.graphDebuffRes.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.graphDebuffRes.Clickable = false;
            this.graphDebuffRes.ColorAbsorbed = System.Drawing.Color.Gainsboro;
            this.graphDebuffRes.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.graphDebuffRes.ColorEnh = System.Drawing.Color.Cyan;
            this.graphDebuffRes.ColorFadeEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.graphDebuffRes.ColorFadeStart = System.Drawing.Color.Black;
            this.graphDebuffRes.ColorHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.graphDebuffRes.ColorLines = System.Drawing.Color.Black;
            this.graphDebuffRes.ColorMarkerInner = System.Drawing.Color.Black;
            this.graphDebuffRes.ColorMarkerOuter = System.Drawing.Color.Yellow;
            this.graphDebuffRes.ColorOvercap = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(127)))));
            this.graphDebuffRes.DifferentiateColors = false;
            this.graphDebuffRes.Dual = true;
            this.graphDebuffRes.EnhBarColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphDebuffRes.EnhBarColors")));
            this.graphDebuffRes.ForcedMax = 0F;
            this.graphDebuffRes.Highlight = true;
            this.graphDebuffRes.ItemHeight = 13;
            this.graphDebuffRes.Lines = true;
            this.graphDebuffRes.Location = new System.Drawing.Point(8, 46);
            this.graphDebuffRes.MarkerValue = 0F;
            this.graphDebuffRes.Max = 100F;
            this.graphDebuffRes.MaxItems = 8;
            this.graphDebuffRes.Name = "graphDebuffRes";
            this.graphDebuffRes.OuterBorder = true;
            this.graphDebuffRes.Overcap = true;
            this.graphDebuffRes.OvercapColors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("graphDebuffRes.OvercapColors")));
            this.graphDebuffRes.PaddingX = 4F;
            this.graphDebuffRes.PaddingY = 6F;
            this.graphDebuffRes.PerItemScales = ((System.Collections.Generic.List<float>)(resources.GetObject("graphDebuffRes.PerItemScales")));
            this.graphDebuffRes.ScaleHeight = 32;
            this.graphDebuffRes.ScaleIndex = 8;
            this.graphDebuffRes.ShowScale = false;
            this.graphDebuffRes.Size = new System.Drawing.Size(600, 160);
            this.graphDebuffRes.Style = mrbBase.Enums.GraphStyle.Stacked;
            this.graphDebuffRes.TabIndex = 1;
            this.graphDebuffRes.TabStop = false;
            this.graphDebuffRes.TextWidth = 187;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ctlTotalsTabStrip1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 846);
            this.panel1.TabIndex = 100;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pbClose);
            this.panel2.Controls.Add(this.pbTopMost);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 802);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 44);
            this.panel2.TabIndex = 2;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Location = new System.Drawing.Point(488, 8);
            this.pbClose.Margin = new System.Windows.Forms.Padding(4);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(122, 27);
            this.pbClose.TabIndex = 107;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.PbCloseClick);
            this.pbClose.Paint += new System.Windows.Forms.PaintEventHandler(this.PbClosePaint);
            // 
            // pbTopMost
            // 
            this.pbTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbTopMost.BackColor = System.Drawing.Color.Transparent;
            this.pbTopMost.Location = new System.Drawing.Point(10, 8);
            this.pbTopMost.Margin = new System.Windows.Forms.Padding(4);
            this.pbTopMost.Name = "pbTopMost";
            this.pbTopMost.Size = new System.Drawing.Size(122, 27);
            this.pbTopMost.TabIndex = 108;
            this.pbTopMost.TabStop = false;
            this.pbTopMost.Click += new System.EventHandler(this.PbTopMostClick);
            this.pbTopMost.Paint += new System.Windows.Forms.PaintEventHandler(this.PbTopMostPaint);
            // 
            // ctlTotalsTabStrip1
            // 
            this.ctlTotalsTabStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctlTotalsTabStrip1.BackgroundImage")));
            this.ctlTotalsTabStrip1.ColorActiveTab = System.Drawing.Color.Goldenrod;
            this.ctlTotalsTabStrip1.ColorInactiveHoveredTab = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(122)))), ((int)(((byte)(187)))));
            this.ctlTotalsTabStrip1.ColorInactiveTab = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.ctlTotalsTabStrip1.ColorStripLine = System.Drawing.Color.Goldenrod;
            this.ctlTotalsTabStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlTotalsTabStrip1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ctlTotalsTabStrip1.ItemPadding = 18;
            this.ctlTotalsTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.ctlTotalsTabStrip1.Name = "ctlTotalsTabStrip1";
            this.ctlTotalsTabStrip1.OutlineText = true;
            this.ctlTotalsTabStrip1.Size = new System.Drawing.Size(620, 24);
            this.ctlTotalsTabStrip1.TabIndex = 0;
            this.ctlTotalsTabStrip1.TabClick += new mrbControls.ctlTotalsTabStrip.TabClickEventHandler(this.ctlTotalsTabStrip1_TabClick);
            // 
            // frmTotalsV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(620, 846);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(636, 885);
            this.Name = "frmTotalsV2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Totals for Self";
            this.TopMost = true;
            this.Move += new System.EventHandler(this.frmTotalsV2_Move);
            this.Resize += new System.EventHandler(this.frmTotalsV2_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopMost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TabControl tabControl1;
        private ctlTotalsTabStrip ctlTotalsTabStrip1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private PictureBox pbClose;
        private PictureBox pbTopMost;
        private ctlMultiGraph graphEnd;
        private ctlMultiGraph graphHP;
        private ctlMultiGraph graphRes;
        private ctlMultiGraph graphDef;
        private ctlMultiGraph graphPerception;
        private ctlMultiGraph graphMovement;
        private ctlMultiGraph graphToHit;
        private ctlMultiGraph graphHaste;
        private ctlMultiGraph graphAccuracy;
        private ctlMultiGraph graphThreat;
        private ctlMultiGraph graphEndRdx;
        private ctlMultiGraph graphDamage;
        private ctlMultiGraph graphStatusProt;
        private ctlMultiGraph graphStatusRes;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label8;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private ctlMultiGraph graphDebuffRes;
        private ctlMultiGraph graphElusivity;
        private Label label11;
        private Label label10;
    }
}