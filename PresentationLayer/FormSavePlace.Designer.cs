namespace PresentationLayer
{
    partial class FormSavePlace
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
            this.label10 = new System.Windows.Forms.Label();
            this.buttonUredu = new System.Windows.Forms.Button();
            this.buttonCancelAdd = new System.Windows.Forms.Button();
            this.placeOpisBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(49, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(336, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "Želite spremiti lokaciju?";
            // 
            // buttonUredu
            // 
            this.buttonUredu.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonUredu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUredu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonUredu.Location = new System.Drawing.Point(73, 188);
            this.buttonUredu.Name = "buttonUredu";
            this.buttonUredu.Size = new System.Drawing.Size(105, 37);
            this.buttonUredu.TabIndex = 2;
            this.buttonUredu.Text = "U redu";
            this.buttonUredu.UseVisualStyleBackColor = false;
            this.buttonUredu.Click += new System.EventHandler(this.buttonUredu_Click);
            // 
            // buttonCancelAdd
            // 
            this.buttonCancelAdd.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCancelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancelAdd.Location = new System.Drawing.Point(253, 188);
            this.buttonCancelAdd.Name = "buttonCancelAdd";
            this.buttonCancelAdd.Size = new System.Drawing.Size(110, 34);
            this.buttonCancelAdd.TabIndex = 3;
            this.buttonCancelAdd.Text = "Odustani";
            this.buttonCancelAdd.UseVisualStyleBackColor = false;
            this.buttonCancelAdd.Click += new System.EventHandler(this.buttonCancelAdd_Click);
            // 
            // placeOpisBox
            // 
            this.placeOpisBox.Location = new System.Drawing.Point(99, 88);
            this.placeOpisBox.Name = "placeOpisBox";
            this.placeOpisBox.Size = new System.Drawing.Size(229, 67);
            this.placeOpisBox.TabIndex = 20;
            this.placeOpisBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Opis";
            // 
            // FormSavePlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(440, 241);
            this.Controls.Add(this.placeOpisBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancelAdd);
            this.Controls.Add(this.buttonUredu);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(456, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(456, 280);
            this.Name = "FormSavePlace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSavePlace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonUredu;
        private System.Windows.Forms.Button buttonCancelAdd;
        private System.Windows.Forms.RichTextBox placeOpisBox;
        private System.Windows.Forms.Label label3;
    }
}