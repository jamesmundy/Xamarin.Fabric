using Foundation;

// @interface Fabric : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface Fabric
{
	// +(instancetype _Nonnull)with:(NSArray * _Nonnull)kitClasses;
	[Static]
	[Export ("with:")]
	Fabric With (NSObject[] kitClasses);

	// +(instancetype _Nonnull)sharedSDK;
	[Static]
	[Export ("sharedSDK")]
	Fabric SharedSDK ();

	// @property (assign, nonatomic) BOOL debug;
	[Export ("debug")]
	bool Debug { get; set; }
}
