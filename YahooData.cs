using System.Collections.Generic;

namespace StockViewer
{
    class YahooData
    {
        public QuoteResponse quoteResponse { get; set; }
    }

    class QuoteResponse
    {
        public List<Result> result { get; set; }

    }

    class Result
    {
        public string MarketState { get; set; }
        public string Symbol { get; set; }
        public float RegularMarketPreviousClose { get; set; }
        public float RegularMarketPrice { get; set; }
        public float PostMarketPrice { get; set; }
        public float PreMarketPrice { get; set; }
    }
}
