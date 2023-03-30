namespace ClassLibrary
{
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

}
