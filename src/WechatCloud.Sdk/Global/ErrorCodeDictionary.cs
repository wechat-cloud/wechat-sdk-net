//
//  ErrorCodeDictionary.cs
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
    public class ErrorCodeDictionary
    {
        private static IDictionary<int, string> _errorDict = new Dictionary<int, string>();

        static ErrorCodeDictionary() {
            _errorDict.Add(-1,    @"系统繁忙");
            _errorDict.Add(0,     @"请求成功");
            _errorDict.Add(40001, @"获取access_token时AppSecret错误，或者access_token无效");
            _errorDict.Add(40002, @"不合法的凭证类型");
            _errorDict.Add(40003, @"不合法的OpenID");
            _errorDict.Add(40004, @"不合法的媒体文件类型");
            _errorDict.Add(40005, @"不合法的文件类型");
            _errorDict.Add(40006, @"不合法的文件大小");
            _errorDict.Add(40007, @"不合法的媒体文件id");
            _errorDict.Add(40008, @"不合法的消息类型");
            _errorDict.Add(40009, @"不合法的图片文件大小");
            _errorDict.Add(40010, @"不合法的语音文件大小");
            _errorDict.Add(40011, @"不合法的视频文件大小");
            _errorDict.Add(40012, @"不合法的缩略图文件大小");
            _errorDict.Add(40013, @"不合法的APPID");
            _errorDict.Add(40014, @"不合法的access_token");
            _errorDict.Add(40015, @"不合法的菜单类型");
            _errorDict.Add(40016, @"不合法的按钮个数");
            _errorDict.Add(40017, @"不合法的按钮个数");
            _errorDict.Add(40018, @"不合法的按钮名字长度");
            _errorDict.Add(40019, @"不合法的按钮KEY长度");
            _errorDict.Add(40020, @"不合法的按钮URL长度");
            _errorDict.Add(40021, @"不合法的菜单版本号");
            _errorDict.Add(40022, @"不合法的子菜单级数");
            _errorDict.Add(40023, @"不合法的子菜单按钮个数");
            _errorDict.Add(40024, @"不合法的子菜单按钮类型");
            _errorDict.Add(40025, @"不合法的子菜单按钮名字长度");
            _errorDict.Add(40026, @"不合法的子菜单按钮KEY长度");
            _errorDict.Add(40027, @"不合法的子菜单按钮URL长度");
            _errorDict.Add(40028, @"不合法的自定义菜单使用用户");
            _errorDict.Add(40029, @"不合法的oauth_code");
            _errorDict.Add(40030, @"不合法的refresh_token");
            _errorDict.Add(40031, @"不合法的openid列表");
            _errorDict.Add(40032, @"不合法的openid列表长度");
            _errorDict.Add(40033, @"不合法的请求字符，不能包含\uxxxx格式的字符");
            _errorDict.Add(40035, @"不合法的参数");
            _errorDict.Add(40038, @"不合法的请求格式");
            _errorDict.Add(40039, @"不合法的URL长度");
            _errorDict.Add(40050, @"不合法的分组id");
            _errorDict.Add(40051, @"分组名字不合法");
            _errorDict.Add(41001, @"缺少access_token参数");
            _errorDict.Add(41002, @"缺少appid参数");
            _errorDict.Add(41003, @"缺少refresh_token参数");
            _errorDict.Add(41004, @"缺少secret参数");
            _errorDict.Add(41005, @"缺少多媒体文件数据");
            _errorDict.Add(41006, @"缺少media_id参数");
            _errorDict.Add(41007, @"缺少子菜单数据");
            _errorDict.Add(41008, @"缺少oauth code");
            _errorDict.Add(41009, @"缺少openid");
            _errorDict.Add(42001, @"access_token超时");
            _errorDict.Add(42002, @"refresh_token超时");
            _errorDict.Add(42003, @"oauth_code超时");
            _errorDict.Add(43001, @"需要GET请求");
            _errorDict.Add(43002, @"需要POST请求");
            _errorDict.Add(43003, @"需要HTTPS请求");
            _errorDict.Add(43004, @"需要接收者关注");
            _errorDict.Add(43005, @"需要好友关系");
            _errorDict.Add(44001, @"多媒体文件为空");
            _errorDict.Add(44002, @"POST的数据包为空");
            _errorDict.Add(44003, @"图文消息内容为空");
            _errorDict.Add(44004, @"文本消息内容为空");
            _errorDict.Add(45001, @"多媒体文件大小超过限制");
            _errorDict.Add(45002, @"消息内容超过限制");
            _errorDict.Add(45003, @"标题字段超过限制");
            _errorDict.Add(45004, @"描述字段超过限制");
            _errorDict.Add(45005, @"链接字段超过限制");
            _errorDict.Add(45006, @"图片链接字段超过限制");
            _errorDict.Add(45007, @"语音播放时间超过限制");
            _errorDict.Add(45008, @"图文消息超过限制");
            _errorDict.Add(45009, @"接口调用超过限制");
            _errorDict.Add(45010, @"创建菜单个数超过限制");
            _errorDict.Add(45015, @"回复时间超过限制");
            _errorDict.Add(45016, @"系统分组，不允许修改");
            _errorDict.Add(45017, @"分组名字过长");
            _errorDict.Add(45018, @"分组数量超过上限");
            _errorDict.Add(46001, @"不存在媒体数据");
            _errorDict.Add(46002, @"不存在的菜单版本");
            _errorDict.Add(46003, @"不存在的菜单数据");
            _errorDict.Add(46004, @"不存在的用户");
            _errorDict.Add(47001, @"解析JSON/XML内容错误");
            _errorDict.Add(48001, @"api功能未授权");
            _errorDict.Add(50001, @"用户未授权该api");
        }

        public static string GetErrorMessage(int errorCode) {
            if(_errorDict.ContainsKey(errorCode)) {
                return _errorDict[errorCode];
            }

            return "Unreconginzed error";
        }
    }
}

