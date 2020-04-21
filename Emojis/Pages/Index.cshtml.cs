using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GithubEmojis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Emojis.Pages
{
    public class IndexModel : PageModel
    {
        private IGithubEmojiService _emojiServices;

        public IndexModel(IGithubEmojiService emojiSvc)
        {
            _emojiServices = emojiSvc;
        }

        public IList<Emoji> Emojis
        {
            get;
            set;
        }

        public async Task OnGet()
        {
            Emojis = await _emojiServices.GetEmojis();
        }
    }
}
