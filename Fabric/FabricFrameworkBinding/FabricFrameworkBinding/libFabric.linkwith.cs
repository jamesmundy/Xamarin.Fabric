using ObjCRuntime;

[assembly: LinkWith ("libFabric.a", SmartLink = true, ForceLoad = true, Frameworks = "Security SystemConfiguration", LinkerFlags = "-lstdc++ -lz")]
