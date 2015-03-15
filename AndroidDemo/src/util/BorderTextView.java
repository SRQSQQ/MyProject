/*
 * 带边框文本框
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
		// TODO 自动生成的构造函数存根
	}

	@Override
	protected void onDraw(Canvas canvas) {
		// TODO 自动生成的方法存根
		super.onDraw(canvas);
		
		Paint paint = new Paint();
		paint.setColor(Color.BLACK);
		
		//绘制上边框
		canvas.drawLine(0, 0, this.getWidth() - 1, 0, paint);
		//绘制左边框
		canvas.drawLine(0, 0, 0, this.getHeight() - 1, paint);
		//绘制右边框
		canvas.drawLine(this.getWidth() - 1, 0, this.getWidth() - 1, this.getHeight() - 1, paint);
		//绘制下边框
		canvas.drawLine(0, this.getHeight() - 1, this.getWidth() - 1, this.getHeight() - 1, paint);
	}

}
