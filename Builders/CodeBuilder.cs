using System;
using System.Collections.Generic;
using System.Text;

namespace Coding.Exercise
{
    public class CodeBuilder
    {
      private const int indentSize = 2;

      private string _nameClass;
      
      private Dictionary<string, string> _fields;
      
      public CodeBuilder(string nameClass) {
          _nameClass = nameClass;
          _fields = new Dictionary<string, string>();
      }

      public CodeBuilder AddField(string name, string type) {
          _fields.Add(name, type);
          return this;
      }

      public override string ToString()
      {
        var sb = new StringBuilder();
        var sangria = new string(' ', indentSize);
        sb.Append($"public class {_nameClass}\n");
        sb.Append("{\n");

        foreach (var key in _fields.Keys)
          sb.Append(sangria + $"public {_fields[key]} {key};\n");

        sb.Append("}\n");
        return sb.ToString();
      }
    }

  public class Exercise
  {
    static void Main(string[] args)
    {
      var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
      Console.WriteLine(cb);
    }
  }
}