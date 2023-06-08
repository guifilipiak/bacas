﻿using System;
using System.Collections.Generic;

namespace Apisul.AC.Model.Entities.ObjAnttWS
{
    [Serializable]
    public class CancelamentoOperacaoTransporteRetorno
    {
        /// <summary>
        /// CIOT – Código Identificador da Operação de Transporte (com Código Verificador). 
        /// </summary>
        public string CodigoIdentificacaoOperacao { get; set; }

        /// <summary>
        /// Data/Hora do Cancelamento da Operação de Transporte.
        /// </summary>
        public DateTime ? DataCancelamento { get; set; }

        /// <summary>
        /// Protocolo de sucesso no Cancelamento.
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
