using System.Threading.Tasks;
using DevelopersGame.Domain.Abstractions;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace DevelopersGame.Domain.Commands
{
    public class StartBunkerCommand : TelegramCommand
    {
        public override string Name => @"/start_bunker";
        public override Task Execute(Message message, ITelegramBotClient client)
        {
            throw new System.NotImplementedException();
        }

        public override bool Contains(Message message)
        {
            throw new System.NotImplementedException();
        }
    }
}