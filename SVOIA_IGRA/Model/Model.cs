using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>Статус игры.</summary>
    public enum GameStatus
    {
        None,

        Starting,

        Progressing,
    }
    ///<summary>Данные об игроке</summary>
    public class Player
    {
        public int Id { get; }

        public string Name { get; }

        public int Points { get; }

        public Player(int id, string name, int points)
        {
            Id = id;
            Name = name;
            Points = points;
        }
    }

    public interface IMyOwnGame
    {
        /// <summary>Старт новой игры.</summary>
        /// <param name="players">Список игроков.</param>
        void Start(params Player[] players);

        /// <summary>Список игроков текущей игры.</summary>
        IReadOnlyCollection<Player> Players { get; }

        /// <summary>Статус игры.</summary>
        GameStatus Status { get; }

        /// <summary>ИД теущего игрока.</summary>
        int CurrentPlayerId { get; }

        /// <summary>Изменился игрок.</summary>
        event EventHandler<Player> PlayerChanged;

        /// <summary>Изменился статус.</summary>
        event EventHandler<GameStatus> StatusChanged;

        /// <summary>Заменён текущий игрок.</summary>
        event EventHandler<int> CurrentPlayerChanged;
    }

}
