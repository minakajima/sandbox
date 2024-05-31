
using System.Reflection;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


//        char[] chars = new char[0];

//        char chars1 = chars[1];

        // DLLのパスを指定します
        string dllPath = @"C:\Data\code\sandbox\c#\exception_test\x64\Debug\cppdll.dll";

        // DLLをロードします
        Assembly loadedAssembly = Assembly.LoadFile(dllPath);

        // メソッドが定義されている型を取得します
        Type type = loadedAssembly.GetType("Namespace.ClassName");

        // インスタンスを作成します（静的メソッドの場合は不要）
        object instance = Activator.CreateInstance(type);

        // メソッドを取得します
        // メソッドを取得します
        MethodInfo method = type.GetMethod("MethodName");

        // メソッドを呼び出します
        object result = method.Invoke(instance, new object[] { /* メソッドの引数 */ });


    }
}