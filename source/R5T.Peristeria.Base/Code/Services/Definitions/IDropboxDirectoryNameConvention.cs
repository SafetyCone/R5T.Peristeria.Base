using System;

using R5T.T0064;


namespace R5T.Peristeria
{
    [ServiceDefinitionMarker]
    public interface IDropboxDirectoryNameConvention : IServiceDefinition
    {
        string GetDropboxDirectoryName();
    }
}
