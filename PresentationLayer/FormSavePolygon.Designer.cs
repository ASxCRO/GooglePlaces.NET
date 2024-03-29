﻿namespace PresentationLayer
{
    partial class FormSavePolygon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSavePolygon));
            this.buttonCancelAdd = new System.Windows.Forms.Button();
            this.buttonUredu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nazivPoligonaTextBox = new System.Windows.Forms.TextBox();
            this.opisPoligonaTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonCancelAdd
            // 
            this.buttonCancelAdd.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCancelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancelAdd.Location = new System.Drawing.Point(284, 224);
            this.buttonCancelAdd.Name = "buttonCancelAdd";
            this.buttonCancelAdd.Size = new System.Drawing.Size(110, 37);
            this.buttonCancelAdd.TabIndex = 6;
            this.buttonCancelAdd.Text = "Odustani";
            this.buttonCancelAdd.UseVisualStyleBackColor = false;
            this.buttonCancelAdd.Click += new System.EventHandler(this.buttonCancelAdd_Click);
            // 
            // buttonUredu
            // 
            this.buttonUredu.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonUredu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUredu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonUredu.Location = new System.Drawing.Point(173, 224);
            this.buttonUredu.Name = "buttonUredu";
            this.buttonUredu.Size = new System.Drawing.Size(105, 37);
            this.buttonUredu.TabIndex = 5;
            this.buttonUredu.Text = "U redu";
            this.buttonUredu.UseVisualStyleBackColor = false;
            this.buttonUredu.Click += new System.EventHandler(this.buttonUredu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(73, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(330, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "Želite spremiti poligon?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Opis:";
            // 
            // nazivPoligonaTextBox
            // 
            this.nazivPoligonaTextBox.Location = new System.Drawing.Point(115, 94);
            this.nazivPoligonaTextBox.Name = "nazivPoligonaTextBox";
            this.nazivPoligonaTextBox.Size = new System.Drawing.Size(279, 20);
            this.nazivPoligonaTextBox.TabIndex = 18;
            // 
            // opisPoligonaTextBox
            // 
            this.opisPoligonaTextBox.Location = new System.Drawing.Point(115, 133);
            this.opisPoligonaTextBox.Name = "opisPoligonaTextBox";
            this.opisPoligonaTextBox.Size = new System.Drawing.Size(279, 70);
            this.opisPoligonaTextBox.TabIndex = 19;
            this.opisPoligonaTextBox.Text = "";
            // 
            // FormSavePolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(470, 273);
            this.Controls.Add(this.opisPoligonaTextBox);
            this.Controls.Add(this.nazivPoligonaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelAdd);
            this.Controls.Add(this.buttonUredu);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSavePolygon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spremi poligon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelAdd;
        private System.Windows.Forms.Button buttonUredu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nazivPoligonaTextBox;
        private System.Windows.Forms.RichTextBox opisPoligonaTextBox;
    }
}