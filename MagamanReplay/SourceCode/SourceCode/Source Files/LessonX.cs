using System;
using GameNamespace;

namespace GameNamespace
{
	/// <summary>
	/// ��Ϸ�ܹ��ࡣ��������Ϸ��ѭ������Ϸ��ʼ���������ȹ���
	/// ����ĳ�������Ϊ��GameMainLoop����Ϊ��ѭ��������������ÿ֡ˢ����Ļͼ��֮�󣬶��ᱻ����һ�Ρ�
	/// </summary>
	public class	CGameMain
	{
		int				    m_iGameState    =   0;				    // ��Ϸ״̬��0���������ߵȴ���ʼ��1����ʼ����2����Ϸ������
		static CGameMain    m_Instance      =   new CGameMain();    // ���ྲ̬ʵ�� 

		/// <summary>
		/// ���캯��
		/// </summary>
		public CGameMain()
		{
		}
		
		// Get����
		int				            GetGameState()						{ return m_iGameState; }
		static public  CGameMain    GetInstance()                       { return m_Instance; }
		
		// Set����
		void SetGameState( int iState )	
		{
			m_iGameState = iState;
		}


		/// <summary>
		/// ��Ϸ��ѭ�����˺���������ͣ�ĵ��ã�����ÿˢ��һ����Ļ���˺�����������һ��
		/// ���Դ�����Ϸ�Ŀ�ʼ�������С������ȸ���״̬. 
		/// ��������fDeltaTime : �ϴε��ñ��������˴ε��ñ�������ʱ��������λ����
		/// </summary>
		public void GameMainLoop( float	fDeltaTime )
		{
			switch( GetGameState() )
			{
				// ��ʼ����Ϸ�������һ���������
			case 1:
				{
					GameInit();
					SetGameState(2); // ��ʼ��֮�󣬽���Ϸ״̬����Ϊ������
				}
				break;

				// ��Ϸ�����У�����������Ϸ�߼�
			case 2:
				{
					// TODO �޸Ĵ˴���Ϸѭ�������������ȷ��Ϸ�߼�
					if( true )
					{
						GameRun( fDeltaTime );
					}
					else // ��Ϸ������������Ϸ���㺯����������Ϸ״̬�޸�Ϊ����״̬
					{				
						SetGameState(0);
						GameEnd();
					}
				}
				break;

				// ��Ϸ����/�ȴ����ո����ʼ
			case 0:
			default:
				break;
			};
		}
		
		/// <summary>
		/// ÿ�ֿ�ʼǰ���г�ʼ���������һ��������� 
		/// </summary>
		void    GameInit()
		{
		}

		/// <summary>
		/// ÿ����Ϸ������
		/// </summary>
		void	GameRun( float fDeltaTime )
		{
		}

		/// <summary>
		/// ������Ϸ����
		/// </summary>
		void	GameEnd()
		{
		}
	}

}
