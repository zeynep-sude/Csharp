using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class PlayerManager : IPlayerService
    {

        List<Player> PlayerList;
        public PlayerManager()
        {
            PlayerList = new List<Player>();
        }

        public void Add(Player player)
        {
            PlayerList.Add(player);
            Console.WriteLine(player.NickName +" "+ "Hesabınız Etkinleştirildi");
        }

        public void Remove(Player player)
        {
          PlayerList.Remove(player); 
            Console.WriteLine(player.NickName +  " "  + "Hesabınız Silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Bilgileriniz Güncellendi");
        }
    }
}
