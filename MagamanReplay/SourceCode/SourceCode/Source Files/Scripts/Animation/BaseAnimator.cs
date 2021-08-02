using System;
using System.Collections.Generic;
using GameNamespace;

public class BaseAnimator<T> where T : new()
{
    class AnimatorCreator
    {
        internal static readonly T instance = new T();
    }
    //下面这个暂时弃用，使用网上的单例模式
    //private static BaseAnimator instance = new BaseAnimator();
    public void Initalize() //初始化
    {

    }
    internal BaseAnimator()   //构造函数
    {
        
    }
    public static T GetInstance()    //获取单例
    {
        return AnimatorCreator.instance;
    }
    //-----以下是一些工具方法-----
    public static void SetString(string variName, string value)
    {
        
    }
}