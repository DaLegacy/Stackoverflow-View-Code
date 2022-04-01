using ExecuteConsoleCMDs.Models;

string CustomerId;
string UpperCustomerId;
string FileName;
int id;

var templateRepository = new MockTemplateRepository();
var createNewFile = new CreateFile();

Console.WriteLine("Enter your ID:");
CustomerId = Console.ReadLine();

UpperCustomerId = CustomerId.ToUpper();

string[] splitCustomerId = UpperCustomerId.Split('#');

if(splitCustomerId[0] == "ZOO")
{
    Console.WriteLine($"\nHello {CustomerId}, your avaible templates. \n");
    foreach(var template in templateRepository.GetAllTemplates())
    {
        Console.WriteLine($"ID: {template.TemplateId} : Name: {template.TemplateName}\n");
    }

}else if(splitCustomerId[0] == "RAIL")
{
    Console.WriteLine($"Hello {CustomerId}, your avaible templates.");
}
else
{
    Console.WriteLine("You didn't enter anything");
}

Console.WriteLine("Enter template ID");
id = Convert.ToInt32(Console.ReadLine());

var SelectedTemplate = templateRepository.GetTemplateById(id);
Console.WriteLine($"{SelectedTemplate.TemplateContent}");

var Content = SelectedTemplate.TemplateContent;
Console.WriteLine("Enter New File Name");
FileName = Console.ReadLine();
createNewFile.CreateJsonFile(FileName, Content);


