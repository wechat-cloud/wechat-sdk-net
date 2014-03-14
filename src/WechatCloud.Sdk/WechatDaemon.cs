//
//  MyClass.cs
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
using System.Threading.Tasks;

namespace WechatCloud.Sdk
{
    public class WechatDaemon : MarshalByRefObject, IWechatDaemon
    {
        private readonly string _appid;
        private readonly string _secret;
        private readonly DaemonConfiguration _configuration;

        private MessageHandlerCollection _messageHandlerCollection = new MessageHandlerCollection();

        public WechatDaemon(string appid, string secret)
            : this(appid, secret, new DaemonConfiguration()) { }

        public WechatDaemon(string appid, string secret, DaemonConfiguration configuration) {
            _appid = appid;
            _secret = secret;
            _configuration = configuration;
        }

        public void SubscribeEvent<T>(IMessageHandler<T> handler) where T : InMessageBase {
            var messageType = typeof(T);
            if(_messageHandlerCollection.ContainsKey(messageType)) {
                throw new InvalidOperationException("handler already registered");
            }

            _messageHandlerCollection.Add(messageType, handler);
        }

        public void UnsubscribeEvent<T>(IMessageHandler<T> handler) where T : InMessageBase {
            var messageType = typeof(T);
            if(_messageHandlerCollection.ContainsKey(messageType)) {
                _messageHandlerCollection.Remove(messageType);
            }
        }

        public Task<IWechatDaemon> ListeningAsync(IMessagePipleline pipleine) {
            throw new NotImplementedException();
        }

        public void Dispose() {
            throw new NotImplementedException();
        }
    }
}

