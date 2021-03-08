# benchmarkdotnetdemo


![Build](https://github.com/NewDayTechnology/benchmarkdotnetdemo/actions/workflows/dotnet.yml/badge.svg)

A simple demonstration of the superlative [BenchmarkDotNet](https://benchmarkdotnet.org/index.html) and its integration into Github Actions.

Measuring code performance is self evidently a vital discipline to software engineering and yet is so often skipped, usually for false economies. [BenchmarkDotNet](https://benchmarkdotnet.org/index.html) makes this essential task simplicity itself, with a syntax and style that's immediately intuitive to anyone versed in unit testing.

Just exercise your code in a declarative way, include it in your CI pipeline, and enjoy the results.

This project just demonstrates the basics: the .net project, the CI pipeline and the resultant reports.

## The Benchmarks

* ``NoopTest``
The absolute minimum function that can be benchmarked - it does nothing.

* ``AddTest``
A simple addition metric, again of minimal complexity.

* ``MultiplyTest``
A simple multiplication metric, again of minimal complexity.

* ``Fibonacci``
Benchmarking a Fibonacci implementation, measuring the computation time for the first N Fibonacci numbers.


## Builds
Builds are managed with love by Github Actions: 

[Build](https://github.com/NewDayTechnology/benchmarkdotnetdemo/actions)

## Further Reading

[Licence](LICENSE)

[Code of Conduct](CODE_OF_CONDUCT.md)

[Contributing](CONTRIBUTING.md)

[Support](SUPPORT.MD)
