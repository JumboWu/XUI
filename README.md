# XUI
A UI Framework based at Unity 5.6.2f1 with ugui, also you can use for ngui

## 简介
这是一个UI框架，基于Unity5.6.2f1,Demo中使用ugui，此框架也同样适用于ngui，稍加改动就可以了。


## 文件结构
>Assets
>>   -Prefab
>>>      App.prefab       App入口预设
>>>      UICanvas.prefab  UI画布预设
>>   -Scene
>>>      level.unity      测试场景
>>>      Start.unity      测试场景 
>>   -Script
>>>      App.cs  程序入口脚本
>>>      -XTools        XTools工具集
>>>>        MonoSingleton.cs MonoBehavior单例
>>>>        Singleton.cs 普通单例
>>>      -XUI           XUI框架底层
>>>>        BaseUI.cs    UI抽象类
>>>>        UIBase.cs    UI基类
>>>>        UIManager.cs UI管理器
>>   -UI               UI应用层
>>>     -Prefab         UI预设
>>>>       -Resources    UI界面预设与脚本名对应
>>>>>         UIMainMenu.prefab
>>>>>         UITask.prefab
>>>     -Script         每个prefab对应一个以下同名的脚本，脚本基类UIBase
>>>>        UIMainMenu.cs
>>>>        UITask.cs
        
        
##  演示

腾讯视频：https://v.qq.com/x/page/h0539q0iy3y.html
