using Plugin.MobFoxAds.Abstractions;
using System;

namespace Plugin.MobFoxAds
{
  /// <summary>
  /// Cross platform MobFoxAds implemenations
  /// </summary>
  public class CrossMobFoxAds
  {
    static Lazy<IMobFoxAds> Implementation = new Lazy<IMobFoxAds>(() => CreateMobFoxAds(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

    /// <summary>
    /// Current settings to use
    /// </summary>
    public static IMobFoxAds Current
    {
      get
      {
        var ret = Implementation.Value;
        if (ret == null)
        {
          throw NotImplementedInReferenceAssembly();
        }
        return ret;
      }
    }

    static IMobFoxAds CreateMobFoxAds()
    {
#if PORTABLE
        return null;
#else
        return new MobFoxAdsImplementation();
#endif
    }

    internal static Exception NotImplementedInReferenceAssembly()
    {
			return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
    }
  }
}
