using System;
using System.Reflection;

namespace Reflect
{
    internal static class Reflector
    {
        public static void MethodInfo<T>(T obj) where T: class
        {
            Type t = typeof(T);
            MethodInfo[] methods = t.GetMethods();

            foreach(MethodInfo m in methods)
            {
                Console.Write("Method " + m.ReturnType.Name + " " + m.Name + "(");
                ParameterInfo[] parameters = m.GetParameters();

                for(int i = 0; i < parameters.Length; i++)
                {
                    Console.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if(i + 1 < parameters.Length)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine(")");
            }
        }
    }
}
