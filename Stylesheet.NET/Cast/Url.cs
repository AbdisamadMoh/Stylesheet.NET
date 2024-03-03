using System;
namespace Stylesheet.NET
{
    /// <summary>
    /// Css Url object. Equavalent to url(...) in css.
    /// </summary>
    public class Url
    {
        /// <summary>
        /// Returns the url.
        /// </summary>
        public string URL
        {
            get;
        }
        /// <summary>
        /// Whether the url is dealt as a string or non string.
        /// <br/>
        /// Example:
        /// <br/>
        /// String url: 'some_url/file.css'
        /// <br/>
        /// Non string url: some_url/file.css
        /// </summary>
        public bool UrlIsNotString
        {
            get; set;
        }
        /// <summary>
        /// Creates url object fromt url path provided
        /// </summary>
        /// <param name="url">Url</param>
        /// <param name="urlIsNotString">Whether the url is dealt as a string or non string.
        /// <br/>
        /// Example:
        /// <br/>
        ///  String url: 'some_url/file.css'
        /// <br/>
        /// Non string url: some_url/file.css</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Url(string url, bool urlIsNotString = false)
        {
            if (url.IsNullOrWhiteSpace())
                throw new ArgumentNullException("Url can not be null");
            UrlIsNotString = urlIsNotString;
            URL = url;
        }
        /// <summary>
        /// Returns css value of the current object.
        /// <code>Note: Does not end with semicolon ';'.</code>
        /// </summary>
        /// <returns></returns>
        /// <param name="url"></param>
        public static implicit operator string(Url url)
        {
            return url.GetCss();
        }
        /// <summary>
        /// Returns css value of the current object.
        /// <code>Note: Does not end with semicolon ';'.</code>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return GetCss();
        }
        /// <summary>
        /// Returns css value of the current object.
        /// <code>Note: Does not end with semicolon ';'.</code>
        /// </summary>
        /// <returns></returns>
        public string GetCss()
        {
            var url = this.URL.Trim();
            while (url.StartsWith("'") || url.StartsWith("\""))
            {
                url = url.Substring(1);
            }
            while (url.EndsWith("'") || url.EndsWith("\""))
            {
                url = url.Substring(0, url.Length - 1);
            }
            return UrlIsNotString ? $"url({url})" : $"url('{url}')";
        }
    }
}
