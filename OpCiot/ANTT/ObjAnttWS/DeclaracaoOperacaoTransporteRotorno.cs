using System;
using System.Collections.Generic;

namespace Apisul.AC.Model.Entities.ObjAnttWS
{
    [Serializable]
    public class DeclaracaoOperacaoTransporteRetorno
    {
        /// <summary>
        /// Código Identificador da Operação de Transporte – CIOT.

        /// B1
        /// B17
        /// B24
        /// B25

        /// Se o tipo de viagem dessa retificação for do tipo TAC Agregado(igual a 3) Executa

        /// B31
        /// B32

        /// </summary>
        public string CodigoIdentificacaoOperacao { get; set; }

        /// <summary>
        /// Código verificador gerado pela ANTT validando os dados enviados – protocolo de autorização.
        /// </summary>
        public int? CodigoVerificador { get; set; }

        /// <summary>
        /// Retorna o número do protocolo de erro ou de sucesso da operação de declaração.
        /// </summary>
        public string Protocolo { get; set; }

        /// <summary>
        /// Código do erro ou sucesso no retorno da informação.
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// Mensagem de erro ou sucesso no retorno da informação.
        /// </summary>
        public string Mensagem { get; set; }

        /// <summary>
        /// Mensagem de aviso cadastrada pela ANTT para o contratado. Sempre que existir esta mensagem, sua apresentação ao transportador e impressão no documento correspondente é obrigatória.
        /// </summary>
        public string AvisoTransportador { get; set; }

        public List<int> Erros
        {
            get
            {
                List<int> lstErros = new List<int>();

                if (this.Codigo == null && this.Mensagem.Contains("Rejeição:"))
                {
                    this.Codigo = "-1";
                }

                if (!string.IsNullOrEmpty(this.Codigo))
                {
                    string[] erros = this.Codigo.Split(',');
                    foreach (var v in erros)
                    {
                        if (v != "110" && v != "111")
                            lstErros.Add(int.Parse(v));
                    }
                }
                
                return lstErros;
            }
        }
    }

}
