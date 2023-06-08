using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Apisul.AC.Model.Entities.ObjAnttWS
{
    [Serializable]
    public class CancelamentoOperacaoTransporte
    {
        /// <summary>
        /// CIOT – Código Identificador da Operação de Transporte (com Código Verificador).
        /// B1
        /// B16
        /// B34
        /// B35
        /// B36
        /// B37
        /// B38
        /// </summary>
        public string CodigoIdentificacaoOperacao { get; set; }

        /// <summary>
        /// Motivo do Cancelamento da Operação de Transporte.
        /// B1
        /// </summary>
        public string MotivoCancelamento { get; set; }
    }
}
