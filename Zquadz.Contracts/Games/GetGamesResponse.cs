using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zquadz.Contracts.Games.Base;

namespace Zquadz.Contracts.Games
{
    internal class GetGamesResponse
    {
        public List<GameDetails> Games { get; set; }
        public GetGamesResponse(List<GameDetails> games) {
            this.Games = games;
        }
    }
}
