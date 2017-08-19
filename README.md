# XUI
A UI Framework based at Unity 5.6.2f1 with ugui, also you can use for ngui

## 简介
这是一个UI框架，基于Unity5.6.2f1,Demo中使用ugui，此框架也同样适用于ngui，稍加改动就可以了。


## 文件结构
>Assets<br>
>>	-Prefab<br>
>>>		App.prefab       App入口预设<br>
>>>		UICanvas.prefab  UI画布预设<br>
>>	-Scene<br>
>>>		level.unity      测试场景<br>
>>>		Start.unity      测试场景
>>	-Script<br>
>>>		App.cs  程序入口脚本<br>
>>>		-XTools        XTools工具集<br>
>>>>			MonoSingleton.cs MonoBehavior单例<br>
>>>>			Singleton.cs 普通单例<br>
>>>		-XUI           XUI框架底层<br>
>>>>			BaseUI.cs    UI抽象类<br>
>>>>			UIBase.cs    UI基类<br>
>>>>			UIManager.cs UI管理器
>>      -UI               UI应用层<br>
>>>			-Prefab         UI预设<br>
>>>>			-Resources    UI界面预设与脚本名对应<br>
>>>>>				UIMainMenu.prefab<br>
>>>>>				UITask.prefab<br>
>>>			-Script         每个prefab对应一个以下同名的脚本，脚本基类UIBase<br>
>>>>				UIMainMenu.cs<br>
>>>>				UITask.cs<br>
        
        
##  演示

腾讯视频：https://v.qq.com/x/page/h0539q0iy3y.html
