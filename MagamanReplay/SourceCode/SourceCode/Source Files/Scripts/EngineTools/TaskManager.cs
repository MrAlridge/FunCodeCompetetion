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
        public static string currentPlayerAnimName = "player_idle";    //当前玩家动画的名字，等动画及做好了一块放进update里获取
        public static float currentPlayerPosX = new float();   //玩家的位置
        public static float currentPlayerPosY = new float();
        public static void Update()
        {
            currentPlayerPosX = CommonAPI.dGetSpritePositionX(currentPlayerAnimName);
            currentPlayerPosY = CommonAPI.dGetSpritePositionY(currentPlayerAnimName);
        }
    }
    public static CTextSprite debugText = new CTextSprite("DEBUG_CurrentPostion");
    
    public static void Update()
    {
        Player.Update();
        debugText.SetTextstring("x: " + Player.currentPlayerPosX.ToString() + "  y: " + Player.currentPlayerPosY.ToString());
        debugText.SetTextValueFloat(Player.currentPlayerPosX);
    }
}