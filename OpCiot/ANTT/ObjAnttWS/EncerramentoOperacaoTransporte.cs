using System;
using System.Collections.Generic;

namespace Apisul.AC.Model.Entities.ObjAnttWS
{
    [Serializable]
    public class EncerramentoOperacaoTransporte
    {
        /// <summary>
        /// CIOT - Código Identificador da Operação de Transporte (com Código Verificador).
        /// B1
        /// B16
        /// B34
        /// B38
        /// Preencimento  obrigatório.
        /// </summary>
        public string CodigoIdentificacaoOperacao { get; set; }

        /// <summary>
        /// Peso total da carga entre município de origem e o município de destino em uma viagem padrão (tipo 1)
        /// B18
        /// B58
        /// Se o tipo de viagem desse encerramento for do tipo TAC Agregado(igual a 3) esse campo não poderá ser informado.
        /// B62
        /// Obs: Anteriormente era PesoCarga
        /// Preencimento não obrigatório.
        /// </summary>
        public string PesoCargaTotal { get; set; }
        /// <summary>
        /// Campo que comportará todas as rotas realizadas para um mesmo CIOT.
        /// B45
        /// B63
        /// Se o tipo de viagem desse encerramento for do tipo padrão(igual a 1) esse campo não poderá ser informado.
        /// B64
        /// Obs:Anteriormente era ViagemOperacaoTransporte
        /// Preencimento não obrigatório.
        /// </summary>
        public List<Rota> Rotas { get; set; }

        /// <summary>
        /// Quantidade de tarifas bancárias ou decorrentes do uso do meio de pagamento de frete cujo pagamento é feito pelo contratante para o transportador para a operação de transporte.
        /// B1
        /// Preencimento  obrigatório.
        /// </summary>
        public string QuantidadeTarifas { get; set; }

        /// <summary> 
        /// Valor das tarifas bancárias ou decorrentes do uso do  meio de pagamento de frete cujo pagamento é feito pelo contratante para o transportador para a operação de transporte.
        /// B1
        /// Preencimento  obrigatório.
        /// </summary>
        public string ValorTarifas { get; set; }
    }
}
