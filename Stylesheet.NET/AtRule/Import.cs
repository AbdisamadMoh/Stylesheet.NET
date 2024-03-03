namespace Stylesheet.NET
{
    /// <summary>
    /// Stylesheet import object
    /// </summary>
    public class Import
    {
        internal bool PathIsNotString
        {
            get; set;
        }

        /// <summary>
        /// Creates an import object from the local path provided.
        /// </summary>
        /// <param name="path">Path e.g. path/file.css</param>
        /// <param name="_PathIsNotString">Whether the path is dealt as a string or non string.
        /// <br/>
        /// Example:
        /// <br/>
        /// String path: 'path/file.css'
        /// <br/>
        /// Non string path: path/file.css
        /// </param>
        public Import(string path, bool _PathIsNotString = false)
        {
            PathIsNotString = _PathIsNotString;
            Url = PathIsNotString ? path : $"'{path}'";
        }
        /// <summary>
        /// Creates an import object from the url provided.
        /// </summary>
        /// <param name="url"></param>
        public Import(Url url)
        {
            Url = url;
        }
        /// <summary>
        ///  Creates an import object from the local path provided and the conditional query.
        /// </summary>
        /// <param name="path">Path e.g. path/file.css</param>
        /// <param name="query">Media query</param>
        /// <param name="_PathIsNotString">Whether the path is dealt as a string or non string.
        /// <br/>
        /// Example:
        /// <br/>
        /// String path: 'path/file.css'
        /// <br/>
        /// Non string path: path/file.css
        /// </param>
        public Import(string path, string query, bool _PathIsNotString = false)
        {
            PathIsNotString = _PathIsNotString;
            Url = PathIsNotString ? path : $"'{path}'";
            QueryCondtions = query;
        }

        /// <summary>
        /// Creates an import object from the local path provided and the conditional query.
        /// </summary>
        /// <param name="path">Path e.g. path/file.css</param>
        /// <param name="query">The media query using AtRule query builder.
        /// <br/>
        /// Example:
        /// <br/>
        /// new AtRule().Screen.And.MaxWidth("480px")
        /// </param>
        /// <param name="_PathIsNotString">Whether the path is dealt as a string or non string.
        /// <br/>
        /// Example:
        /// <br/>
        /// String path: 'path/file.css'
        /// <br/>
        /// Non string path: path/file.css</param>
        public Import(string path, AtRule query, bool _PathIsNotString = false)
        {
            PathIsNotString = _PathIsNotString;
            Url = PathIsNotString ? path : $"'{path}'";
            QueryCondtions = query;
        }
        /// <summary>
        /// Creates an import object from the url path provided and the conditional query.
        /// </summary>
        /// <param name="url">url path</param>
        /// <param name="query"></param>
        public Import(Url url, string query)
        {
            Url = url;
            QueryCondtions = query;
        }
        /// <summary>
        /// Creates an import object from the url path provided and the conditional query.
        /// </summary>
        /// <param name="url">Url path</param>
        /// <param name="query">The media query using AtRule query builder.
        /// <br/>
        /// Example:
        /// <br/>
        /// new AtRule().Screen.And.MaxWidth("480px")</param>
        public Import(Url url, AtRule query)
        {
            Url = url;
            QueryCondtions = query;
        }
        public static implicit operator string(Import import)
        {
            return import.GetCss();
        }

        /// <summary>
        /// Gets the import url
        /// </summary>
        public string Url
        {
            get; private protected set;
        }

        /// <summary>
        /// Gets Media query condition
        /// </summary>
        public string QueryCondtions
        {
            get; private protected set;
        }

        /// <summary>
        /// Returns the CSS as a srting of the current object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return GetCss();
        }
        /// <summary>
        ///  Returns the CSS as a srting of the current object.
        /// </summary>
        /// <returns></returns>
        public string GetCss()
        {
            return $"@import {Url} {QueryCondtions};";
        }
    }
}
