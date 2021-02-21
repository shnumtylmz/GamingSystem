using GamingSystem.Abstract;

namespace GamingSystem
{
    class Game:IEntity
    {
        public int GameNumber { get; set; }
        public string GameName { get; set; }
    }
}
