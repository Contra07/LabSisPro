using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace Library
{
    public class AsmFunction
    {
        public const string METHOD_NAME = "OR";
        public const string ASSEMBLY_NAME = METHOD_NAME;
        public const string MODULE_NAME = METHOD_NAME + ".dll";
        public const string TYPE_NAME = METHOD_NAME + "DLL";

        public static void CreateORLibrary()
        {
            AppDomain asmDomain = Thread.GetDomain();
            AssemblyBuilder asmBuilder = asmDomain.DefineDynamicAssembly(new AssemblyName(ASSEMBLY_NAME), AssemblyBuilderAccess.RunAndSave);
            ModuleBuilder xorModule = asmBuilder.DefineDynamicModule(MODULE_NAME, true);
            TypeBuilder typeBuilder = xorModule.DefineType(TYPE_NAME, TypeAttributes.Public);
            MethodBuilder methodBuilder = typeBuilder.DefineMethod(METHOD_NAME, MethodAttributes.Public, typeof(int), new Type[] { typeof(int), typeof(int) });
            ILGenerator iLGenerator = methodBuilder.GetILGenerator();
            iLGenerator.Emit(OpCodes.Ldarg_1);
            iLGenerator.Emit(OpCodes.Ldarg_2);
            iLGenerator.Emit(OpCodes.Or);
            iLGenerator.Emit(OpCodes.Ret);
            typeBuilder.CreateType();
            asmBuilder.Save(MODULE_NAME);
        }
    }
}