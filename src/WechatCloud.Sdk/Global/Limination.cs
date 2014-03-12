//
//  Limination.cs
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

namespace WechatCloud.Sdk
{
    public abstract class Limination
    {
        public abstract int 获取access_token { get; }
        public abstract int 自定义菜单创建 { get; }
        public abstract int 自定义菜单查询 { get; }
        public abstract int 自定义菜单删除 { get; }
        public abstract int 创建分组 { get; }
        public abstract int 获取分组 { get; }
        public abstract int 修改分组名 { get; }
        public abstract int 移动用户分组 { get; }
        public abstract int 上传多媒体文件 { get; }
        public abstract int 下载多媒体文件 { get; }
        public abstract int 发送客服消息 { get; }
        public abstract int 获取带参数的二维码 { get; }
        public abstract int 获取关注者列表 { get; }
        public abstract int 获取用户基本信息 { get; }
        public abstract int 获取网页授权access_token { get; }
        public abstract int 刷新网页授权access_token { get; }
        public abstract int 网页授权获取用户信息 { get; }
    }
}

