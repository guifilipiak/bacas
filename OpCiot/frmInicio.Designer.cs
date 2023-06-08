namespace OpCiot
{
    partial class frmInicio
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
            this.btnCancelarCiot = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cbAmbiente = new System.Windows.Forms.ComboBox();
            this.btnEncerrarCiot = new System.Windows.Forms.Button();
            this.ofdArquivos = new System.Windows.Forms.OpenFileDialog();
            this.btnArquivos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelarCiot
            // 
            this.btnCancelarCiot.Location = new System.Drawing.Point(471, 378);
            this.btnCancelarCiot.Name = "btnCancelarCiot";
            this.btnCancelarCiot.Size = new System.Drawing.Size(100, 23);
            this.btnCancelarCiot.TabIndex = 0;
            this.btnCancelarCiot.Text = "Cancelar CIOT";
            this.btnCancelarCiot.UseVisualStyleBackColor = true;
            this.btnCancelarCiot.Click += new System.EventHandler(this.btnCancelarCiot_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnArquivos);
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT (Informe os números de ciot separados por \",\")";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Location = new System.Drawing.Point(12, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUTPUT (Retorno em formato JSON)";
            // 
            // txtInput
            // 
            this.txtInput.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInput.Location = new System.Drawing.Point(7, 19);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(546, 163);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "9234657894, 9234657896, 9234657899";
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            this.txtInput.Leave += new System.EventHandler(this.txtInput_Leave);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(7, 15);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(547, 79);
            this.txtOutput.TabIndex = 1;
            // 
            // cbAmbiente
            // 
            this.cbAmbiente.DisplayMember = "0";
            this.cbAmbiente.FormattingEnabled = true;
            this.cbAmbiente.Items.AddRange(new object[] {
            "Homologação",
            "Produção"});
            this.cbAmbiente.Location = new System.Drawing.Point(423, 12);
            this.cbAmbiente.Name = "cbAmbiente";
            this.cbAmbiente.Size = new System.Drawing.Size(148, 21);
            this.cbAmbiente.TabIndex = 3;
            this.cbAmbiente.Text = "Homologação";
            this.cbAmbiente.SelectedIndexChanged += new System.EventHandler(this.cbAmbiente_SelectedIndexChanged);
            // 
            // btnEncerrarCiot
            // 
            this.btnEncerrarCiot.Location = new System.Drawing.Point(365, 378);
            this.btnEncerrarCiot.Name = "btnEncerrarCiot";
            this.btnEncerrarCiot.Size = new System.Drawing.Size(100, 23);
            this.btnEncerrarCiot.TabIndex = 4;
            this.btnEncerrarCiot.Text = "Encerrar CIOT";
            this.btnEncerrarCiot.UseVisualStyleBackColor = true;
            this.btnEncerrarCiot.Click += new System.EventHandler(this.btnEncerrarCiot_Click);
            // 
            // ofdArquivos
            // 
            this.ofdArquivos.FileName = "inputFile";
            // 
            // btnArquivos
            // 
            this.btnArquivos.Location = new System.Drawing.Point(392, 198);
            this.btnArquivos.Name = "btnArquivos";
            this.btnArquivos.Size = new System.Drawing.Size(161, 23);
            this.btnArquivos.TabIndex = 5;
            this.btnArquivos.Text = "Selecionar Arquivo Input";
            this.btnArquivos.UseVisualStyleBackColor = true;
            this.btnArquivos.Click += new System.EventHandler(this.btnArquivos_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 413);
            this.Controls.Add(this.btnEncerrarCiot);
            this.Controls.Add(this.cbAmbiente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelarCiot);
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPERACOES CIOT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarCiot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ComboBox cbAmbiente;
        private System.Windows.Forms.Button btnEncerrarCiot;
        private System.Windows.Forms.Button btnArquivos;
        private System.Windows.Forms.OpenFileDialog ofdArquivos;
    }
}

