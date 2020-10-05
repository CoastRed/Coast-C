## 1.枚举

语法：
```CSharp
[public] enum 枚举名
{
    值1;
    值2;
    ......
}
```

`public`：可省略，访问修饰符，公开的，哪都可以访问
`enum`：关键字，声明枚举的关键字

枚举名：要符合Pascal规范

```CSharp
namespace _002_枚举
{
    public enum Gender
    { 
        男,
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            Gender gender = Gender.男;
        }
    }
}
```

