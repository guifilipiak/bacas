using Apisul.AC.Model.Entities.ObjAnttWS;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Apisul.AC.Business.Provider.ANTT
{
    public class WsAntt
    {
        public string URL;
        private string caminhoCertificado;
        private string senhaCertificado;
        public WsAntt()
        {
            this.URL = "https://appservices-hml.antt.gov.br/pefServices/api/";
            this.caminhoCertificado = Environment.CurrentDirectory + @"\multisat.pfx";
            this.senhaCertificado = "apisul";
        }
        public ConsultarSituacaoTransportadorRetorno ConsultarSituacaoTransportador(ConsultarSituacaoTransportador obj)
        {
            return Send<ConsultarSituacaoTransportadorRetorno, ConsultarSituacaoTransportador>("ConsultarSituacaoTransportador", obj);

            // POST
            // "pefConsultarSituacaoTransportador"
        }
        public ConsultarFrotaTransportadorRetorno ConsultarFrotaTransportador(ConsultarFrotaTransportador obj)
        {
            return Send<ConsultarFrotaTransportadorRetorno, ConsultarFrotaTransportador>("ConsultarFrotaTransportador", obj);
            // POST
            // "ConsultarFrotaTransportador"
        }
        public DeclaracaoOperacaoTransporteRetorno DeclaracaoOperacaoTransporte(DeclaracaoOperacaoTransporte obj)
        {
            return Send<DeclaracaoOperacaoTransporteRetorno, DeclaracaoOperacaoTransporte>("DeclaracaoOperacaoTransporte", obj);
            // POST
            // "pefDeclaracaoOperacaoTransporte"
        }
        public CancelamentoOperacaoTransporteRetorno CancelamentoOperacaoTransporte(CancelamentoOperacaoTransporte obj)
        {
            return Send<CancelamentoOperacaoTransporteRetorno, CancelamentoOperacaoTransporte>("CancelamentoOperacaoTransporte", obj);

            // POST
            // "CancelamentoOperacaoTransporte"
        }
        public RetificacaoOperacaoTransporteRetorno RetificacaoOperacaoTransporte(RetificacaoOperacaoTransporte obj)
        {
            return Send<RetificacaoOperacaoTransporteRetorno, RetificacaoOperacaoTransporte>("RetificacaoOperacaoTransporte", obj);

            // "POST"
            // "RetificacaoOperacaoTransporte"
        }
        public EncerramentoOperacaoTransporteRetorno EncerramentoOperacaoTransporte(EncerramentoOperacaoTransporte obj)
        {
            return Send<EncerramentoOperacaoTransporteRetorno, EncerramentoOperacaoTransporte>("EncerramentoOperacaoTransporte", obj);
            // "POST"
            //"EncerramentoOperacaoTransporte";
        }
        private T Send<T, V>(string metodo, V obj) where T : class, new()
        {
            return Send<T, V>(metodo, "POST", obj);
        }
        private T Send<T, V>(string metodo, string verboHttp, V obj) where T : class, new()
        {
            T retorno = null;

            //Serealiza objeto em json
            string objJson = JsonConvert.SerializeObject(obj);
            string responseString;
            int contadorRequisicao = 0;

            while (true)
            {
                try
                {

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.URL + "/" + metodo);
                    request.ContentType = "application/json";
                    request.Method = verboHttp;

                    // Indica que autenticação será mutua
                    request.AuthenticationLevel = AuthenticationLevel.MutualAuthRequested;
                    request.ClientCertificates.Add(GetCertFromFile());

                    ASCIIEncoding encoding = new ASCIIEncoding();
                    byte[] byte1 = encoding.GetBytes(objJson);
                    request.ContentLength = byte1.Length;

                    using (Stream streamRequest = request.GetRequestStream())
                    {
                        //Escreve json na stream
                        streamRequest.Write(byte1, 0, byte1.Length);
                    }

                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    {
                        using (Stream streamResponse = response.GetResponseStream())
                        {
                            using (StreamReader streamRead = new StreamReader(streamResponse))
                            {
                                //Lê o retorno
                                responseString = streamRead.ReadToEnd();
                                // Deserializa o retorno
                                retorno = JsonConvert.DeserializeObject<T>(responseString);
                            }
                        }
                    }

                    //Libera certificado após utilizado
                    for (int cert = 0; cert < request.ClientCertificates.Count; cert++)
                    {
                        request.ClientCertificates[cert].Reset();
                    }

                    break;
                }
                catch (WebException e)
                {
                    if (e.Status == WebExceptionStatus.Timeout)
                    {
                        if (contadorRequisicao <= 3)
                        {
                            System.Threading.Thread.Sleep(4000);
                            contadorRequisicao++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return retorno;
        }

        /// <summary>
        /// Busca arquivo certificado
        /// </summary>
        /// <returns>Caso for debug busca do no diretorio local</returns>
        private X509Certificate2 GetCertFromFile()
        {
            return new X509Certificate2(this.caminhoCertificado, this.senhaCertificado, X509KeyStorageFlags.PersistKeySet);
        }
    }
}
