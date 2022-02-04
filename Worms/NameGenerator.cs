namespace Worms
{
    public class NameGenerator
    {
        private const string Name = "Worm";
        private int _wormNum = 0;

        public string GetNewName()
        {
            _wormNum++;
            return Name + _wormNum;
        }
    }
}