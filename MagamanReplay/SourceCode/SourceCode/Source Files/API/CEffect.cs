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
	/// �ࣺCEffect
	/// ��Ч���飬���ھ����е�һ�֡��÷������־���һ�������ڵ�ͼ��ڷ�һ����Ч��Ϊģ�壬������
	/// Ȼ���ڴ����ﶨ��һ����Ч����Ķ���ʵ������ʹ��
	/// </summary>
	public class CEffect : CSprite
	{
		private string		m_szCloneName;		// �ڵ�ͼ��Ԥ�Ȱڷźõ�������¡����Ч����
		private float		m_fTime;			// ��ѭ����Ч������ʱ����ѭ����Ч��ѭ��ʱ��

		/// <summary>
		/// ���캯��
		/// ���� szCloneName����ͼ��ڷźõ���Ч����
		/// ���� szMyName���µ���Ч���֡�ע�⣺�����ѭ����Ч����ô����һ��ѭ����Ч�Ͷ���һ������ʵ�����ò�ͬ������
		///                �������һ��ͬ����ѭ����Ч�����Ŷ�Σ���ɾ����ʱ�������⡣��ѭ����Ч�������һ��ʵ����β���
		/// ���� fTime����ѭ����Ч������ʱ����ѭ����Ч��ѭ��ʱ��
		/// </summary>
		public CEffect(string szCloneName, string szMyName, float fTime) : base(szMyName)
		{
			m_szCloneName = szCloneName;
			m_fTime = fTime;
		}

		/// <summary>
		/// GetCloneName����ȡ������¡����Ч����
		/// </summary>
		public string GetCloneName()
		{
			return m_szCloneName;
		}

		/// <summary>
		/// GetTime��������Чѭ��ʱ����������ʱ��
		/// </summary>
		public	float		GetTime()
		{
			return m_fTime;
		}

		/// <summary>
		/// PlayEffect������һ����ѭ������Ч���������֮�����Ч�Զ�ɾ��
		/// ���ŷ�ѭ����Ч��ʱ�򣬿���ʹ��һ��CEffect�Ķ���ʵ�������Ŷ����Ч
		/// ���� fPosX�����ŵ�X����
		/// ���� fPosY�����ŵ�Y����
		/// ���� fRotation�����ŵĽǶȳ���
		/// </summary>
		public	void		PlayEffect(  float fPosX,  float fPosY,  float fRotation)
		{
			CommonAPI.dPlayEffect(GetCloneName(), GetTime(), fPosX, fPosY, fRotation);
		}

		/// <summary>
		/// PlayLoopEffect������һ��ѭ����Ч������Ҫ����Ч��ʱ����Ҫ�Լ�����API����ɾ��
		/// ���� fPosX�����ŵ�X����
		/// ���� fPosY�����ŵ�Y����
		/// ���� fRotation�����ŵĽǶȳ���
		/// </summary>
		public	void		PlayLoopEffect(  float fPosX,  float fPosY,  float fRotation)
		{
			CommonAPI.dPlayLoopEffect(GetCloneName(), GetName(), GetTime(), fPosX, fPosY, fRotation);
		}

		/// <summary>
		/// DeleteEffect��ɾ��һ�����ڲ��ŵ���Ч��ֻ��ѭ����Ч����Ҫ�ֶ�ɾ��
		/// </summary>
		public	void		DeleteEffect()
		{
			CommonAPI.dDeleteEffect(GetName());
		}
	};
}
