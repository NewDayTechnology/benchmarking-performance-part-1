using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Exporters.Csv;

namespace benchmarkdotnetdemo
{
    [InProcess()]
    [MemoryDiagnoser]
    [RankColumn, MinColumn, MaxColumn, Q1Column, Q3Column, AllStatisticsColumn]
    [JsonExporterAttribute.Full, CsvMeasurementsExporter, CsvExporter(CsvSeparator.Comma), HtmlExporter, MarkdownExporterAttribute.GitHub]
    [GcServer(true)]
    public class SimpleBenchmark
    {
        [Benchmark]
        public void NoopTest()
        {
        }

        [Benchmark]
        public int AddTest()
        {
            return int.MaxValue + int.MinValue;
        }

        [Benchmark]
        public int MultiplyTest()
        {
            return 11 * 3;
        }
    }
}
