using System;

namespace Apisul.AC.Model.Entities.ObjAnttWS
{
    [Serializable]
    public class ConsultarSituacaoTransportador
    {
        /// <summary>
        /// CPF ou CNPJ do Interessado. Se informado:
        /// - 11 dígitos CPF; ou
        /// - 14 dígitos CNPJ.
        /// Obs: Obrigatório preenchimento na requisição.
        /// </summary>
        public string CpfCnpjInteressado { get; set; }

        /// <summary>
        /// CPF ou CNPJ do Transportador. Se informado:
        /// - 11 dígitos CPF; ou
        /// - 14 dígitos CNPJ.
        /// Obs: Obrigatório preenchimento na requisição.
        /// </summary>
        public string CpfCnpjTransportador { get; set; }

        /// <summary>
        /// Número do RNTRC do Transportador.
        /// Caso, seja informado 8 dígitos, deverá ser incluso um zero “0” à esquerda, completando os 9 dígitos.Mas informando 7 dígitos ele será considerado inválido.
        /// Obs: Obrigatório preenchimento na requisição.
        /// </summary>
        public string RNTRCTransportador { get; set; }
    }
}
