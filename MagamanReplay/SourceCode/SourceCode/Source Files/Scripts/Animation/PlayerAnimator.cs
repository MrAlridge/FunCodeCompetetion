using System;
using System.Collections.Generic;
using GameNamespace;

public class PlayerAnimator : BaseAnimator<PlayerAnimator>
{
    //-----各种参数-----
    /// <summary>
    /// 控制移动方向的状态机参数，取值只有Left，None，Right。默认状态为None
    /// </summary>
    public string moveDir = "None";
    //-----参数结束-----
    
    /// <summary>
    /// 返回当前状态的字符串
    /// </summary>
    public string ReturnCurrentState()
    {
        return "NULL";
    }
}