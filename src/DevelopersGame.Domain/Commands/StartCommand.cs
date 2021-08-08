using System.Threading.Tasks;
using DevelopersGame.Domain.Abstractions;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace DevelopersGame.Domain.Commands
{
    public class StartCommand : TelegramCommand
    {
        public override string Name => @"/start";

        public override bool Contains(Message message)
        {
            if (message.Type != MessageType.Text)
                return false;

            return message.Text.Contains(Name);
        }

        public override async Task Execute(Message message, ITelegramBotClient botClient)
        {
            var chatId = message.Chat.Id;

            var keyBoard = new ReplyKeyboardMarkup
            {
                Keyboard = new[]
                {
                    new[]
                    {
                        new KeyboardButton("\U0001F3E0 Main")
                    },
                    new[]
                    {
                        new KeyboardButton("\U0001F3E0 Bunker")
                    },
                    new []
                    {
                        new KeyboardButton("\U0001F3E0 Mafia")
                    },
                    new []
                    {
                        new KeyboardButton("\U0001F3E0 World Domination")
                    }
                }
            };
            await botClient.SendTextMessageAsync(chatId, "Hi, you started Me, if u want to start choose the game",
                parseMode: ParseMode.Html, false, false, 0, keyBoard);
        }
    }
}