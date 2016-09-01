using System.Reflection;

[assembly: AssemblyCompany(ShardedAssemblyInfo.Company)]
[assembly: AssemblyProduct(ShardedAssemblyInfo.Product)]
[assembly: AssemblyCopyright(ShardedAssemblyInfo.Copyright)]
[assembly: AssemblyVersion(ShardedAssemblyInfo.VersionString)]
[assembly: AssemblyInformationalVersion(ShardedAssemblyInfo.InformationalVersion)]

internal static class ShardedAssemblyInfo
{
    public const string Company = "Guangzhou XY Information Technolony Co.,Ltd.";
    public const string Product = "PIS";
    public const string VersionString = "3.0.1.2";
    public const string InformationalVersion = VersionString;
    public const string Copyright = "© Copyright 2016 PIS Team. All rights reserved.";
}