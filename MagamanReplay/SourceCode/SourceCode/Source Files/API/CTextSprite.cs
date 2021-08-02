using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//////////////////////////////////////////////////////////////////////////////
//
//////////////////////////////////////////////////////////////////////////////

namespace GameNamespace
{
	/// <summary>
	/// �ࣺCSTextSprite
	/// ���־��飬�����ھ����е�һ�֡������÷����ڵ�ͼ��ڷ�һ�������֡����壬�������
	/// Ȼ���ڴ����ﶨ��һ�����־���Ķ���ʵ��������������Ϊ���캯���Ĳ�����Ȼ����ö�Ӧ�ĳ�Ա��������������ʾ����
	/// </summary>
	public class CTextSprite : CSprite
	{
		public	CTextSprite( string szName ) : base(szName)
		{
		}

		/// <summary>
		/// SetTextValue�����־�����ʾĳ����ֵ
		/// ���� iValue��Ҫ��ʾ����ֵ
		/// </summary>
		/// <param name="iValue"></param>
		public	void		SetTextValue( int iValue )
		{
			CommonAPI.dSetTextValue( GetName(),  iValue );
		}

		/// <summary>
		/// SetTextValueFloat�����־�����ʾĳ��������ֵ
		/// ���� fValue��Ҫ��ʾ����ֵ
		/// </summary>
		/// <param name="fValue"></param>
		public	void		SetTextValueFloat( float fValue )
		{
			CommonAPI.dSetTextValueFloat( GetName(),  fValue );
		}

		/// <summary>
		/// SetTextstring�����־�����ʾĳ���ַ�������
		/// ���� szStr��Ҫ��ʾ���ַ���
		/// </summary>
		/// <param name="szStr"></param>
		public	void		SetTextstring( string szStr )
		{
			CommonAPI.dSetTextstring(  GetName(), szStr );
		}
	};
}