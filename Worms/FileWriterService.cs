namespace Worms
{
    public class FileWriterService
    {
        private StreamWriter _file;
        
        public void WriteCoordinatesToFile(string name, int vitality, int x, int y)
        {
            _file.WriteLine(name + ":[lives: " + vitality + ", coords: (" + x + "," + y + ")]");
        }

        public void OpenFile()
        {
            _file = new StreamWriter("D:/Olga/Documents/Study/4th course/C#/Worms/coordinates.txt", false);
        }
        
        public void CloseFile()
        {
            _file.Close();
        }
    }
}