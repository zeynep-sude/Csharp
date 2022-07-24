using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface IPlayerService
    {
        void Add(Player player);
        void Remove(Player player);
        void Update(Player player);
    }
}
