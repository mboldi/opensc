﻿namespace OpenSC.GUI.Carousels
{
    partial class CarouselSyncGroupList
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
            this.components = new System.ComponentModel.Container();
            this.addableRouterTypesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.topPanel.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // addableRouterTypesMenu
            // 
            this.addableRouterTypesMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.addableRouterTypesMenu.Name = "addableVtrTypesMenu";
            this.addableRouterTypesMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // CarouselList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.HeaderText = "List of labelsets";
            this.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.Name = "CarouselList";
            this.Text = "List of labelsets";
            this.Controls.SetChildIndex(this.mainContainer, 0);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip addableRouterTypesMenu;
    }
}