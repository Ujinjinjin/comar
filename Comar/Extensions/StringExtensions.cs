namespace Comar.Extensions;

/// <summary> Collection of extensions for <see cref="string"/> </summary>
internal static class StringExtensions
{
	/// <summary> Returns a value indicating whether a specified substring does not occur within this string </summary>
	/// <param name="source">Source string</param>
	/// <param name="value">Substring to search</param>
	public static bool NotContains(this string source, string value)
	{
		return !source.Contains(value);
	}

	/// <summary> Replace all `\r\n` with `\n` in given string </summary>
	/// <param name="source">Source string</param>
	public static string ToUnixEol(this string source)
	{
		return source.Replace("\r\n", "\n");
	}
}