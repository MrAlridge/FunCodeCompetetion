using System;
using GameNamespace;

/// <summary>
/// 游戏总管类。负责处理游戏主循环、游戏初始化、结束等工作
/// 大体的程序流程为：GameMainLoop函数为主循环函数，在引擎每帧刷新屏幕图像之后，都会被调用一次。
/// </summary>
public class	CGameMain
{
	static int			m_iGameState    =   0;				    // 游戏状态，0：结束或者等待开始；1：初始化；2：游戏进行中
    static CGameMain    m_Instance      =   new CGameMain();    // 本类静态实例 

    /// <summary>
    /// 构造函数
    /// </summary>
    public CGameMain()
    {
    }
    
	// Get方法
	int				            GetGameState()						{ return m_iGameState; }
    static public  CGameMain    GetInstance()                       { return m_Instance; }
	
	// Set方法
	public static void			SetGameState( int iState )			{ m_iGameState	=	iState; }


    /// <summary>
    /// 游戏主循环，此函数将被不停的调用，引擎每刷新一次屏幕，此函数即被调用一次
    /// 用以处理游戏的开始、进行中、结束等各种状态. 
    /// 函数参数fDeltaTime : 上次调用本函数到此次调用本函数的时间间隔，单位：秒
    /// </summary>
    public void GameMainLoop( float	fDeltaTime )
    {
	    switch( GetGameState() )
	    {
		    // 初始化游戏，清空上一局相关数据
	    case 1:
		    {
			    GameInit();
			    SetGameState(2); // 初始化之后，将游戏状态设置为进行中
		    }
		    break;

		    // 游戏进行中，处理各种游戏逻辑
	    case 2:
		    {
			    // TODO 修改此处游戏循环条件，完成正确游戏逻辑
			    if( true )
			    {
				    GameRun( fDeltaTime );
			    }
			    else // 游戏结束。调用游戏结算函数，并把游戏状态修改为结束状态
			    {				
				    SetGameState(0);
				    GameEnd();
			    }
		    }
		    break;

		    // 游戏结束/等待按空格键开始
	    case 0:
	    default:
		    break;
	    };
    }
	
    /// <summary>
    /// 每局开始前进行初始化，清空上一局相关数据 
    /// </summary>
	void    GameInit()
    {
    }

    /// <summary>
    /// 每局游戏进行中
    /// </summary>
	void	GameRun( float fDeltaTime )
    {
		TaskManager.Update();
    }

    /// <summary>
    /// 本局游戏结束
    /// </summary>
	void	GameEnd()
    {
    }
}

