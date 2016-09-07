using System.Reflection;

[assembly: AssemblyCompany(ShardedAssemblyInfo.Company)]
[assembly: AssemblyProduct(ShardedAssemblyInfo.Product)]
[assembly: AssemblyCopyright(ShardedAssemblyInfo.Copyright)]
[assembly: AssemblyVersion(ShardedAssemblyInfo.AssemblyVersion)]
////[assembly: AssemblyFileVersion(ShardedAssemblyInfo.AssemblyFileVersion)]
////[assembly: AssemblyInformationalVersion(ShardedAssemblyInfo.AssemblyInformationalVersion)]
[assembly: AssemblyInformationalVersion(ShardedAssemblyInfo.AssemblyVersion)]

internal static class ShardedAssemblyInfo
{
    public const string Product = "PIS";
    public const string Company = "Guangzhou XY Information Technolony Co.,Ltd.";

    public const string AssemblyVersion = "3.0.0.3";
    ////public const string AssemblyFileVersion = "3.0.*.*";
    ////public const string AssemblyInformationalVersion = "3.0.0.2";

    public const string Copyright = "© Copyright 2016 PIS Team. All rights reserved.";
}