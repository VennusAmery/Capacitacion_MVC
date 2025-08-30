
namespace CapaVista
{
    partial class consulta
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
            this.dgv_registros = new System.Windows.Forms.DataGridView();
            this.btn_consulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_registros
            // 
            this.dgv_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registros.Location = new System.Drawing.Point(42, 107);
            this.dgv_registros.Name = "dgv_registros";
            this.dgv_registros.RowHeadersWidth = 51;
            this.dgv_registros.RowTemplate.Height = 24;
            this.dgv_registros.Size = new System.Drawing.Size(716, 316);
            this.dgv_registros.TabIndex = 0;
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(237, 29);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(324, 53);
            this.btn_consulta.TabIndex = 1;
            this.btn_consulta.Text = "consultar";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.dgv_registros);
            this.Name = "consulta";
            this.Text = "consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_registros;
        private System.Windows.Forms.Button btn_consulta;
    }
}