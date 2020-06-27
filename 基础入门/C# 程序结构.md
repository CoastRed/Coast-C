# C# 程序结构

**一个 C# 程序主要包括以下部分：**
- 命名空间声明（Namespace declaration）
- 一个 class
-  Class 方法
-  Class 属性
-  一个 Main 方法
-  语句（Statements）& 表达式（Expressions）
-  注释

```CSharp
using System;
namespace HelloWorldApplication
{
   class HelloWorld
   {
      static void Main(string[] args)
      {
         /* 我的第一个 C# 程序*/
         Console.WriteLine("Hello World");
         Console.ReadKey();
      }
   }
}

```

当上面的代码被编译和执行时，它会产生下列结果：

`Hello World`

-  程序的第一行 using System; - using 关键字用于在程序中包含 System 命名空间。 一个程序一般有多个 using 语句。
-  下一行是 namespace 声明。一个 namespace 里包含了一系列的类。HelloWorldApplication 命名空间包含了类 HelloWorld。
-  下一行是 class 声明。类 HelloWorld 包含了程序使用的数据和方法声明。类一般包含多个方法。方法定义了类的行为。在这里，HelloWorld 类只有一个 Main 方法。
-  下一行定义了 Main 方法，是所有 C# 程序的 入口点。Main 方法说明当执行时 类将做什么动作。
-  下一行 /*...*/ 将会被编译器忽略，且它会在程序中添加额外的 注释。
-  Main 方法通过语句 Console.WriteLine("Hello World"); 指定了它的行为。
WriteLine 是一个定义在 System 命名空间中的 Console 类的一个方法。该语句会在屏幕上显示消息 "Hello World"。
-  最后一行 Console.ReadKey(); 是针对 VS.NET 用户的。这使得程序会等待一个按键的动作，防止程序从 Visual Studio .NET 启动时屏幕会快速运行并关闭。

以下几点值得注意：

-  C# 是大小写敏感的。
-  所有的语句和表达式必须以分号（;）结尾。
-  程序的执行从 Main 方法开始。
-  与 Java 不同的是，文件名可以不同于类的名称。

