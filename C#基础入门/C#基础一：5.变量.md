# C# 变量

一个变量只不过是一个供程序操作的存储区的名字。在 C# 中，每个变量都有一个特定的类型，类型决定了变量的内存大小和布局。范围内的值可以存储在内存中，可以对变量进行一系列操作。
我们已经讨论了各种数据类型。C# 中提供的基本的值类型大致可以分为以下几类：

| 类型	    | 举例                                                      |
| :-------- | :-------------------------------------------------------- |
| 整数类型   | sbyte、byte、short、ushort、int、uint、long、ulong 和 char |
| 浮点型     | float 和 double                                           |
| 十进制类型 | decimal                                                   |
| 布尔类型   | true 或 false 值，指定的值                                 |
| 空类型     | 可为空值的数据类型                                         |

C# 允许定义其他值类型的变量，比如 enum，也允许定义引用类型变量，比如 class。这些我们将在以后的章节中进行讨论。在本章节中，我们只研究基本变量类型。

命名规则：
1. 首字母是字母或下划线，其余部分是字母、数字、下划线
2. 不能是C#中的关键字

命名潜规则：
1. Pascal命名法：所以单词第一个字母大写，其它字母小写
2. Camel命名法：除了第一个单词，所有单词第一个字母大写，其它字母小写


## C# 中的变量定义

1. 声明
2. 赋值
3. 使用

注意：声明和赋值可以同时进行

C# 中变量定义的语法：
`<data_type> <variable_list>;`

在这里，data_type 必须是一个有效的 C# 数据类型，可以是 char、int、float、double 或其他用户自定义的数据类型。variable_list 可以由一个或多个用逗号分隔的标识符名称组成。

一些有效的变量定义如下所示：

```CSharp
int i, j, k;
char c, ch;
float f, salary;
double d;
```

您可以在变量定义时进行初始化：

`int i = 100;`

## C# 中的变量初始化

变量通过在等号后跟一个常量表达式进行初始化（赋值）。初始化的一般形式为：

`variable_name = value;`

变量可以在声明时被初始化（指定一个初始值）。初始化由一个等号后跟一个常量表达式组成，如下所示：

`<data_type> <variable_name> = value;`

一些实例：

```CSharp
int d = 3, f = 5;    /* 初始化 d 和 f. */
byte z = 22;         /* 初始化 z. */
double pi = 3.14159; /* 声明 pi 的近似值 */
char x = 'x';        /* 变量 x 的值为 'x' */
```

正确地初始化变量是一个良好的编程习惯，否则有时程序会产生意想不到的结果。

请看下面的实例，使用了各种类型的变量：

```CSharp
namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            short a;
            int b ;
            double c;

            /* 实际初始化 */
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadLine();
        }
    }
}
```

当上面的代码被编译和执行时，它会产生下列结果：

`a = 10, b = 20, c = 30`

## 占位符

先挖坑 --> 再埋坑

```CSharp
int number1 = 1;
int number2 = 2;
int number3 = 3;
Console.WriteLine("第一个数字是{0},第二个数字是{1},第三个数字是{2}",number1,number2,number3);
Console.ReadKey();
```

注意：
当埋的坑比挖的坑多时，后面的不执行
当挖的坑比埋的坑多时，语法无错误，会引发异常，程序无法继续向下执行

## 交换变量

当不使用第三方变量进行交换变量时：
```CSharp
int n1 = 10;
int n2 = 20;
n1 = n1 - n2;
n2 = n1 + n2;
n1 = n2 - n1;
Console.WriteLine("交换后n1的值是{0},n2的值是{1}", n1, n2);
Console.ReadKey();
```

## 接受来自用户的值

System 命名空间中的 Console 类提供了一个函数 ReadLine()，用于接收来自用户的输入，并把它存储到一个变量中。

例如：

```CSharp
int num;
num = Convert.ToInt32(Console.ReadLine());
```

函数 Convert.ToInt32() 把用户输入的数据转换为 int 数据类型，因为 Console.ReadLine() 只接受字符串格式的数据。

## C# 中的 Lvalues 和 Rvalues

C# 中的两种表达式：
	1. lvalue：lvalue 表达式可以出现在赋值语句的左边或右边。
	2. rvalue：rvalue 表达式可以出现在赋值语句的右边，不能出现在赋值语句的左边。

变量是 lvalue 的，所以可以出现在赋值语句的左边。数值是 rvalue 的，因此不能被赋值，不能出现在赋值语句的左边。下面是一个有效的语句：
`int g = 20;`
下面是一个无效的语句，会产生编译时错误：
`10 = 20;`

## 关于静态变量

在 C# 中没有全局变量的概念，所有变量必须由该类的实例进行操作，这样做提升了安全性，但是在某些情况下却显得力不从心。
因此，我们在保存一些类的公共信息时，就会使用静态变量。

`static <data_type> <variable_name> = value;`

在变量之前加上 static 关键字，即可声明为静态变量。


