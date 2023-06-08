using System;
using System.Collections.Generic;

namespace Apisul.AC.Model.Entities.ObjAnttWS
{
    [Serializable]
    public class ConsultarFrotaTransportador
    {
        /// <summary>
        /// CPF ou CNPJ do Interessado. Sendo:
        /// - 11 dígitos CPF;
        /// - 14 dígitos CNPJ.
        /// Obs: Obrigatório preenchimento na requisição.
        /// </summary>
        public string CpfCnpjInteressado { get; set; }

        /// <summary>
        /// CPF ou CNPJ do Transportador. Sendo:
        /// - 11 dígitos CPF;
        /// - 14 dígitos CNPJ.
        /// Obs: Obrigatório preenchimento na requisição.
        /// </summary>
        public string CpfCnpjTransportador { get; set; }

        /// <summary>
        /// RNTRC do transportador consultado.
        /// Caso, tenha sido informado 8 dígitos e este seja válido, deverá ser recuperado com zero “0” à esquerda, completando os 9 dígitos.
        /// Obs: Obrigatório preenchimento na requisição.
        /// </summary>
        public string RNTRCTransportador { get; set; }

        /// <summary>
        /// Placas dos veículos a serem pesquisados.
        /// Obs: Obrigatório preenchimento na requisição.
        /// </summary>
        public List<string> Placas { get; set; }
    }
}
