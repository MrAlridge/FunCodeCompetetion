using System;

namespace GameNamespace
{
    public enum playerStateSet
    {
        Idle,       //待机
        Walk,       //行走
        Dash,       //冲刺
        Jump,       //跳跃
        Hurt,       //受伤
        ClimbUp,    //向上爬
        ClimbDown,  //向下爬
        JumpUp,     //向上跳
        JumpDown,   //向下跳
        Attack1,
        Attack2,
        Attack3,
        //以上是基础三连斩
        DashAttack,     //冲刺斩
        JumpAttack,     //基础跳斩
        BoostUpAttack,  //升龙斩
        SpiningAttack   //空中旋转斩击
    }
}
