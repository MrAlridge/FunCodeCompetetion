using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

///////////////////////////////////////////////////////////////////////////////
//
///////////////////////////////////////////////////////////////////////////////

namespace GameNamespace
{
	/// <summary>
	/// CStaticSprite
	/// ��̬����(��̬ͼƬ��ʾ)����CSprite�������̳��������Ȼ�����˼������ƾ���ͼƬ��ʾ�ĺ���
	/// </summary>
	public class CStaticSprite : CSprite
	{
		public	CStaticSprite( string szName ) : base(szName)
		{
		}

		/// <summary>
		/// SetStaticSpriteImage������/���ľ�̬�������ʾͼƬ
		/// ���� szImageName��ͼƬ����
		/// ���� iFrame����ͼƬ����ʾ֡����Ϊ�༭��Ԥ��ͼ����ʾ��1/N����ΧΪ 0 �� N - 1
		/// </summary>
		/// <param name="szImageName"></param>
		/// <param name="iFrame"></param>
		public	void		SetStaticSpriteImage( string szImageName,  int iFrame )
		{
			CommonAPI.dSetStaticSpriteImage( GetName(), szImageName, iFrame );
		}

		/// <summary>
		/// SetStaticSpriteFrame�����þ�̬���鵱ǰͼƬ����ʾ֡��
		/// ���� iFrame����ͼƬ����ʾ֡����Ϊ�༭��Ԥ��ͼ����ʾ��1/N����ΧΪ 0 �� N - 1
		/// </summary>
		/// <param name="iFrame"></param>
		public	void		SetStaticSpriteFrame(  int iFrame )
		{
			CommonAPI.dSetStaticSpriteFrame( GetName(), iFrame );
		}
		
		/// <summary>
		/// GetStaticSpriteImage����ȡ���鵱ǰ��ʾ��ͼƬ����
		/// ����ֵ��ͼƬ����
		/// </summary>
		/// <returns></returns>
		public	string  GetStaticSpriteImage()
		{
			return CommonAPI.dGetStaticSpriteImage( GetName() );
		}
	
		/// <summary>
		/// GetStaticSpriteFrame����ȡ���鵱ǰ��ʾ��ͼƬ֡��
		/// ����ֵ��֡��
		/// </summary>
		/// <returns></returns>
		public	int			GetStaticSpriteFrame()
		{
			return CommonAPI.dGetStaticSpriteFrame( GetName() );
		}
	};
}