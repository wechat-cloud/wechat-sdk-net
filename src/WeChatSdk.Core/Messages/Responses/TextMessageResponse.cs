//
//  TextMessageResponse.cs
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

namespace WeChatSdk.Core.Messages.Responses
{
    /// <xml>
    /// <ToUserName><![CDATA[toUser]]></ToUserName>
    /// <FromUserName><![CDATA[fromUser]]></FromUserName>
    /// <CreateTime>12345678</CreateTime>
    /// <MsgType><![CDATA[text]]></MsgType>
    /// <Content><![CDATA[content]]></Content>
    /// </xml>
    /// 参数  描述
    /// ToUserName      接收方帐号（收到的OpenID）
    /// FromUserName    开发者微信号
    /// CreateTime      消息创建时间
    /// MsgType         text
    /// Content         回复的消息内容,长度不超过2048字节
    public class TextMessageResponse
    {
        public TextMessageResponse() {
        }
    }
}