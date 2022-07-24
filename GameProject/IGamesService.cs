using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface IGamesService
    {
        void Install(Games game);
        void Remove(Games game);
        void Update(Games game);
        void Buy (Games game,Player player);
        void Buy(Games game,Player player,Campaign campaign);

    }
}
