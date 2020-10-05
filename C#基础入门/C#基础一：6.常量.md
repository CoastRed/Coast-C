# C# 常量

不能被重新赋值，常量是固定值，程序执行期间不会改变。常量可以是任何基本数据类型，比如整数常量、浮点常量、字符常量或者字符串常量，还有枚举常量。
常量可以被当作常规的变量，只是它们的值在定义后不能被修改。

语法：const 变量类型，变量名 = 值

```CSharp
const int number = 40;
```

## 整数常量

整数常量可以是十进制、八进制或十六进制的常量。前缀指定基数：0x 或 0X 表示十六进制，0 表示八进制，没有前缀则表示十进制。
整数常量也可以有后缀，可以是 U 和 L 的组合，其中，U 和 L 分别表示 unsigned 和 long。后缀可以是大写或者小写，多个后缀以任意顺序进行组合。

这里有一些整数常量的实例：
```CSharp
212         /* 合法 */
215u        /* 合法 */
0xFeeL      /* 合法 */
078         /* 非法：8 不是一个八进制数字 */
032UU       /* 非法：不能重复后缀 */
```

以下是各种类型的整数常量的实例：

```CSharp
85         /* 十进制 */
0213       /* 八进制 */
0x4b       /* 十六进制 */
30         /* int */
30u        /* 无符号 int */
30l        /* long */
30ul       /* 无符号 long */
```

## 浮点常量

一个浮点常量是由整数部分、小数点、小数部分和指数部分组成。您可以使用小数形式或者指数形式来表示浮点常量。

这里有一些浮点常量的实例：

```CSharp
3.14159       /* 合法 */
314159E-5L    /* 合法 */
510E          /* 非法：不完全指数 */
210f          /* 非法：没有小数或指数 */
.e55          /* 非法：缺少整数或小数 */
```

使用小数形式表示时，必须包含小数点、指数或同时包含两者。使用指数形式表示时，必须包含整数部分、小数部分或同时包含两者。有符号的指数是用 e 或 E 表示的。

## 字符常量

字符常量是括在单引号里，例如，'x'，且可存储在一个简单的字符类型变量中。一个字符常量可以是一个普通字符（例如 'x'）、一个转义序列（例如 '\t'）或者一个通用字符（例如 '\u02C0'）。

在 C# 中有一些特定的字符，当它们的前面带有反斜杠时有特殊的意义，可用于表示换行符（\n）或制表符 tab（\t）。在这里，列出一些转义序列码：
|   转义序列  | 含义    |
| :-- | :-- |
|  \\   |  \ 字符   |
|   \'  |   ' 字符  |
|  \"   |   " 字符  |
|    \? | ? 字符    |
|   \a  |   Alert 或 bell  |
|  \b   |   退格键（Backspace）  |
|   \f  |  换页符（Form feed）  |
|   \n  |  换行符（Newline）   |
|  \r   |    回车 |
|  \t   |   水平制表符 tab  |
|  \v   |    垂直制表符 tab |
|  \ooo   |  一到三位的八进制数   |
| \xhh . . .    |   一个或多个数字的十六进制数  |


以下是一些转义序列字符的实例：

```CSharp
namespace EscapeChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\tWorld\n\n");
            Console.ReadLine();
        }
    }
}
```

当上面的代码被编译和执行时，它会产生下列结果：

`Hello   World`

## 字符串常量

字符串常量是括在双引号 "" 里，或者是括在 @"" 里。字符串常量包含的字符与字符常量相似，可以是：普通字符、转义序列和通用字符
使用字符串常量时，可以把一个很长的行拆成多个行，可以使用空格分隔各个部分。

这里是一些字符串常量的实例。下面所列的各种形式表示相同的字符串。

```CSharp
string a = "hello, world";                  // hello, world
string b = @"hello, world";               // hello, world
string c = "hello \t world";               // hello     world
string d = @"hello \t world";               // hello \t world
string e = "Joe said \"Hello\" to me";      // Joe said "Hello" to me
string f = @"Joe said ""Hello"" to me";   // Joe said "Hello" to me
string g = "\\\\server\\share\\file.txt";   // \\server\share\file.txt
string h = @"\\server\share\file.txt";      // \\server\share\file.txt
string i = "one\r\ntwo\r\nthree";
string j = @"one
two
three";
```

## 定义常量

关于常量变量命名的规则：

- 带有 private 私有访问修饰符的常量要以骆驼命名法命名，即以下划线开头，第一个单词的首字母小写，余下单词首字母大写。
private const string _bookName = "新华字典";
- 带有 public 公共修饰符、protected 受保护修饰符等的常量要以帕斯卡命名法命名，即各个单词首字母都要大写。
public const int BookPrice = 10;

在下面两种情况下：
	-   a、取值永久不变(比如圆周率、一天包含的小时数、地球的半径等)。
	-   b、对程序性能要求非常苛刻。
可以使用 const 常量，除此之外的其他情况都应该优先采用 readonly 常量。


### 1.静态常量（编译时常量）const

使用 const 关键字来定义的 。定义一个常量的语法如下：

`const <data_type> <constant_name> = value;`

在编译时就确定了值，必须在声明时就进行初始化且之后不能进行更改，可在类和方法中定义。定义方法如下：

```CSharp
const double a=3.14；// 正确声明常量的方法
const int b;         // 错误，没有初始化
```

### 2.动态常量（运行时常量）readonly

在运行时确定值，只能在声明时或构造函数中初始化，只能在类中定义。定义方法如下：

```CSharp
class Program
{
    readonly int a=1;  // 声明时初始化
    readonly int b;    // 构造函数中初始化
    Program()
    {
        b=2;
    }
    static void Main()
    {
    }
}
```


下面的代码演示了如何在程序中定义和使用常量：

```CSharp
using System;

public class ConstTest
{
    class SampleClass
    {
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public SampleClass(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    static void Main()
    {
        SampleClass mC = new SampleClass(11, 22);
        Console.WriteLine("x = {0}, y = {1}", mC.x, mC.y);
        Console.WriteLine("c1 = {0}, c2 = {1}",
                          SampleClass.c1, SampleClass.c2);
    }
}
```

当上面的代码被编译和执行时，它会产生下列结果：

```CSharp
x = 11, y = 22
c1 = 5, c2 = 10

```

