/*
 * �ı�demo����1
 */
package com.example.androiddemo;

import java.lang.reflect.Field;
import java.security.PublicKey;

import android.R.integer;
import android.app.Activity;
import android.content.Intent;
import android.graphics.Color;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.text.Html;
import android.text.Html.ImageGetter;
import android.text.SpannableString;
import android.text.Spanned;
import android.text.method.LinkMovementMethod;
import android.text.style.ClickableSpan;
import android.view.Gravity;
import android.view.View;
import android.widget.TextView;

public class TextViewDemo extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO �Զ����ɵķ������
		super.onCreate(savedInstanceState);
		setContentView(R.layout.demo_txt);
		
		TextView textView1 = (TextView) findViewById(R.id.txt1);
		TextView textView2 = (TextView) findViewById(R.id.txt2);
		TextView textView3 = (TextView) findViewById(R.id.txt3);
		TextView textView4 = (TextView) findViewById(R.id.txt4);
		
		//����textView1��ʾ����
		String html = "<font color='red'>Android</font><br>";
		html += "<font color='#0000FF'><big><i>Android</i></big></font><p>";
		html += "<font color='@" + android.R.color.black + "'><tt><b><big><u>Android</u></big></b></tt></font><p>";
		html += "<big><a href='http://www.baidu.com'>�ٶ�һ��</a></big>";
		
		//��htmlת����CharSequence����
		CharSequence charSequence = Html.fromHtml(html);
		//����textView1��ʾ����
		textView1.setText(charSequence);
		//�������޷������������ʾ��ҳ
		textView1.setMovementMethod(LinkMovementMethod.getInstance());
		
		
		//����textView2��ʾ����
		String text = "URL��http://www.baidu.com\n";
		text += "E-mail��srq218@163.com\n";
		text += "�绰��10086\n";
		textView2.setText(text);
		textView2.setMovementMethod(LinkMovementMethod.getInstance());
		
		//����textView3��ʾ����
		String htmlImage = "ͼ��1<img src='image1'/>ͼ��2<img src='image2'/>ͼ��3<a href='http://www.baidu.com'><img src='image3'/></a>";
		
		textView3.setTextColor(Color.BLACK);
		textView3.setBackgroundColor(Color.WHITE);
		textView3.setTextSize(20);
		
		//��htmlת����CharSequence����
		CharSequence charSequenceImage = Html.fromHtml(htmlImage, new ImageGetter() {
			
			@Override
			public Drawable getDrawable(String source) {
				// TODO �Զ����ɵķ������
				Drawable drawable = getResources().getDrawable(getRescourceID(source));
				
				//��image2��С3��
				if (source.equals("image2")) {
					drawable.setBounds(0, 0, drawable.getIntrinsicWidth()/3, drawable.getIntrinsicWidth()/5);
				} else {
					drawable.setBounds(0, 0, drawable.getIntrinsicWidth()/2, drawable.getIntrinsicWidth()/2);
				}
				return drawable;
			}
		}, null);
		
		textView3.setText(charSequenceImage);
		textView3.setMovementMethod(LinkMovementMethod.getInstance());
		
		//��һҳ
		SpannableString spannableString = new SpannableString("��һҳ");
		spannableString.setSpan(new ClickableSpan() {
			
			@Override
			public void onClick(View widget) {
				// TODO �Զ����ɵķ������
				Intent intent = new Intent(TextViewDemo.this, TextViewDemoTwo.class);
				startActivity(intent);
			}
		}, 0, 3, Spanned.SPAN_EXCLUSIVE_EXCLUSIVE);
		
		textView4.setTextSize(20);
		textView4.setGravity(Gravity.CENTER);
		textView4.setText(spannableString);
		textView4.setMovementMethod(LinkMovementMethod.getInstance());
	}

	/*
	 * ͨ��ͼƬ����ȡͼƬ��ԴID
	 */
	public int getRescourceID(String name) {
		try {
			//����ͼƬ����ȡField����
			Field field = R.drawable.class.getField(name);
			//��ȡͼ����ԴID
			return Integer.parseInt(field.get(null).toString());			
		} catch (Exception e) {
			// TODO: handle exception
		}
		return 0;
	}
}
