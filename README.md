# ProtoBufTest
Some tests and benchmarkes using Google ProtoBuf library.

I used .NET Standard 2.0 for libraries and .NET Framework 4.5 for Unit Tests. Google.ProtoBuf NuGet package says that it even supports .Net Standard 1.0 if I remember correctly.

Since I did not want to include any binary, you should download a pre-build (or built it by yourself) proto compiler which you can get here:
[ProtoBuf Releases](https://github.com/google/protobuf/releases "ProtoBuf Releases")

The performance are so damn good, here some results:

| Library             | 40.000 De/Serialize loops  | Serialized size        |
|:------------------- |:--------------------------:|:----------------------:|
| .NET Framework JSON | 1.200ms                    | 511 bytes (prettyfied) |
| Newtonsoft JSON     | 850ms                      | 299 bytes              |
| Google ProtoBuf     | 84ms                       | 84 bytes               |

If you recompile My.Models.ProtoBufDefs it will generate the models for My.Models automatically.

So far I am very happy about ProtoBuf. The I/O per seconds are extremely high compared to JSON, one thing that is extremely important for the high-performance micro-services of the company which I am working on.

In the future I would like to create custom HTTP filters for WCF and WebAPI (both ASP.NET 5 and ASP.NET Core 2.x) in order to use this repo as base for bigger projects.
