//
//  ApiInvocationLimitation.cs
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

namespace WeChatSdk.Core.Global
{
    public class Limitation
    {
        public const int 获取access_token = 2000;
        public const int 自定义菜单创建 = 1000;
        public const int 自定义菜单查询 = 10000;
        public const int 自定义菜单删除 = 1000;
        public const int 创建分组 = 1000;
        public const int 获取分组 = 1000;
        public const int 修改分组名 = 1000;
        public const int 移动用户分组 = 100000;
        public const int 上传多媒体文件 = 5000;
        public const int 下载多媒体文件 = 10000;
        public const int 发送客服消息 = 500000;
        public const int 获取带参数的二维码 = 100000;
        public const int 获取关注者列表 = 500;
        public const int 获取用户基本信息 = 5000000;
        public const int 获取网页授权access_token = 2000000;
        public const int 刷新网页授权access_token = 2000000;
        public const int 网页授权获取用户信息 = 2000000;
    }
}