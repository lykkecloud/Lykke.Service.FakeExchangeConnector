﻿using System.Collections.Generic;
using Lykke.Service.FakeExchangeConnector.Core.Domain.Trading;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Lykke.Service.FakeExchangeConnector.Core.Domain
{
    /// <summary>
    /// Information about the exchange
    /// </summary>
    public sealed class ExchangeInformationModel
    {
        /// <summary>
        /// A name of the exchange
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Supported instruments
        /// </summary>
        public IEnumerable<Instrument> Instruments { get; set; }

        /// <summary>
        /// A current state of the exchange
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ExchangeState State { get; set; }

        /// <summary>
        /// A description of the exchange streaming capabilities
        /// </summary>
        public StreamingSupport StreamingSupport { get; set; }
    }

    /// <summary>
    /// A description of the exchange streaming capabilities
    /// </summary>
    public sealed class StreamingSupport
    {
        /// <summary>
        /// Can stream order books
        /// </summary>
        public bool OrderBooks { get; }

        /// <summary>
        /// Can stream orders updates
        /// </summary>
        public bool Orders { get; }


        public StreamingSupport(bool orderBooks, bool orders)
        {
            OrderBooks = orderBooks;
            Orders = orders;
        }
    }
}
