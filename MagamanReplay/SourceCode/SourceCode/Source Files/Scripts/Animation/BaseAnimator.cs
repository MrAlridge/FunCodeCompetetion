using System;
using System.Collections.Generic;

public class BaseAnimator
{
    private static BaseAnimator instance = new BaseAnimator();
    public void Initalize() //初始化
    {

    }
    private BaseAnimator()   //构造函数
    {
        AnimationManager.AddAnimator(instance);
    }
    public static BaseAnimator GetInstance()    //获取单例
    {
        return instance;
    }
    //-----以下是一些工具方法-----
    public static void SetString(string variName, string value)
    {
        
    }
}