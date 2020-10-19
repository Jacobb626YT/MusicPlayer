namespace Music
{
    partial class Music
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            this.Stop = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Play = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Stop
            // 
            resources.ApplyResources(this.Stop, "Stop");
            this.Stop.Depth = 0;
            this.Stop.DrawShadows = true;
            this.Stop.HighEmphasis = true;
            this.Stop.Icon = null;
            this.Stop.MouseState = MaterialSkin.MouseState.HOVER;
            this.Stop.Name = "Stop";
            this.Stop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Stop.UseAccentColor = false;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // Play
            // 
            resources.ApplyResources(this.Play, "Play");
            this.Play.Depth = 0;
            this.Play.DrawShadows = true;
            this.Play.HighEmphasis = true;
            this.Play.Icon = null;
            this.Play.MouseState = MaterialSkin.MouseState.HOVER;
            this.Play.Name = "Play";
            this.Play.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Play.UseAccentColor = false;
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Music
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Play);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.Stop);
            this.Name = "Music";
            this.Sizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton Stop;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton Play;
    }
}

