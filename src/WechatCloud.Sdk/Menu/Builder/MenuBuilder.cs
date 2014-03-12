//
//  MenuBuilder.cs
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

namespace WeChatSdk.Core.Menu.Builder
{
    public class MenuBuilder
    {
        private MpMenu _mpMenu;

        private MenuBuilder() {
            _mpMenu = new MpMenu();
        }

        public static MenuBuilder Create() {
            return new MenuBuilder();
        }

        public MenuBuilder AddClickButton(string name, string key) {
            var newButton = new MenuButtonClick(name, key);
            _mpMenu.AddButton(newButton);

            return this;
        }

        public MenuBuilder AddClickButton(string name, Action<SubButtonBuilder> subButtonBuilder) {
            var newButton = new MenuButtonClick(name, "");

            var sbBuilder = new SubButtonBuilder(newButton);
            subButtonBuilder(sbBuilder);

            _mpMenu.AddButton(newButton);

            return this;
        }

        public MenuBuilder AddViewButton(string name, string url) {
            var newButton = new MenuButtonClick(name, url);
            _mpMenu.AddButton(newButton);

            return this;
        }
    }

    public class SubButtonBuilder
    {
        private MenuButtonClick _parentButton;

        public SubButtonBuilder(MenuButtonClick parentButton) {
            _parentButton = parentButton;
        }

        public SubButtonBuilder AddClickButton(string name, string key) {
            var newButton = new MenuButtonClick(name, key);
            _parentButton.AddSubButton(newButton);

            return this;
        }

        public SubButtonBuilder AddViewButton(string name, string url) {
            var newButton = new MenuButtonView(name, url);
            _parentButton.AddSubButton(newButton);

            return this;
        }
    }
}

