using System;
using System.Collections.Generic;

public class PlayerAnimator : BaseAnimator
{
    //-----各种参数-----
    /// <summary>
    /// 控制移动方向的状态机参数，取值只有Left，None，Right。默认状态为None
    /// </summary>
    public string moveDir = "None";
    //-----参数结束-----
    public enum State
    {
        Idle,       //待机
        Walk,       //行走
        Dash,       //冲刺
        Jump,       //跳跃
        Hurt,       //受伤
        ClimbUp,    //向上爬
        ClimbDown,  //向下爬
        JumpUp,     //向上跳
        JumpDown    //向下跳
    }
    public enum AttackState:State
    {
        Attack1,
        Attack2,
        Attack3,
        //以上是基础三连斩
        DashAttack,     //冲刺斩
        JumpAttack,     //基础跳斩
        BoostUpAttack,  //升龙斩
        SpiningAttack   //空中旋转斩击
    }

    public State ReturnCurrentState()
    {
        
    }
}