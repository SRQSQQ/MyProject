/*
 * 文本demo界面2
 */
package com.example.androiddemo;

import android.app.Activity;
import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.text.SpannableString;
import android.text.Spanned;
import android.text.TextPaint;
import android.text.method.LinkMovementMethod;
import android.text.style.BackgroundColorSpan;
import android.text.style.CharacterStyle;
import android.text.style.ClickableSpan;
import android.util.Log;
import android.view.View;
import android.widget.TextView;

public class TextViewDemoTwo extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO 自动生成的方法存根
		super.onCreate(savedInstanceState);
		setContentView(R.layout.demo_txt2);
		
		TextView textView1 = (TextView) findViewById(R.id.txtTwo_txt1);		
		TextView textView2 = (TextView) findViewById(R.id.txtTwo_txt2);
		TextView textView3 = (TextView) findViewById(R.id.txtTwo_txt3);
		
		//设置textView1显示内容
		String text = "<无背景><有背景>\n";
		text += "<蓝字红背景>\n";		
		
		try {
			SpannableString spannableString = new SpannableString(text);
			//设置背景色
			spannableString.setSpan(new BackgroundColorSpan(Color.BLUE), 5, 10, Spanned.SPAN_EXCLUSIVE_EXCLUSIVE);
			//同时设置文本和背景色
			spannableString.setSpan(new ColorSpan(Color.BLUE, Color.RED), 11, text.length(), Spanned.SPAN_EXCLUSIVE_EXCLUSIVE);
			
			textView1.setTextSize(15);
			textView1.setText(spannableString);	
			
			//设置textView2行间距
			textView2.setLineSpacing(15, 1.2f);
			
			SpannableString spannableString2 = new SpannableString("下一页");
			spannableString2.setSpan(new ClickableSpan() {
				
				@Override
				public void onClick(View widget) {
					// TODO 自动生成的方法存根
					Intent intent = new Intent(TextViewDemoTwo.this, TextViewDemoThree.class);
					startActivity(intent);
				}
			}, 0, 3, Spanned.SPAN_EXCLUSIVE_EXCLUSIVE);
						
			textView3.setText(spannableString2);
			textView3.setMovementMethod(LinkMovementMethod.getInstance());
		} catch (Exception e) {
			// TODO: handle exception
			Log.e("TextViewDemoTwo", "Exception：" + Log.getStackTraceString(e));
		}		
	}
	
	/*
	 * 同时设置文本和背景颜色的Span
	 */
	public class ColorSpan extends CharacterStyle {
		private int myTextColor;	//文本颜色
		private int myBackgroundColor;	//背景颜色
		public ColorSpan(int textColor, int backgroundColor) {
			myTextColor = textColor;
			myBackgroundColor = backgroundColor;
		}
		
		@Override
		public void updateDrawState(TextPaint tp) {
			// TODO 自动生成的方法存根
			tp.bgColor = myBackgroundColor;
			tp.setColor(myTextColor);
		}
	}
}
