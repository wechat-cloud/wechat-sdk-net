//
//  MenuButtonLink.cs
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
using System.Text.RegularExpressions;

namespace WeChatSdk.Core.Menu
{
    public class MenuButtonView : MenuButtonBase
    {
        public MenuButtonView(string buttonName, string buttonUrl): base(buttonName) {
            if (!Regex.IsMatch(buttonUrl, @"")) {
                throw new ArgumentException("invalid url format");
            }

            url = buttonUrl;
        }

        public override string type { 
            get {
                return "view";
            } 
        }

        public string url { get; set; }

        public override bool IsValid() {
            return true;
        }
    }
}