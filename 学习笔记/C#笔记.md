#    常识问题

计算机能识别的命令就是二进制代码——机器码
因为机器码不容易被人类识别，所以出现了一些简易单词的语言——汇编语言
由英文单词组成的短句的命令——高级语言

面向过程
面向对象

行为：能做的一些方法
属性：可以量化的特性

数值类型可以描述类似于血量，防御力，攻击力
在计算机中以二进制的形式存储的

二进制的单位——位
一个8位的二进制数字——  一个字节(byte)可代表2^8个数
**1KB=1024byte**
**1MB=1024KB**
**1GB=1024MB**
**1TB=1024GB**

字符类型可以描述一些抽象概念
在计算机中也是二进制数据只不过通过编码表来翻译成对应的语言文字
如：333：你 ， 334:好
输出333+334=你好

给对象描述行为和属性，就是注入灵魂，这样对象就可以真实呈现在游戏世界中了

**IDE:集成开发环境，可以方便我们快速开发程序——编写代码的软件**

**编译成中间代码**

**中间代码交由CLR，CLR把我们的中间代码编译成对应平台的机器码，以供**
**对应平台去识别程序命令**



绝对路径：从盘符开始索引的目录
相对路径：相对我当前目录的路径


注释：也叫做内联文档，帮助我们梳理程序使用的说明书，需要我们自己写
在要注释的内容前，用//来开头就变成了注释
注释不会对程序有任何影响

程序结构

引用集：引用已经写好的一些资源
命名空间：用来区分同名的程序
类：由一些系列拥有相同属性和相同方法的对象们抽象出来的模板
主函数：是一切方法的入口，是整个程序的开始和结束
主函数的开始象征着程序的出生，如果你还没出生，其他的方法也就没有作用
所以，主函数是一切方法的入口

**{}代表块**
**;代表一条语句**
**()一般跟在方法后面，代表该方法传入的参数，要求你传对应类型的参数**


Console.WriteLine()，让控制台在屏幕打印小括号内的内容
Console.ReadKey(),让控制台等待用户的按键输入

程序都是线性执行的，也叫做线程

**C#=C Sharp**

Console:控制台
.WriteLine（）：控制台的打印方法
.ReadKey():控制台的监听用户按键的方法

.叫做dot语法可以索引到对象的方法和属性

**值类型在栈里，引用类型在堆里**

**控制台的字符串转换**

```
 **int**     

convert.ToInt32(Console.ReadLine())

**int.Parse(Console.ReadLine())**

**shot**

convert.ToInt16(Console.ReadLine()) 

**float**

convert.ToSingle(Console.ReadLine()) 

**double**

convert.ToDouble(Console.ReadLine()) 
```





# 算法



## 随机数查重

 Random rad = new Random();
 int xuehao = rad.Next(1000,10000);

**Exists   判断集合中是否存在满足指定条件的元素（更全面）**

**Contains   判断集合中是否包含指定元素**

随机数找查重的判断返回值bool

**不重复10个随机数：**

```
 static void Main(string[] args)
        {
            Random r = new Random();

            int id = r.Next(0, 20);
            //集合
            List<int> list = new List<int>();

            for (int i = 0; i < 20; i++)

            {
               //判断集合里是否有一样的
               //方法一：IndexOf（垃圾方法）
               //IndexOf返回的是值类型，要用是否>=0来确定要不要执行
                while (list.IndexOf(id) >= 0)
                {
                    id = r.Next(0, 20);
                }
                
                //方法二:contains 
                //也可以用list.Exists(i=>i==id)  
                // Exists需要用委托，所以用lambda简便
               
               //Contains是bool类型
                 while (list .Contains(id)) 
                {
                    id = r.Next(0,20);
                }
                  //添加进list<int>集合里
                list.Add(id);

               Console.WriteLine(list[i]);
            }
        }
```



## 质数问题

**是否质数**

```c#
     //判断一个数是不是质数

                int number = Convert.ToInt32(Console.ReadLine());


                bool result = true;//假设所有数字都是质数，依次循环找是否可取余
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        break;
                    }
                }


                string str = result ? "是" : "不是";
                Console.WriteLine($"{number}{str}质数");
```

**1~100质数**

在判断一个数是否为质数的条件上加一个for

```c#
                //输出1~100全部质数

              for(int number =2;number <= 100; number++)
            {
                  

                bool result = true;//假设所有数字都是质数，依次循环找是否可取余
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
                  
                  
                  
                if (result == true)
                {
                    Console.WriteLine(number);
                }

            }
```







## 斐波拉契数列

```c#
 //规律一个数等于前两位数之和  1,1,2,3,5,8,13.......
            int num1 = 1, num2 = 1;
            for(int i=1;i<=30;i++)
            {
                int num = num1;         //因为赋值时候num1=num2了，后面会加2个num2，所以要提前拿出num1的值
                Console.WriteLine(num1);
                num1 = num2;
                num2 = num + num2;

            }
```



## 乘法口诀表

外层是行，然后列小于行

```c#
   for(int line=1;line<=9;line++)
            {
                for(int colum = 1; colum <= line; colum++)
                {
                    Console.Write($"{colum }x{line}={line * colum,-3}");
                    //一般colum(列)在前,line(行)在后,反一下也可以，不换行，写write
                }
                Console.WriteLine();
            }
```



## 排序算法



### **自带的排序方式**

数组举例，且集合排序同做法

```
数据：int[] A = {16, 67, 12, 50, 8, 46, 4};
整体升序：Array.Sort(A);
整体降序：先升序，再反转Array.Reverse(A);
局部升序： Array.Sort(A,2,4);//从索引为2的元素开始的4个元素进行升序
局部降序：Array.Reverse(A,2,3);//对索引为2的元素开始的3个元素进行反转
```



### 选择排序

```c#
 static void Main(string[] args)
        {
      int[] array = { 34, 78, 11, 65, 79, 12, 5, 5, 3, 45 };
            XuanZhe(array);
            foreach(int i in array)
            {
                Console.Write(i + ",");
            }
           
        }
     
        static void XuanZhe(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j=i+1;j<array.Length;j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp;
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
```



### 冒泡排序

 

```
 static void Main(string[] args)
        {
            int[] array = {45,12,56,13 };
            MaoPao(array);
            foreach(int i in array)
            {
                Console.Write(i + ",");
            }
           
        }
     
        static void MaoPao(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)//和选择不一样，这里是循环次数
            {
                for (int j=0;i+j<array.Length-1;j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp;
                        temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
        }
```



# 随机数 

​	**骰子举例**

```
第一步，你得先建立一个骰子
Random 骰子名=new Random();

第二步，调用扔骰子的方法
骰子名.Next();//扔骰子的方法  0到2^16-1次方
骰子名.Next(maxValue);//0到maxValue-1
骰子名.Next(min，max);// min到max-1

第三步，用一个变量取接收骰子随机出来的数值
如： int num=骰子名.Next(1,101);//在1-100中随机一个数出来
```



# 数值类型	

```
整数类型 int 用来描述整数 4个字节  32位
	如：100,2200,888
	注意 int类型只取整数部分的信息，不会取你的小数信息
	
浮点类型 float（single） 用来描述小数 4个字节 32 
	最多可以表示7位有效数字
	如果说你的数据是float类型，在数据后加上f
	如：3.141592f;如果没有f会辨识为double类型
	如果你的长度超过了你float类型的长度，会进行四舍五入，超过长度的数据 	会丢掉

字符类型
	字符串 string 用来描述一串字符 8个字节  64位
	用双引号表示字符串
	字符 char 用来描述一个字符 2个字节 16位
	用单引号表示字符
    
	因为计算机只认识数字，不认识人类的语言
	所以我们做了一本字典（asc码表）把数字和字符联系在一起
	所以字符类型的本质就是一个数字

bool类型 用来描述真假 true/false  1个字节  8位

sizeof（数据类型）：可以查看你传入的数据类型所占几个字节
```

# 常量/变量

```
变量/常量，都是用来存储数据的盒子

变量
	数据类型 变量名=初始值
	1.可以赋初始值
	2.可以重新赋值

常量
	const 数据类型 常量名=初始值
	1.必须赋初始值
	2.不能重新赋值

关键字：C#语言会定义好一些单词的含义如：namespace ,class ,int等
	那么我们在给变量取名的时候就不能取这些被定义好了的关键字	
```

# String操作

两个字符串可以比大小 CompareTo（）

Contains()是否包含子串某字符

Insert（）插入一个字符进字符串

通过Split()分割字符串成字符串数组

```
        
          //CompareTo（）方法 两个字符串可以比大小abc大于abd
        int results ="abc".CompareTo("abd");

        //Contains()是否包含子串a
        bool c = "abc".Contains("a");
        //插入一个字符进字符串
        string st = "abc".Insert(0,"s");

        //通过Split()分割字符串成字符数组
        string[] sp = "yan,man,yi".Split(',');
```





例题：通过设定的字符Split（‘，’）切割输入的字符串拿到其中**最长**的字符串数组

```
 static void Main(string[] args)
    {


        string st = Console.ReadLine();
        string[] s1 = st.Split(',');


        string results = "";
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1[i].Length > results.Length)
            {
                results = s1[i];
            }


        }
        Console.WriteLine(results);

    }
```

## String.format("0:D2}",a)字符串格式化



```
C 或 c 
货币 
Console.Write(“{0:C}”, 2.5); // 
2.50Console.Write(“0:C”,−2.5);//( 
2.50Console.Write(“0:C”,−2.5);//( 
2.50) 
D 或 d 
十进制数 
Console.Write(“{0:D5}”, 25); //00025 
E 或 e 
科学型 
Console.Write(“{0:E}”, 250000); //2.500000E+005 
F 或 f 
固定点 
Console.Write(“{0:F2}”, 25); //25.00 
Console.Write(“{0:F0}”, 25); //25 
G 或 g 
常规 
Console.Write(“{0:G}”, 2.5); //2.5 
N 或 n 
数字 
Console.Write(“{0:N}”, 2500000); //2,500,000.00 
X 或 x 
十六进制 
Console.Write(“{0:X}”, 250); //FA 
Console.Write(“{0:X}”, 0xffff); //FFFF 
百分数格式应该用“p”这个参数。 
格式 原始数据 结 果 
“{0:P}” 0.40 40% 
1、格式化货币（跟系统的环境有关，中文系统默认格式化人民币，英文系统格式化美元） 
string.Format(“{0:C}”,0.2) 结果为：￥0.20 （英文操作系统结果：$0.20） 
默认格式化小数点后面保留两位小数，如果需要保留一位或者更多，可以指定位数 
string.Format(“{0:C1}”,23.15) 结果为：￥23.2 （截取会自动四舍五入） 
格式化多个Object实例 
string.Format(“市场价：{0:C}，优惠价{1:C}”,23.15,19.82) 
2、格式化十进制的数字（格式化成固定的位数，位数不能少于未格式化前，只支持整形 ） 
string.Format(“{0:D3}”,23) 结果为：023 
string.Format(“{0:D2}”,1223) 结果为：1223，（精度说明符指示结果字符串中所需的最少数字个数。） 
3、用分号隔开的数字，并指定小数点后的位数 
string.Format(“{0:N}”, 14200) 结果为：14,200.00 （默认为小数点后面两位） 
string.Format(“{0:N3}”, 14200.2458) 结果为：14,200.246 （自动四舍五入） 
4、格式化百分比 
string.Format(“{0:P}”, 0.24583) 结果为：24.58% （默认保留百分的两位小数） 
string.Format(“{0:P1}”, 0.24583) 结果为：24.6% （自动四舍五入） 
5、零占位符和 数字占位符 
string.Format(“{0:0000.00}”, 12394.039) 结果为：12394.04 
string.Format(“{0:0000.00}”, 194.039) 结果为：0194.04 
string.Format(“{0:###.##}”, 12394.039) 结果为：12394.04 
string.Format(“{0:####.#}”, 194.039) 结果为：194 
下面的这段说明比较难理解，多测试一下实际的应用就可以明白了。 
零占位符： 
如果格式化的值在格式字符串中出现“0”的位置有一个数字，则此数字被复制到结果字符串中。小数点前最左边的“0”的位置和小数点后最右边的“0”的位置确定总在结果字符串中出现的数字范围。 
“00”说明符使得值被舍入到小数点前最近的数字，其中零位总被舍去。 
数字占位符： 
如果格式化的值在格式字符串中出现“#”的位置有一个数字，则此数字被复制到结果字符串中。否则，结果字符串中的此位置不存储任何值。 
请注意，如果“0”不是有效数字，此说明符永不显示“0”字符，即使“0”是字符串中唯一的数字。如果“0”是所显示的数字中的有效数字，则显示“0”字符。 
“##”格式字符串使得值被舍入到小数点前最近的数字，其中零总被舍去。 
6、日期格式化 
string.Format(“{0:d}”,System.DateTime.Now) 结果为：2009-3-20 （月份位置不是03） 
string.Format(“{0:D}”,System.DateTime.Now) 结果为：2009年3月20日 
string.Format(“{0:f}”,System.DateTime.Now) 结果为：2009年3月20日 15:37 
string.Format(“{0:F}”,System.DateTime.Now) 结果为：2009年3月20日 15:37:52 
string.Format(“{0:g}”,System.DateTime.Now) 结果为：2009-3-20 15:38 
string.Format(“{0:G}”,System.DateTime.Now) 结果为：2009-3-20 15:39:27 
string.Format(“{0:m}”,System.DateTime.Now) 结果为：3月20日 
string.Format(“{0:t}”,System.DateTime.Now) 结果为：15:41 
string.Format(“{0:T}”,System.DateTime.Now) 结果为：15:41:50



string strNeed = string.Format("{0}{1}",str1,str2);  //可以拼接成各种字符串

string strNeed = string.Format("{0:F2}", 2.3634f); // 可以使字符串为保留两位小数的浮点数值

string strNeed = string.Format("{0:D2}",5);  // 可以使字作串为两位整数的值，不足位数前面补零 或者ToString("00");

string strNeed = string.Format("0:3:X");   // 可以使字符串为十六进制的值
```



```
string strNeed = string.Format("{0:D2}",5);  // 可以使字作串为两位整数的值，不足位数前面补零 或者ToString("00");
```



# 命名规则

```
1.变量名必须以字母或者_开头
	2.变量名只能是字母数字_的组合
	3.变量名不能和关键字重名
	4.变量名不能和其他变量名还有方法名重名
	
命名规范
	1.Camel驼峰命名法：首个单词的首字母小写其余单词的首字母大写（如：myAge）
	在C#中变量一般以此命名法命名

	2.Pascal命名法 帕斯卡：每个单词的首字母都大写如（MyFuncition）
在C#中类名或者方法名以此法命名。
如遇到缩写，则每个字母都大写如（HP ATK MP）等
```



# 运算符

		= 赋值符号
		作用：把右边的内容赋值给左边，注意，赋值号左右变量的数据类型必须相同
		如：int age=18;
		
		+ - * / %
	
	他们是有运算优先级，可以使用（）改变运算优先级
	+也可用于字符串连接
	
	++自加符号：让自己+1；
	--自减符号：让自己-1；
	自加/减符号为前缀时，先增减后使用，为后缀，先使用后增减；
	在使用的时候才有前后缀之分；

# 关系运算

<	>	 >= 	<= 	 ==	 !=	返回结果都为bool值，true or false

​	

# 数据类型转换

隐式转换：是系统自动进行的，不需要声明，不会造成数据丢失，一般不会失败	发生条件：低精度的数据朝高精度转换的时候进行

	整型和浮点型可以进行混合计算
	但是，要先转成同一类型后，再计算
	转换规则参考表
	
	显式转换：是我们手动进行的，在转换过程中，可能会出现数据丢失，转换不成功时会报错
	因为是手动调用，所以可以再任意时候转换
	甚至可以将精度高的数据转成精度低的数据
	
	1.强制转换运算符 （）
	（转换的类型）要进行转换的变量
	强制转换符目前只能转换数值类型，不能转换字符串
	
	2.Convert转换类
	是C# System库下 的一个数据类型转换工具
	用法：Convert.ToXXX(你要转换的变量)，XXX代表你要转换的类型
	只能从一个基本数据类型转换成另外一个基本数据类型
	转换成功，会返回给你一个对应类型的数据，要用一个变量去接收
	
	3.XXX.Parse（要转换的变量）
	可以将字符串转换成对应的XXX类型
	字符串必须为可转的数值，不然会报错
	如：int a=int.Parse("32"),这样我们就把32这个字符串转成数字了

# 逻辑运算符

​	&& 与运算符 双目运算符 左右两边都是布尔表达式
​	当两边的值都为true时，运算结果才为true
​	其余情况都为false

	|| 或运算符 双目运算符 左右两边也是布尔表达式
	只要有一边情况为true时，则运算结果为true
	如果两边都为false，则为false
	
	！ 非运算符 单目运算符 只有一个布尔表达式
	结果与布尔表达式的结果相反

# 条件语句

​	**三目运算符**
​	表达式1？表达式2：表达式3
​	

	表达式1一定是布尔表达式
	如果为true则执行表达式2，整个式子的结果为表达式2的结果
	如果为false则执行表达式3，整个式子的结果为表达式3的结果

​	

## if语句

​	if(布尔表达式) {  代码  }
​	当布尔表达式为真时 ，会执行if块中的代码
​	为假的时候会跳过if块

	if(布尔表达式) {  代码  } else{ 代码 }
	当布尔表达式为假的时候，会进入else块中
	为真的时候会进入if块中
	两者只能进一个

条件语句
	if（）{}
	else if(){}
	else if(){}
	else if(){}
	.....
	else{}
	

	会去判断if（）里的条件，如果为假，会接着去判断下一个else if（）的条件
	一旦有一个条件为真，会进入对应的块中执行里面的代码，其他的就不会去判断了

## **Switch**

​	switch(表达式)
​	{
​		case （标号）常量值：
​			该情况执行的代码；
​			break;//代表该情况执行完毕

		case 常量值：
			该情况执行的代码；
			break;//代表该情况执行完毕
	
		case 常量值：
			该情况执行的代码；
			break;//代表该情况执行完毕
		....
		default:
			break;
	
	}
	
	表达式的结果可以是整数，字符 ，枚举
	标号的数据类型必须和表达式一致
	标号具有唯一性
	标号的顺序是可以改变的
	当所有case（情况）都不满足时，会执行default语句
	每一个switch块中只有一个default;



​	

## **while循环**

​	while（循环条件）//循环条件为布尔表达式
​	{
​		循环体
​	}

	当执行到while循环时候会先检测循环条件，当条件为真时，执行块中的循环体，
	执行完循环体后，会回到循环条件，再次询问条件是否为真，为真就接着去执行循环体
	为假则循环执行完毕。
	
	break：在switch语句中，跳出switch，在循环中，不管条件，直接终止循环。
	
	continue：在循环中，可以跳过本次循环，直接开始下一次循环的流程。

 




















## do whlie循环

​	do{}while(条件)
​	先不管循环条件，进入循环体执行一遍
​	然后再去询问执行条件，如果满足则执行循环体
​	不满足则跳出循环

## for循环

​	for(初始表达式；循环条件；增量表达式 )
​	{           }

	第一步执行初始表达式
	第二步询问循环条件。
	第三步，为真，执行循环体，为假跳出循环
	第四步，执行完循环体后，会执行增量表达式
	第五步，再次询问循环条件


复杂数据类型
	就是基本数据类型的组合
	一个角色 的血量，防御力，攻击力，等级等

# 枚举

​	是一种自定义数据类型
​	在使用枚举类型的变量前，先定义出这个数据类型
​	可以描述事物的状态，或者有限的结果

**写类外和类里面都可以**，都需要创建一个枚举的变量

	定义：
	enum 枚举名
	{
		枚举项,
		枚举项,
		枚举项
	    }
	
	1.枚举的本质是Int
	2.枚举可以和int类型进行互换——使用显示转换
	3.默认情况下，第一个枚举数的值为 0，后面每个枚举数的值依次递增 1。
	4.可以使用赋值符号，重新给枚举项赋int值
	
	枚举的使用
	1.在使用前，先定义出你自己的枚举类型
	2.其他数据类型是一样的使用方法，用变量这个盒子去装载
	
	枚举的转换
	1.和Int类型进行转换——显示转换
	2.枚举可以转成字符串——枚举变量名.ToString（）；
	3.字符串转枚举
	（自定义枚举类型的名字）Enum.Parse( typeof(枚举类型)，"你要转换的字符串");

举例：

**适用于那种有限的取值范围、月份，四季，性别等数据**

```
using System;
public enum Season   //season 季节
{ 
    spring,//0
    summer,//1
    autumn,//2
    winter,//3//在最后一个逗号可不写

}
class program 
{ 
public static void  Main(string []args)
    {
        Season s = Season.summer;
        Console.WriteLine(s);
        Console.WriteLine(s+1);//表示下一个数据，只有整型和字符串可以加整型
    }
}
```



# 访问修饰符

​	

	放在变量或者类名，方法名前面，用来修饰它的可访问性
	
	public关键字：代表公开，谁都可以访问
	
	private关键字：代表私有的，只有自己本身才可以访问（变量和方法的默认访问修饰符）
	
	protected关键字：代表继承的，只有自己和自己的子类才可以访问
	
	internal 本程序集（*类*和结构体的默认访问修饰符）

作用域
	在哪个块中，就对哪个块（包含子块）有作用.

# 结构体

​	概念：
​	描述事物的结构关系
​	可以包含多个基本数据类型，也可以包含其他复杂数据类型
​	它不可以包含自身类型

	因为是复杂数据类型，是自定义的
	所以在使用前，先定义出这个数据类型
	
	定义：
	定义了一个结构体的模板，通过这个模板可以创建结构体的对象
	struct 结构体名{  成员，成员，成员  }
	成员前面要加上public访问修饰符，我才能进行外部访问


	实例化：通过模板创造出对应的对象。
	结构体在使用时，需要实例化一个对象。
	结构体名 变量名（对象名）=new 结构体名（）；
	在内存中开辟一块空间用来存储我的对象
	
	调用：
	结构体对象成员的调用
	对象名.成员
	
	static：静态
	如果你的成员被静态修饰了，只能通过结构体名.成员名调用
	
	静态和非静态的调用区别
	静态：类型名称.静态成员调用
	非静态：对象名.成员调用

一般字段只有一两个可以考虑考虑使用结构体

不能有无参数构造方法

有参数构造方法必须给字段赋值；

结构体始终包含一个无参数构造方法，好实例化，不像类方法一样，写了就没了。

结构体不能继承

结构体和类基本上一样，但

换成了class就是类了，两者相似，**类是引用类型**(堆上开辟空间)，**结构体是值类型**（栈上开辟空间），前面的什么int，bool，double什么的值类型**都是结构体类型**

引用类型传的是地址

右键看  定义上是一个结构体

**引用类型在堆上开辟空间**

# foreach遍历

**遍历数组快速枚举**

**相对于for遍历，有局限性**

//如果数组不是int类型的，就要拿与数组匹配的类型来快速遍历

```
foreach(int i in array)
{
console.Write(i+",");
}
```



# 数组

​	连续的，有顺序的集合

数组：数组就是一个容器，用来存储一系列相互兼容的数据变量

**实例化一个数组：声明一个数组，并且赋初值**

**数组中的元素访问**

访问数组中元素通过元素下标；在程序中，元素下标是**从0开始**

Length是表示a中元素个数；

我们是通过下标的值来取得数字组中对应的值， 而下标是从0开始计算的， arr[0]为第一个元素， 如果arr中有5个元素，则最后一个元素的下标为4，arr的length为5 即下标为（length-1）的元素为最后一个元素。	

	声明：告诉计算机这是个什么玩意
	
	数组的声明：
	数据类型[] 数组名;
	数据类型[] 数组名=new 数据类型[长度];
	数据类型[] 数组名={ 元素1，元素2，元素3.....  };
	数据类型[] 数组名=new 数据类型[长度]{ 元素1，元素2，元素3.....  };
	
	new在内存中开辟空间，如果没有赋值，则赋上默认值
	
	具体举例：
	int类型的数组声明
	int[]array；
	int[]array=new int[10];
	int[]array=new int[10]{1,2,3,4,5,6,7,8,9,10}
	int[]array={}


	数组元素的访问
	通过下标号去访问  数组名[下标号]
	下标号从零开始计数
	
	元素的更改
	可以通过下标号访问到你要更改的元素，然后重新赋值
	数组名[下标号]=新的值
	
	遍历：把所有的元素都访问一遍
	遍历数组：下标号从0开始到数组长度-1结束；
	用for循环特别适合遍历数组


	属性
	.Length：代表你数组的长度
	
	清空数组
	textArray[]
	 Array.Clear(textArray, 0, textArray.Length);

**二维数组**

	声明：
	数据类型[,] 数组名
	数据类型[,] 数组名=new 数据类型[行的长度，列的长度]
	数据类型[,] 数组名=初始值
	
	如：int[,] arr= new int[2,3]
	int[,] arr={ {1,2,3} ,{4,5,6} };


	访问：
	也是通过下标号访问， i,j
	arr[i,j]   i：你在哪一个数组中，j:代表你在该数组中的第几位


	赋值：直接通过下标号去赋值
	
	遍历：双层for循环，第一层遍历第一个维度的长度，第二层遍历第二维度的长度
	
	方法：
		数组名.GetLength( index ) //从0开始，0代表第一个维度，1代表第二个维度....





**交错数组**

	多维数组，每个数组的长度是一样长的
	
	交错数组，每个数组的长度不一样
	
	声明
	
	数据类型[][] 数组名=new 数据类型[长度][]
	
	因为每个数组的长度不定，所以，在声明阶段，只定义有几个数组


	遍历：
	foreach（数据类型 item in 集合  ）
	{  访问item  }
	只能访问，不能赋值
	而且foreach会产生内存碎片，影响效率


	var的作用：可以先不定义类型，让系统自动去判断
	尽量少使用var


	如：
	int[][] arr=new int[3][]{
		new int[2]{1,2},
		new int[3]{3,4,5},
		new int[4]{6,7,8,9}
	}
	
	foreach( var item in 交错数组)
	{
		foreach（var i in item){
			Console.WriteLine(i);
	
		}
		
	}



# 函数（方法）

​	函数的概念：
​	封装我们的逻辑，以便重复使用
​	

	函数（方法）可以有返回值
	方法得有参数的接入口


	函数的定义：
	函数只能声明在类，结构体，接口中
	
	static 访问修饰符 返回类型 方法名（参数类型，.......）
	{
		方法体；
		
	}
	
	如果说你有返回值，返回类型处填上你要返回数据的类型
	可以在函数中使用return关键字返回对应的结果。
	
	如果没有返回值，在返回类型处用void关键字填充
	也可以使用return关键字跳出函数。


​	**调用：**
**​	静态方法：被static修饰过的方法就叫静态方法**
**​	特征：调用上，通过类型名称.方法名（）**
**​**	
**​	非静态方法：没有被static修饰过，也叫做成员方法**
**​	特征：调用上，必须要先实例化一个对象，再去通过对象名.方法名（）；**
**​**	
**​	通过（）形参列表可以传递参数到函数中**
**​**	
**​	传参：值类型与引用类型**
**​	值类型：存在栈中。**
**​	引用类型：内容存在堆中，地址存在栈中。**


	值类型传参的特征，就是在栈中去复制了一份值。
	
	引用类型传参的特征，因为复制的是地址，而地址指向同一个空间，所以如果你在函数中
	更改内容则会更改原内容。


	为了让值类型传参可以修改原内容，出现了一个关键字
	ref关键字——索引地址符
	使用：1.在定义函数的的参数列表时，把你想要索引的值类型的那个参数前加上ref
	      2.在调用方法时，在传递参数时，依然也要写上ref


	1.函数定义
	2.函数的调用
	3.不同类型传参
	4.ref索引地址符的使用



# 关键字

​	this——指代自身实例对象
​	ref——让值类型传参对实际参数有作用
​	out——通过参数列表可以额外输出一个信息

	out:
	1.在定义函数参数列表时，可在参数前添加
	2.在函数跳出前，一定要先赋值，不然会报错
	3.在函数调用时，在被out修饰过的参数前，要加out
	
	ref：
	1.在定义函数参数列表时，可在参数前添加
	2.在函数调用时，在被ref修饰过的参数前，要加ref
	3.在调用前，ref的参数一定要先赋值

## ref和out

**修饰方法的参数**。在面对其他方法里对值的交换时候，主函数里的**值类型**并没有交换的情况，这个传递的是地址

```
 static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Swap(ref x,ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);

        }如果没有加ref或者out,那么只会在Swap里修改了值.主函数里并没有改变，这个是无返回值的方法哦
        下面的数组是引用，所以引用的一律不需要，在堆上执行，传递的值是地址
        static void Swap(ref int a, ref int b) 
        {
            int t = a;
            a = b;
            b = t;
            
        }
```

## params


	params：可变参数传参
	1.可变参数传参，在函数定义的时候可以，在参数前加上
	2.被params参数必须是数组类型
	3.必须放在函数参数列表的最后一位
	
	在调用数组方法时候在形参前面加上params
	在调用方法的时候可以将数组中的元素直接写在参数列表中

## readonly

readonly（只读）

readonly和const的区别

1：readonly可以没有初始值，const一定需要初始值；

2：readonly可以在构造方法里修改赋值



## Sealed

表示密封，可以修饰类，也可以修饰方法

密封类作用：不能被继承

密封方法不能被重写，加上去了的话







# 函数的重载

	概念：
	当参数列表不一致时
	则同名函数构成重载
	1.在编译时，系统会自动判别你的参数列表，根据参数列表去对应你的方法
	2.返回类型对重载无影响


	结论：唯一判别是否重载的标准是参数列表

 先锋的：

在一个**类**中，如果有多个方法满足一下条件，那么这些方法彼此之间是重载关系

**一：方法名相同**（包括了实例化作用的构造函数）

**二：参数不同**：数量不同 && 类型不同。

就是方法名相同，但**参数**要不一样。





# 函数的递归

​	方法自己调用自己 ，方法循环调用
​	1.如果没有边界，会无限调用自己，把栈爆了
​	2.所以我们要有跳出——return
​	3.跳出就要有条件——达到目的——边界
​	4.每次调用要有变化，变化朝边界靠近
​	5.一旦到达边界，就跳出

具体实例：

**求第n个斐波拉契数列的数值**

（打出全部数字来加一个for就好了）

```c#
  static int index(int x)//用递归求斐波拉契数列第几个的值;
        {
            if (x == 1 || x == 2)
            {
                return 1;

            }
            return index(x - 2) + index(x - 1);
        }
```







# static静态

在main函数里（非静态的方法才需要实例化，**静态的方法直接调用类名.方法，在当前类里就直接写方法名字**）

**静态的成员是属于类的，访问的时候需要用来类来访问**

非静态的成员是属于对象的，访问的时候需要用**对象**来访问。

**只执行一次：**

因为储存空间分 栈（值类型）堆（引用类型）还有格外一个静态存储空间，不能被像堆一样，开辟不同空间，第一次开辟就一直是同一个地址了

每次new的时候堆上可以开辟不同的空间，但在静态储存空间上只会执行一次，所以空间只有一块



构造方法

    class person
    { 
        public person()
        {
    
        }
        
    }
# 构造方法



1：构造方法**没有返回值**，甚至void都不能写

2：**构造方法名必须是类名**

3：**实例化对象时候需要一个构造方法**

（构造方法就是用来实例化的对象的，如果没有构造方法，系统有默认的无参数构造方法哦，所以之前的实例化都是可以成功的）



## **static构造方法**

静态构造方法必须**无参数**

静态构造前面**不能访问修饰符** public 或者private，这是属于非静态

静态构造方法在main里 实例化对象时候，默认的那个非静态无参数构造方法不会有影响   ，依旧是那个非静态无参数构造方法实例化的，但这个静态的无参数构造方法也会执行，但执行一次**第二次不会执行**

# 类：

​	也是复杂数据类型
​	也是需要我们先定义出类型，
​	才能去使用它的数据
​	

	把一系列相同属性或相同行为的对象，
	抽象出共同属性行为的模板就叫做类


	属性：在程序中通过字段（所有数据类型的变量）和属性（C#的特性）
	来描述事物的特征。
	
	行为：在程序中通过方法（函数）来描述事物的行为
	
	声明：
		class 类名{
			字段;
			属性;//封装后的字段
			方法;
		}
	
	类名 对象名（变量名）=new 类名（）；
	
	和结构体很相似，结构体对象是值类型
	类对象是引用类型 
	
	初始化：对类对象的成员进行赋值
	在实例化后应该对其对象初始化

## 	**构造方法**

3：构造方法**不能**显示调用（调用构造方法**不能**像静态以**类名调**用，也不能像非静态用实例化**对象名调**）

类名 xx=new 类名（）实例化的时候直接调用

4:类里一定有非静态构造方法，如果没有  **构造方法**      时候实例化对象的时候默认一个**无参数**（非静态）构造方法**自动调用**的

如果添加一个公有的（非静态）构造方法，所以不会引用默认公有无参数（非静态）构造方法，如果是静态的构造方法，那个默认的还会有哦

## 对象：

​	对象：是通过模板类实例化出来的个体，他具有具体的属性和行为（方法）
​	对象不能索引到静态方法。

	对象的生命周期
	构造（出生）——使用（活着）——析构（死亡）


	构造函数：当一个类被实例化为一个对象时，
	将会调用构造函数完成对象的初始化


	可以指定一个类的构造函数
	
	声明方法：
		访问修饰符 类名（参数）
		{
			初始化；
		}
	
	1.没有返回类型，因为固定返回对应的对象
	2.构造函数的方法名必须和类名一致
	3.不指定时，将有一个默认构造
	4.如果指定，默认构造将会失效（但可重载出默认构造）
	
	This关键字：
	1.指代自身的实例对象
	2.指向自身的构造函数


	对象的使用：有变量直接或间接指向对象的空间，则在被使用，
	如果没有了，会被C#的垃圾回收机制判定为垃圾，被回收掉


	析构函数
	调用析构函数对象将会释放，在C#中对象的释放由垃圾回收机制完成
	声明：~类名(){}。
	注意
	1.没有访问修饰符
	2.没有返回值，不能写void
	3.函数名必须是 ~类名
	4.不指定时，将有一个析构
	5.指定时，默认析构将失效
	6.不可重载
	7.在垃圾回收时自动调用


	垃圾回收机制
	是C#中CLR内存管理机制，他将会帮助我们有效的释放内
	存，在一定程序上保证了对象的安全性，及使用的便捷性。








## 属性

​	因为你把字段全public，会非常的不安全，外部可以随意更改你的值
​	有可能会导致你程序出问题，这个时候，我们就把它取消public
​	但外部就不能访问了，所以我们公开了两个api，一个是Get方法
​	可以让外部访问我的字段，一个是Set方法可以接收外部的传参来修改
​	因为两个方法都是自己定义的，所以可以保护你字段的合法性

	后来C#针对这个问题，出了一个特性——属性
	
	因为通过方法返回和修改，所以多了性能消耗


​	

	声明属性
	访问修饰符 数据类型 属性名{
		get{
			return
			}
		set{
			字段=value;
			}
	
	}
	
	get块和set块本质上是两个方法
	
	1.属性内部有两个块，set块和get块
	2.get块代表外界访问，所以get中必须要有return返回结果
	3.return的返回结果要和属性的数据类型保持一致
	4.set块代表外界写入，可以通过value关键字来接受外界的传参
	5.可以只有一个块
	6.get块和set块前面都可以加访问修饰符
	7.属性名一般和你保护的字段保持一致，只不过首字母大写


	自动属性
	用空语句代替get块和set块，则被称为自动属性
	它会在编译时自动生成一个变量供get和set使用
	
	访问修饰符 数据类型 属性名{
		get;
		set;
	}
	自动属性的set是可以不用写



例子：

```c#
 class person
    {
       public  string name;
        private int age;//私有化的字段的保护，封装起来如下
        public void  Setage(int i)

        {
            if(i<0 || i >150)
            {
                return;
            }
            age = i;
        }
        public int Getage()
        {
            return age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person manyi = new person();
            manyi.name = "yanmanyi";

            manyi.Setage(61);//如果private的age不在条件范围内，就不
       
            Console.WriteLine(manyi.Getage());
           

        }
    }
```



作用于......**字段**私有化后，除了以上方法，可以用属性访问器来实现设置字段值，所以属性差不多就是字段，只是后面加了不一样条件



权限修饰符   **要访问字段**的类型   属性名｛｝ 

 注释：和方法差不多，没有小括号，注意，属性不能有小括号，要不然就是方法了

属性名**开头大写**，里面的就是 set和get

例如；

```
 class person
    {
     
        private int age;
        public  int   Age//这个是属性
        {
           // 写操作
           set           //set和get属于访问器
            {
                //访问器中，value表示外界传来的值
                if(value>=150)
                {
                    age = value;
                }
            }
           //读操作
           get
            {
                return age;
            }
        }
      
    }
```











## 静态类

​	用static关键字修饰的类叫做静态类
​	1.静态类只能有静态成员（静态的方法，字段，属性）
​	2.静态类不允许实例化
​	3.静态类在项目中，资源是共享的，唯一的
​	所以，当我们需要一个统一管理的工具，或者制作工具时，可以
​	考虑使用静态类

	4.静态类会随着程序同生共死，会一直占有资源
	所以静态类在项目中应该越少越好


	静态类的声明
	static class 类名{
		static 字段；
		static 属性；
		static 方法；
		
	}
	
	调用静态类的成员：类名.静态成员


	静态与静态的区别
	成员调用：静态成员通过类名调用，非静态成员通过对象名调用
	类的成员：静态类只能包含静态成员，非静态类可以包含静态成员
	方法的区别：静态方法只能调用静态成员，非静态方法可以调用静态成员

# 单例模式

​	为了既发挥静态的优点——资源共享的优点，又避免静态一直霸占资源的缺点
​	所以出现了单例模式

	使用唯一个静态变量来索引堆中的内容
	
	1.不允许别人去实例化出其他个体（封闭构造函数）
	2.那么为了别人方便索引，而且只能访问，使用属性的get方法去封装这个变量
	3.在外人访问的时候，得先判断一下，这个静态变量存储的地址是否空
	4.如果为空，就要去堆中开辟空间（使用new 构造函数（） 创建一个新对象）
	5.如果不为空就可以直接返回
	6.这样，该类中其他非静态的成员，就可以通过这唯一一个静态变量去索引（用dot语法）

里面有**动态数组扩容**

```
namespace 静态类
{


   public struct Vector2 {

        int x, y;

        static int a;
       

        public Vector2(int x, int y) {
            this.x = x;
            this.y = y;

        }

    }


    //声明一个怪物类，一旦实例化一个怪物，就自动添加到管理类中去
    //给怪物加一个攻击的行为：在方法中输出一句话
    //声明一个怪物管理类（静态）

    //实例化10只怪物，让他们统一执行攻击指令


   public class Monster
    {

        string name;


        public Monster() { }

        public Monster(string name)
        {

            this.name = name;
            //自动添加到管理类中去
            MonsterManager.Intance.AddMonster(this);

        }

        public void Attack()
        {

            Console.WriteLine("{0}攻击了", name);
        }

    }


    //单例模式

    //单一的实例

    //把类对象封装成静态对象

    //关闭此类构造函数

    //用属性封装静态对象

    //公开这个属性，以供外部调用

    //这样就达到了， 在静态区中只有一个变量地址，但是内容是存在堆中的效果

    //这样既发挥静态的优点，又避免了静态的缺点


    public class MonsterManager
    {
        //把对象索引地址从栈中，放到了静态区中
        //1.声明一个本类的静态对象
        private static MonsterManager instance;//封装了一个静态对象

        public Monster[] list;

        //2.使用属性将这个对象封装起来
        public static MonsterManager Intance
        {
            get
            {
                //4.在get块里，判断我当前这个对象的地址是否空
                if (instance == null)//一旦有外人来访问地址，先看看堆中是否有内容，如果没有，就开片空间//unity里切换场景的时候，需要重新new对象类开辟新的堆空间
                {
                    //5.如果为空则实例化一个对象，不为空直接返回
                    instance = new MonsterManager();
                }
                return instance;//再把新开空间的地址返还出去
            }
            //3.删除set块，不让外部随意写入
        }

        //6.把构造函数private私有化起来，这样外部不能去创造我这个类的实例
        private MonsterManager()
        {
            list = new Monster[4];

        }//封闭了本类的构造函数


        //可动态扩容的添加方法
        public void AddMonster(Monster m)
        {

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == null)//如果有空位
                {
                    list[i] = m;
                    return;
                }
            }
            //如果没有在上面的流程中return掉，代表数组满了


            //声明一个新的数组，长度是原来的两倍
            Monster[] temp = new Monster[list.Length * 2];

            //把原来数组的数据复制到新数组中
            for (int i = 0; i < list.Length; i++)
            {
                temp[i] = list[i];
            }
            //list重新取最新的数组
            list = temp;
            //把怪物安插进数组中
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == null)//如果有空位
                {
                    list[i] = m;
                    return;
                }
            }


        }

    }



    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 1000; i++)
            {
                new Monster("第" + i + "号哥布林");
            }


            for (int i = 0; i < MonsterManager.Intance.list.Length; i++)
            {
                if (MonsterManager.Intance.list[i] != null)
                {
                    MonsterManager.Intance.list[i].Attack();
                }

            }


        }
    }
}

```



# 继承



​	是C#中面向对象的一个重要概念，用一个已存在的类去定义出一个新的类
​	新的类叫做 子类/派生类
​	已存在的类叫做 父类/基类/超类

	C#中所有类的最终基类都是Object类
	
	声明
	访问修饰   class 派生类名：基类名{
	
	}
	
	特性：
	1.一个类只可以直接继承一个基类
	2.派生类拥有基类的所有属性和方法
	3.基类的成员不允许子类访问，子类是无法访问到的
	4.子类会默认调用父类的默认构造函数
	5.如果父类的默认构造函数失效，子类需要重新指定（用base）
	6.如果你的类没有父类，将默认继承Object类



# 继承中的构造方法



所以实例化**子类**前先实例化**父类**

**解决方法1**：因为父类里有构造方法的话，就没办法引用那个无参数默认的构造方法，所以，无法实例化，那就**加一个无参构造方法**



```
using System;

class m 
{ public string name;
    public int age;


    public m() { }//需要这个来实例化，因为自己是构造方法，不能直接继承，写了一个构造，默认构造方法无法引用
    public m(string name) { this.name = name; }
    
   
}

class A : m { }

    class Program
    {
        static void Main(string[] args)
        {
        m a = new m("yanmanyi");//实例化对象哦，此时开辟的空间里有父类和子类，然后就先去了给父类m实例化了
       //类A里的是默认的无参构造方法哦

    }   }

```

**解决方法2：**

# ：base（）

先指向父类有参数的构造方法

```
using System;

class m 
{ public string name;
    public int age;


    
    public m(string name) { this.name = name; }
    
   
}

class A : m {
    public A(string name) : base(name) //  :base()   A实例化前先指向父类有参数的构造方法,   :this()用于当前类中方法的指向
    {  }
}

    class Program
    {
        static void Main(string[] args)
        {
        A yan = new A();
      
    }   }
```

# ：this（）

：this（），执行本类其他有参数构造方法

：base（）是指向父类用的构造



```
 class person
    {
        public int age;
        public string name;
        public double height;
        public double weight;

        public person (string name,int age)
        {
            this.age = age;
            this.name = name;
        }

        
        public person(string name, int age,double height,double weight):this (name ,age )
        {
           // this.age = age;
           // this.name = name;//上面有的话可  
           ：this（）省略其字段
            this.height = height;
            this.weight = weight;
          
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            person laowang = new person("laowang", 31);
            Console.WriteLine(laowang.name );
            person xaiomin = new person("yanmanyi",21,1.82,70.0);
          

           
        }
    }
```











# 访问修饰符

​	public公开的
​	private私有的（变量和方法的默认访问修饰符）
​	protected继承
​	internal 本程序集（**类**和结构体的默认访问修饰符）

	引用其他程序集，使用using关键字
	也可以直接通过dot语法，找到对应的命名空间.类名

# 命名空间

​	同一命名空间下的东西不能重名，可以直接调用
​	不同命名空间下的类可以重名，所以可以用命名空间来区分不同的代码

# this与base

​	this关键字指向自身实例或者自身构造函数
​	base关键字指向父类的实例或者父类的构造函数

# new

​	1.实例化一个对象
​	2.为子类的成员申请一个新的空间

	如果子类中有成员与父类中的成员重名，可以用new关键字为子类中这个成员
	申请一个新的空间，以便于计算机识别，如果不写，将默认启用new



# 方法隐藏（了解）

隐藏方法，就是父类里有的方法，子类里再写一个，**父类的那个被隐藏**，执行子类那个方法



```
using System;
class person1
{
    public void Xiaoming() { Console.WriteLine("person1 xiaoming"); }
}
class person2 : person1
{
    //隐藏方法，就是父类里有的方法，子类里再写一个，父类的那个被隐藏
    //加 new，在类里 创一个新的方法了，之前方法还在，向上转型回去父类就会使用
    public new void Xiaoming() { Console.WriteLine("person2 xiaoming"); }
}

class progran
{
    public static void Main(string[]args)
    {
        person2 per = new person2();
        per.Xiaoming();

    }
}
```





# 方法重写（重点）

**在子类里想重写父类里一样的方法，需要再父类的那个方法前加关键字virtual**或者abstract，因为这些方法函数是可以被重写

**在子类重写的方法前加override修饰词**

重写方法 前提条件就是上面的这句话

```
using System;
class person1
{
    public virtual  void Xiaoming() { Console.WriteLine("person1 xiaoming"); }
}
class person2 : person1
{
加了关键字重写了方法，所以不像隐藏一样，子类继承了父类方法后，这个一样名字的方法里的全部重写，向上转型回去后，因为重写了，所以父类里的那个方法是和之前不一样了，这个和隐藏不一样
    
    public override  void Xiaoming() { Console.WriteLine("person2 xiaoming"); }
}

class progran
{
    public static void Main(string[]args)
    {
        person2 per = new person2();
        per.Xiaoming();

    }
}
```

# abstract 抽象类



**抽象类关键字abstract**

```
abstract class A { 

public abstract void show();//抽象方法
};
```

**不能实例化对象**

**抽象类可以被其他类继承**

用途：用来约束子类的一种行为





**抽象方法**：**没有**实现部分（也就是没有大括号那部分）。其次被继承的子类需要实现抽象类里的**全部**抽象方法，通过override重写搞定到实现部分就不是抽象方法了，



# interface 接口

接口关键字  interface

作用：一系列约束规范



接口中的方法不是抽象类，虽然都没有实现部分。

接口中的方法**不能有访问权限修饰符**



接口**实现**注意：

接口实现的时候必须是public的权限

实现接口方法不能像抽象方法一样加override重写来实现实现的部分

其次接口命名以大写**I**开头

```
interface IUsb(){

void A();
}
//
：这里叫实现接口，如果一个类需要继承父类和实现接口，则
class mouse:Fulei,IUsb{}//如果多个接口往后直接逗号加的去就好

class Mouse:IUsb{
public void A(){};

}
```

多态进阶：

向上转型：实现类类型转向接口类类型









# 多态

​	为了解决同一种指令，可以有不同行为和结果，
​	在运行时，可以通过调用同一个方法，来实现派生类中不同表现。


	虚方法——抽象类——抽象函数——接口



## 里氏转化原则

目的和虚方法 重写作用一样，达到一个命令不一样行为，虚方法重写好用

​	1.子类对象当作父类对象去使用调用父类函数（因为子类拿到了父类的所有内容）

​	2.父类对象可以装载子类内容，甚至可以**强制转换**成子类对象去使用（因为父类盒子里装的就是子类的内容）



个人见解：为了统一管理不一样的怪物有不一样技能，父类对象可以点子类函数





​	

	is：判断这个变量是否能转换成对应类型，如果可以，返回t，否则返回f;
	as:尝试转换，如果能，返回转换过后的对象，如果不能，返回null
	
	is和as要搭配使用，则要可以避免空引用报错


​	
​	class 父类 { }
​	class 子类: 父类 { }
​	
​	class Program
​	    {
​	        static void Main(string[] args)
​	        {
​	    
​	        父类 父对象 =new 子类();父类对象装子类内容
​	        
​	        //需要先判断可否行转换
​	        if(父对象 is 子类)
​	        {
​	          子类 变量对象= （父对象 as 子类）
​	            //变量对象应该代表的是父对象，此时父对象可以Dot语法出子类的内容
​	        }


​	       
​	        }  
​	    
​	    }

​	

```
            //1.子类对象可以当做父类对象去使用
            //2.父类变量可以装载子类对象，甚至可以强转成子类类型


            Monster[] monsters = new Monster[10];

            Random r = new Random();


            for (int i = 0; i < 10; i++)
            {
                int rate = r.Next(1, 101);

                if (rate>=80)//20%
                {
                    monsters[i] = new Boss();
                }
                else
                {
                    monsters[i] = new Goblin();
                }
            }


            for (int i = 0; i < monsters.Length; i++)
            {
               
                if (monsters[i] is Boss)
                {                 

                    (monsters[i] as Boss).Attack();

                }
                else
                {
                    (monsters[i] as Goblin).Attack();
                   
                }
            }





//    书写一个Monster，他派生出Boss和Goblin两个类，Boss有技能
//和攻击，呼唤小怪，小怪有攻击，然后生成10个怪，随机生成Boss和goblin
//装到一个数组里，遍历数组调用它们的攻击，如果是boss就放技能

    class Monster
    {
        public string name;

        public Monster(string name) {

            this.name = name;
        }

    

    }


    class Goblin : Monster {
        //继承后,如果子类的构造函数参数和父类的构造不一致，要么base指向，要么父类里重载一个
        public Goblin(string name) : base(name) { }

        public void Attack() { }
    }

    class Boss : Monster {

        public Boss(string name) : base(name) { }

        public void Skill() { }


        public void Attack() { }
        

    }



```


​	
​	



## 虚方法

​	被virtual关键字修饰的方法，叫做虚方法
​	

	虚方法通常写你要继承的父类中，用virtual关键字去修饰子类要重写方法
	然后子类就可以通过override关键字去重写你的虚方法
	
	让我不同的子类对象对同一指令有不同的行为
	
	1.虚方法在调用，会根据你运行时，实际的对象和最后重写的方法，去决定运行哪一个
	
	2.如果你是非虚方法，是需要转成对应的对象，才能执行对应的方法


	3.子类只能重写同参数列表同返回类型同名的虚方法
	
	4.不要再子类中去声明一个和虚方法同名的新方法，虚方法会被new给隐藏掉
	
	5.虚方法必须是非静态的，因为要让子类去继承重写，如果是静态就无法唯一化
	
	6.虚方法不能私有化，必须要子类去继承，如果一定要让子类重写不了，可以用sealed去封闭
	
	sealed：1.可以密封一个 派生类 的虚方法的重写，导致新的派生类无法重写
		2.密封一个类，让这个类无法被派生

## 抽象类与抽象方法

抽象方法是没有实现代码的虚方法

被abstract关键字修饰的类叫做抽象类
​	

	被abstract关键修饰的方法叫做抽象方法
	
	1.抽象方法必须放在抽象类中
	2.抽象方法不可以实现代码，用空语句代替块
	3.抽象方法可以用override关键字去重写
	4.继承了抽象类的子类必须要实现抽象类中所有的抽象方法
	5.抽象类不能实例化


​	
​	如果你的父类需要实例化，且需要实现方法，用虚方法
​	如果你的父类不许要实例化，也不需要实现方法，用抽象类和抽象方法

## 接口

​	和类进行一个约定，完成某些指定的功能

	1.接口可以包含方法，属性，事件，所引器
	2.接口不提供所定义的成员的代码实现，只能由继承接口的类或者结构去实现
	3.接口的继承者必须实现接口的所有属性和方法
	4.一类可以继承多个接口，但当你的继承关系有类的时候，类要放在继承列表中的第一个
	5.接口可以继承接口
	6.接口不能有构造函数，不能有字段，不能重载运算符
	7.接口中的成员已经强制为public了


	声明：
	访问修饰符 interface 接口名{
		属性，
		方法，
		索引器
		事件
	}


	接口取名，前面必须要加大写的I


	接口的使用
	
	访问修饰符 class 类名:基类，接口，接口........{
	
		实现所有接口的成员
	}
	
	当无法抽象出一个类，但又有相同的功能的时候，用接口来，比如说直升机，超人，鸟，都可飞，但无法全部抽象出一个抽象类来实现多态，于是不同的就提取出一个接口


​	
​	再例如 麻雀， 鸵鸟，鹦鹉，直升机，天鹅
​	
​	飞，走，游泳
​	
​	会飞 和 会游泳  提取两个接口
​	走  是绝大部分都会的，所以可以搞抽象类


​	
​	


	接口的显示实现
	当我们的类继承了多个接口，有可能会有重名的成员，这个时候
	可以使用显示实现来区别不同接口的成员
	
	接口名.成员名{}




# 索引器：

​	索引器类似于属性，可以让类的成员可以被快速访问
​	使用一个或者多个参数可以索引到类中的成员，


	声明：
	访问修饰符 数据类型 this[ 数据类型 索引参数 ]
	{
		get{ return }//读
		set{ 字段=value}//写
		
	}
	
	使用：对象名[索引参数]

如何在函数中抛出异常

# 用throw关键

​	下标号 超出 范围的异常 实例化
​	new IndexOutOfRangeException();

	一旦抛出异常，程序就会终止在抛出异常的地方

```
namespace 索引器简单用法
{
    class Person {

        string name;
        string sex;
        string age;
        string hobby;

        public Person(string name, string sex, string age, string hobby) {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.hobby = hobby;
            
        }


        public string this[int index] {

            get{
                switch (index)
                {
                    case 0:
                        return name;
                    case 1:
                        return sex;
                    case 2:
                        return age;
                    case 3:
                        return hobby;
                    default:
                 //扔     下标号 超出 范围的异常
            //throw new IndexOutOfRangeException(); 
                        Console.WriteLine("下标号超出范围");
                        return "";
                }
            }
            set {

                switch (index)
                {
                    case 0:
                        name = value; break;
                    case 1:
                        sex = value; break;
                    case 2:
                        age = value; break;
                    case 3:
                        hobby = value; break;
                    default:
         //扔     下标号 超出 范围的异常
        //throw new IndexOutOfRangeException(); 
                        Console.WriteLine("下标号超出范围");
                        break;
                }
            }



        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("小明", "男", "17", "看电影");


            p[3] = "打篮球";
            Console.WriteLine(p[3]);
        }
    }
}

```



# 	重载运算符operator关键字

​	让我们自定义的数据类型可以通过运算符进行运算

	访问修饰符 static 返回类型 operator 运算符（参数）
	{   运算内容以及返回结果  } 



  

```
namespace 重载运算符
{
    struct Vector2 {

        public int x, y;
        public Vector2(int x, int y) {

            this.x = x;
            this.y = y;
        }

       public static Vector2 operator +(Vector2 a,Vector2 b)
        {

      
            return new Vector2(a.x + b.x, a.y + b.y);
        }


        public static bool operator ==(Vector2 a, Vector2 b)
        {

            return (a.x == b.x) && (a.y == b.y);
        }

//相等和不相等的重载方法是同时候出现
        public static bool operator !=(Vector2 a, Vector2 b) {

            return !(a == b);
        }

        public override string ToString()
        {
            return String.Format("({0},{1})", x, y);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector2 pointA = new Vector2(1, 1);

            Vector2 dir = new Vector2(2, 3);

            Vector2 poitnB = pointA + dir;
            Console.WriteLine(poitnB);

            Console.WriteLine(pointA==poitnB);
        }
    }
}

```





















# 数据结构

```
	描述数据之间的关系

	行为:添加数据，删除数据，插入数据，查找数据，修改数据


	追加数据：向这个结构的末尾添加一个数据
	删除数据：在这个结构中删除你指定的数据
	插入数据：向这个结构中某一个位置插入你指定的数据
	查找数据：可以查找并访问到该数据
	修改数据：可以对该结构指定的数据进行重新赋值

	线性，链式，树状，图形，散列
	
	链式：是非连续的内存空间，是每个数据分成三部分 头 数据 尾
	
	每个数据的尾部链接下一个数据的头部


	所以在内存不是连续的空间，而是一个一个的空间，通过头尾地址
	联系在一起
```

# 集合

```
Collection是C#写好的数据结构类库

	ArrayList,HashTable,Stack,Queue

	如果你要使用这些数据结构类的模板，要先引用System.Collection

	就可以通过类名去实例化它的对象

```

## ArrayList

```
动态的数组
是封装过后的数组，里面的元素容器为object类型
	这样ArrayList就适用于所有的数据类型
	因为object类型是所有类的父类，又因为里氏转化原则，父类可以
	装载子类，所以ArrayList可以装载所有数据类型
		

	
	属性：
		Count:记录我当前拥有多少个元素
		Capacity:记录我当前可以包含多少个元素

	方法：
		添加 .Add（object value）
		把当前这个对象添加到数组中

		删除 .Remove(object value)
		查询此元素，并移除第一个匹配的元素项
		
		.RemoveAt（int index）
		根据下标号移除该元素

		插入 .Insert（int index，Object value）
		把对应对象插入到对应的下标

		访问/修改：通过索引器下标号

		排序：.Sort();
		
		反转: .Reverse();

		检测是否包含： .Contains（object value）
		检测该集合是否包含该元素，如果包含返回true，不包含返回false

		查找索引：.IndexOf(object value)
		找到第一个匹配该元素的下标号并返回
		如果没找到，则返回-1
```

## HashTable

```
哈希表
	也是System.Collections集合下的数据结构类
	它储存的也是Object类型的对象
	但是它在内存中是散列排布的
	因为这个特性，非常适合存储大量的数据
	
	在HashTable中一个键只能对应一个值，一个值可以对应多个键
	多对一的关系

	HashTable存储的是<键，值>对
	
	HashTable table=new HashTable();

	
	属性：
	Count:HashTable包含的键值对的数目
	Keys：HashTable中键的集合；
	Values:HashTable中值的集合
	
	方法：
	增删查改
	
	Add（key,value）在哈希表中添加一对键值对
	Remove（key）删除键值
	因为一个值有可能对应多个键，这样就不能把整个键值对删除掉
	只有没有键指向这个值，就会被自动释放掉，所以只需要删除键
	值就OK了

	Contains(key)检测是否包含此键值对
	ContainsKey（key）检测是否包含这个键
	ContainsValue（value）检测是否包含这个值


	访问：索引器[键]
	
	遍历使用foreach去键/值的集合中把每个元素都取到
```

## 栈

```
	也是System.Collections下的数据结构类
	存储的依然是Object类型的对象


		
	Stack 名字=new Stack();
	
	Count:实际拥有的元素个数；	

	栈的释放顺序是先进后出（后进先出）

	压栈——Push(object 对象)把这个对象添加到栈的顶部
	弹栈——Pop()把栈顶的元素弹出来，会删除
	Peek()返回栈顶的元素，不删除
	

	在遍历弹栈的时候要注意，Pop方法会删除你的对象，导致Count属性
	发生改变，所以，应该用一个变量存储一下一开始的Count值
	根据这个变量，来弹栈，就可以把栈中所有的数据弹出去
```

## 队列

```
是System.Collections下的数据结构类，存储Object类型的对象
	
	Queue que=new Queue();

	队列的释放顺序是先进先出
	
	属性 Count:该结构包含的元素个数

	方法：
	EnQueue（Object value）进入队列的末尾处
	DeQueue（）返回并移除队列最前面的那个元素
	Peek()把队列中队首的元素返回，但不删除

```

# 泛型

```
因为我们在编程中想先不定义数据类型，只想先写逻辑，就可以使用
	Object类型，这样我的逻辑就适用于所有类型，但是，在运行中，Object
	类型的变量会需要转换到对应类型，浪费资源，所以出现泛型，来替代
	Object类型的方案。

	使用泛型，可以让我们延迟定义数据类型，来编写程序

	泛型是一种将逻辑应用到不同数据类型上的机制，可以通过类型替代符
	来暂时替代参数的数据类型，这样只需要在编译的时候，编译器会自动
	将该替代符编译成对应数据类型来处理

```







## 泛型方法

```
定义泛型方法
	访问修饰 返回类型 方法名<T,U>（T 参数 U 参数）{

	}
	我们可以在方法名后使用<类型替代符>来定义一个泛型方法

	方法定义好后，在调用泛型方法时，应该在<>括号内填上对应的类型

	
	使用范围：当你的方法适用于所有数据类型的时候，可以使用泛型来
	代替Object类型，以节省资源
```



**泛型在方法使用**

T在作用当前方法中，不能作用在其他方法中

**虽然不知道T是什么类型，但可以使用这个类型**

方法中的泛型在调用方法的时候确定

```
 class Program
    {
        //调用中需要写是什么类型
        static void Show<T>() { }
        
        //如果方法泛型在参数中使用了，在调用中可以不写类型，实参传的值就是什么T的类型
        static void Show<T>(T t) { }

        static void Main(string[] args)
        {
            Show<int>();
            Show(10);
        }

      
    }
```













## 泛型类

```
访问修饰符 class 类名<T>{
		T 成员；

	}

	类型替代符的作用：可以让我们先不定义数据类型，只管逻辑，在调用
	此方法或者此类对象时，才在<>括号里填上对应类型，这样我这段逻辑
	或者说这个类结构就可以适用于所有数据类型而且要比Object类型节省
	资源。
```

**泛型在类里的使用**

可以将类型在类、接口、方法中进行传递；

类似于——————传参，只不过传的是类

命名---大驼峰，一般用T表示

泛型不能继承，但泛型这个类可以

**虽然不知道T是什么类型，但可以使用这个类型**

```
 class person<T> {
        public T t;
    }
    class person2<T, M, D> {
        public T t;//不知道T、M、D是什么类型，等用的时候在给类型
        public M m;
        public D d;
    }
    class Program
    {TMD
        static void Main(string[] args)
        {
            //实例化具有泛型的类需要带上传的类型，所以说类似于————传参
            person<int> laowang = new person<int>() ;
            laowang.t = 3;

            person2<string, int, int> manyi = new person2<string, int, int>();
            manyi.t = "满意";
            manyi.m = 20;
            manyi.d = 520;

        }

      
    }
```









## 泛型集合

```
在System.Collections.Generic下的泛型数据结构类
	比System.Collections下Object类型的数据结构类要更安全，性能更好
```



### 泛型列表



```
L ist<数据类型> 列表名=new List<数据类型>(可填写初始长度)
	
	属性：
	Count:代表这个列表实际包含多少元素
	Capacity：代表这个列表可以包含多少个元素


	方法：
	Add:在列表末尾添加一个元素
	Remove:删除指定的元素
	RemoveAt:删除下标号指定的元素
	Contains:检测是否包含这个元素
	IndexOf:从头开始查找第一个匹配项的下标号，没找到返回-1
	LastIndexOf:从尾开始查找第一个匹配项的下标号，没找到返回-1
	Insert：在指定Index的位置，插入这个元素
	Reverse：反转当前列表的排列顺序
	Sort排序


	查/改：索引器[下标号]
```

### 字典

```
	在System.Collections.Generic下，
	对应HashTable,添加了泛型的特性，性能更高更安全
	在内存中是散列排布的，存储也是键值对

	Dictionary<键的数据类型，值的数据类型> 字典名=new Dictionary<键的数据类型，值的数据类型>（）
	
	Count:实际包含的元素个数
	Keys:键的集合
	Values：值的集合

	添加元素
	Add(key,value)
	可以直接通过索引器去添加
	字典名[key]=value;

	
	删除元素
	Remove(key)通过键去删除

	访问
	this[key]通过键值来访问元素
	this[key].对应方法
	this[key][第几个obj]

	遍历
	可以直接用foreach 取到每一对键值对KeyValuePair<Key类型,键类型> 对象
	通过这个键值对对象.出key属性和value属性
```

### 泛型  栈与队列

```
在System.Collections.Generic下的泛型集合
	对比Stack和Queue多了泛型的特性


	Stack<数据类型> 栈名=new Stack<数据类型>();
	
	压栈：栈名.Push（元素）
	弹栈：栈名.Pop（） 会返回栈顶的元素
	查看栈顶的元素：栈名.Peek（）；


	Queue<数据类型> 队列名=new Queue<数据类型>();
	进队：队列名.EnQueue（元素）在队尾添加元素
	出队：队列名.DeQueue（）把队首的元素弹出来
	查看队首的元素：队列名.Peek（）;

```



## IComparable<T> 接口

```
	可以实现Sort对复杂数据类型的排序

	让你的类实现ComparaTo（T other）方法

	会返回一个int值
	
	其含义  大于零：对象大于other参数；
		小于零：对象小于other参数；
		等于零：对象等于other参数；
```





# delegate委托

委托：就是一个方法的类型（int的那种类型的）

委托的类型,实例化委托对象需要用一个方法来实例化
这个方法的返回值类型和参数列表需要和委托保持一致



```
//声明一个TestDelegate类型的委托
    delegate void TestDelegate();
    class Program
    {
        static void Main(string[] args)
        {
          //委托的类型,实例化委托对象需要用一个方法来实例化
          //这个方法的返回值类型和参数列表需要和委托保持一致
           // TestDelegate a=new TestDelegate (Test);
            TestDelegate a=Test;//也可以这样简化写
            //a指向了一个方法
            a();
        }

        public static void Test() {

            Console.WriteLine("yan");
        }
    }
```

不想规规矩矩的写方法就用简化用匿名，以下：



# 委托的匿名方法

匿名方法

```
和委托搭配使用
	方便我们快速对委托进行传参
	不需要我们去定义一个新的函数
	直接用delegate关键字代替方法名,后面跟上参数列表与方法体

	delegate(参数列表){方法体}


```



```
//声明一个无返回值无参数的委托
    delegate void TestDelegate1();
    //声明一个有返回值有参数的委托
    delegate int TestDelegate2(int x,int y);
    class Program
    {
        static void Main(string[] args)
        {
            //匿名方法，直接用delegate来代替原本需要写的方法
            TestDelegate1 a = delegate ()
            { Console.WriteLine("hello");
            };
            TestDelegate2 b =  delegate (int x,int y) { return x+y; };
          
            a();
            Console.WriteLine(b(5));


        }
```





# Lambda    =>

lambda表达式

```
匿名方法的升级
	更加简写
	(参数列表)=>{ 方法体 }
	当你的方法体只有一条语句的时候，可以不写return，甚至可以没有花括号
	参数列表的参数甚至可以不写数据类型
	如果说方法体里一旦出现了return，一定要加上花括号；

```



**//Lambda代替方法匿名，结合以上的委托**

**=> Lambda运算符，读作 goes to**

用作在**参数**与**{}**之间

```
 
    //无返回值无参数的委托
    delegate void TestDelegate1();
    //有参数有返回值的委托
    delegate int TestDelegate2(int x,int y);
 
    class Program
    {
        static void Main(string[] args)
        {
            //Lambda代替方法匿名
            // => Lambda运算符，读作 goes to

            TestDelegate1 a = () => { };
            TestDelegate2 b = (int x,int y) => { return x + y; };

            //简化1：如果Lambda方法体中只有一个返回值，可以简化
            TestDelegate2 bb = (int x, int y) =>  x + y;

            //简化2：在Lambda方法体中的 形参类型 可不写
            TestDelegate2 bbb = ( x,  y) =>  x + y; 
            //简化3：如果Lambda参数只有一个，小括号可以省略
            TestDelegate2 bbbb = x => x+x; 



        }

      
    }
```



# 委托

```
是方法的载体（引用），可以承载（一个或者多个）方法
	是一种特殊数据类型，专门用来存储方法
	所有的委托都派生自System.Delegate类

	委托可以让我们把方法当做变量去使用
	解决了很多代码冗余的问题，也解决了方法回调的问题

	
	委托的定义
	访问修饰符 delegate 返回类型 委托类型名（参数列表）;
	
	委托的变量
	委托类型名 委托变量名；
	委托类型名 委托变量名 = new 委托类型(返回类型与参数列表一致方法)；
	在装载方法的时候，不用写小括号； 
	
	委托的赋值
	委托变量名 = 返回类型与参数列表一致方法

	委托的调用
	委托变量名(参数)；
	委托变量名.Invoke(参数)；
	
	回调：就是在其他方法里使用了委托变量而已
```

委托概念

```
委托的注册
	委托名+=方法名//就可以将多个方法注册进委托变量中

委托的注销
	委托名-=方法名//可以将方法从委托列表中移除

	委托变量一旦重新赋值，以前引用的方法全部丢失

	可以使用委托变量=null全部清空方法列表


委托的本质
	就是方法引用的列表，有先后顺序，一旦调用会把列表中所有的方法执行完
```

# 事件

```
委托变量如果公开出去，很不安全，外部可以随意调用
	所以取消public，封闭它，我们可以自己书写两个方法，供外部注册与注销，委托调用在
	子方法里调用，这样封装委托变量可以使它更安全，这个就叫做事件

	1.外部不能随便调用，只能注册和注销
	2.只能自己去调用自己的委托

	C#为了方便我们封装委托变量，推出一个特性event事件
	
	在委托变量前用event修饰这个变量，这个委托变量就变成了事件
	这样的话，这个变量，就算你公开出去也没关系了
	因为，外部只能对这个变量进行注册和注销，只能内部进行触发
```

# 观测者模式

```
模型——视图
	发布——订阅
	源——收听者

	一系列对象来监听另外一个对象的行为，被监听者一旦触发事件/发布消息，
	则被所有监听者收到，然后执行自己的行为
	
	就是使用委托/事件，让一系列对象把他们的行为来注册到我的委托中去，
	什么时候执行这个委托，由我自身决定，外部不能干涉
```

# 委托与事件

委托是一种可以承载方法的复杂数据类型
需要我们自定义

delegate 返回类型 委托类型名（参数列表）


委托类型名 委托变量名=new 委托类型名(方法名)


调用： 委托变量名（）；   委托变量名.Invoke（）；

注册与注销
委托变量名+=返回类型与参数列表一致的方法名
委托变量名-=返回类型与参数列表一致的方法名

如果注册了多种方法在委托变量中则先注册的先执行



为了委托变量的安全性，我们应该取消委托变量的public
使用两个方法作为接口公开给外部使用

编写注册与注销方法，通过委托类型的参数来传参

这样，我们就可以管这个委托变量叫做事件

C#为了方便我们快速封装委托，就出现了event关键字

如果在委托变量前用event关键字修饰，则自动把这个委托变量，变成了事件

这样我这个委托变量就算公开出去，外部也只能进行注册与注销，只能自身调用这个事件



匿名方法

通常和委托变量搭配使用
方便我们快速对委托变量进行传参
delegate(参数列表){ 方法体 }



lambda表达式

（参数列表）=>{ 方法体}
当你的方法体只有一条语句时，可以不写return，甚至连花括号也可以省略
参数列表里也可以不写数据类型
当方法体里一旦出现了return，必须要加上花括号



观察者模式
一群对象在观察另外一个对象的行为，当这个对象的行为达成一定条件，则触发了一群对象的反应
要做到以上功能，要搭配事件使用
把一群对象的反应行为注册到被观察的对象的事件中去





# 泛型委托

自定义泛型委托
delegate T 委托名<T>(T 参数);

C#提供好了两个泛型委托的模板供我们使用
这两个模板基本上就可以适用于所有的委托
所以其实是不需要我们自定义

1.不带返回类型的泛型委托——Acition<类型1，类型2.....类型n>参数列表时对应的参数类型

2.带返回类型的泛型委托——Func<类型1，类型2.....类型n>
参数列表的末尾的类型是作为返回类型使用      



# 先锋的集合具体案例

## ArrayList集合

**集合与数组**都是一个容器，是用来存储兼容的数据类型的容器；

不同点：

1：数组是定长的容器，而集合是变长的容器

2：集合提供了很多快捷的方法在操作元素

3：**集合长度是Count，**数组长度是length

ArrayList一个类似于数组的一个容器

**ArrayList里面存的元素是object类型的**

需要引用//using System.Collections;





增删改、查看

```
 class Program
    {
 
        static void Main(string[] args)
        {
            
            ArrayList list = new ArrayList();

            //增：
            Add(list);//解释：为什么可以直接用list        
      //因为形参里的list指向的地址和上面的list指向的地址都是new ArrayList
              //删除
            Remove(list );
            //改
            Set(list);
           
        }
        
        

        //增，可以添加任意类型的
        public static void Add(ArrayList list) {
            
            list.Add(1);
            list.Add("yanmanyi");
            list.Add(3.14);
            //添加一个元素，只不过这个元素是数组
            list.Add(new int[] { 1,2,3,4,5,6,7});//此时list集合长度是4

            //批量添加元素：将一个集合中的元素添加到另外一个集合中
            list.AddRange(new int[] { 1,2,3,4});//此时list集合长度是8
            
              //插入也是增操作，插入的话原来的往后排队
            list.Insert(0,"yan");
              //批量插入
            list.InsertRange(0, new int[] { 1,2,3,4,5});

            Console.WriteLine(list .Count );//集合长度是Count，数组长度是length
        }
        
        
        
        
        
        
        //删
        public static void Remove(ArrayList list) {

            //删除指定第一个元素（有重复的话删除第一个）
            list.Remove(1);
            //List<>集合的删除比ArrayList集合多了RemoveAll（删除指定全部元素）
            //删除指定下标的元素
            list.RemoveAt(0);

            //给定一个下标和长度，确定范围，删除范围内元素
            list.RemoveRange(2,2);
            //清空
            list.Clear();
        }
        
        
        
        
        
        
         //修改
        public static void Set(ArrayList list)
        {
            //通过下标修改
            list[1] = 9;

            //批量修改连续元素，提供一个起点索引
            list.SetRange(0,new string[] {"a","b","c" });

        }

    }
```

遍历

```
 public static void Search(ArrayList list ) {

            //通过for遍历下标
            for (int i = 0; i < list.Count; i++) {

                Console.WriteLine(list[i]);
            }
            
            //通过foreach   因为list存的都是object类型对象  也可以用var
            //其次foreach只能用来打印遍历，不能修改操作，要修改用for去修改
            foreach (Object obj in list ) {

                Console.WriteLine(obj + ",");
            }

        }
```

**var**：可以赋予局部变量推断“类型”var 而不是显式类型。

```
我们举个例子。原来我们定义变量，是要这样：
int a = 1;
string b = "2";也就是说,必须先明确地指定变量是什么数据类型，才能给它赋值。

而 var 是一个弱类型，用：
var a = 1;
var b = "2";编译器会根据你给 a 的值 1，来推断 a 是一个整数类型；同理，推断出 b 是一个字符串类型。有点类似 object，但是效率比 object 要高。

```



查询元素下标

```
int index = list.IndexOf(3);//查询一个元素第一次出现的下标
 int index1 = list.LastIndexOf(3);//查询一个元素最后一次出现的下标
int index2 = list.BinarySearch(3);//使用二分查找查询某个元素的下标，二分查找的前提是有序排列
```



升、倒，是否有

```
 list.Sort();//集合排序，默认是升序
  list.Reverse();//集合倒序
 bool b= list.Contains(1);//判断集合中是否包含某个元素,有bool返回值
```









自定义排序

一个person类  字段 int age;



ArrayList集合，添加11个person类，

将集合中的元素（也就是11个person类）按照age进行sort()升序排序

```
using System;
using System.Collections;


//集合排序 //集合中可以存储任意类型的数据，但如果是自定义类型，如集合这里的是person对象，如何使用比较大小？
//sort()会将集合中的元素按照一定规则来进行排序，如果元素不是int类型这种，而是自定义的话
//通过IComparable 或者IComparable<T>接口来实现，谁去实现？
//让集合中需要排序的元素对应的类（这里是person）去实现这个接口
class Person : IComparable, IComparable<Person> //使用第二个接口带有泛型<>的简单，无需判断集合里是否同类种类<person>直接指定了person类
{

    int age;
    public Person(int _age)
    {
        this.age = _age;
    }

    //ToString（）返回的就是对象的字符串表示形式
    public override string ToString()
    {
        return age + "";
    }

    //接口实现部分,这个方法就是Icomparable接口中自定义排序规则的方法
    //前提：比较大小的两个对象 this和obj;如果用了第二个接口带有泛型，那么指定this就要和T类型的比较，就不用像第一种的那样麻烦
    //返回值：==0  this==obj
    //        >0    this>obj
    //        <0    th<obj
    public int CompareTo(object obj)
    {
        //this.age可以拿到，但obj是Object类型的，没有age，所以需要向下转型
        if (obj is Person)
        {
            //判断obj是不是person类型，如果集合存储的是不同类型的呢？就毫无比较意义
            //使用<T>泛型更简单，无需判断是不是同种集合对象

            //obj向下转型person类型，因为集合中存的是11个person类型的对象，这些对象的类型叫object，故：
            Person otherperson = obj as Person;
            //返回值：
            return this.age - otherperson.age;
        }
        return 0;

    }
    public int CompareTo(Person obj)//因为泛型<>，此时obj就是person类了
    {
        return this.age - obj.age;
    }

}
class pragram
{
    public static void Main(string[] args)
    {
        //实例化一个ArrayList 对象
        ArrayList list = new ArrayList();

        //添加 11个person类对象

        list.Add(new Person(1));
        list.Add(new Person (3));
        list.Add(new Person(2));
        list.Add(new Person(3));
        list.Add(new Person(7));
        list.Add(new Person(6));
        list.Add(new Person(8));
        list.Add(new Person(0));
        list.Add(new Person(5));
        list.Add(new Person(2));
        list.Add(new Person(0));

        
        list.Sort();



        foreach (Object obj in list ) { Console.WriteLine(obj); }//object也可以是person类
    }
}

```





## List<>集合

和ArrayList的区别**就是只能存储指定类型的元素**

要不然乱七八糟的类型放进来，用的时候需要判断是不是同类型，由上题可知

引用命名空间using System.Collections.Generic;

```
 List<string> list = new List<string>();
```

List<>集合的删除比ArrayList集合多了的**RemoveAll**(委托)，其他增删改查方法都一样使用，其次定义里还有很多方法

removeAll：删除指定的全部元素

```
List<string> list = new List<string>();
        list.AddRange(new string[] { "yan", "yan", "yan","man","yi"});
      
        list.RemoveAll( name =>name=="yan");
        
          //RemoveAll(参数)这里需要用委托，但直接用Lambda委托的=>,最简单形参(string name)=>{name=="yan"}
```



**Exists (委托方法) Find(委托) 判断集合中是否存在满足指定条件的元素（更全面）**

```
List<int> list = new List<int>();

        list.Add(1);//如果list<int>集合里有指定元素，返回值是true
        bool result = list.Exists(num => num == 1);
        Console.WriteLine(result);
```

**exists,find需要用委托，所以用lambda简便**

```
   //实例化一个集合
        List<int> list = new List<int>();
        //给集合添加元素
        list.AddRange(new int[] {2,1,5,3,8,4 });
        //集合里是否含有奇数
        bool result = list.Exists(num => num % 2 != 0);
        Console.WriteLine(result);

        //查找集合中第一个奇数 find(委托)
        int n = list.Find(num => num % 2 != 0);
        Console.WriteLine(n);
        
         //查找集合中全部的奇数
       List<int>results= list.FindAll(num=>num%2!=0);//返回的也是一个集合哦
       
         //查找集合第一个奇数的下标
        int index = list.FindIndex(num => num % 2 != 0);
        
           //移除所有奇数
        list.RemoveAll(num => num % 2 != 0);
        foreach (int a in list ) {

            Console.Write(a+"\t");
        }
        
     
```

**Contains   判断集合中是否包含指定元素（更简单表达）**

```
 List<int> list = new List<int>();

        list.Add(1);
        bool result = list.Contains( 1);
        Console.WriteLine(result);
```

随机数找查重的判断返回值bool





















## Stack（栈）集合

## Queue（队列）集合



**区别：**

**栈先进后出   队列先进先出**



Stack  3个方法  Push()   Peek()  Pop()  添加、获取、移除

```
 static void Main(string[] args)
    {
        //实例化一个栈集合
        Stack sk = new Stack();

        //将一个元素压栈  //先进后出，所以第一个元素是A
        sk.Push("yan");
        sk.Push(520);
        sk.Push("A");
        
        //Peek()获取栈顶的元素
        Object _obj = sk.Peek();

        //Pop()栈顶的元素出栈,返回刚刚出栈的元素值
        Object ele = sk.Pop();
        
         

        foreach (Object obj in sk)//有不一样类型的话遍历的时候是object类型，不加int 类型的话可以写string obj
        {
            Console.WriteLine(obj + "\t");//先进后出，所以第一个元素是A
        }
    }
```





Queue 3个方法 Enqueue()  Peek()  Dequeue()    添加、获取、移除

```
static void Main(string[] args)
    {
        //实例化一个Queue队列集合
        Queue q = new Queue();

        //将一个元素放到队列中
        q.Enqueue("yan");
        q.Enqueue("A");

        //获取排在队列首位的元素
        Object   ele=  q.Peek();

        //Dequeue()将队列首个元素移除，返回刚刚出的元素值
        Object _ele = q.Dequeue();


        foreach (string st in q)//有不一样类型的话遍历的时候是object类型
        {
            Console.WriteLine(st + "\t");
        }
    }
```

 









##  Hashtable集合



 Hashtable存储的元素是一个 **键值对**(key-value-pair)

//Hashtable中**存储的元素类型是DictionaryEntry**

键值对：是由两个值组成的，一个是**键（key）**，一个是**值（value）**

特点：（需要同时出现，且他们一 一对应，一个键对应一个值，不能出现相同的键，值可以相同）

//Hashtable中元素的顺序是根据key 的Hash编码来排序的；不是倒叙也不是正序

//索引器 通过键来修改值，因为值可重复、乱序下标不可用





```
class program
{
    static void Main(string[] args)
    {

        Hashtable table = new Hashtable();

        //增
        AddHashtable(table);
       //删
        RemoveHashtable(table);
        //改
        GaiHashtable(table);
        //查
        SearchHashtable(table);


    }

    //增
    public static void AddHashtable(Hashtable table)
    {
        //添加键值对
        table.Add("name", "yanmanyi");
        table.Add("xiaoname", "yanliangtao");
        table.Add("score",59);

    }
    //删
    public static void RemoveHashtable(Hashtable table)
    {
        //通过key来删除一个键值对
        table.Remove("xiaoname");
    
    }
    //改
    public static void GaiHashtable(Hashtable table)
    {
        //通过索引器来改，通过key来修改value，因为值可重复、乱序下标不可用
        table["score"] = 60;
        //table里并没有height这个键，但通过索引器修改操作也是一种添加行为
        table["height"] = 180;

    }

    //查
    public static void SearchHashtable(Hashtable table)
    {
        //Hashtable中存储的元素类型是DictionaryEntry
        //属于拿到一个元素然后点出key
        foreach (DictionaryEntry obj in table) 
        {
            //获取键值对这个元素(只会获取到是DictionaryEntry的类型)//DictionaryEntry _obj = obj;


            //获取键值对里的键
            Object key = obj.Key;

            //获取键值对里的值
            Object value = obj.Value;

            Console.WriteLine($"{key}={value}");//Hashtable中元素的顺序是根据key 的Hash编码来排序的；不是倒叙也不是正序
        }

        //例外一种遍历：获取Hashtable所有的key
      ICollection  keys = table.Keys;//不知道获取的keys是什么类型，属于用Object,字典集合可以，因为有泛型
        //或者拿到全部key然后再
        foreach (Object key in keys) {
           Object value = table[key];
            Console.WriteLine($"{key}={value}");
        }

    }

    

    
}
```











## Dictionary<>集合

和Hashtable差不多，**但Dictionary<>有泛型**

**增删改**注意类型就基本上和Hashtable集合一样，但**查**不一样不一样



**Dictionary集合里面存储的元素类型是KeyValuePair<key,value>**





```
class Program
{
    public static void Main(string[] args)
    {
        //Dictionary<> 类似与Hashtable，存储的元素也是键值对
        //Dictionary<>需要指定key和value的类型
        Dictionary<string, string> dic = new Dictionary<string ,string >();

        //增
        AddDictionary(dic);

        //删
        RemoveDictionary(dic);

        //改
        GaiDictionary(dic);

        //查
        SearchDictionary(dic);
    }

    //增
    public static void AddDictionary(Dictionary<string ,string > dic) 
    {
        dic.Add("name","严满意");
        dic.Add("电话号","123456");
        dic.Add("key","value");
    
    }

    //删
    public static void RemoveDictionary(Dictionary<string ,string > dic) 
    {
        //和Hashtable一样通过删除key（键）
        dic.Remove("电话号");

    }


    //改
    public static void GaiDictionary(Dictionary<string ,string > dic) 
    {
        //一样和Hashtable的方法一样，通过索引器获取key然后改value的值
        dic["name"] = "严满意大帅哥";
    }

    //查
    public static void SearchDictionary(Dictionary<string ,string > dic)
    {
        //属于拿到一个元素然后点出key
        foreach (KeyValuePair<string ,string > search in dic) 
        {
            string key = search.Key;
            string value = search.Value;
            Console.WriteLine($"{key}={value}" );
        }

        //或者拿到全部key然后再
        ICollection<string> keys = dic.Keys;
        foreach (string  key in keys) 
        {
            string  value = dic[key];
            Console.WriteLine($"{key}={value}");
        }
    
    }
}
```































































































































































































































































































































































































































































































































































































































































































