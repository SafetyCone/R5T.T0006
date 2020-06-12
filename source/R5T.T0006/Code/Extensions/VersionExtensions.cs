using System;


namespace R5T.T0006
{
    public static class VersionExtensions
    {
        public static string ToStringProjectFileStandard(this Version version)
        {
            var representation = $"{version.Major}.{version.Minor}";
            return representation;
        }
    }
}
