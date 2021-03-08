using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Exporters.Csv;

namespace benchmarkdotnetdemo
{
    [InProcess()]
    [MemoryDiagnoser]
    [RankColumn, MinColumn, MaxColumn, Q1Column, Q3Column, AllStatisticsColumn]
    [JsonExporterAttribute.Full, CsvMeasurementsExporter, CsvExporter(CsvSeparator.Comma), HtmlExporter, MarkdownExporterAttribute.GitHub]
    [GcServer(true)]
    public class FibonacciBenchmark
    {
        [Params(1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233)]
        public int Count { get; set; }

        [Benchmark]
        public void Fibonacci()
        {
            var xs = Count.GetFibonacci().ToList();
        }
    }
}
