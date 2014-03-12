//
//  MessageValidationToken.cs
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

namespace WeChatSdk.Core
{
    public class MessageValidationToken
    {
        // 微信加密签名，signature结合了开发者填写的token参数和请求中的timestamp参数、nonce参数。
        public string signature{ get; set;}
        // 时间戳
        public string timestamp { get; set;}
        // 随机数
        public string nonce { get; set; }
        // 随机字符串
        public string echostr { get; set;}
    }
}

