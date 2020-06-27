# 第四天

## 1.分支结构

```CSharp
if(判断条件)
{
要执行的语句;
}
```

```CSharp
Console.WriteLine("请输入时间：");
int mins = Convert.ToInt32(Console.ReadLine());
if (mins >= 60)
{
    Console.WriteLine("超时了");
}
Console.ReadKey();
```

```CSharp
if(判断条件)
{
要执行的语句;
}
else
{
当条件不成立时执行的代码;
}
```

```CSharp
Console.WriteLine("请输小赵的考试成绩：");
int score = Convert.ToInt32(Console.ReadLine());
if (score >= 90)
{
    Console.WriteLine("奖励");
}
else
{
    Console.WriteLine("惩罚");
}
Console.ReadKey();
```

if-else-if
作用：用来处理多条件的区间的判断

```CSharp
if(判断条件)
{
要执行的语句;
}
else if(判断条件)
{
要执行的代码;
}
else if(判断条件)
{
要执行的代码;
}
......
else
{
要执行的代码;
}
```

## 2.异常捕获

```CSharp
try
{
可能会出现异常的代码;
}
catch
{
出现异常后要执行的代码;
}
```

```CSharp
            int number = 0;
Console.WriteLine("请输入一个数字");
try
{
    number = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("输入的内容无法转换为字符串");
}
Console.WriteLine(number*2);
Console.ReadKey();
```

## 3.变量的作用域

变量的作用域从声明它的那个括号开始到那个括号所对应的结束的括号结束。
在这个范围内，我们可以访问并使用变量，超出这个范围就访问不到了

## 4.switch-case

一般用来处理多条件的定值的判断

```CSharp
switch(变量或表达式的值)
{
    case 值1: 要执行的代码;
    break;
    case 值2: 要执行的代码;
    break;
    ......
    default: 要执行的代码;
    break;
}
```

```CSharp
bool b = true;
double salary = 5000;
Console.WriteLine("请输入李四的评级：");
string level = Console.ReadLine();
switch (level)
{
    case "A": salary += 500;
        break;
    case "B": salary += 200;
        break;
    case "C": salary += 0;
        break;
    case "D": salary -= 200;
        break;
    case "E": salary -= 500;
        break;
    default: Console.WriteLine("输入有误，程序退出");
        b = false;
        break;
}
if (b)
{
    Console.WriteLine("李四明年的工资是{0}", salary);
}
Console.ReadKey();
```

## 5.while循环结构

```CSharp
while(循环条件)
{
    循环体;
}
```

while中的循环体可能一次都不执行

## 6.break

作用：
1. 跳出switch-case结构
2. 跳出当前while循环结构

## 7.do-while循环

```CSharp
do
{
    循环体；
}while()
```

do-while 至少会循环一次

## 8.continue

结束本次循环，重新开始条件判断，进入下次循环

## 9.for循环

```CSharp
for(表达式1;表达式2;表达式3)
{
    循环体；
}
```

表达式1：一般为声明循环变量，记录循环得次数
表达式2：一般为循环条件
表达式3：一般为改变循环条件的代码

```CSharp
for (int i = 0; i < length; i++)
{
    
}
```

## 10.三元表达式

语法：
表达式1？表达式2:表达式3；
表达式1一般为一个关系表达式
如果表达式1的值为True，那么表达式2的值就是整个三元表达式的值，
如果表达式1的值为False，那么表达式3的值就是整个三元表达式的值，
注意：表达式2的结果类型必须和表达式3的结果类型一致，并且也要跟整个三元表达式的结果类型一致

```CSharp
int number1;
int number2;
int max;
Console.WriteLine("请输入第一个数字：");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("请输入第二个数字：");
number2 = Convert.ToInt32(Console.ReadLine());
max = (number2>number1)?number2:number1;
Console.WriteLine("max为{0}",max);
Console.ReadKey();
```
