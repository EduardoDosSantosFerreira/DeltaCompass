﻿namespace DeltaCompass
{
    partial class FormPaginaPerfil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidebarControl1 = new SidebarControl();
            SuspendLayout();
            // 
            // sidebarControl1
            // 
            sidebarControl1.BackColor = Color.FromArgb(28, 28, 28);
            sidebarControl1.Dock = DockStyle.Left;
            sidebarControl1.Location = new Point(0, 0);
            sidebarControl1.MaximumSize = new Size(272, 456);
            sidebarControl1.MinimumSize = new Size(48, 456);
            sidebarControl1.Name = "sidebarControl1";
            sidebarControl1.Size = new Size(272, 456);
            sidebarControl1.TabIndex = 0;
            // 
            // FormPaginaPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(800, 450);
            Controls.Add(sidebarControl1);
            Name = "FormPaginaPerfil";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private SidebarControl sidebarControl1;
    }
}
