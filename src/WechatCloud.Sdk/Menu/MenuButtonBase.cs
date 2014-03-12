//
//  MenuButtonBase.cs
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

namespace WeChatSdk.Core.Menu
{
    /// http请求方式：POST
    /// https://api.weixin.qq.com/cgi-bin/menu/create?access_token=ACCESS_TOKEN
    /// 参数          是否必须                说明
    /// button          是              按钮数组，按钮个数应为2~3个
    /// sub_button      否              子按钮数组，按钮个数应为2~5个
    /// type            是              按钮类型，目前有click类型
    /// name            是              按钮描述，既按钮名字，不超过16个字节，子菜单不超过40个字节
    /// key         类型为click时必须     按钮KEY值，用于消息接口(event类型)推送，不超过128字节
    public abstract class MenuButtonBase
    {
        public MenuButtonBase(string buttonName) {
            if (string.IsNullOrEmpty(buttonName)) {
                throw new ArgumentNullException("buttonName", "button name is now allowed to be null or empty.");
            }

            name = buttonName;
        }

        public string name { get; set; }

        public abstract string type { get; }

        public virtual bool IsValid() {
            if (IsSubButton) {
                return name.Length <= 40;
            }

            return name.Length <= 16;
        }

        public bool IsSubButton { get; protected set; }
    }
}
// Sample:
// {
//     "button":[
//        {    
//         "type":"click",
//         "name":"今日歌曲",
//         "key":"V1001_TODAY_MUSIC"
//        },
//        {
//         "type":"view",
//         "name":"歌手简介",
//         "url":"http://www.qq.com/"
//        },
//        {
//         "name":"菜单",
//         "sub_button":[
//            {
//             "type":"click",
//             "name":"hello word",
//             "key":"V1001_HELLO_WORLD"
//            },
//            {
//             "type":"click",
//             "name":"赞一下我们",
//             "key":"V1001_GOOD"
//            }]
//        }]
// }