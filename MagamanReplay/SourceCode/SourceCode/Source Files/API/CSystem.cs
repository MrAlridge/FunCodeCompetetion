using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

////////////////////////////////////////////////////////////////////////////////
//
////////////////////////////////////////////////////////////////////////////////
 
namespace GameNamespace
{
	/// <summary>
	/// �ࣺCSSystem
	/// ϵͳ��ع��ܵ���. �������÷��� CSSystem::������();
	/// </summary>
	public	class CSystem
	{
		/// <summary>
		/// CursorOff���ر���겻��ʾ����API���ص�������Windows����꣬���ǵ��ÿ�������API dCursorOn��������꽫һֱ����ʾ
		/// </summary>
		public	static void		CursorOff()
		{
			CommonAPI.dCursorOff();
		}

		/// <summary>
		/// CursorOn�����������ʾ����API dCursorOff�رյ�������¿�����ʾ
		/// </summary>
		public	static void		CursorOn()
		{
			CommonAPI.dCursorOn();
		}

		/// <summary>
		/// IsCursorOn����ǰ����ǿ������ǹرա���Ӧ������API dCursorOff��dCursorOn�������߹رյĲ���
		/// ����ֵ��trueΪ����״̬��falseΪ�ر�״̬
		/// </summary>
		/// <returns></returns>
		public	static bool		IsCursorOn()
		{
			return CommonAPI.dIsCursorOn() == 0 ? false : true;
		}

		/// <summary>
		/// ShowCursor������/��ʾ��ꡣ��APIֻ�����ر����򴰿��ڵ���꣬�ƶ����������ʱ����껹�ǻ���ʾ
		/// ���� bShow��true Ϊ��ʾ��false Ϊ����
		/// </summary>
		/// <param name="bShow"></param>
		public	static void		ShowCursor(  bool bShow )
		{
			CommonAPI.dShowCursor( bShow ? 1 : 0 );
		}
	
		/// <summary>
		/// IsShowCursor����ǰ�������ʾ�������ء���Ӧ������API ShowCursor���ػ�����ʾ�Ĳ���
		/// ����ֵ��trueΪ����״̬��falseΪ�ر�״̬
		/// </summary>
		/// <returns></returns>
		public	static bool		IsShowCursor()
		{
			return CommonAPI.dIsShowCursor() == 0 ? false : true;
		}
		
		/// <summary>
		/// SetWindowTitle�����ô�������/����
		/// ���� szTitle���ǿ��ַ���
		/// </summary>
		/// <param name="szTitle"></param>
		public	static void		SetWindowTitle( string szTitle )
		{
			CommonAPI.dSetWindowTitle( szTitle );
		}

		/// <summary>
		/// ResizeWindow�����Ĵ��ڴ�С
		/// ���� iWidth�����ȣ�����0С�ڵ���1920
		/// ���� iHeight���߶ȣ�����0С�ڵ���1080
		/// </summary>
		/// <param name="iWidth"></param>
		/// <param name="iHeight"></param>
		public	static void		ResizeWindow(int iWidth, int iHeight)
		{
			CommonAPI.dResizeWindow( iWidth, iHeight);
		}

		/// <summary>
		/// Random����ȡһ�����ڵ���0�������
		/// ����ֵ��int����Χ0 - 2147483648
		/// </summary>
		/// <returns></returns>
		public	static int		Random()
		{
			return CommonAPI.dRandom();
		}

		/// <summary>
		/// RandomRange����ȡһ��λ�ڲ���1������2֮��������
		/// ����ֵ��int����ΧiMin - iMax
		/// ���� iMin��С��iMax������
		/// ���� iMax������iMin������
		/// </summary>
		/// <param name="iMin"></param>
		/// <param name="iMax"></param>
		/// <returns></returns>
		public	static int		RandomRange(  int iMin,  int iMax )
		{
			return CommonAPI.dRandomRange( iMin, iMax );
		}

		/// <summary>
		/// CalLineRotation�������������ߵ�ֱ�ߵ���ת�Ƕ�
		/// ����ֵ���Ƕȣ���Χ0 - 360
		/// ���� fStartX����ʼ����X
		/// ���� fStartY����ʼ����Y
		/// ���� fEndX���յ�����X
		/// ���� fEndY���յ�����Y
		/// </summary>
		/// <param name="fStartX"></param>
		/// <param name="fStartY"></param>
		/// <param name="fEndX"></param>
		/// <param name="fEndY"></param>
		/// <returns></returns>
		public	static float	CalLineRotation(  float fStartX,  float fStartY,  float fEndX,  float fEndY )
		{
			return CommonAPI.dCalLineRotation( fStartX, fStartY, fEndX, fEndY );
		}

		/// <summary>
		/// RotationToVectorX������ĳ���Ƕȶ�Ӧ��ֱ��������X����
		/// ���� fRotation���Ƕȣ���Χ0 - 360
		/// ����ֵ ����ֱ��������Xֵ
		/// </summary>
		/// <param name="fRotation"></param>
		/// <returns></returns>
		public	static float	RotationToVectorX(  float fRotation )
		{
			return CommonAPI.dRotationToVectorX( fRotation );
		}

		/// <summary>
		/// RotationToVectorY������ĳ���Ƕȶ�Ӧ��ֱ��������Y����
		/// ���� fRotation���Ƕȣ���Χ0 - 360
		/// ����ֵ ����ֱ��������Yֵ
		/// </summary>
		/// <param name="fRotation"></param>
		/// <returns></returns>
		public	static float	RotationToVectorY(  float fRotation )
		{
			return CommonAPI.dRotationToVectorY( fRotation );
		}

		/// <summary>
		/// DrawLine��������֮�仭һ����
		/// ���� fStartX����ʼ����X
		/// ���� fStartY����ʼ����Y
		/// ���� fEndX���յ�����X
		/// ���� fEndY���յ�����Y
		/// ���� fLineWidth���ߵĴ�ϸ�����ڵ���1
		/// ���� iLayer���������ڵĲ㣬��༭�������õľ���Ĳ㼶��ͬһ�������Χ0 - 31��
		/// ���� iRed, iGreen, iBlue : ��������ԭɫ����ɫֵ����Χ 0 - 255
		/// ���� iAlpha���ߵ�͸���ȣ���Χ0-255. 0Ϊȫ͸����255Ϊ��͸��
		/// </summary>
		public	static void		DrawLine(  float fStartX,  float fStartY,  float fEndX,  float fEndY,  float fLineWidth,  int iLayer,  int iRed,  int iGreen,  int iBlue,  int iAlpha )
		{
			CommonAPI.dDrawLine( fStartX, fStartY, fEndX, fEndY, fLineWidth, iLayer, iRed, iGreen, iBlue, iAlpha );
		}

		/// DrawTriangle����һ��������
		/// ���� fX1,fX2,fX3�����������������X����
		/// ���� fY1,fY2,fY3�����������������Y����
		/// ���� fLineWidth���ߵĴ�ϸ�����ڵ���1
		/// ���� iLayer�������������ڵĲ㣬��༭�������õľ���Ĳ㼶��ͬһ�������Χ0 - 31��
		/// ���� iRed, iGreen, iBlue : ��������ԭɫ����ɫֵ����Χ 0 - 255
		/// ���� iAlpha�������ε�͸���ȣ���Χ0-255. 0Ϊȫ͸����255Ϊ��͸��<summary>
		/// 
		/// </summary>
		public	static void		DrawTriangle(  float fX1,  float fY1,  float fX2,  float fY2,  float fX3,  float fY3,  float fLineWidth,  int iLayer,  int iRed,  int iGreen,  int iBlue,  int iAlpha )
		{
			CommonAPI.dDrawTriangle( fX1, fY1, fX2, fY2, fX3, fY3, fLineWidth, iLayer, iRed, iGreen, iBlue, iAlpha );
		}

		/// <summary>
		/// DrawRect����һ������
		/// ���� fUpperX�����Ͻ�����X
		/// ���� fUpperY�����Ͻ�����Y
		/// ���� fLowerX�����½�����X
		/// ���� fLowerY�����½�����Y
		/// ���� fLineWidth���ߵĴ�ϸ�����ڵ���1
		/// ���� iLayer���þ������ڵĲ㣬��༭�������õľ���Ĳ㼶��ͬһ�������Χ0 - 31��
		/// ���� iRed, iGreen, iBlue : ��������ԭɫ����ɫֵ����Χ 0 - 255
		/// ���� iAlpha�����ε�͸���ȣ���Χ0-255. 0Ϊȫ͸����255Ϊ��͸��
		/// </summary>
		public	static void		DrawRect(  float fUpperX,  float fUpperY,  float fLowerX,  float fLowerY,  float fLineWidth,  int iLayer,  int iRed,  int iGreen,  int iBlue,  int iAlpha )
		{
			CommonAPI.dDrawRect( fUpperX, fUpperY, fLowerX, fLowerY, fLineWidth, iLayer, iRed, iGreen, iBlue, iAlpha );
		}

		/// <summary>
		/// DrawCircle����һ��Բ
		/// ���� fCenterX��Բ������X
		/// ���� fCenterY��Բ������Y
		/// ���� fRadius��Բ�İ뾶
		/// ���� iSegment��Բ����������Χ4-72. ���紫��6�����õ�һ��6���Σ�����Խ��ԽԲ�������ǻ�ͼЧ��Խ��
		/// ���� fLineWidth���ߵĴ�ϸ�����ڵ���1
		/// ���� iLayer����Բ���ڵĲ㣬��༭�������õľ���Ĳ㼶��ͬһ�������Χ0 - 31��
		/// ���� iRed, iGreen, iBlue : ��������ԭɫ����ɫֵ����Χ 0 - 255
		/// ���� iAlpha��Բ��͸���ȣ���Χ0-255. 0Ϊȫ͸����255Ϊ��͸��
		/// </summary>
		public	static void		DrawCircle(  float fCenterX,  float fCenterY,  float fRadius,  int iSegment,  float fLineWidth,  int iLayer,  int iRed,  int iGreen,  int iBlue,  int iAlpha )
		{
			CommonAPI.dDrawCircle( fCenterX, fCenterY, fRadius, iSegment, fLineWidth, iLayer, iRed, iGreen, iBlue, iAlpha );
		}
			
		/// <summary>
		/// GetScreenLeft����ȡ����߽�֮���X����
		/// ����ֵ����߽�X����
		/// </summary>
		/// <returns></returns>
		public	static float	GetScreenLeft()
		{
			return CommonAPI.dGetScreenLeft();
		}

		/// <summary>
		/// GetScreenTop����ȡ����߽�֮�ϱ�Y����
		/// ����ֵ���ϱ߽�Y����
		/// </summary>
		/// <returns></returns>
		public	static float	GetScreenTop()
		{
			return CommonAPI.dGetScreenTop();
		}

		/// <summary>
		/// GetScreenRight����ȡ����߽�֮�ұ�X����
		/// ����ֵ���ұ߽�X����
		/// </summary>
		/// <returns></returns>
		public	static float	GetScreenRight()
		{
			return CommonAPI.dGetScreenRight();
		}

		/// <summary>
		/// GetScreenBottom����ȡ����߽�֮�±�Y����
		/// ����ֵ���±߽�Y����
		/// </summary>
		/// <returns></returns>
		public	static float	GetScreenBottom()
		{
			return CommonAPI.dGetScreenBottom();
		}

		/// <summary>
		/// LoadMap�������³�����ע�⣬�����³�����ʱ�򣬾ɳ��������о��鶼��������ɾ���������������ڳ����д��������Ƴ����ľ��鶼�����ڵ��ñ�API֮ǰ��ɾ����
		/// ���� szName���������֡����½����������ʱ��ȡ�����֣������Сд�ĺ�׺ -- xxx.t2d�����ô�·��
		/// </summary>
		/// <param name="szName"></param>
		public	static void		LoadMap( string szName )
		{
			CommonAPI.dLoadMap( szName );
		}

		//////////////////////////////////////////////////////////////////////////////////////////
		//
		// ����APIΪϵͳAPI�������Լ�����
		//
		//////////////////////////////////////////////////////////////////////////////////////////

		// GetTimeDelta����ȡ���ε��ñ�����֮���ʱ���
		// ����ֵ��float����λ ��
		//
		public	static float	GetTimeDelta()
		{
			return CommonAPI.dGetTimeDelta();
		}
		// EngineMainLoop��������ѭ�������������Լ�����
		//
		public	static bool		EngineMainLoop()
		{
			return CommonAPI.dEngineMainLoop() == 0 ? false : true;
		}
		// InitGameEngine����ʼ�����棬�����Լ�����
		//
		public	static bool		InitGameEngine( string szArgs )
		{
			return CommonAPI.dInitGameEngine2(szArgs) == 0 ? false : true;
		}
		// ShutdownGameEngine���ر����棬�����Լ�����
		//
		public	static void		ShutdownGameEngine()
		{
			CommonAPI.dShutdownGameEngine();
		}
	};
}