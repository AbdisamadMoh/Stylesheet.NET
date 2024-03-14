using System;
using System.Collections;
using System.Collections.Generic;

namespace StylesheetNET
{
    public class StylesheetCustomDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>> 
    {
        bool _alwaysContainsKey = false;
        public StylesheetCustomDictionary(bool alwaysContainsKey = false)
        {
            _alwaysContainsKey = alwaysContainsKey;
        }

        Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();
        public TValue this[TKey key]
        {
            get
            {
           
                if(key.ToString().IsNullOrWhiteSpace()) throw new ArgumentNullException("Key");

                if (!dict.ContainsKey(key))
                {
                    if (typeof(TValue) == typeof(string))
                    {
                        var strVal = (TValue)Activator.CreateInstance(typeof(string), new object[] {"".ToCharArray()});
                        dict.Add(key, strVal);
                        return strVal;
                    }
                    var newVal = (TValue)Activator.CreateInstance(typeof(TValue), key);
                    dict.Add(key, newVal);
                    return newVal;
                }
                else
                {
                    return dict[key];
                }
            }
            set
            {
                dict[key] = value;
            }

        }

        public bool ContainsKey(TKey key)
        {
            if (_alwaysContainsKey)
                return true;

            return dict.ContainsKey(key);
        }
        public bool Remove(TKey key)
        {
            return dict.Remove(key);
        }
        public int Count
        {

            get
            {
                return dict.Count;
            }
        }
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return dict.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return dict.GetEnumerator();
        }
    }
}
