//
//  EventMessage.cs
//
//  Author:
//       lurongkai <lurongkai@gmail.com>
//
//  Copyright (c) 2013 lurongkai
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

namespace WechatCloud.Core.Messages
{
    /// <xml><ToUserName><![CDATA[toUser]]></ToUserName>
    /// <FromUserName><![CDATA[FromUser]]></FromUserName>
    /// <CreateTime>123456789</CreateTime>
    /// <MsgType><![CDATA[event]]></MsgType>
    /// <Event><![CDATA[EVENT]]></Event>
    /// <EventKey><![CDATA[EVENTKEY]]></EventKey>
    /// </xml>
    /// 参数	            描述
    /// ToUserName	 	接收方微信号
    /// FromUserName	发送方微信号，若为普通用户，则是一个OpenID
    /// CreateTime	 	消息创建时间
    /// MsgType	 		消息类型，event
    /// Event	 		事件类型，subscribe(订阅)、unsubscribe(取消订阅)、CLICK(自定义菜单点击事件)
    /// EventKey	 	事件KEY值，与自定义菜单接口中KEY值对应
    public abstract class EventMessage : MessageBase
    {
        public virtual string Event { get; protected set; }
    }
}

