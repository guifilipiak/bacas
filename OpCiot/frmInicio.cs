using Apisul.AC.Business.Provider.ANTT;
using Apisul.AC.Model.Entities.ObjAnttWS;
using OpCiot.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpCiot
{
    public partial class frmInicio : Form
    {
        WsAntt wsAntt;
        LogWriter log;
        string textFile = string.Empty;

        public frmInicio()
        {
            InitializeComponent();

            wsAntt = new WsAntt();
        }

        #region Chamadas Web Service Antt
        private void btnCancelarCiot_Click(object sender, EventArgs e)
        {
            var output = new List<CancelamentoOperacaoTransporteRetorno>();

            btnCancelarCiot.Enabled = false;
            btnEncerrarCiot.Enabled = false;

            try
            {
                var input = string.Empty;
                if (!string.IsNullOrEmpty(textFile) && !txtInput.Enabled)
                {
                    input = textFile;
                }
                else
                {
                    input = txtInput.Text;
                }

                var listCiot = new List<string>();

                if (!string.IsNullOrEmpty(input) && input != "9234657894, 9234657896, 9234657899")
                {
                    listCiot.AddRange(input.Split(','));
                }

                listCiot.RemoveAll(x => x.Trim() == string.Empty);

                if (listCiot.Count > 0)
                {
                    foreach (var item in listCiot)
                    {
                        var value = item.Trim();
                        if (value.Length == 12)
                        {
                            value = value + "XXXX";
                        }

                        var modelCiot = new Apisul.AC.Model.Entities.ObjAnttWS.CancelamentoOperacaoTransporte()
                        {
                            CodigoIdentificacaoOperacao = value,
                            MotivoCancelamento = "Cancelamento HML do CIOT: " + item
                        };

                        var result = wsAntt.CancelamentoOperacaoTransporte(modelCiot);
                        if (result != null)
                        {
                            output.Add(result);
                        }
                        else
                        {
                           //Grava Log
                           log = new LogWriter("[" + DateTime.Now + "] Erro ao cancelar CIOT - Protocolo: " + item + Environment.NewLine);
                        }
                    }
                    txtOutput.Text = Newtonsoft.Json.JsonConvert.SerializeObject(output, Newtonsoft.Json.Formatting.Indented);
                }
                else
                {
                    MessageBox.Show("Informe ao menos um CIOT para cancelamento!");
                }

                btnCancelarCiot.Enabled = true;
                btnEncerrarCiot.Enabled = true;
                txtInput.Enabled = true;
                textFile = string.Empty;
            }
            catch (Exception ex)
            {
                if (output.Count > 0)
                    txtOutput.Text = Newtonsoft.Json.JsonConvert.SerializeObject(output, Newtonsoft.Json.Formatting.Indented);

                MessageBox.Show("Erro ao cancelar CIOT!" + Environment.NewLine + ex.Message);

                btnCancelarCiot.Enabled = true;
                btnEncerrarCiot.Enabled = true;
                txtInput.Enabled = true;
                textFile = string.Empty;
            }
        }

        private void btnEncerrarCiot_Click(object sender, EventArgs e)
        {
            var output = new List<EncerramentoOperacaoTransporteRetorno>();

            btnCancelarCiot.Enabled = false;
            btnEncerrarCiot.Enabled = false;

            try
            {
                var input = string.Empty;
                if (!string.IsNullOrEmpty(textFile) && !txtInput.Enabled)
                {
                    input = textFile;
                }
                else
                {
                    input = txtInput.Text;
                }

                var listCiot = new List<string>();

                if (!string.IsNullOrEmpty(input) && input != "9234657894, 9234657896, 9234657899")
                {
                    listCiot.AddRange(input.Split(','));
                }

                listCiot.RemoveAll(x => x.Trim() == string.Empty);

                if (listCiot.Count > 0)
                {
                    foreach (var item in listCiot)
                    {
                        var value = item.Trim();
                        if (value.Length == 12)
                        {
                            value = value + "XXXX";
                        }

                        var rotaDefault = new List<Rota>();
                        rotaDefault.Add(new Rota()
                        {
                            CodigoMunicipioOrigem = "3118601",
                            CodigoMunicipioDestino = "3118601",
                            CodigoNaturezaCarga = "0001",
                            PesoCarga = "1",
                            QuantidadeViagens = 0
                        });

                        var modelCiot = new Apisul.AC.Model.Entities.ObjAnttWS.EncerramentoOperacaoTransporte()
                        {
                            CodigoIdentificacaoOperacao = value,
                            QuantidadeTarifas = "0",
                            ValorTarifas = "0",
                            Rotas = rotaDefault,
                            PesoCargaTotal = null
                        };

                        var result = wsAntt.EncerramentoOperacaoTransporte(modelCiot);
                        if (result != null)
                        {
                            output.Add(result);
                        }
                        else
                        {
                            //Grava Log
                            log = new LogWriter("[" + DateTime.Now + "] Erro ao encerrar CIOT - Protocolo: " + item + Environment.NewLine);
                        }
                    }
                    txtOutput.Text = Newtonsoft.Json.JsonConvert.SerializeObject(output, Newtonsoft.Json.Formatting.Indented);
                }
                else
                {
                    MessageBox.Show("Informe ao menos um CIOT para encerramento!");
                }

                btnCancelarCiot.Enabled = true;
                btnEncerrarCiot.Enabled = true;
                txtInput.Enabled = true;
                txtInput.Enabled = true;
                textFile = string.Empty;
            }
            catch (Exception ex)
            {
                if (output.Count > 0)
                    txtOutput.Text = Newtonsoft.Json.JsonConvert.SerializeObject(output, Newtonsoft.Json.Formatting.Indented);

                MessageBox.Show("Erro ao cancelar CIOT!" + Environment.NewLine + ex.Message);

                btnCancelarCiot.Enabled = true;
                btnEncerrarCiot.Enabled = true;
                txtInput.Enabled = true;
                textFile = string.Empty;
            }
        }
        #endregion

        #region Eventos de Tela
        private void txtInput_Enter(object sender, EventArgs e)
        {
            if (txtInput.Text == "9234657894, 9234657896, 9234657899")
            {
                txtInput.Text = "";
                txtInput.ForeColor = Color.Black;
            }
        }

        private void txtInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text) || string.IsNullOrWhiteSpace(txtInput.Text))
            {
                txtInput.Text = "9234657894, 9234657896, 9234657899";
                txtInput.ForeColor = Color.Gray;
            }
        }

        private void cbAmbiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAmbiente.SelectedItem.Equals("Produção"))
            {
                wsAntt.URL = "https://appservices.antt.gov.br/pefServices/api/";
            }
            else
            {
                wsAntt.URL = "https://appservices-hml.antt.gov.br/pefServices/api/";
            }
        }
        #endregion

        private void btnArquivos_Click(object sender, EventArgs e)
        {
            var result = ofdArquivos.ShowDialog();
            if (result == DialogResult.OK)
            {
                textFile = File.ReadAllText(ofdArquivos.FileName);
                txtInput.Enabled = false;
            }
        }
    }
}
