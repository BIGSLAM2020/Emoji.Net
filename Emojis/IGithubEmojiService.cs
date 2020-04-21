using System.Collections.Generic;
using System.Threading.Tasks;
using Emojis;

namespace GithubEmojis
{
    public interface IGithubEmojiService
    {
        Task<IList<Emoji>> GetEmojis();
        IList<Emoji> GetEmojis(string content);
    }
}