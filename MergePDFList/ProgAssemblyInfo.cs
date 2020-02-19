using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MergePDFList
{
   public static class ProgAssemblyInfo
    {
        private static Assembly _assembly { get; } = Assembly.GetExecutingAssembly();

        public static string Company { get; } = _assembly.GetCustomAttribute<AssemblyCompanyAttribute>().Company;
        public static string Copyright { get; } = _assembly.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
        public static string Guid { get; } = _assembly.GetCustomAttribute<GuidAttribute>().Value;
        public static string Title { get; } = _assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;
        public static Version Version { get; } = _assembly.GetName().Version;
    }
}
