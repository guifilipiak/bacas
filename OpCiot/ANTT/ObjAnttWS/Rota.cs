using System;

namespace Apisul.AC.Model.Entities.ObjAnttWS
{
    [Serializable]
    public class Rota
    {
        /// <summary>
        /// Código do Município de Origem da Carga, segundo IBGE.
        /// B7
        /// B43
        /// Se o tipo de viagem desse encerramento for do tipo padrão(igual a 1) esse campo não poderá ser informado.
        /// B44
        /// Preencimento não obrigatório.
        /// </summary>
        public string CodigoMunicipioOrigem { get; set; }

        /// <summary>
        /// Código do Município de Destino da Carga, segundo IBGE.
        /// B8
        /// B43
        /// Se o tipo de viagem desse encerramento for do tipo padrão(igual a 1) esse campo não poderá ser informado.
        /// B44
        /// Preencimento não obrigatório.
        /// </summary>
        public string CodigoMunicipioDestino { get; set; }

        /// <summary>
        /// Código da Natureza da Carga.
        /// Caso não possa ser especificado, deverá ser informado o código genérico “0001”.
        /// B9
        /// B43
        /// Se o tipo de viagem desse encerramento for do tipo padrão (igual a 1) esse campo não poderá ser informado.
        /// B44
        /// Preencimento não obrigatório.
        /// </summary>
        public string CodigoNaturezaCarga { get; set; }

        /// <summary>
        /// Somatório do peso em quilos das cargas transportadas durante a vigência da operação de transporte para a mesma combinação de município de origem, município de destino e código da natureza da carga.
        /// B1
        /// B18
        /// Preencimento não obrigatório.
        /// </summary>
        public string PesoCarga { get; set; }

        /// <summary>
        /// Quantidade de viagens realizadas durante a vigência da operação de transporte para a mesma combinação de município de origem, município de destino e código da natureza da carga.
        /// B43
        /// Se o tipo de viagem desse encerramento for do tipo padrão(igual a 1) esse campo não poderá ser informado.
        /// B44
        /// Preencimento não obrigatório.
        /// </summary>
        public int QuantidadeViagens { get; set; }
    }
}
