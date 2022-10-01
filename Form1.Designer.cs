
namespace Sakarya_Nesneye_Dayalı_Programlama_Odevi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x_textbox = new System.Windows.Forms.TextBox();
            this.y_textbox = new System.Windows.Forms.TextBox();
            this.button_arkadasmi = new System.Windows.Forms.Button();
            this.button_son = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // x_textbox
            // 
            this.x_textbox.Location = new System.Drawing.Point(40, 21);
            this.x_textbox.Name = "x_textbox";
            this.x_textbox.Size = new System.Drawing.Size(114, 20);
            this.x_textbox.TabIndex = 2;
            // 
            // y_textbox
            // 
            this.y_textbox.Location = new System.Drawing.Point(40, 82);
            this.y_textbox.Name = "y_textbox";
            this.y_textbox.Size = new System.Drawing.Size(114, 20);
            this.y_textbox.TabIndex = 3;
            // 
            // button_arkadasmi
            // 
            this.button_arkadasmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_arkadasmi.Location = new System.Drawing.Point(12, 126);
            this.button_arkadasmi.Name = "button_arkadasmi";
            this.button_arkadasmi.Size = new System.Drawing.Size(114, 31);
            this.button_arkadasmi.TabIndex = 4;
            this.button_arkadasmi.Text = "ARKADAŞ MI";
            this.button_arkadasmi.UseVisualStyleBackColor = true;
            this.button_arkadasmi.Click += new System.EventHandler(this.button_arkadasmi_Click);
            // 
            // button_son
            // 
            this.button_son.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_son.Location = new System.Drawing.Point(153, 126);
            this.button_son.Name = "button_son";
            this.button_son.Size = new System.Drawing.Size(78, 31);
            this.button_son.TabIndex = 4;
            this.button_son.Text = "SON";
            this.button_son.UseVisualStyleBackColor = true;
            this.button_son.Click += new System.EventHandler(this.button_son_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 173);
            this.Controls.Add(this.button_son);
            this.Controls.Add(this.button_arkadasmi);
            this.Controls.Add(this.y_textbox);
            this.Controls.Add(this.x_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Arkadaş Sayılar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x_textbox;
        private System.Windows.Forms.TextBox y_textbox;
        private System.Windows.Forms.Button button_arkadasmi;
        private System.Windows.Forms.Button button_son;
    }
}

