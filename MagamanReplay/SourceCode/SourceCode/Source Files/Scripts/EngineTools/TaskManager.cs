using System;
using System.Collections.Generic;
using GameNamespace;

/// <summary>
/// 这个脚本充当了引擎与自己编写的脚本的中转站
/// </summary>

public class TaskManager
{
    public class Player
    {
        private PlayerAnimator animator = PlayerAnimator.GetInstance();
    }
    public List enemyPool = new List();
    
}