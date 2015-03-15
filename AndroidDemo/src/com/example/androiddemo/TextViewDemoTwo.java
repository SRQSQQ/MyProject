/*
 * �ı�demo����2
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
		// TODO �Զ����ɵķ������
		super.onCreate(savedInstanceState);
		setContentView(R.layout.demo_txt2);
		
		TextView textView1 = (TextView) findViewById(R.id.txtTwo_txt1);		
		TextView textView2 = (TextView) findViewById(R.id.txtTwo_txt2);
		TextView textView3 = (TextView) findViewById(R.id.txtTwo_txt3);
		
		//����textView1��ʾ����
		String text = "<�ޱ���><�б���>\n";
		text += "<���ֺ챳��>\n";		
		
		try {
			SpannableString spannableString = new SpannableString(text);
			//���ñ���ɫ
			spannableString.setSpan(new BackgroundColorSpan(Color.BLUE), 5, 10, Spanned.SPAN_EXCLUSIVE_EXCLUSIVE);
			//ͬʱ�����ı��ͱ���ɫ
			spannableString.setSpan(new ColorSpan(Color.BLUE, Color.RED), 11, text.length(), Spanned.SPAN_EXCLUSIVE_EXCLUSIVE);
			
			textView1.setTextSize(15);
			textView1.setText(spannableString);	
			
			//����textView2�м��
			textView2.setLineSpacing(15, 1.2f);
			
			SpannableString spannableString2 = new SpannableString("��һҳ");
			spannableString2.setSpan(new ClickableSpan() {
				
				@Override
				public void onClick(View widget) {
					// TODO �Զ����ɵķ������
					Intent intent = new Intent(TextViewDemoTwo.this, TextViewDemoThree.class);
					startActivity(intent);
				}
			}, 0, 3, Spanned.SPAN_EXCLUSIVE_EXCLUSIVE);
						
			textView3.setText(spannableString2);
			textView3.setMovementMethod(LinkMovementMethod.getInstance());
		} catch (Exception e) {
			// TODO: handle exception
			Log.e("TextViewDemoTwo", "Exception��" + Log.getStackTraceString(e));
		}		
	}
	
	/*
	 * ͬʱ�����ı��ͱ�����ɫ��Span
	 */
	public class ColorSpan extends CharacterStyle {
		private int myTextColor;	//�ı���ɫ
		private int myBackgroundColor;	//������ɫ
		public ColorSpan(int textColor, int backgroundColor) {
			myTextColor = textColor;
			myBackgroundColor = backgroundColor;
		}
		
		@Override
		public void updateDrawState(TextPaint tp) {
			// TODO �Զ����ɵķ������
			tp.bgColor = myBackgroundColor;
			tp.setColor(myTextColor);
		}
	}
}
