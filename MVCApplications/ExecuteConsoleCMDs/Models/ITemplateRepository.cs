using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteConsoleCMDs
{
    public interface ITemplateRepository
    {
        IEnumerable<Template> GetAllTemplates();
        Template GetTemplateById(int id);
    }
}
