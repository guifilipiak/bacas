using System;

namespace Apisul.AC.Model.Entities.ObjAnttWS
{
    [Serializable]
    public class Frota
    {
        /// <summary>
        /// Placa do Veículo.
        /// </summary>
        public string PlacaVeiculo { get; set; }

        /// <summary>
        /// Situação do Veículo:
        /// false - Não pertence ao Transportador
        /// true - Pertence ao Transportador
        /// </summary>
        public bool? SituacaoVeiculoFrotaTransportador  { get; set; }
}
}
