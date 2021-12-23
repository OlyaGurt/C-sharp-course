namespace Worms;

public class Words
{
    private const int Lives_count = 100;

    static void Main(string[] args)
    {
        Worm worm = new Worm ("John", new Coordinate(0,0), Lives_count);

        worm.MoveDown();
        worm.MoveLeft();

        while (worm.Lives > 0)
        {
            for (int i = 0; i < 2; i++)
            {
                worm.MoveUp();
            }
            if (worm.Lives == 0)
                break;

            for (int i = 0; i < 2; i++)
            {
                worm.MoveRight();
                
            }
            if (worm.Lives == 0)
                break;

            for (int i = 0; i < 2; i++)
            {
                worm.MoveDown();
                
            }
            if (worm.Lives == 0)
                break;

            for (int i = 0; i < 2; i++)
            {
                worm.MoveLeft();
               
            }
            if (worm.Lives == 0)
                break;
        }
        
        worm.CloseFile();

    }
}

