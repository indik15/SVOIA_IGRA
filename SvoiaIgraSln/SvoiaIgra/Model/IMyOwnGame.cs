using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public interface IMyOwnGame
    {
        /// <summary>Старт новой игры.</summary>
        /// <param name="players">Список игроков.</param>
        void Start(params Player[] players);

        /// <summary>Список игроков текущей игры.</summary>
        IReadOnlyCollection<Player> Players { get; }

        /// <summary>Статус игры.</summary>
        GameStatus Status { get; }

        /// <summary>ИД теущего игрока. </summary>
        int CurrentPlayerId { get; }

        /// <summary>Изменился игрок.</summary>
        event EventHandler<Player> PlayerChanged;

        /// <summary>Изменился статус.</summary>
        event EventHandler<GameStatus> StatusChanged;

        /// <summary>Заменён текущий игрок.</summary>
        event EventHandler<int> CurrentPlayerChanged;
    }

}
