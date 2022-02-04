namespace Worms
{
    public class Worm
    {
        private string _name;
        private Coordinates _position;
        private int _lives;
        private FileWriterService _fileWriterService;
        

        public FileWriterService FileWriterService
        {
            get => _fileWriterService;
            set => _fileWriterService = value;
        }

        public int Lives
        {
            get
            {
                return _lives;
            }
            set
            {
                _lives = value;
            }
        }
        
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
            
        }
        public Coordinates Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
            
        }
        
        public Worm(FileWriterService fileWriterService, NameGenerator nameGenerator)
        {
            _name = nameGenerator.GetNewName();
            _position = new Coordinates();
            _position.X = 0;
            _position.Y = 0;
            _lives = 10;
            _fileWriterService = fileWriterService;

        }
        
        public Worm(FileWriterService fileWriterService, NameGenerator nameGenerator, int x, int y)
        {
            _name = nameGenerator.GetNewName();
            _position = new Coordinates();
            _position.X = x;
            _position.Y = y;
            _lives = 10;
            _fileWriterService = fileWriterService;

        }

        public Coordinates MoveRight()
        {
            _position.X = _position.X + 1;
            _fileWriterService.WriteCoordinatesToFile(_name, _lives, _position.X, _position.Y);
            return _position;
        }
        
        public Coordinates MoveLeft()
        {
            _position.X = _position.X - 1;
            _fileWriterService.WriteCoordinatesToFile(_name, _lives, _position.X, _position.Y);
            return _position;
        }
        public Coordinates MoveUp()
        {
            _position.Y = _position.Y + 1;
            _fileWriterService.WriteCoordinatesToFile(_name, _lives, _position.X, _position.Y);
            return _position;
        }
        public Coordinates MoveDown()
        {
            _position.Y = _position.Y - 1;
            _fileWriterService.WriteCoordinatesToFile(_name, _lives, _position.X, _position.Y);
            return _position;
        }
        
        public Coordinates DontMove()
        {
            _fileWriterService.WriteCoordinatesToFile(_name, _lives, _position.X, _position.Y);
            return _position;
        }
        
        public void EndOfAction()
        {
            _lives = _lives - 1;
        }

    }
}