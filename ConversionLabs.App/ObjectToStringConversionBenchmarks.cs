using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace ConversionLabs {
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class ObjectToStringConversionBenchmarks {
        private readonly object? _obj = "1234";
        private static readonly ObjectToStringConverters ObjectToStringConverter = new();
        [Benchmark]
        public void ConvertUsingAs()
        {
            ObjectToStringConverter.UsingAs(_obj);
        }

        [Benchmark]
        public void ConvertUsingCasting()
        {
            ObjectToStringConverter.UsingCasting(_obj);
        }

        [Benchmark]
        public void ConvertUsingConvertToString()
        {
            ObjectToStringConverter.UsingConvertToString(_obj);
        }


        [Benchmark]
        public void ConvertUsingToString()
        {
            ObjectToStringConverter.UsingToString(_obj);
        }

    }
}
