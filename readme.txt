Server
	http://nugetserver.net/
	https://docs.microsoft.com/pt-br/nuget/hosting-packages/overview

	Install-Package NuGet.Server -Version 3.1.2

Client
	*.csproj
  
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>netstandard2.0</TargetFramework>
    <Version>1.0.0</Version>
    <Authors>Calazans</Authors>
    <Company>Calazans Corp</Company>
    <Description>Teste pacotes nuget</Description>
    <PackageLicenseUrl>https://github.com/rcalazansn</PackageLicenseUrl>
    <PackageProjectUrl>https://github.com/rcalazansn</PackageProjectUrl>
    <RepositoryUrl>https://github.com/rcalazansn</RepositoryUrl>
    <AssemblyVersion>1.0.0.0</AssemblyVersion>
    <FileVersion>1.0.0.0</FileVersion>
    <FileVersion>1.0.0.0</FileVersion>
    <PackageId>nuget_consoleMSG</PackageId>
  </PropertyGroup>

</Project>

executar (pasta onde esta o *.csproj): dotnet pack
