//
//  MessageHandlerCollection.cs
//
//  Author:
//       Lu Rongkai <lurongkai@gmail.com>
//
//  Copyright (c) 2014 lurongkai
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
//
using System;
using System.Collections.Generic;

namespace WechatCloud.Sdk
{
    public class MessageHandlerCollection : IDictionary<Type, IMessageHandler<InMessageBase>> 
    {
        private IDictionary<Type, IMessageHandler<InMessageBase>> _innerDictionary = new Dictionary<Type, IMessageHandler<InMessageBase>>();

        public void Add(Type key, IMessageHandler<InMessageBase> value) {
            _innerDictionary.Add(key, value);
        }

        public void Add<T>(Type key, IMessageHandler<T> value) where T: InMessageBase {
            Add(key, value);
        }

        public bool ContainsKey(Type key) {
            return _innerDictionary.ContainsKey(key);
        }

        public bool Remove(Type key) {
            return _innerDictionary.Remove(key);
        }

        public bool TryGetValue(Type key, out IMessageHandler<InMessageBase> value) {
            return _innerDictionary.TryGetValue(key, out value);
        }

        public IMessageHandler<InMessageBase> this[Type index] {
            get {
                return _innerDictionary[index];
            }
            set {
                _innerDictionary[index] = value;
            }
        }

        public ICollection<Type> Keys {
            get {
                return _innerDictionary.Keys;
            }
        }

        public ICollection<IMessageHandler<InMessageBase>> Values {
            get {
                return _innerDictionary.Values;
            }
        }

        public void Add(KeyValuePair<Type, IMessageHandler<InMessageBase>> item) {
            _innerDictionary.Add(item);
        }

        public void Clear() {
            _innerDictionary.Clear();
        }

        public bool Contains(KeyValuePair<Type, IMessageHandler<InMessageBase>> item) {
            return _innerDictionary.Contains(item);
        }

        public void CopyTo(KeyValuePair<Type, IMessageHandler<InMessageBase>>[] array, int arrayIndex) {
            _innerDictionary.CopyTo(array, arrayIndex);
        }

        public bool Remove(KeyValuePair<Type, IMessageHandler<InMessageBase>> item) {
            return _innerDictionary.Remove(item);
        }

        public int Count {
            get {
                return _innerDictionary.Count;
            }
        }

        public bool IsReadOnly {
            get {
                return _innerDictionary.IsReadOnly;
            }
        }

        public IEnumerator<KeyValuePair<Type, IMessageHandler<InMessageBase>>> GetEnumerator() {
            return _innerDictionary.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
    }
}

