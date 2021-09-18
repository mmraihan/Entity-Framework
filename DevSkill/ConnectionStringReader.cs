using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSkill
{
    
    public static class ConnectionStringReader
    {
        

        public const string ConnectionString= "Server=.//;Database=DevSkillCSharpB8;Trusted_Connection=True;";
    }
}


//Command Migration, Update
//dotnet ef migrations add AddStudentTable --context TrainingContext --project DevSkill
//dotnet ef database update --context TrainingContext --project DevSkill
//
