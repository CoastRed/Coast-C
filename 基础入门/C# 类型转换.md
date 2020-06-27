# C# 类型转换

类型转换从根本上说是类型铸造，或者说是把数据从一种类型转换为另一种类型。在 C# 中，类型铸造有两种形式：

-  自动/隐式类型转换（程序自动进行）：这些转换是 C# 默认的以安全方式进行的转换, 不会导致数据丢失。例如，从小的整数类型转换为大的整数类型，从派生类转换为基类。
    必须是两种相互兼容的数据类型才能进行
    例如：int --> double
    小的类型往大的类型转换
-  强制/显式类型转换（需要自己编写）：显式类型转换，即强制类型转换。显式转换需要强制转换运算符，而且强制转换会造成数据丢失。
    必须是两种相互兼容的数据类型才能进行
    例如：double --> int
    大的类型往小的类型转换
    语法：要转换为的数据类型(要转换的内容)
下面的实例显示了一个显式的类型转换：
```CSharp
namespace TypeConversionApplication
{
    class ExplicitConversion
    {
        static void Main(string[] args)
        {
            double d = 5673.74;
            int i;

            // 强制转换 double 为 int
            i = (int)d;
            Console.WriteLine(i);
            Console.ReadKey();
           
        }
    }
}
```

当上面的代码被编译和执行时，它会产生下列结果：

`5673`

## C# 类型转换方法

C# 提供了下列内置的类型转换方法：

| 序号 | 序号 |
| :-- | :-- |
| 1    |  ToBoolean
	如果可能的话，把类型转换为布尔型。   |
|   2  |  ToByte
	把类型转换为字节类型。   |
|  3   |   ToChar
	如果可能的话，把类型转换为单个 Unicode 字符类型。  |
|  4   |   ToDateTime
	把类型（整数或字符串类型）转换为 日期-时间 结构。  |
|  5   |  ToDecimal
	把浮点型或整数类型转换为十进制类型。   |
|  6   |  ToDouble
	把类型转换为双精度浮点型。   |
|  7   |   ToInt16
	把类型转换为 16 位整数类型。  |
|   8  |  ToInt32
	把类型转换为 32 位整数类型。   |
|  9   |   ToInt64
	把类型转换为 64 位整数类型。  |
|  10   |   ToSbyte
	把类型转换为有符号字节类型。  |
|  11   |   ToSingle
	把类型转换为小浮点数类型。  |
|  12   |   ToString
	把类型转换为字符串类型。  |
| 13    |   ToType
	把类型转换为指定类型。  |
|  14   |  ToUInt16
	把类型转换为 16 位无符号整数类型。   |
|  15   |  ToUInt32
	把类型转换为 32 位无符号整数类型。   |
|   16  |  ToUInt64
	把类型转换为 64 位无符号整数类型。   |


下面的实例把不同值的类型转换为字符串类型：

```CSharp
namespace TypeConversionApplication
{
    class StringConversion
    {
        static void Main(string[] args)
        {
            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadKey();
           
        }
    }
}
```

当上面的代码被编译和执行时，它会产生下列结果：

```
75
53.005
2345.7652
True
```

### convert/Parse类型转换

必须看上去存在转换的可能性才能转换，否则引发异常

```CSharp
string str1 = "123";
double number1 = Convert.ToDouble(str1);
Console.WriteLine(number1);
Console.ReadKey();
```

```CSharp
int number = int.parse("123")
```

Convert在本质上也是调用的parse，因此parse相对效率会更高

```CSharp
int number = 0;
//使用TryParse进行数据转换，当转换成功时b是True，并把转换成功后的值放入number，若转换失败则b为False，number为0，跟前面的int number = 0没关系，无论成不成功都不会抛出异常
bool b = int.TryParse("123a", out number);
Console.WriteLine(b);
Console.WriteLine(number);
Console.ReadKey();
```

## 类型之间的转换 - Convert 和 Parse

```CSharp
string locstr = 123.ToString();
//如果要将"locstr"转成整型数
//方法一: 用 Convert 
int i = Convert.ToInt16(locstr);
//方法二: 用 Parse
int ii = int.Parse(locstr);
```

`int.TryParse(string s,out int i)`

该方式也是将数字内容的字符串转换为int类型，但是该方式比int.Parse(string s) 好一些，它不会出现异常，最后一个参数result是输出值，如果转换成功则输出相应的值，转换失败则输出0。

```CSharp
class test
{
    static void Main(string[] args)
    {
        string s1="abcd";
        string s2="1234";
        int a,b;
        bool bo1=int.TryParse(s1,out a);
        Console.WriteLine(s1+" "+bo1+" "+a);
        bool bo2=int.TryParse(s2,out b);
        Console.WriteLine(s2+" "+bo2+" "+b);
    }
}
```

结果输出：

```
abcd False 0
1234 True 1234
```

### Convert.ToInt32() 与 int.Parse() 的区别

没搞清楚 Convert.ToInt32 和 int.Parse() 的细细微区别时千万别乱用，否则可能会产生无法预料的结果，举例来说：假如从 url 中取一个参数 page 的值，我们知道这个值是一个 int，所以即可以用 Convert.ToInt32(Request.QueryString["page"])，也可以用 int.Parse(Request.QueryString["page"])，但是如果 page 这个参数在 url 中不存在，那么前者将返回 0，0 可能是一个有效的值，所以你不知道 url 中原来根本就没有这个参数而继续进行下一下的处理，这就可能产生意想不到的效果，而用后一种办法的话没有 page 这个参数会抛出异常，我们可以捕获异常然后再做相应的处理，比如提示用户缺少参数，而不是把参数值当做 0 来处理。

- 这两个方法的最大不同是它们对 null 值的处理方法： Convert.ToInt32(null) 会返回 0 而不会产生任何异常，但 int.Parse(null) 则会产生异常。
- 对数据进行四舍五入时候的区别
	-   Convert.ToInt32(double value) 如果 value 为两个整数中间的数字，则返回二者中的偶数；即 3.5 转换为 4，4.5 转换为 4，而 5.5 转换为 6。不过 4.6 可以转换为 5，4.4 转换为 4 。
	-   int.Parse("4.5") 直接报错:"输入字符串的格式不正确"。
	-   int(4.6) = 4 Int 转化其他数值类型为 Int 时没有四舍五入，强制转换。
- 对被转换类型的区别 int.Parse 是转换 String 为 int, Convert.ToInt32 是转换继承自 Object 的对象为 int 的(可以有很多其它类型的数据)。你得到一个 object 对象, 你想把它转换为 int, 用 int.Parse 就不可以, 要用 Convert.ToInt32。

## 枚举类型转换

### 枚举转换成int类型

枚举类型默认与int类型是相互兼容的
枚举中的元素默认是从0开始的，往后依次递增1，当然也可以强制干预

```CSharp  
namespace _003_枚举转换
{
    public enum QQstate
    { 
        Online,
        Offline = 4,
        Leave
    }
    class Program
    {
        static void Main(string[] args)
        {
            QQstate state = QQstate.Leave;
            int n = (int)state;
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
```

### int转换为枚举类型

当int类型的值大于枚举中元素个数时，会直接输出int类型的值，不会抛出异常

```Csharp
namespace _003_枚举转换
{
    public enum QQstate
    { 
        Online,
        Offline,
        Leave
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 2;
            QQstate state = (QQstate)n1;
            Console.WriteLine(state);
            Console.ReadKey();
        }
    }
}
```

### 枚举转换成字符串类型

所有的类型都可以用ToString转换为string类型

```CSharp
namespace _003_枚举转换
{
    public enum QQstate
    { 
        Online,
        Offline,
        Leave
    }
    class Program
    {
        static void Main(string[] args)
        {
            QQstate state = QQstate.Offline;
            string s = state.ToString();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
```

### 字符串转换成枚举类型

```CSharp
namespace _003_枚举转换
{
    public enum QQstate
    { 
        Online,
        Offline,
        Leave
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "0";
            string s1 = "Leave";
            string s2 = "ASDF"    //抛出异常
            QQstate state = (QQstate)Enum.Parse(typeof(QQstate), s);
            Console.WriteLine(state);
            Console.ReadKey();
        }
    }
}
```

如果被转换的值是数字时，则根据相应的值去枚举中寻找相应的索引对应的值，当大于索引时，则输出原数字
如果被转换的值是字符串时，当遇到转换的值在枚举中找不到时，则抛出异常