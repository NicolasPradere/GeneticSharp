using System.Reflection;
// Switch beetwen configurantios.
#if DEBUG
 // Debug only used for development porpuses.
 [assembly: AssemblyConfiguration("Debug")]
#else
 // Only used for production porpuses. 
 [assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyVersion("2.2.0")]
[assembly: AssemblyFileVersion("2.2.0.0")]
