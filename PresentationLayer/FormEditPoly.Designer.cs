namespace PresentationLayer
{
    partial class FormEditPoly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditPoly));
            this.polyNameBox = new System.Windows.Forms.TextBox();
            this.polyOpisBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancelPolyEdit = new System.Windows.Forms.Button();
            this.buttonUredu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // polyNameBox
            // 
            this.polyNameBox.Location = new System.Drawing.Point(99, 95);
            this.polyNameBox.Name = "polyNameBox";
            this.polyNameBox.Size = new System.Drawing.Size(229, 20);
            this.polyNameBox.TabIndex = 17;
            // 
            // polyOpisBox
            // 
            this.polyOpisBox.Location = new System.Drawing.Point(99, 149);
            this.polyOpisBox.Name = "polyOpisBox";
            this.polyOpisBox.Size = new System.Drawing.Size(229, 67);
            this.polyOpisBox.TabIndex = 16;
            this.polyOpisBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Opis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Naziv";
            // 
            // buttonCancelPolyEdit
            // 
            this.buttonCancelPolyEdit.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCancelPolyEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelPolyEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancelPolyEdit.Location = new System.Drawing.Point(218, 259);
            this.buttonCancelPolyEdit.Name = "buttonCancelPolyEdit";
            this.buttonCancelPolyEdit.Size = new System.Drawing.Size(110, 37);
            this.buttonCancelPolyEdit.TabIndex = 13;
            this.buttonCancelPolyEdit.Text = "Odustani";
            this.buttonCancelPolyEdit.UseVisualStyleBackColor = false;
            this.buttonCancelPolyEdit.Click += new System.EventHandler(this.buttonCancelPolyEdit_Click);
            // 
            // buttonUredu
            // 
            this.buttonUredu.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonUredu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUredu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonUredu.Location = new System.Drawing.Point(99, 259);
            this.buttonUredu.Name = "buttonUredu";
            this.buttonUredu.Size = new System.Drawing.Size(105, 37);
            this.buttonUredu.TabIndex = 12;
            this.buttonUredu.Text = "U redu";
            this.buttonUredu.UseVisualStyleBackColor = false;
            this.buttonUredu.Click += new System.EventHandler(this.buttonUredu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(94, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 29);
            this.label10.TabIndex = 11;
            this.label10.Text = "Detalji poligona";
            // 
            // FormEditPoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(417, 316);
            this.Controls.Add(this.polyNameBox);
            this.Controls.Add(this.polyOpisBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelPolyEdit);
            this.Controls.Add(this.buttonUredu);
            this.Controls.Add(this.label10);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditPoly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uredi poligon";
            this.Load += new System.EventHandler(this.FormEditPoly_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox polyNameBox;
        private System.Windows.Forms.RichTextBox polyOpisBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancelPolyEdit;
        private System.Windows.Forms.Button buttonUredu;
        private System.Windows.Forms.Label label10;
    }
}