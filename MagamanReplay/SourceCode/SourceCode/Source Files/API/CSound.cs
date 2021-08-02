using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/////////////////////////////////////////////////////////////////////////////
//
/////////////////////////////////////////////////////////////////////////////

namespace GameNamespace
{
	/// <summary>
	/// �ࣺCSSound
	/// �����������࣬����һ������ʵ�������ò��ź�������ʵ�������Ĳ���
	/// </summary>
	public	class CSound
	{
		private string		m_szName;	// ������
		private int			m_iSoundId;	// ���沥��������ʱ�򣬷��ص�ID
		private bool		m_bLoop;	// bLoop : �Ƿ�ѭ�����š����Ϊѭ����Ч������CSoundʵ��������ʱ���Զ�����StopSoundֹͣ�������Ĳ���
		private float		m_fVolume;	// ������С��0-1��1Ϊ�����ļ���ԭ����С
	
		/// <summary>
		/// ���캯��
		/// ���� szName��������·�������ƣ�����ֵ���ڱ༭������Դ -> ������������鿴����Ŀ���������Դ�����������Ǹ�·��ֵ��д����
		/// ���� bLoop���Ƿ�ѭ�����š������ѭ�����ŵ���������Ҫ�ֶ�����APIֹͣ����
		/// ���� fVolume��������С��0-1��1Ϊ�����ļ���ԭ����С
		/// </summary>
		public	CSound( string szName,  bool bLoop,  float fVolume )
		{
			m_bLoop		=	bLoop;
			m_fVolume	=	fVolume;
			m_iSoundId	=	0;
			m_szName	=	szName;
		}

		/// <summary>
		/// GetName����ȡ��������
		/// </summary>
		public	string GetName()
		{
			return m_szName;
		}

		/// <summary>
		/// PlaySound�����Ÿ�����
		/// </summary>
		public	void		PlaySound()
		{
			if( m_bLoop && 0 != m_iSoundId )
				StopSound();

			m_iSoundId = CommonAPI.dPlaySound(GetName(), m_bLoop ? 1 : 0, m_fVolume);
		}

		/// <summary>
		/// StopSound��ֹͣ�������Ĳ���
		/// ��ѭ���Ĳ�����֮���Զ�ֹͣ������һ�㲻��Ҫ���ô˺�����ֻ��ѭ������������Ҫ���á�����ѭ����Ч��������������Ҳ���Զ����ô˺��� 
		/// </summary>
		public	void		StopSound()
		{
			CommonAPI.dStopSound( m_iSoundId );

			m_iSoundId = 0;
		}

		/// <summary>
		/// StopAllSound��ֹͣ������������
		/// ��̬�����������Դ��ַ�ʽ���ã�CSound::StopAllSound����ֹͣ��Ϸ���������ڲ��ŵ�����
		/// </summary>
		public	static void	StopAllSound()
		{
			CommonAPI.dStopAllSound();
		}
	};
}