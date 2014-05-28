using System;
using FluentAssertions;
using WechatCloud.Sdk;
using Xunit;

namespace WechatCloud.Tests
{
    public class MessageHandlerCollectionTest
    {
        [Fact]
        public void AddToCollection() {
            var collection = new MessageHandlerCollection();

            collection.Count.Should().Be(0, "default");

        }
    }
}

