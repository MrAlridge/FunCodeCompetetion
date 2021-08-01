# 前言

由于这个引擎实在是太狗屎了，我只能一个一个API的看，在这里整理一下各个东西是干什么的

-----

## CAnimateSprite.cs -- 管理动态精灵，继承自CSprite.cs

-----

## CEffect.cs -- 管理“特效精灵”，用法应该跟Unity的Partical System差不多

初步推断应该是在摄像机外放置一个模板特效，需要时再生成实例

-----

## CommonAPI.cs -- 像坨屎山一样堆了一堆东西

    1.`public enum EWorldLimit`
Sprite精灵与世界边界碰撞响应定义(碰撞之后API `OnSpriteColWorldLimit` 将被调用)

    2.'public enum ECollisionResponse'
精灵与精灵之间、精灵与地图中其它精灵之间的碰撞响应( 碰撞之后API`OnSpriteColSprite`将被调用 )

    3.`public enum MouseTypes`
鼠标按键的定义

    4.`public enum KeyCodes`
键盘KEY值定义

    5.剩下的基本都是一些基本的函数

-----

## CSound.cs -- 管理声音播放的接口

    `public	class CSound`
里面定义的基本都是各种播放声音的函数

-----

## CSprite.cs -- 又一坨屎山，Sprite的实现及操作

    ```C#
    public class CSprite
    /// <summary>
    /// 类：CSprite
    /// 所有精灵的基类。包括下面的静态精灵，动态精灵，文字，特效等均由此类继承下去
    /// 一般的图片精灵从本类继承下去即可。只有特殊的精灵，比如带动画的精灵，才需要从动态精灵继承下去
    /// </summary>
    ```
