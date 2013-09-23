//
//  MenuButton.cs
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
using System.Collections.Generic;

namespace WeChatSdk.Core.Menu
{
    public class MenuButtonClick : MenuButtonBase
    {
        public MenuButtonClick(string buttonName, string buttonKey): base(buttonName) {
            // TODO: button key validator.

            key = buttonKey;
        }

        private List<MenuButtonBase> _subButtons = new List<MenuButtonBase>();

        public override string type { 
            get {
                return "click";
            } 
        }

        public string key { get; set; }

        public MenuButtonBase[] sub_button { 
            get {
                return _subButtons.ToArray();
            }
        }

        public override bool IsValid() {
            return 
                base.IsValid() &&
                (_subButtons.Count == 0 || _subButtons.Count >= 2 && _subButtons.Count <= 5) &&
                key.Length <= 128;
        }

        public void AddSubButton(MenuButtonBase newSubButton) {
            if (_subButtons.Count == 5) {
                throw new InvalidOperationException("Sub-button count limited to 5.");
            }

            _subButtons.Add(newSubButton);
        }
    }
}