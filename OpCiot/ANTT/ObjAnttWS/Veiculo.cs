using System;

namespace Apisul.AC.Model.Entities.ObjAnttWS
{
    [Serializable]
    public class Veiculo
    {
        /// <summary>
        /// Placa do veículo.
        /// B1
        /// B5
        /// B15
        /// B20
        /// B48
        /// B59
        /// Se campo TipoViagem = 1  
        /// Executa B29
        /// Se campo TipoViagem = 3 
        /// Executa B28

        /// </summary>
        public string Placa { get; set; }
        /// <summary>
        /// Número do RNTRC do Transportador que possui o veículo em sua frota.
        /// Caso, seja informado 8 dígitos, deverá ser incluso um zero “0” à esquerda, completando os 9 dígitos.Mas informando 7 dígitos ele será considerado inválido.

        /// B1
        /// B15
        /// B60

        /// </summary>
        public string RNTRC { get; set; }
    }
}
