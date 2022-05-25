
namespace numero_do_mes
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
            this.lb_result = new System.Windows.Forms.Label();
            this.cb_mes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Elaborar um sistema onde o usuário digita o número do mês \r\ne exibir o nome do" +
    " mês correspondente.";
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Location = new System.Drawing.Point(66, 139);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(27, 13);
            this.lb_result.TabIndex = 4;
            this.lb_result.Text = "Mês";
            // 
            // cb_mes
            // 
            this.cb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_mes.FormattingEnabled = true;
            this.cb_mes.Location = new System.Drawing.Point(15, 74);
            this.cb_mes.Name = "cb_mes";
            this.cb_mes.Size = new System.Drawing.Size(121, 21);
            this.cb_mes.TabIndex = 5;
            this.cb_mes.SelectedIndexChanged += new System.EventHandler(this.cb_mes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 342);
            this.Controls.Add(this.cb_mes);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.ComboBox cb_mes;
    }
}

