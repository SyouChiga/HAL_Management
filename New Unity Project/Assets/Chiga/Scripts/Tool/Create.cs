using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectFactory : MonoBehaviour
{
    public static List<string> Script(string name)
    {
        List<string> local_Script = new List<string>();

        local_Script.Add("using System.Collections;");
        local_Script.Add("using System.Collections.Generic;");
        local_Script.Add("using UnityEngine;");
        local_Script.Add("");
        local_Script.Add("");

        local_Script.Add("namespace School");
        local_Script.Add("{");

        local_Script.Add(" namespace Subject");
        local_Script.Add("  {");

        local_Script.Add("     public class " + name + " : BeginSubject");
        local_Script.Add("     {");

        local_Script.Add("      void Start()");
        local_Script.Add("      {");
        local_Script.Add("      }");

        local_Script.Add("      void Update()");
        local_Script.Add("      {");
        local_Script.Add("      }");

        local_Script.Add("     }");

        local_Script.Add("   }");

        local_Script.Add("}");

        return local_Script;
    }
}
   