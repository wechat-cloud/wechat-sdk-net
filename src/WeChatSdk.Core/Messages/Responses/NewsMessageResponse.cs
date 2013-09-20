//
//  NewsMessageResponse.cs
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
    /// <CreateTime>12345678</CreateTime>
    /// <MsgType><![CDATA[news]]></MsgType>
    /// <ArticleCount>2</ArticleCount>
    /// <Articles>
    /// <item>
    /// <Title><![CDATA[title1]]></Title> 
    /// <Description><![CDATA[description1]]></Description>
    /// <PicUrl><![CDATA[picurl]]></PicUrl>
    /// <Url><![CDATA[url]]></Url>
    /// </item>
    /// <item>
    /// <Title><![CDATA[title]]></Title>
    /// <Description><![CDATA[description]]></Description>
    /// <PicUrl><![CDATA[picurl]]></PicUrl>
    /// <Url><![CDATA[url]]></Url>
    /// </item>
    /// </Articles>
    /// </xml> 
    /// 参数              描述
    /// ToUserName      接收方帐号（收到的OpenID）
    /// FromUserName    开发者微信号
    /// CreateTime      消息创建时间
    /// MsgType         news
    /// ArticleCount    图文消息个数，限制为10条以内
    /// Articles        多条图文消息信息，默认第一个item为大图
    /// Title           图文消息标题
    /// Description     图文消息描述
    /// PicUrl          图片链接，支持JPG、PNG格式，较好的效果为大图640*320，小图80*80。
    /// Url             点击图文消息跳转链接
    public class NewsMessageResponse
    {
        public NewsMessageResponse() {
        }
    }
}