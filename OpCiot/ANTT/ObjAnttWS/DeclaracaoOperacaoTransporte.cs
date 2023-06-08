using System;
using System.Collections.Generic;

namespace Apisul.AC.Model.Entities.ObjAnttWS
{
    [Serializable]
    public class DeclaracaoOperacaoTransporte
    {
        /// <summary>
        /// CPF ou CNPJ do Contratado. Se informado:
        /// - 11 dígitos CPF; ou
        /// - 14 dígitos CNPJ.
        /// </summary>
        public string CpfCnpjContratado { get; set; }

        /// <summary>
        /// Número do RNTRC do Contratado.
        /// Caso, seja informado 8 dígitos, deverá ser incluso um zero “0” à esquerda, completando os 9 dígitos.Mas informando 7 dígitos ele será considerado inválido.

        /// </summary>
        public string RNTRCContratado { get; set; }

        public string FlagContingencia { get; set; }

        /// <summary>
        /// Campo que comportará todos os veículos vinculado a uma viagem.
        /// 
        /// OBS:Anteriormente era VeiculoOperacaoTransporte
        /// </summary>
        public List<Veiculo> Veiculos { get; set; }

        /// <summary>
        /// Este número deve ser completado com zeros à esquerda até que se atinja a quantidade de caracteres obrigatória
        /// Obs: Necessário informar somente o sequencial gerado pela IPEF Anteriormente o nome do campo era CodigoIdentificacaoOperacao
        /// </summary>
        //public string SequencialNumerico { get; set; }

        /// <summary>
        /// CPF ou CNPJ do Contratante. Se informado:
        /// - 11 dígitos CPF; ou
        /// - 14 dígitos CNPJ.
        /// B1
        /// B4
        /// B25
        /// B33
        /// 
        /// Se campo TipoViagem = 3
        /// B24
        /// B26
        /// </summary>
        public string CodigoIdentificacaoOperacao { get; set; }
        public string CpfCnpjContratante { get; set; }

        /// <summary>
        /// Campo não deve ser informado quando o campo TipoViagem é igual a 3;
        /// B55
        /// CPF ou CNPJ do Destinatário da Carga.Se informado:
        /// - 11 dígitos CPF; ou
        /// - 14 dígitos CNPJ.
        /// B1
        /// B4
        /// </summary>
        public string CpfCnpjDestinatario { get; set; }

        /// <summary>
        /// Campo não deve ser informado quando o campo TipoViagem é igual a 3;
        /// B53
        /// Código do Município de Origem da Carga, segundo IBGE.
        /// B1
        /// B7
        /// </summary>
        public string CodigoMunicipioOrigem { get; set; }

        /// <summary>
        /// Campo não deve ser informado quando o campo TipoViagem é igual a 3;
        /// B54
        /// Código do Município de Destino da Carga, segundo IBGE.
        /// B1
        /// B8
        /// </summary>
        public string CodigoMunicipioDestino { get; set; }

        /// <summary>
        /// Campo não deve ser informado quando o campo TipoViagem é igual a 3;
        /// Código da Natureza da Carga.
        /// Caso não possa ser especificado, deverá ser informado o código genérico “0001”.
        /// B1
        /// B9
        /// B52
        /// </summary>
        public string CodigoNaturezaCarga { get; set; }

        /// <summary>
        /// Campo não deve ser informado quando o campo TipoViagem é igual a 3;
        /// B57
        /// Peso em quilos da Carga.
        /// B1
        /// B18
        /// </summary>
        public string PesoCarga { get; set; }

        /// <summary>
        /// Indica se o contratante é cliente da IPEF:
        /// false - Contratante não é cliente
        /// true - Contratante é cliente
        /// B1
        /// </summary>
        public string FlagCliente { get; set; }

        /// <summary>
        /// Campo não deve ser informado quando o campo TipoViagem é igual a 3;
        /// B56
        /// Data de Início da Viagem.
        /// B1
        /// B22
        /// B61
        /// Para o TipoViagem igual a 1 
        /// Executa
        /// B12
        /// B21
        /// </summary>
        public string DataInicioViagem { get; set; }

        /// <summary>
        /// Previsão da Data de Término da Viagem 
        /// B1
        /// B13
        /// B61
        /// Se campo TipoViagem = 1
        /// Executa B21
        /// Se campo TipoViagem = 3
        /// Executa B30
        /// </summary>
        public string DataFimViagem { get; set; }

        /// <summary>
        /// Data/Hora da Declaração da Operação de Transporte. Esta data deve ser a mesma que foi usada para a geração do sequencial (campo 4).
        /// B1
        /// B19
        /// B61
        /// </summary>
        public string DataDeclaracaoTransporte { get; set; }

        /// <summary>
        /// Tipo de operação de transporte
        /// - 1 (Operação de Transporte Padrão);
        /// - 3 (Operação de Transporte com TAC-Agregado).
        /// B1
        /// </summary>
        public string TipoViagem { get; set; }

        /// <summary>
        /// Campo passa a não ser obrigatório quando o campo TipoViagem é igual a 1;
        /// Número do RNTRC do Contratante que possui o Veículo em sua frota.
        /// Caso, seja informado 8 dígitos, deverá ser incluso um zero “0” à esquerda, completando os 9 dígitos.
        /// Mas informando 7 dígitos ele será considerado inválido.
        /// B1
        /// B60
        /// Se campo TipoViagem = 3 
        /// B26
        /// </summary>
        public string RNTRCContratante { get; set; }

        /// <summary>
        /// Quantidade de tarifas bancárias ou decorrentes do uso do meio de pagamento de frete cujo pagamento é feito pelo contratante para o transportador para a operação de transporte.
        /// B1
        /// </summary>
        public int QuantidadeTarifas { get; set; }

        /// <summary>
        /// Valor das tarifas bancárias ou decorrentes do uso do meio de pagamento de frete cujo pagamento é feito pelo contratante para o transportador para a operação de transporte.
        /// 
        /// B1
        /// </summary>
        public string ValorTarifas { get; set; }
    }
}
