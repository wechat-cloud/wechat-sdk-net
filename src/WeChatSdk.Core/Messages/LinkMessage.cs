//
//  LinkMessage.cs
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

namespace WeChatSdk.Core
{
    /// <xml>
    /// <ToUserName><![CDATA[toUser]]></ToUserName>
    /// <FromUserName><![CDATA[fromUser]]></FromUserName>
    /// <CreateTime>1351776360</CreateTime>
    /// <MsgType><![CDATA[link]]></MsgType>
    /// <Title><![CDATA[公众平台官网链接]]></Title>
    /// <Description><![CDATA[公众平台官网链接]]></Description>
    /// <Url><![CDATA[url]]></Url>
    /// <MsgId>1234567890123456</MsgId>
    /// </xml> 
    /// 参数              描述
    /// ToUserName      接收方微信号
    /// FromUserName    发送方微信号，若为普通用户，则是一个OpenID
    /// CreateTime      消息创建时间
    /// MsgType         消息类型，link
    /// Title           消息标题
    /// Description     消息描述
    /// Url             消息链接
    /// MsgId           消息id，64位整型
    public class LinkMessage : SimpleMessage
    {    
        public string Title { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }
    }
}

