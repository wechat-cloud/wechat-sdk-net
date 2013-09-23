//
//  DefaultTokenService.cs
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
using RestSharp;
using RestSharp.Extensions;

namespace WeChatSdk.Client.Authentication
{
    public class DefaultTokenService : ITokenService
    {
        private const string baseUrl = "https://api.weixin.qq.com/";
        private const string resourceUrl = "cgi-bin/token?grant_type={client_credential}&appid={APPID}&secret={APPSECRET}";

        public AccessToken GetAccessToken(string token, string appId, string appSecret) {
            var client = new RestClient(baseUrl);

            var request = new RestRequest(resourceUrl, Method.GET);
            request.AddUrlSegment("client_credential", token);
            request.AddUrlSegment("APPID", appId);
            request.AddUrlSegment("APPSECRET", appSecret);

            var response = client.Execute<AccessToken>(request);

            return response.Data;
        }
    }
}

