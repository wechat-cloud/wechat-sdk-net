//
//  LocationMessage.cs
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
	/// <MsgType><![CDATA[location]]></MsgType>
	/// <Location_X>23.134521</Location_X>
	/// <Location_Y>113.358803</Location_Y>
	/// <Scale>20</Scale>
	/// <Label><![CDATA[位置信息]]></Label>
	/// <MsgId>1234567890123456</MsgId>
	/// </xml> 
	/// 参数	            描述
	/// ToUserName		开发者微信号
	/// FromUserName	发送方帐号（一个OpenID）
	/// CreateTime	 	消息创建时间 （整型）
	/// MsgType	 		location
	/// Location_X	 	地理位置纬度
	/// Location_Y	 	地理位置经度
	/// Scale	 		地图缩放大小
	/// Label	 		地理位置信息
	/// MsgId	 		消息id，64位整型
	public class LocationMessage
	{
		public LocationMessage() {
		}
	}
}

