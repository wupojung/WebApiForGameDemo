using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDemo.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }

        public Player(int Id, string Name, int Level, int HP)
        {
            this.Id = Id;
            this.Name = Name;
            this.Level = Level;
            this.HP = HP;
        }
    }

    //完全用來測試  (模擬成資料庫)
    //單例模式
    public class PlayerFake
    {
        private static PlayerFake instance = null;

        private IList<Player> _players;

        public static PlayerFake Instance
        {
            get
            {

                if (instance == null) { instance = new PlayerFake(); } //單例模式 的核心

                return instance;
            }
        }

        public PlayerFake()
        {
            _players = new List<Player>();
            _players.Add(new Player(1, "Apple", 5, 40));
            _players.Add(new Player(2, "Eric", 1, 10));
            _players.Add(new Player(3, "Kitty", 10, 300));
            _players.Add(new Player(4, "Peter", 3, 215));
        }


        public Player GetPlayerById(int id)
        {

            return _players.Where(x => x.Id == id)
                           .FirstOrDefault();
        }

    }

}
