using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using R5T.Magyar;
using R5T.Ostersund;
using R5T.Ostersund.Extensions;


namespace R5T.T0006
{
    public static class ProjectFileValues
    {
        public static bool ParseBoolean(string booleanString)
        {
            var boolean = bool.Parse(booleanString);
            return boolean;
        }

        public static string FormatBoolean(bool boolean)
        {
            var booleanString = boolean.ToString();
            return booleanString;
        }

        public static Version ParseLanguageVersion(string languageVersionString)
        {
            var languageVersion = Version.Parse(languageVersionString);
            return languageVersion;
        }

        public static string FormatLanguageVersion(Version languageVersion)
        {
            var languageVersionString = $"{languageVersion.Major}:{languageVersion.Minor}";
            return languageVersionString;
        }

        public static List<int> ParseNoWarn(string noWarnString)
        {
            var tokens = noWarnString.Split(';');

            var warningNumbers = tokens.Select(x => Int32.Parse(x)).ToList();
            return warningNumbers;
        }

        public static string FormatNoWarn(List<int> noWarn)
        {
            var stringBuilder = new StringBuilder();

            foreach (var warningNumber in noWarn)
            {
                stringBuilder.Append($"{warningNumber};");
            }

            stringBuilder.RemoveLast();

            var noWarnString = stringBuilder.ToString();
            return noWarnString;
        }

        public static OutputType ParseOutputType(string outputTypeString)
        {
            var outputType = outputTypeString.ToOutputType();
            return outputType;
        }

        public static string FormatOutputType(OutputType outputType)
        {
            var outputTypeString = outputType.ToStringStandard();
            return outputTypeString;
        }

        public static TargetFramework ParseTargetFramework(string targetFrameworkString)
        {
            var targetFramework = targetFrameworkString.ToTargetFramework();
            return targetFramework;
        }

        public static string FormatTargetFramework(TargetFramework targetFramework)
        {
            var targetFrameworkString = targetFramework.ToStringStandard();
            return targetFrameworkString;
        }
    }
}
