namespace ExecuteConsoleCMDs.Models
{
    public class MockTemplateRepository : ITemplateRepository
    {
        public IEnumerable<Template> Templates =>
            new List<Template>
            {
                new Template{ TemplateId = 1, TemplateName = "TemplateName1", TemplateContent = "What am I <typeOfAniaml>"},
                new Template{ TemplateId = 2, TemplateName = "TemplateName2", TemplateContent = "Train at platform <platformNumber>"},
                new Template{ TemplateId = 3, TemplateName = "TemplateName3", TemplateContent = "What do I eat <foodStuffs>"}
            };


        public IEnumerable<Template> GetAllTemplates()
        {
            return Templates;
        }

        public Template GetTemplateById(int templateId)
        {
            return Templates.FirstOrDefault(t => t.TemplateId == templateId);
        }
    }
}
