using ObjCRuntime;

[assembly: LinkWith ("Crashlytics.a", SmartLink = true, ForceLoad = true, Frameworks = "Security SystemConfiguration", LinkerFlags = "-lstdc++ -lz")]
