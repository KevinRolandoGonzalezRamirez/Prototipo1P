
namespace CapaVista
{
    partial class ConsultaCompras
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
            this.dvgConsulta = new System.Windows.Forms.DataGridView();
            this.btn_consulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgConsulta
            // 
            this.dvgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsulta.Location = new System.Drawing.Point(24, 106);
            this.dvgConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.dvgConsulta.Name = "dvgConsulta";
            this.dvgConsulta.ReadOnly = true;
            this.dvgConsulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvgConsulta.RowHeadersWidth = 51;
            this.dvgConsulta.RowTemplate.Height = 24;
            this.dvgConsulta.Size = new System.Drawing.Size(669, 236);
            this.dvgConsulta.TabIndex = 3;
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(259, 24);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(173, 60);
            this.btn_consulta.TabIndex = 11;
            this.btn_consulta.Text = "Consultar";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // ConsultaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 487);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.dvgConsulta);
            this.Name = "ConsultaCompras";
            this.Text = "ConsultaCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgConsulta;
        private System.Windows.Forms.Button btn_consulta;
    }
}