﻿namespace Mids_Reborn.Controls
{
    partial class PairedListEx
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
            components = new System.ComponentModel.Container();
            this.myTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            //
            // myTip
            //
            this.myTip.AutoPopDelay = 15000;
            this.myTip.InitialDelay = 350;
            this.myTip.ReshowDelay = 100;
            // 
            // PairedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "PairedListEx";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolTip myTip;
    }
}