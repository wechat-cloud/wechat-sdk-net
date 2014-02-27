//
//  TextMessage.cs
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
    /// <xml>
    /// <ToUserName><![CDATA[toUser]]></ToUserName>
    /// <FromUserName><![CDATA[fromUser]]></FromUserName> 
    /// <CreateTime>1348831860</CreateTime>
    /// <MsgType><![CDATA[text]]></MsgType>
    /// <Content><![CDATA[this is a test]]></Content>
    /// <MsgId>1234567890123456</MsgId>
    /// </xml>
    /// 
    /// 参数				描述
    /// ToUserName		开发者微信号
    /// FromUserName	发送方帐号（一个OpenID）
    /// CreateTime	 	消息创建时间 （整型）
    /// MsgType	 		text
    /// Content	 		文本消息内容
    /// MsgId	 		消息id，64位整型
    public class TextMessage : GeneralMessage
    {
        public string Content { get; private set; }

        public override string MsgType {
            get {
                return "text";
            }
        } 
    }
}

