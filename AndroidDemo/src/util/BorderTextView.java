/*
 * ���߿��ı���
 */
package util;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.util.AttributeSet;
import android.widget.TextView;

public class BorderTextView extends TextView {

	public BorderTextView(Context context, AttributeSet attrs) {
		super(context, attrs);
		// TODO �Զ����ɵĹ��캯�����
	}

	@Override
	protected void onDraw(Canvas canvas) {
		// TODO �Զ����ɵķ������
		super.onDraw(canvas);
		
		Paint paint = new Paint();
		paint.setColor(Color.BLACK);
		
		//�����ϱ߿�
		canvas.drawLine(0, 0, this.getWidth() - 1, 0, paint);
		//������߿�
		canvas.drawLine(0, 0, 0, this.getHeight() - 1, paint);
		//�����ұ߿�
		canvas.drawLine(this.getWidth() - 1, 0, this.getWidth() - 1, this.getHeight() - 1, paint);
		//�����±߿�
		canvas.drawLine(0, this.getHeight() - 1, this.getWidth() - 1, this.getHeight() - 1, paint);
	}

}
