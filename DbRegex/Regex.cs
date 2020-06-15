using System.Data.SqlTypes;
using RX = System.Text.RegularExpressions;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString Regex(string input, string regex)
    {
        var match = RX.Regex.Match(input, regex).Groups[1].Value;
        return new SqlString (match);
    }

    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString RegexReplace(string input, string regex, string replacement)
    {
        var result = RX.Regex.Replace(input, regex, replacement);
        return new SqlString(result);
    }
}
