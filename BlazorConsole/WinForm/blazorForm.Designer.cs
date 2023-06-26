namespace WinForm
{
    partial class blazorForm
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
            blazorView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)blazorView).BeginInit();
            SuspendLayout();
            // 
            // blazorView
            // 
            blazorView.AllowExternalDrop = true;
            blazorView.CreationProperties = null;
            blazorView.DefaultBackgroundColor = Color.White;
            blazorView.Dock = DockStyle.Fill;
            blazorView.Location = new Point(0, 0);
            blazorView.Name = "blazorView";
            blazorView.Size = new Size(800, 450);
            blazorView.TabIndex = 0;
            blazorView.ZoomFactor = 1D;
            // 
            // blazorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(blazorView);
            Name = "blazorForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)blazorView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 blazorView;
    }
}