# 快捷键

**Ctrl+K+F	即可排序标准**

**Ctrl+K+C 	即可快速注释**

**Ctrl + K + U 	即可取消注释**

**Ctrl+Shift 或者  V	+鼠标	可移动物体到位**

**Ctrl+Shift+F 	摄像机位置调整到scene视角**

**Ctrl+Shift +c	调试面板**

**Ctrl+K+S	代码#region的折叠和其他**

**Alt	按住的同时可选操作范围**

**Alt+上下	可移动代码顺序**

**Alt：鼠标在Scene面板就变成一个小眼睛，这时候单击鼠标左键可以实现巡游角度查看场景；**

**Ctrl+D在Hierachy面板复制出一个一样的Object**

**Alt+鼠标左击，可在Hierarchy层级面板里展开全部或者关闭全部**

**Ctrl+Shift+P		暂停运行的时候**



 **Ctrl + M + O: 折叠所有方法**

**Ctrl + M + M: 折叠或者展开当前方法**

**Ctrl + M + L: 展开所有方法** 





TileMap的画板 TilePalette里快捷操作：按Shift是删除所选区域，Ctrl是赋值所选区域



# 小知识

## 注释

 //TODO: 注释未做的行为
 //FIXME:注释待修改的行为

**在视图-任务列表即可查看到**



## vs编辑器初始模板

修改地点：

```
Hub>unity>版本>Editor>Data>Resources>ScriptTemplates>(继承MonoBehaviour的那个文本文档)
```













## 值得注意的问题

start只执行一次，后面都不执行，每次开启和关闭执行的是OnEnable和OnDisable

如果函数有错，可能会影响后面的内容报空一类

## 模拟设备的package manager

**Device Simulate**

# []

## 序列化

```
Tips 1 ：[SerializeField]

通常我们会在代码里用 Public 生成可见的变量；用 Private 生成不可见的变量。如果我想在测试阶段能够观察到 Private 的变量是否得到了我想要的值怎么办呢？可以参考下面的图片，在 Private 前面或者上面添加一个代码：[SerializeField]。



Tips 2 ：[Speace]

好像上面的代码部分的图片那样，无论我们写代码时怎样用空行来分割整理代码，在 Unity 的编辑窗口里他们都是挨在一起...
所以怎样让 Inspector 窗口像我们 VS 写的代码那样规整呢？就是在你需要“隔行”的的地方写上一个代码：[Space]。


Tips 3 : [Header]

虽然用 [Space] 可以空出一定的空间用来分类。但是更直观的方法就是在参数前面加上注视。好像在代码中用 // 来添加代码注释一样，我们也可以在 Inspector 窗口里用文字来分割分类我们的各项参数。方法是在代码前加上：[Header("XXX")] 


Tips 4 : [Range]

每次我们创建一个数值类变量（int,float) 时，我们都会纠结要给他多少才好。或者我们是多人合作编辑的团队，我负责设计代码，有其他人来测试决定实际效果时。我们会为了保护游戏性设置一个可以使用的参数范围，这时我们只需要在设置变量前添加一个范围的代码就可以，方法如下：[Range(最小值 , 最大值)]。


Tips 5 : [HideInInspector]

类似刚才提到的 [Range] 一样。很多时候我们希望保护好我们已经测试好的参数，并不希望有任何人改动导致其他的游戏问题。所以我们可以将我们调整好的参数保护好，方法就是——吧他们藏起来！方法如下：[HideInInspector]。

```



## 添加组件

脚本自动给游戏对象添加对应的组件

```
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

与类同级
```

## 创建属性

脚本命名_SO结尾，例如：Text_SO脚本（好习惯）

继承ScriptableObject类，不继承Monobehaviour类

```
与类同级
[CreateAssetMenu (fileName="Preset",menuName ="Character Preset")]

在Project面板中可创建属性
```

## 显示出集合或者类的属性

[System.Serializable]

具体情况如下

```c#

[CreateAssetMenu (fileName ="Preset",menuName ="Character Preset")]
public class Preset_SO :ScriptableObject 
{

    public List<PresetSetting> settings = new List<PresetSetting>();

}

//序列化出来，要不然在那个Preset属性面板中看不到
[System.Serializable]
public class PresetSetting 
{
public int test;
}

```



文字输入框显示（有个输入范围在Inspector面板中）

```
 //描述
    [TextArea]//有个输入范围在Inspector面板中
    public string description = "";
```



# 生命周期

## Awake

 1、整个生命周期最先被调用的方法
2、当对象被加载到场景中时，自动调用该方法
3、这个方法会被执行一次 

## OnEnable

 1、当脚本被激活时调用该方法
2、该方法会被调用多次，如果被OnDisable设置为不可激活，再次激活还会调用该方法。 

**唤醒脚本或脚本挂载的对象的时候回自动调用**

```
awake，onenable，start 在一个周期里，三个都走一遍才算一个脚本唤醒

个人理解：如果脚本写了OnEnable函数，这是一个唤醒函数，如果一开始就没隐藏脚本或者脚本对象，直接运行开始，那么它会执行完了当前这个类的awake，onenable，start 后，才考虑其他脚本，所以，如果这里用了单例去调用其他方法是不可以的，单例会空引用哦
```

## Start

 1、初始化操作
2、会被调用一次，即使OnEnable会被执行多次，Start 会自我检测，如果执行了一次了不会再执行。 

##  **FixedUpdate** 

 1、以帧为单位进行场景的刷新，以固定的恶时间间隔来进行刷新
2、主要作用：与物理相关的更新操作（Rigidbody） 

##  **Update**

1、每一帧与每一帧得执行时间可能是不一致的，执行速率与硬件设备和被渲染得物体有关系，有时快有时慢。
2、主要作用：场景中数据的更新和数据的逻辑处理操作，transform 的移动和旋转一般也在这里面执行 

##  **LateUpdate**

当一帧执行结束，在准备下一帧执行之前，会调用该方法。

一般合适摄像机跟随

## **OnDisable**

1、将脚本设置为不可激活状态或不可用状态
2、该方法调用一次 

## **OnDestroy**

1、脚本被销毁时调用该方法

OnDisable会先调用把脚本设置为不可用后，才能进行销毁 OnDestroy

## 总结

```
awake 跟 OnDestroy 是成对出现的。
OnEnable跟OnDisable是成对出现的。

awake—》OnEnable----》OnDisable—》OnDestroy
```







# 小功能

## 计时器

 **写一计时器工具，从整点开始计时，格式为：00：00：00**

```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    int hour;//时钟
    int minute;//分钟
    int second;//秒钟
    int millisecond;//毫秒
    float currentTime;//当前时间

    bool isStart = false;
    public Text timeNumber;


    private void Update()
    {

        if (isStart)
        {
            currentTime += Time.deltaTime;

            hour = (int)currentTime / 3600;
            minute = ((int)currentTime - hour * 3600) / 60;
            second = (int)currentTime - hour * 3600 - minute * 60;
            millisecond = (int)((currentTime - (int)currentTime) * 1000);
        }
        else
        {
            hour = (int)currentTime / 3600;
            minute = ((int)currentTime - hour * 3600) / 60;
            second = (int)currentTime - hour * 3600 - minute * 60;
            millisecond = (int)((currentTime - (int)currentTime) * 1000);
        }

        timeNumber.text = 
        string.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}", hour, minute, second, millisecond);
        
        都可以实现在一位数的时候显示两个数，01
       // timeNumber.text = $"{hour:D2}";
       //Format另外一种写法ToString("00");
       //或者toString（"F1"）
    }



    /// <summary>
    /// 开始btn事件
    /// </summary>
    public void IsStart()
    {
        isStart = true;

    }
    /// <summary>
    /// 暂停btn事件
    /// </summary>
    public void IsPause()
    {
        isStart = false;

    }
    /// <summary>
    /// 重新btn事件
    /// </summary>
    public void Again()
    {
        currentTime = 0f;
        isStart = false;

    }



}

```



**延迟重复调用函数可以达到计时器功能**



## 摄像机跟随

```
 public Transform target;
 public float height, forward_, lerp;

 private Vector3 offSet;//偏移量


    private void LateUpdate()
    {
        offSet = -target.forward * forward_ + Vector3.up * height;


        transform.position = Vector3.Lerp(transform.position, target.position + offSet, lerp);

        transform.LookAt(target);
        //transform.forward =-offSet;效果等同于看齐

    }
```





## 类扩展方法



给transform扩展上递归查找子物体这个方法

```


//扩展方法的工具类(形参上加上this Transform transform),代表在transform上扩展函数对象
public static  class ExtensionMethod
{
    //递归查找子物体,在transform上扩展一个方法，可以直接在transform上直接调用
    public static Transform FindChild_DG(this Transform transform, string childName,Transform Parent) {


        if (childName == Parent.name) return Parent;
        if (Parent.childCount == 0) return null;


        Transform obj = null;
        for (int i = 0; i < Parent.childCount; i++)
        {
            obj = transform. FindChild_DG(childName,Parent.GetChild(i));
            if (obj) break;
        }

        return obj;
        
       
    }
}
```

```
1.扩展Transform类
2.编写删除所有字节点对象的方法
获取transform所有的子元素数childCount

通过for循环配合GetChild找到所有子元素
删除子元素Destroy(元素的gameObject)
3.调用



public static class ExtensionMethod {

    public static void DestroyChildAll(this Transform t) {

        for (int i = 0; i < t.childCount; i++)
        {
            Transform.Destroy(t.GetChild(i).gameObject);
                
        }
    }

}
```



## 划线案例

```
 public LineRenderer lineRenderer;//别挂在自己身上，自己克隆自己会导致无线叠加
    private int positionCount;

    private Vector3 position;
    private List<Vector3> listPositions = new List<Vector3>();

    private void Start()
    {
        positionCount = 0;
        lineRenderer.positionCount = positionCount;
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
        //屏幕坐标系转世界坐标
            position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
            if (!listPositions.Contains(position))
            {
                positionCount++;

                lineRenderer.positionCount = positionCount;
                lineRenderer.SetPosition(positionCount - 1, position);

                listPositions.Add(position);
            }

        }

        //克隆部分
        if (Input.GetMouseButtonUp(0))
        {
            Instantiate(lineRenderer.gameObject, transform);
            positionCount = 0;
        }




    }
```



## 打字机模式01

把string利用ToCharArray()拆分为字符形式，foreach遍历一次添加到文本组件上

```
    private Text txtFile;
    public string textsWord;
    public float WaiteTime;

    void Start()
    {
        
        txtFile = GetComponent<Text>();

        StartCoroutine("StartTyping");

    }

    //把string利用ToCharArray()拆分为字符形式
    IEnumerator StartTyping()
    {
        foreach (var textChar in textsWord.ToCharArray())
        {
            txtFile.text += textChar;
            yield return new WaitForSeconds(WaiteTime);
        }

     //   yield return new WaitForSeconds(5);
     
        yield break;

    }

```

## 打字机模式02



 **所用知识点：string中的Substring–两个参数，第一个参数为初始下标，第二个为终止下标，从某个字符串中剪切出冲初始下标到终止下标中间的字符，重新组成一个字符串** 

```
    [Header("打字间隔")] public float typeTimer = 0.2f;
    [Header("打字的内容")] public string textWord;
    private Text txtFile;
    private bool isStartTyping = true;//是否开始打字
    private float timer;
    private int currentIndex = 0;

    private void Start()
    {
        txtFile = GetComponent<Text>();
        //返回两个或多个值中最大的值
        typeTimer = Mathf.Max(0.02f, typeTimer);

    }

    private void Update()
    {
        OnStartTyping();
    }

    private void OnStartTyping()
    {

        if (isStartTyping)
        {
            timer += Time.deltaTime;
            if (timer >= typeTimer)
            {
                timer = 0;
                currentIndex++;
                txtFile.text = textWord.Substring(0, currentIndex);
                if (currentIndex >= textWord.Length)
                {
                    OnFinshTyping();
                }
            }
        }
    }

    private void OnFinshTyping()
    {
       isStartTyping = false;
        timer = 0;
        currentIndex = 0;
        txtFile.text = textWord;
    }
```

## FSM切换状态模板

EnemyBaseState 抽象类

```
public abstract  class EnemyBaseState 
{
    public abstract void EnterState(EnemyController enemy);
    public abstract void OnUpdate(EnemyController enemy);
}
```

不同状态要做的事情

```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : EnemyBaseState
{
    public override void EnterState(EnemyController enemy)
    {
       
    }

    public override void OnUpdate(EnemyController enemy)
    {
        
    }
}
```

EnemyController控制

```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    EnemyBaseState currentState;
    public PatrolState patrolState = new PatrolState();
    /// <summary>
    /// 状态切换
    /// </summary>
    public void TransitionToState(EnemyBaseState state) 
    {
        currentState = state;
        currentState.EnterState(this);//相当于Start函数
    }

   
    private void Update()
    {
        currentState.OnUpdate(this);
    }


}

```

## Fade

```
    public IEnumerator FadeOut(float time)
    {

        while (canvasGroup.alpha！=1)
        {
            canvasGroup.alpha += Time.deltaTime / time;
            yield return null;
        }


    }

    public IEnumerator FadeIn(float time)
    {

        while (canvasGroup.alpha != 0)
        {
            canvasGroup.alpha -= Time.deltaTime / time;
            yield return null;
        }


    }

```



# 单例



**个人理解的单例：**一个类调用另外一个类的函数需要先获取对象，然后对象挂载的这个另外所需类，才能  .dot语法引用出函数。也可以用静态的特点**静态的成员是属于类的，访问的时候需要用来类来访问**，改成静态的函数就可以直接点，但静态是在栈中开辟空间，耗内存，**于是就有了单例，在栈里声明个变量名,具体实例化对象是在堆中**



## 正常单例

```
private static 当前类 instance;
public static 当前类 Instance { get { return instance; } }//写个属性比较好，也可不写
  private void Awake()
   {
       if (instance)
       {
      Destroy(gameObject);       //切换场景会产生新的同一个脚本实例
      }

      instance = this;//this指向自身实例
   } 
```





## 泛型单例

其他类继承此工具类后，即可有了正常的单例调用

SingLeton 翻译：单例模式

```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//泛型类单例
public class SingLeton<T> : MonoBehaviour where T:SingLeton<T>
{


    private static T instance;

    public static T Instance { get { return instance; } }


    //因为Awake可能还需要被添加使用，使用需要被重写的
    protected virtual void Awake() 
    {
        if (instance != null) Destroy(gameObject);
        else instance = (T)this;
    
    }


   //好的属性和方法 

    // 判断是否生成单例
    public static bool IsInitialized {

        get { return instance != null; }
    }


    //销毁的时候清空这个单例对象变量
    protected virtual void OnDestroy() {

        if (instance==this )
        {
            instance = null;
        }
    
    }

}
```





# 类和API

## Input常用

 

Input.**GetAxis**("Horizontal")

Input.**GetAxisRaw**("Vertical")

GetAxis 或者GetAxisRaw是获取InputManager封装好了的按钮名称，里面有按相对应的键位就会有数值改变        

**有Raw**的就是-1	0	1整值变化 **没有raw**就是-1到1范围变化

------

 Input.**GetKeyDown**(KeyCode.Space)和Input.**GetButtonDown**("Jump") 一样的 效果

GetKeyDown是获取哪个键位是否按下

GetButtonDown是获取InputManager封装好的按钮名称，里面有相对应的键位

------

Input.**GetMouseButtonDown**(0)

GetMouseButtonDown 是获取鼠标是否按下 ，0左1右



## LayerMask类



 **1 << 6** 打开第6的层。 

等价于**1 << LayerMask.NameToLayer(“Ground”)**

也等价于 **LayerMask.GetMask((“Ground”)**



 ~(1 << 10) 打开除了第10之外的层。 

 ~(1 << 0) 打开所有的层。 

 (1 << 10) | (1 << 8) 打开第10和第8的层。

等价于**LayerMask.GetMask((“Ground”, “Wall”)**

```
是否触碰到对应的层级

举例：Ground层级是6


coll.IsTouchingLayers(1<<6）
coll.IsTouchingLayers(1 << LayerMask.NameToLayer(“Ground”)）
coll.IsTouchingLayers(LayerMask.GetMask("Ground")）
```







## Animator

直接 播放  animator.Play("ani_name"); 

暂停 animator.speed = 0; 

继续播放 animator.speed = 1; 

normalizedTime: 范围0 ~ 1, 0是动作开始，1是动作结束  
anim.GetCurrentAnimatorStateInfo(0). normalizedTime    

判断是否在播放此动画：
**anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"）**

**这是用来判断动画播放结束的代码,代替Event帧事件**

```
AnimatorStateInfo stateinfo = animator.GetCurrentAnimatorStateInfo(0);

if(stateinfo.IsName("attack")
&&
(stateinfo.normalizedTime > 1.0f)){}
```



**anim.GetCurrentAnimatorClipInfo(0)[0].clip.length**

**这是动画播放的时间长度，一个float的值**

```
anim.GetCurrentAnimatorClipInfo(0)[0].clip.length
//案例是海盗炸弹里那个敌人发现player的时候出现的感叹号，用携程来开启，在触碰的一瞬间，

alarmSign.SetActive(true);
yield return new WaitForSeconds(alarmSign.GetComponent<Animator>().GetCurrentAnimatorClipInfo(0)[0].clip.length);

alarmSign.SetActive(false);
```















## SceneManagement



```
using UnityEngine.SceneManagement;
```

**直接加载某名字或者某序号的场景**

SceneManager.LoadScene（）

**加载当前场景后一个场景**

 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

 **加载当前场景**

SceneManager.LoadScene(SceneManager.GetActiveScene().name);

SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);





## Physics

### 物理检测



**Physics2D.OverlapCircle**

bool值

```
海盗炸弹是用 Physics2D.OverlapCircle，**圆形检测**

//这里是点的一定范围内有没有对应的层级
        isGround = 
Physics2D.OverlapCircle(groundCheck.position, checkRadius, 1<<8);
```



**Physics2D.OverlapCircleAll（）**

2D的检测

```
//位置点-范围距离-检测所需层级（）

Physics2D.OverlapCircleAll（）
返回一个数组，查询周围对象
物理检测周围物体返回一个数组，或者限制游戏层级
```

**Physics.OverlapSphere（）**

3D的检测

```
var colliders = Physics.OverlapSphere(transform.position,sightRadius);
返回一个数组，查询周围对象
物理检测周围物体返回一个数组，或者限制游戏层级
```



------

或者小狐狸里面的一样，利用触发器，然后IsTouch...检测有没有触碰

 IsTouchingLayers 是否触碰到对应的层级

举例：Ground层级是6

coll.IsTouchingLayers(1<<6）



### 射线检测

Camera直接屏幕坐标发射一条射线

```
Camera.Main.ScreenPointToRay(Input.mousePosition)
```

Camera 屏幕坐标系转世界坐标

```
  
            position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
```

自己new一条射线的情况


















## Gizmos

 /// <summary>
    /// 不需要调用。
    /// </summary>


     public void OnDrawGizmos()
        {
    
      Gizmos.color = Color.blue;
      Gizmos.DrawWireSphere(groundCheck.position, checkRadius);
       }


  选择才显示
    
      private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(transform.position, sightRadius);
        }
## Resources

在Preject面板中Resources文件夹里加载对应资源

```c#
 //泛型加载
GameObject obj = Resources.Load<GameObject>("Prefab/Obj");
Instantiate(obj,transform.position,Quaternion.identity);

 //不建议用这种，多了封箱拆箱，损耗内存
	GameObject obje = Resources.Load("Prefab/Obj") as GameObject;
        Instantiate(obje);
```

## Random

```
 float random_ = Random.Range(patrolRange,-patrolRange);
 
 Random.Value  返回0到1之间的float数
```





## NavMeshAgent

是否在Navmesh上的点

```
   NavMeshHit hit;
        wayPoint = NavMesh.SamplePosition(randomPoint, out hit, patrolRadius, 1) ? hit.position : transform.position;
```











## Dot



//以下是正前方左右各60°的样例

```c#
 float dot = 
     Vector3.Dot(transform.forward,(target.transform.position -transform.position).normalized);

     bool isDot = dot >= 0.5f ? true : false;
```

```
Mathf.Acos(0.5f)*Mathf.Rad2Deg
弧度0.5转角度60
```







## Quaternion

让cube1看齐cube2，但是直接lookAt，使用.LookRotation获取到相差角度是多少， Debug.Log(q.eulerAngles);

```
  Quaternion q = Quaternion.LookRotation(cubes[1].transform.position- cubes[0].transform.position);
        cubes[0].transform.rotation = Quaternion.Lerp(cubes[0].transform.rotation,q,0.1f);
        Debug.DrawLine(cubes[0].transform.position, cubes[1].transform.position);
```

**改变向量方向直接乘以四元数即可 但是需要注意四元数需要在前面，向量在后面**

# UI相关



## OnGUI

```
    GameObject target;
    bool toggle_ = false;
    float verticalValue;
    float scrollBar;
    int isSelect;

    private void OnGUI()
    {
     
        //New Rect前两个参数是屏幕起始点，后两个参数是矩形显示框大小

        //文字显示       
        GUI.Label(new Rect(30, 30, 100, 100), "严满意");
        //屏幕输入文字
		GUI.TextField(new Rect(30, 30, 100, 100), "严满意");

        //按钮显示
        if (GUI.Button(new Rect(100, 30, 50, 50), "按钮"))
        {
            Debug.Log("按下按钮");
        }


        //开关切换
        toggle_ = GUI.Toggle(new Rect(200, 30, 100, 100), toggle_, "开关");



        //滑动条
        verticalValue = GUI.VerticalSlider(new Rect(300, 30, 30, 200), verticalValue, 10, 0);

        //滚动条
        scrollBar = GUI.VerticalScrollbar(new Rect(330, 30, 30, 200), scrollBar, 0.5f, 10, 0);


        //返回一个int，选中的是那个
        isSelect = GUI.Toolbar(new Rect(500, 30, 300, 100), isSelect, new string[] { "Bar01", "Bar02", "Bar03" });



        //OnGUI是左上角为原点的显示，所以在用OnGUI显示（世界坐标转屏幕坐标时候，需要Screen.height-y轴位置，把左下角为原点的显示方式改成左上角OnGUI显示的方式）

        Vector3 pos = Camera.main.WorldToScreenPoint(target.transform.position);
GUI.Label(new Rect(pos.x, Screen.height - pos.y, 100, 100), "text");


    }


```

**GUIStyle**

```
    public GUIStyle uIStyle;
    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 10;
        style.alignment = TextAnchor.UpperCenter;
        style.normal.textColor = Color.green;

        GUI.Label(new Rect (10,10,20,20),"string",style);

        //除了以上方法去修改文字属性，也可以直接创建public变量style在unity界面Inspector里修改对应的属性
        GUI.Label(new Rect (10,30,20,20),"string",uIStyle);
    }
```



































## UI点击不触发其他事情

引用命名空间using UnityEngine.EventSystems;

检测是否点击的是UI

简单做法：

GameObject clickUIEvent = EventSystem.current.currentSelectedGameObject;

此语句的意思是碰到UI返回true，碰到3D objects返回false

完美做法：

```csharp
 if (  EventSystem.current.currentSelectedGameObject != null) {         return; }
```





# 存储

## PlayerPrefs

存在客户端的数据，是键值对方式存在的

```c#
//设置键值和值 
PlayerPerfs.SetInt(“keyInt”,10); 
PlayerPerfs.SetFloat(“keyFloat”,10.2f); 
PlayerPerfs.SetString(“keyString”,”lmzqm”);

   PlayerPrefs.Save();//保存出来

 //获取键值如果不存在该键值就返回默认值0
    PlayerPerfs.GetInt("keyInt",0);
    PlayerPerfs.GetFloat("keyFloat",0);
    PlayerPerfs.GetString("keyString","0");

    PlayerPerfs.DeleteAll();//删除所有键值
    PlayerPerfs.DeleteKey("keyInt");//删除某个键值
    bool exist = PlayerPerfs.HasKey("keyInt");//判断是否存在键值



```











# 其他

## 非空判断简写

 if (targetPoint.GetComponent<BombController>())
  targetPoint.GetComponent<BombController>().TurnOff();

```c#
 //非空判断，作用和上面的一样
targetPoint.GetComponent<BombController>()?.TurnOff();
```

## 声音

```
音效：
1.private AudioSource audioSources;
2.audioSources = gameObject.GetComponent<AudioSource>();
3.audioSources.clip = Resources.Load<AudioClip>("bom");
4.audioSources.Play();

声音管理：通过一个声音管理类，公开声明需要的声音Audio Clip，然后创建不一样的函数方法去给当前的audioSources.clip=所需播放声音。
最后在通过单例去调用这个类里面所需声音的函数。


问题所在：如果需要同时播放两段声音不能这样子，因为只是在同一个AudioSource播放，如果有需要，可以创几个同级物体上，去使用它的声音组件播放
```







# 粒子系统













# 火星时代



## 递归

//递归查找子物体

```c#

    Transform FindChild(string childName, Transform Parent)
    {

        if (childName == Parent.name) return Parent;

        if (Parent.childCount ==0)return null;

        Transform obj = null;

        for (int i = 0; i < Parent.childCount; i++)
        {

            obj = FindChild(childName, Parent.GetChild(i));

            if (obj) break;

        }

        return obj;

    }
```



## 组件介绍

### Camera

```
1.Camera:摄像机组件
Clear Flags：Skybox：天空盒；
		Solid Color：填充颜色，当有空白处，填充背景颜色；
        Depth Only：仅考虑深度；只渲染我需要渲染的层，而且不受其他不渲染层遮挡影响；
	    Don’t Clear：不清除上一帧留下的渲染数据，类似残影效果；

Culling Mask：裁剪层；这里面控制当前摄像机会渲染哪些层的游戏物体，是通过二进制的形式去控制的；

Projection：Perspective：透视摄像机；一般渲染3D场景或者说是3D摄像机，能渲染出z轴值变化效果；
			  Orthographic：正交摄像机，一般渲染2D场景或者2D游戏，游戏物体在z轴运动效果不能显示；

Size/Field of view：摄像机渲染范围大小；

Clipping Planes：Near /far   渲染最近/最远距离；所需要渲染的游戏物体必须在这个范围内，否则不会被渲染；

Viewport Rect：xy：是以屏幕左下角为起始点，按比例来计算当前摄像机渲染画面的位置；			
				 WH：当前摄像机渲染的画面在整个屏幕中大小；
Depth：值越大越后渲染，后渲染的画面覆盖前面渲染的画面；所以值越大，显示越靠前；
```

Camera里面中Target RenderTexturer：

创建 RenderTexture：创建一个新的摄像机，作为渲染当前人物渲染摄像机，当给摄像机Target Texture赋值Rendertexture时，这个摄像机的Depth就会失效，不会跟其他摄像机进行对比渲染到主屏幕；将当前摄像机拍摄到的内容显示到RenderTexture上；















### Light灯光

```c#
Type:
	Directional	平行光
	Spot	聚光灯
	Point	点光源
	Area	区域光
	
Mode:	
	RealTime	实时
	Mix	混合
	Baked	烘焙
	
Intersity	光照强度
Indirect Multiplier	光照强度乘数（漫反射）

Shadow Type：
	NoShadow	没有影子
	HardShadow	硬影子
	SoftShadow	柔和影子
	
Cookie：灯光上贴的一层纸
Drawhalo:辉光
Render Mode:渲染类型

Culling Mask：裁剪层（是否有灯光有效果）
	
	
```



### Rigidbody刚体

```

Mass:质量；
Drag：摩擦力;
Angular Drag:转弯阻力;
Use Gravity:是否使用重力;
Is Kinematic:运动学刚体，当两个刚体发生碰撞，它不会发生位移；
Collision Detection：检测精度：
		Discrete：离散性监测； 
		Continuous：连续性监测；
		Continuous Dynamic：连续动态监测；
		
Constraints：  Freeze Position：锁轴位移
               Freeze Rotation：锁轴旋转
		
Interpolate:如果刚体抖动，none：没有插值运算；
Interpolate：根据上一帧位置做插值运算；
Extrapolate：根据上一帧运动预测下一帧的插值；
```

**AddForce和velocity** 

**addforce是施加力，在update里有加速行为，velocity是给速度，只需要一帧就可以**

力是矢量，有大小有方向；
牛顿第二定律：F = ma
 动量守恒定律：  M1V1  =M2V2 
动量定理：Ft = mv = Impulse冲量



```
F = ma
ForceMode. Acceleration:关注是加速度，所以跟物体的质量不相关；
ForceMode. Force:关注的是力的整体，也就是m*a的值，这时跟物体的质量相关；

Ft = mv
ForceMode. Impulse ：关注的是冲量的整体，也就是m*v的值，这时跟物体的质量相关；
ForceMode. VelocityChange：关注是速度，所以跟物体的质量不相关；

AddRelativeForce自身坐标系，如果里面参数是世界坐标的情况。

```

**AddTorque**

扭矩力

```
 rb.AddTorque(Vector3.forward*50, ForceMode.Impulse);
```



**AddForceAtPosition(Vector3.forward, target.transform.position);**

第一个参数是移动的力，第二个是施加一个当前位置和移动物体的向量值得方向扭矩力

### AudioSource

```
AudioSource：播放声音的组件，音源
Mute：静音
Play On Awake：自动播放；
Loop：循环；
Priority：优先级；
Volume：音量大小；
Pitch：音调高低；

7.AudioListener：监听声音；一般放摄像机上，相当于是耳朵
重要：一个场景内只能有一个这个组件；
8.AudioClip：
Unity支持的音频格式：
		.aiff:适用于较短声音片段；
		.wav: 适用于较短声音片段；
		.mp3、OGG:适合较长的音乐片段；

	Force to mono:强制将多声道音频转换成单声道音频，占用大小会缩小；勾选Normalize之后会对声音有优化；

Load In Background：在后台加载声音；
Load Type：Decompress On Load：以不压缩的形式存在内存，用的时候方便，但是占用内存高；
			Compress in memory:以压缩的形式存在内存，
			Streaming：以流的形式存在内存，使用时现解码；
Preload Audio Data：预加载音频资源；如果勾选进入场景就会马上加载；如果不勾选，第一次使用音频时才会加载进来；

Compression Format：PCM：音频以最高质量进行存储；
					  Vorbis：相对来说压缩的更小；根据质量控制Quality选择；
					  ADPCM：脚步声、武器碰撞的声音；
```

### LineRenderer  

```

Material:划线的材质；
Positions：多个点，划线的点集；
Use World Space：是否使用世界坐标系；
Loop：是否循环，是指第一个点和最后一个点是否形成闭环；
Width：划线的宽度，通过曲线来控制；

corner vertices 拐角圆滑度
```

