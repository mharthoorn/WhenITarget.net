using System.Collections.Generic;

namespace Moniker.Model
{
    public static class NetworkBuilder
    {
        public static Network Build()
        {
            // Sources: 
            // http://blog.stephencleary.com/2012/05/framework-profiles-in-net.html
            // https://docs.microsoft.com/en-us/dotnet/articles/standard/library

            var network = new Network();
            
            network.Add(Group.NET, Key.net11, ".NET framework 1.1", Kind.Framework);
            network.Add(Group.NET, Key.net20, ".NET framework 2.0", Kind.Framework);
            network.Add(Group.NET, Key.net35, ".NET framework 3.5", Kind.Framework);
            network.Add(Group.NET, Key.net40, ".NET framework 4.0", Kind.Framework);
            network.Add(Group.NET, Key.net403, ".NET framework 4.0.3", Kind.Framework);
            network.Add(Group.NET, Key.net45, ".NET framework 4.5", Kind.Framework);
            network.Add(Group.NET, Key.net451, ".NET framework 4.5.1", Kind.Framework);
            network.Add(Group.NET, Key.net452, ".NET framework 4.5.2", Kind.Framework);
            network.Add(Group.NET, Key.net46, ".NET framework 4.6", Kind.Framework);
            network.Add(Group.NET, Key.net461, ".NET framework 4.6.1", Kind.Framework);
            network.Add(Group.NET, Key.net462, ".NET framework 4.6.2", Kind.Framework);
            network.Add(Group.NET, Key.net463, ".NET framework 4.6.2", Kind.Framework);
            network.Add(Group.Other, Key.netmf, ".NET Microframework", Kind.Framework);
            network.Add(Group.Other, Key.wp7, "Windows Phone 7", Kind.Framework);
            network.Add(Group.Other, Key.wp8, "Windows Phone 8", Kind.Framework);
            network.Add(Group.Other, Key.wp81, "Windows Phone 8.1", Kind.Framework);
            network.Add(Group.Other, Key.wpa81, "Windows Phone 8.1", Kind.Framework);
            network.Add(Group.Other, Key.uap10, "Univeral Windows Platform", Kind.Framework);
            network.Add(Group.Other, Key.mono, "Mono/Xamarin", Kind.Framework);

            network.Add(Group.Other, Key.sl4, "Silverlight 4.0", Kind.Framework);
            network.Add(Group.Other, Key.sl5, "Silverlight 5.0", Kind.Framework);

            network.Add(Group.netstandard, Key.netstandard1_0, ".NET platform standard 1.0", Kind.Standard);
            network.Add(Group.netstandard, Key.netstandard1_1, ".NET platform standard 1.1", Kind.Standard);
            network.Add(Group.netstandard, Key.netstandard1_2, ".NET platform standard 1.2", Kind.Standard);
            network.Add(Group.netstandard, Key.netstandard1_3, ".NET platform standard 1.3", Kind.Standard);
            network.Add(Group.netstandard, Key.netstandard1_4, ".NET platform standard 1.4", Kind.Standard);
            network.Add(Group.netstandard, Key.netstandard1_5, ".NET platform standard 1.5", Kind.Standard);
            network.Add(Group.netstandard, Key.netstandard1_6, ".NET platform standard 1.6", Kind.Standard);

            network.Add(Group.netcoreapp, Key.netcoreapp1_0, ".NET core 1.0", Kind.Framework);

            // will deal with this later
            network.Add(Group.WinStore, Key.win8, ".NET Windows Store 8", Kind.Framework);
            network.Add(Group.WinStore, Key.win81, ".NET Windows Store 8.1", Kind.Framework);
            //network.Add(Group.WinStore, Key.win, ".NET Windows Store 8.1", Kind.Framework);
            network.Add(Group.WinStore, Key.win10, ".NET Windows 10 Store", Kind.Framework);

            network.Add(Group.Browser, Key.Silverlight, "Silverlight Browser platform", Kind.Framework);
            /*
            network.Add(Group.WinStoreNetCore, Key.netcore, ".NET Core for Windows Store", Kind.Framework);
            network.Add(Group.WinStoreNetCore, Key.netcore45, ".NET Core 4.5 for Windows Store", Kind.Framework);
            network.Add(Group.WinStoreNetCore, Key.netcore451, ".NET Core 4.5.1 for Windows Store", Kind.Framework);
            network.Add(Group.WinStoreNetCore, Key.netcore50, ".NET Core 5.0 for Windows Store", Kind.Framework);
            */

            // only PCLs that exist in a netstandard are turned on here.
            network.Add(Group.PCL, Key.Profile2, "portable-net40+win8+sl4+wp7", Kind.Standard);
            network.Add(Group.PCL, Key.Profile3, "portable-net40+sl4", Kind.Standard);
            network.Add(Group.PCL, Key.Profile4, "portable-net45+sl4+win8+wp7", Kind.Standard);
            //network.Add(Group.PCL, Key.Profile5, "portable-net40+win8", Kind.Standard);
            //network.Add(Group.PCL, Key.Profile6, "portable-net403+win8", Kind.Standard);
            network.Add(Group.PCL, Key.Profile7, "portable-net45+win8", Kind.Standard);

            network.Add(Group.PCL, Key.Profile14, "portable-net40+sl5", Kind.Standard);
            network.Add(Group.PCL, Key.Profile18, "portable-net403+sl4", Kind.Standard);
            network.Add(Group.PCL, Key.Profile19, "portable-net403+sl5", Kind.Standard);
            network.Add(Group.PCL, Key.Profile23, "portable-net45+sl4", Kind.Standard);
            network.Add(Group.PCL, Key.Profile24, "portable-net45+sl5", Kind.Standard);
            network.Add(Group.PCL, Key.Profile31, "portable-win81+wp81", Kind.Standard);
            network.Add(Group.PCL, Key.Profile32, "portable-win81+wpa81", Kind.Standard);
            network.Add(Group.PCL, Key.Profile36, "portable-net40+sl4+win8+wp8", Kind.Standard);
            network.Add(Group.PCL, Key.Profile37, "portable-net40+sl5+win8", Kind.Standard);
            network.Add(Group.PCL, Key.Profile41, "portable-net403+sl4+win8", Kind.Standard);
            network.Add(Group.PCL, Key.Profile44, "portable-net451+win81", Kind.Standard);
            network.Add(Group.PCL, Key.Profile49, "portable-net45+wp8", Kind.Standard);
            network.Add(Group.PCL, Key.Profile78, "portable-net45+win8+wp8", Kind.Standard);
            network.Add(Group.PCL, Key.Profile84, "portable-wp81+wpa81", Kind.Standard);
            network.Add(Group.PCL, Key.Profile111, "portable-net45+win8+wpa81", Kind.Standard);
            network.Add(Group.PCL, Key.Profile151, "portable-net451+win81+wpa81", Kind.Standard);

            network.Add(Group.PCL, Key.Profile157, "portable-win81+wp81+wpa81", Kind.Standard);
            network.Add(Group.PCL, Key.Profile259, "portable-net45+win8+wpa81+wp8", Kind.Standard);

            network.Add(Group.Windows, Key.Windows10, "Windows 10", Kind.Platform);
            network.Add(Group.Windows, Key.WinStore, "Windows 10 Store", Kind.Platform);
            network.Add(Group.Windows, Key.XBox, "XBox", Kind.Platform);
            network.Add(Group.Windows, Key.Windows8_1, "Windows 8.1", Kind.Platform);
            network.Add(Group.Windows, Key.Windows8, "Windows 8", Kind.Platform);
            network.Add(Group.Windows, Key.Windows7, "Windows 7", Kind.Platform);
            network.Add(Group.Windows, Key.WinPhone, "Windows Phone", Kind.Platform);

            network.Add(Group.NonWindows, Key.Ubuntu, "Ubuntu", Kind.Platform);
            network.Add(Group.NonWindows, Key.OSX, "Mac OS X", Kind.Platform);
            network.Add(Group.NonWindows, Key.IOS, "ios", Kind.Platform);
            network.Add(Group.NonWindows, Key.Ubuntu14, "Ubuntu 14, Linux Mint 17", Kind.Platform);
            network.Add(Group.NonWindows, Key.Ubuntu16, "Ubuntu 16", Kind.Platform);
            network.Add(Group.NonWindows, Key.Centos, "CentOS, Oracle Linux", Kind.Platform);
            network.Add(Group.NonWindows, Key.RHEL, "Red Hat Enterprise Linux", Kind.Platform);
            network.Add(Group.NonWindows, Key.SUSE, "Open SUSE", Kind.Platform);
            network.Add(Group.NonWindows, Key.Fedora, "fedora", Kind.Platform);
            network.Add(Group.NonWindows, Key.Android, "Android - Google", Kind.Platform);

            // Compatibility
            network.Upgrade(Key.net11, Key.net20, Key.net35, Key.net40, Key.net403, Key.net45);
            network.Upgrade(Key.net45, Key.net451, Key.net452, Key.net46, Key.net461, Key.net462, Key.net463);

            network.Link(Key.net463, Relation.RunsOn, Key.Windows10, Key.Windows7, Key.Windows8, Key.Windows8_1);
           
            // network.Link(Key.netmf);
            network.Link(Key.wp7, Relation.RunsOn, Key.WinPhone);
            network.Link(Key.wp8, Relation.RunsOn, Key.WinPhone);
            network.Link(Key.wp81, Relation.RunsOn, Key.WinPhone);
            network.Link(Key.wpa81, Relation.RunsOn, Key.WinPhone);
            network.Link(Key.uap10, Relation.RunsOn, Key.Windows10);

            network.Link(Key.mono, Relation.RunsOn, Key.IOS, Key.Android);
            network.Link(Key.netcoreapp1_0, Relation.RunsOn, Key.Windows7, Key.XBox, Key.Ubuntu, Key.OSX, Key.Ubuntu14, Key.Centos, Key.RHEL, Key.SUSE, Key.Fedora);

            network.Upgrade(Key.Windows7, Key.Windows8, Key.Windows8_1, Key.Windows10);

            network.RunsOn(Key.win8,  Key.win81, Key.WinStore, Key.Windows8);
            //network.Link(Key.win, Key.win81); //win = alias of win81
            network.RunsOn(Key.win81, Key.win, Key.WinStore, Key.Windows8_1);

            network.RunsOn(Key.win10, Key.Windows10, Key.WinStore); 
            network.RunsOn(Key.netcore, Key.WinStore);
            network.RunsOn(Key.netcore45, Key.WinStore);
            network.RunsOn(Key.netcore451, Key.WinStore);
            network.RunsOn(Key.netcore50, Key.WinStore);

            network.RunsOn(Key.sl4, Key.Silverlight);
            network.RunsOn(Key.sl5, Key.Silverlight);


            network.RunsOn(Key.Windows10, Key.XBox);
            network.RunsOn(Key.WinStore, Key.Windows10);
            //network.Link("xbox");
            //network.Link("windows81");
            network.RunsOn(Key.Windows8, Key.Windows8_1);
            network.RunsOn(Key.Windows7, Key.Windows8);
            //network.Link("ubuntu");
            //network.Link("osx");
            //network.Link("ios");
            network.RunsOn(Key.Ubuntu14, Key.Ubuntu16);
            //network.Link("ubuntu16");
            //network.Link("centos");
            //network.Link("rhel");
            //network.Link("suse");
            //network.Link("fedora");
            network.Upgrade(Key.netstandard1_0, Key.netstandard1_1, Key.netstandard1_2, Key.netstandard1_3, Key.netstandard1_4, Key.netstandard1_5, Key.netstandard1_6);

            network.RunsOn(Key.netstandard1_0, Key.wp8);
            network.RunsOn(Key.netstandard1_0, Key.Profile31, Key.Profile49, Key.Profile78, Key.Profile88, Key.Profile157, Key.Profile259);

            network.RunsOn(Key.netstandard1_1, Key.net45,  Key.win8);
            network.RunsOn(Key.netstandard1_1, Key.Profile7, Key.Profile111);
             
            network.RunsOn(Key.netstandard1_2, Key.net451, Key.win81, Key.wpa81);
            network.RunsOn(Key.netstandard1_2, Key.Profile32, Key.Profile44, Key.Profile151);

            network.RunsOn(Key.netstandard1_3, Key.net46);
            
            network.RunsOn(Key.netstandard1_4, Key.net461, Key.uap10);
            network.RunsOn(Key.netstandard1_5, Key.net462);
            network.RunsOn(Key.netstandard1_6, Key.netcoreapp1_0, Key.net463, Key.mono);

            network.AutolinkProfiles();

            return network;
        }
    }
}