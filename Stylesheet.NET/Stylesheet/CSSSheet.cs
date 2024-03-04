using System;
using System.Collections.Generic;


namespace Stylesheet.NET
{
    /// <summary>
    /// Represents a CSS Stylesheet. It is where you will write all your css.
    /// </summary>
    public class CSSSheet : BaseSheet
    {
        #region fields
        readonly List<MediaQuery> _mediaQuery = new List<MediaQuery>();
        readonly List<Keyframes> _keyframes = new List<Keyframes>();
        List<Layer> _Layers = new List<Layer>();
        List<Import> _imports = new List<Import>();
        List<Dictionary<string, string>> _fontfaces = new List<Dictionary<string, string>>();

        #endregion

        #region properties

        /// <summary>
        /// The Charset rule specifies the character encoding used in the style sheet.
        /// <code>@charset "utf-8";</code>
        /// </summary>
        public string Charset
        {
            get; set;
        }

        /// <summary>
        /// The Root matches the document's root element. In HTML, the root element is always the html element.
        /// </summary>
        public Root Root
        {
            get; set;
        }
        public ICssObject this[AtRuleType rule]
        {
            //get
            //{
            //    if (rule == AtRuleType.MediaQuery)
            //        return _mediaQuery;
            //    if (rule == AtRuleType.Keyframes)
            //        return _keyframes;
            //    return null;
            //}
            set
            {
                if (rule == AtRuleType.MediaQuery)
                {
                    if (value == null)
                        throw new ArgumentNullException("Media query can not be null.");
                    if (value.GetType() != typeof(MediaQuery))
                        throw new InvalidCastException("Type of 'MediaQuery' is required for this operation.");

                    _mediaQuery.Add(value as MediaQuery);
                    return;
                }

                if (rule == AtRuleType.Keyframes)
                {
                    if (value == null)
                        throw new ArgumentNullException("Keyframes can not be null.");
                    if (value.GetType() != typeof(Keyframes))
                        throw new InvalidCastException("Type of 'Keyframes' is required for this operation.");

                    _keyframes.Add(value as Keyframes);
                    return;
                }

            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns unminified CSS stylesheet as a string from the current object.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return GenerateCss();
        }
        /// <summary>
        /// Returns CSS stylesheet as a string from the current object.
        /// </summary>
        /// <param name="minified">Whether returned CSS should be minified</param>
        /// <returns></returns>
        public override string ToString(bool minified)
        {
            return GenerateCss(minified);
        }
        /// <summary>
        /// Returns unminified CSS stylesheet as a string from the current object.
        /// </summary>
        /// <returns></returns>
        public override string GenerateCss()
        {
            return GenerateCss(false);
        }

        /// <summary>
        /// Returns CSS stylesheet as a string from the current object.
        /// </summary>
        /// <param name="minified">Whether returned CSS should be minified</param>
        /// <returns></returns>
        public override string GenerateCss(bool minified)
        {
            string newLine = minified ? "" : "\n";
            string space = minified ? "" : " ";
            string indent = minified ? "" : Extension.Indent;
            var css = "";
            string charset = this.Charset.IsNullOrWhiteSpace() ? "" : $"@charset \"{this.Charset}\";{newLine}";

            var _layers = "";

            if (_Layers.Count > 0)
            {
                foreach (var layer in _Layers)
                {
                    _layers += $"@layer {layer.LayerName}{space}{{{newLine}{layer.GenerateCss(minified)}{newLine}}}{newLine}";
                }
            }
            var imports = "";
            foreach (var im in _imports)
            {
                if (im == null)
                    continue;
                imports += $"{im.GetCss()}{newLine}";
            }
            var fontfaces = "";
            foreach (var font in _fontfaces)
            {
                var fcss = $"@font-face{space}{{{newLine}";
                foreach (var kv in font)
                {
                    fcss += $"{indent}{kv.Key}:{space}{kv.Value};{newLine}";
                }
                fcss += $"}}";
                fontfaces += $"{fcss}{newLine}";
            }
            var root = Root != null ? Root.GenerateCss(minified) : "";
            css += $"{charset}{_layers}{imports}{fontfaces}{root}{newLine}{this.GetCss(minified)}{newLine}";


            foreach (Keyframes keyframe in _keyframes)
            {
                css += $"{keyframe.GetFramesCss(minified)}{newLine}";
            }

            foreach (var _mq in _mediaQuery)
            {
                css += $"{_mq.ToString(minified)}{newLine}";
            }

            return css;

        }

        /// <summary>
        /// Used to import an external CSS file into the current stylesheet.
        /// </summary>
        /// <param name="import"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Import(Import import)
        {
            if (import == null)
                throw new ArgumentNullException();
            _imports.Add(import);
        }

        /// <summary>
        /// Removes an imported external CSS file from the current stylesheet.
        /// </summary>
        /// <param name="import"></param>
        /// <returns></returns>
        public bool RemoveImport(Import import)
        {
            return _imports.Remove(import);
        }

        /// <summary>
        /// Removes all imported external CSS files from the current stylesheet.
        /// </summary>
        public void ClearImport()
        {
            _imports.Clear();
        }

        /// <summary>
        /// Adds a stylesheet layer to the current stylesheet object.
        /// </summary>
        /// <param name="layerName">The name of the layer</param>
        /// <param name="layer">Layer to be added</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Layer AddLayer(string layerName, Layer layer)
        {
            if (layer == null)
                throw new ArgumentNullException(layerName);
            //unnamed layer
            if (layerName.IsNullOrWhiteSpace())
            {
                layer.LayerName = layerName;
                _Layers.Add(layer);
                return layer;
            }

            //if already exists update
            for (int i = 0; i < _Layers.Count; i++)
            {
                if (_Layers[i].LayerName.IsNullOrWhiteSpace())
                    continue;
                if (_Layers[i].LayerName.Trim() == layerName.Trim())
                {
                    layer.LayerName = layerName;
                    _Layers[i] = layer;
                    return layer;
                }
            }

            //if not exists add
            layer.LayerName = layerName;
            _Layers.Add(layer);
            return layer;
        }

        /// <summary>
        /// Removes a layer from the current stylesheet object.
        /// </summary>
        /// <param name="layer">Layer to be removed</param>
        /// <returns></returns>
        public bool RemoveLayer(Layer layer)
        {
            if (layer == null)
                return false;
            return _Layers.Remove(layer);
        }

        /// <summary>
        /// Removes a layer from the current stylesheet object.
        /// </summary>
        /// <param name="layerName">Name of the layer to be removed</param>
        /// <returns></returns>
        public bool RemoveLayer(string layerName)
        {
            if (layerName.IsNullOrWhiteSpace())
                return false;
            for (int i = 0; i < _Layers.Count; i++)
            {
                if (_Layers[i].LayerName.Trim() == layerName.Trim())
                {

                    _Layers.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Removes all layers from the current stylesheet object.
        /// </summary>
        public void ClearLayers()
        {
            _Layers.Clear();
        }

        /// <summary>
        /// Adds Defined custom font to be used.
        /// <code>Example:
        /// <br/>
        /// AddFontFace("Sansation Light Font", "font/SansationLight.woff")</code>
        /// </summary>
        /// <param name="fontFamily"></param>
        /// <param name="source"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddFontFace(string fontFamily, string source)
        {
            if (fontFamily.IsNullOrWhiteSpace() || source.IsNullOrWhiteSpace())
                throw new ArgumentNullException("AddFontFace");
            _fontfaces.Add(new Dictionary<string, string>()
            {
                {"font-family", $"\"{fontFamily}\""},
                {"src", new Url(source)}
            });
        }

        /// <summary>
        /// Adds Defined custom font to be used. 
        /// </summary>
        /// <param name="fontface_properties">Key, value properties of the font.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddFontFace(Dictionary<string, string> fontface_properties)
        {
            if (fontface_properties == null)
                throw new ArgumentNullException("AddFontFace");
            if (fontface_properties.Count == 0)
                return;
            var fontf = new Dictionary<string, string>();
            foreach (var kv in fontface_properties)
            {
                fontf.Add(kv.Key, kv.Value);
            }
            _fontfaces.Add(fontf);
        }

        /// <summary>
        /// Removes facefont using its fontfamily key.
        /// </summary>
        /// <param name="fontFamily"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool RemoveFontFace(string fontFamily)
        {
            if (fontFamily.IsNullOrWhiteSpace())
                throw new ArgumentNullException("RemoveFontFace: famliyName");
            bool isremoved = false;
            for (int i = 0; i < _fontfaces.Count; i++)
            {
                var font = _fontfaces[i];
                if (font.ContainsKey("font-family"))
                {
                    if (font["font-family"].Trim().ToLower() == fontFamily.Trim().ToLower())
                    {
                        isremoved = true;
                        _fontfaces.RemoveAt(i);
                    }

                }
            }

            return isremoved;
        }


        /// <summary>
        /// Removes all fontface from the current stylesheet object.
        /// </summary>
        public void ClearFontFace()
        {
            _fontfaces.Clear();
        }

        #endregion
    }
}
