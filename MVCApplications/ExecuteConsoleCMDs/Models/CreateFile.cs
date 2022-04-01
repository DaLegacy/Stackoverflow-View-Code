namespace ExecuteConsoleCMDs.Models
{
    using System.Text;


    public class CreateFile
    {
        public void CreateJsonFile(string fileName, string content)
        {
            var path = @$"C:\Main Storage\GitHub Repos\Stackoverflow-View-Code\MVCApplications\ExecuteConsoleCMDs\GeneratedFiles\{fileName}.json";

            using (FileStream fs = File.Create(path))
            {
                AddText(fs, content);
            }
        }

        private static void AddText(FileStream fs, string content)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(content);
            fs.Write(info, 0, info.Length);
        }
    }
}
