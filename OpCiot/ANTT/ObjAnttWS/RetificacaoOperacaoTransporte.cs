using System;
using System.Collections.Generic;

namespace Apisul.AC.Model.Entities.ObjAnttWS
{
    [Serializable]
    public class RetificacaoOperacaoTransporte
    {
        /// <summary>
        /// CIOT – Código Identificador da Operação de Transporte (com Código Verificador).
        /// B1
        /// B16
        /// B34
        /// B38
        /// B39
        /// B40
        /// B41
        /// Preencimento  obrigatório.
        /// </summary>
        public string CodigoIdentificacaoOperacao { get; set; }

        /// <summary>
        /// Campo que comportará todos os veículos vinculado a uma viagem.
        /// B1
        /// B49
        /// Obs: Anteriormente era VeiculoOperacaoTransporte
        /// Preencimento  obrigatório.
        /// </summary>
        public List<Veiculo> Veiculos { get; set; }

        /// <summary>
        /// Código da Natureza da Carga.
        /// Campo não deve ser informado quando o campo TipoViagem é igual a 3;
        /// B47
        /// Caso não possa ser especificado, deverá ser informado o código genérico “0001”.
        /// B9
        /// B52
        /// Preencimento não obrigatório.
        /// </summary>
        public string CodigoNaturezaCarga { get; set; }

        /// <summary>
        /// Peso em quilos da Carga.
        /// Campo não deve ser informado quando o campo TipoViagem é igual a 3;
        /// B47
        /// B18
        /// Preencimento não obrigatório.
        /// </summary>
        public string PesoCarga { get; set; }

        /// <summary>
        /// Data de Início da Viagem.
        /// Campo não deve ser informado quando o campo TipoViagem é igual a 3;
        /// B47
        /// B12
        /// B21
        /// B22
        /// B61
        /// Preencimento não obrigatório.
        /// </summary>
        public string DataInicioViagem { get; set; }

        /// <summary>
        /// Previsão da Data de Término da Viagem Campo não deve ser informado quando o campo TipoViagem é igual a 3;
        /// B47
        /// B13
        /// B21
        /// B61
        /// Preencimento não obrigatório.
        /// </summary>
        public string DataFimViagem { get; set; }

        /// <summary>
        /// Código do Município de Origem da Carga, segundo IBGE.
        /// Campo não deve ser informado quando o campo TipoViagem é igual a 3;
        /// B47
        /// B7
        /// Preencimento não obrigatório.
        /// </summary>
        public string CodigoMunicipioOrigem { get; set; }

        /// <summary>
        /// Código do Município de Destino da Carga, segundo IBGE.
        /// Campo não deve ser informado quando o campo TipoViagem é igual a 3;
        ///  B47
        ///  B8
        /// Preencimento não obrigatório.
        /// </summary>
        public string CodigoMunicipioDestino { get; set; }

        /// <summary>
        /// Quantidade de tarifas bancárias ou decorrentes do uso do meio de pagamento de frete cujo pagamento é feito pelo contratante para o transportador para a operação de transporte.
        /// B1
        /// 
        /// Preencimento obrigatório.
        /// </summary>
        public string QuantidadeTarifas { get; set; }

        /// <summary>
        /// Valor das tarifas bancárias ou decorrentes do uso do meio de pagamento de frete cujo pagamento é feito pelo contratante para o transportador para a operação de transporte.
        /// B1
        /// Preencimento obrigatório.
        /// </summary>
        public string ValorTarifas { get; set; }
    }
}
