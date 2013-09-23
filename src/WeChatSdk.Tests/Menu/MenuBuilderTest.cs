//
//  MenuBuilderTest.cs
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
using WeChatSdk.Core;

namespace WeChatSdk.Tests.Menu
{
    public class MenuBuilderTest
    {
        public void TestBuilderApi() {
            MenuBuilder.Create()
                .AddClickButton("click-button1", "subscribe")
                .AddViewButton("view-button1", @"http://lurongkai.github.io")
                .AddClickButton("click-button2", button =>
                    button.AddClickButton("sub-click1", "S1")
                          .AddViewButton("sub-view1", @"http://weibo.com/lengleng3898"));
        }
    }
}

