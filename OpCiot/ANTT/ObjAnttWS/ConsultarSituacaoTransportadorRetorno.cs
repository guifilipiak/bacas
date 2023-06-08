using System;
using System.Collections.Generic;

namespace Apisul.AC.Model.Entities.ObjAnttWS
{
    [Serializable]
    public class ConsultarSituacaoTransportadorRetorno
    {
        /// <summary>
        /// CPF ou CNPJ do Transportador
        /// - 11 dígitos CPF; ou
        /// - 14 dígitos CNPJ.
        /// </summary>
        public string CpfCnpjTransportador { get; set; }

        /// <summary>
        /// Número do RNTRC do Transportador.  RNTRC do transportador consultado.
        /// Caso, tenha sido informado 8 dígitos e este seja válido, deverá ser recuperado com zero “0” à esquerda, completando os 9 dígitos.
        /// </summary>
        public string RNTRCTransportador { get; set; }

        /// <summary>
        /// Nome ou Razão Social do Transportador.
        /// </summary>
        public string NomeRazaoSocialTransportador { get; set; }

        /// <summary>
        /// Situação do RNTRC Ativa:
        /// false - Situação não é ativa
        /// true - Situação é ativa
        /// </summary>
        public Boolean? RNTRCAtivo { get; set; }

        /// <summary>
        /// Data de Validade do RNTRC do Transportador.
        /// </summary>
        public DateTime? DataValidadeRNTRC { get; set; }

        /// <summary>
        /// Transportador:
        /// - TAC
        /// - ETC
        /// - CTC
        /// </summary>
        public string TipoTransportador { get; set; }

        /// <summary>
        /// Transportador é equiparado ao TAC:
        /// false – Não
        /// true - Sim
        /// </summary>
        public Boolean? EquiparadoTAC { get; set; }

        /// <summary>
        /// Protocolo retornado após consumo do serviço
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

        public List<int> Erros
        {
            get
            {
                List<int> lstErros = new List<int>();
                string[] erros = this.Codigo.Split(',');
                foreach (var v in erros)
                {
                    if (v != "110" && v != "111")
                        lstErros.Add(int.Parse(v));
                }
                return lstErros;
            }
        }

    }
}
