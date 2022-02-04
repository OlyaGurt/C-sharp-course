using Microsoft.Extensions.Hosting;


namespace Worms
{
    public class WorldSimulatorService : IHostedService
    {
        private FileWriterService _fileWriterService;
        private FoodGenerator _foodGenerator;
        private WormLogic _wormLogic;
        private NameGenerator _nameGenerator;
        private Food _food;

        public WorldSimulatorService(FileWriterService fileWriterService, FoodGenerator foodGenerator, WormLogic wormLogic, NameGenerator nameGenerator, Food food)
        {
            _fileWriterService = fileWriterService;
            _foodGenerator = foodGenerator;
            _wormLogic = wormLogic;
            _nameGenerator = nameGenerator;
            _food = food;

        }
        public void Life()
        {
            List<Worm> worms = new List<Worm>();
            Worm worm = new Worm(_fileWriterService, _nameGenerator);
            worms.Add(worm);
            _fileWriterService.OpenFile();
            for (int i = 0; i < 100; i++)
            {
                _foodGenerator.GenerateFood(_food);
                for (int a = 0; a < worms.Count; a++)
                {
                    _wormLogic.WormAction(worms, worms[a], _nameGenerator, _food);
                }

                for (int a = 0; a < worms.Count; a++)
                {
                    if (worms[a].Lives < 1)
                    {
                        worms.RemoveAt(a);
                    }
                }
            }

            _fileWriterService.CloseFile();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Task.Run(Life);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
            => Task.CompletedTask;   
        
    }
}