﻿using NUnit.Framework;
using VkNet.Model.RequestParams;

namespace VkNet.Tests.Categories.Messages
{
	public class MessagesGetConversationsTests: BaseTest
	{
		[Test]
		public void GetConversations()
		{
			Url = "https://api.vk.com/method/messages.getConversations";

			Json = @"{
				response: {
					count: 1,
					items: [
						{
							conversation: {
								peer: {
									id: 100,
									type: 'user',
									local_id: 100
								},
								in_read: 220697,
								out_read: 220697,
								last_message_id: 220697,
								can_write: {
									allowed: true
								},
								push_settings: {
									no_sound: false,
									disabled_until: 0,
									disabled_forever: true
								}
							},
							last_message: {
								date: 1530088859,
								from_id: 100,
								id: 220697,
								out: 0,
								peer_id: 100,
								text: 'Код подтверждения входа',
								conversation_message_id: 276,
								fwd_messages: [],
								important: false,
								random_id: 0,
								attachments: [],
								is_hidden: false
							}
						}
					]
				}
			}";

			var result = Api.Messages.GetConversations(new GetConversationsParams());

			Assert.That(1, Is.EqualTo(result.Count));
		}
	}
}