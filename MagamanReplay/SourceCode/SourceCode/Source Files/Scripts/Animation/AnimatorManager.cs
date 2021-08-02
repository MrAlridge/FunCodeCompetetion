using System;
using System.Collections.Generic;
using GameNamespace;

public class AnimationManager
{
    public List<BaseAnimator> animatorsList = new List<BaseAnimator>(); //这里存放全局所有的动画状态机

    public static void AddAnimator(BaseAnimator inputAnimator)
    {
        animatorsList.Add(inputAnimator);
    }

    public static void StartAllAnimator()
    {
        foreach (BaseAnimator animator in animatorsList)
        {
            animator.Initalize();   //在这里启动动画机的initalize()
        }
    }
}