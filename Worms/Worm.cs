using System.Xml;

namespace Worms;

public class Worm
{
    private string _name;
    private Coordinate _position;
    private int _lives;
    private StreamWriter _file;

    public string Name { get; set; }

    public Coordinate Position { get; set; }
    
    public int Lives { get; set; }

    public Worm(string name, Coordinate position, int lives)
    {
        _name = name;
        _position = position;
        Lives = lives;
        _file = new StreamWriter("D:/Olga/Documents/Study/4th course/C#/Worms/coordsJohn.txt");
        

    }
    

    public void CloseFile()
    {
        _file.Close();
    }
    
    public void Write()
    {
        _file.WriteLine("Worms:[" + _name + "(" + _position.X + "," + _position.Y + ")]");
        
    }

    public void MoveRight()
    {
        _position.X++;
        Lives--;
        Write();

    }

    public void MoveLeft()
    {
        _position.X--;
        Lives--;
        Write();
    }

    public void MoveUp()
    {
        _position.Y++;
        Lives--;
        Write();
    }

    public void MoveDown()
    {
        _position.Y--;
        Lives--;
        Write();
    }

    public void DontMove()
    {
        Lives--;
        Write();
    }

}
